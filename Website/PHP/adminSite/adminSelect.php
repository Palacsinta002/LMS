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
    <button onclick="sendRequest()" >send</button>
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
    <script>
        let requestedData;
        let sendeddata = "";
        function sendRequest() {
            const data = new URLSearchParams(
                validateInput()
                
            
            ) 
            
            const url = `http://localhost/Website/PHP/dbManaging/BooksApi.php/books?${data.toString()}`
            console.log(url)
            fetch(url,)
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
        }
        function validateInput(){
            let list = {}

            if (document.getElementById("ISBN").value.length != 0){
                list["ISBN"] = document.getElementById("ISBN").value
                
            }
            if (document.getElementById("Title").value.length != 0){
                list["Title"] = document.getElementById("Title").value
                
            }
            if (document.getElementById("Publisher").value.length != 0){
                list["Publisher"] = document.getElementById("Publisher").value
                
            }
            if (document.getElementById("Author").value.length != 0){
                list["Author"] = document.getElementById("Author").value
                
            }
            if (document.getElementById("Category").value.length != 0){
                list["Category"] = document.getElementById("Category").value
                
            }
            if (document.getElementById("PublicationYear").value.length != 0){
                list["PublicationYear"] = document.getElementById("PublicationYear").value
                
            }
            list["limit"] = 10
            return list

        }
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
                firstrow =document.createElement("tr")
                table.appendChild(firstrow)

                firstrowElement = document.createElement("th")
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


