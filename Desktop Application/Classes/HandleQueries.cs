namespace Desktop_Application.Classes;
internal class HandleQueries
{
    // Takes a grid and fills it with the Select result of the given filename
    internal static List<string[]> Select(string fileName)
    {
        Connection connection = new();
        string filePath = @"SqlQueries\" + fileName + ".sql";
        string query = File.ReadAllText(filePath);
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
    internal static void InsertBorrowing(string username, string isbn, DateTime borrowDate, DateTime dueDate)
    {
        string borrowDateString = $"{borrowDate.Year}-{borrowDate.Month}-{borrowDate.Day}";
        string dueDateString = $"{dueDate.Year}-{dueDate.Month}-{dueDate.Day}";
        Connection connection = new();
        string query = $"INSERT INTO Borrowings(UserID, ISBN, BorrowDate, DueDate) VALUES((SELECT id FROM Users WHERE Username = \"{username}\"), {isbn}," +
            $"\"{borrowDateString}\", \"{dueDateString}\")";
        connection.RunSqlCommand(query);
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
        Connection connection = new();
        string query = $"INSERT INTO Users(FirstName, LastName, dateOfBirth, Username, Password, Address, RoleID) VALUES(\"{firstName}\", \"{lastName}\", \"{dateOfBirth}\", \"{username}\", \"{hashedPassword}\", \"{address}\", 3)";
        connection.RunSqlCommand(query);
    }




    // UPDATE functions
    // Update book with the given arguments
    internal static void UpdateBook(DataGridView books_grd, string isbn, string publisher, string title, string pubYear, string authorsString, string categoriesString)
    {
        Delete(books_grd, "Books", "ISBN", "ISBN");

        InsertBook(isbn, publisher, title, pubYear, authorsString, categoriesString);
    }
    // Update borrowing
    internal static void UpdateBorrowing(string username, string isbn, DateTime borrowDate, DateTime dueDate)
    {
        string borrowDateString = $"{borrowDate.Year}-{borrowDate.Month}-{borrowDate.Day}";
        string dueDateString = $"{dueDate.Year}-{dueDate.Month}-{dueDate.Day}";
        Connection connection = new();
        string query = $"UPDATE Borrowings SET UserID = (SELECT id FROM Users WHERE Username = \"{username}\"), ISBN = {isbn}, " +
            $"BorrowDate = \"{borrowDateString}\", DueDate = \"{dueDateString}\" " +
            $"WHERE ISBN = {isbn}";
        connection.RunSqlCommand(query);
    }
    // Update borrowing - mark as returned
    internal static void UpdateBorrowing(DataGridView borrowings_grd, string returnDate)
    {
        Connection connection = new();
        foreach (DataGridViewRow row in borrowings_grd.SelectedRows)
        {
            string query = $"UPDATE Borrowings SET ReturnDate = \"{returnDate}\" WHERE ISBN = {row.Cells[2].Value}";
            connection.RunSqlCommand(query);
        }
    }
    // Update category with the given arguments
    internal static void UpdateCategory(DataGridView categories_grd, string category)
    {
        Connection connection = new();
        foreach (DataGridViewRow row in categories_grd.SelectedRows)
        {
            string query = $"UPDATE Categories SET Category = \"{category}\" WHERE Category = \"{row.Cells[0].Value}\"";
            connection.RunSqlCommand(query);
        }
    }
    // Update author with the given arguments
    internal static void UpdateAuthor(DataGridView authors_grd, string author)
    {
        Connection connection = new();
        foreach (DataGridViewRow row in authors_grd.SelectedRows)
        {
            string query = $"UPDATE Authors SET Author = \"{author}\" WHERE Author = \"{row.Cells[0].Value}\"";
            connection.RunSqlCommand(query);
        }
    }
    // Update publisher with the given arguments
    internal static void UpdatePublisher(DataGridView publisher_grd, string publisher)
    {
        Connection connection = new();
        foreach (DataGridViewRow row in publisher_grd.SelectedRows)
        {
            string query = $"UPDATE Publishers SET Publisher = \"{publisher}\" WHERE Publisher = \"{row.Cells[0].Value}\"";
            connection.RunSqlCommand(query);
        }
    }
    // Update user with the given arguments
    internal static void UpdatetUser(DataGridView users_grd, string firstName, string lastName, string email, string username, string address)
    {
        Connection connection = new();
        foreach (DataGridViewRow row in users_grd.SelectedRows)
        {
            string query = $"UPDATE Users SET FirstName = \"{firstName}\", LastName = \"{lastName}\", Email = \"{email}\", Username = \"{username}\", Address = \"{address}\" WHERE Username = \"{row.Cells[4].Value}\"";
            connection.RunSqlCommand(query);
        }
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