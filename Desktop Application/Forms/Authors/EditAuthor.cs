using Desktop_Application.Classes;
using System.Text.RegularExpressions;

namespace Desktop_Application.Forms.Authors;

public partial class EditAuthor : Form
{
    private readonly DataGridView _author_grd;
    private string _oldAuthor;

    public EditAuthor(DataGridView author_grd)
    {
        _author_grd = author_grd;
        _oldAuthor = string.Empty;
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

        var selectedRow = _author_grd.SelectedRows[0].Cells;

        textBox_author.Text = selectedRow["authors_author"].Value.ToString();
        _oldAuthor = selectedRow["authors_author"].Value.ToString() ?? string.Empty;
    }

    private void Save(object sender, EventArgs e)
    {
        if (ValidateInput())
        {
            HandleQueries.UpdateAuthor(_oldAuthor, textBox_author.Text);
            MessageBox.Show("Author updated succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }

    private bool ValidateInput()
    {
        if (textBox_author.Text == string.Empty)
        {
            MessageBox.Show("Author is required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        else if (!Regex.IsMatch(textBox_author.Text, @"^[^""\\]+$"))
        {
            MessageBox.Show("Author is not in the correct format! Please check your special characters!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        else if (CheckAuthor(textBox_author.Text))
        {
            MessageBox.Show("Author already exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        return true;
    }

    private static bool CheckAuthor(string author)
    {
        var result = HandleQueries.SelectFromFile("SelectAuthor");
        foreach (string[] item in result)
        {
            if (item[0] == author) return true;
        }
        return false;
    }
}