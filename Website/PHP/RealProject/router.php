<?php
require_once __DIR__ . "/InputMethods.php";
require __DIR__ . '/vendor/autoload.php';
use Router\Router;
use App\Controllers\UserController;
use App\Controllers\BorrowingsController;
use App\Controllers\BooksController;
use App\Controllers\Ideiglenes;
use App\Controllers\ImageController;
use App\Controllers\BorrowingsAndBooksController;
$requesturi = explode("/", trim($_SERVER["REQUEST_URI"],"/"));


Router::post("/api/login", UserController::class, "login");
Router::post("/api/register", UserController::class,"register");
Router::post("/api/verify-account", UserController::class,"verifyAccount");

Router::get("/api/user", UserController::class,"userData", true);
Router::put("/api/update-user", UserController::class,"updateUser");
Router::delete("/api/delete-user", UserController::class,"deleteUser");


Router::post("/api/borrowings", BorrowingsController::class,"getFromDBByParams");

#this shall be a get
Router::get("/api/top-borrowings", BorrowingsAndBooksController::class,"topBorrowedBooks",false,true,true);

Router::get("/api/borrowing-books", Ideiglenes::class,"borrowingBooks");
Router::get("/api/my-borrowed-books", BorrowingsAndBooksController::class,"getMyBorrowedBooks",true);
Router::get("/api/available-books", BorrowingsAndBooksController::class,"availableBooks",false);

Router::post("/api/upload-img", ImageController::class,"uploadImg");
Router::get("/img", ImageController::class,"getImg",false,true,true);


Router::get("/api/books", BooksController::class,"getFromDBByParams",false,true);
Router::get("/api/all-books", BooksController::class,"countAllBooks");
Router::get("/api/all-users", UserController::class,"allUsers");
Router::get("/api/all-borrowings", BorrowingsController::class,"allBorrowings");


Router::get("/api/test", BorrowingsAndBooksController::class,"availableBooks",false);
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