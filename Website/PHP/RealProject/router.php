<?php
require __DIR__ . '/vendor/autoload.php';
use Router\Router;
use ApiResponse\Response;
use App\Controllers\UserController;
use App\Controllers\BorrowingsController;
use App\Controllers\BooksController;
use App\Controllers\ImageController;
use App\Controllers\ReservationController;

Router::post("/api/login", UserController::class, "login");
Router::post("/api/register", UserController::class,"register");
Router::post("/api/verify-account", UserController::class,"verifyAccount");
Router::post("/api/forgot-password", UserController::class,"forgotPassword");
Router::get("/api/user", UserController::class,"userData", true);
Router::put("/api/user", UserController::class,"updateUser");
Router::put("/api/finalize-registration", UserController::class,"finalizeRegistration",false);
Router::put("/api/change-password", UserController::class,"changePassword");
Router::delete("/api/user", UserController::class,"deleteUser");

Router::get("/api/top-borrowings/{limit}", BorrowingsController::class,"topBorrowedBooks",false,true);

Router::get("/api/borrowings", BorrowingsController::class,"show",true);
Router::get("/api/available-books", BooksController::class,"availableBooks",false);

Router::post("/api/upload-img", ImageController::class,"uploadImg",false,true);
Router::get("/img/{ISBN}", ImageController::class,"getImg",false,true);

Router::get("/api/books", BooksController::class,"getFromDBByParams",false,true);
Router::get("/api/all-books", BooksController::class,"countAllBooks");
Router::get("/api/all-users", UserController::class,"allUsers");
Router::get("/api/all-borrowings", BorrowingsController::class,"allBorrowings");

Router::get("/api/reserve", ReservationController::class,"show",true);
Router::post("/api/reserve",ReservationController::class,"store",true);
Router::delete("/api/reserve/{ISBN}", ReservationController::class, "destroy");

Router::get("/api/test", BorrowingsController::class,"availableBooks",false);

Response::httpError(404, "Route not found");