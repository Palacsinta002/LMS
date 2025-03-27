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
        DateTime currentDate = DateTime.Parse(selectedRow["reservations_endDate"].Value.ToString());
        int extendBy = int.Parse(comboBox_extendBy.Text.Split(" ")[0]);
        DateTime extendedDate = currentDate.AddMonths(extendBy);

        HandleQueries.UpdateReservation(selectedRow["reservations_isbn"].Value.ToString(), extendedDate);
        MessageBox.Show("Reservations extended succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        this.Close();
    }
}