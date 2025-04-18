namespace Desktop_Application.Classes;

internal class DragWindow
{
    private readonly Form _form;

    private bool _mouseDown;
    private Point _lastLocation;

    public DragWindow(Form form, Panel panel, Label title)
    {
        _form = form;

        panel.MouseDown += OnPanelMouseDown;
        panel.MouseMove += OnPanelMouseMove;
        panel.MouseUp += OnPanelMouseUp;

        title.MouseDown += OnPanelMouseDown;
        title.MouseMove += OnPanelMouseMove;
        title.MouseUp += OnPanelMouseUp;
    }

    public static void Handle(Form form, Panel panel, Label title)
    {
        _ = new DragWindow(form, panel, title);
    }

    void OnPanelMouseDown(object sender, MouseEventArgs e)
    {
        _mouseDown = true;
        _lastLocation = e.Location;
    }

    void OnPanelMouseMove(object sender, MouseEventArgs e)
    {
        if (!_mouseDown) return;
        Point offset = new(e.X - _lastLocation.X, e.Y - _lastLocation.Y);
        _form.Location = new(_form.Location.X + offset.X, _form.Location.Y + offset.Y);
    }

    void OnPanelMouseUp(object sender, MouseEventArgs e)
    {
        _mouseDown = false;
    }
}