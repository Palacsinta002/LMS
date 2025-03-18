<?php
header("Content-Type: Application/json");
header("Access-Control-Allow-Origin: *");
header("Access-Control-Allow-Methods: GET");

function openapi( $uri ) {
    require_once __DIR__ . "/InputMethods.php";
    if ($_SERVER["REQUEST_METHOD"] != "GET"){
        errorOutput("17");
    }
    require_once __DIR__ . "/users/getbooks.php";
    
    if(($booksPlace = array_search("books",$uri)) != false){
        $uriData = array_slice($uri,$booksPlace, count($uri)-$booksPlace);
        require_once __DIR__ . "/users/getbooks.php";
        getbooks($uriData);
    }
}


?>