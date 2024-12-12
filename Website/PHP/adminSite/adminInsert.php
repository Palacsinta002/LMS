<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Insert</title>
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
    <button id="request-button" >send</button>
    <p id="response"></p>
    <script type="module">
        import {PostApiUrl,validateInput} from "./adminscripts.js"
        const url = PostApiUrl("books")
        console.log(url)
        document.getElementById("request-button").addEventListener("click",()=>{
            let userInput = validateInput(["Title","Publisher","Author","Category","PublicationYear","ISBN"],["Title","Publisher","Author","Category","PublicationYear","ISBN"])
            console.log(JSON.stringify(userInput));
            
            if (Object.keys(userInput).length == 7){
                
                fetch(url,{
                method: "POST",
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
                document.getElementById("response").innerText = result["Success"]
            })
            .catch(error => {
                    console.log("Error",error)
                })

            }
            else{
                document.getElementById("response").innerText = "You entered the data worng!"
            }
            
            
            
        })

    </script>
    <?php
    
    
    ?>
</body>
</html>