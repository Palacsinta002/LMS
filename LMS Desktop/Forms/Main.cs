using Desktop_Application.Classes;
using Desktop_Application.Forms.Authors;
using Desktop_Application.Forms.Books;
using Desktop_Application.Forms.Borrowings;
using Desktop_Application.Forms.Categories;
using Desktop_Application.Forms.Profile;
using Desktop_Application.Forms.Publishers;
using Desktop_Application.Forms.Reservations;
using Desktop_Application.Forms.Users;

namespace Desktop_Application;

public partial class Main : Form
{
    private string _username;
    private readonly bool _isAdmin;

    public Main(string username, bool isAdmin)
    {
        _username = username;
        _isAdmin = isAdmin;
        InitializeComponent();
    }

    private void OnLoad(object sender, EventArgs e)
    {
        HandleFonts.Set(this);
        users_rButton_edit.Visible = _isAdmin;
        users_rButton_remove.Visible = _isAdmin;

        label_greeting.Text = $"Hello {_username}!";

        ShowDashboard(sender, e);
    }

    private void OpenProfileSettings(object sender, EventArgs e)
    {
        ProfileSettings profileSettings = new(_username);
        profileSettings.ShowDialog();
        _username = profileSettings.Username;
        label_greeting.Text = $"Hello {_username}!";
    }

