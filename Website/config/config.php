<?php
global $CFG;
$CFG= new stdClass();
$CFG->dbhost = "localhost";
$CFG->dbname = "LMS";
$CFG->username = "admin";
$CFG->password = "admin";
$conn = new mysqli("localhost","admin","admin","LMS");
if ($conn->connect_error){
    die ("Error:" . $conn->connect_error);
}
?>