<?php

namespace App\Controllers;

use ApiResponse\Response;
use Database\Queries\IdeiglenesBooksBorrowings;
class Ideiglenes{

    public static function borrowingBooks(){
        Response::httpSuccess(200, IdeiglenesBooksBorrowings::query());
    }
}
?>