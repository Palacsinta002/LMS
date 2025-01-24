<?php
header("Content-Type: Application/json");
header("Access-Control-Allow-Origin: http://localhost:5173");
header("Access-Control-Allow-Methods: POST, OPTIONS");
header("Access-Control-Allow-Headers: Content-Type,Authorization");
header("Access-Control-Allow-Credentials: true");

if ($_SERVER['REQUEST_METHOD'] === 'OPTIONS') {
    http_response_code(204); // No Content for preflight
    exit();
}
$requestmethod = $_SERVER["REQUEST_METHOD"];
$uri = parse_url( $_SERVER["REQUEST_URI"],PHP_URL_PATH);
$uri = explode("/", trim($uri,"/"));

if ($uri[count($uri)-1] == "register"){
    require_once "register.php";
    register();
}
elseif($uri[count($uri)-1] == "login"){

}
else{
    echo json_encode(["error"=> "Endpoint not found!"]);
}

?>