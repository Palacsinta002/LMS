using Desktop_Application.Classes;
using Desktop_Application.Forms.Books;
using MySqlX.XDevAPI.Common;

namespace Desktop_Application
{
    public partial class AdminPanel : Form
    {
        public AdminPanel(bool isAdmin)
        {
            InitializeComponent();
        }

        // Hides every panel so there will be room for the opened panel
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

        #region
        // Shows the Dashboard
        private void ShowDashboard(object sender, EventArgs e)
        {
            if (!dashboard_pnl.Visible)
            {
                HidePanels();
                dashboard_pnl.Visible = true;

                // Show statistics about our books
                List<object[]> result;
                result = HandleQueries.Select("BookCountSelect");
                dashboard_books.Text = result[0][0].ToString();

                result = HandleQueries.Select("UserCountSelect");
                dashboard_users.Text = result[0][0].ToString();

                result = HandleQueries.Select("BorrowingCountSelect");
                dashboard_borrowings.Text = result[0][0].ToString();

                result = HandleQueries.Select("BookTopBorrowedSelect");
                HandleGrids.Fill(dashboard_grd, result);
            }
        }
        #endregion

        // Books
        #region
        // Shows Books page and hides other pages
        private void ShowBooks(object sender, EventArgs e)
        {
            if (!books_pnl.Visible)
            {
                HidePanels();
                books_pnl.Visible = true;
                var result = HandleQueries.Select("BookSelect");
                HandleGrids.Fill(books_grd, result);
            }
        }

        // Selects from the database again
        private void RefreshBooks(object sender, EventArgs e)
        {
            var result = HandleQueries.Select("BookSelect");
            HandleGrids.Fill(books_grd, result);
        }

        // Edit the selected book from the grid and then updates in the database
        private void EditBook(object sender, EventArgs e)
        {
            if (books_grd.SelectedRows.Count != 1)
            {
                MessageBox.Show("You can only edit one book at a time!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            EditBook editBook = new(books_grd);
            editBook.ShowDialog();
        }

        // Removes book from the database
        private void RemoveBook(object sender, EventArgs e)
        {
            RemoveBook removeBook = new(books_grd);
            removeBook.ShowDialog();
        }

        // Adds a book to the database
        private void AddBook(object sender, EventArgs e)
        {
            AddBook addBook = new(books_grd);
            addBook.ShowDialog();
        }

        // Live search through the grid which is already filled with content from the database
        private void SearchBook(object sender, EventArgs e)
        {
            HandleGrids.SearchGrid(books_grd, books_src.Text);
        }
        #endregion

        // Borrowings
        #region
        private void ShowBorrowings(object sender, EventArgs e)
        {
            if (!borrowings_pnl.Visible)
            {
                HidePanels();
                borrowings_pnl.Visible = true;
            }
        }
        #endregion

        // Categories
        #region
        private void ShowCategories(object sender, EventArgs e)
        {
            if (!categories_pnl.Visible)
            {
                HidePanels();
                categories_pnl.Visible = true;
            }
        }
        #endregion

        // Members
        #region
        private void ShowMembers(object sender, EventArgs e)
        {
            if (members_pnl.Visible != true)
            {
                HidePanels();
                members_pnl.Visible = true;
            }
        }
        #endregion

        // Authors
        #region
        private void ShowAuthors(object sender, EventArgs e)
        {
            if (!authors_pnl.Visible)
            {
                HidePanels();
                authors_pnl.Visible = true;
            }
        }
        #endregion

        // Publishers
        #region
        private void ShowPublishers(object sender, EventArgs e)
        {
            if (!publishers_pnl.Visible)
            {
                HidePanels();
                publishers_pnl.Visible = true;
            }
        }
        #endregion

        // Logs out and drops back to the login screen
        private void Logout(object sender, EventArgs e)
        {
            Login login = new();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }
    }
}
