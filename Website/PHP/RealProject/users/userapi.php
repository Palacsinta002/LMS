<?php
session_start();
####################  Set up the headers  ####################
header("Content-Type: Application/json");
header("Access-Control-Allow-Origin: http://localhost:5173");
header("Access-Control-Allow-Methods: POST, OPTIONS");
header("Access-Control-Allow-Headers: Content-Type,Authorization");
header("Access-Control-Allow-Credentials: true");

####################  Looking for the option connection (Axios only)  ####################
if ($_SERVER['REQUEST_METHOD'] === 'OPTIONS') {
    http_response_code(204); 
    exit();
}

####################  Split up the url and checks the last part of it and return a json  ####################
$requestmethod = $_SERVER["REQUEST_METHOD"];
$uri = parse_url( $_SERVER["REQUEST_URI"],PHP_URL_PATH);
$uri = explode("/", trim($uri,"/"));

if ($uri[count($uri)-1] == "register"){
    require_once "register.php";
    register();
}
elseif($uri[count($uri)-1] == "login"){
    require_once "login.php";
    login();
}
elseif($uri[count($uri)-1] == "logout"){
    require_once "logout.php";
}
elseif(seacrhURLElement($uri,"books") >= 0){
    $booksPlace = seacrhURLElement($uri,"books");
    $uriData = array_slice($uri,$booksPlace, count($uri)-$booksPlace);
    require_once "getbooks.php";
    getbooks($uriData);
    
}
elseif($uri[count($uri)-1] == "verify"){
    require_once "verify.php";
    verify();
}
else{
    echo json_encode(["error"=> "Endpoint not found!"]);
}
function seacrhURLElement($uri, $element){
    for ($i=0; $i < count($uri); $i++) { 
        if ($uri[$i] == $element){
            return $i;
        }
    }
    return -1;
}

?>