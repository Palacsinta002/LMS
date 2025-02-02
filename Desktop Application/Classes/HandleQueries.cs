using MySqlX.XDevAPI.Common;

namespace Desktop_Application.Classes
{
    internal class HandleQueries
    {
        // Requires a grid and an object array list and fills the grid with the data
        private static void FillGrid(DataGridView grd, List<object[]> data)
        {
            // Clears the grid
            grd.Rows.Clear();

            foreach (var row in data)
            {
                grd.Rows.Add(row.ToArray());
            }
        }

        // Takes a grid and fills it with the Select result of the given filename
        internal static void SelectFill(DataGridView grd, string fileName)
        {
            Connection connection = new();
            string filePath = @"SqlQueries\" + fileName + ".sql";
            string query = File.ReadAllText(filePath);
            var result = connection.Select(query);
            FillGrid(grd, result);
        }

        // OVERLOAD Takes a combobox and fills it with the Select result of the given filename
        internal static void SelectFill(ComboBox cb, string fileName)
        {
            Connection connection = new();
            string filePath = @"SqlQueries\" + fileName + ".sql";
            string query = File.ReadAllText(filePath);
            var result = connection.Select(query);
            foreach (var item in result)
            {
                cb.Items.Add(item[0].ToString() ?? string.Empty);
            }
        }



        // Insert functions
        // Insert book what is given by the user
        internal static void InsertBook()
        {

        }



        // Delete functions
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
                connection.Delete(query);
            }

            SelectFill(books_grd, "BookSelect");
        }
    }
}
