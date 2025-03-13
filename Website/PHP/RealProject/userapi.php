<?php
session_start();
####################  Set up the headers  ####################
header("Content-Type: Application/json");
header("Access-Control-Allow-Origin: http://localhost:5173");
header("Access-Control-Allow-Methods: POST, OPTIONS");
header("Access-Control-Allow-Headers: Content-Type,Authorization");
header("Access-Control-Allow-Credentials: true");
require_once __DIR__ . "/InputMethods.php";
####################  Looking for the option connection (Axios only)  ####################
if ($_SERVER['REQUEST_METHOD'] === 'OPTIONS') {
    http_response_code(204);
    exit();
}
####################  Securing the api so it will only accept requests from the "http://localhost:5173" url.  ####################
if (isset($_SERVER['HTTP_ORIGIN']) && $_SERVER['HTTP_ORIGIN'] == "http://localhost:5173") {

    $uri = parse_url($_SERVER["REQUEST_URI"], PHP_URL_PATH);
    $uri = explode("/", trim($uri, "/"));
    $uri = deleteFromList($uri, 0);
    makePostApiEndpoints([["login", "register", "verify", "borrowings", "verifyUser"], ["uploadimg"]], $uri, ["users", "uploadimg"]);
} else {
    errorOutput("várjál mert nem állítottam át a titkosítást! Amúgy szólj ha nem működik mert ez nagyon új!!!!!!! Mert ennek az lenne a feladata hogy csak tőled fogad el kérést de ha ide dobott akkor valami nem működik ja és ami lényeges ERRORCODE : 19");
}


function seacrhURLElement($uri, $element)
{
    for ($i = 0; $i < count($uri); $i++) {
        if ($uri[$i] == $element) {
            return $i;
        }
    }
    return -1;
}

