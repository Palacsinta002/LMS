namespace Desktop_Application
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void CloseWindow(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginCheck(object sender, EventArgs e)
        {
            adminPanel adminPanel = new adminPanel();
            this.Hide();
            adminPanel.ShowDialog();
            this.Close();
        }
    }
}
