<?php

namespace Database\Queries;

class BorrowingAndBooksTable extends Table{
    public static function selectMyBooks($userID){
        return self::select(["borrowings"],["borrowings.ISBN","publishers.Publisher","books.Title","GROUP_CONCAT(DISTINCT Authors.Author SEPARATOR ',') as 'Authors'","GROUP_CONCAT(DISTINCT categories.category SEPARATOR ',') as 'Category'","books.publicationYear","borrowings.BorrowDate","borrowings.DueDate","borrowings.ReturnDate"])
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
                "books.Title",
                "GROUP_CONCAT(DISTINCT Authors.Author SEPARATOR ',') as 'Authors'",
                "borrow_count.Count as 'BorrowCount'", 
                "books.publicationYear"
            ]
        )
        ->innerJoin("borrowings", ["books.ISBN"], ["="], ["borrowings.ISBN"])
        ->innerJoin("Books_authors", ["Books.ISBN"], ["="], ["Books_Authors.ISBN"])
        ->innerJoin("Authors", ["Books_Authors.AuthorID"], ["="], ["Authors.ID"])
        ->innerJoin(
            "(SELECT ISBN, COUNT(ID) as Count FROM Borrowings GROUP BY ISBN) as borrow_count",
            ["books.ISBN"],
            ["="],
            ["borrow_count.ISBN"]
        )
        ->groupBy(["books.Title", "books.publicationYear"])
        ->orderBy(["borrow_count.Count"], false) 
        ->limit($limit)
        ->execute(true);
    }
    public static function selectAvailableBooks(){
        $subQueryBorrowed = self::select(["borrowings"], ["ISBN"])
            ->where(["returnDate"], ["IS"], ["NULL"], ["i"])
            ->toString("borrowed_books");

        $subQueryReserved = self::select(["reservations"], ["ISBN"]) 
            ->toString("reserved_books");

        return self::select(["books"],["books.ISBN","publishers.Publisher","books.Title","GROUP_CONCAT(DISTINCT Authors.Author SEPARATOR ',') as 'Authors'","GROUP_CONCAT(DISTINCT categories.category SEPARATOR ',') as 'Category'","books.publicationYear"])
        ->innerJoin("borrowings",["books.ISBN"],["="],["borrowings.ISBN"])
        ->innerJoin("Publishers",["Publishers.ID"],["="],["books.PublisherID"])
        ->innerJoin("Books_authors",["Books.ISBN"],["="],["Books_Authors.ISBN"])
        ->innerJoin("Authors",["Books_Authors.AuthorID"],["="],["Authors.ID"])
        ->innerJoin("Books_Categories",["Books.ISBN"],["="],["Books_Categories.ISBN"])
        ->innerJoin("Categories",["Books_Categories.CategoryID"],["="],["Categories.ID"])
        ->leftJoin($subQueryBorrowed, ["books.ISBN"], ["="], ["borrowed_books.ISBN"])
        ->leftJoin($subQueryReserved, ["books.ISBN"], ["="], ["reserved_books.ISBN"])
        ->where(["borrowed_books.ISBN","reserved_books.ISBN"], ["IS","IS"], ["NULL","NULL"], ["i","i"])
        ->groupBy(["publishers.Publisher","books.Title","books.publicationYear"])
        ->execute(true);
    }
}

?>