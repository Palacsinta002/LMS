<?php

function sendAPIRequest($data){
    $options = [
        "http" => [
            "method" => "POST",
            "content"=> $data,
            "header" => "Content-Type: Application/json\r\n" . "Accept: application/json\r\n"
        ]
        ];
    return $options;

}

?>