<?php
$email = "NiNcs";
$pattern = "/^[A-Z][a-z]+$/";

if (preg_match($pattern, $email)) {
    echo "Valid name!";
} else {
    echo "Invalid name.";
}
?>