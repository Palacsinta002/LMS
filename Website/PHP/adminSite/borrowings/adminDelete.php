<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Delete</title>
</head>
<body>
<?php require __DIR__ . "/../../config/loggedIn.php"?>
    <h2>Delete</h2>
    <a href="./../adminSite.php">AdminSite</a>
    <form >
        Username<input type="text" name="Username" id="Username"><br>
        ISBN<input type="text" name="ISBN" id="ISBN"><br>
        BorrowDate<input type="text" name="BorrowDate" id="BorrowDate"><br>
        ReturnDate<input type="text" name="ReturnDate" id="ReturnDate"><br>
        DueDate<input type="text" name="DueDate" id="DueDate"><br>
        Returned<input type="text" name="IsReturned" id="IsReturned"><br>
    </form>
    <button id="request-button" >send</button>
    <p id="response"></p>
<script type="module">
        import {validateInput,PostApiUrl} from "../adminscripts.js"

        document.getElementById("request-button").addEventListener("click",()=>{
            let userInput = validateInput(["Username","ISBN","BorrowDate","ReturnDate","DueDate","IsReturned"],["Username","ISBN","BorrowDate","ReturnDate","DueDate","IsReturned"])
                const url =PostApiUrl("borrowings")
                fetch(url,{
                method: "DELETE",
                header:{
                    "Content-Type:":"application/json"
                },
                body: JSON.stringify(userInput)
            }
            ).then(response=>{
                if (!response.ok){
                    throw new Error("Something went wrong!");
                }
                else{
                    return response.json()
                }
            })
            .then(result =>{
                for (let key in result){
                    document.getElementById("response").innerText = result[key]
                }
            })
            .catch(error => {
                    console.log("Error",error)
                })
        })
</script>
</body>
</html>