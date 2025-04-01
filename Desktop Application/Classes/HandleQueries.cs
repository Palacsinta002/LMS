namespace Desktop_Application.Classes;

internal class HandleQueries
{
    // Returns Select result of the given filename
    internal static List<string[]> SelectFromFile(string fileName)
    {
        Connection connection = new();
        string filePath = @"SqlQueries\" + fileName + ".sql";
        string query = File.ReadAllText(filePath);
        return connection.Select(query);
    }

    // Returns Select result of the given string
    internal static List<string[]> SelectFromString(string query)
    {
        Connection connection = new();
        return connection.Select(query);
    }


    // INSERT functions
    // Insert book with the given arguments
    internal static void InsertBook(string isbn, string publisher, string title, string pubYear, string[] authors, string[] categories)
    {
        Connection connection = new();
        string query;

        query = $"INSERT INTO Books (ISBN, PublisherID, Title, PublicationYear) VALUES ({isbn}, (SELECT id FROM Publishers WHERE Publisher = \"{publisher}\"), \"{title}\", {pubYear})";
        connection.RunSqlCommand(query);

        // Insert book-author into bridging table
        foreach(string author in authors)
        {
            query = $"INSERT INTO Books_Authors (ISBN, AuthorID) VALUES ({isbn}, (SELECT id FROM Authors WHERE Author = \"{author}\"))";
            connection.RunSqlCommand(query);
        }
        // Insert book-category into bridging table
        foreach (string category in categories)
        {
            query = $"INSERT INTO Books_Categories (ISBN, CategoryID) VALUES ({isbn}, (SELECT id FROM Categories WHERE Category = \"{category}\"))";
            connection.RunSqlCommand(query);
        }
    }
    // Insert borrowing with the given arguments
    internal static void InsertBorrowing(string username, string[] isbns, string borrowDate, string dueDate)
    {
        Connection connection = new();

        foreach (string isbn in isbns)
        {
            string query = $"INSERT INTO Borrowings(UserID, ISBN, BorrowDate, DueDate) VALUES((SELECT id FROM Users WHERE Username = \"{username}\"), {isbn}," +
                $"\"{borrowDate}\", \"{dueDate}\")";
            connection.RunSqlCommand(query);
        }
    }
    // Insert reservation with the given arguments
    internal static void InsertReservation(string username, string[] isbns)
    {
        Connection connection = new();

        foreach (string isbn in isbns)
        {
            string query = $"INSERT INTO Reservations(UserID, ISBN) VALUES((SELECT id FROM Users WHERE Username = \"{username}\"), {isbn})";
            connection.RunSqlCommand(query);
        }
    }
    // Insert category with the given arguments
    internal static void InsertCategory(string category)
    {
        Connection connection = new();
        string query = $"INSERT INTO Categories(Category) VALUES(\"{category}\")";
        connection.RunSqlCommand(query);
    }
    // Insert author with the given arguments
    internal static void InsertAuthor(string author)
    {
        Connection connection = new();
        string query = $"INSERT INTO Authors(Author) VALUES(\"{author}\")";
        connection.RunSqlCommand(query);
    }
    // Insert publisher with the given arguments
    internal static void InsertPublisher(string publisher)
    {
        Connection connection = new();
        string query = $"INSERT INTO Publishers(Publisher) VALUES(\"{publisher}\")";
        connection.RunSqlCommand(query);
    }
    // Insert user with the given arguments
    internal static void InsertUser(string firstName, string lastName, string dateOfBirth, string username, string hashedPassword, string address)
    {
        Connection connection = new();
        string query = $"INSERT INTO Users(FirstName, LastName, dateOfBirth, Username, Password, Address, Verified, RoleID) VALUES(\"{firstName}\", \"{lastName}\", \"{dateOfBirth}\", \"{username}\", \"{hashedPassword}\", \"{address}\", 1, 3)";
        connection.RunSqlCommand(query);
    }




