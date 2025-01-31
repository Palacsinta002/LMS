SELECT 
    Books.Title,
    GROUP_CONCAT(DISTINCT Authors.Author ORDER BY Authors.Author SEPARATOR ', '),
    Books.PublicationYear,
    GROUP_CONCAT(DISTINCT Categories.Category ORDER BY Categories.Category SEPARATOR ', '),
    Publishers.Publisher,
    Books.ISBN
FROM Books
JOIN Publishers ON Books.PublisherID = Publishers.id
JOIN Books_Authors ON Books.ISBN = Books_Authors.ISBN
JOIN Authors ON Books_Authors.AuthorID = Authors.id
JOIN Books_Categories ON Books.ISBN = Books_Categories.ISBN
JOIN Categories ON Books_Categories.CategoryID = Categories.id
GROUP BY Books.Title, Books.PublicationYear, Publishers.Publisher, Books.ISBN;