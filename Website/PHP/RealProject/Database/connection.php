<?php

namespace Database;

use Config\Env;
use ApiResponse\Response;
class Connection{

    public static function connect(){
        Env::load();
        $conn = new \mysqli($_ENV["DB_HOST"], $_ENV["DB_USER"], $_ENV["DB_PASSWORD"], $_ENV["DB_NAME"]);
        if ($conn->connect_error) {
            Response::httpError(500, $conn->connect_error);
        }
        if (isset(getallheaders()["Test"])){
            $conn->autocommit(false);
        }
        return $conn;
        
        }
}
?>