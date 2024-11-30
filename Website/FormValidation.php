<?php
require "config/config.php";

function printing($print)
{
    if ($_SERVER["REQUEST_METHOD"] == "POST") {
        echo $print;
    }
}
#function that check the input that given by user
require_once "./validate.php";

#set up all the variables
$username = "";
$password = "";
$username_error = "";
$password_error = "";
$error = "";
#look for the "POST" method
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $username = validateTheInput($_POST["username"]);
    $password = validateTheInput($_POST["password"]);
    #after getting the validated values this checks if its exists
    if (strlen($username) == 0) {
        $username_error = "Please enter your username.";
    }
    if (strlen($password) == 0) {
        $password_error = "Please enter your password.";
    }

    #login method 
    $sql = "SELECT users.username, users.password ,users.RoleID FROM users WHERE users.username = '$username' AND users.password = '$password'";

    $result = $conn->query($sql);

    #look for the amount of rows if it is 0 that means this user is not exist
    if ($result->num_rows > 0) {
        $row = $result->fetch_assoc();
        $jsondata = json_encode($row);
        if ($row["RoleID"] ==3 )
        {
            
            header('Location: ./userSite.php');
            exit();
        }
        elseif($row["RoleID"] ==2)
        {
            
            
            header('Location: ./userSite.php');
            exit();
        }
        else
        {
            
            header('Location: ./adminSite/adminSite.php');
            exit();
        }
        
    } else 
    {
        if (strlen($username_error) == 0 && strlen($password_error) == 0) {
            $error = "Wrong password or username.";
        }

    }

}