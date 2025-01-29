<?php

use PHPMailer\PHPMailer\PHPMailer;
use PHPMailer\PHPMailer\SMTP;
//Import PHPMailer classes into the global namespace
//These must be at the top of your script, not inside a function
require __DIR__ . '/phpmailer/src/Exception.php';
require __DIR__ . '/phpmailer/src/PHPMailer.php';
require __DIR__ . '/phpmailer/src/SMTP.php';
require_once __DIR__ . '/../InputMethods.php';

//Create an instance; passing `true` enables exceptions

function sendEmail($sendToElmail,$sendToName,$subject,$body){
    $mail = new PHPMailer(true);

try {
    //Server settings
    $mail->isSMTP();
    $mail->Host = 'smtp.gmail.com';
    $mail->SMTPAuth = true;
    $mail->Username = 'librarymanagementsystem.emailer@gmail.com';
    $mail->Password = 'cfjncbaukrqfvtzb'; // Replace with your App Password
    $mail->SMTPSecure = PHPMailer::ENCRYPTION_STARTTLS; // TLS encryption
    $mail->Port = 587;

    //Recipients
    $mail->setFrom('librarymanagementsystem.emailer@gmail.com', 'LMS');
    $mail->addAddress($sendToElmail, $sendToName);

    //Content
    $mail->isHTML(true);
    $mail->Subject = $subject;
    $mail->Body = $body;
    

    $mail->send();
    echo json_encode(["Success" => "Email sent"]);
    die();
} catch (Exception $e) {
    errorOutput("2");
}
}