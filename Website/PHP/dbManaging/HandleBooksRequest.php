<?php
function HandleBookRequest($method){
    require __DIR__ . "/../config/config.php";
    require __DIR__ . "/ConvertIDToString.php";
    global $conn;
    ################    GET    #####################
    if ($method == "GET"){
        

        $limit = isset($_GET["limit"]) ? $_GET["limit"] : 15;
        $sql = "SELECT books.ISBN,books.title,books.publicationYear,publishers.publisher,Authors.name,Categories.category 
            from books,publishers,Authors,Categories 
            where books.publisherID = publishers.publisherID and books.authorID = authors.authorID and books.categoryID = categories.CategoryID ". validateInput() ." limit $limit";
        $result = json_encode($conn->query($sql)->fetch_all()) ;
        echo $result;
        
    }
    ################    POST    #####################
    if ($method == "POST"){
        if ($_SESSION["RoleID"] < 3){
            $rawBody = file_get_contents('php://input');
        $decoded = json_decode($rawBody, true);
        $publisher = checkdata("publishers",["PublisherID", "publisher"],"publisher", $decoded["Publisher"]);
        $author = checkdata("Authors",["AuthorID", "name"],"name", $decoded["Author"]);
        $category = checkdata("categories",["CategoryID", "Category"],"Category", $decoded["Category"]);
        $ISBN = $decoded["ISBN"];
        $title = $decoded["Title"];
        $publicationYear = $decoded["PublicationYear"];
        $sql = "insert into books(publisherID,authorID,categoryID,title,ISBN,publicationYear) values('$publisher' , '$author', '$category', '$title', '$ISBN', $publicationYear)";
        if ($conn->query($sql)){
            echo json_encode(["Success:" => "The line was successfully inserted!"]);
        }
        }
        else{
            echo json_encode(["Error:" => "You don't have permission for this request!"]);
            die();
        }
        

    }
    ################    PATCH    #####################
    if ($method == "PATCH"){
        if ($_SESSION["RoleID"] < 3){
            $rawBody = file_get_contents('php://input');
            $decoded = json_decode($rawBody, true);
            $current = $decoded["current"];
            $newdata = $decoded["new"];
            #first convert
            if (isset($current["Publisher"])){
                $current["Publisher"] = checkdata("publishers",["PublisherID", "publisher"],"publisher", $current["Publisher"]);
            }
            if (isset($current["Author"])){
                $current["Author"] = checkdata("Authors",["AuthorID", "name"],"name", $current["Author"]);
            }
            if (isset($current["Category"])){
                $current["Category"] = checkdata("categories",["CategoryID", "Category"],"Category", $current["Category"]);
            }
            #second convert
            if (isset($newdata["Publisher"])){
                $newdata["Publisher"] = checkdata("publishers",["PublisherID", "publisher"],"publisher", $newdata["Publisher"]);
            }
            if (isset($newdata["Author"])){
                $newdata["Author"] = checkdata("Authors",["AuthorID", "name"],"name", $newdata["Author"]);
            }
            if (isset($newdata["Category"])){
                $newdata["Category"] = checkdata("categories",["CategoryID", "Category"],"Category", $newdata["Category"]);
            }
            
            $sql = "UPDATE books set ". equalize($newdata) . " where " . equalize($current);
            if ($conn->query($sql)){
                echo json_encode(["success" => "row(s) successfully updated!"]);
            }
            else {
                echo json_encode(["Error" => "Something went wrong!"]);
            }
        }
        else{
            echo json_encode(["Error:" => "You don't have permission for this request!"]);
            die();
        }

    }
    ################    DELETE    #####################
    if ($method == "DELETE"){
        
        $rawBody = file_get_contents('php://input');
        $decoded = json_decode($rawBody, true);
        if (isset($current["Publisher"])){
            $current["Publisher"] = checkdata("publishers",["PublisherID", "publisher"],"publisher", $current["Publisher"]);
        }
        if (isset($current["Author"])){
            $current["Author"] = checkdata("Authors",["AuthorID", "name"],"name", $current["Author"]);
        }
        if (isset($current["Category"])){
            $current["Category"] = checkdata("categories",["CategoryID", "Category"],"Category", $current["Category"]);
        }
        
        $sql = "SELECT books.BookID from books where ". equalize($decoded);
        
        if ($result = $conn->query($sql)){
            
            $result = $result->fetch_all(MYSQLI_ASSOC);
            foreach ($result as $key => $value) {
                $sql = "DELETE from borrowings where bookID =". $value["BookID"];
                
                $conn->query($sql);
            }
        }
        $sql = "DELETE from books where ". equalize($decoded);
        if ($conn->query($sql)){
            echo json_encode(["Success" => "row(s) successfully deleted"]);
        }
        else {
            echo json_encode(["Error" => "Something went wrong!"]);
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



/*function normalizeData($input){
    $normalized = ["title" =>null,"publisher" =>null,"author" =>null,"category" =>null,"publicationYear" =>null,"ISBN" =>null ];
    foreach ($input as $key => $value) {
        $normalized[$key] = $input[$value];
    }
    return $normalized;
    }
*/
function equalize($input){
    $sql = "";
    unset($input["limit"]);
    foreach ($input as $key => $value) {
        if ($key == "Publisher" || $key == "Author" || $key == "Category"){
            $sql.= $key."ID = $value, ";
        }
        else{
            $sql.= "$key = '$value', " ;
        }
        
    }
    $sql = trim(trim($sql),",");
    return $sql;
}

?>