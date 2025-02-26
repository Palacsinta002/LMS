DROP DATABASE IF EXISTS LMS;

-- Create the database
CREATE DATABASE LMS 
DEFAULT CHARACTER SET utf8 
COLLATE utf8_hungarian_ci;

-- Create lms user
CREATE USER IF NOT EXISTS "lms"@"%" IDENTIFIED BY "!LibraryMS25";
GRANT SELECT, INSERT, UPDATE, DELETE ON LMS.* TO "lms"@"%";

USE LMS;

-- Create Roles table
CREATE TABLE Roles(
    id INT AUTO_INCREMENT PRIMARY KEY,
    Role VARCHAR(100) NOT NULL
);

-- Create Authors table
CREATE TABLE Authors (
    id INT AUTO_INCREMENT PRIMARY KEY,
    Author VARCHAR(255) NOT NULL
);

-- Create Categories table
CREATE TABLE Categories (
    id INT AUTO_INCREMENT PRIMARY KEY,
    Category VARCHAR(100) NOT NULL
);

-- Create Publisher table
CREATE TABLE Publishers (
    id INT AUTO_INCREMENT PRIMARY KEY,
    Publisher VARCHAR(255) NOT NULL
);

-- Create Users table (previously called Members)
CREATE TABLE Users (
    id INT AUTO_INCREMENT PRIMARY KEY,
    FirstName VARCHAR(100) NOT NULL,
    LastName VARCHAR(100) NOT NULL,
    Email Varchar(50) NOT Null UNIQUE,
    Username Varchar(25) not null UNIQUE,
    Password varchar(100) not null,
    RoleID INT NOT NULL,
    FOREIGN KEY (RoleID) REFERENCES Roles(id) ON DELETE CASCADE
);

-- Create Books table
CREATE TABLE Books (
    ISBN BIGINT(13) PRIMARY KEY,
    PublisherID INT,
    Title VARCHAR(255) NOT NULL,
    PublicationYear int(4),
    FOREIGN KEY (PublisherID) REFERENCES Publishers(id) ON DELETE CASCADE
);

-- Create Books_Authors table to handle multiple authors per book
CREATE TABLE Books_Authors(
    ISBN BIGINT(13) NOT NULL,
    AuthorID INT NOT NULL,
    PRIMARY KEY (ISBN, AuthorID),
    FOREIGN KEY (ISBN) REFERENCES Books(ISBN) ON DELETE CASCADE,
    FOREIGN KEY (AuthorID) REFERENCES Authors(id) ON DELETE CASCADE
);

-- Create Books_Categories table to handle multiple categories per book
CREATE TABLE Books_Categories (
    ISBN BIGINT(13) NOT NULL,
    CategoryID INT NOT NULL,
    PRIMARY KEY (ISBN, CategoryID),
    FOREIGN KEY (ISBN) REFERENCES Books(ISBN) ON DELETE CASCADE,
    FOREIGN KEY (CategoryID) REFERENCES Categories(id) ON DELETE CASCADE
);

-- Create Borrowings table
CREATE TABLE Borrowings (
    id INT AUTO_INCREMENT PRIMARY KEY,
    UserID INT NOT NULL,
    ISBN BIGINT(13) NOT NULL,
    BorrowDate DATE NOT NULL,
    DueDate DATE NOT NULL,
    ReturnDate DATE,
    FOREIGN KEY (UserID) REFERENCES Users(id) ON DELETE CASCADE,
    FOREIGN KEY (ISBN) REFERENCES Books(ISBN) ON DELETE CASCADE
);

-- Create Borrowings_backup table
CREATE TABLE Borrowings_storage (
    id INT,
    UserID INT,
    Username VARCHAR(25),
    Title VARCHAR(255),
    ISBN BIGINT(13),
    BorrowDate DATE,
    DueDate DATE,
    ReturnDate DATE
);

DELIMITER $$

CREATE TRIGGER after_borrowing_insert
AFTER INSERT ON Borrowings
FOR EACH ROW
BEGIN
    INSERT INTO Borrowings_storage (id, UserID, Username, Title, ISBN, BorrowDate, DueDate, ReturnDate)
    VALUES (NEW.id, NEW.UserID, (SELECT Username FROM Users WHERE id = NEW.UserID), (SELECT Title FROM Books WHERE ISBN = NEW.ISBN), NEW.ISBN, NEW.BorrowDate, NEW.DueDate, NEW.ReturnDate);
END $$

CREATE TRIGGER after_borrowing_update
AFTER UPDATE ON Borrowings
FOR EACH ROW
BEGIN
    UPDATE Borrowings_storage
    SET 
        UserID = NEW.UserID,
        Username = (SELECT Username FROM Users WHERE id = NEW.UserID),
        Title = (SELECT Title FROM Books WHERE ISBN = NEW.ISBN),
        ISBN = NEW.ISBN,
        BorrowDate = NEW.BorrowDate,
        DueDate = NEW.DueDate,
        ReturnDate = NEW.ReturnDate
    WHERE id = OLD.id;
