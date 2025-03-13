using System.Text.RegularExpressions;
using Desktop_Application.Classes;
using Desktop_Application.Forms.Borrowings;

namespace Desktop_Application.Forms.Books;

public partial class EditBook : Form
{
    private readonly DataGridView _books_grd;

    public EditBook(DataGridView books_grd)
    {
        _books_grd = books_grd;
        InitializeComponent();
    }

    private void OnLoad(object sender, EventArgs e)
    {
        DragWindow.Handle(this, header, title);
        BorderPaint.Handle(this);
        CloseThisWindow.Handle(this, close_btn);
        CloseThisWindow.Handle(this, cancel);

        var result = HandleQueries.Select("SelectPublisher");
        HandleGrids.Fill(dropDown_publisher, result);

        var selectedRow = _books_grd.SelectedRows[0].Cells;

        textBox_title.Text = selectedRow["books_title"].Value.ToString();
        textBox_pubYear.Text = selectedRow["books_publicationYear"].Value.ToString();
        textBox_author.Text = selectedRow["books_author"].Value.ToString();
        textBox_category.Text = selectedRow["books_category"].Value.ToString();
        dropDown_publisher.Text = selectedRow["books_publisher"].Value.ToString();
        textBox_isbn.Text = selectedRow["books_isbn"].Value.ToString();
    }

    private void Save(object sender, EventArgs e)
    {
        if (ValidateInput())
        {
            HandleQueries.UpdateBook(_books_grd, textBox_isbn.Text, dropDown_publisher.Text, textBox_title.Text, textBox_pubYear.Text, textBox_author.Text, textBox_category.Text);
            MessageBox.Show("Book updated succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }

    // returns true if everything is correct
    private bool ValidateInput()
    {
        if (textBox_title.Text == string.Empty)
        {
            MessageBox.Show("Title is required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        else if (!Regex.IsMatch(textBox_title.Text, @"^[^""\\]+$"))
        {
            MessageBox.Show("Title is not in the correct format! Please check your special characters!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (!Regex.IsMatch(textBox_pubYear.Text, @"^[0-9]{4}$"))
        {
            MessageBox.Show("Publication year must be a 4 digit number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (textBox_author.Text == string.Empty)
        {
            MessageBox.Show("You must choose at least one author!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (textBox_category.Text == string.Empty)
        {
            MessageBox.Show("You must choose at least one vategory!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (dropDown_publisher.Text == string.Empty)
        {
            MessageBox.Show("You must choose a publisher from the dropdown menu!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (!Regex.IsMatch(textBox_isbn.Text, @"^[0-9]{13}$"))
        {
            MessageBox.Show("ISBN number must be a 13 digit number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        return true;
    }

    private void OpenChooseAuthor(object sender, EventArgs e)
    {
        List<string> selectedAuthors = textBox_author.Text.Split(", ").ToList();
        ChooseAuthor chooseAuthor = new(selectedAuthors);
        chooseAuthor.ShowDialog();

        textBox_author.Text = string.Join(", ", ChooseAuthor.SelectedAuthors);
    }

    private void OpenChooseCategory(object sender, EventArgs e)
    {
        ChooseCategory chooseCategory = new();
        chooseCategory.ShowDialog();

        textBox_category.Text = string.Join(", ", ChooseCategory.SelectedCategories);
    }
}