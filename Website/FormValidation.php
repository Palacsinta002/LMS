<?php
    require "config/config.php";
    
    $username = "";
    $password = "";

    if($_SERVER["REQUEST_METHOD"] == "POST"){
        $username = $_POST["username"];
        $password = $_POST["password"];

        $sql = "SELECT users.username, users.password FROM users WHERE users.username = '$username' AND users.password = '$password'";
    
        $result = $conn->query($sql);
    
        if($result->num_rows > 0){
            header('Location: ./books.php');
            exit();
        }
    
    }