<?php

require_once __DIR__ . "/InputMethods.php";
$requesturi = explode("/", trim($_SERVER["REQUEST_URI"],"/"));
if ($requesturi[0] == "api"){
    require_once __DIR__ . "/userapi.php";
}
if ($requesturi[0] == "img"){
    $requesturi = deleteFromList($requesturi,0);
    count($requesturi) == 0 ? errorOutput("18") : "";
    $filepath = "http://localhost/LMS/website/php/realproject/booksImages"."/". $requesturi[count($requesturi)-1] . ".png";
    if (!file_exists($file)){return header("Location: http://localhost/LMS/website/php/realproject/booksImages/missing.png");}
    return header("Location: " . $files);
}
else{
    http_response_code(404);
    echo "Not Found";
}
?>