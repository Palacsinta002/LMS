<?php 
session_start();
if (!isset($_SESSION["username"])){
    header("Location: http://localhost/amos/website/PHP/index.php");
}
?>