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

        private void MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void No(object sender, EventArgs e)
        {
            // https://stackoverflow.com/questions/13027681/creating-a-save-button-for-a-form-in-c-sharp
        }

        private void Yes(object sender, EventArgs e)
        {

        }
    }
}
