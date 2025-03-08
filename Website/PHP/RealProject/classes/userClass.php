<?php
# This file contains the user calss this class is for the user login.
# 

class UserClass{
    private $username;

    public function __construct($username,$password) {
        require_once __DIR__ . "/../InputMethods.php";
        
        $this->setUsernameAndPassword($username,$password);
        
    }

    public function setUsernameAndPassword($username,$password){
        require_once __DIR__ . "/../config/connect.php";
        $conn = connect();
        $username = validateTheInput($username);
        $password = validateTheInput($password);
        
        $sql = "SELECT users.id, users.username, users.password, users.roleID, users.firstname, users.lastname, users.email from users where username = '$username'";
        $result = $conn->query($sql);
        ####################  logged in  ####################
        if ($result->num_rows > 0){
            
            $data = $result -> fetch_all(MYSQLI_ASSOC);
            if (password_verify($password,$data[0]["password"])){
                $envVariables = include_once __DIR__ ."/../config/config.php";
                $JWT_KEY = $envVariables["JWT_KEY"];
                echo json_encode(["token" => makeToken($JWT_KEY,$data[0]["username"],$data[0]["id"])]);
            }
        else{
            errorOutput("7");}
        }
        else{
            errorOutput("7");
        }

        $conn->close();
        

    } 

}

?>