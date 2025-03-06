<?php
####################  This file is a helper file for the rest of the .php files.   ####################


####################  This is a simple validate function. Require before making any queries  ####################
function validateTheInput($input)
{
    $input = htmlentities($input);
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
        echo $uri[count($uri)-1];
        if ($uri[count($uri)-1] == $endpoints[$i]){
            require_once __DIR__ . "/$folder" . "/" . $endpoints[$i].".php";
            call_user_func($endpoints[$i]);
        }
        
    }
    errorOutput("0");
    
}

?>