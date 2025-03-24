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
        Helper::validateTheInput($ISBN);
        $howsBook = ReservationTable::selectByISBN($ISBN,true);
        if (count($howsBook) == 0 || $howsBook[0]["UserID"] != $userID){
            Response::httpError(400,32);
        }
        model::validateISBN($ISBN);
        ReservationTable::deleteReservation($ISBN);
        Response::httpSuccess(200,["Success"=>"Reservation deleted"]);
    }

    public static function myReservations($body,$userID){
        $userID = Helper::validateTheInput($userID);
        Model::validateID( $userID );
        Response::httpSuccess(200,ReservationTable::selectMyReservations($userID));
    }

}

?>