END $$

CREATE TRIGGER delete_authors_and_books
BEFORE DELETE ON Authors
FOR EACH ROW
BEGIN
    DELETE FROM Books
    WHERE ISBN IN (
        SELECT ISBN FROM Books_Authors WHERE AuthorID = OLD.id
    ) AND NOT EXISTS (
        SELECT ISBN FROM Books_Authors WHERE Books_Authors.ISBN = Books.ISBN AND Books_Authors.AuthorID != OLD.id
    );
END $$

CREATE TRIGGER delete_categories_and_books
BEFORE DELETE ON Categories
FOR EACH ROW
BEGIN
    DELETE FROM Books
    WHERE ISBN IN (
        SELECT ISBN FROM Books_Categories WHERE CategoryID = OLD.id
    ) AND NOT EXISTS (
        SELECT ISBN FROM Books_Categories WHERE Books_Categories.ISBN = Books.ISBN AND Books_Categories.CategoryID != OLD.id
    );
END $$

DELIMITER ;

-- Insert values into Roles table
INSERT INTO Roles (Role) VALUES
('Admin'),
('Librarian'),
('Member');

-- Insert values into Authors table
INSERT INTO Authors (Author) VALUES
('George Orwell'),
('J.K. Rowling'),
('Ernest Hemingway'),
('Gabriel Garcia Marquez'),
('Fyodor Dostoevsky'),
('Haruki Murakami'),
('Jane Austen'),
('Leo Tolstoy'),
('Mark Twain'),
('Isabel Allende'),
('J.R.R. Tolkien'),
('Agatha Christie'),
('William Shakespeare'),
('Charles Dickens'),
('Franz Kafka');

-- Insert values into Categories table
INSERT INTO Categories (Category) VALUES
('Fiction'),
('Non-fiction'),
('Science Fiction'),
('Fantasy'),
('Historical Fiction'),
('Mystery'),
('Biography'),
('Romance'),
('Thriller'),
('Self-help'),
('Classics'),
('Young Adult'),
('Adventure'),
('Horror'),
('Poetry');

-- Insert values into Publishers table
INSERT INTO Publishers (Publisher) VALUES
('Penguin Random House'),
('HarperCollins'),
('Simon & Schuster'),
('Hachette Livre'),
('Macmillan Publishers'),
('Oxford University Press'),
('Scholastic'),
('Cengage'),
('Wiley'),
('Pearson'),
('Springer'),
('McGraw-Hill'),
('Routledge'),
('Cambridge University Press'),
('Bloomsbury Publishing');

-- Insert values into Users table
INSERT INTO Users (FirstName, LastName, Email, Username, Password, RoleID) VALUES
('John', 'Doe', 'john.doe@example.com', 'johndoe', '$2y$10$s6wDg2g6WyuxoOrDg4wv4O2hfGcgGaLMhaMWSlNLu048HpF5snqIq', 3),
('Jane', 'Smith', 'jane.smith@example.com', 'janesmith', '$2y$10$0rK/0Ny/pPudrVWaCKCDfuViT9DiyBvXQjbkIODHGdjkRGgvDt/NO', 3),
('Admin', 'User', 'admin@example.com', 'admin', '$2y$10$M6a/92XfuWaAymQ3uTScju2in8rSdkRbdGPIeP.HFC2h.mODuqT4O', 1),
('Librarian', 'One', 'librarian1@example.com', 'librarian1', '$2y$10$85fqudNMJZc2lm.CBnznQ.2C9Z265MIIx6kJaMmlwNX8Q3u6wtG4G', 2),
('Alice', 'Johnson', 'alice.j@example.com', 'alicej', '$2y$10$GTQ29D1QP3PWG2ldSc.rnOdLnzN7NP1P4VvtIpuzU0NHtX4PLqIu.', 3),
('Bob', 'Brown', 'bob.brown@example.com', 'bobbrown', '$2y$10$0zrLGHesWh.0VJ9l57Kc8.6p7DI5LWTAU7kg27P5KK1M1aaOvdwhu', 3),
('Clara', 'Olsen', 'clara.olsen@example.com', 'clarao', '$2y$10$iJFpcy.LqYyqt00QQTpNAu4W7Tl5C44Hq9L3h7GTXmcsmHQP03OBO', 3),
('David', 'White', 'david.white@example.com', 'davidwhite', '$2y$10$4fXmOd1EXoX5ZKnWfS1L2eDRrS8WKqqGEFCkwlEhxzfycoT26u/ga', 3),
('Eve', 'Green', 'eve.green@example.com', 'evegreen', '$2y$10$mRlPDwVGnY5Nm.Zwhv/v.eBJqnmGaqfLEMLienuMGJ2FoMAev6iw6', 3),
('Frank', 'Moore', 'frank.moore@example.com', 'frankmoore', '$2y$10$ssUsidw4bUT1.9rcHzkUH.l.Hxeq5PzLXhE4W.V2kPwrcqAGp.3B6', 3),
('Grace', 'Lee', 'grace.lee@example.com', 'gracelee', '$2y$10$UqvjfjlxgpVC4yzcfMvhNutNJpSP5gnjKaizOV36Ad4hr/XLxhf2q', 3),
('Hannah', 'Scott', 'hannah.scott@example.com', 'hannahscott', '$2y$10$y/MlLUAOqRhK3h/STvJHl.xavuT57tQk6gze37FlYQ4RYmjPO0ox6', 3),
('Ian', 'Walker', 'ian.walker@example.com', 'ianwalker', '$2y$10$CQDXhfODyjHT34GHjaqSCeu3FKF.hFotCrzLAXsgRxF1JvK77nW6W', 3),
('Jack', 'Young', 'jack.young@example.com', 'jackyoung', '$2y$10$i7JYPvFT/sa6od7vlhp3oOJm2oV9XcGPjRxUR8RR11LhqmEfvQegu', 3),
('Laura', 'Harris', 'laura.harris@example.com', 'lauraharris', '$2y$10$7ohuabBRz5sXx2/0sFP4nOKcJl3XunwqNigHdTtQCsRosjmDFx0VW', 3);

