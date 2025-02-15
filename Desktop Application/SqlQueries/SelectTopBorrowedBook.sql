SELECT
	COUNT(Borrowings.id),
    Books.Title,
    GROUP_CONCAT(DISTINCT Authors.Author SEPARATOR ', '),
    Books.PublicationYear,
    GROUP_CONCAT(DISTINCT Categories.Category SEPARATOR ', ')
FROM Books
JOIN Books_Authors ON Books.ISBN = Books_Authors.ISBN
JOIN Authors ON Books_Authors.AuthorID = Authors.id
JOIN Books_Categories ON Books.ISBN = Books_Categories.ISBN
JOIN Categories ON Books_Categories.CategoryID = Categories.id
JOIN Borrowings ON Books.ISBN = Borrowings.ISBN
GROUP BY Books.Title, Books.PublicationYear
ORDER BY COUNT(Borrowings.id) DESC
LIMIT 10;