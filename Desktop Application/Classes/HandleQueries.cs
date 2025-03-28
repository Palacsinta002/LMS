namespace Desktop_Application.Classes;
internal class HandleQueries
{
    // Takes a grid and fills it with the Select result of the given filename
    internal static List<string[]> SelectFromFile(string fileName)
    {
        Connection connection = new();
        string filePath = @"SqlQueries\" + fileName + ".sql";
        string query = File.ReadAllText(filePath);
        return connection.Select(query);
    }

    // Select the
    internal static List<string[]> SelectFromString(string query)
    {
        Connection connection = new();
        return connection.Select(query);
    }


    // INSERT functions
    // Insert book with the given arguments
    internal static void InsertBook(string isbn, string publisher, string title, string pubYear, string authorsString, string categoriesString)
    {
        List<string> authors = authorsString.Split(", ").ToList();
        List<string> categories = categoriesString.Split(", ").ToList();

        Connection connection = new();
        string query = $"INSERT INTO Books (ISBN, PublisherID, Title, PublicationYear) VALUES ({isbn}, (SELECT id FROM Publishers WHERE Publisher = \"{publisher}\"), \"{title}\", {pubYear})";
        connection.RunSqlCommand(query);

        for (int i = 0; i < authors.Count; i++)
        {
            query = $"INSERT INTO Books_Authors (ISBN, AuthorID) VALUES ({isbn}, (SELECT id FROM Authors WHERE Author = \"{authors[i]}\"))";
            connection.RunSqlCommand(query);
        }
        for (int i = 0; i < categories.Count; i++)
        {
            query = $"INSERT INTO Books_Categories (ISBN, CategoryID) VALUES ({isbn}, (SELECT id FROM Categories WHERE Category = \"{categories[i]}\"))";
            connection.RunSqlCommand(query);
        }
    }
    // Insert borrowing with the given arguments
    internal static void InsertBorrowing(string username, string isbns, DateTime borrowDate, DateTime dueDate)
    {
        Connection connection = new();

        string borrowDateString = $"{borrowDate.Year}-{borrowDate.Month}-{borrowDate.Day}";
        string dueDateString = $"{dueDate.Year}-{dueDate.Month}-{dueDate.Day}";
        string[] isbnArr = isbns.Split(", ");

        foreach (string isbn in isbnArr)
        {
            string query = $"INSERT INTO Borrowings(UserID, ISBN, BorrowDate, DueDate) VALUES((SELECT id FROM Users WHERE Username = \"{username}\"), {isbn}," +
                $"\"{borrowDateString}\", \"{dueDateString}\")";
            connection.RunSqlCommand(query);
        }
    }
    // Insert reservation with the given arguments
    internal static void InsertReservation(string username, string isbns)
    {
        Connection connection = new();

        string[] isbnArr = isbns.Split(", ");

        foreach (string isbn in isbnArr)
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
    internal static void InsertUser(string firstName, string lastName, DateTime dateOfBirth, string username, string hashedPassword, string address)
    {
        string dateOfBirthString = $"{dateOfBirth.Year}-{dateOfBirth.Month}-{dateOfBirth.Day}";

        Connection connection = new();
        string query = $"INSERT INTO Users(FirstName, LastName, dateOfBirth, Username, Password, Address, Verified, RoleID) VALUES(\"{firstName}\", \"{lastName}\", \"{dateOfBirthString}\", \"{username}\", \"{hashedPassword}\", \"{address}\", 1, 3)";
        connection.RunSqlCommand(query);
    }




    // UPDATE functions
    // Update book with the given arguments
    internal static void UpdateBook(DataGridView books_grd, string isbn, string publisher, string title, string pubYear, string authorsString, string categoriesString)
    {
        Delete(books_grd, "Books", "books_isbn", "ISBN");

        InsertBook(isbn, publisher, title, pubYear, authorsString, categoriesString);
    }
    // Update borrowing
    internal static void UpdateBorrowing(string isbn, DateTime dueDate)
    {
        string dueDateString = $"{dueDate.Year}-{dueDate.Month}-{dueDate.Day}";

        Connection connection = new();
        string query = $"UPDATE Borrowings SET DueDate = \"{dueDateString}\" WHERE ISBN = {isbn}";
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
    internal static void UpdateReservation(string isbn, DateTime reservationEndDate)
    {
        string reservationEndDateString = $"{reservationEndDate.Year}-{reservationEndDate.Month}-{reservationEndDate.Day}";

        Connection connection = new();
        string query = $"UPDATE Reservations SET ReservationEndDate = \"{reservationEndDateString}\" WHERE ISBN = {isbn}";
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
    internal static void UpdateUser(string oldUsername, string firstName, string lastName, DateTime dateOfBirth, string username, string address, bool verified)
    {
        string dateOfBirthString = $"{dateOfBirth.Year}-{dateOfBirth.Month}-{dateOfBirth.Day}";

        Connection connection = new();
        string query = $"UPDATE Users SET FirstName = \"{firstName}\", LastName = \"{lastName}\", DateOfBirth = \"{dateOfBirthString}\", Username = \"{username}\", Address = \"{address}\", Verified = {verified} WHERE Username = \"{oldUsername}\"";
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
    internal static void UpdateProfile(string oldUsername, string firstName, string lastName, string username, DateTime dateOfBirth, string email, string address, string password)
    {
        string dateOfBirthString = $"{dateOfBirth.Year}-{dateOfBirth.Month}-{dateOfBirth.Day}";

        Connection connection = new();
        string query = $"UPDATE Users SET FirstName = \"{firstName}\", LastName = \"{lastName}\", Username = \"{username}\", DateOfBirth = \"{dateOfBirthString}\", Email = \"{email}\", Address = \"{address}\", Password = \"{password}\" WHERE Username = \"{oldUsername}\"";
        connection.RunSqlCommand(query);
    }



    // Deletes the selected item in the given grid from the given table based on the given column
    internal static void Delete(DataGridView grd, string table, string grdcol, string dbcol)
    {
        Connection connection = new();
        foreach (DataGridViewRow row in grd.SelectedRows)
        {
            string item = row.Cells[grdcol].Value.ToString() ?? string.Empty;
            string query = $"DELETE FROM {table} WHERE {dbcol} = \"{item}\"";
            connection.RunSqlCommand(query);
        }
    }
}