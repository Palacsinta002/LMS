SELECT 
	Users.FirstName,
    Users.LastName,
    DATE_FORMAT(Users.DateOfBirth, "%d/%m/%Y"),
    Users.Address,
    Users.Username,
    Users.Email,
    Roles.Role,
    IF(Users.Verified, "Yes", "No")
FROM Users
JOIN Roles ON Roles.id = Users.RoleID
ORDER BY Users.FirstName, Users.LastName;