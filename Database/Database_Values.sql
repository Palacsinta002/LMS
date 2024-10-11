INSERT INTO MembershipType (MembershipType) VALUES
('Student'),
('Teacher'),
('Adult'),
('None');

INSERT INTO Roles (Role) VALUES
('Member'),
('Admin'),
('Librarian');

INSERT INTO Authors (Name, Nationality) VALUES
('George Orwell', 'British'),
('J.K. Rowling', 'British'),
('Ernest Hemingway', 'American'),
('Gabriel Garcia Marquez', 'Colombian'),
('Fyodor Dostoevsky', 'Russian'),
('Haruki Murakami', 'Japanese'),
('Jane Austen', 'British'),
('Leo Tolstoy', 'Russian'),
('Mark Twain', 'American'),
('Isabel Allende', 'Chilean'),
('J.R.R. Tolkien', 'British'),
('Agatha Christie', 'British'),
('William Shakespeare', 'British'),
('Charles Dickens', 'British'),
('Franz Kafka', 'Czech');

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


INSERT INTO Books (PublisherID, AuthorID, CategoryID, Title, PublicationYear, ISBN, CopiesAvailable) VALUES
(1, 1, 1, '1984', 1949, '9780451524935', 5),
(2, 2, 4, 'Harry Potter and the Sorcerer''s Stone', 1997, '9780439708180', 3),
(3, 3, 5, 'The Old Man and the Sea', 1952, '9780684801223', 2),
(4, 4, 1, 'One Hundred Years of Solitude', 1967, '9780060883287', 4),
(5, 5, 1, 'Crime and Punishment', 1866, '9780486415871', 6),
(6, 6, 1, 'Norwegian Wood', 1987, '9780375704024', 7),
(7, 7, 8, 'Pride and Prejudice', 1813, '9780141040349', 10),
(8, 8, 10, 'War and Peace', 1869, '9780199232765', 2),
(9, 9, 1, 'The Adventures of Tom Sawyer', 1876, '9780486400778', 3),
(10, 10, 1, 'The House of the Spirits', 1982, '9781501117015', 5),
(11, 11, 4, 'The Hobbit', 1937, '9780345339683', 4),
(12, 12, 6, 'Murder on the Orient Express', 1934, '9780062693661', 7),
(13, 13, 1, 'Hamlet', 1603, '9780743477123', 5),
(14, 14, 1, 'Great Expectations', 1861, '9780486415864', 6),
(15, 15, 1, 'The Trial', 1925, '9780805209990', 3);


INSERT INTO Borrowings (UserID, BookID, BorrowDate, DueDate, ReturnDate, IsReturned) VALUES
(1, 1, '2024-09-01', '2024-09-15', '2024-09-14', TRUE),
(2, 2, '2024-09-05', '2024-09-19', '2024-09-19', TRUE),
(3, 3, '2024-09-10', '2024-09-24', NULL, FALSE),
(4, 4, '2024-09-12', '2024-09-26', '2024-09-25', TRUE),
(5, 5, '2024-09-15', '2024-09-29', NULL, FALSE),
(6, 6, '2024-09-20', '2024-10-04', NULL, FALSE),
(7, 7, '2024-09-25', '2024-10-09', NULL, FALSE),
(8, 8, '2024-09-27', '2024-10-11', NULL, FALSE),
(9, 9, '2024-09-30', '2024-10-14', NULL, FALSE),
(10, 10, '2024-10-01', '2024-10-15', NULL, FALSE),
(11, 11, '2024-10-02', '2024-10-16', NULL, FALSE),
(12, 12, '2024-10-03', '2024-10-17', NULL, FALSE),
(13, 13, '2024-10-04', '2024-10-18', NULL, FALSE),
(14, 14, '2024-10-05', '2024-10-19', NULL, FALSE),
(15, 15, '2024-10-06', '2024-10-20', NULL, FALSE);
