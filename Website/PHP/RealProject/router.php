<?php

$requesturi = explode("/", trim($_SERVER["REQUEST_URI"],"/"));
if ($requesturi[0] == "api"){
    require_once __DIR__ . "/userapi.php";
}
else{ 
    http_response_code(404);
    echo "Not Found";
}
?>