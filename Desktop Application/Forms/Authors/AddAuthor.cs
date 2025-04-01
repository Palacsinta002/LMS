using System.Text.RegularExpressions;
using Desktop_Application.Classes;

namespace Desktop_Application.Forms.Authors;

public partial class AddAuthor : Form
{
    public AddAuthor()
    {
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
    }

    private void Save(object sender, EventArgs e)
    {
        if (ValidateInput())
        {
            HandleQueries.InsertAuthor(textBox_author.Text);
            MessageBox.Show("Author added succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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