<?php

namespace Router;
use ApiResponse\Response;
use Helper\Helper;
use App\Authorize\Token;
class Router{

    public static function post($endpoint, $controller, $function, $auth = false){
        $uri = $_SERVER["REQUEST_URI"];
        
        if ($uri == $endpoint){
            if ($_SERVER["REQUEST_METHOD" ] == "POST"){
                $userID = "";
                if ($auth == true){
                    $token = isset(getallheaders()['Authorization']) ? getallheaders()['Authorization'] : (isset(getallheaders()['authorization']) ? getallheaders()['authorization'] : "");
                    $userID = Token::verifyToken($token);
                    $body = Helper::getPostBody();
                    $controller::$function($body,$userID);
                    die();
                }
                $body = Helper::getPostBody();
                $controller::$function($body);
                die("");
            }
            
        }
        
    }

    

    public static function get($endpoint, $controller, $function,$auth = false, $getFromURL = false, $img = false){
        $uri = $_SERVER["REQUEST_URI"];
            if (strlen($uri) >= strlen($endpoint) && substr($uri,0, strlen($endpoint)) == $endpoint && $getFromURL){
                
                if ($_SERVER["REQUEST_METHOD" ] != "GET"){
                    Response::httpError(404,17);
                }
                
                if ($img == true){
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
                if ($auth == true){
                    $token = isset(getallheaders()['Authorization']) ? getallheaders()['Authorization'] : (isset(getallheaders()['authorization']) ? getallheaders()['authorization'] : "");
                    $userID = Token::verifyToken($token);
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
                    $token = isset(getallheaders()['Authorization']) ? getallheaders()['Authorization'] : (isset(getallheaders()['authorization']) ? getallheaders()['authorization'] : "");
                    $userID = Token::verifyToken($token);
                    $controller::$function($data,$userID);
                    die();
                }
                $controller::$function($data);
                die("");
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
}
?>