<?php
session_start();

// Adatbázis kapcsolat
$pdo = new PDO('mysql:host=localhost;dbname=book_rental;charset=utf8', 'root', '');
$pdo->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);

// Bejelentkezés ellenőrzése
if (!isset($_SESSION['user_id']) && basename($_SERVER['PHP_SELF']) != 'login.php' && basename($_SERVER['PHP_SELF']) != 'register.php') {
    header("Location: login.php");
    exit;
}

// Könyvek lekérdezése
$stmt = $pdo->query("SELECT * FROM books");
$books = $stmt->fetchAll(PDO::FETCH_ASSOC);

// Kosár inicializálása
if (!isset($_SESSION['cart'])) {
    $_SESSION['cart'] = [];
}

// Könyv hozzáadása a kosárhoz, ha elérhető
if (isset($_GET['add']) && isset($_SESSION['user_id'])) {
    $bookId = (int)$_GET['add'];
    $stmt = $pdo->prepare("SELECT * FROM books WHERE id = ? AND quantity > 0");
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
if (isset($_GET['checkout']) && !empty($_SESSION['cart']) && isset($_SESSION['user_id'])) {
    foreach ($_SESSION['cart'] as $bookId => $book) {
        $pdo->prepare("INSERT INTO rentals (user_id, book_id, rented_at) VALUES (?, ?, NOW())")->execute([$_SESSION['user_id'], $bookId]);
        $pdo->prepare("UPDATE books SET quantity = quantity - 1 WHERE id = ?")->execute([$bookId]);
    }
    $_SESSION['cart'] = [];
}
?>
<!DOCTYPE html>
<html lang="hu">
<head>
    <meta charset="UTF-8">
    <title>Könyvkölcsönzés</title>
    <link rel="stylesheet" href="styles.css">
</head>
<body>
    <div class="container">
        <h1>Könyvkölcsönzés</h1>
        <a href="logout.php" class="logout">Kijelentkezés</a>
        <h2>Elérhető könyvek</h2>
        <div class="book-list">
            <?php foreach ($books as $book): ?>
                <div class="book-card">
                    <strong><?= htmlspecialchars($book['title']) ?></strong><br>
                    <?= htmlspecialchars($book['author']) ?><br>
                    (<?= $book['quantity'] ?> db)
                    <?php if ($book['quantity'] > 0): ?>
                        <a href="?add=<?= $book['id'] ?>">Kölcsönzés</a>
                    <?php else: ?>
                        <p style="color: red;">Nincs elérhető példány</p>
                    <?php endif; ?>
                </div>
            <?php endforeach; ?>
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
        </div>

        <h2>Saját kölcsönzéseim</h2>
        <ul>
            <?php
            $stmt = $pdo->prepare("SELECT books.title, books.author, rentals.id FROM rentals JOIN books ON rentals.book_id = books.id WHERE rentals.user_id = ?");
            $stmt->execute([$_SESSION['user_id']]);
            $rentals = $stmt->fetchAll(PDO::FETCH_ASSOC);
            
            foreach ($rentals as $rental): ?>
                <li>
                    <?= htmlspecialchars($rental['title']) ?> - <?= htmlspecialchars($rental['author']) ?>
                    <a href="return.php?rental_id=<?= $rental['id'] ?>">Visszaadás</a>
                </li>
            <?php endforeach; ?>
        </ul>
    </div>
</body>
</html>
