DROP DATABASE IF EXISTS LMS;

-- Create the database
CREATE DATABASE LMS 
DEFAULT CHARACTER SET utf8 
COLLATE utf8_hungarian_ci;

USE LMS;

-- Create MembershipType table
CREATE TABLE MembershipType(
    MembershipTypeID INT AUTO_INCREMENT PRIMARY KEY,
    MembershipType VARCHAR(100) NOT NULL
);

-- Create Roles table
CREATE TABLE Roles(
    RoleID INT AUTO_INCREMENT PRIMARY KEY,
    Role VARCHAR(100) NOT NULL
);

-- Create Authors table
CREATE TABLE Authors (
    AuthorID INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(255) NOT NULL
);

-- Create Categories table
CREATE TABLE Categories (
    CategoryID INT AUTO_INCREMENT PRIMARY KEY,
    Category VARCHAR(100) NOT NULL
);

-- Create Publisher table
CREATE TABLE Publishers (
    PublisherID INT AUTO_INCREMENT PRIMARY KEY,
    Publisher VARCHAR(255) NOT NULL
);


-- Create Users table (previously called Members)
CREATE TABLE Users (
    UserID INT AUTO_INCREMENT PRIMARY KEY,
    FirstName VARCHAR(100) NOT NULL,
    LastName VARCHAR(100) NOT NULL,
    Email Varchar(50) not Null,
    Username Varchar(25) not null,
    Password varchar(100) not null,
    MembershipTypeID INT NOT NULL,
    RoleID INT NOT NULL,
    FOREIGN KEY (MembershipTypeID) REFERENCES MembershipType(MembershipTypeID),
    FOREIGN KEY (RoleID) REFERENCES Roles(RoleID)
);

-- Create Books table
CREATE TABLE Books (
    ISBN BIGINT(13) PRIMARY KEY,
    PublisherID INT,
    AuthorID INT,
    CategoryID INT,
    Title VARCHAR(255) NOT NULL,
    PublicationYear INT(4),
    FOREIGN KEY (AuthorID) REFERENCES Authors(AuthorID),
    FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID),
    FOREIGN KEY (PublisherID) REFERENCES Publishers(PublisherID)
);

-- Create Borrowings table
CREATE TABLE Borrowings (
    BorrowID INT AUTO_INCREMENT PRIMARY KEY,
    UserID INT NOT NULL,
    ISBN BIGINT NOT NULL,
    BorrowDate DATE NOT NULL,
    ReturnDate Date,
    DueDate Date not null,
    IsReturned boolean,
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    FOREIGN KEY (ISBN) REFERENCES Books(ISBN)
);


-- Values
INSERT INTO MembershipType (MembershipType) VALUES
('Student'),
('Teacher'),
('Adult'),
('None');

INSERT INTO Roles (Role) VALUES
('Admin'),
('Librarian'),
('Member');

INSERT INTO Authors (Name) VALUES
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

INSERT INTO Users (FirstName, LastName, Email, Username, Password, MembershipTypeID, RoleID) VALUES
('John', 'Doe', 'john.doe@example.com', 'johndoe', 'password123', 1, 3),
('Jane', 'Smith', 'jane.smith@example.com', 'janesmith', 'password123', 2, 3),
('Admin', 'User', 'admin@example.com', 'admin', 'adminpassword', 4, 1),
('Librarian', 'One', 'librarian1@example.com', 'librarian1', 'libpass', 4, 2),
('Alice', 'Johnson', 'alice.j@example.com', 'alicej', 'alice123', 1, 3),
('Bob', 'Brown', 'bob.brown@example.com', 'bobbrown', 'bobpass', 2, 3),
('Clara', 'Olsen', 'clara.olsen@example.com', 'clarao', 'clarapass', 3, 3),
('David', 'White', 'david.white@example.com', 'davidwhite', 'davidpass', 3, 3),
('Eve', 'Green', 'eve.green@example.com', 'evegreen', 'evepass', 2, 3),
('Frank', 'Moore', 'frank.moore@example.com', 'frankmoore', 'frankpass', 1, 3),
('Grace', 'Lee', 'grace.lee@example.com', 'gracelee', 'gracepass', 4, 3),
('Hannah', 'Scott', 'hannah.scott@example.com', 'hannahscott', 'hannahpass', 4, 3),
('Ian', 'Walker', 'ian.walker@example.com', 'ianwalker', 'ianpass', 3, 3),
('Jack', 'Young', 'jack.young@example.com', 'jackyoung', 'jackpass', 2, 3),
('Laura', 'Harris', 'laura.harris@example.com', 'lauraharris', 'laurapass', 1, 3);

INSERT INTO Books (ISBN, PublisherID, AuthorID, CategoryID, Title, PublicationYear) VALUES
(9780451524935, 1, 1, 1, '1984', 1949),
(9780439708180, 2, 2, 4, 'Harry Potter and the Sorcerer''s Stone', 1997),
(9780684801223, 3, 3, 5, 'The Old Man and the Sea', 1952),
(9780060883287, 4, 4, 1, 'One Hundred Years of Solitude', 1967),
(9780486415871, 5, 5, 1, 'Crime and Punishment', 1866),
(9780375704024, 6, 6, 1, 'Norwegian Wood', 1987),
(9780141040349, 7, 7, 8, 'Pride and Prejudice', 1813),
(9780199232765, 8, 8, 10, 'War and Peace', 1869),
(9780486400778, 9, 9, 1, 'The Adventures of Tom Sawyer', 1876),
(9781501117015, 10, 10, 1, 'The House of the Spirits', 1982),
(9780345339683, 11, 11, 4, 'The Hobbit', 1937),
(9780062693661, 12, 12, 6, 'Murder on the Orient Express', 1934),
(9780743477123, 13, 13, 1, 'Hamlet', 1603),
(9780486415864, 14, 14, 1, 'Great Expectations', 1861),
(9780805209990, 15, 15, 1, 'The Trial', 1925);

INSERT INTO Borrowings (UserID, ISBN, BorrowDate, DueDate, ReturnDate, IsReturned) VALUES
(1, 9780451524935, '2024-09-01', '2024-09-15', '2024-09-14', TRUE),
(2, 9780439708180, '2024-09-05', '2024-09-19', '2024-09-19', TRUE),
(3, 9780684801223, '2024-09-10', '2024-09-24', NULL, FALSE),
(4, 9780060883287, '2024-09-12', '2024-09-26', '2024-09-25', TRUE),
(5, 9780486415871, '2024-09-15', '2024-09-29', NULL, FALSE),
(6, 9780375704024, '2024-09-20', '2024-10-04', NULL, FALSE),
(7, 9780141040349, '2024-09-25', '2024-10-09', NULL, FALSE),
(8, 9780199232765, '2024-09-27', '2024-10-11', NULL, FALSE),
(9, 9780486400778, '2024-09-30', '2024-10-14', NULL, FALSE),
(10, 9781501117015, '2024-10-01', '2024-10-15', NULL, FALSE),
(11, 9780345339683, '2024-10-02', '2024-10-16', NULL, FALSE),
(12, 9780062693661, '2024-10-03', '2024-10-17', NULL, FALSE),
(13, 9780743477123, '2024-10-04', '2024-10-18', NULL, FALSE),
(14, 9780486415864, '2024-10-05', '2024-10-19', NULL, FALSE),
(15, 9780805209990, '2024-10-06', '2024-10-20', NULL, FALSE);