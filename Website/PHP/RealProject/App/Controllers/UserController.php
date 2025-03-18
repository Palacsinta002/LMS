<?php
namespace App\Controllers;
use App\Models\User;
use Database\Queries\UserTable;
use Helper\Helper;
use App\Authorize\Token;
use ApiResponse\Response;
use Emailer\SendEmail;

class UserController{
    public static function login(){
        $body = Helper::getPostBody();
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

    public static function register(){
        
        $body = Helper::getPostBody();
        $body = Helper::validateTheInputArray($body);
        if (!($body = User::checkRequiredData($body,["email","username","password","passwordAgain","firstname","lastname","address"]))){
            Response::httpError(400,21);
        }
        
        User::checkEmail($body["email"]);
        User::checkFirstLastName($body["firstname"]);
        User::checkFirstLastName($body["lastname"]);
        $body["password"] = User::checkPassword($body["password"],$body["passwordAgain"]);
        User::checkUsername($body["username"]);
        $verificationCode = User::createAuthCode();
        $body["EmailVerificationCode"] = $verificationCode;
        UserTable::insertToUser($body);

        SendEmail::sendEmail($body["email"],"New user","Verification Email","your verification code is: " . $verificationCode);
        Response::httpSuccess(200,"User created");
    }

    public static function verifyAccount(){
        
        $body = Helper::getPostBody();
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

    public static function userData(){
        $body = Helper::getPostBody();
        $body = Helper::validateTheInputArray($body);
        if (!($body = User::checkRequiredData($body,["ID"]))){
            Response::httpError(400,21);
        }
        User::validateID($body["ID"]);

        Response::httpSuccess(200,UserTable::selectUserData($body["ID"]));
    }

    public static function updateUser(){
        $body = Helper::getPostBody();
        $body = Helper::validateTheInputArray($body);
        if (!($body = User::checkRequiredData($body,["ID"],["username","passwordOld","password","firstname","lastname","address"]))){
            Response::httpError(400,21);
        }
        User::validateID($body["ID"]);
        if (!isset((($userCurentData = UserTable::selectUserData($body["ID"]))[0]))){
            Response::httpError(400,27);
        };
        $userCurentData= $userCurentData[0];
        $userPassword = UserTable::selectByUsername($userCurentData["username"])[0]["password"];
        User::callingValidateFunctions($body,["username"],User::class,"checkUsername");
        User::callingValidateFunctions($body,["firstname"],User::class,"checkFirstLastName");
        User::callingValidateFunctions($body,["lastname"],User::class,"checkFirstLastName");
        User::callingValidateFunctions($body,["passwordOld","password"],User::class,"checkPassword");
        User::callingValidateFunctions($body,["address"],User::class,"validateAddress");
        if ((isset($body["passwordOld"]) && !isset($body["password"])) || (!isset($body["passwordOld"]) && isset($body["password"]))){
            Response::httpError(400,21);
        }
        if (isset($body["passwordOld"]) && isset($body["password"]) ){
            User::userPasswordIsMatch($body["passwordOld"],$userPassword);
            $body["password"] = password_hash($body["password"], PASSWORD_BCRYPT);
            unset($body["passwordOld"]);
        }
        $ID = $body["ID"];
        unset($body["ID"]);
        $types = User::makeTypesArray($body,["username","password","firstname","lastname","address"],["s","s","s","s","s"]);
        UserTable::updateUserData($ID,array_keys($body),array_values($body),$types);
        Response::httpSuccess(200,"User updated");
        
    }
    public static function deleteUser($ID){
        $body = Helper::getPostBody();
        $body = Helper::validateTheInputArray($body);
        if (!($body = User::checkRequiredData($body,["ID"]))){
            Response::httpError(400,21);
        }
        if (!isset((($userCurentData = UserTable::selectUserData($body["ID"]))[0]))){
            Response::httpError(400,27);
        };
        User::validateID($body["ID"]);
        UserTable::deleteUserRow($ID);
        Response::httpSuccess(200,"User deleted");
    }
}


?>