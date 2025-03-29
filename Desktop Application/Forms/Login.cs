using System.Text.RegularExpressions;
using Desktop_Application.Classes;

namespace Desktop_Application;

public partial class Login : Form
{
    private string _username;
    private string _password;

    public Login()
    {
        _username = "";
        _password = "";
        InitializeComponent();
    }

    private void OnLoad(object sender, EventArgs e)
    {
        // Default design and controls
        HandleFonts.Set(this);
        DragWindow.Handle(this, header, title);
        BorderPaint.Handle(this);
        CloseThisWindow.Handle(this, close_btn);
        HandleKeys.Handle(this, Keys.Enter, LoginCheck);
        this.KeyPreview = true;
    }

    private void LoginCheck(object sender, EventArgs e)
    {
        if (_username == string.Empty || _password == string.Empty)
        {
            MessageBox.Show("Username and password are required!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else if (usernameError_lbl.Text == "" && passwordError_lbl.Text == "")
        {
            // Selects the hashed password and role based on username
            string query = $"SELECT Users.Password, Roles.Role FROM Users JOIN Roles ON Roles.id = Users.RoleID WHERE Username = '{_username}'";
            Connection conn = new();
            var result = conn.Select(query);

            // If username exists
            if (result.Count == 1)
            {
                string hashPassword = result[0][0].ToString() ?? string.Empty;

                // Takes the given password and the hashed password from the database. Then matches them, if they match the user is allowed to log in.
                if (BCrypt.Net.BCrypt.Verify(_password, hashPassword))
                {
                    bool isAdmin = false;
                    // If the user is not an admin or librarian they can't log in
                    if (result[0][1].ToString() == "Member")
                    {
                        MessageBox.Show("You must be a librarian or an administrator to log in!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (result[0][1].ToString() == "Admin")
                    {
                        isAdmin = true;
                    }

                    AdminPanel adminPanel = new(username_textBox.Text, isAdmin);
                    this.Hide();
                    adminPanel.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Wrong username or password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Wrong username or password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        else
        {
            MessageBox.Show("There are errors in the username or password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    // On username text change it writes out to the user what is wrong with the given text if there is any
    private void UsernameTextChanged(object sender, EventArgs e)
    {
        _username = username_textBox.Text;

        if (_username == string.Empty)
        {
            usernameError_lbl.Text = "Username is required!";
        }
        else if (!Regex.IsMatch(_username, @"^[^""\\]+$"))
        {
            usernameError_lbl.Text = "Not allowed special characters!";
        }
        else
        {
            usernameError_lbl.Text = "";
        }
    }

    // On password text change it writes out to the user what is wrong with the given text if there is any
    private void PasswordTextChanged(object sender, EventArgs e)
    {
        _password = password_textBox.Text;

        if (_password == string.Empty)
        {
            passwordError_lbl.Text = "Password is required!";
        }
        else if (!Regex.IsMatch(_password, @"^[^""\\]+$"))
        {
            passwordError_lbl.Text = "Not allowed special characters!";
        }
        else
        {
            passwordError_lbl.Text = "";
        }
    }

    // Handles the eye icon for showing the password
    private void ShowPassword(object sender, EventArgs e)
    {
        if (password_textBox.PasswordChar == '*')
        {
            password_textBox.PasswordChar = '\0';
            showPassword_btn.Image = Image.FromFile(@"Resources\hideIcon.png");
        }
        else
        {
            password_textBox.PasswordChar = '*';
            showPassword_btn.Image = Image.FromFile(@"Resources\showIcon.png");
        }
    }
}