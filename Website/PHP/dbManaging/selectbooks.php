<?php
function HandleUserSelect($method){
    if ($method == "POST"){
        echo json_encode(["success"=> "you made a post request and got the data well!"]);
    }
}


?>