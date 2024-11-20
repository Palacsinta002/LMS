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
            dashboard_pnl.Visible = false;
            books_pnl.Visible = false;
            borrowings_pnl.Visible = false;
            categories_pnl.Visible = false;
            members_pnl.Visible = false;
        }

        // Shows the Dashboard after hiding previous content.
        private void ShowDashboard(object sender, EventArgs e)
        {
            if (dashboard_pnl.Visible != true)
            {
                HidePanels();
                dashboard_pnl.Visible = true;
            }
        }

        // Shows the Books after removing previous content.
        private void ShowBooks(object sender, EventArgs e)
        {
            if (books_pnl.Visible != true)
            {
                HidePanels();
                books_pnl.Visible = true;
            }
        }

        private void ShowBorrowings(object sender, EventArgs e)
        {
            if (borrowings_pnl.Visible != true)
            {
                HidePanels();
                borrowings_pnl.Visible = true;
            }
        }

        private void ShowCategories(object sender, EventArgs e)
        {
            if (categories_pnl.Visible != true)
            {
                HidePanels();
                categories_pnl.Visible = true;
            }
        }

        private void ShowMembers(object sender, EventArgs e)
        {
            if (members_pnl.Visible != true)
            {
                HidePanels();
                members_pnl.Visible = true;
            }
        }
    }
}
