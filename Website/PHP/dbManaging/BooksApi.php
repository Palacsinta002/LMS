<?php
//require __DIR__ . "/../config/loggedIn.php";

header("Content-Type: Application/json");
header("Access-Control-Allow-Origin: *");
header("Access-Control-Allow-Methods: GET, POST, PUT, DELETE, PATCH");

$requestmethod = $_SERVER["REQUEST_METHOD"];
$uri = parse_url( $_SERVER["REQUEST_URI"],PHP_URL_PATH);
$uri = explode("/", trim($uri,"/"));


if ($uri[count($uri)-1] === "books") {
    require __DIR__ ."/HandleBooksRequest.php";
    HandleBookRequest($requestmethod);
}
elseif($uri[count($uri)-1] === "borrowings" ){
    //if ($_SESSION["RoleID"] < 3){
        require __DIR__ ."/HandleBorrowingsRequest.php";
        HandleBorrowingRequest($requestmethod);
    /* }
    else{
        echo json_encode(["Error" => "You don't have permission for this request!"]);
    }*/
        
    
}
elseif($uri[count($uri)-1] === "smallTables" ){
    if ($_SESSION["RoleID"] < 3){
        require __DIR__ ."/HandleSmallTables.php";
        HandleSmallTablesRequest($requestmethod);
    }
    else{
        echo json_encode(["Error" => "You don't have permission for this request!"]);
    }
}

else{
    echo json_encode(["error"=> "Endpoint not found!"]);
}

?>