<?php
require_once __DIR__ . "/RealProject/config/connect.php";
$conn = connect();
$sql = "SELECT users.password from users";
$stmt = $conn->query($sql);
$data = $stmt->fetch_all(MYSQLI_ASSOC);
foreach ($data as $key => $value) {
    
    $hashed = password_hash($value["password"], PASSWORD_BCRYPT);
    $sql = "UPDATE users set password = '". $hashed . "' where password = '" . $value["password"] . "'";
    echo $sql;
    echo "</br>";
    $conn->query($sql);
}
$stmt->close();
?>