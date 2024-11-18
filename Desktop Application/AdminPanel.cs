namespace Desktop_Application
{
    public partial class adminPanel : Form
    {
        public adminPanel()
        {
            InitializeComponent();
        }

        private void Logout(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void HidePanels()
        {
            dashboardPanel.Visible = false;
            booksPanel.Visible = false;
        }

        // Shows the Dashboard after hiding previous content.
        private void ShowDashboard(object sender, EventArgs e)
        {
            if(dashboardPanel.Visible != true)
            {
                HidePanels();
                dashboardPanel.Visible = true;
            }
        }

        // Shows the Books after removing previous content.
        private void ShowBooks(object sender, EventArgs e)
        {
            if (booksPanel.Visible != true)
            {
                HidePanels();
                booksPanel.Visible = true;
            }
        }
    }
}
