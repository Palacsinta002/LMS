using Desktop_Application.Classes;
using System.Text.RegularExpressions;

namespace Desktop_Application.Forms.Profile;

public partial class ChangePassword : Form
{
    internal string Password { get; private set; }

    public ChangePassword(string hashedPassword)
    {
        Password = hashedPassword;
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
        this.KeyPreview = true;
    }

    private void Save(object sender, EventArgs e)
    {
        if (ValidateInput())
        {
            Password = BCrypt.Net.BCrypt.HashPassword(textBox_newPassword.Text);
            this.Close();
        }
    }

    // returns true if everything is correct
    private bool ValidateInput()
    {
        if (!BCrypt.Net.BCrypt.Verify(textBox_currentPassword.Text, Password))
        {
            MessageBox.Show("Current password field doesn't match with your actual password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (textBox_newPassword.Text == string.Empty)
        {
            MessageBox.Show("New password field is required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        else if (!Regex.IsMatch(textBox_newPassword.Text, @"^[^""\\]+$"))
        {
            MessageBox.Show("New password field is not in the correct format! Please check your special characters!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        else if (!Regex.IsMatch(textBox_newPassword.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*\W).{8,16}$"))
        {
            MessageBox.Show("New password field doesn't match the requirements!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (textBox_newPasswordAgain.Text == string.Empty)
        {
            MessageBox.Show("New password again field is required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        else if (textBox_newPasswordAgain.Text != textBox_newPassword.Text)
        {
            MessageBox.Show("The new passwords does not match!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        return true;
    }

    private void ShowPasswordRequirements(object sender, EventArgs e)
    {
        PasswordRequirements passwordRequirements = new();
        passwordRequirements.ShowDialog();
    }
}