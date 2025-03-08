<?php
####################  This file is a helper file for the rest of the .php files.   ####################

require 'vendor/autoload.php';

use Firebase\JWT\JWT;
use Firebase\JWT\Key;


####################  This is a simple validate function. Require before making any queries  ####################
function validateTheInput($input)
{
    $input = htmlspecialchars($input);
    $input = stripcslashes($input);
    $input = trim($input);
    return $input;
}
####################  Logging out the error. The error codes are in the errorCodes.txt file.   ####################
function errorOutput($errorCode){
    echo json_encode(["error" => "$errorCode"]);
    die();
}
####################  Gets the content of the request  ####################
function getPostBody(){
    $rawbody = file_get_contents("php://input");
    $decoded = json_decode($rawbody, true);
    return $decoded;
}

####################  Making an api endpoints  ####################
function makePostApiEndpoints($endpoints, $uri, $folder){
    for ($i=0; $i < count($endpoints); $i++) { 
        for ($j= 0; $j < count($endpoints[$i]); $j++){
            if ($uri[count($uri)-1] == $endpoints[$i][$j]){
                require_once __DIR__ . "/" . $folder[$i] . "/" . $endpoints[$i][$j].".php";
                call_user_func($endpoints[$i][$j]);
                die();
            }
        }
        
        
    }
    errorOutput("18");
    
}

####################  Delete from list and reseting its keys  ####################
function deleteFromList($list,$index){
    for ($i= $index; $i < count($list)-1; $i++){
        $list[$i] = $list[$i+1];
    }
    unset($list[count($list)-1]);
    return $list;
}

####################  Make a token with HS256 hash key and with the secret key  ####################

function makeToken($secretKey,$username,$userID) {
    $payload = [
        "sub" => $username,
        "iss" => "http://localhost:5173",
        "iat" => time(),
        "exp" => time() + 3600,
        "user_id" => $userID
    ];
    return JWT::encode($payload, $secretKey, 'HS256');
    }

####################  Decode the token by the secret key and HS256 hash  ####################
function decodeToken($token,$secretKey){
    try {
        $decoded = JWT::decode($token, new Key($secretKey, 'HS256'));
        echo json_encode(["Token" => "valid"]);
    } catch (Exception $e) {
        echo json_encode(["Invalid Token: " => $e->getMessage()]);
    }
}
?>