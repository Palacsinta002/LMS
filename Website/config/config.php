<?php

$conn = new mysqli("localhost","admin","admin","LMS");
if ($conn->connect_error){
    die ("Error:" . $conn->connect_error);
}
?>