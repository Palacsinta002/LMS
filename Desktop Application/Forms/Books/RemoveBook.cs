using Desktop_Application.Classes;

namespace Desktop_Application.Forms.Books
{
    public partial class RemoveBook : Form
    {
        public RemoveBook()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            DragWindow.Handle(this, header, title);
            BorderPaint.Handle(this);
            CloseThisWindow.Handle(this, close_btn);
            CloseThisWindow.Handle(this, no);
        }

        private void Yes(object sender, EventArgs e)
        {
            HandleQueries.Delete(adminPanel.books_grd, "Books", "ISBN");
            MessageBox.Show("Book removed succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            HandleQueries.SelectFill(adminPanel.books_grd, "BookSelect");
            this.Close();
        }
    }
}
