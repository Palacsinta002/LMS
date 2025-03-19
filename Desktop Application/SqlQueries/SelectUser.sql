SELECT 
	Users.FirstName,
    Users.LastName,
    Users.dateOfBirth,
    Users.Address,
    Users.Verified
    Users.Username,
    Users.Email,
    Roles.Role
FROM Users
JOIN Roles ON Roles.id = Users.RoleID
ORDER BY Users.FirstName, Users.LastName;