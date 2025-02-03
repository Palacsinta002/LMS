<?php
function getbooks($uriData){
    require_once __DIR__ . "/../InputMethods.php";
    require_once __DIR__ . "/../config/connect.php";
    $conn = connect();
    $options = ["ISBN" =>" and books.ISBN =",
                "publisher" =>" and publishers.publisher =",
                "title" =>" and books.title =", 
                "author" =>" and authors.author =", 
                "category" =>" and categories.category =",
                "publicationYear" =>" and books.publicationYear ="
            ];
    $sqlParamaters = [];
    $lengthOfUriDoubles = (count($uriData)-1) %2 == 0 ? count($uriData)-1 : count($uriData)-2;
    
    for ($i=0; $i < $lengthOfUriDoubles / 2; $i++) { 
        $j = ($i+1)*2;
        foreach ($options as $key => $value) {
            if ($uriData[$j-1] == $key){
                if ($key == "ISBN" || $key == "publicationYear"){
                    $options[$key] .= $uriData[$j] . " ";
                }
                else{
                    $options[$key] .= "'" . $uriData[$j] . "' ";
                }
            }
        }
    }
        $sql = "SELECT books.ISBN, publishers.publisher, books.title, GROUP_CONCAT(DISTINCT Authors.Author SEPARATOR ','), GROUP_CONCAT(DISTINCT categories.category SEPARATOR ','), books.publicationYear
                from books, publishers, books_authors, authors, books_categories, categories
                where books.ISBN = books_authors.ISBN and books_authors.AuthorID = authors.id and books.ISBN = books_categories.ISBN and books_categories.CategoryID = categories.id and books.publisherid = publishers.id" ;
    foreach ($options as $key => $value) {
        if ($value[strlen($value)-1] == "="){
            $options[$key] = "";
        }
        $sql .= $options[$key];
    }
    $sql .= " GROUP BY Books.Title, Books.PublicationYear, Publishers.Publisher, Books.ISBN";
    if ($result =$conn->query($sql)){
        $data = $result->fetch_all(MYSQLI_ASSOC);
        echo json_encode($data);
    }
    else{
        errorOutput("14");
    }

}