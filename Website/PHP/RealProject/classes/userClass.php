<?php

class UserClass{
    private $username;

    private $roleID;

    private $firstName;

    private $lastName;

    private $email;

    public function __construct($username,$password) {
        require_once __DIR__ . "/../InputMethods.php";
        $this->setUsernameAndPassword($username,$password);
        
    }

    function setUsernameAndPassword($username,$password){
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
            $this->username = html_entity_decode($data[0]["username"]);
            $this->roleID = html_entity_decode($data[0]["roleID"]);
            $this->firstName = html_entity_decode($data[0]["firstname"]);
            $this->lastName = html_entity_decode($data[0]["lastname"]);
            $this->email = html_entity_decode($data[0]["email"]);
            
            echo json_encode(["Success"=> "Successfully logged in as $username"]);
        }
        else{
            errorOutput("7");}
        }
        else{
            errorOutput("7");
        }

        $conn->close();
        

    }

    function getUsername(){
        return $this->username;
    }

    


}

?>