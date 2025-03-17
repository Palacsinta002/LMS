SELECT 
    Books.Title,
    GROUP_CONCAT(DISTINCT Authors.Author SEPARATOR ', '),
    Books.PublicationYear,
    Books.ISBN
FROM Books
JOIN Publishers ON Books.PublisherID = Publishers.id
JOIN Books_Authors ON Books.ISBN = Books_Authors.ISBN
JOIN Authors ON Books_Authors.AuthorID = Authors.id
WHERE NOT EXISTS (SELECT Borrowings.ISBN FROM Borrowings WHERE Borrowings.ISBN = Books.ISBN AND Borrowings.ReturnDate IS NULL)
GROUP BY Books.Title, Books.PublicationYear, Books.ISBN
ORDER BY Books.Title;