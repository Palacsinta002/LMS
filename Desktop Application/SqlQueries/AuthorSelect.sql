SELECT 
	Authors.Author,
    GROUP_CONCAT(DISTINCT Books.Title SEPARATOR ', ')
FROM Authors
JOIN Books_Authors ON Authors.id = Books_Authors.AuthorID
JOIN Books ON Books_Authors.ISBN = Books.ISBN
GROUP BY Author;