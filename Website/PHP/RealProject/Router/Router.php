<?php

namespace Router;
use ApiResponse\Response;
use Helper\Helper;
use App\Authorize\Token;
class Router{

    public static function post($endpoint, $controller, $function, $auth = false,$getFiles = false){
        $uri = $_SERVER["REQUEST_URI"];
        
        if ($uri == $endpoint){
            if ($_SERVER["REQUEST_METHOD" ] != "POST"){
                return;
            }
            $body = Helper::getPostBody();

                if ($auth == true){
                    if ($getFiles == true){
                        $controller::$function();
                        die();
                    }
                    $userID = self::getHeadAuth();
                    $controller::$function($body,$userID);
                    die();
                }
                if ($getFiles == true){
                    $controller::$function();
                    die();
                }
                $controller::$function($body);
                die("");
            
        }
        
    }

    

    public static function get( $endpoint, $controller, $function,$auth = false, $getFromURL = false ){
        $uri = $_SERVER["REQUEST_URI"];
            if ($getFromURL){
                $data = self::getVariablesFromUrl($uri, $endpoint);
                if ($data == -1){
                    return;
                }
                $data = $data == false ? self::getBodyFromUrl($uri,$endpoint) : $data;
            }
            else{
                $data = Helper::validateTheInputArray($_GET);
            }
            if (strlen($uri) >= strlen($endpoint) && substr($uri,0, strlen($endpoint))  == $endpoint){
                if ($_SERVER["REQUEST_METHOD" ] != "GET"){
                    return;
                }

                if ($auth == true){
                    $userID = self::getHeadAuth();
                    $controller::$function($data,$userID);
                    die();
                }
                $controller::$function($data);
                die("");
            }
        
        
    }
    public static function put($endpoint, $controller, $function,$auth = true){
        $uri = $_SERVER["REQUEST_URI"];
        
        if ($uri == $endpoint){
            if ($_SERVER["REQUEST_METHOD" ] != "PUT"){
                return;
            }
            $body = Helper::getPostBody();
            if ($auth == true){
                $userID = self::getHeadAuth();
                $controller::$function($body,$userID);
                die();
            }
            
            $controller::$function($body);
            die();
            
        }
    }    
    public static function delete($endpoint, $controller, $function){
        $uri = $_SERVER["REQUEST_URI"];
        $data = self::getVariablesFromUrl($uri, $endpoint);
        if ($data == -1){
            return;
        }
        if (strlen($uri) >= strlen($endpoint) && substr($uri,0, strlen($endpoint)) == $endpoint){
            if ($_SERVER["REQUEST_METHOD"] != "DELETE"){
                return;
            }
            if (($userID = self::getHeadAuth())){
                if (($data = self::getVariablesFromUrl($uri, $endpoint)) != false){
                    $controller::$function($data,$userID);
                    die();
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


    private static function getBodyFromUrl( $uri,$endpoint){
        $body = explode("/",trim(substr($uri, strlen($endpoint)),"/"));
        $data = Helper::validateTheInputArray(self::getBodyByUrl($body));
        return $data;
    }


    private static function getVariablesFromUrl($uri, &$endpoint){
        $endpointArray = explode("/", trim($endpoint, "/"));
        $uriArray = explode("/", trim($uri, "/"));
        $variables = [];
        $returnEndpoint = "";
        for ($i=0; $i < count($endpointArray); $i++) { 
            if ($endpointArray[$i][0] == "{" && $endpointArray[$i][strlen($endpointArray[$i])-1] == "}"){
                $key = substr($endpointArray[$i], 1, strlen($endpointArray[$i])-2);
                $variables[$key] = $i;
            }
            else{
                $returnEndpoint .= "/". $endpointArray[$i];
            }
        }
        
        $endpoint = $returnEndpoint;
        if (count($variables) == 0){
            return false;
        }
        foreach ($variables as $key => $value) {
            if (isset($uriArray[$value])){
                $variables[$key] = $uriArray[$value];
            }
            else{
                return -1;
            }
        }
        
        $variables = Helper::validateTheInputArray($variables, "url");
        if (count($variables) == 1){
            return $variables[array_keys($variables)[0]];
        }
        return $variables;
    }
}
?>