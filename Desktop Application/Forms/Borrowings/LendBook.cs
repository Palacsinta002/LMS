using Desktop_Application.Classes;

namespace Desktop_Application.Forms.Borrowings;

public partial class LendBook : Form
{
    private DateTime _borrowDate;
    private DateTime _dueDate;

    public LendBook()
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

        int[] bDate = borrowDate_datePicker.Text.Split('/').Select(int.Parse).ToArray();
        _borrowDate = new(bDate[2], bDate[1], bDate[0]);

        int[] dDate = dueDate_datePicker.Text.Split('/').Select(int.Parse).ToArray();
        _dueDate = new(dDate[2], dDate[1], dDate[0]);
    }

    private void Save(object sender, EventArgs e)
    {
        if (ValidateInput())
        {
            HandleQueries.InsertBorrowing(dropDown_user.Text, textBox_books.Text, _borrowDate, _dueDate);
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

        if (_borrowDate > _dueDate)
        {
            MessageBox.Show("Due date cannot be earlier than borrow date!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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