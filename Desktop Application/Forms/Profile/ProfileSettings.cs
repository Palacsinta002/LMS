using Desktop_Application.Classes;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Desktop_Application.Forms.Profile;

public partial class ProfileSettings : Form
{
    internal string Username { get; private set; }
    private DateTime _dateOfBirth;
    private string _password;
    private string _newPassword;

    public ProfileSettings(string username)
    {
        Username = username;
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
        this.KeyPreview = true;

        string[] userData = HandleQueries.SelectFromString(
            $"SELECT FirstName, LastName, Username, " +
            $"DATE_FORMAT(Users.DateOfBirth, \"%d/%m/%Y\"), Email, Address, Password " +
            $"FROM Users WHERE Username = \"{Username}\"")[0];

        Username = userData[2];
        _password = userData[6];
        _newPassword = userData[6];

        textBox_firstName.Text = userData[0];
        textBox_lastName.Text = userData[1];
        textBox_username.Text = userData[2];
        dateOfBirth_datePicker.Value = DateTime.ParseExact(userData[3], "dd/MM/yyyy", CultureInfo.InvariantCulture);
        textBox_email.Text = userData[4];
        textBox_address.Text = userData[5];
    }

    private void Save(object sender, EventArgs e)
    {
        if (ValidateInput())
        {
            SaveConfirmation saveConfirmation = new();
            saveConfirmation.ShowDialog();
            if (saveConfirmation.DialogResult != DialogResult.OK) return;

            HandleQueries.UpdateProfile(Username, textBox_firstName.Text, textBox_lastName.Text, textBox_username.Text, _dateOfBirth, textBox_email.Text, textBox_address.Text, _newPassword);
            MessageBox.Show("Profile updated succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Username = textBox_username.Text;
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

        if (textBox_email.Text == string.Empty)
        {
            MessageBox.Show("Email is required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        else if (!Regex.IsMatch(textBox_email.Text, @"^[^""\\]+$"))
        {
            MessageBox.Show("Email is not in the correct format! Please check your special characters!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        else if (!Regex.IsMatch(textBox_email.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
        {
            MessageBox.Show("Email is not in the correct format!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        if (username == Username) return false; // This skips the check if the username didnt changed
        List<string[]> result = HandleQueries.SelectFromFile("SelectUsername");
        foreach (string[] item in result)
        {
            if (item[0] == username) return true;
        }
        return false;
    }

    private void ChangePassword(object sender, EventArgs e)
    {
        ChangePassword changePassword = new(_password);
        changePassword.ShowDialog();
        _newPassword = changePassword.Password;
    }
}