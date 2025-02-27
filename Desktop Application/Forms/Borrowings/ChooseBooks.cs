using Desktop_Application.Classes;

namespace Desktop_Application.Forms.Borrowings
{
    public partial class ChooseBooks : Form
    {
        private static List<string> selectedBooks = [];
        public static List<string> SelectedBooks
        {
            get { return selectedBooks; }
        }

        public ChooseBooks()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            DragWindow.Handle(this, header, title);
            BorderPaint.Handle(this);
            CloseThisWindow.Handle(this, close_btn);
            CloseThisWindow.Handle(this, cancel);

            var result = HandleQueries.Select("SelectBookForBorrowings");
            if (selectedBooks.Count > 0)
            {
                foreach (var item in result)
                {
                    if (selectedBooks.Contains(item[3]))
                    {
                        selectedBooks_grd.Rows.Add(item);
                    }
                    else
                    {
                        allBooks_grd.Rows.Add(item);
                    }
                }
            }
            else
            {
                HandleGrids.Fill(allBooks_grd, result);
            }
        }

        private void Ok(object sender, EventArgs e)
        {
            selectedBooks = [];
            foreach (DataGridViewRow row in selectedBooks_grd.Rows)
            {
                selectedBooks.Add(row.Cells["selectedBooks_isbn"].Value.ToString() ?? string.Empty);
            }
            this.Close();
        }

        private void MoveRight(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in allBooks_grd.SelectedRows)
            {
                allBooks_grd.Rows.Remove(row);
                selectedBooks_grd.Rows.Add(row);
            }
        }

        private void MoveLeft(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in selectedBooks_grd.SelectedRows)
            {
                selectedBooks_grd.Rows.Remove(row);
                allBooks_grd.Rows.Add(row);
            }
        }
    }
}
