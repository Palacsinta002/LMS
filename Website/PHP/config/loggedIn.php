<?php 
session_start();
if (!isset($_SESSION["username"])){
    header("Location: http://localhost/website/PHP/index.php");
}
?>