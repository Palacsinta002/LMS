using Desktop_Application.Classes;

namespace Desktop_Application.Forms.Borrowings;

public partial class AddBorrowing : Form
{
    private DateTime _dueDate;

    public AddBorrowing()
    {
        InitializeComponent();
    }

    private void OnLoad(object sender, EventArgs e)
    {
        DragWindow.Handle(this, header, title);
        BorderPaint.Handle(this);
        CloseThisWindow.Handle(this, close_btn);
        CloseThisWindow.Handle(this, cancel);

        var result = HandleQueries.Select("SelectUsername");
        HandleGrids.Fill(dropDown_user, result);
    }

    private void Save(object sender, EventArgs e)
    {
        if (ValidateInput())
        {
            HandleQueries.InsertBorrowing(dropDown_user.Text, textBox_books.Text, DateTime.Today, _dueDate);
            MessageBox.Show("Book lent succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }

    // returns true if everything is correct
    private bool ValidateInput()
    {
        if (dropDown_user.Text == string.Empty)
        {
            MessageBox.Show("Username is required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

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
        List<string> selectedISBNs = textBox_books.Text.Split(", ").ToList();
        ChooseBooks chooseBooks = new(selectedISBNs);
        chooseBooks.ShowDialog();

        textBox_books.Text = string.Join(", ", ChooseBooks.SelectedISBNs);
    }
}