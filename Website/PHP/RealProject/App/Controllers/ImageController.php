<?php

namespace App\Controllers;

use App\Validations\Image;
use ApiResponse\Response;
class ImageController {
    public static function uploadImg(){
        $img = $_FILES["image"] ?? Response::httpError(400,16);
        Image::validateImage($img);
        move_uploaded_file($img["tmp_name"], __DIR__ . "/../../booksImages". "/" .basename($img["name"]));
    }
    public static function getImg($img){
        Image::validateISBN($img);
        $imgPath = __DIR__ . "/../../booksImages/". $img . ".";
        Image::checkForValidFile($imgPath);
        header('Content-Type: ' . mime_content_type(__DIR__ . "/../../booksImages/missing.png"));
        readfile(__DIR__ . "/../../booksImages/missing.png");
        die();
    }
}
?>