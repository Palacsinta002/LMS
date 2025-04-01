<?php
namespace App\Controllers;
use App\Models\User;
use Database\Queries\UserTable;
use Helper\Helper;
use App\Authorize\Token;
use ApiResponse\Response;
use Emailer\SendEmail;
use Emailer\EmailBodies;
class UserController{
    public static function login($body){
        $body = Helper::validateTheInputArray($body);
        if (!($body = User::checkRequiredData($body,["username","password"]))){
            Response::httpError(400,21);
        }
        $id = User::loginAuth($body["username"], $body["password"]);
        Response::httpSuccess(200,["Token" => Token::makeToken($id,$body["username"])]);
        
    }

    public static function veifyUser(){
        $body = Helper::getPostBody();
        echo Token::verifyToken($body["token"]);
    }

    public static function register($body){
        
        $body = Helper::validateTheInputArray($body);
        if (!($body = User::checkRequiredData($body,["email","username","password","passwordAgain","firstname","lastname","address"]))){
            Response::httpError(400,21);
        }
        
        User::checkEmail($body["email"]);
        User::checkFirstLastName($body["firstname"]);
        User::checkFirstLastName($body["lastname"]);
        User::validateAddress($body["address"]);
        $body["password"] = User::checkPassword($body["password"],$body["passwordAgain"]);
        User::checkUsername($body["username"]);
        $verificationCode = User::createAuthCode();
        $body["EmailVerificationCode"] = $verificationCode;
        UserTable::insertToUser($body);

        SendEmail::sendEmail($body["email"],"New user","Verification Email",EmailBodies::verifyEmail($verificationCode));
        Response::httpSuccess(200,["Success" =>"User created"]);
    }

    public static function verifyAccount($body){

        $body = Helper::validateTheInputArray($body);
        if (!($body = User::checkRequiredData($body,["verificationCode"]))){
            Response::httpError(400,21);
        }
        User::checkAuthCode($body["verificationCode"]);
        User::updateToVerified($body["verificationCode"]);
        
    }

    public static function allUsers(){
        Response::httpSuccess(200,UserTable::numberOfUsers());
    }

    public static function userData($body,$userID= null){
        $body = Helper::validateTheInputArray($body);
        User::validateID($userID);

        Response::httpSuccess(200,UserTable::selectUserData($userID));
    }

    public static function updateUser($body,$userID = null){

        $body = Helper::validateTheInputArray($body);
        $body = User::removeNullValues($body);
        if (!($body = User::checkRequiredData($body,[],["username","passwordOld","password","firstname","lastname","address"]))){
            Response::httpError(400,21);
        }
        User::validateID($userID);
        if (!isset((($userCurentData = UserTable::selectUserData($userID))[0]))){
            Response::httpError(400,27);
        };
        $userCurentData= $userCurentData[0];
        $userPassword = UserTable::selectByUsername($userCurentData["username"])[0]["password"];
        User::callingValidateFunctions($body,["username"],User::class,"checkUsername");
        User::callingValidateFunctions($body,["firstname"],User::class,"checkFirstLastName");
        User::callingValidateFunctions($body,["lastname"],User::class,"checkFirstLastName");
        User::callingValidateFunctions($body,["password"],User::class,"checkPassword");
        User::callingValidateFunctions($body,["address"],User::class,"validateAddress");
        if ((isset($body["passwordOld"]) && !isset($body["password"])) || (!isset($body["passwordOld"]) && isset($body["password"]))){
            Response::httpError(400,21);
        }
        if (isset($body["passwordOld"]) && isset($body["password"]) ){
            User::userPasswordIsMatch($body["passwordOld"],$userPassword);
            $body["password"] = password_hash($body["password"], PASSWORD_BCRYPT);
            unset($body["passwordOld"]);
        }

        $types = User::makeTypesArray($body,["username","password","firstname","lastname","address"],["s","s","s","s","s"]);
        UserTable::updateUserData($userID,array_keys($body),array_values($body),$types);
        Response::httpSuccess(200,["Success" =>"User updated"]);
        
    }
    public static function deleteUser($body,$userID){

        if (!isset((($userCurentData = UserTable::selectUserData($userID))[0]))){
            Response::httpError(400,27);
        };
        User::validateID($userID);
        UserTable::deleteUserRow($userID);
        Response::httpSuccess(200,["Success" => "User deleted"]);
    }

    public static function forgotPassword($body){
        $body = Helper::validateTheInputArray($body);
        if (!($body = User::checkRequiredData($body,["email"],))){
            Response::httpError(400,21);
        }
        User::validateEmail($body["email"]);
        if (($user = UserTable::selectByEmail($body["email"],false))->num_rows == 0){
            Response::httpError(400,0);
        };
        $data = $user->fetch_assoc();
        $token = Token::makeToken($data["id"],$data["username"],900);
        SendEmail::sendEmail($body["email"],$data["username"],"Forgot password",EmailBodies::forgotPassword($data["username"],$token));
        Response::httpSuccess(200,["Success"=> "Email sent"]);

    }
    public static function changePassword($body,$userID){
        $body = Helper::validateTheInputArray($body);
        if (!($body = User::checkRequiredData($body,["password","passwordAgain"]))){
            Response::httpError(400,21);
        }
        $newPasswordHash = User::checkPassword($body["password"],$body["passwordAgain"]);
        UserTable::changePassword($newPasswordHash,$userID);
        Response::httpSuccess(200,["Success"=> "Password updated"]);
    }
    public static function finalizeRegistration($body){
        $body = Helper::validateTheInputArray($body);
        
        if (!($body = User::checkRequiredData($body,["email","username","password"]))){
            Response::httpError(400,21);
        }
        
        User::checkEmail($body["email"]);
        $id = User::loginAuth($body["username"],$body["password"],false);
        $user = UserTable::selectUserData($id)[0];
        if (isset($user["email"])){
            Response::httpError(400,34);
        }
   
        $verificationCode = User::createAuthCode();
        SendEmail::sendEmail($body["email"],"New user","Verification Email",EmailBodies::verifyEmail($verificationCode));
        UserTable::updateUserData($id,["email","EmailVerificationCode"],[$body["email"],$verificationCode],["s","i"]);
        Response::httpSuccess(200,["Success"=> "Email sent"]);
    }
}


?>