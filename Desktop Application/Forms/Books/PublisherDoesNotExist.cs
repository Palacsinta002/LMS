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
        }

        private void YesOrNo(object sender, EventArgs e)
        {

        }
    }
}
