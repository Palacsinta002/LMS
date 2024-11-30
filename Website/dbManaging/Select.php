<?php
#*********DONE*********

if ($_SERVER["REQUEST_METHOD"] == "POST") {
    #don't touch this 2 paths!!
    require __DIR__."/../config/config.php";
    require __DIR__."/../validate.php";
    # get all of the options to select
    $title = validateTheInput($_POST["Title"]);
    $publisher = validateTheInput($_POST["Publisher"]);
    $author = validateTheInput($_POST["Author"]);
    $category = validateTheInput($_POST["Category"]);
    $publicationYear = validateTheInput($_POST["PublicationYear"]);
    $ISBN = validateTheInput($_POST["ISBN"]);
    # make sure that all of the inputs are full and reforms it to be ready for a select command
    if (strlen($title)!= 0){
        $title = "and books.title = '$title'";
    }
    if (strlen($publisher)!= 0){
        $publisher = "and publishers.publisher = $publisher";
    }
    if (strlen($author)!= 0){
        $author = "and authors.name = $author";
    }
    if (strlen($category)!= 0){
        $category = "and categories.category = $category";
    }
    if (strlen($publicationYear)!= 0){
        $publicationYear = "and books.publicationYear = $publicationYear";
    }
    if (strlen($ISBN)!= 0){
        $ISBN = "and books.ISBN = '$ISBN'";
    }
    
    # this three commands doing all of the backend jobs.
    $text = "select books.ISBN,books.title,books.publicationYear,publishers.publisher,Authors.name,Categories.category 
            from books,publishers,Authors,Categories 
            where books.publisherID = publishers.publisherID and books.authorID = authors.authorID and books.categoryID = categories.CategoryID 
            $title $publisher $author $category $publicationYear $ISBN";
    
    # checks if the select is returns with a data or its false
    function miez($input) {
        if (!$input) {
            throw new Exception('Wrong datas');
        }
        return $input;
    }
    try {
        $select = miez($conn->prepare($text));
        
    } 
    catch (Exception $e) {
        echo 'Caught exception: ',  $e->getMessage(), "\n";
        exit;
    }
    
    $select->execute();

    /*$select->bind_result($BookID,$PublisherID,$AuthorID,$CategoryID,$Title,$PublicationYear,$ISBN);
    while ($select->fetch()) {
        $jsoncumo[] = [$BookID,$PublisherID,$AuthorID,$CategoryID,$Title,$PublicationYear,$ISBN];
        
    }*/
    //$datajson = $select->get_result()->fetch_all(MYSQLI_ASSOC);

    # this is the frontend of the php
    $result = $select->get_result();
    if ($result->num_rows > 0){
        while ($row = $result->fetch_assoc()){
            echo $row["ISBN"];
            echo "<br>";
            echo $row["title"];
            echo "<br>";
            echo $row["publicationYear"];
            echo "<br>";
            echo $row["publisher"];
            echo "<br>";
            echo $row["name"];
            echo "<br>";
            echo $row["category"];
            echo "<br>";
        }
    }

    # always important to close the databse
    $select->close();
    $conn->close();
    //header('Content-Type: application/json');
    //echo json_encode($data);
}