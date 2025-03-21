<?php

namespace Database\Queries;

class BooksTable extends Table{
    public static function selectByParams($fields =[], $operators = [], $values = [],$types = []){
        if (count($fields) == 0) {
            return self::select(["books"],["books.ISBN","publishers.Publisher","books.Title","GROUP_CONCAT(DISTINCT Authors.Author SEPARATOR ',') as 'Authors'","GROUP_CONCAT(DISTINCT categories.category SEPARATOR ',') as 'Category'","books.publicationYear"])
            ->innerJoin("Publishers",["Publishers.ID"],["="],["books.PublisherID"])
            ->innerJoin("Books_authors",["Books.ISBN"],["="],["Books_Authors.ISBN"])
            ->innerJoin("Authors",["Books_Authors.AuthorID"],["="],["Authors.ID"])
            ->innerJoin("Books_Categories",["Books.ISBN"],["="],["Books_Categories.ISBN"])
            ->innerJoin("Categories",["Books_Categories.CategoryID"],["="],["Categories.ID"])
            ->groupBy(["Books.Title", "Books.PublicationYear", "Publishers.Publisher", "Books.ISBN"])->execute(true);
        }
        return self::select(["books"],["books.ISBN","publishers.Publisher","books.Title","GROUP_CONCAT(DISTINCT Authors.Author SEPARATOR ',') as 'Authors'","GROUP_CONCAT(DISTINCT categories.category SEPARATOR ',') as 'Category'","books.publicationYear"])
        ->innerJoin("Publishers",["Publishers.ID"],["="],["books.PublisherID"])
        ->innerJoin("Books_authors",["Books.ISBN"],["="],["Books_Authors.ISBN"])
        ->innerJoin("Authors",["Books_Authors.AuthorID"],["="],["Authors.ID"])
        ->innerJoin("Books_Categories",["Books.ISBN"],["="],["Books_Categories.ISBN"])
        ->innerJoin("Categories",["Books_Categories.CategoryID"],["="],["Categories.ID"])
        ->where($fields,$operators,$values,$types)
        ->groupBy(["Books.Title", "Books.PublicationYear", "Publishers.Publisher", "Books.ISBN"])->execute(true);
    }
    public static function countAllBooks(){
        return self::select(["books"],["count(ISBN) AS books"])->execute(true);
    }
    public static function selectTopBooks($ISBNList){
        return self::select(["books"],["books.ISBN","books.Title","GROUP_CONCAT(DISTINCT Authors.Author SEPARATOR ',') as 'Authors'"])
        ->innerJoin("Books_authors",["Books.ISBN"],["="],["Books_Authors.ISBN"])
        ->innerJoin("Authors",["Books_Authors.AuthorID"],["="],["Authors.ID"])
        ->where(["books.ISBN"],["IN"],[$ISBNList],["i"])
        ->groupBy(["Books.Title", "Books.ISBN"])
        ->execute(true);
    }
    public static function selectByISBN($ISBN, $fetch = false){
        return self::select(["books"],["ISBN"])->where(["ISBN"],["="],[$ISBN],["i"])->execute(true, $fetch);
    }
}
?>