-- Insert values into Books table
INSERT INTO Books (ISBN, PublisherID, Title, PublicationYear) VALUES
(9780451524935, 1, '1984', 1949),
(9780439708180, 2, 'Harry Potter and the Sorcerer''s Stone', 1997),
(9780684801223, 3, 'The Old Man and the Sea', 1952),
(9780060883287, 4, 'One Hundred Years of Solitude', 1967),
(9780486415871, 5, 'Crime and Punishment', 1866),
(9780375704024, 6, 'Norwegian Wood', 1987),
(9780141040349, 7, 'Pride and Prejudice', 1813),
(9780199232765, 8, 'War and Peace', 1869),
(9780486400778, 9, 'The Adventures of Tom Sawyer', 1876),
(9781501117015, 10, 'The House of the Spirits', 1982),
(9780345339683, 11, 'The Hobbit', 1937),
(9780062693661, 12, 'Murder on the Orient Express', 1934),
(9780743477123, 13, 'Hamlet', 1603),
(9780486415864, 14, 'Great Expectations', 1861),
(9780805209990, 15, 'The Trial', 1925);

-- Insert values into Books_Authors table
INSERT INTO Books_Authors (ISBN, AuthorID) VALUES
(9780451524935, 1),
(9780439708180, 2),
(9780684801223, 3),
(9780060883287, 4),
(9780486415871, 5),
(9780486415871, 6),
(9780375704024, 6),
(9780141040349, 7),
(9780199232765, 8),
(9780486400778, 9),
(9780486400778, 10),
(9781501117015, 10),
(9780345339683, 11),
(9780062693661, 12),
(9780062693661, 1),
(9780743477123, 13),
(9780743477123, 10),
(9780486415864, 14),
(9780805209990, 15);

-- Insert values into Books_Categories table
INSERT INTO Books_Categories (ISBN, CategoryID) VALUES
(9780451524935, 1),
(9780451524935, 3),
(9780439708180, 4),
(9780439708180, 12),
(9780684801223, 5),
(9780060883287, 1),
(9780060883287, 4),
(9780486415871, 1),
(9780375704024, 1),
(9780141040349, 8),
(9780199232765, 10),
(9780486400778, 1),
(9780486400778, 10),
(9781501117015, 1),
(9780345339683, 4),
(9780062693661, 6),
(9780743477123, 1),
(9780486415864, 1),
(9780805209990, 1);

-- Insert values into Borrowings table
INSERT INTO Borrowings (UserID, ISBN, BorrowDate, DueDate, ReturnDate) VALUES
(1, 9780451524935, '2024-09-01', '2024-09-15', NULL),
(2, 9780439708180, '2024-09-05', '2024-09-19', NULL),
(3, 9780684801223, '2024-09-10', '2024-09-24', NULL),
(4, 9780060883287, '2024-09-12', '2024-09-26', NULL),
(5, 9780486415871, '2024-09-15', '2024-09-29', NULL),
(6, 9780375704024, '2024-09-20', '2024-10-04', NULL),
(7, 9780141040349, '2024-09-25', '2024-10-09', NULL),
(8, 9780199232765, '2024-09-27', '2024-10-11', NULL),
(9, 9780486400778, '2024-09-30', '2024-10-14', NULL),
(10, 9781501117015, '2024-10-01', '2024-10-15', NULL),
(11, 9780345339683, '2024-10-02', '2024-10-16', NULL),
(12, 9780062693661, '2024-10-03', '2024-10-17', NULL),
(13, 9780743477123, '2024-10-04', '2024-10-18', NULL),
(14, 9780486415864, '2024-10-05', '2024-10-19', NULL),
(15, 9780805209990, '2024-10-06', '2024-10-20', NULL);