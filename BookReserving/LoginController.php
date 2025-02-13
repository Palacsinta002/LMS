<?php

class userLoginController {
    public function __construct($username, $password) {
        require_once 'conn.php';

        $this->login($username, $password);
        
    }

    public function login($username, $password) {
        $pdo = connect();
        $sqlPrepared = $pdo->prepare("SELECT * FROM users WHERE username = ? AND password = ?");
        $sqlPrepared->execute([$username, $password]);
        if ($sqlPrepared->rowCount() > 0) {
            $user = $sqlPrepared->fetch(PDO::FETCH_ASSOC);
            $_SESSION['userID'] = $user['id'];
            header("Location: index.php");
        } else {
            echo "Hibás felhasználónév vagy jelszó!";
        }
        
    }
}


?>