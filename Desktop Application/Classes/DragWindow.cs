
namespace Desktop_Application.Classes
{
    internal class DragWindow
    {
        Form _form;
        Panel _panel;
        Label _title;

        Point _mouseDown;

        public DragWindow(Form form, Panel panel, Label title)
        {
            _form = form;
            _panel = panel;
            _title = title;

            panel.MouseDown += OnPanelMouseDown;
            panel.MouseMove += OnPanelMouseMove;
            panel.MouseUp += OnPanelMouseUp;

            title.MouseDown += OnPanelMouseDown;
            title.MouseMove += OnPanelMouseMove;
            title.MouseUp += OnPanelMouseUp;
        }

        public static void Handle(Form form, Panel panel, Label title)
        {
            new DragWindow(form, panel, title);
        }

        void OnPanelMouseDown(object sender, MouseEventArgs e)
        {
            _mouseDown = e.Location;
        }

        void OnPanelMouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDown == default) return;
            Point offset = new(e.X - _mouseDown.X, e.Y - _mouseDown.Y);
            _form.Location = new(_form.Location.X + offset.X, _form.Location.Y + offset.Y);
        }

        void OnPanelMouseUp(object sender, MouseEventArgs e)
        {
            _mouseDown = default;
        }
    }
}
