<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>LMS</title>
</head>
<body>

     <form method="POST" action=<?php htmlspecialchars($_SERVER["PHP_SELF"])?>>
        <input type="text" name="title">
        <input type="submit" value="submit">
    </form>
    <?php 
        require "./dbManaging/Select.php";
    ?>
</body>
</html>