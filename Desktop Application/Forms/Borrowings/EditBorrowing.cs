using Desktop_Application.Classes;

namespace Desktop_Application.Forms.Borrowings;

public partial class EditBorrowing : Form
{
    private readonly DataGridView _borrowings_grd;

    private DateTime _dueDate;

    public EditBorrowing(DataGridView borrowings_grd)
    {
        _borrowings_grd = borrowings_grd;
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

        var result = HandleQueries.SelectFromFile("SelectUsername");
        HandleGrids.Fill(dropDown_user, result);

        var selectedRow = _borrowings_grd.SelectedRows[0].Cells;

        dropDown_user.Text = selectedRow["borrowings_username"].Value.ToString();
        textBox_books.Text = selectedRow["borrowings_isbn"].Value.ToString();
        dueDate_datePicker.Text = selectedRow["borrowings_dueDate"].Value.ToString();
    }

    private void Save(object sender, EventArgs e)
    {
        if (ValidateInput())
        {
            HandleQueries.UpdateBorrowing(dropDown_user.Text, textBox_books.Text, _dueDate);
            MessageBox.Show("Borrowing updated succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }

    private bool ValidateInput()
    {
        if (textBox_books.Text == string.Empty)
        {
            MessageBox.Show("Books are required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        int[] dDate = dueDate_datePicker.Text.Split('/').Select(int.Parse).ToArray();
        _dueDate = new(dDate[2], dDate[1], dDate[0]);

        if (_dueDate <= DateTime.Today)
        {
            MessageBox.Show("Due time must be at least 1 day!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        return true;
    }

    private void OpenChooseBooks(object sender, EventArgs e)
    {
        List<string> selectedBooks = textBox_books.Text.Split(", ").ToList();
        ChooseBooks chooseBooks = new(selectedBooks);
        chooseBooks.ShowDialog();

        textBox_books.Text = string.Join(", ", ChooseBooks.SelectedISBNs);
    }
}