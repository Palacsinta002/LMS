export function getApiUrl(data){
    let url = window.location.pathname.split("/")
    let newurl = window.location.origin
    for (let i = 0; i < url.length-2; i++) {
        newurl += url[i] +"/"
                
    }
    newurl += `dbManaging/BooksApi.php/books?${data.toString()}`
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
export function validateInput(){
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
