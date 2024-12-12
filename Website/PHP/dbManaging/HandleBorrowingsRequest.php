<?php
function HandleBorrowingRequest($method){
    require __DIR__ . "/../config/config.php";
    require "./ConvertIDToString.php";
    global $conn;
    if ($method == "GET"){
        $username = isset($_GET["Username"])? " and Users.username = '" . $_GET["Username"] . "'" : " ";
        $BookTitle = isset($_GET["BookTitle"])? " and books.title = '" . $_GET["BookTitle"]. "'" : " ";
        $BorrowDate = isset($_GET["BorrowDate"])? " and borrowings.BorrowDate = '" .  $_GET["BorrowDate"] . "'" : " ";
        $ReturnDate = isset($_GET["ReturnDate"])? " and borrowings.ReturnDate = '" .   $_GET["ReturnDate"] . "'" : " ";
        $DueDate = isset($_GET["DueDate"])? " and borrowings.DueDate = '" .  $_GET["DueDate"] . "'" : " ";
        $IsReturned = isset($_GET["IsReturned"])? " and borrowings.IsReturned =" .   $_GET["IsReturned"] : " ";
        $sql = "SELECT Users.username, books.title, borrowings.BorrowDate, borrowings.ReturnDate, borrowings.DueDate, borrowings.IsReturned
        from books,borrowings,users
        where books.BookId = borrowings.BookID and borrowings.userID = users.userID $username $BookTitle $BorrowDate $ReturnDate $DueDate $IsReturned";
    
        if ($result = $conn->query($sql)->fetch_all(MYSQLI_ASSOC)){
            if (count($result) > 0){
                echo json_encode($result);
            }
            else{
                echo json_encode(["Error" => "There are no rows with these parameters!"]);
            }
        }
        

    }
    if ($method == "POST"){
        $rawBody = file_get_contents('php://input');
        $decoded = json_decode($rawBody, true);
        if (isset($decoded["ISBN"])){
            $decoded["bookID"] = checkdata("books",["ISBN", "bookID"],"bookID", $decoded["ISBN"]);
        }
        if (isset($decoded["Username"])){
            $decoded["UserID"] = checkdata("users",["Username", "UserID"],"UserID", $decoded["Username"]);
        }
        $sql = "insert into borrowings(userID,bookID,borrowDate,returnDate,DueDate,IsReturned) values( " . $decoded["UserID"] . " , " . $decoded["BookID"] . ", '" . $decoded["BorrowDate"] . "', '" . $decoded["ReturnDate"] . "', '" . $decoded["DueDate"] . "', " . $decoded["IsReturned"] . ")";
        if ($conn->query($sql)){
            echo json_encode(["Success:" => "The line was successfully inserted!"]);
        }
        else{
            echo json_encode(["Success:" => "Wrong input!"]);
        }
        
    }
}

?>