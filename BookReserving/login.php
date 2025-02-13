<?php
session_start();



?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <form action="login.php" method="POST">
        <input type="text" name="username" placeholder="Felhasználónév">
        <input type="password" name="password" placeholder="Jelszó">
        <p><?php
        if ($_SERVER["REQUEST_METHOD"] == "POST"){
            require_once "loginController.php";
            $login = new userLoginController($_POST['username'], $_POST['password']);
        }
        ?></p>
        <button type="submit">Bejelentkezés</button>
    </form>
</body>
</html>