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
        HandleFonts.Set(this);
        DragWindow.Handle(this, header, title);
        BorderPaint.Handle(this);
        CloseWindow.Handle(this, close_btn);
        CloseWindow.Handle(this, button_ok);
        HandleKeys.Handle(this, [Keys.Enter, Keys.Escape], (s, e) => this.Close());
    }
}