
namespace Desktop_Application.Classes
{
    internal class DragWindow
    {
        Form _form;
        Panel _panel;

        Point _mouseDown;

        public DragWindow(Form form, Panel panel)
        {
            _form = form;
            _panel = panel;

            panel.MouseDown += OnPanelMouseDown;
            panel.MouseMove += OnPanelMouseMove;
            panel.MouseUp += OnPanelMouseUp;
        }

        public static void Handle(Form form, Panel panel)
        {
            new DragWindow(form, panel);
        }

        void OnPanelMouseDown(object sender, MouseEventArgs e)
        {
            _mouseDown = e.Location;
        }

        void OnPanelMouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDown == default) return;
            Point offset = new(e.X - _mouseDown.X, e.Y - _mouseDown.Y);
            _mouseDown = e.Location;
            _form.Location = new(_form.Location.X + offset.X, _form.Location.Y + offset.Y);
            _mouseDown = e.Location;
        }

        void OnPanelMouseUp(object sender, MouseEventArgs e)
        {
            _mouseDown = default;
        }

        /*

        // Makes the Login form moveable without title bar.
        private bool mouseDown;
        private Point lastLocation;

        // If the mouse button is down, it gets the location of the cursor.
        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        // It calculates the new position of the window, based on the mouse movement.
        private void Header_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        // When realising the mouse button, the form no longer takes the mouse's position.
        private void Header_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        */
    }
}
