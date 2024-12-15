using Desktop_Application.Classes;

namespace Desktop_Application.Forms.Books
{
    public partial class PublisherDoesNotExist : Form
    {
        public PublisherDoesNotExist()
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

        private void AddPublisher(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            // Add the given publisher to the database
        }
    }
}
