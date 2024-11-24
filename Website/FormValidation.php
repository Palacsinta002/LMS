<?php
    require "config/config.php";

    function printing($print){
        if($_SERVER["REQUEST_METHOD"] == "POST"){echo $print;}
    }
    #function that check the input that given by user
    function validateTheInput($input){
        $input = htmlentities($input);
        $input = stripcslashes($input);
        $input = trim($input);
        return $input;
    }
    #set up all the variables
    $username = "";
    $password = "";
    $username_error = "";
    $password_error="";
    $error = "";
    #look for the "POST" method
    if($_SERVER["REQUEST_METHOD"] == "POST"){
        $username = validateTheInput($_POST["username"]);
        $password = validateTheInput($_POST["password"]);

        #after getting the validated values this checks if its exists
        if (strlen($username) == 0){
            $username_error = "Please enter your username.";
        }
        if (strlen($password) == 0){
            $password_error = "Please enter your password.";
        }

        #login method 
        $sql = "SELECT users.username, users.password FROM users WHERE users.username = '$username' AND users.password = '$password'";
    
        $result = $conn->query($sql);

        #look for the amount of rows if it is 0 that means this user is not exist
        if($result->num_rows > 0){
            header('Location: ./books.php');
            exit();
        }
        else{
            if (strlen($username_error) == 0 && strlen($password_error) == 0)
            {
                $error = "Wrong password or username.";
            }
            
        }
    
    }