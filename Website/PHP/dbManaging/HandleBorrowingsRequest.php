<?php
function HandleBorrowingRequest($method){
    require __DIR__ . "/../config/config.php";
    require "./ConvertIDToString.php";
    global $conn;


    if ($method == "GET"){
        $username = isset($_GET["Username"])? " and Users.username = '" . $_GET["Username"] . "'" : "";
        $BookTitle = isset($_GET["BookTitle"])? " and books.title = '" . $_GET["BookTitle"]. "'" : "";
        $BorrowDate = isset($_GET["BorrowDate"])? " and borrowings.BorrowDate = '" .  $_GET["BorrowDate"] . "'" : "";
        $ReturnDate = isset($_GET["ReturnDate"])? " and borrowings.ReturnDate = '" .   $_GET["ReturnDate"] . "'" : "";
        $DueDate = isset($_GET["DueDate"])? " and borrowings.DueDate = '" .  $_GET["DueDate"] . "'" : "";
        $IsReturned = isset($_GET["IsReturned"])? " and borrowings.IsReturned =" .   $_GET["IsReturned"] : "";
        $sql = "SELECT Users.username, books.title, borrowings.BorrowDate, borrowings.ReturnDate, borrowings.DueDate, borrowings.IsReturned from books,borrowings,users where books.BookId = borrowings.BookID and borrowings.userID = users.userID $username $BookTitle $BorrowDate $ReturnDate $DueDate $IsReturned";

        if ($result = $conn->query($sql)->fetch_all(MYSQLI_ASSOC)){
            if (count($result) > 0){
                echo json_encode($result);
            }
            else{
                echo json_encode(["Error" => "There are no rows with these parameters!"]);
            }
        }
        else{
            echo json_encode(["Error" => "There are no rows with these parameters!"]);
        }
        

    }


    if ($method == "POST"){
        $rawBody = file_get_contents('php://input');
        $decoded = json_decode($rawBody, true);
        foreach ($decoded as $key => $value) {

            $decoded[$key] = $value == "-" ? null : $value;
            if ( $key == "IsReturned"){ $decoded[$key] = $value == "-" ? 0 : $value;}
            if (strlen($value) == 0 && $key != "ReturnDate"){
                echo json_encode(["Error" => "Missing required data!"]);
            }
        }
        
        if (isset($decoded["ISBN"])){

            $decoded[] = "BookID";
            $decoded["BookID"] = checkdata("books",["bookID","ISBN"],"ISBN", $decoded["ISBN"]);
            
        }
            
           
        if (isset($decoded["Username"])){
            $decoded[] = "UserID";
            $decoded["UserID"] = checkdata("users",["UserID", "Username"],"Username", $decoded["Username"]);
        }
        
        $sql = "insert into borrowings(userID,bookID,borrowDate,returnDate,DueDate,IsReturned) values( " . $decoded["UserID"] . " , " . $decoded["BookID"] . ", '" . $decoded["BorrowDate"] . "', '" . $decoded["ReturnDate"] . "', '" . $decoded["DueDate"] . "', " . $decoded["IsReturned"] . ")";
        if ($conn->query($sql)){
            echo json_encode(["Success:" => "The line was successfully inserted!"]);
        }
        else{
            echo json_encode(["Success:" => "Wrong input!"]);
        }
        
    }

    
    if ($method == "PATCH"){
        $rawBody = file_get_contents('php://input');
        $decoded = json_decode($rawBody, true);
        $current = $decoded["current"];
        $newdata = $decoded["new"];
        #first convert

       if (isset($current["ISBN"])){
            

            $current["Book"] = checkdata("books",["bookID","ISBN"],"ISBN", $current["ISBN"]);
            unset($current["ISBN"]);
            
        }
        if (isset($current["Username"])){

            $current["User"] = checkdata("users",["UserID", "Username"],"Username", $current["Username"]);
            unset($current["Username"]);
        }

        #second convert
        if (isset($newdata["ISBN"])){

            $newdata["Book"] = checkdata("books",["bookID","ISBN"],"ISBN", $newdata["ISBN"]);
            unset($newdata["ISBN"]);
            
        }
        if (isset($newdata["Username"])){

            $newdata["User"] = checkdata("users",["UserID", "Username"],"Username", $newdata["Username"]);
            unset($newdata["Username"]);
        }

        $sql = "UPDATE borrowings set ". equalize($newdata, ["Book","User"]) . " where " . equalizeAND($current,["Book","User"]);

        if ($conn->query($sql)){
            echo json_encode(["Success" => "row(s) successfully updated!"]);
        }
        else {
            echo json_encode(["Error" => "Something went wrong!"]);
        }
    }
    if ($method == "DELETE")
    {
        $rawBody = file_get_contents('php://input');
        $decoded = json_decode($rawBody, true);

        if (isset($decoded["ISBN"])){

            $decoded["Book"] = checkdata("books",["bookID","ISBN"],"ISBN", $decoded["ISBN"]);
            unset($decoded["ISBN"]);
            
        }
        if (isset($decoded["Username"])){

            $decoded["User"] = checkdata("users",["UserID", "Username"],"Username", $decoded["Username"]);
            unset($decoded["Username"]);
        }
        
        $sql = "DELETE from borrowings where ". equalizeAND($decoded, ["Book","User"]);
        if ($conn->query($sql)){
            echo json_encode(["Success" => "row(s) successfully deleted"]);
        }
        else {
            echo json_encode(["Error" => "Something went wrong!"]);
        }
    }
}

?>