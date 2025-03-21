<?php
namespace Helper;
use ApiResponse\Response;

class Helper{
    public static function validateTheInput($input)
    {
        if (!isset($input)){
            Response::httpError(400,21);
        }
        $input = htmlspecialchars($input);
        $input = stripcslashes($input);
        $input = trim($input);
        return $input;
    }
    public static function validateTheInputArray($array){
        
        foreach ($array as $key => $value) {
            $array[$key] = self::validateTheInput($value);
        }
        return $array;
    }
    ####################  Gets the content of the request  ####################
    public static function getPostBody(){
        
        $rawbody = file_get_contents("php://input");
        $decoded = json_decode($rawbody, true);
        if ($decoded === null && json_last_error() !== JSON_ERROR_NONE) {
            Response::httpError(400,29);
        }
        return $decoded;
    }
    function directiontoUrl($direction) {
        $var = ' \ ';
        $url = "http://localhost";
        $direction = explode(trim($var), $direction);
        for ($i=array_search("LMS", $direction); $i < count($direction); $i++) { 
            $url .= "/" . $direction[$i];
        }
        return $url;
    }
}
?>