<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Update</title>
</head>
<body>
    <?php require __DIR__ . "/../config/loggedIn.php"?>
    <h2>Row that you would like to change</h2>
    <a href="./adminSite.php">AdminSite</a>
<form>
        Title<input type="text" name="Title" id="Title"><br>
        Publisher<input type="text" name="Publisher" id="Publisher"><br>
        Author<input type="text" name="Author" id="Author"><br>
        Category<input type="text" name="Category" id="Category"><br>
        Year(publication)<input type="text" name="PublicationYear" id="PublicationYear"><br>
        ISBN<input type="text" name="ISBN" id="ISBN"><br>

        <h2>Change values</h2><br>
        Title<input type="text" name="TitleChanged" id="TitleChanged"><br>
        Publisher<input type="text" name="PublisherChanged" id="PublisherChanged"><br>
        Author<input type="text" name="AuthorChanged" id="AuthorChanged"><br>
        Category<input type="text" name="CategoryChanged" id="CategoryChanged"><br>
        Year(publication)<input type="text" name="PublicationYearChanged" id="PublicationYearChanged"><br>
        ISBN<input type="text" name="ISBNChanged" id="ISBNChanged"><br>
    </form>
    <button id="request-button">Update</button>
    <p id="response"></p>
    <script type="module">
        import {validateInput,PostApiUrl} from "./adminscripts.js"
        document.getElementById("request-button").addEventListener("click",() =>{
            const url = PostApiUrl()
            const userInput = {
                current: validateInput(["Title","Publisher","Author","Category","PublicationYear","ISBN"],["Title","Publisher","Author","Category","PublicationYear","ISBN"]),
                new: validateInput(["Title","Publisher","Author","Category","PublicationYear","ISBN"],["TitleChanged","PublisherChanged","AuthorChanged","CategoryChanged","PublicationYearChanged","ISBNChanged"])
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
                document.getElementById("response").textContent = result["success"]
            }).catch(error =>{
                console.log("error",error);
                
            })
            })
        

    </script>
</body>
</html>