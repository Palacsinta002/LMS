SELECT
    GROUP_CONCAT(users.FirstName,' ', users.LastName),
    books.Title,
    books.ISBN,
    DATE_FORMAT(borrowings.BorrowDate, "%d %M %Y"),
    DATE_FORMAT(borrowings.ReturnDate, "%d %M %Y"),
    DATE_FORMAT(borrowings.DueDate, "%d %M %Y")
FROM borrowings
JOIN Users ON users.id = borrowings.UserID
JOIN Books ON books.ISBN = borrowings.ISBN
GROUP BY books.ISBN, borrowings.BorrowDate;