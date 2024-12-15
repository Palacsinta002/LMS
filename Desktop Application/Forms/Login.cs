using Desktop_Application.Classes;

namespace Desktop_Application
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
            CloseThisWindow.Handle(this, close_btn);
        }

        // WIP For now the Login button opens another form without any checking.
        private void LoginCheck(object sender, EventArgs e)
        {
            adminPanel adminPanel = new adminPanel();
            this.Hide();
            adminPanel.ShowDialog();
            this.Close();
        }
    }
}
