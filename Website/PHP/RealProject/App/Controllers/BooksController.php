<?php

namespace App\Controllers;

use ApiResponse\Response;
use Database\Queries\BooksTable;
use Helper\Helper;
use App\Models\Books;
class BooksController implements IController{
    public static function getFromDBByParams($body){
        $body = Helper::validateTheInputArray($body);
        $body = Books::checkRequiredData($body,[],[["ISBN","books.ISBN"],["publihser","publishers.publisher"],["author","Authors.author"],["category","categories.category"],["title","books.title"],["publicationYear","books.publicationYear"]]);
        Books::callingValidateFunctions($body,["publihser"],Books::class,"validatePublisher");
        Books::callingValidateFunctions($body,["ISBN"],Books::class,"validateISBN");
        Books::callingValidateFunctions($body,["author","category"],Books::class,"validateMultipleValuesOfString");
        Books::callingValidateFunctions($body,["title"],Books::class,"validateTitle");
        Books::callingValidateFunctions($body,["publicationYear"],Books::class,"validateYear");
        $typesAndOperators = Books::makeTypesArray($body,["books.ISBN","publishers.publisher","Authors.author","categories.category","books.title","books.publicationYear"],["i","s","s","s","s","i"],["=","=","LIKE","LIKE","=","="]);
        Response::httpSuccess(200,BooksTable::selectByParams(array_keys($body),array_values($typesAndOperators),array_values($body),array_keys($typesAndOperators)));
    }

    public static function countAllBooks(){
        Response::httpSuccess(200, BooksTable::countAllBooks());
    }

}
?>