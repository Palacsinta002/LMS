using System.Text.RegularExpressions;
using Desktop_Application.Classes;

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
        CloseWindow.Handle(this, close_btn);
        CloseWindow.Handle(this, cancel);
        HandleKeys.Handle(this, Keys.Enter, Save);
        HandleKeys.Handle(this, Keys.Escape, (s, e) => this.Close());
        this.KeyPreview = true;
    }

    private void Save(object sender, EventArgs e)
    {
        if (ValidateInput())
        {
            Password = BCrypt.Net.BCrypt.HashPassword(textBox_newPassword.Text);
            this.DialogResult = DialogResult.OK;
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
        else if (!Regex.IsMatch(textBox_newPassword.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*(\d|\W)).{8,16}$"))
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

    // Handles the eye icon for showing the password
    private void ShowPassword(object sender, EventArgs e)
    {
        if (textBox_newPassword.PasswordChar == '*')
        {
            textBox_newPassword.PasswordChar = '\0';
            button_showPassword.Image = Image.FromFile(@"Resources\hideIcon.png");
        }
        else
        {
            textBox_newPassword.PasswordChar = '*';
            button_showPassword.Image = Image.FromFile(@"Resources\showIcon.png");
        }
    }

    // On password change it will update the buttons and colors of the password requirements labels
    private void OnPasswordChange(object sender, EventArgs e)
    {
        string password = textBox_newPassword.Text;

        // Checking length
        if (Regex.IsMatch(password, @"^.{8,16}$"))
        {
            rButton_characterCount.Image = Image.FromFile(@"Resources\checkMark.png");
            label_characterCount.ForeColor = Color.Green;
        }
        else
        {
            rButton_characterCount.Image = Image.FromFile(@"Resources\closeRed.png");
            label_characterCount.ForeColor = Color.Red;
        }
        // Checking uppercase characters
        if (Regex.IsMatch(password, @"[A-Z]"))
        {
            rButton_upper.Image = Image.FromFile(@"Resources\checkMark.png");
            label_upper.ForeColor = Color.Green;
        }
        else
        {
            rButton_upper.Image = Image.FromFile(@"Resources\closeRed.png");
            label_upper.ForeColor = Color.Red;
        }
        // Checking lowercase characters
        if (Regex.IsMatch(password, @"[a-z]"))
        {
            rButton_lower.Image = Image.FromFile(@"Resources\checkMark.png");
            label_lower.ForeColor = Color.Green;
        }
        else
        {
            rButton_lower.Image = Image.FromFile(@"Resources\closeRed.png");
            label_lower.ForeColor = Color.Red;
        }
        // Checking special and numeric characters
        if (Regex.IsMatch(password, @"\d|[^\w\""]"))
        {
            rButton_special.Image = Image.FromFile(@"Resources\checkMark.png");
            label_special.ForeColor = Color.Green;
        }
        else
        {
            rButton_special.Image = Image.FromFile(@"Resources\closeRed.png");
            label_special.ForeColor = Color.Red;
        }
        // Checking if passwords are matching
        if (textBox_newPassword.Text == textBox_newPasswordAgain.Text)
        {
            rButton_match.Image = Image.FromFile(@"Resources\checkMark.png");
            label_match.ForeColor = Color.Green;
        }
        else
        {
            rButton_match.Image = Image.FromFile(@"Resources\closeRed.png");
            label_match.ForeColor = Color.Red;
        }
    }

    private void OnPasswordAgainChange(object sender, EventArgs e)
    {
        // Checking if passwords are matching
        if (textBox_newPassword.Text == textBox_newPasswordAgain.Text)
        {
            rButton_match.Image = Image.FromFile(@"Resources\checkMark.png");
            label_match.ForeColor = Color.Green;
        }
        else
        {
            rButton_match.Image = Image.FromFile(@"Resources\closeRed.png");
            label_match.ForeColor = Color.Red;
        }
    }
}