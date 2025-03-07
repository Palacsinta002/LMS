using System.Text.RegularExpressions;
using Desktop_Application.Classes;

namespace Desktop_Application
{
    public partial class AddUser : Form
    {
        public AddUser()
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
                string randomPassword = GeneratePassword(12);
                MessageBox.Show(randomPassword);

                Mailer.SendMail(textBox_email.Text, textBox_username.Text, randomPassword);

                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(randomPassword);

                HandleQueries.InsertUser(textBox_firstName.Text, textBox_lastName.Text, textBox_email.Text, textBox_username.Text, hashedPassword, textBox_address.Text);
                MessageBox.Show("User added succesfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        // returns true if everything is correct
        private bool ValidateInput()
        {
            if (textBox_firstName.Text == string.Empty)
            {
                MessageBox.Show("First name is required!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!Regex.IsMatch(textBox_firstName.Text, @"^[^""\\]+$"))
            {
                MessageBox.Show("First name is not in the correct format! Please check your special characters!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (textBox_lastName.Text == string.Empty)
            {
                MessageBox.Show("Last name is required!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!Regex.IsMatch(textBox_lastName.Text, @"^[^""\\]+$"))
            {
                MessageBox.Show("Last name is not in the correct format! Please check your special characters!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (textBox_email.Text == string.Empty)
            {
                MessageBox.Show("Email is required!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!Regex.IsMatch(textBox_email.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                MessageBox.Show("Email is not in the correct format! Please check your special characters!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (textBox_username.Text == string.Empty)
            {
                MessageBox.Show("Address is required!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!Regex.IsMatch(textBox_username.Text, @"^[^""\\]+$"))
            {
                MessageBox.Show("Address is not in the correct format! Please check your special characters!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (CheckUsername(textBox_username.Text))
            {
                MessageBox.Show("Username already exists!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (textBox_address.Text == string.Empty)
            {
                MessageBox.Show("Address is required!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!Regex.IsMatch(textBox_address.Text, @"^[^""\\]+$"))
            {
                MessageBox.Show("Address is not in the correct format! Please check your special characters!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private static bool CheckUsername(string username)
        {
            List<string[]> result = HandleQueries.Select("SelectUsername");
            foreach(string[] item in result)
            {
                if (item[0] == username) return true;
            }
            return false;
        }

        private static string GeneratePassword(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new();
            string randomPassword = "";
            while(0 < length--)
            {
                randomPassword += chars[random.Next(chars.Length)];
            }
            return randomPassword;
        }
    }
}
