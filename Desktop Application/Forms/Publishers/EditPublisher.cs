using Desktop_Application.Classes;
using System.Text.RegularExpressions;

namespace Desktop_Application.Forms.Publishers;

public partial class EditPublisher : Form
{
    private readonly DataGridView _publishers_grd;
    private string _oldPublisher;

    public EditPublisher(DataGridView publishers_grd)
    {
        _publishers_grd = publishers_grd;
        _oldPublisher = string.Empty;
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

        var selectedRow = _publishers_grd.SelectedRows[0].Cells;

        textBox_publisher.Text = selectedRow["publishers_publisher"].Value.ToString();
        _oldPublisher = selectedRow["publishers_publisher"].Value.ToString() ?? string.Empty;
    }

    private void Save(object sender, EventArgs e)
    {
        if (ValidateInput())
        {
            HandleQueries.UpdatePublisher(_oldPublisher, textBox_publisher.Text);
            MessageBox.Show("Publisher updated succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        var result = HandleQueries.SelectFromFile("SelectPublisher");
        foreach (string[] item in result)
        {
            if (item[0] == publisher) return true;
        }
        return false;
    }
}