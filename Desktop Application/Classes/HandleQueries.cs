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
        internal static void Insert()
        {
            Connection connection = new();

        }



        // Delete functions
        // Delete books and refresh the grid
        internal static void Delete(DataGridView grd, string table, string col)
        {
            Connection connection = new();
            foreach (DataGridViewRow row in grd.SelectedRows)
            {
                string item = row.Cells[col].Value.ToString() ?? string.Empty;
                string query = $"DELETE FROM {table} WHERE {col} = {item}";
                connection.Delete(query);
            }
        }
    }
}
