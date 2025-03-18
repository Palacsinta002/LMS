<?php
# This file handle the /getbooks request                                                                                        #
# The function getbooks gets the data from the uri and makes a query to the database to get the books that match the given data #
# The data is in the uri in the form of key value pairs                                                                         #
function getbooks($uriData){
    require_once __DIR__ . "/../InputMethods.php";
    require_once __DIR__ . "/../config/connect.php";
    $conn = connect();
    $options = ["isbn" =>" and books.ISBN =",
                "publisher" =>" and publishers.publisher =",
                "title" =>" and books.title =", 
                "author" =>" and authors.author =", 
                "category" =>" and categories.category =",
                "publicationyear" =>" and books.publicationYear ="
            ];
    # ignore the last element if the uriData is odd
    $lengthOfUriDoubles = (count($uriData)-1) %2 == 0 ? count($uriData)-1 : count($uriData)-2;
    # loop through the uriData and add the data to the options array
    for ($i=0; $i < $lengthOfUriDoubles / 2; $i++) { 
        $j = ($i+1)*2;
        $uriData[$j-1] = strtolower($uriData[$j-1]);
        foreach ($options as $key => $value) {
            if ($uriData[$j-1] == $key){
                if ($key == "isbn" || $key == "publicationyear"){
                    $options[$key] .= urldecode($uriData[$j]) . " ";
                }
                elseif ($key == "author" || $key == "category"){
                    $options[$key] = trim($options[$key], "=");
                    $options[$key] .= "LIKE '%" . urldecode($uriData[$j]) . "%' ";
                }
                else{
                    $options[$key] .= "'" . urldecode($uriData[$j]) . "' ";
                }
            }
        }
    }
        $sql = "SELECT books.ISBN, publishers.Publisher, books.Title, GROUP_CONCAT(DISTINCT Authors.Author SEPARATOR ',') as 'Authors', GROUP_CONCAT(DISTINCT categories.category SEPARATOR ',') as 'Category', books.publicationYear,books.ImgUrl
                from books, publishers, books_authors, authors, books_categories, categories
                where books.ISBN = books_authors.ISBN and books_authors.AuthorID = authors.id and books.ISBN = books_categories.ISBN and books_categories.CategoryID = categories.id and books.publisherid = publishers.id" ;
    # add the options to the sql query
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