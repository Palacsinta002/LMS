<?php
function connect(){
    $conn = new mysqli("localhost", "lms", "!LibraryMS25", "LMS");
    if ($conn->connect_error) {
        die("Error:" . $conn->connect_error);
    }
    return $conn;
}


?>