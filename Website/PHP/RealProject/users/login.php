<?php
####################  This file handle the /login request  ####################
function login(){
    require_once __DIR__ . "/../InputMethods.php";
    require_once __DIR__ . "/../classes/userClass.php";
    $rawbody = file_get_contents("php://input");
    $decoded = json_decode($rawbody, true);
    $decoded["username"] ??  errorOutput("8");
    $decoded["password"] ??  errorOutput("9");
    
    $alma = new UserClass($decoded["username"],$decoded["password"]);
}

?>