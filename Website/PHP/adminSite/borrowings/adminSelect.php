<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Borrowings</title>
</head>
<body>
<?php require __DIR__ . "/../../config/loggedIn.php"?>
    <h2>Select</h2>
    <a href="./../adminSite.php">AdminSite</a>
    <form >
        Username<input type="text" name="Username" id="Username"><br>
        BookTitle<input type="text" name="BookTitle" id="BookTitle"><br>
        BorrowDate<input type="text" name="BorrowDate" id="BorrowDate"><br>
        ReturnDate<input type="text" name="ReturnDate" id="ReturnDate"><br>
        DueDate<input type="text" name="DueDate" id="DueDate"><br>
        Returned<input type="text" name="IsReturned" id="IsReturned"><br>
    </form>
    <button id="request-button" >send</button>
    <div id="parent">
    <table id="content">
    </table>
    </div>
    <script type="module">
        import {getApiUrl,validateInput} from "../adminscripts.js"
        let requestedData;
        document.getElementById("request-button").addEventListener("click", ()=>{
            const data = new URLSearchParams(
                validateInput(["Username","BookTitle","BorrowDate","ReturnDate","DueDate","IsReturned"],["Username","BookTitle","BorrowDate","ReturnDate","DueDate","IsReturned"])
            ) 
            console.log(data)
            let newurl = getApiUrl("borrowings",data)
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
                    console.log(result)
                    selectByParams()
                    fillUpTheTable(result)
                })
                .catch(error => {
                    console.log("Error",error)
                })
        } );
    

        function selectByParams() {
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
                firstrowElement.textContent = "Username"
                firstrow.appendChild(firstrowElement)

                firstrowElement = document.createElement("th")
                firstrowElement.textContent = "BookTitle"
                firstrow.appendChild(firstrowElement)

                firstrowElement = document.createElement("th")
                firstrowElement.textContent = "BorrowDate"
                firstrow.appendChild(firstrowElement)

                firstrowElement = document.createElement("th")
                firstrowElement.textContent = "ReturnDate"
                firstrow.appendChild(firstrowElement)

                firstrowElement = document.createElement("th")
                firstrowElement.textContent = "DueDate"
                firstrow.appendChild(firstrowElement)

                firstrowElement = document.createElement("th")
                firstrowElement.textContent = "Returned"
                firstrow.appendChild(firstrowElement)
                


            result.forEach(row => {
                
                let th =document.createElement("tr")
                table.appendChild(th)
                for (let key in row) {
                    let td =document.createElement("td")
                    td.textContent = row[key]
                    th.appendChild(td)
                };
            });
            
        }
    </script>
</body>
</html>