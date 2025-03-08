namespace Desktop_Application;

using Desktop_Application.Classes;
using Desktop_Application.Forms.Books;
using Desktop_Application.Forms.Borrowings;
using Desktop_Application.Forms.Categories;

public partial class AdminPanel : Form
{
    private readonly string _name;
    private readonly bool _isAdmin;

    public AdminPanel(string name, bool isAdmin)
    {
        _name = name;
        _isAdmin = isAdmin;
        InitializeComponent();
    }

    private void OnLoad(object sender, EventArgs e)
    {
        users_button_edit.Visible = _isAdmin;
        users_button_remove.Visible = _isAdmin;

        hello_lbl.Text = $"Hello {_name}!";

        ShowDashboard(sender, e);
    }

    #region Dashboard
    // Shows the Dashboard
    private void ShowDashboard(object sender, EventArgs e)
    {
        if (!dashboard_pnl.Visible)
        {
            HidePanels();
            dashboard_pnl.Visible = true;

            // Show statistics about our books
            try
            {
                List<string[]> result;
                result = HandleQueries.Select("SelectBookCount");
                dashboard_books.Text = result[0][0];

                result = HandleQueries.Select("SelectUserCount");
                dashboard_users.Text = result[0][0];

                result = HandleQueries.Select("SelectBorrowingCount");
                dashboard_borrowings.Text = result[0][0];

                result = HandleQueries.Select("SelectTopBorrowedBook");
                HandleGrids.Fill(dashboard_grd, result);
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is something wrong with the connection to the database, we can't show statistics!\nError: " + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }
    }
    #endregion

    #region Books
    // BOOKS
    // Shows Books page and hides other pages
    private void ShowBooks(object sender, EventArgs e)
    {
        if (!books_pnl.Visible)
        {
            HidePanels();
            books_pnl.Visible = true;
            RefreshBooks(sender, e);
        }
    }

    // Select books from the database and fills the grid
    private void RefreshBooks(object sender, EventArgs e)
    {
        var result = HandleQueries.Select("SelectBook");
        HandleGrids.Fill(books_grd, result);
    }

    // Live search - Searches title, publication year or isbn in the grid
    private void SearchBooks(object sender, EventArgs e)
    {
        string[] cols = ["title", "publicationYear", "isbn"];
        HandleGrids.SearchGrid(books_grd, books_src.Text, cols);
    }

    // Adds a book to the database
    private void AddBook(object sender, EventArgs e)
    {
        AddBook addBook = new();
        addBook.ShowDialog();
        RefreshBooks(sender, e);
    }

    // Edit the selected book from the grid and then updates it in the database
    private void EditBook(object sender, EventArgs e)
    {
        if (books_grd.SelectedRows.Count != 1)
        {
            MessageBox.Show("You must select ONE book to edit!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        EditBook editBook = new(books_grd);
        editBook.ShowDialog();
        RefreshBooks(sender, e);
    }

    // Removes book from the database
    private void RemoveBooks(object sender, EventArgs e)
    {
        RemoveBooks removeBook = new(books_grd);
        removeBook.ShowDialog();
        RefreshBooks(sender, e);
    }
    #endregion

    #region Borrowings
    // BORROWINGS
    // Shows Borrowings page and hides other pages
    private void ShowBorrowings(object sender, EventArgs e)
    {
        if (!borrowings_pnl.Visible)
        {
            HidePanels();
            borrowings_pnl.Visible = true;
            RefreshBorrowings(sender, e);
        }
    }

    // Select borrowings from the database and fills the grid
    internal void RefreshBorrowings(object sender, EventArgs e)
    {
        List<string[]> result;
        if (checkBox_currentBorrowings.Checked)
        {
            borrowings_grd.Columns["borrowings_returnDate"].Visible = false;
            result = HandleQueries.Select("SelectCurrentBorrowing");
        }
        else
        {
            borrowings_grd.Columns["borrowings_returnDate"].Visible = true;
            result = HandleQueries.Select("SelectAllBorrowing");
        }
        HandleGrids.Fill(borrowings_grd, result);
    }

    // Live search - Searches username, title or isbn in the grid
    private void SearchBorrowings(object sender, EventArgs e)
    {
        string[] cols = ["borrowings_username", "borrowings_title", "borrowings_isbn"];
        HandleGrids.SearchGrid(borrowings_grd, borrowings_src.Text, cols);
    }

    // Adds a borrowing to the database - Lends a book
    private void AddBorrowing(object sender, EventArgs e)
    {
        LendBook addBorrowing = new();
        addBorrowing.ShowDialog();
        RefreshBorrowings(sender, e);
    }

    // Edit the selected borrowing from the grid and then updates it in the database
    private void EditBorrowing(object sender, EventArgs e)
    {
        if (borrowings_grd.SelectedRows.Count != 1)
        {
            MessageBox.Show("You must select ONE borrowing to edit!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        else if (borrowings_grd.SelectedRows[0].Cells["borrowings_returnDate"].Value.ToString() != string.Empty)
        {
            MessageBox.Show("You can't edit returned borrowings!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        EditBorrowing editBorrowing = new(borrowings_grd);
        editBorrowing.ShowDialog();
        RefreshBorrowings(sender, e);
    }

    // Removes borrowing from the database - Marks the book as returned
    private void RemoveBorrowings(object sender, EventArgs e)
    {
        ReturnBook removeBorrowing = new(borrowings_grd);
        removeBorrowing.ShowDialog();
        RefreshBorrowings(sender, e);
    }
    #endregion

    #region Categories
    // CATEGORIES
    // Shows Categories page and hides other pages
    private void ShowCategories(object sender, EventArgs e)
    {
        if (!categories_pnl.Visible)
        {
            HidePanels();
            categories_pnl.Visible = true;
            RefreshCategories(sender, e);
        }
    }

    // Select categories from the database and fills the grid
    private void RefreshCategories(object sender, EventArgs e)
    {
        var result = HandleQueries.Select("SelectCategory");
        HandleGrids.Fill(categories_grd, result);
    }

    // Live search - Searches category in the grid
    private void SearchCategories(object sender, EventArgs e)
    {
        string[] cols = ["categories_category"];
        HandleGrids.SearchGrid(categories_grd, categories_src.Text, cols);
    }

    // Adds a category to the database
    private void AddCategory(object sender, EventArgs e)
    {
        AddCategory addCategory = new();
        addCategory.ShowDialog();
        RefreshCategories(sender, e);
    }

    // Edit the selected category from the grid and then updates it in the database
    private void EditCategory(object sender, EventArgs e)
    {
        if (categories_grd.SelectedRows.Count != 1)
        {
            MessageBox.Show("You must select ONE category to edit!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        EditCategory editCategory = new(categories_grd);
        editCategory.ShowDialog();
        RefreshCategories(sender, e);
    }

    // Removes category from the database - Marks the book as returned
    private void RemoveCategories(object sender, EventArgs e)
    {
        RemoveCategories removeCategories = new(categories_grd);
        removeCategories.ShowDialog();
        RefreshCategories(sender, e);

    }
    #endregion

    #region Authors
    // AUTHORS
    // Shows Authors page and hides other pages
    private void ShowAuthors(object sender, EventArgs e)
    {
        if (!authors_pnl.Visible)
        {
            HidePanels();
            authors_pnl.Visible = true;
        }
    }

    // Select authors from the database and fills the grid
    private void RefreshAuthors(object sender, EventArgs e)
    {

    }

    // Live search - Searches authors in the grid
    private void SearchAuthors(object sender, EventArgs e)
    {

    }

    // Adds an author to the database
    private void AddAuthor(object sender, EventArgs e)
    {

    }

    // Edit the selected author from the grid and then updates it in the database
    private void EditAuthor(object sender, EventArgs e)
    {

    }

    // Removes authors from the database - Marks the book as returned
    private void RemoveAuthor(object sender, EventArgs e)
    {

    }
    #endregion

    #region Publishers
    // PUBLISHERS
    // Shows Publishers page and hides other pages
    private void ShowPublishers(object sender, EventArgs e)
    {
        if (!publishers_pnl.Visible)
        {
            HidePanels();
            publishers_pnl.Visible = true;
        }
    }

    // Select publishers from the database and fills the grid
    private void RefreshPublishers(object sender, EventArgs e)
    {

    }

    // Live search - Searches publishers in the grid
    private void SearchPublishers(object sender, EventArgs e)
    {

    }

    // Adds a publisher to the database
    private void AddPublisher(object sender, EventArgs e)
    {

    }

    // Edit the selected publisher from the grid and then updates it in the database
    private void EditPublisher(object sender, EventArgs e)
    {

    }

    // Removes publishers from the database - Marks the book as returned
    private void RemovePublishers(object sender, EventArgs e)
    {

    }
    #endregion

    #region Users
    // USERS
    // Shows Users page and hides other pages
    private void ShowUsers(object sender, EventArgs e)
    {
        if (users_pnl.Visible != true)
        {
            HidePanels();
            users_pnl.Visible = true;
            RefreshUsers(sender, e);
        }
    }

    // Select users from the database and fills the grid
    private void RefreshUsers(object sender, EventArgs e)
    {
        var result = HandleQueries.Select("SelectUser");
        HandleGrids.Fill(users_grd, result);
    }

    // Live search - Searches users in the grid
    private void SearchUsers(object sender, EventArgs e)
    {
        string[] cols = ["users_name", "users_username"];
        HandleGrids.SearchGrid(users_grd, users_src.Text, cols);
    }

    // Adds a user to the database
    private void AddUser(object sender, EventArgs e)
    {
        AddUser addUser = new();
        addUser.ShowDialog();
        RefreshUsers(sender, e);
    }

    // Edit the selected user from the grid and then updates it in the database
    private void EditUser(object sender, EventArgs e)
    {
        if (users_grd.SelectedRows.Count != 1)
        {
            MessageBox.Show("You must select ONE user to edit!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        EditUser editUser = new(users_grd);
        editUser.ShowDialog();
        RefreshUsers(sender, e);
    }

    // Removes user from the database - Marks the book as returned
    private void RemoveUsers(object sender, EventArgs e)
    {
        RemoveUser removeUser = new(users_grd);
        removeUser.ShowDialog();
        RefreshUsers(sender, e);
    }
    #endregion

    // Hides every panel so there will be room for the opened panel
    private void HidePanels()
    {
        dashboard_pnl.Visible = false;
        books_pnl.Visible = false;
        borrowings_pnl.Visible = false;
        categories_pnl.Visible = false;
        users_pnl.Visible = false;
        authors_pnl.Visible = false;
        publishers_pnl.Visible = false;
    }

    // Logs out and drops back to the login screen
    private void Logout(object sender, EventArgs e)
    {
        Login login = new();
        this.Hide();
        login.ShowDialog();
        this.Close();
    }
}