namespace Desktop_Application.Classes
{
    internal class HandleQueries
    {
        // Select books and fill the grid with data
        internal static void ListBooks(DataGridView books_grd)
        {
            Connection connection = new();
            string filePath = @"SqlQueries\BooksSelect.sql";
            string query = File.ReadAllText(filePath);
            var result = connection.Select(query);
            FillGrid.Fill(books_grd, result);
        }

        // Delete books and refresh the grid
        internal static void DeleteBooks(DataGridView books_grd, List<string> selectedISBNs)
        {
            Connection connection = new();
            foreach (string ISBN in selectedISBNs)
            {
                string query = $"DELETE FROM Books WHERE ISBN = {ISBN}";
                connection.Delete(query);
            }

            ListBooks(books_grd);
        }
    }
}
