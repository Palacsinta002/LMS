using Desktop_Application.Classes;

namespace Desktop_Application.Forms.Reservations;

public partial class ExtendReservation : Form
{
    private readonly DataGridView _reservations_grd;

    public ExtendReservation(DataGridView reservations_grd)
    {
        _reservations_grd = reservations_grd;
        InitializeComponent();
    }

    private void OnLoad(object sender, EventArgs e)
    {
        HandleFonts.Set(this);
        DragWindow.Handle(this, header, title);
        BorderPaint.Handle(this);
        CloseThisWindow.Handle(this, close_btn);
        CloseThisWindow.Handle(this, cancel);
        HandleKeys.Handle(this, Keys.Enter, Save);
        HandleKeys.Handle(this, Keys.Escape, (s, e) => this.Close());

        comboBox_extendBy.SelectedIndex = 0;
    }

    private void Save(object sender, EventArgs e)
    {
        var selectedRow = _reservations_grd.SelectedRows[0].Cells;
        DateTime endDate = DateTime.Parse(selectedRow["reservations_endDate"].Value.ToString() ?? string.Empty);
        string isbn = selectedRow["reservations_isbn"].Value.ToString() ?? string.Empty;

        int extendBy = int.Parse(comboBox_extendBy.Text.Split(" ")[0]);
        DateTime extendedDate = endDate.AddMonths(extendBy);

        HandleQueries.UpdateReservation(isbn, extendedDate);
        MessageBox.Show("Reservations extended succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        this.Close();
    }
}