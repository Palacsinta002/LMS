<?php

namespace Database\Queries;

class ReservationTable extends Table{
    public static function reserve($ISBN,$userID){
        self::insert("Reservations",["ISBN","userID"],[$ISBN,$userID],["i","i"])->execute(false,false);
        
    }

    public static function deleteReservation($ISBN){
        self::delete("Reservations")
        ->where(["ISBN"],["="],[$ISBN],["i"])->execute(false,false);
    }

    public static function bookInReservation($ISBN){
        return self::select(["Reservations"],["ISBN"])
        ->where(["ISBN"],["="],[$ISBN],["i"])->execute(true,false);
    }
    public static function countUserReservations($userID){
        return self::select(["Reservations"],["count(ISBN) as userReservations"])
        ->where(["userID"],["="],[$userID],["i"])->execute(true);
    }
    public static function selectByISBN($ISBN,$fetch = false){
        return self::select(["Reservations"],["*"])
        ->where(["ISBN"],["="],[$ISBN],["i"])->execute(true,$fetch);
    }
    public static function selectMyReservations($userID){
        return self::select(["Reservations"],[
            "reservations.ISBN",
            "reservations.ReservationStartDate",
            "reservations.ReservationEndDate",
            "publishers.Publisher",
            "books.Title","GROUP_CONCAT(DISTINCT Authors.Author SEPARATOR ',') as 'Authors'",
            "GROUP_CONCAT(DISTINCT categories.category SEPARATOR ',') as 'Category'","books.publicationYear"
            ])
        ->innerJoin("books",["books.ISBN"],["="],["reservations.ISBN"])
        ->innerJoin("Publishers",["Publishers.ID"],["="],["books.PublisherID"])
        ->innerJoin("Books_authors",["Books.ISBN"],["="],["Books_Authors.ISBN"])
        ->innerJoin("Authors",["Books_Authors.AuthorID"],["="],["Authors.ID"])
        ->innerJoin("Books_Categories",["Books.ISBN"],["="],["Books_Categories.ISBN"])
        ->innerJoin("Categories",["Books_Categories.CategoryID"],["="],["Categories.ID"])
        ->where(["reservations.userID"],["="],[$userID],["i"])
        ->groupBy(["publishers.Publisher","books.Title","books.publicationYear"])
        ->execute(true);
    }
}


?>