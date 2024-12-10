<?php
function HandleUserSelect($method){
    require __DIR__ . "/../config/config.php";
    if ($method == "GET"){
        

        $limit = isset($_GET["limit"]) ? $_GET["limit"] : 15;
        $sql = "SELECT books.ISBN,books.title,books.publicationYear,publishers.publisher,Authors.name,Categories.category 
            from books,publishers,Authors,Categories 
            where books.publisherID = publishers.publisherID and books.authorID = authors.authorID and books.categoryID = categories.CategoryID ". validateInput() ." limit $limit";
        global $conn;
        $result = json_encode($conn->query($sql)->fetch_all()) ;
        echo $result;
        
    }

    if ($method == "POST"){
        $rawBody = file_get_contents('php://input');
        $decoded = json_decode($rawBody, true);
        $publisher = checkdata("publishers",["PublisherID", "publisher"],"publisher", $decoded["Publisher"]);
        $author = checkdata("Authors",["AuthorID", "name"],"name", $decoded["Author"]);
        $category = checkdata("categories",["CategoryID", "Category"],"Category", $decoded["Category"]);
        $ISBN = $decoded["ISBN"];
        $title = $decoded["Title"];
        $publicationYear = $decoded["PublicationYear"];
        $sql = "insert into books(publisherID,authorID,categoryID,title,ISBN,publicationYear) values('$publisher' , '$author', '$category', '$title', '$ISBN', $publicationYear)";;
        if ($conn->query($sql)){
            echo json_encode(["Success:" => "The line was successfully inserted!"]);
        }

    }
    $conn->close();

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
function checkdata($table, $cols, $maincol, $element){
    global $conn;
    $txt = "";
    for ($i=0; $i < count($cols); $i++) { 
        $txt .= $table . "." . $cols[$i] . ", ";
    }
    $txt = trim(trim($txt),",");

    $sql = "select $txt from $table where $table.$maincol = '$element'";
    $selectedrow = $conn->query($sql);
    if ($selectedrow->num_rows > 0){
        $row = $selectedrow->fetch_assoc();
        $col = $cols[0];
        return $row["$col"];
        
    }
    else{
        echo json_encode(["error:" =>  $element . " not in the database!"]);
        die(); 
    }

}
?>