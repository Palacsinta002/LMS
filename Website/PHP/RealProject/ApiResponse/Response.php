<?php

namespace ApiResponse;

class Response{
    
    public static function httpError( $code, $message ){
        header("Content-Type: application/json");
        http_response_code($code);
        if (!preg_match("/^[0-9]+$/", $message)) {
            echo json_encode([
                "error" => $message
            ]);
            die();
        }
        $lines = file("errorCodes.txt", FILE_IGNORE_NEW_LINES);
        echo json_encode([
            "error" => substr($lines[$message],strpos($lines[$message],"!")+1)
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