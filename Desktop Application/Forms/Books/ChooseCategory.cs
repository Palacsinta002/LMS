using Desktop_Application.Classes;

namespace Desktop_Application.Forms.Books
{
    public partial class ChooseCategory : Form
    {
        private static List<string> selectedCategories = [];
        public static List<string> SelectedCategories
        {
            get { return selectedCategories; }
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

            HandleQueries.SelectFill(chooseCategory_grd, "CategorySelect");
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
