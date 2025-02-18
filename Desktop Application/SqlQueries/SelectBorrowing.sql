SELECT 
    users.FirstName,
    users.LastName,
    books.Title,
    books.ISBN,
    borrowings.BorrowDate,
    borrowings.ReturnDate,
    borrowings.DueDate
FROM borrowings
JOIN Users ON users.id = borrowings.UserID
JOIN Books ON books.ISBN = borrowings.ISBN;