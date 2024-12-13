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
        }

        private void Border_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.Black, new Rectangle(0, 0, Width - 1, Height - 1));
        }

        private void CloseWindow(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Cancel(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
