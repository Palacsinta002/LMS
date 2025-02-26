<?php
# This file handle the /UploadImg request
header("Content-Type: Application/json");
header("Access-Control-Allow-Origin: *");
header("Access-Control-Allow-Methods: POST, OPTIONS");
header("Access-Control-Allow-Headers: Content-Type,Authorization");
header("Access-Control-Allow-Credentials: true");
require_once __DIR__ . "/InputMethods.php";
require_once __DIR__ . "/config/connect.php";
if ($_SERVER["REQUEST_METHOD"] == "POST"){
    $img = $_FILES["image"] ?? errorOutput("16");
    if (move_uploaded_file($img["tmp_name"], __DIR__ . "/booksImages". "/" .basename($img["name"]))){
        echo json_encode(["ImgUrl" => "http://localhost". $_SERVER["REQUEST_URI"] . "/booksImages" . "/" .basename($img["name"])]);
    }
    else {
        errorOutput("16");
    }
   
}
else{
    errorOutput("17");
}