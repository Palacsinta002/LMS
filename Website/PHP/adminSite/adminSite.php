<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <h1>Welcome </h1>
    <?php
    /*$options = array(
        'http' => array(
          'method'  => 'POST',
          'content' => json_encode( $data ),
          'header'=>  "Content-Type: application/json\r\n" .
                      "Accept: application/json\r\n"
          )
      );
    $context  = stream_context_create( $options );
    $result = file_get_contents( "./index.php", false, $context );
    if ($_SERVER['REQUEST_METHOD'] == "POST"){
        echo "hát valamit elküldött";
    }*/

echo "admin oldal"


?>
<h2>What would you like to do?</h2>
<a href="./adminSelect.php">Select</a>
<a href="./adminInsert.php">Insert</a>
<a href="./adminUpdate.php">Update</a>


</body>
</html>
