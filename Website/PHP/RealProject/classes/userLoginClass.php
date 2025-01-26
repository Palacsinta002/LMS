<?php

class UserLoginClass{
    private $username;

    function setUsername($username){
        require_once __DIR__ . "/../config/connect.php";
        $conn = connect();
        $username = validateTheInput($username);
        ####################  missing sql  ####################
        return "";
    }

    function getUsername(){
        return $this->username;
    }

    private $password;

    function setPassword($password){
        return "";
    }

    function getPassword(){
        return $this->password;
    }

    public function __construct($username,$password) {
        require_once __DIR__ . "/../InputMethods.php";
        $this->username = $this->setUsername($username);
        $this->password = $this->setPassword($password);
    }

}

?>