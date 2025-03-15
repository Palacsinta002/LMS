SELECT 
	Users.FirstName,
    Users.LastName,
    Users.Username,
    Users.Email,
    Users.Address,
    Roles.Role
FROM Users
JOIN Roles ON Roles.id = Users.RoleID
ORDER BY Users.FirstName, Users.LastName;