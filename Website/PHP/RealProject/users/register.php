<?php
####################  This file handle the /register request  ####################
function register(){
    require_once __DIR__ . "/../classes/userRegisterClass.php";
    require_once __DIR__ . "/../InputMethods.php";
    ####################  unpacking the post request body  ####################
    $decoded = getPostBody();

    ####################  making class and verify the given data  ####################
    $user = new UserRegisterClass(isset($decoded["email"])?$decoded["email"]: "",isset($decoded["username"])?$decoded["username"]:"",isset($decoded["firstname"])? $decoded["firstname"]: "",isset($decoded["lastname"])?$decoded["lastname"]:"",isset($decoded["password"])?$decoded["password"]:"",isset($decoded["passwordAgain"])?$decoded["passwordAgain"]:"");
    $user->sendVerificationEmail();

}

