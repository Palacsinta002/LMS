SELECT 
	Authors.Author,
    COALESCE(GROUP_CONCAT(DISTINCT Books.Title SEPARATOR ', '), "-")
FROM Authors
LEFT JOIN Books_Authors ON Authors.id = Books_Authors.AuthorID
LEFT JOIN Books ON Books_Authors.ISBN = Books.ISBN
GROUP BY Author;