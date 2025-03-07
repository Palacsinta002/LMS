SELECT 
	CONCAT(Users.FirstName, " ", Users.LastName),
    Users.Email,
    Users.Username, 
    Roles.Role
FROM Users
JOIN Roles ON Roles.id = Users.RoleID;