using Desktop_Application.Classes;

namespace Desktop_Application.Forms.Borrowings;

public partial class AddBorrowing : Form
{
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
        HandleKeys.Handle(this, Keys.Enter, Save);
        HandleKeys.Handle(this, Keys.Escape, (s, e) => this.Close());

        var result = HandleQueries.SelectFromFile("SelectUsername");
        HandleGrids.Fill(dropDown_user, result);

        comboBox_extendBy.SelectedIndex = 0;
    }

    private void Save(object sender, EventArgs e)
    {
        if (ValidateInput())
        {
            int dueTime = int.Parse(comboBox_extendBy.Text.Split(" ")[0]);
            DateTime dueDate = DateTime.Today.AddMonths(dueTime);

            HandleQueries.InsertBorrowing(dropDown_user.Text, textBox_books.Text, DateTime.Today, dueDate);
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