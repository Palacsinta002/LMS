<?php
function validateTheInput($input)
{
    $input = htmlentities($input);
    $input = stripcslashes($input);
    $input = trim($input);
    return $input;
}


?>