SELECT
    Username,
    Title,
    ISBN,
    DATE_FORMAT(BorrowDate, "%d/%m/%Y"),
    DATE_FORMAT(DueDate, "%d/%m/%Y"),
    DATE_FORMAT(ReturnDate, "%d/%m/%Y")
FROM Borrowings_storage
ORDER BY BorrowDate DESC;