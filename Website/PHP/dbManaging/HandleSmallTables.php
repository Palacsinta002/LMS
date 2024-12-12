<?php
function HandleSmallTablesRequest($method){
    require __DIR__. "/../config/config.php";
    global $conn;
    if ($method == "GET"){
        if (isset($_GET["publisher"])){
            $xd = strlen($_GET["publisher"]) > 0 ? "where publishers.publisher = '"  . $_GET["publisher"] . "'" : "" ;
            $sql = "SELECT publishers.publisherID, publishers.publisher from publishers $xd" ;

            $result = $conn->query($sql);
            if ($result->num_rows > 0){
                echo json_encode($result->fetch_all(MYSQLI_ASSOC));
            }
            else{
                echo json_encode(["Error" => "Invalid data!"]);
            }
        }
        if (isset($_GET["category"])){
            $xd = strlen($_GET["category"]) > 0 ? "where categories.category = '"  . $_GET["category"] . "'" : "" ;
            $sql = "SELECT categories.categoryID, categories.category from categories $xd" ;

            $result = $conn->query($sql);
            if ($result->num_rows > 0){
                echo json_encode($result->fetch_all(MYSQLI_ASSOC));
            }
            else{
                echo json_encode(["Error" => "Invalid data!"]);
            }
        }
        if (isset($_GET["Author"])){
            $xd = strlen($_GET["Author"]) > 0 ? "where Authors.name = '"  . $_GET["Author"] . "'" : "" ;
            $sql = "SELECT Authors.AuthorID, Authors.name from Authors $xd" ;

            $result = $conn->query($sql);
            if ($result->num_rows > 0){
                echo json_encode($result->fetch_all(MYSQLI_ASSOC));
            }
            else{
                echo json_encode(["Error" => "Invalid data!"]);
            }
        }
    }
}



?>