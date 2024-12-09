export function getApiUrl(){
    let url = window.location.pathname.split("/")
    let newurl = window.location.origin
    for (let i = 0; i < url.length-2; i++) {
        newurl += url[i] +"/"
                
    }
    newurl += `dbManaging/BooksApi.php/books?${data.toString()}`
    return newurl
}
export default getApiUrl