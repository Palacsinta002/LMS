<?php

namespace App\Authorize;
use Firebase\JWT\JWT;
use Config\Env;
class Token{

    public static function makeToken($userid,$username){
        Env::load();
        $payload = [
            "sub"=> $username,
            "iss" => "http://localhost/5173",
            "iat" => time(),
            "exp" => time() + 3600,
            "userID"=> $userid,
        ];
        return JWT::encode($payload, $_ENV["JWT_KEY"], "HS256");
    }
    public static function verifyToken($token){
        try {
            Env::load();
            $token = JWT::decode($token,$_ENV["JWT_KEY"]);
            return json_encode(["token" => $token]);
        }
        catch(\Exception $e){
            return $e->getMessage();
        }
    }
}


?>