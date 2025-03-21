using Desktop_Application.Classes;
using System.Text.RegularExpressions;

namespace Desktop_Application.Forms.Users;

public partial class EditUser : Form
{
    private readonly DataGridView _users_grd;
    private string _oldUsername;
    private DateTime _dateOfBirth;

    public EditUser(DataGridView users_grd)
    {
        _users_grd = users_grd;
        InitializeComponent();
    }

    private void OnLoad(object sender, EventArgs e)
    {
        DragWindow.Handle(this, header, title);
        BorderPaint.Handle(this);
        CloseThisWindow.Handle(this, close_btn);
        CloseThisWindow.Handle(this, cancel);

        var selectedRow = _users_grd.SelectedRows[0].Cells;

        textBox_firstName.Text = selectedRow["users_firstName"].Value.ToString();
        textBox_lastName.Text = selectedRow["users_lastName"].Value.ToString();
        textBox_username.Text = selectedRow["users_username"].Value.ToString();
        dateOfBirth_datePicker.Text = selectedRow["users_dateOfBirth"].Value.ToString();
        textBox_address.Text = selectedRow["users_address"].Value.ToString();
        checkBox_verify.Checked = selectedRow["users_verified"].Value.ToString() == "Yes" ? true : false;

        _oldUsername = textBox_username.Text;
    }

    private void Save(object sender, EventArgs e)
    {
        if (ValidateInput())
        {
            bool verified = checkBox_verify.Checked;
            HandleQueries.UpdateUser(_users_grd, textBox_firstName.Text, textBox_lastName.Text, _dateOfBirth, textBox_username.Text, textBox_address.Text, verified);
            MessageBox.Show("User updated succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }

    // returns true if everything is correct
    private bool ValidateInput()
    {
        if (textBox_firstName.Text == string.Empty)
        {
            MessageBox.Show("First name is required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        else if (!Regex.IsMatch(textBox_firstName.Text, @"^[^""\\]+$"))
        {
            MessageBox.Show("First name is not in the correct format! Please check your special characters!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (textBox_lastName.Text == string.Empty)
        {
            MessageBox.Show("Last name is required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        else if (!Regex.IsMatch(textBox_lastName.Text, @"^[^""\\]+$"))
        {
            MessageBox.Show("Last name is not in the correct format! Please check your special characters!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (textBox_username.Text == string.Empty)
        {
            MessageBox.Show("Username is required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        else if (!Regex.IsMatch(textBox_username.Text, @"^[a-zA-Z][a-zA-Z0-9._]{2,19}$"))
        {
            MessageBox.Show("Username is not in the correct format! It must start with a letter and can only contain latin letters, numbers, underscores and dots.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        else if (CheckUsername(textBox_username.Text))
        {
            MessageBox.Show("Username already exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        int[] bDate = dateOfBirth_datePicker.Text.Split('/').Select(int.Parse).ToArray();
        _dateOfBirth = new(bDate[2], bDate[1], bDate[0]);

        if (_dateOfBirth > DateTime.Today)
        {
            MessageBox.Show("Date of birth cannot be later than today!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        else if (_dateOfBirth < DateTime.Now.AddYears(-130))
        {
            MessageBox.Show("Cannot enter date older than 130 years old!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (textBox_address.Text == string.Empty)
        {
            MessageBox.Show("Address is required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        else if (!Regex.IsMatch(textBox_address.Text, @"^[^""\\]+$"))
        {
            MessageBox.Show("Address is not in the correct format! Please check your special characters!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        return true;
    }

    private bool CheckUsername(string username)
    {
        if (username == _oldUsername) return false;
        List<string[]> result = HandleQueries.SelectFromFile("SelectUsername");
        foreach (string[] item in result)
        {
            if (item[0] == username) return true;
        }
        return false;
    }
}