<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Insert</title>
</head>
<body>
    <?php require __DIR__ . "/../config/loggedIn.php"?>
    <h2>Insert a book</h2>
    <a href="./adminSite.php">AdminSite</a>
    <form method="POST" action=<?php htmlspecialchars($_SERVER["PHP_SELF"])?>>
        Title<input type="text" name="Title"><br>
        Publisher<input type="text" name="Publisher"><br>
        Author<input type="text" name="Author"><br>
        Category<input type="text" name="Category"><br>
        Year(publication)<input type="text" name="PublicationYear"><br>
        ISBN<input type="text" name="ISBN"><br>
        <input type="submit" value="submit">
    </form>
    <?php
    require "../dbManaging/Insert.php"
    
    ?>
</body>
</html>