SELECT
    Users.Username,
    Books.Title,
    Borrowings.ISBN,
    DATE_FORMAT(Borrowings.BorrowDate, "%d/%m/%Y"),
    DATE_FORMAT(Borrowings.DueDate, "%d/%m/%Y")
FROM Borrowings
JOIN Users ON Users.id = Borrowings.UserID
JOIN Books ON Books.ISBN = Borrowings.ISBN
ORDER BY BorrowDate DESC;