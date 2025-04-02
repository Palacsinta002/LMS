using Desktop_Application.Classes;

namespace Desktop_Application.Forms.Profile;

public partial class SaveConfirmation : Form
{
    public SaveConfirmation()
    {
        InitializeComponent();
    }

    private void OnLoad(object sender, EventArgs e)
    {
        HandleFonts.Set(this);
        DragWindow.Handle(this, header, title);
        BorderPaint.Handle(this);
        CloseWindow.Handle(this, close_btn);
        CloseWindow.Handle(this, no);
        HandleKeys.Handle(this, Keys.Enter, Yes);
        HandleKeys.Handle(this, Keys.Escape, (s, e) => this.Close());
    }

    private void Yes(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.OK;
        this.Close();
    }
}