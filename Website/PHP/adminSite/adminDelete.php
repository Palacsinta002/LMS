<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Delete</title>
</head>
<body>
<?php require __DIR__ . "/../config/loggedIn.php"?>
    <h2>Insert a book</h2>
    <a href="./adminSite.php">AdminSite</a>
    <form >
        Title<input type="text" name="Title" id="Title"><br>
        Publisher<input type="text" name="Publisher" id="Publisher"><br>
        Author<input type="text" name="Author" id="Author"><br>
        Category<input type="text" name="Category" id="Category"><br>
        Year(publication)<input type="text" name="PublicationYear" id="PublicationYear"><br>
        ISBN<input type="text" name="ISBN" id="ISBN"><br>
    </form>
    <button id="request-button" >Delete</button>
    <p id="response"></p>
    <script type="module">
        import {validateInput,PostApiUrl} from "./adminscripts.js"

        document.getElementById("request-button").addEventListener("click",()=>{
            let userInput = validateInput(["Title","Publisher","Author","Category","PublicationYear","ISBN"],["Title","Publisher","Author","Category","PublicationYear","ISBN"])
                const url =PostApiUrl("books")
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