SELECT
    Users.Username,
    Books.Title,
    Borrowings.ISBN,
    DATE_FORMAT(Borrowings.BorrowDate, "%d %M %Y"),
    DATE_FORMAT(Borrowings.DueDate, "%d %M %Y"),
    DATE_FORMAT(Borrowings.ReturnDate, "%d %M %Y")
FROM Borrowings
JOIN Users ON Users.id = Borrowings.UserID
JOIN Books ON Books.ISBN = Borrowings.ISBN
ORDER BY BorrowDate DESC, ISBN ASC;