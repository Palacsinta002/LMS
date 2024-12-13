<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Update</title>
</head>
<body>
<?php require __DIR__ . "/../../config/loggedIn.php"?>
    <h2>Update</h2>
    <a href="./../adminSite.php">AdminSite</a>
    <form >
        <h1>Current</h1>
        Username<input type="text" name="Username" id="Username"><br>
        ISBN<input type="text" name="ISBN" id="ISBN"><br>
        BorrowDate<input type="text" name="BorrowDate" id="BorrowDate"><br>
        ReturnDate<input type="text" name="ReturnDate" id="ReturnDate"><br>
        DueDate<input type="text" name="DueDate" id="DueDate"><br>
        Returned<input type="text" name="IsReturned" id="IsReturned"><br>
        <h1>Updated</h1>
        Username<input type="text" name="Username" id="UsernameChanged"><br>
        ISBN<input type="text" name="ISBN" id="ISBNChanged"><br>
        BorrowDate<input type="text" name="BorrowDate" id="BorrowDateChanged"><br>
        ReturnDate<input type="text" name="ReturnDate" id="ReturnDateChanged"><br>
        DueDate<input type="text" name="DueDate" id="DueDateChanged"><br>
        Returned<input type="text" name="IsReturned" id="IsReturnedChanged"><br>
    </form>
    <button id="request-button" >send</button>
    <p id="response"></p>
    <script type="module">
        import {validateInput,PostApiUrl} from "../adminscripts.js"
        document.getElementById("request-button").addEventListener("click",() =>{
            const url = PostApiUrl("borrowings")
            const userInput = {
                current: validateInput(["Username","ISBN","BorrowDate","ReturnDate","DueDate","IsReturned"],["Username","ISBN","BorrowDate","ReturnDate","DueDate","IsReturned"]),
                new: validateInput(["Username","ISBN","BorrowDate","ReturnDate","DueDate","IsReturned"],["UsernameChanged","ISBNChanged","BorrowDateChanged","ReturnDateChanged","DueDateChanged","IsReturnedChanged"])
            }
            console.log(JSON.stringify(userInput))
            fetch(url,{
                method: "PATCH",
                headers: {
                    "Content-Type": "application/json"
                },
                body: JSON.stringify(userInput)
            }).then(response => {
                if (!response.ok){
                    throw new Error("The server is currently offline!");
                    
                }
                else{
                    return response.json()
                    
                }
            }).then(result =>{
                for (let key in result){
                    document.getElementById("response").innerText = result[key]
                }
            }).catch(error =>{
                console.log("error",error);
                
            })
            })
    </script>
</body>
</html>