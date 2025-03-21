<?php
namespace App\Controllers;
use App\Models\Borrowing;
use Database\Queries\BorrowingsTable;
use Helper\Helper;
use ApiResponse\Response;
use App\Models\Books;
use Database\Queries\BooksTable;
class BorrowingsController implements IController{
    public static function getFromDBByParams($body){
        $body = Helper::validateTheInputArray($body);
        $optionalFields = ["userID","ISBN","borrowDate","dueDate","returnDate"] ;
        $body = Borrowing::checkRequiredData($body,[],$optionalFields);
        Borrowing::callingValidateFunctions($body,["borrowDate","dueDate","returnDate"],Borrowing::class,"checkFormatDate");
        $operators = array_fill(0, count($body),"=");
        
        $types = Borrowing::makeTypesArray($body,$optionalFields,["i","i","s","s","s"]);

        $result = BorrowingsTable::borrowingsByParams(array_keys($body),$operators,array_values($body),$types);
        Response::httpSuccess(200, $result);

    }
    public static function allBorrowings($body){
        Response::httpSuccess(200, BorrowingsTable::allBorrowings());
    }


    
}

?>