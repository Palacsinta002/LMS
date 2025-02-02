using Desktop_Application.Classes;

namespace Desktop_Application.Forms.Books
{
    public partial class ChooseCategory : Form
    {
        private static List<string> selectedCategories = [];
        public static List<string> SelectedCategories
        {
            get { return selectedCategories; }
            set { selectedCategories = value; }
        }

        public ChooseCategory()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            DragWindow.Handle(this, header, title);
            BorderPaint.Handle(this);
            CloseThisWindow.Handle(this, close_btn);
            CloseThisWindow.Handle(this, cancel);

            Connection connection = new();
            string filePath = @"SqlQueries\CategoriesSelect.sql";
            string query = File.ReadAllText(filePath);
            var result = connection.Select(query);

            chooseCategory_grd.Rows.Clear();
            foreach (var row in result)
            {
                chooseCategory_grd.Rows.Add(row[0]);
            }
        }

        private void Ok(object sender, EventArgs e)
        {
            selectedCategories = [];
            foreach (DataGridViewRow row in chooseCategory_grd.SelectedRows)
            {
                selectedCategories.Add(row.Cells["Category"].Value.ToString() ?? string.Empty);
            }
            this.Close();
        }
    }
}
