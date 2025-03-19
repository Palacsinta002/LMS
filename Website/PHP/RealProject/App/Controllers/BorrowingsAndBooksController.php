<?php

namespace App\Controllers;
use ApiResponse\Response;
use Database\Queries\BorrowingAndBooksTable;
use Helper\Helper;
use App\Models\Borrowing;
class BorrowingsAndBooksController{
    public static function getMyBorrowedBooks($body,$userID = null){

        Response::httpSuccess(200, BorrowingAndBooksTable::selectMyBooks($userID));
    }

    public static function topBorrowedBooks($body){
        $body = Helper::validateTheInputArray($body);
        if (($body = Borrowing::checkRequiredData($body,["limit"])) == false){
            Response::httpError(200,21);
        };
        Borrowing::callingValidateFunctions($body,["limit"],Borrowing::class,"checkLimit");
        Response::httpSuccess(200,BorrowingAndBooksTable::selectTopBorrowedBook($body["limit"]));
        
    }
}
?>