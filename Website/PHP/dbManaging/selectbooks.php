<?php
function HandleUserSelect($method){
    if ($method == "POST"){
        require __DIR__ . "/../config/config.php";
        global $conn;
        $sql = "select books.ISBN,books.title,books.publicationYear,publishers.publisher,Authors.name,Categories.category 
            from books,publishers,Authors,Categories 
            where books.publisherID = publishers.publisherID and books.authorID = authors.authorID and books.categoryID = categories.CategoryID";
        
        echo json_encode($conn->query($sql)->fetch_all(MYSQLI_ASSOC));
    }
}


?>