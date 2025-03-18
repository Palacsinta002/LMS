<?php
# This file handle the /UploadImg request

function uploadimg(){
    require_once __DIR__ . "/../InputMethods.php";
    require_once __DIR__ . "/../config/connect.php";
    if ($_SERVER["REQUEST_METHOD"] == "POST"){
        $img = $_FILES["image"] ?? errorOutput("16");
        if (explode( ".", basename($img["name"]))[1] == "png" 
        || explode( ".", basename($img["name"]))[1] == "jpg" 
        && move_uploaded_file($img["tmp_name"], __DIR__ . "/../booksImages". "/" .basename($img["name"]))){}
        else {
            errorOutput("16");
        }
       
    }
    else{
        errorOutput("17");
    }
}

