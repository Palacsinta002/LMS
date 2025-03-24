SELECT
	Users.Username,
	Books.Title,
	Reservations.ISBN,
    DATE_FORMAT(ReservationStartDate, "%d/%m/%Y"),
    DATE_FORMAT(ReservationEndDate, "%d/%m/%Y")
FROM Reservations
JOIN Users ON Users.id = UserID
JOIN Books ON Books.ISBN = Reservations.ISBN
ORDER BY ReservationStartDate DESC, Reservations.ISBN ASC;