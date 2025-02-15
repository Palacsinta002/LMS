using Desktop_Application.Classes;

namespace Desktop_Application.Forms.Books
{
    public partial class ChooseAuthor : Form
    {
        private static List<string> selectedAuthors = [];
        public static List<string> SelectedAuthors
        {
            get { return selectedAuthors; }
        }

        public ChooseAuthor()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            DragWindow.Handle(this, header, title);
            BorderPaint.Handle(this);
            CloseThisWindow.Handle(this, close_btn);
            CloseThisWindow.Handle(this, cancel);

            HandleQueries.SelectFill(chooseAuthor_grd, "AuthorSelect");
        }

        private void Ok(object sender, EventArgs e)
        {
            selectedAuthors = [];
            foreach (DataGridViewRow row in chooseAuthor_grd.SelectedRows)
            {
                selectedAuthors.Add(row.Cells["Author"].Value.ToString() ?? string.Empty);
            }
            this.Close();
        }
    }
}
