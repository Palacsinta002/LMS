<?php

function Borrowings(){
    require_once __DIR__ . "/../InputMethods.php";
    require_once __DIR__ . "/../config/connect.php";

    # query by [ISBN,userID,borrowDate,dueDate,returnDate]
    $validatedBody = getPostBody();
    $sqlWhere = "";
    if (isset($validatedBody)){
        
        foreach($validatedBody as $key => $value){
            if (in_array($key, ["ISBN","userid","borrowDate","returnDate","DueDate"])){
                if ($key == "ISBN" || $key == "userID"){
                    $sqlWhere .= " and borrowings.$key = $value";
                }
                else {
                    if ($value == "null" || $value == "NULL"){
                        $sqlWhere .= " and borrowings.$key is $value";
                    }
                    else {
                        $sqlWhere .= " and borrowings.$key = " ."'$value'";
                    }
                }
            }
            if (in_array($key, ["title","publicationYear"])){
                if ($key == "publicationYear"){
                    $sqlWhere .= " and books.$key = $value";
                }
                else{
                    $sqlWhere .= " and books.$key = '$value'";
                }
            }
            if ($key == "author"){
                    $sqlWhere .= " and books.$key LIKE '%$value%'";
                
            }
            if ($key == "category"){
                $sqlWhere .= " and categories.$key LIKE '%$value%'";   
            }
            if ($key == "publisher"){
                $sqlWhere .= " and publishers.$key = '$value'";   
            }
            if ($key == "username"){
                $sqlWhere .= " and users.$key = '$value'";   
            }
            
        }
    }
    $sql = "SELECT borrowings.ISBN, users.username, borrowings.borrowDate, borrowings.returnDate, borrowings.dueDate 
    from borrowings, users, books
    where borrowings.userID = users.ID". $sqlWhere;

    $sql = "SELECT books.ISBN, publishers.Publisher, books.Title, GROUP_CONCAT(DISTINCT Authors.Author SEPARATOR ',') as 'Authors', GROUP_CONCAT(DISTINCT categories.category SEPARATOR ',') as 'Categories', books.publicationYear, users.username, borrowings.borrowDate, borrowings.returnDate, borrowings.dueDate 
                from books, publishers, books_authors, authors, books_categories, categories, users, borrowings
                where books.ISBN = books_authors.ISBN and books_authors.AuthorID = authors.id and books.ISBN = books_categories.ISBN and books_categories.CategoryID = categories.id and books.publisherid = publishers.id and books.ISBN = borrowings.ISBN and borrowings.userid = users.ID";
    
    $sql .= $sqlWhere;
    $sql .= " GROUP BY Books.Title, Books.PublicationYear, Publishers.Publisher, Books.ISBN";
    
    $conn = connect();
    echo json_encode($conn->query($sql)->fetch_all(MYSQLI_ASSOC));
    $conn->close();

}


?>