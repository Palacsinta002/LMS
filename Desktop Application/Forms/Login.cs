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
        }

        // The X int the upper right corner closes the form.
        private void CloseWindow(object sender, EventArgs e)
        {
            this.Close();
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
