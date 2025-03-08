<?php
require 'vendor/autoload.php';

use Firebase\JWT\JWT;
use Firebase\JWT\Key;

function makeToken($secretKey) {
// Create Token
$payload = [
    "iss" => "http://localhost:5173",
    "iat" => time(),
    "exp" => time() + 3600,
];
return JWT::encode($payload, $secretKey, 'HS256');
}

// Decode Token
try {
    $decoded = JWT::decode($token, new Key($secretKey, 'HS256'));
    echo "Decoded Token:\n";
    print_r($decoded);
} catch (Exception $e) {
    echo "Invalid Token: " . $e->getMessage();
}
?>
