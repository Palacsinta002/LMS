namespace Desktop_Application.Classes
{
    internal class FillGrid
    {
        public static void Fill(DataGridView grid, List<object[]> data)
        {
            // Cleans the grid
            grid.Rows.Clear();

            foreach (var row in data)
            {
                grid.Rows.Add(row.ToArray());
            }
        }
    }
}
