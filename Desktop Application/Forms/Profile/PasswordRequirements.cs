using Desktop_Application.Classes;

namespace Desktop_Application.Forms.Profile;

public partial class PasswordRequirements : Form
{
    public PasswordRequirements()
    {
        InitializeComponent();
    }

    private void OnLoad(object sender, EventArgs e)
    {
        DragWindow.Handle(this, header, title);
        BorderPaint.Handle(this);
        CloseThisWindow.Handle(this, close_btn);
        CloseThisWindow.Handle(this, button_ok);
        HandleKeys.Handle(this, Keys.Enter, (s, e) => this.Close());
        HandleKeys.Handle(this, Keys.Escape, (s, e) => this.Close());
    }
}