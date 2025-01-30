<?php
function validateTheInput($input)
{
    $input = htmlentities($input);
    $input = stripcslashes($input);
    $input = trim($input);
    return $input;
}
function errorOutput($errorCode){
    echo json_encode(["error" => "$errorCode"]);
    die();
}

function getPostBody(){
    $rawbody = file_get_contents("php://input");
    $decoded = json_decode($rawbody, true);
    return $decoded;
}

?>