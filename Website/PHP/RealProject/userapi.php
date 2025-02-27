<?php
session_start();
####################  Set up the headers  ####################
header("Content-Type: Application/json");
header("Access-Control-Allow-Origin: *");
header("Access-Control-Allow-Methods: POST, OPTIONS");
header("Access-Control-Allow-Headers: Content-Type,Authorization");
header("Access-Control-Allow-Credentials: true");

####################  Looking for the option connection (Axios only)  ####################
if ($_SERVER['REQUEST_METHOD'] === 'OPTIONS') {
    http_response_code(204); 
    exit();
}
require_once __DIR__ . "/InputMethods.php";
$uri = parse_url( $_SERVER["REQUEST_URI"],PHP_URL_PATH);
$uri = explode("/", trim($uri,"/"));

makePostApiEndpoints(["register","login", "logout", "verify"],$uri,"users");

function seacrhURLElement($uri, $element){
    for ($i=0; $i < count($uri); $i++) { 
        if ($uri[$i] == $element){
            return $i;
        }
    }
    return -1;
}

