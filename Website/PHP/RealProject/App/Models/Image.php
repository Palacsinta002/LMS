<?php

namespace App\Models;

use ApiResponse\Response;
class Image extends Model{
    public static function validateImage($img){
        if (empty($img['tmp_name']) || !file_exists($img["tmp_name"])) {
            Response::httpError(400, 16);
        }

        $imageInfo = getimagesize($img["tmp_name"]);
        if ($imageInfo == false) {
            Response::httpError(400,28);
        }
        
        $fileType = explode("/", $img["type"]);
        self::validateExtentions($fileType);
        if ($img["size"] > 70 * 1024 * 1024){
            Response::httpError(400,28);
        }
        return true;
           
    }

    public static function validateExtentions($fileType){
        $allowedTypes = ["png", "jpg", "jpeg"];
        if ($fileType[0] != "image" || !in_array($fileType[1], $allowedTypes)){
            Response::httpError(400,28);
        }
    }
    public static function checkForValidFile($imgPath){
        $allowedTypes = ["png", "jpg", "jpeg"];
        foreach ($allowedTypes as $extention) {
            if (file_exists($imgPath . $extention)) {
                header('Content-Type: ' . mime_content_type($imgPath . $extention));
                readfile($imgPath . $extention);
                die();
            }
        }
    }
}

?>