using Desktop_Application.Forms.Books;

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
            authors_pnl.Visible = false;
            publishers_pnl.Visible = false;
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

        private void ShowAuthors(object sender, EventArgs e)
        {
            if (authors_pnl.Visible != true)
            {
                HidePanels();
                authors_pnl.Visible = true;
            }
        }

        private void ShowPublishers(object sender, EventArgs e)
        {
            if (publishers_pnl.Visible != true)
            {
                HidePanels();
                publishers_pnl.Visible = true;
            }
        }

        private void RefreshBooks(object sender, EventArgs e)
        {
            // Refresh the table of books from the database
        }

        private void EditBook(object sender, EventArgs e)
        {
            EditBook editBook = new EditBook();
            editBook.ShowDialog();
            if(editBook.DialogResult == DialogResult.OK)
            {
                // Update the book's details
            }
        }

        private void RemoveBook(object sender, EventArgs e)
        {
            RemoveBookConfirmation removeBookConfirmation = new RemoveBookConfirmation();
            removeBookConfirmation.ShowDialog();
            if (removeBookConfirmation.DialogResult == DialogResult.OK)
            {
                // Remove the book
            }
        }

        private void AddBook(object sender, EventArgs e)
        {
            AddBook addBook = new AddBook();
            addBook.ShowDialog();
            if (addBook.DialogResult == DialogResult.OK)
            {
                // Add the book
            }
        }
    }
}
