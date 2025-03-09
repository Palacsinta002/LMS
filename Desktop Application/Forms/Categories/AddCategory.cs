using Desktop_Application.Classes;
using System.Text.RegularExpressions;

namespace Desktop_Application.Forms.Categories;

public partial class AddCategory : Form
{
    public AddCategory()
    {
        InitializeComponent();
    }

    private void OnLoad(object sender, EventArgs e)
    {
        DragWindow.Handle(this, header, title);
        BorderPaint.Handle(this);
        CloseThisWindow.Handle(this, close_btn);
        CloseThisWindow.Handle(this, cancel);
    }

    private void Save(object sender, EventArgs e)
    {
        if (ValidateInput())
        {
            HandleQueries.InsertCategory(textBox_category.Text);
            MessageBox.Show("Category added succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }

    private bool ValidateInput()
    {
        if (textBox_category.Text == string.Empty)
        {
            MessageBox.Show("Category is required!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }
        else if (!Regex.IsMatch(textBox_category.Text, @"^[^""\\]+$"))
        {
            MessageBox.Show("Category is not in the correct format! Please check your special characters!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }
        return true;
    }
}