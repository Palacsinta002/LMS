<?php

$conn = new mysqli("localhost","Admin","Admin","LMS");
if ($conn->connect_error){
    die ("Error:" . $conn->connect_error);
}
?>