namespace Desktop_Application.Classes
{
    internal class FillGrid
    {
        public static void Fill(DataGridView grid, List<List<string>> data)
        {
            // Cleans the grid
            grid.Rows.Clear();

            for (int rowIndex = 0; rowIndex < data[0].Count; rowIndex++)
            {
                // Wrappes a row into an object 
                object[] row = new object[data.Count];
                for(int colIndex = 0; colIndex < data.Count; colIndex++)
                {
                    row[colIndex] = data[colIndex][rowIndex];
                    
                }
                grid.Rows.Add(row);
            }
        }
    }
}