    // UPDATE functions
    // Update book with the given arguments
    internal static void UpdateBook(string oldIsbn, string isbn, string publisher, string title, string pubYear, string[] authors, string[] categories)
    {
        Connection connection = new();
        string query;

        // Update book itself
        query = $"UPDATE Books SET ISBN = {isbn}, PublisherID = (SELECT id FROM Publishers WHERE Publisher = \"{publisher}\"), " +
            $"Title = \"{title}\", PublicationYear = {pubYear} " +
            $"WHERE ISBN = {oldIsbn}";
        connection.RunSqlCommand(query);

        // Update Books_Authors bridging table
        query = $"DELETE FROM Books_Authors WHERE ISBN = {oldIsbn} AND " +
            $"AuthorID NOT IN ({string.Join(", ", authors.Select(author => $"(SELECT id FROM Authors WHERE Author = \"{author}\")"))})";
        connection.RunSqlCommand(query);

        foreach(string author in authors)
        {
            query = $"INSERT INTO Books_Authors (ISBN, AuthorID) " +
                $"SELECT {oldIsbn}, id FROM Authors " +
                $"WHERE Author = \"{author}\" AND " +
                $"id NOT IN (SELECT AuthorID FROM Books_Authors WHERE ISBN = {oldIsbn})";
            connection.RunSqlCommand(query);
        }

        // Update Books_Categories bridging table
        query = $"DELETE FROM Books_Categories WHERE ISBN = {oldIsbn} AND " +
            $"CategoryID NOT IN ({string.Join(", ", categories.Select(category => $"(SELECT id FROM Categories WHERE Category = \"{category}\")"))})";
        connection.RunSqlCommand(query);

        foreach (string category in categories)
        {
            query = $"INSERT INTO Books_Categories (ISBN, CategoryID) " +
                $"SELECT {oldIsbn}, id FROM Categories " +
                $"WHERE Category = \"{category}\" AND " +
                $"id NOT IN (SELECT CategoryID FROM Books_Categories WHERE ISBN = {oldIsbn})";
            connection.RunSqlCommand(query);
        }
    }
    // Update borrowing
    internal static void UpdateBorrowing(string isbn, string dueDate)
    {

        Connection connection = new();
        string query = $"UPDATE Borrowings SET DueDate = \"{dueDate}\" WHERE ISBN = {isbn}";
        connection.RunSqlCommand(query);
    }
    // Update borrowing - mark as returned
    internal static void UpdateBorrowing(List<string> isbnArr, string returnDate)
    {
        Connection connection = new();

        foreach (string isbn in isbnArr)
        {
            string query = $"UPDATE Borrowings SET ReturnDate = \"{returnDate}\" WHERE ISBN = {isbn}";
            connection.RunSqlCommand(query);
        }
    }
    // Update reservation with the given arguments
    internal static void UpdateReservation(string isbn, string reservationEndDate)
    {
        Connection connection = new();
        string query = $"UPDATE Reservations SET ReservationEndDate = \"{reservationEndDate}\" WHERE ISBN = {isbn}";
        connection.RunSqlCommand(query);
    }
    // Update category with the given arguments
    internal static void UpdateCategory(string oldCategory, string category)
    {
        Connection connection = new();
        string query = $"UPDATE Categories SET Category = \"{category}\" WHERE Category = \"{oldCategory}\"";
        connection.RunSqlCommand(query);
    }
    // Update author with the given arguments
    internal static void UpdateAuthor(string oldAuthor, string author)
    {
        Connection connection = new();
        string query = $"UPDATE Authors SET Author = \"{author}\" WHERE Author = \"{oldAuthor}\"";
        connection.RunSqlCommand(query);
    }
    // Update publisher with the given arguments
    internal static void UpdatePublisher(string oldPublisher, string publisher)
    {
        Connection connection = new();
        string query = $"UPDATE Publishers SET Publisher = \"{publisher}\" WHERE Publisher = \"{oldPublisher}\"";
        connection.RunSqlCommand(query);
    }
    // Update user with the given arguments
    internal static void UpdateUser(string oldUsername, string firstName, string lastName, string dateOfBirth, string username, string address, bool verified)
    {
        Connection connection = new();
        string query = $"UPDATE Users SET FirstName = \"{firstName}\", LastName = \"{lastName}\", DateOfBirth = \"{dateOfBirth}\", Username = \"{username}\", Address = \"{address}\", Verified = {verified} WHERE Username = \"{oldUsername}\"";
        connection.RunSqlCommand(query);
    }
    // Update user password
    internal static void UpdateUserPassword(string username, string hashedPassword)
    {
        Connection connection = new();
        string query = $"UPDATE Users SET Password = \"{hashedPassword}\" WHERE Username = \"{username}\"";
        connection.RunSqlCommand(query);
    }
    // Update logged in user
    internal static void UpdateProfile(string oldUsername, string firstName, string lastName, string username, string dateOfBirth, string email, string address, string password)
    {
        Connection connection = new();
        string query = $"UPDATE Users SET FirstName = \"{firstName}\", LastName = \"{lastName}\", Username = \"{username}\", DateOfBirth = \"{dateOfBirth}\", Email = \"{email}\", Address = \"{address}\", Password = \"{password}\" WHERE Username = \"{oldUsername}\"";
        connection.RunSqlCommand(query);
    }



    // Deletes the selected item in the given grid from the given table based on the given column
    internal static void Delete(List<string> selectedItems, string table, string dbcol)
    {
        Connection connection = new();
        foreach (string item in selectedItems)
        {
            string query = $"DELETE FROM {table} WHERE {dbcol} = \"{item}\"";
            connection.RunSqlCommand(query);
        }
    }
}