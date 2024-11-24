<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
<?php
$alma = '<a href="test">Test é</a>';

function checkTheInput($input) {
    // Trim whitespace
    $input = trim($input);

    // Remove slashes if added by magic quotes or similar
    $input = stripslashes($input);

    // Convert to HTML entities (with proper encoding)
    $input = htmlentities($input, ENT_QUOTES, 'UTF-8');

    return $input;
}
echo checkTheInput($alma);
?>
</body>
</html>
