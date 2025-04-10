<?php

namespace App\Validations;
use ApiResponse\Response;

class Books extends Model{
    public static function validateFullName($fullName){
        $namePattern = "/^[A-Za-záéíóöőúüűÁÉÍÓÖŐÚÜŰ]+([\-'. ]?[A-Za-záéíóöőúüűÁÉÍÓÖŐÚÜŰ]+)*$/u";
        if (!preg_match($namePattern, $fullName)) {
            Response::httpError(400, 4);
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