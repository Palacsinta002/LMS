<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Select</title>
</head>
<body>
<?php require __DIR__ . "/../config/loggedIn.php"?>
    <h2>Select</h2>
    
    
    <a href="./adminSite.php">AdminSite</a>
        <form>
        Title<input type="text" id="Title"><br>
        Publisher<input type="text" id="Publisher"><br>
        Author<input type="text" id="Author"><br>
        Category<input type="text" id="Category"><br>
        Year(publication)<input type="text" id="PublicationYear"><br>
        ISBN<input type="text" id="ISBN"><br>
        
    </form>
    <button id="request-button">send</button>
    <div id="parent">
        <table id="content">

        <?php
            /*
             
            $options = ["http" => [
                    "method" => "POST",
                    "header" => [
                        "Content-Type: application/x-www-form-urlencoded",
                        "Accept: application/json"
                    ],
                    "content" => json_encode(["limit" => 15])
                    
            ]
                ];
                $context = stream_context_create($options);
                $result = file_get_contents("http://localhost/Website/PHP/dbManaging/userApi.php/selectbooks",false,$context);
                echo $result === false ?  "something went wrong" : "";
                $data = json_decode($result, true);
                echo "<table>";
                echo "<tr><td>ISBN</td><td>title</td><td>Publication Year</td><td>publisher</td><td>name</td><td>category</td></tr>";
                for ($i=0; $i < count($data); $i++) { 
                    echo "<tr>";
                    for ($j=0; $j < count($data[$i]); $j++) { 
                        echo "<td>";
                        echo $data[$i][$j];
                        echo "</td>";
                    }
                    echo "</tr>";
                }
                
                echo "</table>";

                $options["http"]["content"] = json_encode($_POST); 
            include "../dbManaging/Select.php"

*/
?>

        </table>
    </div>
    <script type="module">
        import {getApiUrl, validateInput} from "./adminscripts.js"
        document.getElementById("request-button").addEventListener("click", ()=>{
            const data = new URLSearchParams(
                validateInput(["Title","Publisher","Author","Category","PublicationYear","ISBN"],["Title","Publisher","Author","Category","PublicationYear","ISBN"])
            ) 

            let newurl = getApiUrl("books",data)
            console.log(newurl)
            fetch(newurl,)
                .then(response => {
                    if(!response){
                        throw new Error("Network response was not ok!")
                    }
                    else{
                        return response.json()
                    }
                })
                .then(result=>{
                    requestedData = result
                    console.log(result)
                    selectByParams()
                    fillUpTheTable(result)
                })
                .catch(error => {
                    console.log("Error",error)
                })
        } );


        let requestedData;
        let sendeddata = "";

        
        let counter = 0
        function selectByParams() {
            counter++
            console.log(counter)
            let parent = document.getElementById("parent")
            while (parent.hasChildNodes()) {
                parent.removeChild(parent.firstChild)
                
            }
            let content =document.createElement("table")
                content.id = "content"
                parent.appendChild(content)
            
            
        }
        function fillUpTheTable(result){
            let table =document.getElementById("content")
                let firstrow =document.createElement("tr")
                table.appendChild(firstrow)

                let firstrowElement = document.createElement("th")
                firstrowElement.textContent = "ISBN"
                firstrow.appendChild(firstrowElement)

                firstrowElement = document.createElement("th")
                firstrowElement.textContent = "Title"
                firstrow.appendChild(firstrowElement)

                firstrowElement = document.createElement("th")
                firstrowElement.textContent = "Publication Year"
                firstrow.appendChild(firstrowElement)

                firstrowElement = document.createElement("th")
                firstrowElement.textContent = "publisher"
                firstrow.appendChild(firstrowElement)

                firstrowElement = document.createElement("th")
                firstrowElement.textContent = "name"
                firstrow.appendChild(firstrowElement)

                firstrowElement = document.createElement("th")
                firstrowElement.textContent = "category"
                firstrow.appendChild(firstrowElement)
                

            
            result.forEach(row => {
                let th =document.createElement("tr")
                table.appendChild(th)
                row.forEach(element => {
                    let td =document.createElement("td")
                    td.textContent = element
                    th.appendChild(td)
                });
            });
            
        }
    </script>
</body>
</html>


