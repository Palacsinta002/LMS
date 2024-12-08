<?php
header("Content-Type: Application/json");
header("Access-Control-Allow-Origin: *");
header("Access-Control-Allow-Methods: GET, POST, PUT, DELETE");

$requestmethod = $_SERVER["REQUEST_METHOD"];
$uri = parse_url( $_SERVER["REQUEST_URI"],PHP_URL_PATH);
$uri = explode("/", trim($uri,"/"));


if ($uri[count($uri)-1] === "books") {
    require __DIR__ ."/HandleBooksRequest.php";
    HandleUserSelect($requestmethod);
}

else{
    echo json_encode(["error"=> "Endpoint not found!"]);
}

?>