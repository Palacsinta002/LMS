<?php
header("Content-Type: Application/json");
header("Access-Control-Allow-Origin: *");
header("Access-Control-Allow-Methods: POST,GET");

$requestmethod = $_SERVER["REQUEST_METHOD"];
$uri = parse_url( $_SERVER["REQUEST_URI"],PHP_URL_PATH);
$uri = explode("/", trim($uri,"/"));

if ($uri [count($uri)-1] === "selectbooks") {
    require __DIR__ ."/selectbooks.php";
    HandleUserSelect($requestmethod);
}
else{
    echo json_encode(["error"=> "Endpoint not found!"]);
}

?>