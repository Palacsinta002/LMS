<?php

class UserRegisterClass{
    
    private $email;
    public function setEmail($email){
        $this->email = $email;
    }
    public function getEmail(){
        return($this->email);
    }
    
    private $username;
    public function setusername($username){
        $this->username = $username;
    }
    public function getusername(){
        return($this->username);
    }

    private $firstName;
    public function setfirstName($firstName){
        $this->firstName = $firstName;
    }
    public function getfirstName(){
        return($this->firstName);
    }

    private $lastName;
    public function setlastName($lastName){
        $this->lastName = $lastName;
    }
    public function getlastName(){
        return($this->lastName);
    }

    private $password;
    public function setpassword($password){
        $this->password = $password;
    }
    public function getpassword(){
        return($this->password);
    }

    private $password2;
    public function setpassword2($password2){
        $this->password2 = $password2;
    }
    public function getpassword2(){
        return($this->password2);
    }
    

    public function __construct($email,$username,$firstName,$lastName,$password,$password2) {
        $this->email = $email;
        $this->username = $username;
        $this->firstName = $firstName;
        $this->lastName = $lastName;
        $this->password = $password;
        $this->password2 = $password2;
    }
    public function getConn():mysqli{
        require __DIR__ . "/../config/connect.php";
        return $conn;
        
    }
    public function sendVerificationEmail(){
        if ($this->verifyEmail() == true){
            $verifyCode = "";
            for ($i=0; $i < 6; $i++) {
                $randomNumb = rand(0,10);
                $verifyCode.= "$randomNumb";
            }
        };
    }
    public function verifyEmail() {
        if (filter_var($this->email, FILTER_VALIDATE_EMAIL)){
            require_once __DIR__ . "/../config/connect.php";
            $conn = connect();
            $sql = "SELECT Email from users where Email = '$this->email'";
            $result = $conn->query($sql);
            if ($result->num_rows > 0){
                return true;
            }
            else{
                echo json_encode(["error" => "1"]);
                die();
            }
            
        }
        else{
            echo json_encode(["error" => "0"]);
            die();
        }
    }
    

}



?>