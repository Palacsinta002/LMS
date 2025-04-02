using Desktop_Application.Classes;

namespace Desktop_Application.Forms.Reservations;

public partial class LendReservation : Form
{
    private DataGridView _reservations_grd;

    public LendReservation(DataGridView reservations_grd)
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

        comboBox_dueDate.SelectedIndex = 0;
    }

    private void Save(object sender, EventArgs e)
    {
        LendReservationConfirmation confirmation = new();
        if (confirmation.ShowDialog() != DialogResult.OK) return;

        var selectedRow = _reservations_grd.SelectedRows[0].Cells;

        string username = selectedRow["reservations_username"].Value.ToString() ?? string.Empty;

        string isbn = selectedRow["reservations_isbn"].Value.ToString() ?? string.Empty;

        DateTime borrowDate = DateTime.Today;
        string borrowDateString = $"{borrowDate.Year}-{borrowDate.Month}-{borrowDate.Day}";

        int dueTime = int.Parse(comboBox_dueDate.Text.Split(" ")[0]);
        DateTime dueDate = DateTime.Today.AddMonths(dueTime);
        string dueDateString = $"{dueDate.Year}-{dueDate.Month}-{dueDate.Day}";

        HandleQueries.InsertBorrowing(username, [isbn], borrowDateString, dueDateString);
        HandleQueries.Delete([isbn], "Reservations", "ISBN");
        MessageBox.Show("Reservation removed and book lent succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        this.Close();
    }
}