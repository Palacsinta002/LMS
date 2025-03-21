<?php

namespace Router;
use ApiResponse\Response;
use Helper\Helper;
use App\Authorize\Token;
class Router{

    public static function post($endpoint, $controller, $function, $auth = false){
        $uri = $_SERVER["REQUEST_URI"];
        
        if ($uri == $endpoint){
            if ($_SERVER["REQUEST_METHOD" ] != "POST"){
                Response::httpError(404,17);
            }
                if ($auth == true){
                    $userID = self::getHeadAuth();
                    $body = Helper::getPostBody();
                    $controller::$function($body,$userID);
                    die();
                }
                $body = Helper::getPostBody();
                $controller::$function($body);
                die("");
            
        }
        
    }

    

    public static function get($endpoint, $controller, $function,$auth = false, $getFromURL = false, $oneElement = false){
        $uri = $_SERVER["REQUEST_URI"];
            if (strlen($uri) >= strlen($endpoint) && substr($uri,0, strlen($endpoint)) == $endpoint && $getFromURL){
                
                if ($_SERVER["REQUEST_METHOD" ] != "GET"){
                    Response::httpError(404,17);
                }
                
                $data = self::getBodyFromUrl($uri,$endpoint, $oneElement);

                if ($auth == true){
                    $userID = self::getHeadAuth();
                    $controller::$function($data,$userID);
                    die();
                }
                $controller::$function($data);
                die("");
            }
            
            elseif (strlen($uri) >= strlen($endpoint) && substr($uri,0, strlen($endpoint))  == $endpoint){
                if ($_SERVER["REQUEST_METHOD" ] != "GET"){
                    Response::httpError(404,17);
                }
                $data = Helper::validateTheInputArray($_GET);
                if ($auth == true){
                    $userID = self::getHeadAuth();
                    $controller::$function($data,$userID);
                    die();
                }
                $controller::$function($data);
                die("");
            }
        
        
    }
    public static function put($endpoint, $controller, $function){
        $uri = $_SERVER["REQUEST_URI"];
        
        if ($uri == $endpoint){
            if ($_SERVER["REQUEST_METHOD" ] != "PUT"){
                Response::httpError(404,17);
            }
            $userID = self::getHeadAuth();
            $body = Helper::getPostBody();
            $controller::$function($body,$userID);
            die();
            
        }
    }
    public static function delete($endpoint, $controller, $function, $getFromURL = false){
        if ($endpoint == $_SERVER["REQUEST_URI"]){
            $uri = $_SERVER["REQUEST_URI"];
            if ($_SERVER["REQUEST_METHOD"] != "DELETE"){
                Response::httpError(404,17);
            }
            if (($userID = self::getHeadAuth())){
                if ($getFromURL){
                    $data = self::getBodyFromUrl($uri,$endpoint,true);
                    echo $data;
                    die();
                    $controller::$function($data,$userID);
                }
                $controller::$function($userID);
                die();
            }

        }
    }
    private static function getBodyByUrl( $uri ){
        $lengthOfUriDoubles = (count($uri)) %2 == 0 ? count($uri) : count($uri)-1;
        $data = [];
        for ($i=0; $i < $lengthOfUriDoubles / 2; $i++) { 
            $j = $i*2;
            $uriData[$j+1] = strtolower($uri[$j+1]);
            $data[$uri[$i]] =  $uriData[$j+ 1];
        }
        return $data;
    }

    private static function getHeadAuth(){
        $headers = getallheaders();
        $token = $headers['Authorization'] ?? $headers['authorization'] ?? "";
        return Token::verifyToken($token);
    }
    private static function getBodyFromUrl( $uri,$endpoint,$oneElement = false ){
        if ($oneElement == true){
            $body = explode("/",trim(substr($uri, strlen($endpoint)),"/"));

            if (count($body) != 1){
                Response::httpError(404,21);
            }
            
            $data = Helper::validateTheInput($body[0]);
        }
        else{
            $body = explode("/",trim(substr($uri, strlen($endpoint)),"/"));
        
            $data = Helper::validateTheInputArray(self::getBodyByUrl($body));
        }
        return $data;
    }
}
?>