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

    public static function topBorrowedBooks($limit){
        Borrowing::validateID($limit);
        Response::httpSuccess(200,BorrowingAndBooksTable::selectTopBorrowedBook($limit));
        
    }
    public static function availableBooks($body){
        Response::httpSuccess(200,BorrowingAndBooksTable::selectAvailableBooks());
        
    }
}
?>