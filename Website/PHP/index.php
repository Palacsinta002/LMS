<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Fosch</title>
</head>
<body>
    <?php
        session_start();
        require "formValidation.php";
    ?>
    <form method="POST" action=<?php htmlspecialchars($_SERVER["PHP_SELF"])?>>
        <table>
            <tr>
                <td><b>Username: </b></td>
                <td><input type="text" name="username" value=<?php printing($username)?>><?php printing($username_error) ?></td>
            </tr>
            <tr>
                <td><b>Password: </b></td>
                <td><input type="password" name="password" value=<?php printing($password)?>><?php printing($password_error) ?></td>
            </tr>
            <tr>
                <td></td>
                <td colspan="2"><input type="submit" value="Submit"></td>
            </tr>
        </table>
    </form>
    <?php printing($error)?>
</body>
</html>