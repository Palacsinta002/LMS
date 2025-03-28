<?php
namespace App\Controllers;
use App\Models\User;
use Database\Queries\UserTable;
use Helper\Helper;
use App\Authorize\Token;
use ApiResponse\Response;
use Emailer\SendEmail;

class UserController{
    public static function login($body){
        $body = Helper::validateTheInputArray($body);
        if (!($body = User::checkRequiredData($body,["username","password"]))){
            Response::httpError(400,21);
        }
        $id = User::loginAuth($body["username"], $body["password"]);
        if (is_array($id)){
            Response::httpSuccess(200,["Token" => Token::makeToken($id,$body["username"]), "isRegistered" => false]);
        }
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
        $bodyOfHtml = "<html>
            <body style='font-family: Arial, sans-serif; background-color: #f4f4f4; margin: 0; padding: 20px;'>
                <div style='max-width: 600px; background: #ffffff; padding: 20px; border-radius: 10px; box-shadow: 0 0 10px rgba(0, 0, 0, 0.1); margin: auto;'>
                    <div style='text-align: center; font-size: 22px; color: #333; font-weight: bold;'>Email Verification</div>
                    <div style='margin-top: 20px; font-size: 16px; color: #555;'>
                        <p>Thank you for registering with us! Please use the verification code below to verify your email address:</p>
                        <div style='display: block; width: fit-content; margin: 20px auto; font-size: 24px; font-weight: bold; background: #007bff; color: white; padding: 12px 20px; border-radius: 5px; letter-spacing: 2px;'>
                            ".$verificationCode."
                        </div>
                        <p>If you did not request this, please ignore this email.</p>
                    </div>
                    <div style='font-size: 12px; text-align: center; color: #999; margin-top: 20px;'>
                        <p>If you have any concerns, please contact our support team.</p>
                        <p>Thank you, <br> LMS</p>
                    </div>
                </div>
            </body>
        </html>";
        SendEmail::sendEmail($body["email"],"New user","Verification Email",$bodyOfHtml);
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
        User::callingValidateFunctions($body,["password","passwordOld"],User::class,"checkPassword");
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
        $bodyOfHtml = "<html>
        <body style='font-family: Arial, sans-serif; background-color: #f4f4f4; margin: 0; padding: 20px;'>
            <div style='max-width: 600px; background: #ffffff; padding: 20px; border-radius: 10px; box-shadow: 0 0 10px rgba(0, 0, 0, 0.1); margin: auto;'>
                <div style='text-align: center; font-size: 22px; color: #333; font-weight: bold;'>Password Reset Request</div>
                <div style='margin-top: 20px; font-size: 16px; color: #555;'>
                    <p>Hello, ".$data["username"]."</p>
                    <p>A password reset request was made for your account. If you initiated this request, please click the button below to reset your password:</p>
                    <a href='http://localhost:5173/change-password/$token' style='display: block; width: 200px; text-align: center; background: #007bff; color: white; padding: 12px; border-radius: 5px; text-decoration: none; font-weight: bold; margin: 20px auto;'>Reset Password</a>
                    <p>If you did not request this, please ignore this email. Your account remains secure.</p>
                    <p>For security reasons, this link will expire in 15 minutes.</p>
                </div>
                <div style='font-size: 12px; text-align: center; color: #999; margin-top: 20px;'>
                    <p>If you have any concerns, please contact our support team.</p>
                    <p>Thank you, <br> LMS</p>
                </div>
            </div>
        </body>
        </html>";
        SendEmail::sendEmail($body["email"],$data["username"],"Forget password",$bodyOfHtml);
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
}


?>