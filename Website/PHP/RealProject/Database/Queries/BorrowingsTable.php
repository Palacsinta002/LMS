<?php

namespace Database\Queries;

class BorrowingsTable extends Table{

    //ez sem kell
    public static function borrowingsByParams($fields =[], $operators = [], $values = [],$types = []){
        if (count($fields) == 0){
            return self::select(["borrowings"],["*"])->execute(true);
        }
        return self::select(["borrowings"],["*"])->where(
            [...$fields],
            [...$operators],
            [...$values],
            [...$types])
            ->execute(true);
    }
    public static function allBorrowings(){
        return self::select(["borrowings_storage"],["count(ISBN) AS borrowings"])->execute(true);
    }
    public static function bookInBorrowings($ISBN){
        return self::select(["borrowings"],["ISBN"])->where(
            ["ISBN","returnDate"],
            ["=","IS"],
            [$ISBN,"NULL"],
            ["i","i"])
            ->execute(true,false);
    }
    public static function selectMyBooks($userID){
        return self::select(["borrowings"],[
            "borrowings.ISBN",
            "publishers.Publisher",
            "books.Title",
            "GROUP_CONCAT(DISTINCT Authors.Author SEPARATOR ',') as 'Authors'",
            "GROUP_CONCAT(DISTINCT categories.category SEPARATOR ',') as 'Category'",
            "books.publicationYear","borrowings.BorrowDate","borrowings.DueDate","borrowings.ReturnDate"
            ])
        ->innerJoin("books",["books.ISBN"],["="],["borrowings.ISBN"])
        ->innerJoin("Publishers",["Publishers.ID"],["="],["books.PublisherID"])
        ->innerJoin("Books_authors",["Books.ISBN"],["="],["Books_Authors.ISBN"])
        ->innerJoin("Authors",["Books_Authors.AuthorID"],["="],["Authors.ID"])
        ->innerJoin("Books_Categories",["Books.ISBN"],["="],["Books_Categories.ISBN"])
        ->innerJoin("Categories",["Books_Categories.CategoryID"],["="],["Categories.ID"])
        ->where(["borrowings.userID"],["="],[$userID],["i"])
        ->groupBy(["borrowings.ISBN","publishers.Publisher","books.Title","books.publicationYear","borrowings.borrowDate","borrowings.DueDate","borrowings.ReturnDate"])
        ->orderBy(["borrowings.borrowDate"],false)
        ->execute(true);
    }
    public static function selectTopBorrowedBook($limit){
        return self::select(
            ["books"],
            [
                "books.ISBN",
                "books.Title",
                "GROUP_CONCAT(DISTINCT Authors.Author SEPARATOR ',') as 'Authors'",
                "GROUP_CONCAT(DISTINCT categories.category SEPARATOR ',') as 'Category'",
                "COUNT(DISTINCT borrowings.ID) AS BorrowCount", 
                "books.publicationYear"
            ]
        )
        ->innerJoin("borrowings", ["books.ISBN"], ["="], ["borrowings.ISBN"])
        ->innerJoin("Books_authors", ["Books.ISBN"], ["="], ["Books_Authors.ISBN"])
        ->innerJoin("Authors", ["Books_Authors.AuthorID"], ["="], ["Authors.ID"])
        ->innerJoin("Books_Categories",["Books.ISBN"],["="],["Books_Categories.ISBN"])
        ->innerJoin("Categories",["Books_Categories.CategoryID"],["="],["Categories.ID"])
        ->groupBy(["books.Title", "books.publicationYear"])
        ->orderBy(["BorrowCount"], false) 
        ->limit($limit)
        ->execute(true);
    }
}

?>