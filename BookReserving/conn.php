<?php
function connect() {
    $pdo = new PDO('mysql:host=localhost;dbname=book_rental;charset=utf8', 'root', '');
    $pdo->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
    return $pdo;
}

?>