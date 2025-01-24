<?php
####################    ####################

class UserRegisterClass{
    
    private $email;
    ####################  setting Email and validate the input  ####################
    public function setEmail($email){
        if (filter_var($email, FILTER_VALIDATE_EMAIL)){
            require_once __DIR__ . "/../config/connect.php";
            $conn = connect();
            $sql = "SELECT Email from users where Email = '$this->email'";
            $result = $conn->query($sql);
            if ($result->num_rows == 0){
                $this->email = $email;
                $conn->close();
            }
            else{
                $conn->close();
                errorOutput("1");
                
            }
            
        }
        else{
            errorOutput("0");
        }
        
    }
    ####################  Get the Email  ####################
    public function getEmail(){
        return($this->email);
    }
    
    private $username;
    ####################  Set the username and validate the input  ####################
    public function setUsername($username){
        $username = validateTheInput($username);
        
        if (strlen($username) < 30){
            $this->username = $username;
        }
        else{
            errorOutput("3");
        }
        
    }
    ####################  Get the username  ####################
    public function getUsername(){
        return($this->username);
        
    }
    
    private $firstName;
    ####################  Set the firstname and validate the input  ####################
    public function setFirstName($firstName){
        $pattern = "/^[A-ZÁRVÍZTŰRŐTÜKÖRFÚRÓGÉP][a-zárvíztűrőtükörfúrógép]+$/";
        if (preg_match($pattern,$firstName)){
            if (strlen($firstName) < 30){
                $this->firstName = $firstName;
            }
            else{
                
                errorOutput("4");
            }
        }
        else{
            errorOutput("4");
        }
       
        
    }
    ####################  Get the firstname  ####################
    public function getFirstName(){
        return($this->firstName);
    }

    private $lastName;

    ####################  Set the lastname and validate the input  ####################
    public function setLastName($lastName){
        $pattern = "/^[A-ZÁRVÍZTŰRŐTÜKÖRFÚRÓGÉP][a-zárvíztűrőtükörfúrógép]+$/";
        if (preg_match($pattern,$lastName)){
            if (strlen($lastName) < 30){
                $this->lastName = $lastName;
            }
            else{
                errorOutput("5");
            }
        }
        else{
            errorOutput("5");
        }
        
    }
    ####################  Get the lastname  ####################
    public function getLastName(){
        return($this->lastName);
    }

    private $password;

    ####################  Set the password and validate the input  ####################
    public function setPassword($password){
        if (strlen($password > 8) && strlen($password) < 16){
            
            if (preg_match('/^(?=.*[a-z])(?=.*[A-Z])(?=.*[\d\W]).+$/', $password)){
                
                $this->password = validateTheInput($password);
            }
            else{
                errorOutput("6");
            }
        }
        else{
            errorOutput("6");
        }
        
    }
    ####################  Get the password  ####################
    public function getPassword(){
        return($this->password);
    }

    private $password2;
    public function setPassword2($password2){
        $this->password2 = $password2;
    }
    public function getPassword2(){
        return($this->password2);
    }
    

    public function __construct($email,$username,$firstName,$lastName,$password,$password2) {
        require_once __DIR__ . "/../InputMethods.php";
        $this->setEmail($email);
        $this->setUsername($username);
        $this->setFirstName($firstName);
        $this->setLastName($lastName);
        $this->setPassword($password);
        $this->password2 = $password2;
    }
    
    public function sendVerificationEmail(){
        
            $verifyCode = "";
            for ($i=0; $i < 5; $i++) {
                $randomNumb = rand(0,10);
                $verifyCode.= "$randomNumb";
            }
            require_once __DIR__ . "/../sendEmail/sendEmail.php";
            sendEmail($this->email,$this->lastName,"It is your verification Email","<html> <p>Your verification code is <b>$verifyCode</b> . <br> Please enter this code to the field on the main page.</p> <p>This is an automatic message. Don't answer to this mail!</p> <html>");
        
    }
    public function verifyEmail() {
        if (filter_var($this->email, FILTER_VALIDATE_EMAIL)){
            require_once __DIR__ . "/../config/connect.php";
            $conn = connect();
            $sql = "SELECT Email from users where Email = '$this->email'";
            $result = $conn->query($sql);
            if ($result->num_rows == 0){
                $conn->close();
                return true;
                
            }
            else{
                echo json_encode(["error" => "1"]);
                $conn->close();
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