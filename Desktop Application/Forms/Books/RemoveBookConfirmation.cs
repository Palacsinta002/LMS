namespace Desktop_Application.Forms.Books
{
    public partial class RemoveBookConfirmation : Form
    {
        public RemoveBookConfirmation()
        {
            InitializeComponent();
        }

        private void CloseWindow(object sender, EventArgs e)
        {
            this.Close();
        }

        // Make the Login form moveable without title bar.
        private bool mouseDown;
        private Point lastLocation;

        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Header_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Header_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void RemoveBook_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.Black, new Rectangle(0, 0, Width - 1, Height - 1));
        }

        private void YesOrNo(object sender, EventArgs e)
        {

        }
    }
}
