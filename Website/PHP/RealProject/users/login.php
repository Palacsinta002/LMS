<?php
####################  This file handle the /login request  ####################
function login(){
    require_once __DIR__ . "/../InputMethods.php";
    require_once __DIR__ . "/../classes/userClass.php";
    

    $decoded = getPostBody();
    
    $decoded["username"] ??  errorOutput("8");
    $decoded["password"] ??  errorOutput("9");
    
    new UserClass($decoded["username"],$decoded["password"]);

}

?>