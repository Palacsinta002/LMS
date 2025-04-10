<?php
namespace App\Controllers;
use App\Validations\Borrowing;
use Database\Queries\BorrowingsTable;
use ApiResponse\Response;

class BorrowingsController{
    public static function allBorrowings($body){
        Response::httpSuccess(200, BorrowingsTable::allBorrowings());
    }
    public static function show($body,$userID = null){
        Response::httpSuccess(200, BorrowingsTable::selectMyBooks($userID));
    }

    public static function topBorrowedBooks($limit){
        Borrowing::validateID($limit);
        Response::httpSuccess(200,BorrowingsTable::selectTopBorrowedBook($limit));

    }
}

?>