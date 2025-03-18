<?php

namespace App\Models;
use ApiResponse\Response;
class Borrowing extends Model{
    public static function checkFormatDate($date){
        if ($date == "NULL"){
            return true;
        }
        $pattern = "/^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[12][0-9]|3[01])$/";
        if (!preg_match($pattern, $date)){
            Response::httpError(400,23);
            
        }
        $date = explode("-", $date);
        if (!checkdate($date[1],$date[2],$date[0])) {
            Response::httpError(400,22);
        }
        return true;
    }
    public static function checkLimit($limit){
        if (!preg_match("/^[0-9]+$/", $limit)){
            Response::httpError(400,3);
        }
        return true;
    }
}

?>