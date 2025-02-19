<?php
####################  This file handle the /register request  ####################
function register(){
    require_once __DIR__ . "/../classes/userRegisterClass.php";
    require_once __DIR__ . "/../InputMethods.php";
    ####################  unpacking the post request body  ####################
    $rawbody = file_get_contents("php://input");
    $decoded = json_decode($rawbody, true);

    ####################  making class and verify the given data  ####################
    $user = new UserRegisterClass($decoded["email"],$decoded["username"],$decoded["firstname"],$decoded["lastname"],$decoded["password"],$decoded["passwordAgain"]);
    $user->sendVerificationEmail();
}

?>