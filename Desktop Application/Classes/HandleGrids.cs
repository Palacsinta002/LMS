namespace Desktop_Application.Classes
{
    internal class HandleGrids
    {
        // Requires a grid and an object array list and fills the grid with the data
        internal static void Fill(DataGridView grd, List<string[]> data)
        {
            // Clears the grid
            grd.Rows.Clear();

            foreach (var row in data)
            {
                grd.Rows.Add(row);
            }
        }

        // OVERLOAD Requires a combobox and an object array list and fills the combobox with the data
        internal static void Fill(ComboBox cb, List<string[]> data)
        {
            foreach (var item in data)
            {
                cb.Items.Add(item[0].ToString() ?? string.Empty);
            }
        }

        internal static void SearchGrid(DataGridView grd, string filterText, string[] cols)
        {
            filterText = filterText.Trim().ToLower();

            foreach (DataGridViewRow row in grd.Rows)
            {
                for(int i = 0; i < cols.Length; i++)
                {
                    if (row.Cells[cols[i]].Value.ToString().ToLower().Contains(filterText))
                    {
                        row.Visible = true;
                        break;
                    }
                    else row.Visible = false;
                }
            }
        }
    }
}
