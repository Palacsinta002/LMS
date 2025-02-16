using System.Text.RegularExpressions;
using Desktop_Application.Classes;

namespace Desktop_Application
{
    public partial class Login : Form
    {
        private string _username;
        private string _password;

        public Login()
        {
            InitializeComponent();
            _username = "";
            _password = "";
        }

        private void OnLoad(object sender, EventArgs e)
        {
            DragWindow.Handle(this, header, title);
            BorderPaint.Handle(this);
            CloseThisWindow.Handle(this, close_btn);
        }

        // On Login if the username and password are in the correct format it starts checking the credentials
        private void LoginCheck(object sender, EventArgs e)
        {
            if (usernameError_lbl.Text == "" && passwordError_lbl.Text == "")
            {
                string hashedPassword = HashPassword(_password);

                string query = $"SELECT Users.FirstName, Users.LastName, Users.Username, Users.Password, Roles.Role FROM Users JOIN Roles ON Roles.id = Users.RoleID WHERE Username = '{_username}' AND Password = '{hashedPassword}'";
                Connection conn = new();
                var result = conn.Select(query);

                if (result.Count == 1)
                {
                    bool isAdmin = false;
                    if (result[0][4].ToString() == "Admin")
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
        }

        private string HashPassword(string password)
        {
            return "";
        }

        // On username change it writes out to the user what is wrong with the given text
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

        // On password change it writes out to the user what is wrong with the given text
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
    }
}
