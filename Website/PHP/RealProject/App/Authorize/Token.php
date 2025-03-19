<?php

namespace App\Authorize;
use Firebase\JWT\JWT;
use Config\Env;
use ApiResponse\Response;
use Firebase\JWT\Key;
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
            if (strpos($token, 'Bearer ') == 0) {
                $token = substr($token, 7);
            }
            Env::load();
            $token = JWT::decode($token,new Key($_ENV["JWT_KEY"],"HS256"));
            return $token->userID;
            
        }
        catch(\Exception $e){
            Response::httpError(200, 31);
        
        }
    }
}


?>