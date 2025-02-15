using System.Text.RegularExpressions;
using Library_Management_System.Classes;

namespace Library_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            DragWindow.Handle(this, header, title);
            BorderPaint.Handle(this);
            CloseThisWindow.Handle(this, close_btn);
        }

        // WIP For now the Login button opens another form without any checking.
        private void LoginCheck(object sender, EventArgs e)
        {
            string username = username_textBox.Text;
            string password = password_textBox.Text;
            if (ValidateInput(username, password))
            {



                bool isAdmin;
                if (username_textBox.Text == "admin")
                {
                    isAdmin = true;
                }
                else
                {
                    isAdmin = false;
                }
                AdminPanel adminPanel = new(/*firstname lastname*/username_textBox.Text, isAdmin);
                this.Hide();
                adminPanel.ShowDialog();
                this.Close();
            }
        }

        private bool ValidateInput(string username, string password)
        {
            if (username == string.Empty)
            {
                MessageBox.Show("Username is required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!Regex.IsMatch(username, @"^[^""\\]+$"))
            {
                MessageBox.Show("Username is not in the correct format! Please check your special characters!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (password == string.Empty)
            {
                MessageBox.Show("Password is required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!Regex.IsMatch(password, @"^[^""\\]+$"))
            {
                MessageBox.Show("Password is not in the correct format! Please check your special characters!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
