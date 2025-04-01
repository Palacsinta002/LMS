using Desktop_Application.Classes;

namespace Desktop_Application.Forms.Reservations;

public partial class RemoveReservations : Form
{
    private readonly List<string> _selectedReservations;

    public RemoveReservations(List<string> selectedReservations)
    {
        _selectedReservations = selectedReservations;
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
        HandleQueries.Delete(_selectedReservations, "Reservations", "ISBN");
        MessageBox.Show("Reservation cancelled succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        this.Close();
    }
}