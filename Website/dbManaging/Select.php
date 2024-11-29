<?php
require "./config/config.php";
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $title = $_POST["title"];
    echo $title;
    $select = "select * from books where books.title = $title";
    //$select->bind_param("s",$title);

    $result = $conn->query($select);
    if ($result->num_rows > 0) {
        echo "idebe";
        while ($row = $result->fetch_assoc()) {
            echo $row["BookID"] . "," . $row["PublisherID"] . "," . $row["AuthorID"] . "," . $row["CategoryID"] . "," . $row["Title"] . "," . $row["PublicationYear"] . "," . $row["ISBN"];
            echo "<br>";
        }
    }
}