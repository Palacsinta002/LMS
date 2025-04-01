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
        CloseWindow.Handle(this, close_btn);
        CloseWindow.Handle(this, cancel);
        HandleKeys.Handle(this, Keys.Enter, Save);
        HandleKeys.Handle(this, Keys.Escape, (s, e) => this.Close());

        comboBox_extendBy.SelectedIndex = 0;
    }

    private void Save(object sender, EventArgs e)
    {
        var selectedRow = _reservations_grd.SelectedRows[0].Cells;

        string isbn = selectedRow["reservations_isbn"].Value.ToString() ?? string.Empty;

        DateTime endDate = (DateTime)selectedRow["reservations_endDate"].Value;
        int extendBy = int.Parse(comboBox_extendBy.Text.Split(" ")[0]);
        DateTime extendedDate = endDate.AddMonths(extendBy);
        string endDateString = $"{extendedDate.Year}-{extendedDate.Month}-{extendedDate.Day}";

        HandleQueries.UpdateReservation(isbn, endDateString);
        MessageBox.Show("Reservations extended succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        this.Close();
    }
}