<?php
require_once __DIR__ . "/InputMethods.php";
require __DIR__ . '/vendor/autoload.php';
use Router\Router;
use App\Controllers\UserController;
use App\Controllers\BorrowingsController;
use App\Controllers\BooksController;
use App\Controllers\Ideiglenes;
use App\Controllers\ImageController;

$requesturi = explode("/", trim($_SERVER["REQUEST_URI"],"/"));


Router::post("/api/login", UserController::class, "login");
Router::post("/api/register", UserController::class,"register");
Router::post("/api/verifyAccount", UserController::class,"verifyAccount");
Router::post("/api/allUsers", UserController::class,"allUsers");
Router::post("/api/user", UserController::class,"userData");
Router::post("/api/updateUser", UserController::class,"updateUser");
Router::post("/api/deleteUser", UserController::class,"deleteUser");


Router::post("/api/borrowings", BorrowingsController::class,"getFromDBByParams");
Router::post("/api/topBorrowings", BorrowingsController::class,"topBorrowedBooks");

Router::post("/api/borrowingBooks", Ideiglenes::class,"borrowingBooks");

Router::post("/api/uploadImg", ImageController::class,"uploadImg");
Router::get("/img", ImageController::class,"getImg",true,true);


Router::get("/api/books", BooksController::class,"getFromDBByParams",true);
Router::get("/api/allBooks", BooksController::class,"countAllBooks");
/* 

if ($requesturi[0] == "api"){
    if ($requesturi[1] == "books"){
        require_once __DIR__ ."/openapi.php";
        openapi($requesturi);
        die();
    }
    require_once __DIR__ . "/userapi.php";
}
elseif ($requesturi[0] == "img"){
    $requesturi = deleteFromList($requesturi,0);
    count($requesturi) == 0 ? errorOutput("18") : "";
    $url = DirectiontoUrl(__DIR__);
    $filepath = $url. "/" ."booksImages/". $requesturi[count($requesturi)-1] . ".png";
    if (!file_exists(__DIR__ . "/booksImages" . "/" . $requesturi[count($requesturi)-1] . ".png")){return header("Location: $url" . "/booksImages/missing.png");}
    return header("Location: " . $filepath);
}
*/

http_response_code(404);
echo "Not Found";



?>