<?php
####################  This function send an email to the current user who tried to register.                        ####################
####################  Get the user information from session storage and destroy if the verification was successful.  ####################
function verify(){
    require_once __DIR__ . "/../InputMethods.php";
    $_SESSION["verifyCode"] ?? errorOutput("10");
    $body = getPostBody();
    if ($body["verifyCode"] == $_SESSION["verifyCode"]){
        require_once __DIR__ . "/../config/connect.php";
        $conn = connect();
        $user = $_SESSION["register"] ?? errorOutput("12");
        $sql = "INSERT into users(email,username,firstname,lastname,password,RoleID) 
                values( '" . $user["email"] . "' , '" .  $user["username"] . "' , '" . $user["firstName"] . "' , '" . $user["lastName"] . "' , '" . $user["password"] . "'," . "3". " ) ";
        if ($conn->query($sql) === TRUE) {
            echo json_encode(["Success" => "registration was successful"]);
            unset($_SESSION["verifyCode"]);
            unset($_SESSION["register"]);
            die();
          } else {
            errorOutput("13");
          }
    }
    else {
        errorOutput("11");
    }
}


?>