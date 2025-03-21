using Desktop_Application.Classes;
using System.Text.RegularExpressions;

namespace Desktop_Application.Forms.Categories;

public partial class EditCategory : Form
{
    private readonly DataGridView _category_grd;

    public EditCategory(DataGridView category_grd)
    {
        _category_grd = category_grd;
        InitializeComponent();
    }

    private void OnLoad(object sender, EventArgs e)
    {
        DragWindow.Handle(this, header, title);
        BorderPaint.Handle(this);
        CloseThisWindow.Handle(this, close_btn);
        CloseThisWindow.Handle(this, cancel);

        var selectedRow = _category_grd.SelectedRows[0].Cells;

        textBox_category.Text = selectedRow["categories_category"].Value.ToString();
    }

    private void Save(object sender, EventArgs e)
    {
        if (ValidateInput())
        {
            HandleQueries.UpdateCategory(_category_grd, textBox_category.Text);
            MessageBox.Show("Category updated succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }

    private bool ValidateInput()
    {
        if (textBox_category.Text == string.Empty)
        {
            MessageBox.Show("Category is required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        else if (!Regex.IsMatch(textBox_category.Text, @"^[^""\\]+$"))
        {
            MessageBox.Show("Category is not in the correct format! Please check your special characters!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }
        else if (CheckCategory(textBox_category.Text))
        {
            MessageBox.Show("Category already exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        return true;
    }

    private static bool CheckCategory(string category)
    {
        var result = HandleQueries.SelectFromFile("SelectCategory");
        foreach (string[] item in result)
        {
            if (item[0] == category) return true;
        }
        return false;
    }
}