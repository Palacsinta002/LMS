<?php

namespace App\Controllers;

use Database\Queries\ReservationTable;
use App\Models\Model;
use Helper\Helper;
use ApiResponse\Response;
use Database\Queries\BooksTable;
use Database\Queries\BorrowingsTable;


class ReservationController{
    public static function reserve($body,$userID){
        $body = Helper::validateTheInputArray($body);
        if (!($body = Model::checkRequiredData($body,["ISBN"]))){
            Response::httpError(400,21);
        }
        Model::validateISBN($body["ISBN"]);
        if (BorrowingsTable::bookInBorrowings($body["ISBN"])->num_rows != 0){
            Response::httpError(400,32);
        }
        if (ReservationTable::bookInReservation($body["ISBN"])->num_rows != 0){
            Response::httpError(400,32);
        }
        if (BooksTable::selectByISBN($body["ISBN"])->num_rows == 0){
            Response::httpError(400,32);
        }
        if (ReservationTable::countUserReservations($userID)[0]["userReservations"] >= 3){
            Response::httpError(400,32);
        }

        ReservationTable::reserve($body["ISBN"],$userID);
        Response::httpSuccess(200,["Success"=>"Reservation made"]);
    }

    public static function delete($ISBN,$userID){
        $body = Helper::validateTheInput($ISBN);
        if (ReservationTable::selectByISBN($ISBN,true)["userID"] != $userID){
            Response::httpError(400,32);
        }
        model::validateISBN($body["ISBN"]);
        ReservationTable::deleteReservation($body["ISBN"]);
        Response::httpSuccess(200,["Success"=>"Reservation deleted"]);
    }

}

?>