using MySqlX.XDevAPI.Common;

namespace Desktop_Application.Classes
{
    internal class HandleQueries
    {
        // Select books and fill the grid
        internal static void ListBooks(DataGridView grd)
        {
            Connection connection = new();
            string filePath = @"SqlQueries\BooksSelect.sql";
            string query = File.ReadAllText(filePath);
            var result = connection.Select(query);
            FillGrid.Fill(grd, result);
        }

        // Insert book what is given by the user
        internal static void InsertBook()
        {

        }

        // Delete books and refresh the grid
        internal static void DeleteBooks(DataGridView books_grd)
        {
            List<string> selectedISBNs = [];
            foreach (DataGridViewRow row in books_grd.SelectedRows)
            {
                selectedISBNs.Add(row.Cells["ISBN"].Value.ToString() ?? string.Empty);
            }

            Connection connection = new();
            foreach (string ISBN in selectedISBNs)
            {
                string query = $"DELETE FROM Books WHERE ISBN = {ISBN}";
                connection.InsertDelete(query);
            }

            ListBooks(books_grd);
        }



        // Select publishers and fill the grid
        internal static void ListPublisher(DataGridView grd)
        {
            Connection connection = new();
            string filePath = @"SqlQueries\PublishersSelect.sql";
            string query = File.ReadAllText(filePath);
            var result = connection.Select(query);
            FillGrid.Fill(grd, result);
        }

        // Select publishers and fill the dropdown menu overload
        internal static void ListPublisher(ComboBox cb)
        {
            Connection connection = new();
            string filePath = @"SqlQueries\PublishersSelect.sql";
            string query = File.ReadAllText(filePath);
            var result = connection.Select(query);
            foreach (var item in result)
            {
                cb.Items.Add(item[0].ToString() ?? string.Empty);
            }
        }

        // Select authors and fill the grid
        internal static void ListAuthors(DataGridView grd)
        {
            Connection connection = new();
            string filePath = @"SqlQueries\AuthorsSelect.sql";
            string query = File.ReadAllText(filePath);
            var result = connection.Select(query);
            FillGrid.Fill(grd, result);
        }
    }
}
