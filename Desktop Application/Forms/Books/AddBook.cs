using Desktop_Application.Classes;

namespace Desktop_Application
{
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            DragWindow.Handle(this, header, title);
            BorderPaint.Handle(this);
            CloseThisWindow.Handle(this, close_btn);
            CloseThisWindow.Handle(this, cancel);
        }

        private void Save(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            // Check if author, category and publisher exists and then save data to database
        }
    }
}
