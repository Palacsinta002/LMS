CREATE DATABASE book_rental;
USE book_rental;

CREATE TABLE users (
    id INT AUTO_INCREMENT PRIMARY KEY,
    username VARCHAR(50) NOT NULL UNIQUE,
    password VARCHAR(255) NOT NULL
);

CREATE TABLE books (
    id INT AUTO_INCREMENT PRIMARY KEY,
    title VARCHAR(255) NOT NULL,
    author VARCHAR(255) NOT NULL,
    quantity INT NOT NULL DEFAULT 1
);

CREATE TABLE rentals (
    id INT AUTO_INCREMENT PRIMARY KEY,
    user_id INT NOT NULL,
    book_id INT NOT NULL,
    rented_at DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (user_id) REFERENCES users(id) ON DELETE CASCADE,
    FOREIGN KEY (book_id) REFERENCES books(id) ON DELETE CASCADE
);

-- Példa felhasználók (Jelszavakat hashelni kellene a PHP-ban!)
INSERT INTO users (username, password) VALUES ('admin', 'admin123');

-- Példa könyvek
INSERT INTO books (title, author, quantity) VALUES 
('A könyv címe 1', 'Szerző 1', 3),
('A könyv címe 2', 'Szerző 2', 5),
('A könyv címe 3', 'Szerző 3', 2);
