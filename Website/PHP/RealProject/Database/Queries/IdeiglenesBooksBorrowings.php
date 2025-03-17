<?php

namespace Database\Queries;

class IdeiglenesBooksBorrowings extends Table{

    public static function query($fields =[], $operators = [], $values = [],$types = []){
        return self::select(["books"],["books.ISBN","publishers.Publisher","books.Title","GROUP_CONCAT(DISTINCT Authors.Author SEPARATOR ',') as 'Authors'","GROUP_CONCAT(DISTINCT categories.category SEPARATOR ',') as 'Category'","books.publicationYear","borrowings.borrowDate","borrowings.DueDate","borrowings.returnDate"])
            ->innerJoin("Publishers",["Publishers.ID"],["="],["books.PublisherID"])
            ->innerJoin("Books_authors",["Books.ISBN"],["="],["Books_Authors.ISBN"])
            ->innerJoin("Authors",["Books_Authors.AuthorID"],["="],["Authors.ID"])
            ->innerJoin("Books_Categories",["Books.ISBN"],["="],["Books_Categories.ISBN"])
            ->innerJoin("Categories",["Books_Categories.CategoryID"],["="],["Categories.ID"])
            ->innerJoin("borrowings",["books.ISBN"],["="],["borrowings.ISBN"])
            ->groupBy(["Books.Title", "Books.PublicationYear", "Publishers.Publisher", "Books.ISBN"])->execute(true);
    }
}

?>