export function getApiUrl(endpoint,data){
    let url = window.location.pathname.split("/")
    let newurl = window.location.origin
    let j = 0
    while (url[j] != "PHP") {
        newurl += url[j] +"/"
        j++
    }
    newurl += "PHP/"
    newurl += `dbManaging/BooksApi.php/${endpoint}?${data.toString()}`
    return newurl
}
export function PostApiUrl(){
    let url = window.location.pathname.split("/")
    let newurl = window.location.origin
    for (let i = 0; i < url.length-2; i++) {
        newurl += url[i] +"/"
                
    }
    newurl += `dbManaging/BooksApi.php/books`
    return newurl
}
export function validateInput(key,input){
    let list = {}
    for (let i = 0; i < input.length; i++) {
        if (document.getElementById(input[i]).value.length != 0){
            list[key[i]] = document.getElementById(input[i]).value
            
        }
        
    }
    /* 
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
        */
    list["limit"] = 10
    console.log(list)
    return list

}
export function validateInputChanged(){
    let list = {}

    if (document.getElementById("ISBNChanged").value.length != 0){
        list["ISBN"] = document.getElementById("ISBNChanged").value
        
    }
    if (document.getElementById("TitleChanged").value.length != 0){
        list["Title"] = document.getElementById("TitleChanged").value
        
    }
    if (document.getElementById("PublisherChanged").value.length != 0){
        list["Publisher"] = document.getElementById("PublisherChanged").value
        
    }
    if (document.getElementById("AuthorChanged").value.length != 0){
        list["Author"] = document.getElementById("AuthorChanged").value
        
    }
    if (document.getElementById("CategoryChanged").value.length != 0){
        list["Category"] = document.getElementById("CategoryChanged").value
        
    }
    if (document.getElementById("PublicationYearChanged").value.length != 0){
        list["PublicationYear"] = document.getElementById("PublicationYearChanged").value
        
    }
    list["limit"] = 15
    return list

}
