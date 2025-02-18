using Desktop_Application.Classes;

namespace Desktop_Application.Forms.Borrowings
{
    public partial class AddBorrowing : Form
    {
        private readonly DataGridView _books_grd;

        public AddBorrowing(DataGridView books_grd)
        {
            _books_grd = books_grd;
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

        }
    }
}
