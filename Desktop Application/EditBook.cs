namespace Desktop_Application
{
    public partial class EditBook : Form
    {
        public EditBook()
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

        // If the mouse button is down, it gets the location of the cursor.
        private void EditBook_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        // It calculates the new position of the window, based on the mouse movement.
        private void EditBook_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        // When realising the mouse button, the form no longer takes the mouse's position.
        private void EditBook_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
