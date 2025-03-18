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
        if (!($body = User::checkRequiredData($body,["email","username","password","passwordAgain","firstname","lastname"]))){
            Response::httpError(400,21);
        }
        
        User::checkEmail($body["email"]);
        User::checkFirstLastName($body["firstname"]);
        User::checkFirstLastName($body["lastname"]);
        $body["password"] = User::checkPassword($body["password"],$body["passwordAgain"]);
        User::checkUsername($body["username"]);
        $verificationCode = User::createAuthCode() ;
        
        UserTable::insertToUser(...$body);

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
}


?>