<?php

namespace Database\Queries;

class ReservationTable extends Table{
    public static function reserve($ISBN,$userID){
        self::insert("Reservations",["ISBN","userID"],[$ISBN,$userID],["i","i"])->execute(false,false);
        
    }

    public static function deleteReservation($ISBN){
        self::delete("Reservations")->where(["ISBN"],["="],[$ISBN],["i"])->execute(false,false);
    }

    public static function bookInReservation($ISBN){
        return self::select(["Reservations"],["ISBN"])->where(["ISBN"],["="],[$ISBN],["i"])->execute(true,false);
    }
    public static function countUserReservations($userID){
        return self::select(["Reservations"],["count(ISBN) as userReservations"])->where(["userID"],["="],[$userID],["i"])->execute(true);
    }
    public static function selectByISBN($ISBN,$fetch = false){
        return self::select(["Reservations"],["*"])->where(["ISBN"],["="],[$ISBN],["i"])->execute(true,$fetch);
    }
}


?>