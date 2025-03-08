<?php

function Borrowings(){
    require_once __DIR__ . "/../InputMethods.php";
    require_once __DIR__ . "/../config/connect.php";

    # query by [ISBN,userID,borrowDate,dueDate,returnDate]
    $validatedBody = getPostBody();
    $sqlWhere = "";
    if (isset($validatedBody)){
        
        foreach($validatedBody as $key => $value){
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
    }
    $sql = "SELECT borrowings.ISBN, users.username, borrowings.borrowDate, borrowings.returnDate, borrowings.dueDate 
    from borrowings, users 
    where borrowings.userID = users.ID". $sqlWhere;

    $conn = connect();
    echo json_encode($conn->query($sql)->fetch_all(MYSQLI_ASSOC));
    $conn->close();

}


?>