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
        return self::select(["borrowings"],["books.Title","GROUP_CONCAT(DISTINCT Authors.Author SEPARATOR ',') as 'Authors'","Count(Borrowings.ID)","books.publicationYear"])
        ->innerJoin("books",["books.ISBN"],["="],["borrowings.ISBN"])
        ->innerJoin("Books_authors",["Books.ISBN"],["="],["Books_Authors.ISBN"])
        ->innerJoin("Authors",["Books_Authors.AuthorID"],["="],["Authors.ID"])
        ->groupBy(["books.Title","books.publicationYear"])
        ->orderBy(["Count(Borrowings.ID)"],false)
        ->limit($limit)->execute(true);
    }
}

?>