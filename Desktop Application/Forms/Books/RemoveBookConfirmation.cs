using Desktop_Application.Classes;

namespace Desktop_Application.Forms.Books
{
    public partial class RemoveBookConfirmation : Form
    {
        public RemoveBookConfirmation()
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
            HandleQueries.DeleteBooks(adminPanel.books_grd);
            this.DialogResult = DialogResult.OK;
        }
    }
}
