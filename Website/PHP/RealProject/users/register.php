<?php

function register(){
    require_once __DIR__ . "/../classes/userRegisterClass.php";
    //$email,$username,$firstName,$lastName,$password,$password2
    $rawbody = file_get_contents("php://input");
    $decoded = json_decode($rawbody, true);
    $user = new UserRegisterClass($decoded["email"],$decoded["username"],$decoded["firstname"],$decoded["lastname"],$decoded["password"],$decoded["password2"]);
    $user->sendVerificationEmail();
}

?>