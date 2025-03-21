<?php

namespace Database\Queries;

class BorrowingsTable extends Table{

    public static function borrowingsByParams($fields =[], $operators = [], $values = [],$types = []){
        if (count($fields) == 0){
            return self::select(["borrowings"],["*"])->execute(true);
        }
        return self::select(["borrowings"],["*"])->where([...$fields],[...$operators],[...$values],[...$types])->execute(true);
    }
    public static function allBorrowings(){
        return self::select(["borrowings_storage"],["count(ISBN) AS borrowings"])->execute(true);
    }
    public static function bookInBorrowings($ISBN){
        return self::select(["borrowings"],["ISBN"])->where(["ISBN","returnDate"],["=","IS"],[$ISBN,"NULL"],["i","i"])->execute(true,false);
    }
}

?>