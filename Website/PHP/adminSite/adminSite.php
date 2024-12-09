<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="./AdminSite.css">
    <title>AdminSite</title>
</head>
<?php
    require __DIR__ . "/../config/loggedIn.php";
?>
<body>
<div class="menu">
    <div class="dropdown">
    <span>books</span>
    <div class="dropdown-content">
    <a href="./adminSelect.php" >select</a>
    <a href="./adminInsert.php" >insert</a>
    <a href="./adminUpdate.php" >update</a>
    </div>
    </div>
    
<a href="./adminInsert.php">borroings</a>
<a href="./adminUpdate.php">users</a>

<div class="menuUser">Welcome <?php echo $_SESSION["username"]?></div>
</div>

<main>

</main>



</body>
</html>
