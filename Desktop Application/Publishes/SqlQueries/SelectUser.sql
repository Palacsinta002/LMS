SELECT 
	Users.FirstName,
    Users.LastName,
    DATE_FORMAT(Users.DateOfBirth, "%d/%m/%Y"),
    Users.Address,
    IF(Users.Verified, "Yes", "No"),
    Users.Username,
    Users.Email,
    Roles.Role
FROM Users
JOIN Roles ON Roles.id = Users.RoleID
ORDER BY Users.FirstName, Users.LastName;