using Desktop_Application.Classes;

namespace Desktop_Application.Forms.Reservations;

public partial class RemoveReservations : Form
{
    private readonly DataGridView _reservations_grd;

    public RemoveReservations(DataGridView reservations_grd)
    {
        _reservations_grd = reservations_grd;
        InitializeComponent();
    }

    private void OnLoad(object sender, EventArgs e)
    {
        HandleFonts.Set(this);
        DragWindow.Handle(this, header, title);
        BorderPaint.Handle(this);
        CloseWindow.Handle(this, close_btn);
        CloseWindow.Handle(this, no);
        HandleKeys.Handle(this, Keys.Enter, Remove);
        HandleKeys.Handle(this, Keys.Escape, (s, e) => this.Close());
    }

    private void Remove(object sender, EventArgs e)
    {
        HandleQueries.Delete(_reservations_grd, "Reservations", "reservations_isbn", "ISBN");
        MessageBox.Show("Reservation cancelled succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        this.Close();
    }
}