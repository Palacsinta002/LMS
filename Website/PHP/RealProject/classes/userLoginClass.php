<?php

class UserClass{
    private $username;

    private $roleID;

    private $firstName;

    private $lastName;



    function setUsernameAndPassword($username,$password){
        require_once __DIR__ . "/../config/connect.php";
        $conn = connect();
        $username = validateTheInput($username);
        $password = validateTheInput($password);
        
        $sql = "SELECT users.userid,users.username,users.roleID,users.firstname,users.lastname from users where username = '$username' and password = '$password'";
        $result = $conn->query($sql);
        ####################  logged in  ####################
        if ($result->num_rows > 0){
            $data = $result -> fetch_all(MYSQLI_ASSOC);
            $this->username = html_entity_decode($data[0]["username"]);
            $this->roleID = html_entity_decode($data[0]["roleID"]);
            $this->firstName = html_entity_decode($data[0]["firstName"]);
            $this->lastName = html_entity_decode($data[0]["lastName"]);
        }
        else{
            errorOutput("7");
        }

        $conn->close();

    }

    function getUsername(){
        return $this->username;
    }

    public function __construct($username,$password) {
        require_once __DIR__ . "/../InputMethods.php";
        $this->setUsernameAndPassword($username,$password);
        
    }

}

?>