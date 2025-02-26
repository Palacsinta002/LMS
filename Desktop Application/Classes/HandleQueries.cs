namespace Desktop_Application.Classes
{
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



        // Insert functions
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
        internal static void InsertBorrowing(string username, string isbn, DateTime borrowDate, DateTime dueDate)
        {
            Connection connection = new();
            string query = $"INSERT INTO Borrowings(UserID, ISBN, BorrowDate, DueDate) VALUES((SELECT id FROM Users WHERE Username = \"{username}\"), {isbn}," +
                $"\"{borrowDate.Year}-{borrowDate.Month}-{borrowDate.Day}\", \"{dueDate.Year}-{dueDate.Month}-{dueDate.Day}\")";
            connection.RunSqlCommand(query);
        }




        // Update functions
        // Update book with the given arguments
        internal static void UpdateBook(DataGridView books_grd, string isbn, string publisher, string title, string pubYear, string authorsString, string categoriesString)
        {
            Delete(books_grd, "Books", "ISBN", "ISBN");

            InsertBook(isbn, publisher, title, pubYear, authorsString, categoriesString);
        }

        // Update borrowing - mark as returned
        internal static void UpdateBorrowing(DataGridView borrowings_grd, string returnDate)
        {
            Connection connection = new();
            foreach(DataGridViewRow row in borrowings_grd.SelectedRows)
            {
                string query = $"UPDATE Borrowings SET ReturnDate = \"{returnDate}\" WHERE ISBN = {row.Cells[2].Value};";
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
                string query = $"DELETE FROM {table} WHERE {dbcol} = {item}";
                connection.RunSqlCommand(query);
            }
        }
    }
}