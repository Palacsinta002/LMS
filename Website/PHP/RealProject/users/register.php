<?php

function register(){
    require_once __DIR__ . "/../connect.php";
    //$email,$username,$firstName,$lastName,$password,$password2
    $rawbody = file_get_contents("php://input");
    $decoded = json_decode($rawbody, true);

}


?>