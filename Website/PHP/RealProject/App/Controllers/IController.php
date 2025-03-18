<?php
namespace App\Controllers;

interface IController{
    public static function getFromDBByParams($body);
}
?>