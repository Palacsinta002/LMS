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



            bool isAdmin;
            if(username_textBox.Text == "admin")
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
}
