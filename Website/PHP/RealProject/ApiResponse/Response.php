<?php

namespace ApiResponse;

class Response{
    
    public static function httpError( $code, $messageCode ){
        header("Content-Type: application/json");
        http_response_code($code);
        $lines = file("errorCodes.txt", FILE_IGNORE_NEW_LINES);
        echo json_encode([
            "error" => substr($lines[$messageCode],strpos($lines[$messageCode],"!")+1)
        ]);
        die();
    }
    public static function httpSuccess($code,$json ){
        header("Content-Type: application/json");
        http_response_code($code);
        echo json_encode($json);
        die();
    }
}

?>