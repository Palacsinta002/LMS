using Desktop_Application.Classes;
using Desktop_Application.Forms.Books;

namespace Desktop_Application
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void HidePanels()
        {
            dashboard_pnl.Visible = false;
            books_pnl.Visible = false;
            borrowings_pnl.Visible = false;
            categories_pnl.Visible = false;
            members_pnl.Visible = false;
            authors_pnl.Visible = false;
            publishers_pnl.Visible = false;
        }

        // Shows the Dashboard after hiding previous content.
        private void ShowDashboard(object sender, EventArgs e)
        {
            if (!dashboard_pnl.Visible)
            {
                HidePanels();
                dashboard_pnl.Visible = true;
            }
        }

        // Shows the Books after removing previous content.
        private void ShowBooks(object sender, EventArgs e)
        {
            if (!books_pnl.Visible)
            {
                HidePanels();
                books_pnl.Visible = true;
                HandleQueries.SelectFill(books_grd, "BookSelect");
            }
        }

        private void ShowBorrowings(object sender, EventArgs e)
        {
            if (!borrowings_pnl.Visible)
            {
                HidePanels();
                borrowings_pnl.Visible = true;
            }
        }

        private void ShowCategories(object sender, EventArgs e)
        {
            if (!categories_pnl.Visible)
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

        private void ShowAuthors(object sender, EventArgs e)
        {
            if (!authors_pnl.Visible)
            {
                HidePanels();
                authors_pnl.Visible = true;
            }
        }

        private void ShowPublishers(object sender, EventArgs e)
        {
            if (!publishers_pnl.Visible)
            {
                HidePanels();
                publishers_pnl.Visible = true;
            }
        }

        private void RefreshBooks(object sender, EventArgs e)
        {
            HandleQueries.SelectFill(books_grd, "BookSelect");
        }

        private void EditBook(object sender, EventArgs e)
        {
            if (books_grd.SelectedRows.Count != 1)
            {
                MessageBox.Show("You can only edit one book at a time!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            EditBook editBook = new();
            editBook.ShowDialog();
        }

        private void RemoveBook(object sender, EventArgs e)
        {
            RemoveBook removeBookConfirmation = new();
            removeBookConfirmation.ShowDialog();
        }

        private void AddBook(object sender, EventArgs e)
        {
            AddBook addBook = new();
            addBook.ShowDialog();
        }

        private void Logout(object sender, EventArgs e)
        {
            Login login = new();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void LiveSearch(object sender, EventArgs e)
        {
            //(books_grd.DataSource as DataTable).DefaultView.RowFilter = string.Format("Name LIKE '%{0}%' OR ID LIKE '%{0}%'", books_src.Text);
        }
    }
}
