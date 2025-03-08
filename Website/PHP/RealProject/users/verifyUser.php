<?php

function verifyUser(){
    require_once __DIR__ . "/../InputMethods.php";
    $config = include_once __DIR__ . "/../config/config.php";
    $JWT_KEY = $config["JWT_KEY"];
    $postBody = getPostBody();
    decodeToken($postBody["token"],$JWT_KEY);
    
}

?>