<?php
function HandleUserSelect($method){
    if ($method == "GET"){
        require __DIR__ . "/../config/config.php";

        $limit = isset($_GET["limit"]) ? $_GET["limit"] : 15;
        $sql = "SELECT books.ISBN,books.title,books.publicationYear,publishers.publisher,Authors.name,Categories.category 
            from books,publishers,Authors,Categories 
            where books.publisherID = publishers.publisherID and books.authorID = authors.authorID and books.categoryID = categories.CategoryID ". validateInput() ." limit $limit";
        global $conn;
        $result = json_encode($conn->query($sql)->fetch_all()) ;
        echo $result;
    }
    if ($method == "POST"){
        $jsonInput = file_get_contents('php://input');
        $decoded = json_decode($jsonInput,true);
        
    }

}
function validateInput(){
    $txt = "";
    $txt .= isset($_GET["ISBN"]) ?  " and books.ISBN = '" . $_GET["ISBN"]."'" : " ";

    $txt .= isset($_GET["Title"]) ?  " and books.title = '" . $_GET["Title"]."'" : " ";

    $txt .= isset($_GET["PublicationYear"]) ?  " and books.publicationYear = " . $_GET["PublicationYear"] : " ";

    $txt .= isset($_GET["Publisher"]) ?  " and publishers.publisher = '" . $_GET["Publisher"]."'" : " ";

    $txt .= isset($_GET["Author"]) ?  " and Authors.name = '" . $_GET["Author"]."'" : " ";

    $txt .= isset($_GET["Category"]) ?  " and Categories.category  = '" . $_GET["Category"]."'" : " ";
    
    return $txt;
}

?>