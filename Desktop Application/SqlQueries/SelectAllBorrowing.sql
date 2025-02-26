SELECT
    Username,
    Title,
    ISBN,
    DATE_FORMAT(BorrowDate, "%d %M %Y"),
    DATE_FORMAT(DueDate, "%d %M %Y"),
    DATE_FORMAT(ReturnDate, "%d %M %Y")
FROM Borrowings_storage
ORDER BY BorrowDate DESC, ISBN ASC;