    #region Dashboard
    // Shows the Dashboard
    private void ShowDashboard(object sender, EventArgs e)
    {
        if (!panel_dashboard.Visible)
        {
            HidePanels();
            panel_dashboard.Visible = true;
            panel_dashboard.Enabled = true;

            // Show statistics about our books
            try
            {
                List<string[]> result;
                result = HandleQueries.SelectFromFile("SelectBookCount");
                rButton_noOfBooks.Text = result[0][0];

                result = HandleQueries.SelectFromFile("SelectUserCount");
                rButton_noOfUsers.Text = result[0][0];

                result = HandleQueries.SelectFromFile("SelectBorrowingCount");
                rButton_noOfBorrowings.Text = result[0][0];

                result = HandleQueries.SelectFromFile("SelectTopBorrowedBook");
                HandleGrids.Fill(dashboard_grid, result);
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
        if (!panel_books.Visible)
        {
            HidePanels();
            panel_books.Visible = true;
            panel_books.Enabled = true;
            RefreshBooks(sender, e);
        }
    }

    // Select books from the database and fills the grid
    private void RefreshBooks(object sender, EventArgs e)
    {
        var result = HandleQueries.SelectFromFile("SelectBook");
        HandleGrids.Fill(books_grid, result);
    }

    // Live search - Searches title, publication year or isbn in the grid
    private void SearchBooks(object sender, EventArgs e)
    {
        string[] cols = ["books_title", "books_publicationYear", "books_isbn"];
        HandleGrids.SearchGrid(books_grid, books_textBox_search.Text, cols);
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
        if (books_grid.SelectedRows.Count != 1)
        {
            MessageBox.Show("You must select ONE book to edit!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        EditBook editBook = new(books_grid);
        editBook.ShowDialog();
        RefreshBooks(sender, e);
    }

    // Removes book from the database
    private void RemoveBooks(object sender, EventArgs e)
    {
        List<string> selectedIsbns = [];
        foreach (DataGridViewRow row in books_grid.SelectedRows)
        {
            string isbn = (string)row.Cells["books_isbn"].Value;
            selectedIsbns.Add(isbn);
        }

        RemoveBooks removeBook = new(selectedIsbns);
        removeBook.ShowDialog();
        RefreshBooks(sender, e);
    }
    #endregion

    #region Borrowings
    // BORROWINGS
    // Shows Borrowings page and hides other pages
    private void ShowBorrowings(object sender, EventArgs e)
    {
        if (!panel_borrowings.Visible)
        {
            HidePanels();
            panel_borrowings.Visible = true;
            panel_borrowings.Enabled = true;
            RefreshBorrowings(sender, e);
        }
    }

    // Select borrowings from the database and fills the grid
    internal void RefreshBorrowings(object sender, EventArgs e)
    {
        List<string[]> result;
        if (borrowings_checkBox_currentBorrowings.Checked)
        {
            borrowings_grid.Columns["borrowings_returnDate"].Visible = false;
            result = HandleQueries.SelectFromFile("SelectCurrentBorrowing");
        }
        else
        {
            borrowings_grid.Columns["borrowings_returnDate"].Visible = true;
            result = HandleQueries.SelectFromFile("SelectAllBorrowing");
        }
        HandleGrids.Fill(borrowings_grid, result);
    }

    // Live search - Searches username, title or isbn in the grid
    private void SearchBorrowings(object sender, EventArgs e)
    {
        string[] cols = ["borrowings_username", "borrowings_title", "borrowings_isbn"];
        HandleGrids.SearchGrid(borrowings_grid, borrowings_textBox_search.Text, cols);
    }

    // Adds a borrowing to the database - Lends a book
    private void AddBorrowing(object sender, EventArgs e)
    {
        AddBorrowing addBorrowing = new();
        addBorrowing.ShowDialog();
        RefreshBorrowings(sender, e);
    }

    // Edit the selected borrowing from the grid and then updates it in the database
    private void EditBorrowing(object sender, EventArgs e)
    {
        if (borrowings_grid.SelectedRows.Count != 1)
        {
            MessageBox.Show("You must select ONE borrowing to extend!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        else if (borrowings_grid.SelectedRows[0].Cells["borrowings_returnDate"].Value.ToString() != string.Empty)
        {
            MessageBox.Show("You can't extend returned borrowings!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        ExtendBorrowing extendBorrowing = new(borrowings_grid);
        extendBorrowing.ShowDialog();
        RefreshBorrowings(sender, e);
    }

    // Removes borrowing from the database - Marks the book as returned
    private void RemoveBorrowings(object sender, EventArgs e)
    {
        List<string> selectedIsbns = [];
        foreach (DataGridViewRow row in borrowings_grid.SelectedRows)
        {
            string returnDate = (string)row.Cells["borrowings_returnDate"].Value;
            if (returnDate != string.Empty)
            {
                MessageBox.Show("There is at least one book selected which is already returned!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string isbn = (string)row.Cells["borrowings_isbn"].Value;
            selectedIsbns.Add(isbn);
        }

        RemoveBorrowings removeBorrowing = new(selectedIsbns);
        removeBorrowing.ShowDialog();
        RefreshBorrowings(sender, e);
    }
    #endregion

    #region Reservations
    // RESERVATIONS
    // Shows Reservations page and hides other pages
    private void ShowReservations(object sender, EventArgs e)
    {
        HidePanels();
        panel_reservations.Visible = true;
        panel_reservations.Enabled = true;
        RefreshReservations(sender, e);
    }

    // Select reservations from the database and fills the grid
    private void RefreshReservations(object sender, EventArgs e)
    {
        var result = HandleQueries.SelectFromFile("SelectReservation");
        HandleGrids.Fill(reservations_grid, result);
    }

    // Live search - Searches username, title, isbn in the grid
    private void SearchReservations(object sender, EventArgs e)
    {
        string[] cols = ["reservations_username", "reservations_title", "reservations_isbn"];
        HandleGrids.SearchGrid(reservations_grid, reservations_textBox_search.Text, cols);
    }

    // Adds a reservation to the database - Lends a book
    private void AddReservation(object sender, EventArgs e)
    {
        AddReservation addReservation = new();
        addReservation.ShowDialog();
        RefreshReservations(sender, e);
    }

    // Edit the selected reservation from the grid and then updates it in the database
    private void EditReservation(object sender, EventArgs e)
    {
        if (reservations_grid.SelectedRows.Count != 1)
        {
            MessageBox.Show("You must select ONE reservation to extend!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        ExtendReservation extendReservation = new(reservations_grid);
        extendReservation.ShowDialog();
        RefreshReservations(sender, e);
    }

    // Removes reservation from the database
    private void RemoveReservations(object sender, EventArgs e)
    {
        List<string> selectedIsbns = [];
        foreach (DataGridViewRow row in reservations_grid.SelectedRows)
        {
            string isbn = (string)row.Cells["reservations_isbn"].Value;
            selectedIsbns.Add(isbn);
        }

        RemoveReservations removeReservations = new(selectedIsbns);
        removeReservations.ShowDialog();
        RefreshReservations(sender, e);
    }

    // Create a borrowing based on the selected reservations and removes the reservations
    private void LendReservation(object sender, EventArgs e)
    {
        if (reservations_grid.SelectedRows.Count != 1)
        {
            MessageBox.Show("You must select ONE reservation to lend!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        LendReservation lendReservation = new(reservations_grid);
        lendReservation.ShowDialog();
        RefreshReservations(sender, e);
    }
    #endregion

    #region Categories
    // CATEGORIES
    // Shows Categories page and hides other pages
    private void ShowCategories(object sender, EventArgs e)
    {
        if (!panel_categories.Visible)
        {
            HidePanels();
            panel_categories.Visible = true;
            panel_categories.Enabled = true;
            RefreshCategories(sender, e);
        }
    }

    // Select categories from the database and fills the grid
    private void RefreshCategories(object sender, EventArgs e)
    {
        var result = HandleQueries.SelectFromFile("SelectCategory");
        HandleGrids.Fill(categories_grid, result);
    }

    // Live search - Searches category in the grid
    private void SearchCategories(object sender, EventArgs e)
    {
        string[] cols = ["categories_category"];
        HandleGrids.SearchGrid(categories_grid, categories_textBox_search.Text, cols);
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
        if (categories_grid.SelectedRows.Count != 1)
        {
            MessageBox.Show("You must select ONE category to edit!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        EditCategory editCategory = new(categories_grid);
        editCategory.ShowDialog();
        RefreshCategories(sender, e);
    }

    // Removes category from the database - Marks the book as returned
    private void RemoveCategories(object sender, EventArgs e)
    {
        List<string> selectedCategories = [];
        foreach (DataGridViewRow row in categories_grid.SelectedRows)
        {
            string category = (string)row.Cells["categories_category"].Value;
            selectedCategories.Add(category);
        }

        RemoveCategories removeCategories = new(selectedCategories);
        removeCategories.ShowDialog();
        RefreshCategories(sender, e);

    }
    #endregion

    #region Authors
    // AUTHORS
    // Shows Authors page and hides other pages
    private void ShowAuthors(object sender, EventArgs e)
    {
        if (!panel_authors.Visible)
        {
            HidePanels();
            panel_authors.Visible = true;
            panel_authors.Enabled = true;
            RefreshAuthors(sender, e);
        }
    }

    // Select authors from the database and fills the grid
    private void RefreshAuthors(object sender, EventArgs e)
    {
        var result = HandleQueries.SelectFromFile("SelectAuthor");
        HandleGrids.Fill(authors_grid, result);
    }

    // Live search - Searches authors in the grid
    private void SearchAuthors(object sender, EventArgs e)
    {
        string[] cols = ["authors_author"];
        HandleGrids.SearchGrid(authors_grid, authors_textBox_search.Text, cols);
    }

    // Adds an author to the database
    private void AddAuthor(object sender, EventArgs e)
    {
        AddAuthor addAuthor = new();
        addAuthor.ShowDialog();
        RefreshAuthors(sender, e);
    }

    // Edit the selected author from the grid and then updates it in the database
    private void EditAuthor(object sender, EventArgs e)
    {
        if (authors_grid.SelectedRows.Count != 1)
        {
            MessageBox.Show("You must select ONE author to edit!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        EditAuthor editAuthor = new(authors_grid);
        editAuthor.ShowDialog();
        RefreshAuthors(sender, e);
    }

    // Removes authors from the database - Marks the book as returned
    private void RemoveAuthors(object sender, EventArgs e)
    {
        List<string> selectedAuthors = [];
        foreach (DataGridViewRow row in authors_grid.SelectedRows)
        {
            string author = (string)row.Cells["authors_author"].Value;
            selectedAuthors.Add(author);
        }

        RemoveAuthors removeAuthors = new(selectedAuthors);
        removeAuthors.ShowDialog();
        RefreshAuthors(sender, e);
    }
    #endregion

    #region Publishers
    // PUBLISHERS
    // Shows Publishers page and hides other pages
    private void ShowPublishers(object sender, EventArgs e)
    {
        if (!panel_publishers.Visible)
        {
            HidePanels();
            panel_publishers.Visible = true;
            panel_publishers.Enabled = true;
            RefreshPublishers(sender, e);
        }
    }

    // Select publishers from the database and fills the grid
    private void RefreshPublishers(object sender, EventArgs e)
    {
        var result = HandleQueries.SelectFromFile("SelectPublisher");
        HandleGrids.Fill(publishers_grid, result);
    }

    // Live search - Searches publishers in the grid
    private void SearchPublishers(object sender, EventArgs e)
    {
        string[] cols = ["publishers_publisher"];
        HandleGrids.SearchGrid(publishers_grid, publishers_textBox_search.Text, cols);
    }

    // Adds a publisher to the database
    private void AddPublisher(object sender, EventArgs e)
    {
        AddPublisher addPublisher = new();
        addPublisher.ShowDialog();
        RefreshPublishers(sender, e);
    }

    // Edit the selected publisher from the grid and then updates it in the database
    private void EditPublisher(object sender, EventArgs e)
    {
        if (publishers_grid.SelectedRows.Count != 1)
        {
            MessageBox.Show("You must select ONE publisher to edit!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        EditPublisher editPublisher = new(publishers_grid);
        editPublisher.ShowDialog();
        RefreshPublishers(sender, e);
    }

    // Removes publishers from the database - Marks the book as returned
    private void RemovePublishers(object sender, EventArgs e)
    {
        List<string> selectedPublishers = [];
        foreach (DataGridViewRow row in publishers_grid.SelectedRows)
        {
            string publisher = (string)row.Cells["publishers_publisher"].Value;
            selectedPublishers.Add(publisher);
        }

        RemovePublishers removePublishers = new(selectedPublishers);
        removePublishers.ShowDialog();
        RefreshPublishers(sender, e);
    }
    #endregion

    #region Users
    // USERS
    // Shows Users page and hides other pages
    private void ShowUsers(object sender, EventArgs e)
    {
        if (panel_users.Visible != true)
        {
            HidePanels();
            panel_users.Visible = true;
            panel_users.Enabled = true;
            RefreshUsers(sender, e);
        }
    }

    // Select users from the database and fills the grid
    private void RefreshUsers(object sender, EventArgs e)
    {
        var result = HandleQueries.SelectFromFile("SelectUser");
        HandleGrids.Fill(users_grid, result);
    }

    // Live search - Searches users in the grid
    private void SearchUsers(object sender, EventArgs e)
    {
        string[] cols = ["users_name", "users_username"];
        HandleGrids.SearchGrid(users_grid, users_textBox_search.Text, cols);
    }

    // Adds a user to the database
    private void AddUser(object sender, EventArgs e)
    {
        AddUser addUser = new(_isAdmin);
        addUser.ShowDialog();
        RefreshUsers(sender, e);
    }

    // Edit the selected user from the grid and then updates it in the database
    private void EditUser(object sender, EventArgs e)
    {
        if (users_grid.SelectedRows.Count != 1)
        {
            MessageBox.Show("You must select ONE user to edit!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        EditUser editUser = new(users_grid);
        editUser.ShowDialog();
        RefreshUsers(sender, e);
    }

    // Removes user from the database - Marks the book as returned
    private void RemoveUsers(object sender, EventArgs e)
    {
        List<string> selectedUsernames = [];
        foreach (DataGridViewRow row in users_grid.SelectedRows)
        {
            string username = (string)row.Cells["users_username"].Value;
            selectedUsernames.Add(username);
        }

        RemoveUser removeUser = new(selectedUsernames);
        removeUser.ShowDialog();
        RefreshUsers(sender, e);
    }
    #endregion

    // Hides every panel so there will be room for the opened panel
    private void HidePanels()
    {
        panel_dashboard.Visible = false;
        panel_dashboard.Enabled = false;
        panel_books.Visible = false;
        panel_books.Enabled = false;
        panel_borrowings.Visible = false;
        panel_borrowings.Enabled = false;
        panel_reservations.Visible = false;
        panel_reservations.Enabled = false;
        panel_categories.Visible = false;
        panel_categories.Enabled = false;
        panel_users.Visible = false;
        panel_users.Enabled = false;
        panel_authors.Visible = false;
        panel_authors.Enabled = false;
        panel_publishers.Visible = false;
        panel_publishers.Enabled = false;
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