using Desktop_Application.Classes;

namespace Desktop_Application.Forms.Reservations;

public partial class LendReservationConfirmation : Form
{
    public LendReservationConfirmation()
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
        HandleKeys.Handle(this, Keys.Enter, Ok);
        HandleKeys.Handle(this, Keys.Escape, (s, e) => this.Close());
    }

    private void Ok(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.OK;
        this.Close();
    }
}