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
        }

        private void Yes(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void No(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
