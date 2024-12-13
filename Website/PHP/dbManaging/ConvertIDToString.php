<?php
function checkdata($table, $cols, $maincol, $element){
    global $conn;
    $txt = "";
    for ($i=0; $i < count($cols); $i++) { 
        $txt .= $table . "." . $cols[$i] . ", ";
    }
    $txt = trim(trim($txt),",");

    $sql = "select $txt from $table where $table.$maincol = '$element'";
    $selectedrow = $conn->query($sql);
    if ($selectedrow->num_rows > 0){
        $row = $selectedrow->fetch_assoc();
        $col = $cols[0];
        return $row["$col"];
        
    }
    else{
        echo json_encode(["error:" =>  $element . " not in the database!"]);
        die(); 
    }

}

function equalize($input,$IDs){
    $sql = "";
    unset($input["limit"]);
    $IsID = false;
    foreach ($input as $key => $value) {
        $IsID = false;
        foreach ($IDs as $Idkey) {
            if ($Idkey == $key){
                $IsID = true;
                unset($IDs[$key]);
                break;
            }
        }
        
        if($IsID == false){
            $sql.= "$key = '$value', " ;
        }
        else{
            $sql.= $key."ID = $value, ";
        }
        
        
    }
    $sql = trim(trim($sql),",");
    return $sql;
}

function equalizeAND($input,$IDs){
    $sql = "";
    unset($input["limit"]);
    $IsID = false;
    foreach ($input as $key => $value) {
        $IsID = false;
        foreach ($IDs as $Idkey) {
            if ($Idkey == $key){
                $IsID = true;
                unset($IDs[$key]);
                break;
            }
        }
        
        if($IsID == false){
            $sql.= "$key = '$value' and " ;
        }
        else{
            $sql.= $key."ID = $value and  ";
        }
        
        
    }
    $sql = trim(trim($sql),"and ");
    return $sql;
}


?>