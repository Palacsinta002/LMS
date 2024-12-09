<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <?php
    $data = http_build_query(["id" => 12]) ;
    $options = [
        'http' => [
            'method'  => 'POST',
            'header'  => [
                "Content-Type: application/x-www-form-urlencoded",
                "Accept: application/json",
                
            ],
            "content" => $data
            

        ]
    ];
    $context = stream_context_create($options);
    $response = file_get_contents("http://localhost/Website/PHP/dbManaging/userApi.php/selectbooks", false, $context);
    if ($response === FALSE) {
        die('Error occurred while making the POST request.');
    }
    $responseData = json_decode($response, true);
    print_r($responseData);
    ?>
</body>

</html>