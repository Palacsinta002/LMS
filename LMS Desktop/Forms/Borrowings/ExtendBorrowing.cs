using Desktop_Application.Classes;

namespace Desktop_Application.Forms.Borrowings;

public partial class ExtendBorrowing : Form
{
    private readonly DataGridView _borrowings_grd;

    public ExtendBorrowing(DataGridView borrowings_grd)
    {
        _borrowings_grd = borrowings_grd;
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
        var selectedRow = _borrowings_grd.SelectedRows[0].Cells;

        string isbn = selectedRow["borrowings_isbn"].Value.ToString() ?? string.Empty;

        DateTime dueDate = DateTime.Parse(selectedRow["borrowings_dueDate"].Value.ToString() ?? string.Empty);
        int extendBy = int.Parse(comboBox_extendBy.Text.Split(" ")[0]);
        DateTime newDueDate = dueDate.AddMonths(extendBy);
        string newDueDateString = $"{newDueDate.Year}-{newDueDate.Month}-{newDueDate.Day}";

        HandleQueries.UpdateBorrowing(isbn, newDueDateString);
        MessageBox.Show("Borrowing extended succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        this.Close();
    }
}