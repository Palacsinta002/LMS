namespace Desktop_Application
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        // The X int the upper right corner closes the form.
        private void CloseWindow(object sender, EventArgs e)
        {
            this.Close();
        }

        // WIP For now the Login button opens another form without any checking.
        private void LoginCheck(object sender, EventArgs e)
        {
            adminPanel adminPanel = new adminPanel();
            this.Hide();
            adminPanel.ShowDialog();
            this.Close();
        }

        // Make the Login form moveable without title bar.
        private bool mouseDown;
        private Point lastLocation;

        // If the mouse button is down, it gets the location of the cursor.
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        // It calculates the new position of the window, based on the mouse movement.
        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        // When realising the mouse button, the form no longer takes the mouse's position.
        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
