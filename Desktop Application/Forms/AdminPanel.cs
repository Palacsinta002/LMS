using System.Security.Policy;
using Desktop_Application.Classes;
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
                Connection connection = new Connection();
                string query =
                    "SELECT Books.ISBN AS ISBN, Publishers.Publisher AS Publisher, Authors.Name AS Author, Categories.Category AS Category, Books.Title AS Title, Books.PublicationYear AS PublicationYear " +
                    "FROM Books, Publishers, Authors, Categories " +
                    "WHERE Books.PublisherID = Publishers.PublisherID " +
                    "AND Books.AuthorID = Authors.AuthorID " +
                    "AND Books.CategoryID = Categories.CategoryID";
                var result = connection.Select(query);
                FillGrid.Fill(books_grd, result);
                //https://youtu.be/eJi02kg-S8g
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
            // Refresh the table of books from the database
        }

        private void EditBook(object sender, EventArgs e)
        {
            EditBook editBook = new EditBook();
            editBook.ShowDialog();
            if (editBook.DialogResult == DialogResult.OK)
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
