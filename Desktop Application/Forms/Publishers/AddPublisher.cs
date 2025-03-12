using Desktop_Application.Classes;
using System.Text.RegularExpressions;

namespace Desktop_Application.Forms.Publishers;

public partial class AddPublisher : Form
{
    public AddPublisher()
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
            HandleQueries.InsertPublisher(textBox_publisher.Text);
            MessageBox.Show("Publisher added succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }

    private bool ValidateInput()
    {
        if (textBox_publisher.Text == string.Empty)
        {
            MessageBox.Show("Publisher is required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        else if (!Regex.IsMatch(textBox_publisher.Text, @"^[^""\\]+$"))
        {
            MessageBox.Show("Publisher is not in the correct format! Please check your special characters!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        else if (CheckPublisher(textBox_publisher.Text))
        {
            MessageBox.Show("Publisher already exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        return true;
    }

    private static bool CheckPublisher(string publisher)
    {
        var result = HandleQueries.Select("SelectPublisher");
        foreach (string[] item in result)
        {
            if (item[0] == publisher) return true;
        }
        return false;
    }
}