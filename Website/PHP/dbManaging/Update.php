<?php
#*********DONE*********


if ($_SERVER["REQUEST_METHOD"] == "POST") {
    #Don't touch this 2 lines
    require __DIR__."/../config/config.php";
    require __DIR__."/../validate.php";
    #take the post request datas
    $title = validateTheInput($_POST["Title"]);
    $publisher = validateTheInput($_POST["Publisher"]);
    $author = validateTheInput($_POST["Author"]);
    $category = validateTheInput($_POST["Category"]);
    $publicationYear = validateTheInput($_POST["PublicationYear"]);
    $ISBN = validateTheInput($_POST["ISBN"]);

    #changed values datas
    $titleChanged = validateTheInput($_POST["TitleChanged"]);
    $publisherChanged = validateTheInput($_POST["PublisherChanged"]);
    $authorChanged = validateTheInput($_POST["AuthorChanged"]);
    $categoryChanged = validateTheInput($_POST["CategoryChanged"]);
    $publicationYearChanged = validateTheInput($_POST["PublicationYearChanged"]);
    $ISBNChanged = validateTheInput($_POST["ISBN"]);

    #this array is the list of the checked values. A variable false if It's not checked or it was given wrong and It is true if the variable is ready for the insert method.
    $validDatas = [false,false,false,false,false,false];
    $validDatasChanged = [false,false,false,false,false,false];

    
    #checks all of the Post method datas
    if (strlen($title) > 0){
        $validDatas[0] = true;
    }

    if (strlen($publisher) > 0){
        #check if "publsiher" exists in database
        $sql = "select publishers.publisherID,publishers.publisher from publishers where publishers.publisher = '$publisher'";
        $publishers = $conn->query($sql);
        if ($publishers->num_rows > 0){
            $row = $publishers->fetch_assoc();
            $publisher = $row["publisherID"];
            $validDatas[1] = true;
    }
    else{
        die("wrong publisher");
    }
    }
    
    
    if (strlen($author) > 0){
        #check if "author" exists in database
        $sql = "select authors.authorID,authors.name from authors where authors.name = '$author'";
        $authors = $conn->query($sql);
        if ($authors->num_rows > 0){
            $row = $authors->fetch_assoc();
            $author = $row["authorID"];
            $validDatas[2] = true;
        }
        else{
            die("wrong author");
        }
    }

    
    if (strlen($category) > 0){
        #check if "category" exists in database
        $sql = "select categories.categoryID,categories.category from categories where categories.category = '$category'";
        $categories = $conn->query($sql);
        if ($categories->num_rows > 0){
            $row = $categories->fetch_assoc();
            $category = $row["categoryID"];
            $validDatas[3] = true;
        }
        else{
            die("wrong category");
        }
    }

    if (strlen($publicationYear) > 0){
        if (is_numeric($publicationYear)){
            $validDatas[4] = true;
        }
        
    }
    if (strlen($ISBN) > 0){
        if (strlen($ISBN) == 13){
            if (is_numeric($ISBN)){
                #check if "ISBN" exists in database
                $sql = "select books.bookID,books.ISBN from books where books.ISBN = '$ISBN'";
                $ISBNS = $conn->query($sql);
                if ($ISBNS->num_rows > 0){
                    $validDatas[5] = true;
                    
                }
                else{
                    die("This ISBN not exists") ;
                }

                
            }
        }
         
    }
    #checks all the changed values
    if (strlen($titleChanged) == 0){
        $titleChanged = $title;
        
    }
    $validDatasChanged[0] = true;
    

    if (strlen($publisherChanged) == 0){
        $publisherChanged = $publisher;
        $validDatasChanged[1] = true;
    }
    else{
        $sql = "select publishers.publisherID,publishers.publisher from publishers where publishers.publisher = '$publisherChanged'";
        $publishersChanged = $conn->query($sql);
        if ($publishersChanged->num_rows > 0){
            $row = $publishersChanged->fetch_assoc();
            $publisherChanged = $row["publisherID"];
            echo $publisherChanged;
            $validDatasChanged[1] = true;
        }
        else
        {
            die("wrong publisherCheanged");
        }
    }

    if (strlen($authorChanged) == 0){
        $authorChanged = $author;
        $validDatasChanged[2] = true;
    }
    else{
        #check if "author" exists in database
        $sql = "select authors.authorID,authors.name from authors where authors.name = '$authorChanged'";
        $authorsChanged = $conn->query($sql);
        if ($authorsChanged->num_rows > 0){
            $row = $authorsChanged->fetch_assoc();
            $authorChanged = $row["authorID"];
            $validDatasChanged[2] = true;
        }
        else{
            die("wrong authorChanged");
        }
    }
    if (strlen($categoryChanged) == 0){
        $categoryChanged = $category;
        $validDatasChanged[3] = true;
    }
    else{
        #check if "category" exists in database
        $sql = "select categories.categoryID,categories.category from categories where categories.category = '$categoryChanged'";
        $categoriesChanged = $conn->query($sql);
        if ($categoriesChanged->num_rows > 0){
            $row = $categoriesChanged->fetch_assoc();
            $categoryChanged = $row["categoryID"];
            $validDatasChanged[3] = true;
        }
        else{
            die("wrong categoryChanged");
        }
    }
    if (strlen($publicationYearChanged) == 0){
        $publicationYearChanged = $publicationYear;
        $validDatasChanged[4] = true;
    }
    else{
        if (is_numeric($publicationYear)){
            $validDatasChanged[4] = true;
        }
    }
    if (strlen($ISBNChanged) == 0){
        $ISBNChanged = $title;
        $validDatasChanged[5] = true;
    }
    else{
        $validDatasChanged[5] = true;
    }
    #go through all of the values and checks if one of them is false 
    $allvalid = true;
    for ($i=0; $i < 6 ; $i++) { 
        if ($validDatas[$i] == false){
            $allvalid = false;
            break;
        }
        if ($validDatasChanged[$i] == false){
            $allvalid = false;
            break;
        }
    }
    #making the insert
    

    if ($allvalid == true){
        $sql = "UPDATE books 
        SET publisherID=$publisherChanged, authorID=$authorChanged, categoryID =$categoryChanged,title = '$titleChanged', isbn = '$ISBNChanged',publicationYear = $publicationYear 
        WHERE publisherid = $publisher and authorid = $author and categoryid = $category and title = '$title' and isbn = '$ISBN' ";
        $mainInsert = $conn->query($sql);
        echo "A line was successfully updated";

    }
    else{
        echo "You failed to enter the datas well. Please try again!";
    }
    
    if (isset($publishersChanged)){$publishersChanged->close();}
    if (isset($authorsChanged)){$authorsChanged->close();}
    if (isset($categoriesChanged)){$categoriesChanged->close();}
    if (isset($ISBNSChanged)){$ISBNSChanged->close();}
    if (isset($publishers)){$publishers->close();}
    if (isset($authors)){$authors->close();}
    if (isset($categories)){$categories->close();}
    if (isset($ISBNS)){$ISBNS->close();}
    $conn->close();

}

?>