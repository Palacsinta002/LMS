using Desktop_Application.Components;

namespace Desktop_Application
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            panel_menu = new Panel();
            button_dashboard = new Button();
            button_books = new Button();
            button_borrowings = new Button();
            button_reservations = new Button();
            button_categories = new Button();
            button_authors = new Button();
            button_publishers = new Button();
            button_users = new Button();
            rButton_logout = new RoundedButton();
            panel_divider1 = new Panel();
            panel_divider2 = new Panel();
            panel_divider3 = new Panel();
            panel_divider4 = new Panel();
            panel_divider5 = new Panel();
            panel_divider6 = new Panel();
            panel_divider7 = new Panel();
            label_noOfBooks = new Label();
            panel_header = new Panel();
            label_greeting = new Label();
            label_title = new Label();
            panel_dashboard = new Panel();
            panel_noOfBooks = new Panel();
            rButton_noOfBooks = new RoundedButton();
            panel_noOfUsers = new Panel();
            label_noOfUsers = new Label();
            rButton_noOfUsers = new RoundedButton();
            panel_noOfBorrowings = new Panel();
            label_noOfBorrowings = new Label();
            rButton_noOfBorrowings = new RoundedButton();
            panel_topBorrowedBooks = new Panel();
            label_topBorrowedBooks = new Label();
            dashboard_grid = new DataGridView();
            dashboard_count = new DataGridViewTextBoxColumn();
            dashboard_title = new DataGridViewTextBoxColumn();
            dashboard_author = new DataGridViewTextBoxColumn();
            dashboard_publicationYear = new DataGridViewTextBoxColumn();
            dashboard_category = new DataGridViewTextBoxColumn();
            panel_books = new Panel();
            books_rBtton_refresh = new RoundedButton();
            books_rButton_add = new RoundedButton();
            books_rButton_edit = new RoundedButton();
            books_rButton_remove = new RoundedButton();
            books_textBox_search = new TextBox();
            books_label = new Label();
            books_grid = new DataGridView();
            books_title = new DataGridViewTextBoxColumn();
            books_author = new DataGridViewTextBoxColumn();
            books_publicationYear = new DataGridViewTextBoxColumn();
            books_category = new DataGridViewTextBoxColumn();
            books_publisher = new DataGridViewTextBoxColumn();
            books_isbn = new DataGridViewTextBoxColumn();
            panel_borrowings = new Panel();
            borrowings_rButton_refresh = new RoundedButton();
            borrowings_rButton_lend = new RoundedButton();
            borrowings_rButton_extend = new RoundedButton();
            borrowings_rButton_return = new RoundedButton();
            borrowings_textBox_search = new TextBox();
            borrowings_label = new Label();
            borrowings_checkBox_currentBorrowings = new CheckBox();
            borrowings_grid = new DataGridView();
            borrowings_username = new DataGridViewTextBoxColumn();
            borrowings_title = new DataGridViewTextBoxColumn();
            borrowings_isbn = new DataGridViewTextBoxColumn();
            borrowings_borrowDate = new DataGridViewTextBoxColumn();
            borrowings_dueDate = new DataGridViewTextBoxColumn();
            borrowings_returnDate = new DataGridViewTextBoxColumn();
            panel_categories = new Panel();
            categories_rButton_refresh = new RoundedButton();
            categories_rButton_add = new RoundedButton();
            categories_rButton_edit = new RoundedButton();
            categories_rButton_remove = new RoundedButton();
            categories_textBox_search = new TextBox();
            categories_label = new Label();
            categories_grid = new DataGridView();
            categories_category = new DataGridViewTextBoxColumn();
            panel_users = new Panel();
            users_rButton_refresh = new RoundedButton();
            users_rButton_add = new RoundedButton();
            users_rButton_edit = new RoundedButton();
            users_rButton_remove = new RoundedButton();
            users_textBox_search = new TextBox();
            users_label = new Label();
            users_grid = new DataGridView();
            users_firstName = new DataGridViewTextBoxColumn();
            users_lastName = new DataGridViewTextBoxColumn();
            users_dateOfBirth = new DataGridViewTextBoxColumn();
            users_address = new DataGridViewTextBoxColumn();
            users_verified = new DataGridViewTextBoxColumn();
            users_username = new DataGridViewTextBoxColumn();
            users_email = new DataGridViewTextBoxColumn();
            users_role = new DataGridViewTextBoxColumn();
            panel_authors = new Panel();
            authors_rButton_refresh = new RoundedButton();
            authors_rButton_add = new RoundedButton();
            authors_rButton_edit = new RoundedButton();
            authors_rButton_remove = new RoundedButton();
            authors_textBox_search = new TextBox();
            authors_label = new Label();
            authors_grid = new DataGridView();
            authors_author = new DataGridViewTextBoxColumn();
            panel_publishers = new Panel();
            publishers_rButton_refresh = new RoundedButton();
            publishers_rButton_add = new RoundedButton();
            publishers_rButton_edit = new RoundedButton();
            publishers_rButton_remove = new RoundedButton();
            publishers_textBox_search = new TextBox();
            publishers_label = new Label();
            publishers_grid = new DataGridView();
            publishers_publisher = new DataGridViewTextBoxColumn();
            panel_reservations = new Panel();
            reservations_rButton_refresh = new RoundedButton();
            reservations_rButton_add = new RoundedButton();
            reservations_rButton_extend = new RoundedButton();
            reservations_rButton_remove = new RoundedButton();
            reservations_textBox_search = new TextBox();
            reservations_label = new Label();
            reservations_grid = new DataGridView();
            reservations_username = new DataGridViewTextBoxColumn();
            reservations_title = new DataGridViewTextBoxColumn();
            reservations_isbn = new DataGridViewTextBoxColumn();
            reservations_startDate = new DataGridViewTextBoxColumn();
            reservations_endDate = new DataGridViewTextBoxColumn();
            panel_menu.SuspendLayout();
            panel_header.SuspendLayout();
            panel_dashboard.SuspendLayout();
            panel_noOfBooks.SuspendLayout();
            panel_noOfUsers.SuspendLayout();
            panel_noOfBorrowings.SuspendLayout();
            panel_topBorrowedBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dashboard_grid).BeginInit();
            panel_books.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)books_grid).BeginInit();
            panel_borrowings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)borrowings_grid).BeginInit();
            panel_categories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)categories_grid).BeginInit();
            panel_users.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)users_grid).BeginInit();
            panel_authors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)authors_grid).BeginInit();
            panel_publishers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)publishers_grid).BeginInit();
            panel_reservations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)reservations_grid).BeginInit();
            SuspendLayout();
            // 
            // panel_menu
            // 
            panel_menu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel_menu.BackColor = Color.FromArgb(80, 77, 180);
            panel_menu.Controls.Add(button_dashboard);
            panel_menu.Controls.Add(button_books);
            panel_menu.Controls.Add(button_borrowings);
            panel_menu.Controls.Add(button_reservations);
            panel_menu.Controls.Add(button_categories);
            panel_menu.Controls.Add(button_authors);
            panel_menu.Controls.Add(button_publishers);
            panel_menu.Controls.Add(button_users);
            panel_menu.Controls.Add(rButton_logout);
            panel_menu.Controls.Add(panel_divider1);
            panel_menu.Controls.Add(panel_divider2);
            panel_menu.Controls.Add(panel_divider3);
            panel_menu.Controls.Add(panel_divider4);
            panel_menu.Controls.Add(panel_divider5);
            panel_menu.Controls.Add(panel_divider6);
            panel_menu.Controls.Add(panel_divider7);
            panel_menu.Location = new Point(0, 0);
            panel_menu.MinimumSize = new Size(263, 561);
            panel_menu.Name = "panel_menu";
            panel_menu.Size = new Size(263, 561);
            panel_menu.TabIndex = 9;
            // 
            // button_dashboard
            // 
            button_dashboard.AutoSize = true;
            button_dashboard.BackColor = Color.FromArgb(80, 77, 180);
            button_dashboard.FlatAppearance.BorderSize = 0;
            button_dashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            button_dashboard.FlatStyle = FlatStyle.Flat;
            button_dashboard.Font = new Font("Yu Gothic UI Semibold", 14F);
            button_dashboard.ForeColor = Color.White;
            button_dashboard.Location = new Point(0, 101);
            button_dashboard.Name = "button_dashboard";
            button_dashboard.Size = new Size(263, 42);
            button_dashboard.TabIndex = 2;
            button_dashboard.Text = "Dashboard";
            button_dashboard.UseVisualStyleBackColor = false;
            button_dashboard.Click += ShowDashboard;
            // 
            // button_books
            // 
            button_books.AutoSize = true;
            button_books.BackColor = Color.FromArgb(80, 77, 180);
            button_books.FlatAppearance.BorderSize = 0;
            button_books.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            button_books.FlatStyle = FlatStyle.Flat;
            button_books.Font = new Font("Yu Gothic UI Semibold", 14F);
            button_books.ForeColor = Color.White;
            button_books.Location = new Point(0, 144);
            button_books.Name = "button_books";
            button_books.Size = new Size(263, 42);
            button_books.TabIndex = 3;
            button_books.Text = "Books";
            button_books.UseVisualStyleBackColor = false;
            button_books.Click += ShowBooks;
            // 
            // button_borrowings
            // 
            button_borrowings.AutoSize = true;
            button_borrowings.BackColor = Color.FromArgb(80, 77, 180);
            button_borrowings.FlatAppearance.BorderSize = 0;
            button_borrowings.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            button_borrowings.FlatStyle = FlatStyle.Flat;
            button_borrowings.Font = new Font("Yu Gothic UI Semibold", 14F);
            button_borrowings.ForeColor = Color.White;
            button_borrowings.Location = new Point(0, 187);
            button_borrowings.Name = "button_borrowings";
            button_borrowings.Size = new Size(263, 42);
            button_borrowings.TabIndex = 4;
            button_borrowings.Text = "Borrowings";
            button_borrowings.UseVisualStyleBackColor = false;
            button_borrowings.Click += ShowBorrowings;
            // 
            // button_reservations
            // 
            button_reservations.AutoSize = true;
            button_reservations.BackColor = Color.FromArgb(80, 77, 180);
            button_reservations.FlatAppearance.BorderSize = 0;
            button_reservations.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            button_reservations.FlatStyle = FlatStyle.Flat;
            button_reservations.Font = new Font("Yu Gothic UI Semibold", 14F);
            button_reservations.ForeColor = Color.White;
            button_reservations.Location = new Point(0, 230);
            button_reservations.Name = "button_reservations";
            button_reservations.Size = new Size(263, 42);
            button_reservations.TabIndex = 5;
            button_reservations.Text = "Reservations";
            button_reservations.UseVisualStyleBackColor = false;
            button_reservations.Click += ShowReservations;
            // 
            // button_categories
            // 
            button_categories.AutoSize = true;
            button_categories.BackColor = Color.FromArgb(80, 77, 180);
            button_categories.FlatAppearance.BorderSize = 0;
            button_categories.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            button_categories.FlatStyle = FlatStyle.Flat;
            button_categories.Font = new Font("Yu Gothic UI Semibold", 14F);
            button_categories.ForeColor = Color.White;
            button_categories.Location = new Point(0, 273);
            button_categories.Name = "button_categories";
            button_categories.Size = new Size(263, 42);
            button_categories.TabIndex = 6;
            button_categories.Text = "Categories";
            button_categories.UseVisualStyleBackColor = false;
            button_categories.Click += ShowCategories;
            // 
            // button_authors
            // 
            button_authors.AutoSize = true;
            button_authors.BackColor = Color.FromArgb(80, 77, 180);
            button_authors.FlatAppearance.BorderSize = 0;
            button_authors.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            button_authors.FlatStyle = FlatStyle.Flat;
            button_authors.Font = new Font("Yu Gothic UI Semibold", 14F);
            button_authors.ForeColor = Color.White;
            button_authors.Location = new Point(0, 316);
            button_authors.Name = "button_authors";
            button_authors.Size = new Size(263, 42);
            button_authors.TabIndex = 7;
            button_authors.Text = "Authors";
            button_authors.UseVisualStyleBackColor = false;
            button_authors.Click += ShowAuthors;
            // 
            // button_publishers
            // 
            button_publishers.AutoSize = true;
            button_publishers.BackColor = Color.FromArgb(80, 77, 180);
            button_publishers.FlatAppearance.BorderSize = 0;
            button_publishers.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            button_publishers.FlatStyle = FlatStyle.Flat;
            button_publishers.Font = new Font("Yu Gothic UI Semibold", 14F);
            button_publishers.ForeColor = Color.White;
            button_publishers.Location = new Point(0, 359);
            button_publishers.Name = "button_publishers";
            button_publishers.Size = new Size(263, 42);
            button_publishers.TabIndex = 8;
            button_publishers.Text = "Publishers";
            button_publishers.UseVisualStyleBackColor = false;
            button_publishers.Click += ShowPublishers;
            // 
            // button_users
            // 
            button_users.AutoSize = true;
            button_users.BackColor = Color.FromArgb(80, 77, 180);
            button_users.FlatAppearance.BorderSize = 0;
            button_users.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            button_users.FlatStyle = FlatStyle.Flat;
            button_users.Font = new Font("Yu Gothic UI Semibold", 14F);
            button_users.ForeColor = Color.White;
            button_users.Location = new Point(0, 402);
            button_users.Name = "button_users";
            button_users.Size = new Size(263, 42);
            button_users.TabIndex = 9;
            button_users.Text = "Users";
            button_users.UseVisualStyleBackColor = false;
            button_users.Click += ShowUsers;
            // 
            // rButton_logout
            // 
            rButton_logout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            rButton_logout.BackColor = Color.White;
            rButton_logout.BackgroundColor = Color.White;
            rButton_logout.BorderColor = Color.Transparent;
            rButton_logout.BorderRadius = 5;
            rButton_logout.BorderSize = 0;
            rButton_logout.FlatAppearance.BorderSize = 0;
            rButton_logout.FlatAppearance.MouseDownBackColor = Color.Silver;
            rButton_logout.FlatStyle = FlatStyle.Flat;
            rButton_logout.Font = new Font("Yu Gothic UI Semibold", 14F);
            rButton_logout.ForeColor = Color.Black;
            rButton_logout.Location = new Point(82, 475);
            rButton_logout.Name = "rButton_logout";
            rButton_logout.Size = new Size(96, 36);
            rButton_logout.TabIndex = 10;
            rButton_logout.Text = "Logout";
            rButton_logout.TextColor = Color.Black;
            rButton_logout.UseVisualStyleBackColor = false;
            rButton_logout.Click += Logout;
            // 
            // panel_divider1
            // 
            panel_divider1.AutoSize = true;
            panel_divider1.BackColor = Color.White;
            panel_divider1.Location = new Point(33, 143);
            panel_divider1.Name = "panel_divider1";
            panel_divider1.Size = new Size(200, 1);
            panel_divider1.TabIndex = 24;
            // 
            // panel_divider2
            // 
            panel_divider2.AutoSize = true;
            panel_divider2.BackColor = Color.White;
            panel_divider2.Location = new Point(33, 186);
            panel_divider2.Name = "panel_divider2";
            panel_divider2.Size = new Size(200, 1);
            panel_divider2.TabIndex = 25;
            // 
            // panel_divider3
            // 
            panel_divider3.AutoSize = true;
            panel_divider3.BackColor = Color.White;
            panel_divider3.Location = new Point(33, 229);
            panel_divider3.Name = "panel_divider3";
            panel_divider3.Size = new Size(200, 1);
            panel_divider3.TabIndex = 33;
            // 
            // panel_divider4
            // 
            panel_divider4.AutoSize = true;
            panel_divider4.BackColor = Color.White;
            panel_divider4.Location = new Point(33, 272);
            panel_divider4.Name = "panel_divider4";
            panel_divider4.Size = new Size(200, 1);
            panel_divider4.TabIndex = 26;
            // 
            // panel_divider5
            // 
            panel_divider5.AutoSize = true;
            panel_divider5.BackColor = Color.White;
            panel_divider5.Location = new Point(33, 315);
            panel_divider5.Name = "panel_divider5";
            panel_divider5.Size = new Size(200, 1);
            panel_divider5.TabIndex = 29;
            // 
            // panel_divider6
            // 
            panel_divider6.AutoSize = true;
            panel_divider6.BackColor = Color.White;
            panel_divider6.Location = new Point(33, 358);
            panel_divider6.Name = "panel_divider6";
            panel_divider6.Size = new Size(200, 1);
            panel_divider6.TabIndex = 31;
            // 
            // panel_divider7
            // 
            panel_divider7.AutoSize = true;
            panel_divider7.BackColor = Color.White;
            panel_divider7.Location = new Point(33, 401);
            panel_divider7.Name = "panel_divider7";
            panel_divider7.Size = new Size(200, 1);
            panel_divider7.TabIndex = 27;
            // 
            // label_noOfBooks
            // 
            label_noOfBooks.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_noOfBooks.Font = new Font("Yu Gothic UI Semibold", 12F);
            label_noOfBooks.ForeColor = Color.Black;
            label_noOfBooks.Location = new Point(22, 6);
            label_noOfBooks.Margin = new Padding(0);
            label_noOfBooks.Name = "label_noOfBooks";
            label_noOfBooks.Size = new Size(164, 21);
            label_noOfBooks.TabIndex = 11;
            label_noOfBooks.Text = "No. of Books";
            // 
            // panel_header
            // 
            panel_header.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel_header.AutoScroll = true;
            panel_header.BackColor = Color.FromArgb(72, 69, 158);
            panel_header.Controls.Add(label_greeting);
            panel_header.Controls.Add(label_title);
            panel_header.Location = new Point(0, 0);
            panel_header.Name = "panel_header";
            panel_header.Size = new Size(985, 50);
            panel_header.TabIndex = 11;
            // 
            // label_greeting
            // 
            label_greeting.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label_greeting.Cursor = Cursors.Hand;
            label_greeting.Font = new Font("Yu Gothic UI Semibold", 16F);
            label_greeting.ForeColor = Color.White;
            label_greeting.Location = new Point(338, 9);
            label_greeting.Name = "label_greeting";
            label_greeting.Size = new Size(644, 30);
            label_greeting.TabIndex = 1;
            label_greeting.Text = "Hello, Admin 🐱‍🚀";
            label_greeting.TextAlign = ContentAlignment.TopRight;
            label_greeting.Click += OpenProfileSettings;
            // 
            // label_title
            // 
            label_title.AutoSize = true;
            label_title.Cursor = Cursors.Hand;
            label_title.Font = new Font("Yu Gothic UI Semibold", 16F);
            label_title.ForeColor = Color.White;
            label_title.Location = new Point(11, 9);
            label_title.Name = "label_title";
            label_title.Size = new Size(296, 30);
            label_title.TabIndex = 0;
            label_title.Text = "Library Management System";
            label_title.Click += ShowDashboard;
            // 
            // panel_dashboard
            // 
            panel_dashboard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_dashboard.AutoScroll = true;
            panel_dashboard.Controls.Add(panel_noOfBooks);
            panel_dashboard.Controls.Add(panel_noOfUsers);
            panel_dashboard.Controls.Add(panel_noOfBorrowings);
            panel_dashboard.Controls.Add(panel_topBorrowedBooks);
            panel_dashboard.Location = new Point(266, 56);
            panel_dashboard.Name = "panel_dashboard";
            panel_dashboard.Size = new Size(709, 493);
            panel_dashboard.TabIndex = 12;
            panel_dashboard.Visible = false;
            // 
            // panel_noOfBooks
            // 
            panel_noOfBooks.Anchor = AnchorStyles.Top;
            panel_noOfBooks.AutoSize = true;
            panel_noOfBooks.Controls.Add(label_noOfBooks);
            panel_noOfBooks.Controls.Add(rButton_noOfBooks);
            panel_noOfBooks.Location = new Point(54, 30);
            panel_noOfBooks.Name = "panel_noOfBooks";
            panel_noOfBooks.Size = new Size(200, 100);
            panel_noOfBooks.TabIndex = 22;
            // 
            // rButton_noOfBooks
            // 
            rButton_noOfBooks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rButton_noOfBooks.AutoSize = true;
            rButton_noOfBooks.BackColor = Color.FromArgb(80, 77, 180);
            rButton_noOfBooks.BackgroundColor = Color.FromArgb(80, 77, 180);
            rButton_noOfBooks.BorderColor = Color.Transparent;
            rButton_noOfBooks.BorderRadius = 10;
            rButton_noOfBooks.BorderSize = 0;
            rButton_noOfBooks.FlatAppearance.BorderSize = 0;
            rButton_noOfBooks.FlatAppearance.MouseDownBackColor = Color.FromArgb(80, 77, 180);
            rButton_noOfBooks.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 77, 180);
            rButton_noOfBooks.FlatStyle = FlatStyle.Flat;
            rButton_noOfBooks.Font = new Font("Yu Gothic UI Semibold", 22F);
            rButton_noOfBooks.ForeColor = Color.White;
            rButton_noOfBooks.Location = new Point(15, 30);
            rButton_noOfBooks.MaximumSize = new Size(250, 100);
            rButton_noOfBooks.Name = "rButton_noOfBooks";
            rButton_noOfBooks.Size = new Size(171, 63);
            rButton_noOfBooks.TabIndex = 19;
            rButton_noOfBooks.TabStop = false;
            rButton_noOfBooks.Text = "0";
            rButton_noOfBooks.TextColor = Color.White;
            rButton_noOfBooks.UseVisualStyleBackColor = false;
            // 
            // panel_noOfUsers
            // 
            panel_noOfUsers.Anchor = AnchorStyles.Top;
            panel_noOfUsers.AutoSize = true;
            panel_noOfUsers.Controls.Add(label_noOfUsers);
            panel_noOfUsers.Controls.Add(rButton_noOfUsers);
            panel_noOfUsers.Location = new Point(256, 30);
            panel_noOfUsers.Name = "panel_noOfUsers";
            panel_noOfUsers.Size = new Size(200, 100);
            panel_noOfUsers.TabIndex = 23;
            // 
            // label_noOfUsers
            // 
            label_noOfUsers.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_noOfUsers.Font = new Font("Yu Gothic UI Semibold", 12F);
            label_noOfUsers.ForeColor = Color.Black;
            label_noOfUsers.Location = new Point(22, 6);
            label_noOfUsers.Margin = new Padding(0);
            label_noOfUsers.Name = "label_noOfUsers";
            label_noOfUsers.Size = new Size(164, 21);
            label_noOfUsers.TabIndex = 11;
            label_noOfUsers.Text = "No. of Users";
            // 
            // rButton_noOfUsers
            // 
            rButton_noOfUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rButton_noOfUsers.AutoSize = true;
            rButton_noOfUsers.BackColor = Color.FromArgb(80, 77, 180);
            rButton_noOfUsers.BackgroundColor = Color.FromArgb(80, 77, 180);
            rButton_noOfUsers.BorderColor = Color.Transparent;
            rButton_noOfUsers.BorderRadius = 10;
            rButton_noOfUsers.BorderSize = 0;
            rButton_noOfUsers.FlatAppearance.BorderSize = 0;
            rButton_noOfUsers.FlatAppearance.MouseDownBackColor = Color.FromArgb(80, 77, 180);
            rButton_noOfUsers.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 77, 180);
            rButton_noOfUsers.FlatStyle = FlatStyle.Flat;
            rButton_noOfUsers.Font = new Font("Yu Gothic UI Semibold", 22F);
            rButton_noOfUsers.ForeColor = Color.White;
            rButton_noOfUsers.Location = new Point(15, 30);
            rButton_noOfUsers.MaximumSize = new Size(250, 100);
            rButton_noOfUsers.Name = "rButton_noOfUsers";
            rButton_noOfUsers.Size = new Size(171, 63);
            rButton_noOfUsers.TabIndex = 19;
            rButton_noOfUsers.TabStop = false;
            rButton_noOfUsers.Text = "0";
            rButton_noOfUsers.TextColor = Color.White;
            rButton_noOfUsers.UseVisualStyleBackColor = false;
            // 
            // panel_noOfBorrowings
            // 
            panel_noOfBorrowings.Anchor = AnchorStyles.Top;
            panel_noOfBorrowings.AutoSize = true;
            panel_noOfBorrowings.Controls.Add(label_noOfBorrowings);
            panel_noOfBorrowings.Controls.Add(rButton_noOfBorrowings);
            panel_noOfBorrowings.Location = new Point(458, 30);
            panel_noOfBorrowings.Name = "panel_noOfBorrowings";
            panel_noOfBorrowings.Size = new Size(200, 100);
            panel_noOfBorrowings.TabIndex = 23;
            // 
            // label_noOfBorrowings
            // 
            label_noOfBorrowings.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_noOfBorrowings.Font = new Font("Yu Gothic UI Semibold", 12F);
            label_noOfBorrowings.ForeColor = Color.Black;
            label_noOfBorrowings.Location = new Point(22, 6);
            label_noOfBorrowings.Margin = new Padding(0);
            label_noOfBorrowings.Name = "label_noOfBorrowings";
            label_noOfBorrowings.Size = new Size(164, 21);
            label_noOfBorrowings.TabIndex = 11;
            label_noOfBorrowings.Text = "No. of Borrowings";
            // 
            // rButton_noOfBorrowings
            // 
            rButton_noOfBorrowings.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rButton_noOfBorrowings.AutoSize = true;
            rButton_noOfBorrowings.BackColor = Color.FromArgb(80, 77, 180);
            rButton_noOfBorrowings.BackgroundColor = Color.FromArgb(80, 77, 180);
            rButton_noOfBorrowings.BorderColor = Color.Transparent;
            rButton_noOfBorrowings.BorderRadius = 10;
            rButton_noOfBorrowings.BorderSize = 0;
            rButton_noOfBorrowings.FlatAppearance.BorderSize = 0;
            rButton_noOfBorrowings.FlatAppearance.MouseDownBackColor = Color.FromArgb(80, 77, 180);
            rButton_noOfBorrowings.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 77, 180);
            rButton_noOfBorrowings.FlatStyle = FlatStyle.Flat;
            rButton_noOfBorrowings.Font = new Font("Yu Gothic UI Semibold", 22F);
            rButton_noOfBorrowings.ForeColor = Color.White;
            rButton_noOfBorrowings.Location = new Point(15, 30);
            rButton_noOfBorrowings.MaximumSize = new Size(250, 100);
            rButton_noOfBorrowings.Name = "rButton_noOfBorrowings";
            rButton_noOfBorrowings.Size = new Size(171, 63);
            rButton_noOfBorrowings.TabIndex = 19;
            rButton_noOfBorrowings.TabStop = false;
            rButton_noOfBorrowings.Text = "0";
            rButton_noOfBorrowings.TextColor = Color.White;
            rButton_noOfBorrowings.UseVisualStyleBackColor = false;
            // 
            // panel_topBorrowedBooks
            // 
            panel_topBorrowedBooks.Anchor = AnchorStyles.Top;
            panel_topBorrowedBooks.Controls.Add(label_topBorrowedBooks);
            panel_topBorrowedBooks.Controls.Add(dashboard_grid);
            panel_topBorrowedBooks.Location = new Point(39, 144);
            panel_topBorrowedBooks.Name = "panel_topBorrowedBooks";
            panel_topBorrowedBooks.Size = new Size(635, 335);
            panel_topBorrowedBooks.TabIndex = 24;
            // 
            // label_topBorrowedBooks
            // 
            label_topBorrowedBooks.AutoSize = true;
            label_topBorrowedBooks.Font = new Font("Yu Gothic UI Semibold", 12F);
            label_topBorrowedBooks.ForeColor = Color.Black;
            label_topBorrowedBooks.Location = new Point(13, 8);
            label_topBorrowedBooks.Margin = new Padding(0);
            label_topBorrowedBooks.Name = "label_topBorrowedBooks";
            label_topBorrowedBooks.Size = new Size(163, 21);
            label_topBorrowedBooks.TabIndex = 17;
            label_topBorrowedBooks.Text = "Top Borrowed Books";
            // 
            // dashboard_grid
            // 
            dashboard_grid.AllowUserToAddRows = false;
            dashboard_grid.AllowUserToDeleteRows = false;
            dashboard_grid.AllowUserToResizeColumns = false;
            dashboard_grid.AllowUserToResizeRows = false;
            dashboard_grid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dashboard_grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dashboard_grid.BackgroundColor = Color.FromArgb(224, 224, 224);
            dashboard_grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dashboard_grid.Columns.AddRange(new DataGridViewColumn[] { dashboard_count, dashboard_title, dashboard_author, dashboard_publicationYear, dashboard_category });
            dashboard_grid.Location = new Point(15, 32);
            dashboard_grid.Name = "dashboard_grid";
            dashboard_grid.ReadOnly = true;
            dashboard_grid.RowHeadersVisible = false;
            dashboard_grid.RowHeadersWidth = 51;
            dashboard_grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dashboard_grid.ShowCellErrors = false;
            dashboard_grid.ShowCellToolTips = false;
            dashboard_grid.ShowEditingIcon = false;
            dashboard_grid.ShowRowErrors = false;
            dashboard_grid.Size = new Size(604, 290);
            dashboard_grid.StandardTab = true;
            dashboard_grid.TabIndex = 1;
            // 
            // dashboard_count
            // 
            dashboard_count.HeaderText = "#";
            dashboard_count.MinimumWidth = 6;
            dashboard_count.Name = "dashboard_count";
            dashboard_count.ReadOnly = true;
            dashboard_count.Width = 39;
            // 
            // dashboard_title
            // 
            dashboard_title.HeaderText = "Title";
            dashboard_title.MinimumWidth = 6;
            dashboard_title.Name = "dashboard_title";
            dashboard_title.ReadOnly = true;
            dashboard_title.Width = 54;
            // 
            // dashboard_author
            // 
            dashboard_author.HeaderText = "Author";
            dashboard_author.MinimumWidth = 6;
            dashboard_author.Name = "dashboard_author";
            dashboard_author.ReadOnly = true;
            dashboard_author.Width = 69;
            // 
            // dashboard_publicationYear
            // 
            dashboard_publicationYear.HeaderText = "Publication Year";
            dashboard_publicationYear.MinimumWidth = 6;
            dashboard_publicationYear.Name = "dashboard_publicationYear";
            dashboard_publicationYear.ReadOnly = true;
            dashboard_publicationYear.Width = 107;
            // 
            // dashboard_category
            // 
            dashboard_category.HeaderText = "Category";
            dashboard_category.MinimumWidth = 6;
            dashboard_category.Name = "dashboard_category";
            dashboard_category.ReadOnly = true;
            dashboard_category.Width = 80;
            // 
            // panel_books
            // 
            panel_books.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_books.Controls.Add(books_rBtton_refresh);
            panel_books.Controls.Add(books_rButton_add);
            panel_books.Controls.Add(books_rButton_edit);
            panel_books.Controls.Add(books_rButton_remove);
            panel_books.Controls.Add(books_textBox_search);
            panel_books.Controls.Add(books_label);
            panel_books.Controls.Add(books_grid);
            panel_books.Location = new Point(266, 56);
            panel_books.Name = "panel_books";
            panel_books.Size = new Size(709, 493);
            panel_books.TabIndex = 13;
            panel_books.Visible = false;
            // 
            // books_rBtton_refresh
            // 
            books_rBtton_refresh.BackColor = Color.FromArgb(80, 77, 180);
            books_rBtton_refresh.BackgroundColor = Color.FromArgb(80, 77, 180);
            books_rBtton_refresh.BorderColor = Color.Transparent;
            books_rBtton_refresh.BorderRadius = 5;
            books_rBtton_refresh.BorderSize = 0;
            books_rBtton_refresh.FlatAppearance.BorderSize = 0;
            books_rBtton_refresh.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            books_rBtton_refresh.FlatStyle = FlatStyle.Flat;
            books_rBtton_refresh.Font = new Font("Yu Gothic UI Semibold", 14F);
            books_rBtton_refresh.ForeColor = Color.White;
            books_rBtton_refresh.Image = (Image)resources.GetObject("books_rBtton_refresh.Image");
            books_rBtton_refresh.Location = new Point(52, 26);
            books_rBtton_refresh.Name = "books_rBtton_refresh";
            books_rBtton_refresh.Size = new Size(42, 36);
            books_rBtton_refresh.TabIndex = 12;
            books_rBtton_refresh.TextColor = Color.White;
            books_rBtton_refresh.UseVisualStyleBackColor = false;
            books_rBtton_refresh.Click += RefreshBooks;
            // 
            // books_rButton_add
            // 
            books_rButton_add.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            books_rButton_add.BackColor = Color.FromArgb(80, 77, 180);
            books_rButton_add.BackgroundColor = Color.FromArgb(80, 77, 180);
            books_rButton_add.BorderColor = Color.Transparent;
            books_rButton_add.BorderRadius = 5;
            books_rButton_add.BorderSize = 0;
            books_rButton_add.FlatAppearance.BorderSize = 0;
            books_rButton_add.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            books_rButton_add.FlatStyle = FlatStyle.Flat;
            books_rButton_add.Font = new Font("Yu Gothic UI Semibold", 14F);
            books_rButton_add.ForeColor = Color.White;
            books_rButton_add.Location = new Point(132, 26);
            books_rButton_add.Name = "books_rButton_add";
            books_rButton_add.Size = new Size(100, 36);
            books_rButton_add.TabIndex = 15;
            books_rButton_add.Text = "Add";
            books_rButton_add.TextColor = Color.White;
            books_rButton_add.UseVisualStyleBackColor = false;
            books_rButton_add.Click += AddBook;
            // 
            // books_rButton_edit
            // 
            books_rButton_edit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            books_rButton_edit.BackColor = Color.FromArgb(80, 77, 180);
            books_rButton_edit.BackgroundColor = Color.FromArgb(80, 77, 180);
            books_rButton_edit.BorderColor = Color.Transparent;
            books_rButton_edit.BorderRadius = 5;
            books_rButton_edit.BorderSize = 0;
            books_rButton_edit.FlatAppearance.BorderSize = 0;
            books_rButton_edit.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            books_rButton_edit.FlatStyle = FlatStyle.Flat;
            books_rButton_edit.Font = new Font("Yu Gothic UI Semibold", 14F);
            books_rButton_edit.ForeColor = Color.White;
            books_rButton_edit.Location = new Point(238, 26);
            books_rButton_edit.Name = "books_rButton_edit";
            books_rButton_edit.Size = new Size(100, 36);
            books_rButton_edit.TabIndex = 13;
            books_rButton_edit.Text = "Edit";
            books_rButton_edit.TextColor = Color.White;
            books_rButton_edit.UseVisualStyleBackColor = false;
            books_rButton_edit.Click += EditBook;
            // 
            // books_rButton_remove
            // 
            books_rButton_remove.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            books_rButton_remove.BackColor = Color.FromArgb(80, 77, 180);
            books_rButton_remove.BackgroundColor = Color.FromArgb(80, 77, 180);
            books_rButton_remove.BorderColor = Color.Transparent;
            books_rButton_remove.BorderRadius = 5;
            books_rButton_remove.BorderSize = 0;
            books_rButton_remove.FlatAppearance.BorderSize = 0;
            books_rButton_remove.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            books_rButton_remove.FlatStyle = FlatStyle.Flat;
            books_rButton_remove.Font = new Font("Yu Gothic UI Semibold", 14F);
            books_rButton_remove.ForeColor = Color.White;
            books_rButton_remove.Location = new Point(342, 26);
            books_rButton_remove.Name = "books_rButton_remove";
            books_rButton_remove.Size = new Size(100, 36);
            books_rButton_remove.TabIndex = 14;
            books_rButton_remove.Text = "Remove";
            books_rButton_remove.TextColor = Color.White;
            books_rButton_remove.UseVisualStyleBackColor = false;
            books_rButton_remove.Click += RemoveBooks;
            // 
            // books_textBox_search
            // 
            books_textBox_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            books_textBox_search.BackColor = Color.White;
            books_textBox_search.Font = new Font("Yu Gothic UI Semibold", 14F);
            books_textBox_search.Location = new Point(449, 29);
            books_textBox_search.MaxLength = 19;
            books_textBox_search.Name = "books_textBox_search";
            books_textBox_search.PlaceholderText = "Search...";
            books_textBox_search.Size = new Size(208, 32);
            books_textBox_search.TabIndex = 16;
            books_textBox_search.TextChanged += SearchBooks;
            // 
            // books_label
            // 
            books_label.AutoSize = true;
            books_label.Font = new Font("Yu Gothic UI Semibold", 14F);
            books_label.Location = new Point(52, 80);
            books_label.Name = "books_label";
            books_label.Size = new Size(63, 25);
            books_label.TabIndex = 11;
            books_label.Text = "Books";
            // 
            // books_grid
            // 
            books_grid.AllowUserToAddRows = false;
            books_grid.AllowUserToDeleteRows = false;
            books_grid.AllowUserToResizeColumns = false;
            books_grid.AllowUserToResizeRows = false;
            books_grid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            books_grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            books_grid.BackgroundColor = Color.White;
            books_grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            books_grid.Columns.AddRange(new DataGridViewColumn[] { books_title, books_author, books_publicationYear, books_category, books_publisher, books_isbn });
            books_grid.Location = new Point(52, 108);
            books_grid.Name = "books_grid";
            books_grid.ReadOnly = true;
            books_grid.RowHeadersVisible = false;
            books_grid.RowHeadersWidth = 51;
            books_grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            books_grid.ShowCellErrors = false;
            books_grid.ShowCellToolTips = false;
            books_grid.ShowEditingIcon = false;
            books_grid.ShowRowErrors = false;
            books_grid.Size = new Size(605, 359);
            books_grid.StandardTab = true;
            books_grid.TabIndex = 11;
            // 
            // books_title
            // 
            books_title.HeaderText = "Title";
            books_title.MinimumWidth = 6;
            books_title.Name = "books_title";
            books_title.ReadOnly = true;
            books_title.Width = 54;
            // 
            // books_author
            // 
            books_author.HeaderText = "Author";
            books_author.MinimumWidth = 6;
            books_author.Name = "books_author";
            books_author.ReadOnly = true;
            books_author.Width = 69;
            // 
            // books_publicationYear
            // 
            books_publicationYear.HeaderText = "Publication Year";
            books_publicationYear.MinimumWidth = 6;
            books_publicationYear.Name = "books_publicationYear";
            books_publicationYear.ReadOnly = true;
            books_publicationYear.Width = 107;
            // 
            // books_category
            // 
            books_category.HeaderText = "Categroy";
            books_category.MinimumWidth = 6;
            books_category.Name = "books_category";
            books_category.ReadOnly = true;
            books_category.Width = 80;
            // 
            // books_publisher
            // 
            books_publisher.HeaderText = "Publisher";
            books_publisher.MinimumWidth = 6;
            books_publisher.Name = "books_publisher";
            books_publisher.ReadOnly = true;
            books_publisher.Width = 81;
            // 
            // books_isbn
            // 
            books_isbn.HeaderText = "ISBN";
            books_isbn.MinimumWidth = 6;
            books_isbn.Name = "books_isbn";
            books_isbn.ReadOnly = true;
            books_isbn.Width = 57;
            // 
            // panel_borrowings
            // 
            panel_borrowings.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_borrowings.BackColor = Color.White;
            panel_borrowings.Controls.Add(borrowings_rButton_refresh);
            panel_borrowings.Controls.Add(borrowings_rButton_lend);
            panel_borrowings.Controls.Add(borrowings_rButton_extend);
            panel_borrowings.Controls.Add(borrowings_rButton_return);
            panel_borrowings.Controls.Add(borrowings_textBox_search);
            panel_borrowings.Controls.Add(borrowings_label);
            panel_borrowings.Controls.Add(borrowings_checkBox_currentBorrowings);
            panel_borrowings.Controls.Add(borrowings_grid);
            panel_borrowings.Location = new Point(266, 56);
            panel_borrowings.Name = "panel_borrowings";
            panel_borrowings.Size = new Size(709, 493);
            panel_borrowings.TabIndex = 14;
            panel_borrowings.Visible = false;
            // 
            // borrowings_rButton_refresh
            // 
            borrowings_rButton_refresh.BackColor = Color.FromArgb(80, 77, 180);
            borrowings_rButton_refresh.BackgroundColor = Color.FromArgb(80, 77, 180);
            borrowings_rButton_refresh.BorderColor = Color.Transparent;
            borrowings_rButton_refresh.BorderRadius = 5;
            borrowings_rButton_refresh.BorderSize = 0;
            borrowings_rButton_refresh.FlatAppearance.BorderSize = 0;
            borrowings_rButton_refresh.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            borrowings_rButton_refresh.FlatStyle = FlatStyle.Flat;
            borrowings_rButton_refresh.Font = new Font("Yu Gothic UI Semibold", 14F);
            borrowings_rButton_refresh.ForeColor = Color.White;
            borrowings_rButton_refresh.Image = (Image)resources.GetObject("borrowings_rButton_refresh.Image");
            borrowings_rButton_refresh.Location = new Point(52, 26);
            borrowings_rButton_refresh.Name = "borrowings_rButton_refresh";
            borrowings_rButton_refresh.Size = new Size(42, 36);
            borrowings_rButton_refresh.TabIndex = 12;
            borrowings_rButton_refresh.TextColor = Color.White;
            borrowings_rButton_refresh.UseVisualStyleBackColor = false;
            borrowings_rButton_refresh.Click += RefreshBorrowings;
            // 
            // borrowings_rButton_lend
            // 
            borrowings_rButton_lend.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            borrowings_rButton_lend.BackColor = Color.FromArgb(80, 77, 180);
            borrowings_rButton_lend.BackgroundColor = Color.FromArgb(80, 77, 180);
            borrowings_rButton_lend.BorderColor = Color.Transparent;
            borrowings_rButton_lend.BorderRadius = 5;
            borrowings_rButton_lend.BorderSize = 0;
            borrowings_rButton_lend.FlatAppearance.BorderSize = 0;
            borrowings_rButton_lend.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            borrowings_rButton_lend.FlatStyle = FlatStyle.Flat;
            borrowings_rButton_lend.Font = new Font("Yu Gothic UI Semibold", 14F);
            borrowings_rButton_lend.ForeColor = Color.White;
            borrowings_rButton_lend.Location = new Point(132, 26);
            borrowings_rButton_lend.Name = "borrowings_rButton_lend";
            borrowings_rButton_lend.Size = new Size(100, 36);
            borrowings_rButton_lend.TabIndex = 15;
            borrowings_rButton_lend.Text = "Lend";
            borrowings_rButton_lend.TextColor = Color.White;
            borrowings_rButton_lend.UseVisualStyleBackColor = false;
            borrowings_rButton_lend.Click += AddBorrowing;
            // 
            // borrowings_rButton_extend
            // 
            borrowings_rButton_extend.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            borrowings_rButton_extend.BackColor = Color.FromArgb(80, 77, 180);
            borrowings_rButton_extend.BackgroundColor = Color.FromArgb(80, 77, 180);
            borrowings_rButton_extend.BorderColor = Color.Transparent;
            borrowings_rButton_extend.BorderRadius = 5;
            borrowings_rButton_extend.BorderSize = 0;
            borrowings_rButton_extend.FlatAppearance.BorderSize = 0;
            borrowings_rButton_extend.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            borrowings_rButton_extend.FlatStyle = FlatStyle.Flat;
            borrowings_rButton_extend.Font = new Font("Yu Gothic UI Semibold", 14F);
            borrowings_rButton_extend.ForeColor = Color.White;
            borrowings_rButton_extend.Location = new Point(238, 26);
            borrowings_rButton_extend.Name = "borrowings_rButton_extend";
            borrowings_rButton_extend.Size = new Size(100, 36);
            borrowings_rButton_extend.TabIndex = 13;
            borrowings_rButton_extend.Text = "Extend";
            borrowings_rButton_extend.TextColor = Color.White;
            borrowings_rButton_extend.UseVisualStyleBackColor = false;
            borrowings_rButton_extend.Click += EditBorrowing;
            // 
            // borrowings_rButton_return
            // 
            borrowings_rButton_return.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            borrowings_rButton_return.BackColor = Color.FromArgb(80, 77, 180);
            borrowings_rButton_return.BackgroundColor = Color.FromArgb(80, 77, 180);
            borrowings_rButton_return.BorderColor = Color.Transparent;
            borrowings_rButton_return.BorderRadius = 5;
            borrowings_rButton_return.BorderSize = 0;
            borrowings_rButton_return.FlatAppearance.BorderSize = 0;
            borrowings_rButton_return.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            borrowings_rButton_return.FlatStyle = FlatStyle.Flat;
            borrowings_rButton_return.Font = new Font("Yu Gothic UI Semibold", 14F);
            borrowings_rButton_return.ForeColor = Color.White;
            borrowings_rButton_return.Location = new Point(342, 26);
            borrowings_rButton_return.Name = "borrowings_rButton_return";
            borrowings_rButton_return.Size = new Size(100, 36);
            borrowings_rButton_return.TabIndex = 14;
            borrowings_rButton_return.Text = "Return";
            borrowings_rButton_return.TextColor = Color.White;
            borrowings_rButton_return.UseVisualStyleBackColor = false;
            borrowings_rButton_return.Click += RemoveBorrowings;
            // 
            // borrowings_textBox_search
            // 
            borrowings_textBox_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            borrowings_textBox_search.BackColor = Color.White;
            borrowings_textBox_search.Font = new Font("Yu Gothic UI Semibold", 14F);
            borrowings_textBox_search.Location = new Point(449, 29);
            borrowings_textBox_search.MaxLength = 19;
            borrowings_textBox_search.Name = "borrowings_textBox_search";
            borrowings_textBox_search.PlaceholderText = "Search...";
            borrowings_textBox_search.Size = new Size(208, 32);
            borrowings_textBox_search.TabIndex = 16;
            borrowings_textBox_search.TextChanged += SearchBorrowings;
            // 
            // borrowings_label
            // 
            borrowings_label.AutoSize = true;
            borrowings_label.Font = new Font("Yu Gothic UI Semibold", 14F);
            borrowings_label.Location = new Point(52, 80);
            borrowings_label.Name = "borrowings_label";
            borrowings_label.Size = new Size(108, 25);
            borrowings_label.TabIndex = 25;
            borrowings_label.Text = "Borrowings";
            // 
            // borrowings_checkBox_currentBorrowings
            // 
            borrowings_checkBox_currentBorrowings.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            borrowings_checkBox_currentBorrowings.AutoSize = true;
            borrowings_checkBox_currentBorrowings.Location = new Point(472, 80);
            borrowings_checkBox_currentBorrowings.Name = "borrowings_checkBox_currentBorrowings";
            borrowings_checkBox_currentBorrowings.RightToLeft = RightToLeft.Yes;
            borrowings_checkBox_currentBorrowings.Size = new Size(186, 19);
            borrowings_checkBox_currentBorrowings.TabIndex = 17;
            borrowings_checkBox_currentBorrowings.Text = "Only show current borrowings";
            borrowings_checkBox_currentBorrowings.UseVisualStyleBackColor = true;
            borrowings_checkBox_currentBorrowings.CheckedChanged += RefreshBorrowings;
            // 
            // borrowings_grid
            // 
            borrowings_grid.AllowUserToAddRows = false;
            borrowings_grid.AllowUserToDeleteRows = false;
            borrowings_grid.AllowUserToResizeColumns = false;
            borrowings_grid.AllowUserToResizeRows = false;
            borrowings_grid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            borrowings_grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            borrowings_grid.BackgroundColor = Color.White;
            borrowings_grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            borrowings_grid.Columns.AddRange(new DataGridViewColumn[] { borrowings_username, borrowings_title, borrowings_isbn, borrowings_borrowDate, borrowings_dueDate, borrowings_returnDate });
            borrowings_grid.Location = new Point(52, 108);
            borrowings_grid.Name = "borrowings_grid";
            borrowings_grid.ReadOnly = true;
            borrowings_grid.RowHeadersVisible = false;
            borrowings_grid.RowHeadersWidth = 51;
            borrowings_grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            borrowings_grid.ShowCellErrors = false;
            borrowings_grid.ShowCellToolTips = false;
            borrowings_grid.ShowEditingIcon = false;
            borrowings_grid.ShowRowErrors = false;
            borrowings_grid.Size = new Size(605, 359);
            borrowings_grid.StandardTab = true;
            borrowings_grid.TabIndex = 11;
            // 
            // borrowings_username
            // 
            borrowings_username.HeaderText = "Username";
            borrowings_username.MinimumWidth = 6;
            borrowings_username.Name = "borrowings_username";
            borrowings_username.ReadOnly = true;
            borrowings_username.Width = 85;
            // 
            // borrowings_title
            // 
            borrowings_title.HeaderText = "Title";
            borrowings_title.MinimumWidth = 6;
            borrowings_title.Name = "borrowings_title";
            borrowings_title.ReadOnly = true;
            borrowings_title.Width = 54;
            // 
            // borrowings_isbn
            // 
            borrowings_isbn.HeaderText = "ISBN";
            borrowings_isbn.MinimumWidth = 6;
            borrowings_isbn.Name = "borrowings_isbn";
            borrowings_isbn.ReadOnly = true;
            borrowings_isbn.Width = 57;
            // 
            // borrowings_borrowDate
            // 
            borrowings_borrowDate.HeaderText = "Borrow Date";
            borrowings_borrowDate.MinimumWidth = 6;
            borrowings_borrowDate.Name = "borrowings_borrowDate";
            borrowings_borrowDate.ReadOnly = true;
            borrowings_borrowDate.Width = 97;
            // 
            // borrowings_dueDate
            // 
            borrowings_dueDate.HeaderText = "Due Date";
            borrowings_dueDate.MinimumWidth = 6;
            borrowings_dueDate.Name = "borrowings_dueDate";
            borrowings_dueDate.ReadOnly = true;
            borrowings_dueDate.Width = 80;
            // 
            // borrowings_returnDate
            // 
            borrowings_returnDate.HeaderText = "Return Date";
            borrowings_returnDate.MinimumWidth = 6;
            borrowings_returnDate.Name = "borrowings_returnDate";
            borrowings_returnDate.ReadOnly = true;
            borrowings_returnDate.Width = 94;
            // 
            // panel_categories
            // 
            panel_categories.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_categories.BackColor = Color.White;
            panel_categories.Controls.Add(categories_rButton_refresh);
            panel_categories.Controls.Add(categories_rButton_add);
            panel_categories.Controls.Add(categories_rButton_edit);
            panel_categories.Controls.Add(categories_rButton_remove);
            panel_categories.Controls.Add(categories_textBox_search);
            panel_categories.Controls.Add(categories_label);
            panel_categories.Controls.Add(categories_grid);
            panel_categories.Location = new Point(266, 56);
            panel_categories.Name = "panel_categories";
            panel_categories.Size = new Size(709, 493);
            panel_categories.TabIndex = 23;
            panel_categories.Visible = false;
            // 
            // categories_rButton_refresh
            // 
            categories_rButton_refresh.BackColor = Color.FromArgb(80, 77, 180);
            categories_rButton_refresh.BackgroundColor = Color.FromArgb(80, 77, 180);
            categories_rButton_refresh.BorderColor = Color.Transparent;
            categories_rButton_refresh.BorderRadius = 5;
            categories_rButton_refresh.BorderSize = 0;
            categories_rButton_refresh.FlatAppearance.BorderSize = 0;
            categories_rButton_refresh.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            categories_rButton_refresh.FlatStyle = FlatStyle.Flat;
            categories_rButton_refresh.Font = new Font("Yu Gothic UI Semibold", 14F);
            categories_rButton_refresh.ForeColor = Color.White;
            categories_rButton_refresh.Image = (Image)resources.GetObject("categories_rButton_refresh.Image");
            categories_rButton_refresh.Location = new Point(52, 26);
            categories_rButton_refresh.Name = "categories_rButton_refresh";
            categories_rButton_refresh.Size = new Size(42, 36);
            categories_rButton_refresh.TabIndex = 12;
            categories_rButton_refresh.TextColor = Color.White;
            categories_rButton_refresh.UseVisualStyleBackColor = false;
            categories_rButton_refresh.Click += RefreshCategories;
            // 
            // categories_rButton_add
            // 
            categories_rButton_add.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            categories_rButton_add.BackColor = Color.FromArgb(80, 77, 180);
            categories_rButton_add.BackgroundColor = Color.FromArgb(80, 77, 180);
            categories_rButton_add.BorderColor = Color.Transparent;
            categories_rButton_add.BorderRadius = 5;
            categories_rButton_add.BorderSize = 0;
            categories_rButton_add.FlatAppearance.BorderSize = 0;
            categories_rButton_add.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            categories_rButton_add.FlatStyle = FlatStyle.Flat;
            categories_rButton_add.Font = new Font("Yu Gothic UI Semibold", 14F);
            categories_rButton_add.ForeColor = Color.White;
            categories_rButton_add.Location = new Point(132, 26);
            categories_rButton_add.Name = "categories_rButton_add";
            categories_rButton_add.Size = new Size(100, 36);
            categories_rButton_add.TabIndex = 15;
            categories_rButton_add.Text = "Add";
            categories_rButton_add.TextColor = Color.White;
            categories_rButton_add.UseVisualStyleBackColor = false;
            categories_rButton_add.Click += AddCategory;
            // 
            // categories_rButton_edit
            // 
            categories_rButton_edit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            categories_rButton_edit.BackColor = Color.FromArgb(80, 77, 180);
            categories_rButton_edit.BackgroundColor = Color.FromArgb(80, 77, 180);
            categories_rButton_edit.BorderColor = Color.Transparent;
            categories_rButton_edit.BorderRadius = 5;
            categories_rButton_edit.BorderSize = 0;
            categories_rButton_edit.FlatAppearance.BorderSize = 0;
            categories_rButton_edit.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            categories_rButton_edit.FlatStyle = FlatStyle.Flat;
            categories_rButton_edit.Font = new Font("Yu Gothic UI Semibold", 14F);
            categories_rButton_edit.ForeColor = Color.White;
            categories_rButton_edit.Location = new Point(237, 26);
            categories_rButton_edit.Name = "categories_rButton_edit";
            categories_rButton_edit.Size = new Size(100, 36);
            categories_rButton_edit.TabIndex = 13;
            categories_rButton_edit.Text = "Edit";
            categories_rButton_edit.TextColor = Color.White;
            categories_rButton_edit.UseVisualStyleBackColor = false;
            categories_rButton_edit.Click += EditCategory;
            // 
            // categories_rButton_remove
            // 
            categories_rButton_remove.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            categories_rButton_remove.BackColor = Color.FromArgb(80, 77, 180);
            categories_rButton_remove.BackgroundColor = Color.FromArgb(80, 77, 180);
            categories_rButton_remove.BorderColor = Color.Transparent;
            categories_rButton_remove.BorderRadius = 5;
            categories_rButton_remove.BorderSize = 0;
            categories_rButton_remove.FlatAppearance.BorderSize = 0;
            categories_rButton_remove.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            categories_rButton_remove.FlatStyle = FlatStyle.Flat;
            categories_rButton_remove.Font = new Font("Yu Gothic UI Semibold", 14F);
            categories_rButton_remove.ForeColor = Color.White;
            categories_rButton_remove.Location = new Point(343, 26);
            categories_rButton_remove.Name = "categories_rButton_remove";
            categories_rButton_remove.Size = new Size(100, 36);
            categories_rButton_remove.TabIndex = 14;
            categories_rButton_remove.Text = "Remove";
            categories_rButton_remove.TextColor = Color.White;
            categories_rButton_remove.UseVisualStyleBackColor = false;
            categories_rButton_remove.Click += RemoveCategories;
            // 
            // categories_textBox_search
            // 
            categories_textBox_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            categories_textBox_search.BackColor = Color.White;
            categories_textBox_search.Font = new Font("Yu Gothic UI Semibold", 14F);
            categories_textBox_search.Location = new Point(449, 29);
            categories_textBox_search.MaxLength = 19;
            categories_textBox_search.Name = "categories_textBox_search";
            categories_textBox_search.PlaceholderText = "Search...";
            categories_textBox_search.Size = new Size(208, 32);
            categories_textBox_search.TabIndex = 16;
            categories_textBox_search.TextChanged += SearchCategories;
            // 
            // categories_label
            // 
            categories_label.AutoSize = true;
            categories_label.Font = new Font("Yu Gothic UI Semibold", 14F);
            categories_label.Location = new Point(52, 80);
            categories_label.Name = "categories_label";
            categories_label.Size = new Size(103, 25);
            categories_label.TabIndex = 18;
            categories_label.Text = "Categories";
            // 
            // categories_grid
            // 
            categories_grid.AllowUserToAddRows = false;
            categories_grid.AllowUserToDeleteRows = false;
            categories_grid.AllowUserToResizeColumns = false;
            categories_grid.AllowUserToResizeRows = false;
            categories_grid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            categories_grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            categories_grid.BackgroundColor = Color.White;
            categories_grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            categories_grid.Columns.AddRange(new DataGridViewColumn[] { categories_category });
            categories_grid.Location = new Point(52, 108);
            categories_grid.Name = "categories_grid";
            categories_grid.ReadOnly = true;
            categories_grid.RowHeadersVisible = false;
            categories_grid.RowHeadersWidth = 51;
            categories_grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            categories_grid.ShowCellErrors = false;
            categories_grid.ShowCellToolTips = false;
            categories_grid.ShowEditingIcon = false;
            categories_grid.ShowRowErrors = false;
            categories_grid.Size = new Size(605, 359);
            categories_grid.StandardTab = true;
            categories_grid.TabIndex = 11;
            // 
            // categories_category
            // 
            categories_category.HeaderText = "Category";
            categories_category.MinimumWidth = 6;
            categories_category.Name = "categories_category";
            categories_category.ReadOnly = true;
            categories_category.Width = 80;
            // 
            // panel_users
            // 
            panel_users.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_users.Controls.Add(users_rButton_refresh);
            panel_users.Controls.Add(users_rButton_add);
            panel_users.Controls.Add(users_rButton_edit);
            panel_users.Controls.Add(users_rButton_remove);
            panel_users.Controls.Add(users_textBox_search);
            panel_users.Controls.Add(users_label);
            panel_users.Controls.Add(users_grid);
            panel_users.Location = new Point(266, 56);
            panel_users.Name = "panel_users";
            panel_users.Size = new Size(709, 493);
            panel_users.TabIndex = 24;
            panel_users.Visible = false;
            // 
            // users_rButton_refresh
            // 
            users_rButton_refresh.BackColor = Color.FromArgb(80, 77, 180);
            users_rButton_refresh.BackgroundColor = Color.FromArgb(80, 77, 180);
            users_rButton_refresh.BorderColor = Color.Transparent;
            users_rButton_refresh.BorderRadius = 5;
            users_rButton_refresh.BorderSize = 0;
            users_rButton_refresh.FlatAppearance.BorderSize = 0;
            users_rButton_refresh.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            users_rButton_refresh.FlatStyle = FlatStyle.Flat;
            users_rButton_refresh.Font = new Font("Yu Gothic UI Semibold", 14F);
            users_rButton_refresh.ForeColor = Color.White;
            users_rButton_refresh.Image = (Image)resources.GetObject("users_rButton_refresh.Image");
            users_rButton_refresh.Location = new Point(52, 26);
            users_rButton_refresh.Name = "users_rButton_refresh";
            users_rButton_refresh.Size = new Size(42, 36);
            users_rButton_refresh.TabIndex = 12;
            users_rButton_refresh.TextColor = Color.White;
            users_rButton_refresh.UseVisualStyleBackColor = false;
            users_rButton_refresh.Click += RefreshUsers;
            // 
            // users_rButton_add
            // 
            users_rButton_add.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            users_rButton_add.BackColor = Color.FromArgb(80, 77, 180);
            users_rButton_add.BackgroundColor = Color.FromArgb(80, 77, 180);
            users_rButton_add.BorderColor = Color.Transparent;
            users_rButton_add.BorderRadius = 5;
            users_rButton_add.BorderSize = 0;
            users_rButton_add.FlatAppearance.BorderSize = 0;
            users_rButton_add.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            users_rButton_add.FlatStyle = FlatStyle.Flat;
            users_rButton_add.Font = new Font("Yu Gothic UI Semibold", 14F);
            users_rButton_add.ForeColor = Color.White;
            users_rButton_add.Location = new Point(132, 26);
            users_rButton_add.Name = "users_rButton_add";
            users_rButton_add.Size = new Size(100, 36);
            users_rButton_add.TabIndex = 15;
            users_rButton_add.Text = "Add";
            users_rButton_add.TextColor = Color.White;
            users_rButton_add.UseVisualStyleBackColor = false;
            users_rButton_add.Click += AddUser;
            // 
            // users_rButton_edit
            // 
            users_rButton_edit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            users_rButton_edit.BackColor = Color.FromArgb(80, 77, 180);
            users_rButton_edit.BackgroundColor = Color.FromArgb(80, 77, 180);
            users_rButton_edit.BorderColor = Color.Transparent;
            users_rButton_edit.BorderRadius = 5;
            users_rButton_edit.BorderSize = 0;
            users_rButton_edit.FlatAppearance.BorderSize = 0;
            users_rButton_edit.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            users_rButton_edit.FlatStyle = FlatStyle.Flat;
            users_rButton_edit.Font = new Font("Yu Gothic UI Semibold", 14F);
            users_rButton_edit.ForeColor = Color.White;
            users_rButton_edit.Location = new Point(237, 26);
            users_rButton_edit.Name = "users_rButton_edit";
            users_rButton_edit.Size = new Size(100, 36);
            users_rButton_edit.TabIndex = 13;
            users_rButton_edit.Text = "Edit";
            users_rButton_edit.TextColor = Color.White;
            users_rButton_edit.UseVisualStyleBackColor = false;
            users_rButton_edit.Click += EditUser;
            // 
            // users_rButton_remove
            // 
            users_rButton_remove.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            users_rButton_remove.BackColor = Color.FromArgb(80, 77, 180);
            users_rButton_remove.BackgroundColor = Color.FromArgb(80, 77, 180);
            users_rButton_remove.BorderColor = Color.Transparent;
            users_rButton_remove.BorderRadius = 5;
            users_rButton_remove.BorderSize = 0;
            users_rButton_remove.FlatAppearance.BorderSize = 0;
            users_rButton_remove.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            users_rButton_remove.FlatStyle = FlatStyle.Flat;
            users_rButton_remove.Font = new Font("Yu Gothic UI Semibold", 14F);
            users_rButton_remove.ForeColor = Color.White;
            users_rButton_remove.Location = new Point(342, 26);
            users_rButton_remove.Name = "users_rButton_remove";
            users_rButton_remove.Size = new Size(100, 36);
            users_rButton_remove.TabIndex = 14;
            users_rButton_remove.Text = "Remove";
            users_rButton_remove.TextColor = Color.White;
            users_rButton_remove.UseVisualStyleBackColor = false;
            users_rButton_remove.Click += RemoveUsers;
            // 
            // users_textBox_search
            // 
            users_textBox_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            users_textBox_search.BackColor = Color.White;
            users_textBox_search.Font = new Font("Yu Gothic UI Semibold", 14F);
            users_textBox_search.Location = new Point(449, 29);
            users_textBox_search.MaxLength = 19;
            users_textBox_search.Name = "users_textBox_search";
            users_textBox_search.PlaceholderText = "Search...";
            users_textBox_search.Size = new Size(208, 32);
            users_textBox_search.TabIndex = 16;
            users_textBox_search.TextChanged += SearchUsers;
            // 
            // users_label
            // 
            users_label.AutoSize = true;
            users_label.Font = new Font("Yu Gothic UI Semibold", 14F);
            users_label.Location = new Point(52, 80);
            users_label.Name = "users_label";
            users_label.Size = new Size(58, 25);
            users_label.TabIndex = 11;
            users_label.Text = "Users";
            // 
            // users_grid
            // 
            users_grid.AllowUserToAddRows = false;
            users_grid.AllowUserToDeleteRows = false;
            users_grid.AllowUserToResizeColumns = false;
            users_grid.AllowUserToResizeRows = false;
            users_grid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            users_grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            users_grid.BackgroundColor = Color.White;
            users_grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            users_grid.Columns.AddRange(new DataGridViewColumn[] { users_firstName, users_lastName, users_dateOfBirth, users_address, users_verified, users_username, users_email, users_role });
            users_grid.Location = new Point(52, 108);
            users_grid.Name = "users_grid";
            users_grid.ReadOnly = true;
            users_grid.RowHeadersVisible = false;
            users_grid.RowHeadersWidth = 51;
            users_grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            users_grid.ShowCellErrors = false;
            users_grid.ShowCellToolTips = false;
            users_grid.ShowEditingIcon = false;
            users_grid.ShowRowErrors = false;
            users_grid.Size = new Size(605, 359);
            users_grid.StandardTab = true;
            users_grid.TabIndex = 11;
            // 
            // users_firstName
            // 
            users_firstName.HeaderText = "First Name";
            users_firstName.MinimumWidth = 6;
            users_firstName.Name = "users_firstName";
            users_firstName.ReadOnly = true;
            users_firstName.Width = 89;
            // 
            // users_lastName
            // 
            users_lastName.HeaderText = "Last Name";
            users_lastName.MinimumWidth = 6;
            users_lastName.Name = "users_lastName";
            users_lastName.ReadOnly = true;
            users_lastName.Width = 88;
            // 
            // users_dateOfBirth
            // 
            users_dateOfBirth.HeaderText = "Date of Birth";
            users_dateOfBirth.MinimumWidth = 6;
            users_dateOfBirth.Name = "users_dateOfBirth";
            users_dateOfBirth.ReadOnly = true;
            users_dateOfBirth.Width = 98;
            // 
            // users_address
            // 
            users_address.HeaderText = "Address";
            users_address.MinimumWidth = 6;
            users_address.Name = "users_address";
            users_address.ReadOnly = true;
            users_address.Width = 74;
            // 
            // users_verified
            // 
            users_verified.HeaderText = "Verified";
            users_verified.MinimumWidth = 6;
            users_verified.Name = "users_verified";
            users_verified.ReadOnly = true;
            users_verified.Width = 71;
            // 
            // users_username
            // 
            users_username.HeaderText = "Username";
            users_username.MinimumWidth = 6;
            users_username.Name = "users_username";
            users_username.ReadOnly = true;
            users_username.Width = 85;
            // 
            // users_email
            // 
            users_email.HeaderText = "Email";
            users_email.MinimumWidth = 6;
            users_email.Name = "users_email";
            users_email.ReadOnly = true;
            users_email.Width = 61;
            // 
            // users_role
            // 
            users_role.HeaderText = "Role";
            users_role.MinimumWidth = 6;
            users_role.Name = "users_role";
            users_role.ReadOnly = true;
            users_role.Width = 55;
            // 
            // panel_authors
            // 
            panel_authors.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_authors.BackColor = Color.White;
            panel_authors.Controls.Add(authors_rButton_refresh);
            panel_authors.Controls.Add(authors_rButton_add);
            panel_authors.Controls.Add(authors_rButton_edit);
            panel_authors.Controls.Add(authors_rButton_remove);
            panel_authors.Controls.Add(authors_textBox_search);
            panel_authors.Controls.Add(authors_label);
            panel_authors.Controls.Add(authors_grid);
            panel_authors.Location = new Point(266, 56);
            panel_authors.Name = "panel_authors";
            panel_authors.Size = new Size(709, 493);
            panel_authors.TabIndex = 25;
            panel_authors.Visible = false;
            // 
            // authors_rButton_refresh
            // 
            authors_rButton_refresh.BackColor = Color.FromArgb(80, 77, 180);
            authors_rButton_refresh.BackgroundColor = Color.FromArgb(80, 77, 180);
            authors_rButton_refresh.BorderColor = Color.Transparent;
            authors_rButton_refresh.BorderRadius = 5;
            authors_rButton_refresh.BorderSize = 0;
            authors_rButton_refresh.FlatAppearance.BorderSize = 0;
            authors_rButton_refresh.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            authors_rButton_refresh.FlatStyle = FlatStyle.Flat;
            authors_rButton_refresh.Font = new Font("Yu Gothic UI Semibold", 14F);
            authors_rButton_refresh.ForeColor = Color.White;
            authors_rButton_refresh.Image = (Image)resources.GetObject("authors_rButton_refresh.Image");
            authors_rButton_refresh.Location = new Point(52, 26);
            authors_rButton_refresh.Name = "authors_rButton_refresh";
            authors_rButton_refresh.Size = new Size(42, 36);
            authors_rButton_refresh.TabIndex = 12;
            authors_rButton_refresh.TextColor = Color.White;
            authors_rButton_refresh.UseVisualStyleBackColor = false;
            authors_rButton_refresh.Click += RefreshAuthors;
            // 
            // authors_rButton_add
            // 
            authors_rButton_add.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            authors_rButton_add.BackColor = Color.FromArgb(80, 77, 180);
            authors_rButton_add.BackgroundColor = Color.FromArgb(80, 77, 180);
            authors_rButton_add.BorderColor = Color.Transparent;
            authors_rButton_add.BorderRadius = 5;
            authors_rButton_add.BorderSize = 0;
            authors_rButton_add.FlatAppearance.BorderSize = 0;
            authors_rButton_add.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            authors_rButton_add.FlatStyle = FlatStyle.Flat;
            authors_rButton_add.Font = new Font("Yu Gothic UI Semibold", 14F);
            authors_rButton_add.ForeColor = Color.White;
            authors_rButton_add.Location = new Point(131, 25);
            authors_rButton_add.Name = "authors_rButton_add";
            authors_rButton_add.Size = new Size(100, 36);
            authors_rButton_add.TabIndex = 15;
            authors_rButton_add.Text = "Add";
            authors_rButton_add.TextColor = Color.White;
            authors_rButton_add.UseVisualStyleBackColor = false;
            authors_rButton_add.Click += AddAuthor;
            // 
            // authors_rButton_edit
            // 
            authors_rButton_edit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            authors_rButton_edit.BackColor = Color.FromArgb(80, 77, 180);
            authors_rButton_edit.BackgroundColor = Color.FromArgb(80, 77, 180);
            authors_rButton_edit.BorderColor = Color.Transparent;
            authors_rButton_edit.BorderRadius = 5;
            authors_rButton_edit.BorderSize = 0;
            authors_rButton_edit.FlatAppearance.BorderSize = 0;
            authors_rButton_edit.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            authors_rButton_edit.FlatStyle = FlatStyle.Flat;
            authors_rButton_edit.Font = new Font("Yu Gothic UI Semibold", 14F);
            authors_rButton_edit.ForeColor = Color.White;
            authors_rButton_edit.Location = new Point(237, 26);
            authors_rButton_edit.Name = "authors_rButton_edit";
            authors_rButton_edit.Size = new Size(100, 36);
            authors_rButton_edit.TabIndex = 13;
            authors_rButton_edit.Text = "Edit";
            authors_rButton_edit.TextColor = Color.White;
            authors_rButton_edit.UseVisualStyleBackColor = false;
            authors_rButton_edit.Click += EditAuthor;
            // 
            // authors_rButton_remove
            // 
            authors_rButton_remove.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            authors_rButton_remove.BackColor = Color.FromArgb(80, 77, 180);
            authors_rButton_remove.BackgroundColor = Color.FromArgb(80, 77, 180);
            authors_rButton_remove.BorderColor = Color.Transparent;
            authors_rButton_remove.BorderRadius = 5;
            authors_rButton_remove.BorderSize = 0;
            authors_rButton_remove.FlatAppearance.BorderSize = 0;
            authors_rButton_remove.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            authors_rButton_remove.FlatStyle = FlatStyle.Flat;
            authors_rButton_remove.Font = new Font("Yu Gothic UI Semibold", 14F);
            authors_rButton_remove.ForeColor = Color.White;
            authors_rButton_remove.Location = new Point(344, 26);
            authors_rButton_remove.Name = "authors_rButton_remove";
            authors_rButton_remove.Size = new Size(100, 36);
            authors_rButton_remove.TabIndex = 14;
            authors_rButton_remove.Text = "Remove";
            authors_rButton_remove.TextColor = Color.White;
            authors_rButton_remove.UseVisualStyleBackColor = false;
            authors_rButton_remove.Click += RemoveAuthors;
            // 
            // authors_textBox_search
            // 
            authors_textBox_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            authors_textBox_search.BackColor = Color.White;
            authors_textBox_search.Font = new Font("Yu Gothic UI Semibold", 14F);
            authors_textBox_search.Location = new Point(449, 29);
            authors_textBox_search.MaxLength = 19;
            authors_textBox_search.Name = "authors_textBox_search";
            authors_textBox_search.PlaceholderText = "Search...";
            authors_textBox_search.Size = new Size(208, 32);
            authors_textBox_search.TabIndex = 16;
            authors_textBox_search.TabStop = false;
            authors_textBox_search.TextChanged += SearchAuthors;
            // 
            // authors_label
            // 
            authors_label.AutoSize = true;
            authors_label.Font = new Font("Yu Gothic UI Semibold", 14F);
            authors_label.Location = new Point(52, 80);
            authors_label.Name = "authors_label";
            authors_label.Size = new Size(80, 25);
            authors_label.TabIndex = 18;
            authors_label.Text = "Authors";
            // 
            // authors_grid
            // 
            authors_grid.AllowUserToAddRows = false;
            authors_grid.AllowUserToDeleteRows = false;
            authors_grid.AllowUserToResizeColumns = false;
            authors_grid.AllowUserToResizeRows = false;
            authors_grid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            authors_grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            authors_grid.BackgroundColor = Color.White;
            authors_grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            authors_grid.Columns.AddRange(new DataGridViewColumn[] { authors_author });
            authors_grid.Location = new Point(52, 108);
            authors_grid.Name = "authors_grid";
            authors_grid.ReadOnly = true;
            authors_grid.RowHeadersVisible = false;
            authors_grid.RowHeadersWidth = 51;
            authors_grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            authors_grid.ShowCellErrors = false;
            authors_grid.ShowCellToolTips = false;
            authors_grid.ShowEditingIcon = false;
            authors_grid.ShowRowErrors = false;
            authors_grid.Size = new Size(605, 359);
            authors_grid.StandardTab = true;
            authors_grid.TabIndex = 11;
            // 
            // authors_author
            // 
            authors_author.HeaderText = "Author";
            authors_author.MinimumWidth = 6;
            authors_author.Name = "authors_author";
            authors_author.ReadOnly = true;
            authors_author.Width = 69;
            // 
            // panel_publishers
            // 
            panel_publishers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_publishers.AutoSize = true;
            panel_publishers.BackColor = Color.White;
            panel_publishers.Controls.Add(publishers_rButton_refresh);
            panel_publishers.Controls.Add(publishers_rButton_add);
            panel_publishers.Controls.Add(publishers_rButton_edit);
            panel_publishers.Controls.Add(publishers_rButton_remove);
            panel_publishers.Controls.Add(publishers_textBox_search);
            panel_publishers.Controls.Add(publishers_label);
            panel_publishers.Controls.Add(publishers_grid);
            panel_publishers.Location = new Point(266, 56);
            panel_publishers.Name = "panel_publishers";
            panel_publishers.Size = new Size(709, 493);
            panel_publishers.TabIndex = 26;
            panel_publishers.Visible = false;
            // 
            // publishers_rButton_refresh
            // 
            publishers_rButton_refresh.BackColor = Color.FromArgb(80, 77, 180);
            publishers_rButton_refresh.BackgroundColor = Color.FromArgb(80, 77, 180);
            publishers_rButton_refresh.BorderColor = Color.Transparent;
            publishers_rButton_refresh.BorderRadius = 5;
            publishers_rButton_refresh.BorderSize = 0;
            publishers_rButton_refresh.FlatAppearance.BorderSize = 0;
            publishers_rButton_refresh.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            publishers_rButton_refresh.FlatStyle = FlatStyle.Flat;
            publishers_rButton_refresh.Font = new Font("Yu Gothic UI Semibold", 14F);
            publishers_rButton_refresh.ForeColor = Color.White;
            publishers_rButton_refresh.Image = (Image)resources.GetObject("publishers_rButton_refresh.Image");
            publishers_rButton_refresh.Location = new Point(52, 26);
            publishers_rButton_refresh.Name = "publishers_rButton_refresh";
            publishers_rButton_refresh.Size = new Size(42, 36);
            publishers_rButton_refresh.TabIndex = 12;
            publishers_rButton_refresh.TextColor = Color.White;
            publishers_rButton_refresh.UseVisualStyleBackColor = false;
            publishers_rButton_refresh.Click += RefreshPublishers;
            // 
            // publishers_rButton_add
            // 
            publishers_rButton_add.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            publishers_rButton_add.BackColor = Color.FromArgb(80, 77, 180);
            publishers_rButton_add.BackgroundColor = Color.FromArgb(80, 77, 180);
            publishers_rButton_add.BorderColor = Color.Transparent;
            publishers_rButton_add.BorderRadius = 5;
            publishers_rButton_add.BorderSize = 0;
            publishers_rButton_add.FlatAppearance.BorderSize = 0;
            publishers_rButton_add.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            publishers_rButton_add.FlatStyle = FlatStyle.Flat;
            publishers_rButton_add.Font = new Font("Yu Gothic UI Semibold", 14F);
            publishers_rButton_add.ForeColor = Color.White;
            publishers_rButton_add.Location = new Point(132, 26);
            publishers_rButton_add.Name = "publishers_rButton_add";
            publishers_rButton_add.Size = new Size(100, 36);
            publishers_rButton_add.TabIndex = 15;
            publishers_rButton_add.Text = "Add";
            publishers_rButton_add.TextColor = Color.White;
            publishers_rButton_add.UseVisualStyleBackColor = false;
            publishers_rButton_add.Click += AddPublisher;
            // 
            // publishers_rButton_edit
            // 
            publishers_rButton_edit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            publishers_rButton_edit.BackColor = Color.FromArgb(80, 77, 180);
            publishers_rButton_edit.BackgroundColor = Color.FromArgb(80, 77, 180);
            publishers_rButton_edit.BorderColor = Color.Transparent;
            publishers_rButton_edit.BorderRadius = 5;
            publishers_rButton_edit.BorderSize = 0;
            publishers_rButton_edit.FlatAppearance.BorderSize = 0;
            publishers_rButton_edit.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            publishers_rButton_edit.FlatStyle = FlatStyle.Flat;
            publishers_rButton_edit.Font = new Font("Yu Gothic UI Semibold", 14F);
            publishers_rButton_edit.ForeColor = Color.White;
            publishers_rButton_edit.Location = new Point(238, 26);
            publishers_rButton_edit.Name = "publishers_rButton_edit";
            publishers_rButton_edit.Size = new Size(100, 36);
            publishers_rButton_edit.TabIndex = 13;
            publishers_rButton_edit.Text = "Edit";
            publishers_rButton_edit.TextColor = Color.White;
            publishers_rButton_edit.UseVisualStyleBackColor = false;
            publishers_rButton_edit.Click += EditPublisher;
            // 
            // publishers_rButton_remove
            // 
            publishers_rButton_remove.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            publishers_rButton_remove.BackColor = Color.FromArgb(80, 77, 180);
            publishers_rButton_remove.BackgroundColor = Color.FromArgb(80, 77, 180);
            publishers_rButton_remove.BorderColor = Color.Transparent;
            publishers_rButton_remove.BorderRadius = 5;
            publishers_rButton_remove.BorderSize = 0;
            publishers_rButton_remove.FlatAppearance.BorderSize = 0;
            publishers_rButton_remove.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            publishers_rButton_remove.FlatStyle = FlatStyle.Flat;
            publishers_rButton_remove.Font = new Font("Yu Gothic UI Semibold", 14F);
            publishers_rButton_remove.ForeColor = Color.White;
            publishers_rButton_remove.Location = new Point(342, 26);
            publishers_rButton_remove.Name = "publishers_rButton_remove";
            publishers_rButton_remove.Size = new Size(100, 36);
            publishers_rButton_remove.TabIndex = 14;
            publishers_rButton_remove.Text = "Remove";
            publishers_rButton_remove.TextColor = Color.White;
            publishers_rButton_remove.UseVisualStyleBackColor = false;
            publishers_rButton_remove.Click += RemovePublishers;
            // 
            // publishers_textBox_search
            // 
            publishers_textBox_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            publishers_textBox_search.BackColor = Color.White;
            publishers_textBox_search.Font = new Font("Yu Gothic UI Semibold", 14F);
            publishers_textBox_search.Location = new Point(449, 29);
            publishers_textBox_search.MaxLength = 19;
            publishers_textBox_search.Name = "publishers_textBox_search";
            publishers_textBox_search.PlaceholderText = "Search...";
            publishers_textBox_search.Size = new Size(208, 32);
            publishers_textBox_search.TabIndex = 16;
            publishers_textBox_search.TextChanged += SearchPublishers;
            // 
            // publishers_label
            // 
            publishers_label.AutoSize = true;
            publishers_label.Font = new Font("Yu Gothic UI Semibold", 14F);
            publishers_label.Location = new Point(52, 80);
            publishers_label.Name = "publishers_label";
            publishers_label.Size = new Size(99, 25);
            publishers_label.TabIndex = 18;
            publishers_label.Text = "Publishers";
            // 
            // publishers_grid
            // 
            publishers_grid.AllowUserToAddRows = false;
            publishers_grid.AllowUserToDeleteRows = false;
            publishers_grid.AllowUserToResizeColumns = false;
            publishers_grid.AllowUserToResizeRows = false;
            publishers_grid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            publishers_grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            publishers_grid.BackgroundColor = Color.White;
            publishers_grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            publishers_grid.Columns.AddRange(new DataGridViewColumn[] { publishers_publisher });
            publishers_grid.Location = new Point(52, 108);
            publishers_grid.Name = "publishers_grid";
            publishers_grid.ReadOnly = true;
            publishers_grid.RowHeadersVisible = false;
            publishers_grid.RowHeadersWidth = 51;
            publishers_grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            publishers_grid.ShowCellErrors = false;
            publishers_grid.ShowCellToolTips = false;
            publishers_grid.ShowEditingIcon = false;
            publishers_grid.ShowRowErrors = false;
            publishers_grid.Size = new Size(605, 359);
            publishers_grid.StandardTab = true;
            publishers_grid.TabIndex = 11;
            // 
            // publishers_publisher
            // 
            publishers_publisher.HeaderText = "Publisher";
            publishers_publisher.MinimumWidth = 6;
            publishers_publisher.Name = "publishers_publisher";
            publishers_publisher.ReadOnly = true;
            publishers_publisher.Width = 81;
            // 
            // panel_reservations
            // 
            panel_reservations.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_reservations.BackColor = Color.White;
            panel_reservations.Controls.Add(reservations_rButton_refresh);
            panel_reservations.Controls.Add(reservations_rButton_add);
            panel_reservations.Controls.Add(reservations_rButton_extend);
            panel_reservations.Controls.Add(reservations_rButton_remove);
            panel_reservations.Controls.Add(reservations_textBox_search);
            panel_reservations.Controls.Add(reservations_label);
            panel_reservations.Controls.Add(reservations_grid);
            panel_reservations.Location = new Point(266, 56);
            panel_reservations.Name = "panel_reservations";
            panel_reservations.Size = new Size(710, 493);
            panel_reservations.TabIndex = 27;
            panel_reservations.Visible = false;
            // 
            // reservations_rButton_refresh
            // 
            reservations_rButton_refresh.BackColor = Color.FromArgb(80, 77, 180);
            reservations_rButton_refresh.BackgroundColor = Color.FromArgb(80, 77, 180);
            reservations_rButton_refresh.BorderColor = Color.Transparent;
            reservations_rButton_refresh.BorderRadius = 5;
            reservations_rButton_refresh.BorderSize = 0;
            reservations_rButton_refresh.FlatAppearance.BorderSize = 0;
            reservations_rButton_refresh.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            reservations_rButton_refresh.FlatStyle = FlatStyle.Flat;
            reservations_rButton_refresh.Font = new Font("Yu Gothic UI Semibold", 14F);
            reservations_rButton_refresh.ForeColor = Color.White;
            reservations_rButton_refresh.Image = (Image)resources.GetObject("reservations_rButton_refresh.Image");
            reservations_rButton_refresh.Location = new Point(52, 26);
            reservations_rButton_refresh.Name = "reservations_rButton_refresh";
            reservations_rButton_refresh.Size = new Size(42, 36);
            reservations_rButton_refresh.TabIndex = 12;
            reservations_rButton_refresh.TextColor = Color.White;
            reservations_rButton_refresh.UseVisualStyleBackColor = false;
            reservations_rButton_refresh.Click += RefreshReservations;
            // 
            // reservations_rButton_add
            // 
            reservations_rButton_add.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            reservations_rButton_add.BackColor = Color.FromArgb(80, 77, 180);
            reservations_rButton_add.BackgroundColor = Color.FromArgb(80, 77, 180);
            reservations_rButton_add.BorderColor = Color.Transparent;
            reservations_rButton_add.BorderRadius = 5;
            reservations_rButton_add.BorderSize = 0;
            reservations_rButton_add.FlatAppearance.BorderSize = 0;
            reservations_rButton_add.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            reservations_rButton_add.FlatStyle = FlatStyle.Flat;
            reservations_rButton_add.Font = new Font("Yu Gothic UI Semibold", 14F);
            reservations_rButton_add.ForeColor = Color.White;
            reservations_rButton_add.Location = new Point(130, 26);
            reservations_rButton_add.Name = "reservations_rButton_add";
            reservations_rButton_add.Size = new Size(100, 36);
            reservations_rButton_add.TabIndex = 15;
            reservations_rButton_add.Text = "Add";
            reservations_rButton_add.TextColor = Color.White;
            reservations_rButton_add.UseVisualStyleBackColor = false;
            reservations_rButton_add.Click += AddReservation;
            // 
            // reservations_rButton_extend
            // 
            reservations_rButton_extend.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            reservations_rButton_extend.BackColor = Color.FromArgb(80, 77, 180);
            reservations_rButton_extend.BackgroundColor = Color.FromArgb(80, 77, 180);
            reservations_rButton_extend.BorderColor = Color.Transparent;
            reservations_rButton_extend.BorderRadius = 5;
            reservations_rButton_extend.BorderSize = 0;
            reservations_rButton_extend.FlatAppearance.BorderSize = 0;
            reservations_rButton_extend.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            reservations_rButton_extend.FlatStyle = FlatStyle.Flat;
            reservations_rButton_extend.Font = new Font("Yu Gothic UI Semibold", 14F);
            reservations_rButton_extend.ForeColor = Color.White;
            reservations_rButton_extend.Location = new Point(236, 26);
            reservations_rButton_extend.Name = "reservations_rButton_extend";
            reservations_rButton_extend.Size = new Size(100, 36);
            reservations_rButton_extend.TabIndex = 13;
            reservations_rButton_extend.Text = "Extend";
            reservations_rButton_extend.TextColor = Color.White;
            reservations_rButton_extend.UseVisualStyleBackColor = false;
            reservations_rButton_extend.Click += EditReservation;
            // 
            // reservations_rButton_remove
            // 
            reservations_rButton_remove.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            reservations_rButton_remove.BackColor = Color.FromArgb(80, 77, 180);
            reservations_rButton_remove.BackgroundColor = Color.FromArgb(80, 77, 180);
            reservations_rButton_remove.BorderColor = Color.Transparent;
            reservations_rButton_remove.BorderRadius = 5;
            reservations_rButton_remove.BorderSize = 0;
            reservations_rButton_remove.FlatAppearance.BorderSize = 0;
            reservations_rButton_remove.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            reservations_rButton_remove.FlatStyle = FlatStyle.Flat;
            reservations_rButton_remove.Font = new Font("Yu Gothic UI Semibold", 14F);
            reservations_rButton_remove.ForeColor = Color.White;
            reservations_rButton_remove.Location = new Point(342, 26);
            reservations_rButton_remove.Name = "reservations_rButton_remove";
            reservations_rButton_remove.Size = new Size(100, 36);
            reservations_rButton_remove.TabIndex = 14;
            reservations_rButton_remove.Text = "Remove";
            reservations_rButton_remove.TextColor = Color.White;
            reservations_rButton_remove.UseVisualStyleBackColor = false;
            reservations_rButton_remove.Click += RemoveReservations;
            // 
            // reservations_textBox_search
            // 
            reservations_textBox_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            reservations_textBox_search.BackColor = Color.White;
            reservations_textBox_search.Font = new Font("Yu Gothic UI Semibold", 14F);
            reservations_textBox_search.Location = new Point(448, 29);
            reservations_textBox_search.MaxLength = 19;
            reservations_textBox_search.Name = "reservations_textBox_search";
            reservations_textBox_search.PlaceholderText = "Search...";
            reservations_textBox_search.Size = new Size(208, 32);
            reservations_textBox_search.TabIndex = 16;
            reservations_textBox_search.TextChanged += SearchReservations;
            // 
            // reservations_label
            // 
            reservations_label.AutoSize = true;
            reservations_label.Font = new Font("Yu Gothic UI Semibold", 14F);
            reservations_label.Location = new Point(52, 80);
            reservations_label.Name = "reservations_label";
            reservations_label.Size = new Size(121, 25);
            reservations_label.TabIndex = 25;
            reservations_label.Text = "Reservations";
            // 
            // reservations_grid
            // 
            reservations_grid.AllowUserToAddRows = false;
            reservations_grid.AllowUserToDeleteRows = false;
            reservations_grid.AllowUserToResizeColumns = false;
            reservations_grid.AllowUserToResizeRows = false;
            reservations_grid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            reservations_grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            reservations_grid.BackgroundColor = Color.White;
            reservations_grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            reservations_grid.Columns.AddRange(new DataGridViewColumn[] { reservations_username, reservations_title, reservations_isbn, reservations_startDate, reservations_endDate });
            reservations_grid.Location = new Point(52, 108);
            reservations_grid.Name = "reservations_grid";
            reservations_grid.ReadOnly = true;
            reservations_grid.RowHeadersVisible = false;
            reservations_grid.RowHeadersWidth = 51;
            reservations_grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            reservations_grid.ShowCellErrors = false;
            reservations_grid.ShowCellToolTips = false;
            reservations_grid.ShowEditingIcon = false;
            reservations_grid.ShowRowErrors = false;
            reservations_grid.Size = new Size(605, 359);
            reservations_grid.StandardTab = true;
            reservations_grid.TabIndex = 11;
            // 
            // reservations_username
            // 
            reservations_username.HeaderText = "Username";
            reservations_username.MinimumWidth = 6;
            reservations_username.Name = "reservations_username";
            reservations_username.ReadOnly = true;
            reservations_username.Width = 85;
            // 
            // reservations_title
            // 
            reservations_title.HeaderText = "Title";
            reservations_title.MinimumWidth = 6;
            reservations_title.Name = "reservations_title";
            reservations_title.ReadOnly = true;
            reservations_title.Width = 54;
            // 
            // reservations_isbn
            // 
            reservations_isbn.HeaderText = "ISBN";
            reservations_isbn.MinimumWidth = 6;
            reservations_isbn.Name = "reservations_isbn";
            reservations_isbn.ReadOnly = true;
            reservations_isbn.Width = 57;
            // 
            // reservations_startDate
            // 
            reservations_startDate.HeaderText = "Start Date";
            reservations_startDate.MinimumWidth = 6;
            reservations_startDate.Name = "reservations_startDate";
            reservations_startDate.ReadOnly = true;
            reservations_startDate.Width = 83;
            // 
            // reservations_endDate
            // 
            reservations_endDate.HeaderText = "End Date";
            reservations_endDate.MinimumWidth = 6;
            reservations_endDate.Name = "reservations_endDate";
            reservations_endDate.ReadOnly = true;
            reservations_endDate.Width = 79;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(984, 561);
            Controls.Add(panel_header);
            Controls.Add(panel_menu);
            Controls.Add(panel_dashboard);
            Controls.Add(panel_books);
            Controls.Add(panel_borrowings);
            Controls.Add(panel_reservations);
            Controls.Add(panel_categories);
            Controls.Add(panel_authors);
            Controls.Add(panel_publishers);
            Controls.Add(panel_users);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1000, 592);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LMS Desktop";
            Load += OnLoad;
            panel_menu.ResumeLayout(false);
            panel_menu.PerformLayout();
            panel_header.ResumeLayout(false);
            panel_header.PerformLayout();
            panel_dashboard.ResumeLayout(false);
            panel_dashboard.PerformLayout();
            panel_noOfBooks.ResumeLayout(false);
            panel_noOfBooks.PerformLayout();
            panel_noOfUsers.ResumeLayout(false);
            panel_noOfUsers.PerformLayout();
            panel_noOfBorrowings.ResumeLayout(false);
            panel_noOfBorrowings.PerformLayout();
            panel_topBorrowedBooks.ResumeLayout(false);
            panel_topBorrowedBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dashboard_grid).EndInit();
            panel_books.ResumeLayout(false);
            panel_books.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)books_grid).EndInit();
            panel_borrowings.ResumeLayout(false);
            panel_borrowings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)borrowings_grid).EndInit();
            panel_categories.ResumeLayout(false);
            panel_categories.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)categories_grid).EndInit();
            panel_users.ResumeLayout(false);
            panel_users.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)users_grid).EndInit();
            panel_authors.ResumeLayout(false);
            panel_authors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)authors_grid).EndInit();
            panel_publishers.ResumeLayout(false);
            panel_publishers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)publishers_grid).EndInit();
            panel_reservations.ResumeLayout(false);
            panel_reservations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)reservations_grid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel_menu;
        private Button button_dashboard;
        private Panel panel_header;
        private Label label_title;
        private Button button_categories;
        private Button button_borrowings;
        private Button button_users;
        private Button button_books;
        private Label label_greeting;
        private Label label_noOfBooks;
        private Panel panel_dashboard;
        private Label label_topBorrowedBooks;
        private DataGridView dashboard_grid;
        private Panel panel_books;
        private Label books_label;
        private RoundedButton books_rBtton_refresh;
        private RoundedButton rButton_noOfBooks;
        private TextBox books_textBox_search;
        private Panel panel_borrowings;
        private RoundedButton rButton_logout;
        private Panel panel_divider1;
        private Panel panel_divider4;
        private Panel panel_categories;
        private RoundedButton categories_rButton_refresh;
        private RoundedButton categories_rButton_add;
        private RoundedButton categories_rButton_edit;
        private RoundedButton categories_rButton_remove;
        private Label users_label;
        private TextBox categories_textBox_search;
        private Label categories_label;
        private RoundedButton borrowings_rButton_refresh;
        private RoundedButton borrowings_rButton_lend;
        private RoundedButton borrowings_rButton_extend;
        private RoundedButton borrowings_rButton_return;
        private Label borrowings_label;
        private TextBox borrowings_textBox_search;
        private Panel panel_users;
        private TextBox users_textBox_search;
        private Panel panel_divider5;
        private Button button_authors;
        private Panel panel_divider6;
        private Button button_publishers;
        private Panel panel_authors;
        private RoundedButton authors_rButton_refresh;
        private RoundedButton authors_rButton_add;
        private RoundedButton authors_rButton_edit;
        private RoundedButton authors_rButton_remove;
        private Label authors_label;
        private TextBox authors_textBox_search;
        private Panel panel_publishers;
        private RoundedButton publishers_rButton_refresh;
        private RoundedButton publishers_rButton_add;
        private RoundedButton publishers_rButton_edit;
        private RoundedButton publishers_rButton_remove;
        private Label publishers_label;
        private TextBox publishers_textBox_search;
        private Panel panel_noOfBooks;
        private Panel panel_noOfUsers;
        private RoundedButton rButton_noOfUsers;
        private Label label_noOfUsers;
        private Panel panel_noOfBorrowings;
        private RoundedButton rButton_noOfBorrowings;
        private Label label_noOfBorrowings;
        private Panel panel_topBorrowedBooks;
        private DataGridView books_grid;
        private DataGridView borrowings_grid;
        private DataGridViewTextBoxColumn dashboard_count;
        private DataGridViewTextBoxColumn dashboard_title;
        private DataGridViewTextBoxColumn dashboard_author;
        private DataGridViewTextBoxColumn dashboard_publicationYear;
        private DataGridViewTextBoxColumn dashboard_category;
        private CheckBox borrowings_checkBox_currentBorrowings;
        private RoundedButton users_rButton_refresh;
        private DataGridViewTextBoxColumn borrowings_username;
        private DataGridViewTextBoxColumn borrowings_title;
        private DataGridViewTextBoxColumn borrowings_isbn;
        private DataGridViewTextBoxColumn borrowings_borrowDate;
        private DataGridViewTextBoxColumn borrowings_dueDate;
        private DataGridViewTextBoxColumn borrowings_returnDate;
        private DataGridView categories_grid;
        private DataGridViewTextBoxColumn categories_category;
        private RoundedButton users_rButton_add;
        private RoundedButton users_rButton_edit;
        private RoundedButton users_rButton_remove;
        private RoundedButton books_rButton_add;
        private RoundedButton books_rButton_edit;
        private RoundedButton books_rButton_remove;
        private DataGridView users_grid;
        private DataGridView authors_grid;
        private DataGridView publishers_grid;
        private DataGridViewTextBoxColumn authors_author;
        private DataGridViewTextBoxColumn publishers_publisher;
        private DataGridViewTextBoxColumn books_title;
        private DataGridViewTextBoxColumn books_author;
        private DataGridViewTextBoxColumn books_publicationYear;
        private DataGridViewTextBoxColumn books_category;
        private DataGridViewTextBoxColumn books_publisher;
        private DataGridViewTextBoxColumn books_isbn;
        private DataGridViewTextBoxColumn users_firstName;
        private DataGridViewTextBoxColumn users_lastName;
        private DataGridViewTextBoxColumn users_dateOfBirth;
        private DataGridViewTextBoxColumn users_address;
        private DataGridViewTextBoxColumn users_verified;
        private DataGridViewTextBoxColumn users_username;
        private DataGridViewTextBoxColumn users_email;
        private DataGridViewTextBoxColumn users_role;
        private Panel panel_divider7;
        private Panel panel_divider2;
        private Panel panel_divider3;
        private Button button_reservations;
        private Panel panel_reservations;
        private DataGridView reservations_grid;
        private RoundedButton reservations_rButton_refresh;
        private RoundedButton reservations_rButton_add;
        private RoundedButton reservations_rButton_extend;
        private RoundedButton reservations_rButton_remove;
        private Label reservations_label;
        private TextBox reservations_textBox_search;
        private DataGridViewTextBoxColumn reservations_username;
        private DataGridViewTextBoxColumn reservations_title;
        private DataGridViewTextBoxColumn reservations_isbn;
        private DataGridViewTextBoxColumn reservations_startDate;
        private DataGridViewTextBoxColumn reservations_endDate;
    }
}