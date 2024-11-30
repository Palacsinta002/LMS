<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Update</title>
</head>
<body>
    <h2>Row that you would like to change</h2>
    <a href="./adminSite">AdminSite</a>
<form method="POST" action=<?php htmlspecialchars($_SERVER["PHP_SELF"])?>>
        Title<input type="text" name="Title"><br>
        Publisher<input type="text" name="Publisher"><br>
        Author<input type="text" name="Author"><br>
        Category<input type="text" name="Category"><br>
        Year(publication)<input type="text" name="PublicationYear"><br>
        ISBN<input type="text" name="ISBN"><br>

        <h2>Change values</h2><br>
        Title<input type="text" name="TitleChanged"><br>
        Publisher<input type="text" name="PublisherChanged"><br>
        Author<input type="text" name="AuthorChanged"><br>
        Category<input type="text" name="CategoryChanged"><br>
        Year(publication)<input type="text" name="PublicationYearChanged"><br>
        ISBN<input type="text" name="ISBNChanged"><br>

        <input type="submit" value="submit">
    </form>
    <?php
    require "../dbManaging/Update.php"
    
    
    ?>
</body>
</html>