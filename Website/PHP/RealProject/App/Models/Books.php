<?php

namespace App\Models;
use ApiResponse\Response;

class Books extends Model{
    public static function validateMultipleValuesOfString($authorsString){
        $namePattern = "/^[A-ZÁRVÍZTŰRŐTÜKÖRFÚRÓGÉP][a-záéíóöőúüűÁÉÍÓÖŐÚÜŰ\-']*$/u";
        $authorsArray = explode(",",$authorsString);
        for ($i=0; $i < count($authorsArray); $i++) { 
            $author = trim($authorsArray[$i]);
            if (empty($author)) {
                Response::httpError(400, 4);
            }
            $authorNames = explode(" ",$author);
            $strLength = 0;
            for ($j=0; $j < count($authorNames); $j++) { 
                if (!preg_match($namePattern,$authorNames[$j])){
                    Response::httpError(400,4);
                }
                $strLength += strlen($authorNames[$j]);
            }
            
            if ($strLength > 255){
                Response::httpError(400,4);
            }
        }
        return true;
    }

    public static function validateTitle($title){
        $pattern = "/^[A-Za-z0-9ÁÉÍÓÖŐÚÜŰáéíóöőúüű.,!?:;'\-\" ]{1,255}$/u";
        if (!preg_match($pattern, $title)) {
           Response::httpError(400,26);
        } 
        return true; 
    }

    public static function validateYear($year){
        $pattern = "/^[0-9]{1,4}$/";
        if (!preg_match($pattern,$year)){
            Response::httpError(400,23);
        }
        $currentYear = date("Y");
        if ($currentYear < $year){
            Response::httpError(400,23);
        }
        return true;
    }

    public static function validatePublisher($publisher) {
        $publisher = trim($publisher);
    
        $pattern = "/^[A-Za-z0-9ÁÉÍÓÖŐÚÜŰáéíóöőúüű.,'& -]{1,255}$/u";
    
        if (!preg_match($pattern, $publisher)) {
            Response::httpError(400, 25);
        }
    
        return true;
    }

}
?>