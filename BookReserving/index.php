<?php
session_start();
$_SESSION["userID"] ?? header("Location: login.php");
// Adatbázis kapcsolat
require_once 'conn.php';
$pdo = connect();


// Könyvek lekérdezése az adatbázisból

$stmt = $pdo->query("SELECT * FROM books");
$books = $stmt->fetchAll(PDO::FETCH_ASSOC);
function resetBooks(){
    $pdo = connect();
    $stmt = $pdo->query("SELECT * FROM books");
    $books = $stmt->fetchAll(PDO::FETCH_ASSOC);
    return $books;
}
// Kosár inicializálása
if (!isset($_SESSION['cart'])) {
    $_SESSION['cart'] = [];
}

// Könyv hozzáadása a kosárhoz, ha elérhető
if (isset($_GET['add'])) {
    $bookId = (int)$_GET['add'];
    $stmt = $pdo->prepare("SELECT * FROM books WHERE id = ?");
    $stmt->execute([$bookId]);
    $book = $stmt->fetch(PDO::FETCH_ASSOC);
    
    if ($book) {
        $_SESSION['cart'][$bookId] = $book;
    }
}

// Könyv eltávolítása a kosárból
if (isset($_GET['remove'])) {
    $bookId = (int)$_GET['remove'];
    unset($_SESSION['cart'][$bookId]);
}

// Kosár kiürítése
if (isset($_GET['clear'])) {
    $_SESSION['cart'] = [];
}

// Kölcsönzés véglegesítése
if (isset($_GET['checkout']) && !empty($_SESSION['cart'])) {
    foreach ($_SESSION['cart'] as $bookId => $book) {
        $pdo->prepare("INSERT INTO rentals (user_id, book_id, rented_at) VALUES (?, ?, NOW())")->execute([$_SESSION["userID"],$bookId]);
        $pdo->prepare("UPDATE books SET quantity = quantity - 1 WHERE id = ?")->execute([$bookId]);
        $books = resetBooks();
    }
    $_SESSION['cart'] = [];
}
if (isset($_GET['reset'])) {
    $pdo->prepare("UPDATE books SET quantity = 5")->execute();
    $pdo->prepare("DELETE FROM rentals")->execute();
    $books = resetBooks();
    $_SESSION['cart'] = [];
}
function renderBooks($books) {
    foreach ($books as $book) {
        echo '<div class="book-card">';
        echo '<strong>' . htmlspecialchars($book['title']) . '</strong><br>';
        echo htmlspecialchars($book['author']) . '<br>';
        echo '(' . $book['quantity'] . ' db)';
        
        if ($book['quantity'] > 0) {
            echo ' <a href="?add=' . $book['id'] . '">Kölcsönzés</a>';
        } else {
            echo ' <p style="color: red;">Nincs elérhető példány</p>';
        }
        
        echo '</div>';
    }
}
?>
<!DOCTYPE html>
<html lang="hu">
<head>
    <meta charset="UTF-8">
    <title>Könyvkölcsönzés</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            display: flex;
            flex-direction: column;
            align-items: center;
            padding: 20px;
        }
        .container {
            max-width: 800px;
            width: 100%;
            background: white;
            padding: 20px;
            border-radius: 10px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            text-align: center;
        }
        h1, h2 {
            color: #333;
        }
        .book-list {
            display: flex;
            flex-wrap: wrap;
            justify-content: center;
            gap: 20px;
            padding: 0;
        }
        .book-card {
            background: white;
            padding: 15px;
            border-radius: 10px;
            box-shadow: 0 0 5px rgba(0, 0, 0, 0.1);
            width: 200px;
            text-align: center;
        }
        .book-card a {
            display: inline-block;
            margin-top: 10px;
            background: #007bff;
            color: white;
            padding: 5px 10px;
            border-radius: 5px;
            text-decoration: none;
        }
        .book-card a:hover {
            background: #0056b3;
        }
        .cart ul {
            list-style-type: none;
            padding: 0;
        }
        .cart li {
            background: white;
            margin: 5px 0;
            padding: 10px;
            border-radius: 5px;
            box-shadow: 0 0 5px rgba(0, 0, 0, 0.1);
        }
        .buttons a {
            margin: 10px;
            display: inline-block;
            background: #28a745;
            color: white;
            padding: 10px 15px;
            border-radius: 5px;
            text-decoration: none;
        }
        .buttons a:hover {
            background: #218838;
        }
    </style>
</head>
<body>
    <div class="container">
        <h1>Könyvkölcsönzés</h1>
        <h2>Elérhető könyvek</h2>
        <div class="book-list">
            <?php renderBooks($books); ?>
        </div>
        
        <h2>Kosár</h2>
        <div class="cart">
            <ul>
                <?php foreach ($_SESSION['cart'] as $book): ?>
                    <li>
                        <?= htmlspecialchars($book['title']) ?> - <?= htmlspecialchars($book['author']) ?>
                        <a href="?remove=<?= $book['id'] ?>">Eltávolítás</a>
                    </li>
                <?php endforeach; ?>
            </ul>
        </div>
        
        <div class="buttons">
            <a href="?clear=1">Kosár ürítése</a>
            <a href="?checkout=1">Kölcsönzés véglegesítése</a>
            <a href="?reset">feltöltés</a>
        </div>
    </div>
</body>
</html>
