<?php

namespace Config;
use Dotenv\Dotenv;

class Env{

    public static function load(){
        $dotenv = Dotenv::createImmutable(__DIR__);
        $dotenv->load();
    }
}

?>