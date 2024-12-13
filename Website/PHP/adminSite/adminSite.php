<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="./AdminSite.css">
    <title>AdminSite</title>
</head>
<?php
    require __DIR__ . "/../config/loggedIn.php";
?>
<body>
<div class="menu">
    <div class="dropdown">
    <span>Books</span>
    <div class="dropdown-content">
    <a href="./adminSelect.php" >select</a>
    <a href="./adminInsert.php" >insert</a>
    <a href="./adminUpdate.php" >update</a>
    <a href="./adminDelete.php" >Delete</a>
    </div>
    </div>
    
<div class="dropdown">
    <span>Borrowings</span>
    <div class="dropdown-content">
    <a href="./borrowings/adminSelect.php" >select</a>
    <a href="./borrowings/adminInsert.php" >insert</a>
    <a href="./borrowings/adminUpdate.php" >update</a>
    <a href="./borrowings/adminDelete.php" >Delete</a>
    </div>
    </div>

<div class="dropdown">
    <span>Publishers</span>
    <div class="dropdown-content">
    <div class="xd">
    <input type="text" id="publisher"><button name="GET_request-button" id="publisher_request-button" value="Select">Select</button>
    </div>
    
    <a href="./borrowings/adminInsert.php" >insert</a>
    <a href="./borrowings/adminUpdate.php" >update</a>
    <a href="./borrowings/adminDelete.php" >Delete</a>
    </div>
    </div>

<div class="dropdown">
    <span>Authors</span>
    <div class="dropdown-content">
    <div class="xd">
    <input type="text" id="Author" ><button id="Author_request-button" value="Select">Select</button>
    </div>
    <a href="./borrowings/adminInsert.php" >insert</a>
    <a href="./borrowings/adminUpdate.php" >update</a>
    <a href="./borrowings/adminDelete.php" >Delete</a>
    </div>
    </div>

<div class="dropdown">
    <span>Category</span>
    <div class="dropdown-content">
    <div class="xd">
    <input type="text" id="category"><button id="category_request-button">Select</button>
    </div>
    <a href="./borrowings/adminInsert.php" >insert</a>
    <a href="./borrowings/adminUpdate.php" >update</a>
    <a href="./borrowings/adminDelete.php" >Delete</a>
    </div>
    </div>
<div class="menuUser">Welcome <?php echo $_SESSION["username"]?></div>
</div>

<main>
<div id="parent">
     <table id="content">
     
     </table>
     </div>
</main>

<script type="module">
      import {getApiUrl, validateInput} from "./adminscripts.js"
        document.getElementById("publisher_request-button").addEventListener("click", ()=>{
            fetch_select("smallTables","publisher", "publisher")
        } );
        document.getElementById("Author_request-button").addEventListener("click", ()=>{
            fetch_select("smallTables","Author", "Author")
        } );
        document.getElementById("category_request-button").addEventListener("click", ()=>{
            fetch_select("smallTables","category", "category")
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
                let titles = ""
                for (let key in result[0]){
                    let firstrowElement = document.createElement("th")
                    firstrowElement.textContent = key
                    firstrow.appendChild(firstrowElement)
                }
                

            
            result.forEach(row => {
                let th =document.createElement("tr")
                table.appendChild(th)
                for(let key in row) {
                    let td =document.createElement("td")
                    td.textContent = row[key]
                    th.appendChild(td)
                };
            });
            
        }

function fetch_select(endpoint,col,element){
    let list = {}
    list[col] = document.getElementById(element).value 
    console.log(list)
    const data = new URLSearchParams(
                list
            ) 

            let newurl = getApiUrl(endpoint,data)
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
}
</script>

</body>
</html>
