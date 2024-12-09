<?php 
session_start();
if (!isset($_SESSION["username"])){
    $uri = parse_url( $_SERVER["REQUEST_URI"],PHP_URL_PATH);
    $uri = explode("/", trim($uri,"/"));
    $newuri = "http://localhost/";
    $i = 0;
    while ($uri[$i] != "PHP") {
        $newuri.=$uri[$i] . "/";
        $i++;
    }
    $newuri .= "PHP/index.php";
    echo $newuri;
    header("Location: " . $newuri);
}
?>