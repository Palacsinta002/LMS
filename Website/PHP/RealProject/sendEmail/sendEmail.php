<?php
# This file is the basic PHPMailer file. You can find source code on https://github.com/PHPMailer/PHPMailer.
# This file handle the sending of emails. The project's email address is librarymanagementsystem.emailer@gmail.com 
# so any email sent from the system will be from this address. The sendEmail function takes 4 parameters: 
# The first is the email address
# The second is the name of the receiver
# The third is the subject of the email
# The fourth is the body of the email
# By these information the function sends an email to the given email address.

use PHPMailer\PHPMailer\PHPMailer;
use PHPMailer\PHPMailer\SMTP;
require __DIR__ . '/phpmailer/src/Exception.php';
require __DIR__ . '/phpmailer/src/PHPMailer.php';
require __DIR__ . '/phpmailer/src/SMTP.php';
require_once __DIR__ . '/../InputMethods.php';



function sendEmail($sendToElmail,$sendToName,$subject,$body){
    $mail = new PHPMailer(true);

try {
    #Server settings
    $mail->isSMTP();
    $mail->Host = 'smtp.gmail.com';
    $mail->SMTPAuth = true;
    $mail->Username = 'librarymanagementsystem.emailer@gmail.com';
    $mail->Password = 'cfjncbaukrqfvtzb'; 
    $mail->SMTPSecure = PHPMailer::ENCRYPTION_STARTTLS; 
    $mail->Port = 587;

    #Recipients
    $mail->setFrom('librarymanagementsystem.emailer@gmail.com', 'LMS');
    $mail->addAddress($sendToElmail, $sendToName);

    #Content
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