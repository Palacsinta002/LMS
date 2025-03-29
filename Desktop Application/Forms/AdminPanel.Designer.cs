using Desktop_Application.Components;

namespace Desktop_Application
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            panel_menu = new Panel();
            panel7 = new Panel();
            reservations_btn = new Button();
            panel2 = new Panel();
            button2 = new Button();
            panel1 = new Panel();
            button1 = new Button();
            divider_pnl4 = new Panel();
            divider_pnl = new Panel();
            divider_pnl1 = new Panel();
            divider_pnl3 = new Panel();
            logout_btn = new RoundedButton();
            categories_btn = new Button();
            borrowings_btn = new Button();
            users_btn = new Button();
            books_btn = new Button();
            dashboard_btn = new Button();
            label1 = new Label();
            panel_header = new Panel();
            label_greeting = new Label();
            label_title = new Label();
            panel_dashboard = new Panel();
            panel5 = new Panel();
            dashboard_borrowings = new RoundedButton();
            label3 = new Label();
            panel4 = new Panel();
            dashboard_users = new RoundedButton();
            label2 = new Label();
            panel3 = new Panel();
            dashboard_books = new RoundedButton();
            panel6 = new Panel();
            grid_dashboard = new DataGridView();
            dashboard_count = new DataGridViewTextBoxColumn();
            dashboard_title = new DataGridViewTextBoxColumn();
            dashboard_author = new DataGridViewTextBoxColumn();
            dashboard_publicationYear = new DataGridViewTextBoxColumn();
            dashboard_category = new DataGridViewTextBoxColumn();
            label4 = new Label();
            panel_books = new Panel();
            roundedButton5 = new RoundedButton();
            roundedButton6 = new RoundedButton();
            books_refresh_btn = new RoundedButton();
            roundedButton7 = new RoundedButton();
            books_lbl1 = new Label();
            books_src = new TextBox();
            books_grd = new DataGridView();
            books_title = new DataGridViewTextBoxColumn();
            books_author = new DataGridViewTextBoxColumn();
            books_publicationYear = new DataGridViewTextBoxColumn();
            books_category = new DataGridViewTextBoxColumn();
            books_publisher = new DataGridViewTextBoxColumn();
            books_isbn = new DataGridViewTextBoxColumn();
            panel_borrowings = new Panel();
            checkBox_currentBorrowings = new CheckBox();
            borrowings_grd = new DataGridView();
            borrowings_username = new DataGridViewTextBoxColumn();
            borrowings_title = new DataGridViewTextBoxColumn();
            borrowings_isbn = new DataGridViewTextBoxColumn();
            borrowings_borrowDate = new DataGridViewTextBoxColumn();
            borrowings_dueDate = new DataGridViewTextBoxColumn();
            borrowings_returnDate = new DataGridViewTextBoxColumn();
            borrowings_refresh_btn = new RoundedButton();
            borrowings_borrow_btn = new RoundedButton();
            borrowings_edit_btn = new RoundedButton();
            borrowings_return_btn = new RoundedButton();
            borrowings_lbl1 = new Label();
            borrowings_src = new TextBox();
            panel_categories = new Panel();
            categories_grd = new DataGridView();
            categories_category = new DataGridViewTextBoxColumn();
            categories_refresh_btn = new RoundedButton();
            categories_add_btn = new RoundedButton();
            categories_edit_btn = new RoundedButton();
            categories_remove_btn = new RoundedButton();
            categories_lbl1 = new Label();
            categories_src = new TextBox();
            panel_users = new Panel();
            users_grd = new DataGridView();
            users_firstName = new DataGridViewTextBoxColumn();
            users_lastName = new DataGridViewTextBoxColumn();
            users_dateOfBirth = new DataGridViewTextBoxColumn();
            users_address = new DataGridViewTextBoxColumn();
            users_verified = new DataGridViewTextBoxColumn();
            users_username = new DataGridViewTextBoxColumn();
            users_email = new DataGridViewTextBoxColumn();
            users_role = new DataGridViewTextBoxColumn();
            users_button_add = new RoundedButton();
            roundedButton1 = new RoundedButton();
            users_button_edit = new RoundedButton();
            users_button_remove = new RoundedButton();
            users_lbl1 = new Label();
            users_src = new TextBox();
            panel_authors = new Panel();
            authors_grd = new DataGridView();
            authors_author = new DataGridViewTextBoxColumn();
            authors_refresh_btn = new RoundedButton();
            authors_add_btn = new RoundedButton();
            authors_edit_btn = new RoundedButton();
            authors_remove_btn = new RoundedButton();
            authors_lbl1 = new Label();
            authors_src = new TextBox();
            panel_publishers = new Panel();
            publishers_grd = new DataGridView();
            publishers_publisher = new DataGridViewTextBoxColumn();
            publishers_refresh_btn = new RoundedButton();
            publishers_add_btn = new RoundedButton();
            publishers_edit_btn = new RoundedButton();
            publishers_remove_btn = new RoundedButton();
            publishers_lbl1 = new Label();
            publishers_src = new TextBox();
            panel_reservations = new Panel();
            reservations_grd = new DataGridView();
            reservations_username = new DataGridViewTextBoxColumn();
            reservations_title = new DataGridViewTextBoxColumn();
            reservations_isbn = new DataGridViewTextBoxColumn();
            reservations_startDate = new DataGridViewTextBoxColumn();
            reservations_endDate = new DataGridViewTextBoxColumn();
            reservations_refresh_btn = new RoundedButton();
            reservation_add_btn = new RoundedButton();
            reservations_edit_btn = new RoundedButton();
            reservations_remove_btn = new RoundedButton();
            label5 = new Label();
            reservations_src = new TextBox();
            panel_menu.SuspendLayout();
            panel_header.SuspendLayout();
            panel_dashboard.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid_dashboard).BeginInit();
            panel_books.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)books_grd).BeginInit();
            panel_borrowings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)borrowings_grd).BeginInit();
            panel_categories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)categories_grd).BeginInit();
            panel_users.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)users_grd).BeginInit();
            panel_authors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)authors_grd).BeginInit();
            panel_publishers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)publishers_grd).BeginInit();
            panel_reservations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)reservations_grd).BeginInit();
            SuspendLayout();
            // 
            // panel_menu
            // 
            panel_menu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel_menu.BackColor = Color.FromArgb(80, 77, 180);
            panel_menu.Controls.Add(panel7);
            panel_menu.Controls.Add(reservations_btn);
            panel_menu.Controls.Add(panel2);
            panel_menu.Controls.Add(button2);
            panel_menu.Controls.Add(panel1);
            panel_menu.Controls.Add(button1);
            panel_menu.Controls.Add(divider_pnl4);
            panel_menu.Controls.Add(divider_pnl);
            panel_menu.Controls.Add(divider_pnl1);
            panel_menu.Controls.Add(divider_pnl3);
            panel_menu.Controls.Add(logout_btn);
            panel_menu.Controls.Add(categories_btn);
            panel_menu.Controls.Add(borrowings_btn);
            panel_menu.Controls.Add(users_btn);
            panel_menu.Controls.Add(books_btn);
            panel_menu.Controls.Add(dashboard_btn);
            panel_menu.Location = new Point(0, 0);
            panel_menu.MinimumSize = new Size(263, 561);
            panel_menu.Name = "panel_menu";
            panel_menu.Size = new Size(263, 561);
            panel_menu.TabIndex = 9;
            // 
            // panel7
            // 
            panel7.AutoSize = true;
            panel7.BackColor = Color.White;
            panel7.Location = new Point(33, 229);
            panel7.Name = "panel7";
            panel7.Size = new Size(200, 1);
            panel7.TabIndex = 33;
            // 
            // reservations_btn
            // 
            reservations_btn.AutoSize = true;
            reservations_btn.BackColor = Color.FromArgb(80, 77, 180);
            reservations_btn.FlatAppearance.BorderSize = 0;
            reservations_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            reservations_btn.FlatStyle = FlatStyle.Flat;
            reservations_btn.Font = new Font("Yu Gothic UI Semibold", 14F);
            reservations_btn.ForeColor = Color.White;
            reservations_btn.Location = new Point(0, 230);
            reservations_btn.Name = "reservations_btn";
            reservations_btn.Size = new Size(263, 42);
            reservations_btn.TabIndex = 5;
            reservations_btn.Text = "Reservations";
            reservations_btn.UseVisualStyleBackColor = false;
            reservations_btn.Click += ShowReservations;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.BackColor = Color.White;
            panel2.Location = new Point(33, 358);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 1);
            panel2.TabIndex = 31;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackColor = Color.FromArgb(80, 77, 180);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Yu Gothic UI Semibold", 14F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(0, 359);
            button2.Name = "button2";
            button2.Size = new Size(263, 42);
            button2.TabIndex = 8;
            button2.Text = "Publishers";
            button2.UseVisualStyleBackColor = false;
            button2.Click += ShowPublishers;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.White;
            panel1.Location = new Point(33, 315);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 1);
            panel1.TabIndex = 29;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.FromArgb(80, 77, 180);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Yu Gothic UI Semibold", 14F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 316);
            button1.Name = "button1";
            button1.Size = new Size(263, 42);
            button1.TabIndex = 7;
            button1.Text = "Authors";
            button1.UseVisualStyleBackColor = false;
            button1.Click += ShowAuthors;
            // 
            // divider_pnl4
            // 
            divider_pnl4.AutoSize = true;
            divider_pnl4.BackColor = Color.White;
            divider_pnl4.Location = new Point(33, 401);
            divider_pnl4.Name = "divider_pnl4";
            divider_pnl4.Size = new Size(200, 1);
            divider_pnl4.TabIndex = 27;
            // 
            // divider_pnl
            // 
            divider_pnl.AutoSize = true;
            divider_pnl.BackColor = Color.White;
            divider_pnl.Location = new Point(33, 186);
            divider_pnl.Name = "divider_pnl";
            divider_pnl.Size = new Size(200, 1);
            divider_pnl.TabIndex = 25;
            // 
            // divider_pnl1
            // 
            divider_pnl1.AutoSize = true;
            divider_pnl1.BackColor = Color.White;
            divider_pnl1.Location = new Point(33, 143);
            divider_pnl1.Name = "divider_pnl1";
            divider_pnl1.Size = new Size(200, 1);
            divider_pnl1.TabIndex = 24;
            // 
            // divider_pnl3
            // 
            divider_pnl3.AutoSize = true;
            divider_pnl3.BackColor = Color.White;
            divider_pnl3.Location = new Point(33, 272);
            divider_pnl3.Name = "divider_pnl3";
            divider_pnl3.Size = new Size(200, 1);
            divider_pnl3.TabIndex = 26;
            // 
            // logout_btn
            // 
            logout_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            logout_btn.BackColor = Color.White;
            logout_btn.BackgroundColor = Color.White;
            logout_btn.BorderColor = Color.Transparent;
            logout_btn.BorderRadius = 5;
            logout_btn.BorderSize = 0;
            logout_btn.FlatAppearance.BorderSize = 0;
            logout_btn.FlatAppearance.MouseDownBackColor = Color.Silver;
            logout_btn.FlatStyle = FlatStyle.Flat;
            logout_btn.Font = new Font("Yu Gothic UI Semibold", 14F);
            logout_btn.ForeColor = Color.Black;
            logout_btn.Location = new Point(82, 475);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(96, 36);
            logout_btn.TabIndex = 10;
            logout_btn.Text = "Logout";
            logout_btn.TextColor = Color.Black;
            logout_btn.UseVisualStyleBackColor = false;
            logout_btn.Click += Logout;
            // 
            // categories_btn
            // 
            categories_btn.AutoSize = true;
            categories_btn.BackColor = Color.FromArgb(80, 77, 180);
            categories_btn.FlatAppearance.BorderSize = 0;
            categories_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            categories_btn.FlatStyle = FlatStyle.Flat;
            categories_btn.Font = new Font("Yu Gothic UI Semibold", 14F);
            categories_btn.ForeColor = Color.White;
            categories_btn.Location = new Point(0, 273);
            categories_btn.Name = "categories_btn";
            categories_btn.Size = new Size(263, 42);
            categories_btn.TabIndex = 6;
            categories_btn.Text = "Categories";
            categories_btn.UseVisualStyleBackColor = false;
            categories_btn.Click += ShowCategories;
            // 
            // borrowings_btn
            // 
            borrowings_btn.AutoSize = true;
            borrowings_btn.BackColor = Color.FromArgb(80, 77, 180);
            borrowings_btn.FlatAppearance.BorderSize = 0;
            borrowings_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            borrowings_btn.FlatStyle = FlatStyle.Flat;
            borrowings_btn.Font = new Font("Yu Gothic UI Semibold", 14F);
            borrowings_btn.ForeColor = Color.White;
            borrowings_btn.Location = new Point(0, 187);
            borrowings_btn.Name = "borrowings_btn";
            borrowings_btn.Size = new Size(263, 42);
            borrowings_btn.TabIndex = 4;
            borrowings_btn.Text = "Borrowings";
            borrowings_btn.UseVisualStyleBackColor = false;
            borrowings_btn.Click += ShowBorrowings;
            // 
            // users_btn
            // 
            users_btn.AutoSize = true;
            users_btn.BackColor = Color.FromArgb(80, 77, 180);
            users_btn.FlatAppearance.BorderSize = 0;
            users_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            users_btn.FlatStyle = FlatStyle.Flat;
            users_btn.Font = new Font("Yu Gothic UI Semibold", 14F);
            users_btn.ForeColor = Color.White;
            users_btn.Location = new Point(0, 402);
            users_btn.Name = "users_btn";
            users_btn.Size = new Size(263, 42);
            users_btn.TabIndex = 9;
            users_btn.Text = "Users";
            users_btn.UseVisualStyleBackColor = false;
            users_btn.Click += ShowUsers;
            // 
            // books_btn
            // 
            books_btn.AutoSize = true;
            books_btn.BackColor = Color.FromArgb(80, 77, 180);
            books_btn.FlatAppearance.BorderSize = 0;
            books_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            books_btn.FlatStyle = FlatStyle.Flat;
            books_btn.Font = new Font("Yu Gothic UI Semibold", 14F);
            books_btn.ForeColor = Color.White;
            books_btn.Location = new Point(0, 144);
            books_btn.Name = "books_btn";
            books_btn.Size = new Size(263, 42);
            books_btn.TabIndex = 3;
            books_btn.Text = "Books";
            books_btn.UseVisualStyleBackColor = false;
            books_btn.Click += ShowBooks;
            // 
            // dashboard_btn
            // 
            dashboard_btn.AutoSize = true;
            dashboard_btn.BackColor = Color.FromArgb(80, 77, 180);
            dashboard_btn.FlatAppearance.BorderSize = 0;
            dashboard_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            dashboard_btn.FlatStyle = FlatStyle.Flat;
            dashboard_btn.Font = new Font("Yu Gothic UI Semibold", 14F);
            dashboard_btn.ForeColor = Color.White;
            dashboard_btn.Location = new Point(0, 101);
            dashboard_btn.Name = "dashboard_btn";
            dashboard_btn.Size = new Size(263, 42);
            dashboard_btn.TabIndex = 2;
            dashboard_btn.Text = "Dashboard";
            dashboard_btn.UseVisualStyleBackColor = false;
            dashboard_btn.Click += ShowDashboard;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Yu Gothic UI Semibold", 12F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(22, 6);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(164, 21);
            label1.TabIndex = 11;
            label1.Text = "No. of Books";
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
            panel_dashboard.Controls.Add(panel5);
            panel_dashboard.Controls.Add(panel4);
            panel_dashboard.Controls.Add(panel3);
            panel_dashboard.Controls.Add(panel6);
            panel_dashboard.Location = new Point(266, 56);
            panel_dashboard.Name = "panel_dashboard";
            panel_dashboard.Size = new Size(709, 493);
            panel_dashboard.TabIndex = 12;
            panel_dashboard.Visible = false;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top;
            panel5.AutoSize = true;
            panel5.Controls.Add(dashboard_borrowings);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(458, 30);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 100);
            panel5.TabIndex = 23;
            // 
            // dashboard_borrowings
            // 
            dashboard_borrowings.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dashboard_borrowings.AutoSize = true;
            dashboard_borrowings.BackColor = Color.FromArgb(80, 77, 180);
            dashboard_borrowings.BackgroundColor = Color.FromArgb(80, 77, 180);
            dashboard_borrowings.BorderColor = Color.Transparent;
            dashboard_borrowings.BorderRadius = 10;
            dashboard_borrowings.BorderSize = 0;
            dashboard_borrowings.FlatAppearance.BorderSize = 0;
            dashboard_borrowings.FlatAppearance.MouseDownBackColor = Color.FromArgb(80, 77, 180);
            dashboard_borrowings.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 77, 180);
            dashboard_borrowings.FlatStyle = FlatStyle.Flat;
            dashboard_borrowings.Font = new Font("Yu Gothic UI Semibold", 22F);
            dashboard_borrowings.ForeColor = Color.White;
            dashboard_borrowings.Location = new Point(15, 30);
            dashboard_borrowings.MaximumSize = new Size(250, 100);
            dashboard_borrowings.Name = "dashboard_borrowings";
            dashboard_borrowings.Size = new Size(171, 63);
            dashboard_borrowings.TabIndex = 19;
            dashboard_borrowings.TabStop = false;
            dashboard_borrowings.Text = "0";
            dashboard_borrowings.TextColor = Color.White;
            dashboard_borrowings.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.Font = new Font("Yu Gothic UI Semibold", 12F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(22, 6);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(164, 21);
            label3.TabIndex = 11;
            label3.Text = "No. of Borrowings";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top;
            panel4.AutoSize = true;
            panel4.Controls.Add(dashboard_users);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(256, 30);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 100);
            panel4.TabIndex = 23;
            // 
            // dashboard_users
            // 
            dashboard_users.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dashboard_users.AutoSize = true;
            dashboard_users.BackColor = Color.FromArgb(80, 77, 180);
            dashboard_users.BackgroundColor = Color.FromArgb(80, 77, 180);
            dashboard_users.BorderColor = Color.Transparent;
            dashboard_users.BorderRadius = 10;
            dashboard_users.BorderSize = 0;
            dashboard_users.FlatAppearance.BorderSize = 0;
            dashboard_users.FlatAppearance.MouseDownBackColor = Color.FromArgb(80, 77, 180);
            dashboard_users.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 77, 180);
            dashboard_users.FlatStyle = FlatStyle.Flat;
            dashboard_users.Font = new Font("Yu Gothic UI Semibold", 22F);
            dashboard_users.ForeColor = Color.White;
            dashboard_users.Location = new Point(15, 30);
            dashboard_users.MaximumSize = new Size(250, 100);
            dashboard_users.Name = "dashboard_users";
            dashboard_users.Size = new Size(171, 63);
            dashboard_users.TabIndex = 19;
            dashboard_users.TabStop = false;
            dashboard_users.Text = "0";
            dashboard_users.TextColor = Color.White;
            dashboard_users.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.Font = new Font("Yu Gothic UI Semibold", 12F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(22, 6);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(164, 21);
            label2.TabIndex = 11;
            label2.Text = "No. of Users";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top;
            panel3.AutoSize = true;
            panel3.Controls.Add(dashboard_books);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(54, 30);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 100);
            panel3.TabIndex = 22;
            // 
            // dashboard_books
            // 
            dashboard_books.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dashboard_books.AutoSize = true;
            dashboard_books.BackColor = Color.FromArgb(80, 77, 180);
            dashboard_books.BackgroundColor = Color.FromArgb(80, 77, 180);
            dashboard_books.BorderColor = Color.Transparent;
            dashboard_books.BorderRadius = 10;
            dashboard_books.BorderSize = 0;
            dashboard_books.FlatAppearance.BorderSize = 0;
            dashboard_books.FlatAppearance.MouseDownBackColor = Color.FromArgb(80, 77, 180);
            dashboard_books.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 77, 180);
            dashboard_books.FlatStyle = FlatStyle.Flat;
            dashboard_books.Font = new Font("Yu Gothic UI Semibold", 22F);
            dashboard_books.ForeColor = Color.White;
            dashboard_books.Location = new Point(15, 30);
            dashboard_books.MaximumSize = new Size(250, 100);
            dashboard_books.Name = "dashboard_books";
            dashboard_books.Size = new Size(171, 63);
            dashboard_books.TabIndex = 19;
            dashboard_books.TabStop = false;
            dashboard_books.Text = "0";
            dashboard_books.TextColor = Color.White;
            dashboard_books.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top;
            panel6.Controls.Add(grid_dashboard);
            panel6.Controls.Add(label4);
            panel6.Location = new Point(39, 144);
            panel6.Name = "panel6";
            panel6.Size = new Size(635, 335);
            panel6.TabIndex = 24;
            // 
            // grid_dashboard
            // 
            grid_dashboard.AllowUserToAddRows = false;
            grid_dashboard.AllowUserToDeleteRows = false;
            grid_dashboard.AllowUserToResizeColumns = false;
            grid_dashboard.AllowUserToResizeRows = false;
            grid_dashboard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grid_dashboard.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            grid_dashboard.BackgroundColor = Color.FromArgb(224, 224, 224);
            grid_dashboard.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_dashboard.Columns.AddRange(new DataGridViewColumn[] { dashboard_count, dashboard_title, dashboard_author, dashboard_publicationYear, dashboard_category });
            grid_dashboard.Location = new Point(15, 32);
            grid_dashboard.Name = "grid_dashboard";
            grid_dashboard.ReadOnly = true;
            grid_dashboard.RowHeadersVisible = false;
            grid_dashboard.RowHeadersWidth = 51;
            grid_dashboard.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid_dashboard.ShowCellErrors = false;
            grid_dashboard.ShowCellToolTips = false;
            grid_dashboard.ShowEditingIcon = false;
            grid_dashboard.ShowRowErrors = false;
            grid_dashboard.Size = new Size(604, 290);
            grid_dashboard.StandardTab = true;
            grid_dashboard.TabIndex = 1;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI Semibold", 12F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(13, 8);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(163, 21);
            label4.TabIndex = 17;
            label4.Text = "Top Borrowed Books";
            // 
            // panel_books
            // 
            panel_books.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_books.Controls.Add(roundedButton5);
            panel_books.Controls.Add(roundedButton6);
            panel_books.Controls.Add(books_refresh_btn);
            panel_books.Controls.Add(roundedButton7);
            panel_books.Controls.Add(books_lbl1);
            panel_books.Controls.Add(books_src);
            panel_books.Controls.Add(books_grd);
            panel_books.Location = new Point(266, 56);
            panel_books.Name = "panel_books";
            panel_books.Size = new Size(709, 493);
            panel_books.TabIndex = 13;
            panel_books.Visible = false;
            // 
            // roundedButton5
            // 
            roundedButton5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            roundedButton5.BackColor = Color.FromArgb(80, 77, 180);
            roundedButton5.BackgroundColor = Color.FromArgb(80, 77, 180);
            roundedButton5.BorderColor = Color.Transparent;
            roundedButton5.BorderRadius = 5;
            roundedButton5.BorderSize = 0;
            roundedButton5.FlatAppearance.BorderSize = 0;
            roundedButton5.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            roundedButton5.FlatStyle = FlatStyle.Flat;
            roundedButton5.Font = new Font("Yu Gothic UI Semibold", 14F);
            roundedButton5.ForeColor = Color.White;
            roundedButton5.Location = new Point(344, 26);
            roundedButton5.Name = "roundedButton5";
            roundedButton5.Size = new Size(100, 36);
            roundedButton5.TabIndex = 15;
            roundedButton5.Text = "Add";
            roundedButton5.TextColor = Color.White;
            roundedButton5.UseVisualStyleBackColor = false;
            roundedButton5.Click += AddBook;
            // 
            // roundedButton6
            // 
            roundedButton6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            roundedButton6.BackColor = Color.FromArgb(80, 77, 180);
            roundedButton6.BackgroundColor = Color.FromArgb(80, 77, 180);
            roundedButton6.BorderColor = Color.Transparent;
            roundedButton6.BorderRadius = 5;
            roundedButton6.BorderSize = 0;
            roundedButton6.FlatAppearance.BorderSize = 0;
            roundedButton6.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            roundedButton6.FlatStyle = FlatStyle.Flat;
            roundedButton6.Font = new Font("Yu Gothic UI Semibold", 14F);
            roundedButton6.ForeColor = Color.White;
            roundedButton6.Location = new Point(132, 26);
            roundedButton6.Name = "roundedButton6";
            roundedButton6.Size = new Size(100, 36);
            roundedButton6.TabIndex = 13;
            roundedButton6.Text = "Edit";
            roundedButton6.TextColor = Color.White;
            roundedButton6.UseVisualStyleBackColor = false;
            roundedButton6.Click += EditBook;
            // 
            // books_refresh_btn
            // 
            books_refresh_btn.BackColor = Color.FromArgb(80, 77, 180);
            books_refresh_btn.BackgroundColor = Color.FromArgb(80, 77, 180);
            books_refresh_btn.BorderColor = Color.Transparent;
            books_refresh_btn.BorderRadius = 5;
            books_refresh_btn.BorderSize = 0;
            books_refresh_btn.FlatAppearance.BorderSize = 0;
            books_refresh_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            books_refresh_btn.FlatStyle = FlatStyle.Flat;
            books_refresh_btn.Font = new Font("Yu Gothic UI Semibold", 14F);
            books_refresh_btn.ForeColor = Color.White;
            books_refresh_btn.Image = (Image)resources.GetObject("books_refresh_btn.Image");
            books_refresh_btn.Location = new Point(52, 26);
            books_refresh_btn.Name = "books_refresh_btn";
            books_refresh_btn.Size = new Size(42, 36);
            books_refresh_btn.TabIndex = 12;
            books_refresh_btn.TextColor = Color.White;
            books_refresh_btn.UseVisualStyleBackColor = false;
            books_refresh_btn.Click += RefreshBooks;
            // 
            // roundedButton7
            // 
            roundedButton7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            roundedButton7.BackColor = Color.FromArgb(80, 77, 180);
            roundedButton7.BackgroundColor = Color.FromArgb(80, 77, 180);
            roundedButton7.BorderColor = Color.Transparent;
            roundedButton7.BorderRadius = 5;
            roundedButton7.BorderSize = 0;
            roundedButton7.FlatAppearance.BorderSize = 0;
            roundedButton7.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            roundedButton7.FlatStyle = FlatStyle.Flat;
            roundedButton7.Font = new Font("Yu Gothic UI Semibold", 14F);
            roundedButton7.ForeColor = Color.White;
            roundedButton7.Location = new Point(238, 26);
            roundedButton7.Name = "roundedButton7";
            roundedButton7.Size = new Size(100, 36);
            roundedButton7.TabIndex = 14;
            roundedButton7.Text = "Remove";
            roundedButton7.TextColor = Color.White;
            roundedButton7.UseVisualStyleBackColor = false;
            roundedButton7.Click += RemoveBooks;
            // 
            // books_lbl1
            // 
            books_lbl1.AutoSize = true;
            books_lbl1.Font = new Font("Yu Gothic UI Semibold", 14F);
            books_lbl1.Location = new Point(52, 80);
            books_lbl1.Name = "books_lbl1";
            books_lbl1.Size = new Size(63, 25);
            books_lbl1.TabIndex = 11;
            books_lbl1.Text = "Books";
            // 
            // books_src
            // 
            books_src.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            books_src.BackColor = Color.White;
            books_src.Font = new Font("Yu Gothic UI Semibold", 14F);
            books_src.Location = new Point(449, 29);
            books_src.MaxLength = 19;
            books_src.Name = "books_src";
            books_src.PlaceholderText = "Search...";
            books_src.Size = new Size(208, 32);
            books_src.TabIndex = 16;
            books_src.TextChanged += SearchBooks;
            // 
            // books_grd
            // 
            books_grd.AllowUserToAddRows = false;
            books_grd.AllowUserToDeleteRows = false;
            books_grd.AllowUserToResizeColumns = false;
            books_grd.AllowUserToResizeRows = false;
            books_grd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            books_grd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            books_grd.BackgroundColor = Color.White;
            books_grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            books_grd.Columns.AddRange(new DataGridViewColumn[] { books_title, books_author, books_publicationYear, books_category, books_publisher, books_isbn });
            books_grd.Location = new Point(52, 108);
            books_grd.Name = "books_grd";
            books_grd.ReadOnly = true;
            books_grd.RowHeadersVisible = false;
            books_grd.RowHeadersWidth = 51;
            books_grd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            books_grd.ShowCellErrors = false;
            books_grd.ShowCellToolTips = false;
            books_grd.ShowEditingIcon = false;
            books_grd.ShowRowErrors = false;
            books_grd.Size = new Size(605, 359);
            books_grd.StandardTab = true;
            books_grd.TabIndex = 11;
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
            panel_borrowings.Controls.Add(checkBox_currentBorrowings);
            panel_borrowings.Controls.Add(borrowings_grd);
            panel_borrowings.Controls.Add(borrowings_refresh_btn);
            panel_borrowings.Controls.Add(borrowings_borrow_btn);
            panel_borrowings.Controls.Add(borrowings_edit_btn);
            panel_borrowings.Controls.Add(borrowings_return_btn);
            panel_borrowings.Controls.Add(borrowings_lbl1);
            panel_borrowings.Controls.Add(borrowings_src);
            panel_borrowings.Location = new Point(266, 56);
            panel_borrowings.Name = "panel_borrowings";
            panel_borrowings.Size = new Size(709, 493);
            panel_borrowings.TabIndex = 14;
            panel_borrowings.Visible = false;
            // 
            // checkBox_currentBorrowings
            // 
            checkBox_currentBorrowings.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            checkBox_currentBorrowings.AutoSize = true;
            checkBox_currentBorrowings.Location = new Point(472, 80);
            checkBox_currentBorrowings.Name = "checkBox_currentBorrowings";
            checkBox_currentBorrowings.RightToLeft = RightToLeft.Yes;
            checkBox_currentBorrowings.Size = new Size(186, 19);
            checkBox_currentBorrowings.TabIndex = 17;
            checkBox_currentBorrowings.Text = "Only show current borrowings";
            checkBox_currentBorrowings.UseVisualStyleBackColor = true;
            checkBox_currentBorrowings.CheckedChanged += RefreshBorrowings;
            // 
            // borrowings_grd
            // 
            borrowings_grd.AllowUserToAddRows = false;
            borrowings_grd.AllowUserToDeleteRows = false;
            borrowings_grd.AllowUserToResizeColumns = false;
            borrowings_grd.AllowUserToResizeRows = false;
            borrowings_grd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            borrowings_grd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            borrowings_grd.BackgroundColor = Color.White;
            borrowings_grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            borrowings_grd.Columns.AddRange(new DataGridViewColumn[] { borrowings_username, borrowings_title, borrowings_isbn, borrowings_borrowDate, borrowings_dueDate, borrowings_returnDate });
            borrowings_grd.Location = new Point(52, 108);
            borrowings_grd.Name = "borrowings_grd";
            borrowings_grd.ReadOnly = true;
            borrowings_grd.RowHeadersVisible = false;
            borrowings_grd.RowHeadersWidth = 51;
            borrowings_grd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            borrowings_grd.ShowCellErrors = false;
            borrowings_grd.ShowCellToolTips = false;
            borrowings_grd.ShowEditingIcon = false;
            borrowings_grd.ShowRowErrors = false;
            borrowings_grd.Size = new Size(605, 359);
            borrowings_grd.StandardTab = true;
            borrowings_grd.TabIndex = 11;
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
            // borrowings_refresh_btn
            // 
            borrowings_refresh_btn.BackColor = Color.FromArgb(80, 77, 180);
            borrowings_refresh_btn.BackgroundColor = Color.FromArgb(80, 77, 180);
            borrowings_refresh_btn.BorderColor = Color.Transparent;
            borrowings_refresh_btn.BorderRadius = 5;
            borrowings_refresh_btn.BorderSize = 0;
            borrowings_refresh_btn.FlatAppearance.BorderSize = 0;
            borrowings_refresh_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            borrowings_refresh_btn.FlatStyle = FlatStyle.Flat;
            borrowings_refresh_btn.Font = new Font("Yu Gothic UI Semibold", 14F);
            borrowings_refresh_btn.ForeColor = Color.White;
            borrowings_refresh_btn.Image = (Image)resources.GetObject("borrowings_refresh_btn.Image");
            borrowings_refresh_btn.Location = new Point(52, 26);
            borrowings_refresh_btn.Name = "borrowings_refresh_btn";
            borrowings_refresh_btn.Size = new Size(42, 36);
            borrowings_refresh_btn.TabIndex = 12;
            borrowings_refresh_btn.TextColor = Color.White;
            borrowings_refresh_btn.UseVisualStyleBackColor = false;
            borrowings_refresh_btn.Click += RefreshBorrowings;
            // 
            // borrowings_borrow_btn
            // 
            borrowings_borrow_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            borrowings_borrow_btn.BackColor = Color.FromArgb(80, 77, 180);
            borrowings_borrow_btn.BackgroundColor = Color.FromArgb(80, 77, 180);
            borrowings_borrow_btn.BorderColor = Color.Transparent;
            borrowings_borrow_btn.BorderRadius = 5;
            borrowings_borrow_btn.BorderSize = 0;
            borrowings_borrow_btn.FlatAppearance.BorderSize = 0;
            borrowings_borrow_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            borrowings_borrow_btn.FlatStyle = FlatStyle.Flat;
            borrowings_borrow_btn.Font = new Font("Yu Gothic UI Semibold", 14F);
            borrowings_borrow_btn.ForeColor = Color.White;
            borrowings_borrow_btn.Location = new Point(343, 26);
            borrowings_borrow_btn.Name = "borrowings_borrow_btn";
            borrowings_borrow_btn.Size = new Size(100, 36);
            borrowings_borrow_btn.TabIndex = 15;
            borrowings_borrow_btn.Text = "Lend";
            borrowings_borrow_btn.TextColor = Color.White;
            borrowings_borrow_btn.UseVisualStyleBackColor = false;
            borrowings_borrow_btn.Click += AddBorrowing;
            // 
            // borrowings_edit_btn
            // 
            borrowings_edit_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            borrowings_edit_btn.BackColor = Color.FromArgb(80, 77, 180);
            borrowings_edit_btn.BackgroundColor = Color.FromArgb(80, 77, 180);
            borrowings_edit_btn.BorderColor = Color.Transparent;
            borrowings_edit_btn.BorderRadius = 5;
            borrowings_edit_btn.BorderSize = 0;
            borrowings_edit_btn.FlatAppearance.BorderSize = 0;
            borrowings_edit_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            borrowings_edit_btn.FlatStyle = FlatStyle.Flat;
            borrowings_edit_btn.Font = new Font("Yu Gothic UI Semibold", 14F);
            borrowings_edit_btn.ForeColor = Color.White;
            borrowings_edit_btn.Location = new Point(131, 26);
            borrowings_edit_btn.Name = "borrowings_edit_btn";
            borrowings_edit_btn.Size = new Size(100, 36);
            borrowings_edit_btn.TabIndex = 13;
            borrowings_edit_btn.Text = "Extend";
            borrowings_edit_btn.TextColor = Color.White;
            borrowings_edit_btn.UseVisualStyleBackColor = false;
            borrowings_edit_btn.Click += EditBorrowing;
            // 
            // borrowings_return_btn
            // 
            borrowings_return_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            borrowings_return_btn.BackColor = Color.FromArgb(80, 77, 180);
            borrowings_return_btn.BackgroundColor = Color.FromArgb(80, 77, 180);
            borrowings_return_btn.BorderColor = Color.Transparent;
            borrowings_return_btn.BorderRadius = 5;
            borrowings_return_btn.BorderSize = 0;
            borrowings_return_btn.FlatAppearance.BorderSize = 0;
            borrowings_return_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            borrowings_return_btn.FlatStyle = FlatStyle.Flat;
            borrowings_return_btn.Font = new Font("Yu Gothic UI Semibold", 14F);
            borrowings_return_btn.ForeColor = Color.White;
            borrowings_return_btn.Location = new Point(237, 26);
            borrowings_return_btn.Name = "borrowings_return_btn";
            borrowings_return_btn.Size = new Size(100, 36);
            borrowings_return_btn.TabIndex = 14;
            borrowings_return_btn.Text = "Return";
            borrowings_return_btn.TextColor = Color.White;
            borrowings_return_btn.UseVisualStyleBackColor = false;
            borrowings_return_btn.Click += RemoveBorrowings;
            // 
            // borrowings_lbl1
            // 
            borrowings_lbl1.AutoSize = true;
            borrowings_lbl1.Font = new Font("Yu Gothic UI Semibold", 14F);
            borrowings_lbl1.Location = new Point(52, 80);
            borrowings_lbl1.Name = "borrowings_lbl1";
            borrowings_lbl1.Size = new Size(108, 25);
            borrowings_lbl1.TabIndex = 25;
            borrowings_lbl1.Text = "Borrowings";
            // 
            // borrowings_src
            // 
            borrowings_src.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            borrowings_src.BackColor = Color.White;
            borrowings_src.Font = new Font("Yu Gothic UI Semibold", 14F);
            borrowings_src.Location = new Point(449, 29);
            borrowings_src.MaxLength = 19;
            borrowings_src.Name = "borrowings_src";
            borrowings_src.PlaceholderText = "Search...";
            borrowings_src.Size = new Size(208, 32);
            borrowings_src.TabIndex = 16;
            borrowings_src.TextChanged += SearchBorrowings;
            // 
            // panel_categories
            // 
            panel_categories.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_categories.BackColor = Color.White;
            panel_categories.Controls.Add(categories_grd);
            panel_categories.Controls.Add(categories_refresh_btn);
            panel_categories.Controls.Add(categories_add_btn);
            panel_categories.Controls.Add(categories_edit_btn);
            panel_categories.Controls.Add(categories_remove_btn);
            panel_categories.Controls.Add(categories_lbl1);
            panel_categories.Controls.Add(categories_src);
            panel_categories.Location = new Point(266, 56);
            panel_categories.Name = "panel_categories";
            panel_categories.Size = new Size(709, 493);
            panel_categories.TabIndex = 23;
            panel_categories.Visible = false;
            // 
            // categories_grd
            // 
            categories_grd.AllowUserToAddRows = false;
            categories_grd.AllowUserToDeleteRows = false;
            categories_grd.AllowUserToResizeColumns = false;
            categories_grd.AllowUserToResizeRows = false;
            categories_grd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            categories_grd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            categories_grd.BackgroundColor = Color.White;
            categories_grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            categories_grd.Columns.AddRange(new DataGridViewColumn[] { categories_category });
            categories_grd.Location = new Point(52, 108);
            categories_grd.Name = "categories_grd";
            categories_grd.ReadOnly = true;
            categories_grd.RowHeadersVisible = false;
            categories_grd.RowHeadersWidth = 51;
            categories_grd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            categories_grd.ShowCellErrors = false;
            categories_grd.ShowCellToolTips = false;
            categories_grd.ShowEditingIcon = false;
            categories_grd.ShowRowErrors = false;
            categories_grd.Size = new Size(605, 359);
            categories_grd.StandardTab = true;
            categories_grd.TabIndex = 11;
            // 
            // categories_category
            // 
            categories_category.HeaderText = "Category";
            categories_category.MinimumWidth = 6;
            categories_category.Name = "categories_category";
            categories_category.ReadOnly = true;
            categories_category.Width = 80;
            // 
            // categories_refresh_btn
            // 
            categories_refresh_btn.BackColor = Color.FromArgb(80, 77, 180);
            categories_refresh_btn.BackgroundColor = Color.FromArgb(80, 77, 180);
            categories_refresh_btn.BorderColor = Color.Transparent;
            categories_refresh_btn.BorderRadius = 5;
            categories_refresh_btn.BorderSize = 0;
            categories_refresh_btn.FlatAppearance.BorderSize = 0;
            categories_refresh_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            categories_refresh_btn.FlatStyle = FlatStyle.Flat;
            categories_refresh_btn.Font = new Font("Yu Gothic UI Semibold", 14F);
            categories_refresh_btn.ForeColor = Color.White;
            categories_refresh_btn.Image = (Image)resources.GetObject("categories_refresh_btn.Image");
            categories_refresh_btn.Location = new Point(52, 26);
            categories_refresh_btn.Name = "categories_refresh_btn";
            categories_refresh_btn.Size = new Size(42, 36);
            categories_refresh_btn.TabIndex = 12;
            categories_refresh_btn.TextColor = Color.White;
            categories_refresh_btn.UseVisualStyleBackColor = false;
            categories_refresh_btn.Click += RefreshCategories;
            // 
            // categories_add_btn
            // 
            categories_add_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            categories_add_btn.BackColor = Color.FromArgb(80, 77, 180);
            categories_add_btn.BackgroundColor = Color.FromArgb(80, 77, 180);
            categories_add_btn.BorderColor = Color.Transparent;
            categories_add_btn.BorderRadius = 5;
            categories_add_btn.BorderSize = 0;
            categories_add_btn.FlatAppearance.BorderSize = 0;
            categories_add_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            categories_add_btn.FlatStyle = FlatStyle.Flat;
            categories_add_btn.Font = new Font("Yu Gothic UI Semibold", 14F);
            categories_add_btn.ForeColor = Color.White;
            categories_add_btn.Location = new Point(343, 26);
            categories_add_btn.Name = "categories_add_btn";
            categories_add_btn.Size = new Size(100, 36);
            categories_add_btn.TabIndex = 15;
            categories_add_btn.Text = "Add";
            categories_add_btn.TextColor = Color.White;
            categories_add_btn.UseVisualStyleBackColor = false;
            categories_add_btn.Click += AddCategory;
            // 
            // categories_edit_btn
            // 
            categories_edit_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            categories_edit_btn.BackColor = Color.FromArgb(80, 77, 180);
            categories_edit_btn.BackgroundColor = Color.FromArgb(80, 77, 180);
            categories_edit_btn.BorderColor = Color.Transparent;
            categories_edit_btn.BorderRadius = 5;
            categories_edit_btn.BorderSize = 0;
            categories_edit_btn.FlatAppearance.BorderSize = 0;
            categories_edit_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            categories_edit_btn.FlatStyle = FlatStyle.Flat;
            categories_edit_btn.Font = new Font("Yu Gothic UI Semibold", 14F);
            categories_edit_btn.ForeColor = Color.White;
            categories_edit_btn.Location = new Point(131, 26);
            categories_edit_btn.Name = "categories_edit_btn";
            categories_edit_btn.Size = new Size(100, 36);
            categories_edit_btn.TabIndex = 13;
            categories_edit_btn.Text = "Edit";
            categories_edit_btn.TextColor = Color.White;
            categories_edit_btn.UseVisualStyleBackColor = false;
            categories_edit_btn.Click += EditCategory;
            // 
            // categories_remove_btn
            // 
            categories_remove_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            categories_remove_btn.BackColor = Color.FromArgb(80, 77, 180);
            categories_remove_btn.BackgroundColor = Color.FromArgb(80, 77, 180);
            categories_remove_btn.BorderColor = Color.Transparent;
            categories_remove_btn.BorderRadius = 5;
            categories_remove_btn.BorderSize = 0;
            categories_remove_btn.FlatAppearance.BorderSize = 0;
            categories_remove_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            categories_remove_btn.FlatStyle = FlatStyle.Flat;
            categories_remove_btn.Font = new Font("Yu Gothic UI Semibold", 14F);
            categories_remove_btn.ForeColor = Color.White;
            categories_remove_btn.Location = new Point(237, 26);
            categories_remove_btn.Name = "categories_remove_btn";
            categories_remove_btn.Size = new Size(100, 36);
            categories_remove_btn.TabIndex = 14;
            categories_remove_btn.Text = "Remove";
            categories_remove_btn.TextColor = Color.White;
            categories_remove_btn.UseVisualStyleBackColor = false;
            categories_remove_btn.Click += RemoveCategories;
            // 
            // categories_lbl1
            // 
            categories_lbl1.AutoSize = true;
            categories_lbl1.Font = new Font("Yu Gothic UI Semibold", 14F);
            categories_lbl1.Location = new Point(52, 80);
            categories_lbl1.Name = "categories_lbl1";
            categories_lbl1.Size = new Size(103, 25);
            categories_lbl1.TabIndex = 18;
            categories_lbl1.Text = "Categories";
            // 
            // categories_src
            // 
            categories_src.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            categories_src.BackColor = Color.White;
            categories_src.Font = new Font("Yu Gothic UI Semibold", 14F);
            categories_src.Location = new Point(449, 29);
            categories_src.MaxLength = 19;
            categories_src.Name = "categories_src";
            categories_src.PlaceholderText = "Search...";
            categories_src.Size = new Size(208, 32);
            categories_src.TabIndex = 16;
            categories_src.TextChanged += SearchCategories;
            // 
            // panel_users
            // 
            panel_users.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_users.Controls.Add(users_grd);
            panel_users.Controls.Add(users_button_add);
            panel_users.Controls.Add(roundedButton1);
            panel_users.Controls.Add(users_button_edit);
            panel_users.Controls.Add(users_button_remove);
            panel_users.Controls.Add(users_lbl1);
            panel_users.Controls.Add(users_src);
            panel_users.Location = new Point(266, 56);
            panel_users.Name = "panel_users";
            panel_users.Size = new Size(709, 493);
            panel_users.TabIndex = 24;
            panel_users.Visible = false;
            // 
            // users_grd
            // 
            users_grd.AllowUserToAddRows = false;
            users_grd.AllowUserToDeleteRows = false;
            users_grd.AllowUserToResizeColumns = false;
            users_grd.AllowUserToResizeRows = false;
            users_grd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            users_grd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            users_grd.BackgroundColor = Color.White;
            users_grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            users_grd.Columns.AddRange(new DataGridViewColumn[] { users_firstName, users_lastName, users_dateOfBirth, users_address, users_verified, users_username, users_email, users_role });
            users_grd.Location = new Point(52, 108);
            users_grd.Name = "users_grd";
            users_grd.ReadOnly = true;
            users_grd.RowHeadersVisible = false;
            users_grd.RowHeadersWidth = 51;
            users_grd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            users_grd.ShowCellErrors = false;
            users_grd.ShowCellToolTips = false;
            users_grd.ShowEditingIcon = false;
            users_grd.ShowRowErrors = false;
            users_grd.Size = new Size(605, 359);
            users_grd.StandardTab = true;
            users_grd.TabIndex = 11;
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
            // users_button_add
            // 
            users_button_add.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            users_button_add.BackColor = Color.FromArgb(80, 77, 180);
            users_button_add.BackgroundColor = Color.FromArgb(80, 77, 180);
            users_button_add.BorderColor = Color.Transparent;
            users_button_add.BorderRadius = 5;
            users_button_add.BorderSize = 0;
            users_button_add.FlatAppearance.BorderSize = 0;
            users_button_add.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            users_button_add.FlatStyle = FlatStyle.Flat;
            users_button_add.Font = new Font("Yu Gothic UI Semibold", 14F);
            users_button_add.ForeColor = Color.White;
            users_button_add.Location = new Point(344, 26);
            users_button_add.Name = "users_button_add";
            users_button_add.Size = new Size(100, 36);
            users_button_add.TabIndex = 15;
            users_button_add.Text = "Add";
            users_button_add.TextColor = Color.White;
            users_button_add.UseVisualStyleBackColor = false;
            users_button_add.Click += AddUser;
            // 
            // roundedButton1
            // 
            roundedButton1.BackColor = Color.FromArgb(80, 77, 180);
            roundedButton1.BackgroundColor = Color.FromArgb(80, 77, 180);
            roundedButton1.BorderColor = Color.Transparent;
            roundedButton1.BorderRadius = 5;
            roundedButton1.BorderSize = 0;
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.Font = new Font("Yu Gothic UI Semibold", 14F);
            roundedButton1.ForeColor = Color.White;
            roundedButton1.Image = (Image)resources.GetObject("roundedButton1.Image");
            roundedButton1.Location = new Point(52, 26);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(42, 36);
            roundedButton1.TabIndex = 12;
            roundedButton1.TextColor = Color.White;
            roundedButton1.UseVisualStyleBackColor = false;
            roundedButton1.Click += RefreshUsers;
            // 
            // users_button_edit
            // 
            users_button_edit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            users_button_edit.BackColor = Color.FromArgb(80, 77, 180);
            users_button_edit.BackgroundColor = Color.FromArgb(80, 77, 180);
            users_button_edit.BorderColor = Color.Transparent;
            users_button_edit.BorderRadius = 5;
            users_button_edit.BorderSize = 0;
            users_button_edit.FlatAppearance.BorderSize = 0;
            users_button_edit.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            users_button_edit.FlatStyle = FlatStyle.Flat;
            users_button_edit.Font = new Font("Yu Gothic UI Semibold", 14F);
            users_button_edit.ForeColor = Color.White;
            users_button_edit.Location = new Point(132, 26);
            users_button_edit.Name = "users_button_edit";
            users_button_edit.Size = new Size(100, 36);
            users_button_edit.TabIndex = 13;
            users_button_edit.Text = "Edit";
            users_button_edit.TextColor = Color.White;
            users_button_edit.UseVisualStyleBackColor = false;
            users_button_edit.Click += EditUser;
            // 
            // users_button_remove
            // 
            users_button_remove.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            users_button_remove.BackColor = Color.FromArgb(80, 77, 180);
            users_button_remove.BackgroundColor = Color.FromArgb(80, 77, 180);
            users_button_remove.BorderColor = Color.Transparent;
            users_button_remove.BorderRadius = 5;
            users_button_remove.BorderSize = 0;
            users_button_remove.FlatAppearance.BorderSize = 0;
            users_button_remove.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            users_button_remove.FlatStyle = FlatStyle.Flat;
            users_button_remove.Font = new Font("Yu Gothic UI Semibold", 14F);
            users_button_remove.ForeColor = Color.White;
            users_button_remove.Location = new Point(238, 26);
            users_button_remove.Name = "users_button_remove";
            users_button_remove.Size = new Size(100, 36);
            users_button_remove.TabIndex = 14;
            users_button_remove.Text = "Remove";
            users_button_remove.TextColor = Color.White;
            users_button_remove.UseVisualStyleBackColor = false;
            users_button_remove.Click += RemoveUsers;
            // 
            // users_lbl1
            // 
            users_lbl1.AutoSize = true;
            users_lbl1.Font = new Font("Yu Gothic UI Semibold", 14F);
            users_lbl1.Location = new Point(52, 80);
            users_lbl1.Name = "users_lbl1";
            users_lbl1.Size = new Size(58, 25);
            users_lbl1.TabIndex = 11;
            users_lbl1.Text = "Users";
            // 
            // users_src
            // 
            users_src.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            users_src.BackColor = Color.White;
            users_src.Font = new Font("Yu Gothic UI Semibold", 14F);
            users_src.Location = new Point(449, 29);
            users_src.MaxLength = 19;
            users_src.Name = "users_src";
            users_src.PlaceholderText = "Search...";
            users_src.Size = new Size(208, 32);
            users_src.TabIndex = 16;
            users_src.TextChanged += SearchUsers;
            // 
            // panel_authors
            // 
            panel_authors.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_authors.BackColor = Color.White;
            panel_authors.Controls.Add(authors_grd);
            panel_authors.Controls.Add(authors_refresh_btn);
            panel_authors.Controls.Add(authors_add_btn);
            panel_authors.Controls.Add(authors_edit_btn);
            panel_authors.Controls.Add(authors_remove_btn);
            panel_authors.Controls.Add(authors_lbl1);
            panel_authors.Controls.Add(authors_src);
            panel_authors.Location = new Point(266, 56);
            panel_authors.Name = "panel_authors";
            panel_authors.Size = new Size(709, 493);
            panel_authors.TabIndex = 25;
            panel_authors.Visible = false;
            // 
            // authors_grd
            // 
            authors_grd.AllowUserToAddRows = false;
            authors_grd.AllowUserToDeleteRows = false;
            authors_grd.AllowUserToResizeColumns = false;
            authors_grd.AllowUserToResizeRows = false;
            authors_grd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            authors_grd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            authors_grd.BackgroundColor = Color.White;
            authors_grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            authors_grd.Columns.AddRange(new DataGridViewColumn[] { authors_author });
            authors_grd.Location = new Point(52, 108);
            authors_grd.Name = "authors_grd";
            authors_grd.ReadOnly = true;
            authors_grd.RowHeadersVisible = false;
            authors_grd.RowHeadersWidth = 51;
            authors_grd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            authors_grd.ShowCellErrors = false;
            authors_grd.ShowCellToolTips = false;
            authors_grd.ShowEditingIcon = false;
            authors_grd.ShowRowErrors = false;
            authors_grd.Size = new Size(605, 359);
            authors_grd.StandardTab = true;
            authors_grd.TabIndex = 11;
            // 
            // authors_author
            // 
            authors_author.HeaderText = "Author";
            authors_author.MinimumWidth = 6;
            authors_author.Name = "authors_author";
            authors_author.ReadOnly = true;
            authors_author.Width = 69;
            // 
            // authors_refresh_btn
            // 
            authors_refresh_btn.BackColor = Color.FromArgb(80, 77, 180);
            authors_refresh_btn.BackgroundColor = Color.FromArgb(80, 77, 180);
            authors_refresh_btn.BorderColor = Color.Transparent;
            authors_refresh_btn.BorderRadius = 5;
            authors_refresh_btn.BorderSize = 0;
            authors_refresh_btn.FlatAppearance.BorderSize = 0;
            authors_refresh_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            authors_refresh_btn.FlatStyle = FlatStyle.Flat;
            authors_refresh_btn.Font = new Font("Yu Gothic UI Semibold", 14F);
            authors_refresh_btn.ForeColor = Color.White;
            authors_refresh_btn.Image = (Image)resources.GetObject("authors_refresh_btn.Image");
            authors_refresh_btn.Location = new Point(52, 26);
            authors_refresh_btn.Name = "authors_refresh_btn";
            authors_refresh_btn.Size = new Size(42, 36);
            authors_refresh_btn.TabIndex = 12;
            authors_refresh_btn.TextColor = Color.White;
            authors_refresh_btn.UseVisualStyleBackColor = false;
            authors_refresh_btn.Click += RefreshAuthors;
            // 
            // authors_add_btn
            // 
            authors_add_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            authors_add_btn.BackColor = Color.FromArgb(80, 77, 180);
            authors_add_btn.BackgroundColor = Color.FromArgb(80, 77, 180);
            authors_add_btn.BorderColor = Color.Transparent;
            authors_add_btn.BorderRadius = 5;
            authors_add_btn.BorderSize = 0;
            authors_add_btn.FlatAppearance.BorderSize = 0;
            authors_add_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            authors_add_btn.FlatStyle = FlatStyle.Flat;
            authors_add_btn.Font = new Font("Yu Gothic UI Semibold", 14F);
            authors_add_btn.ForeColor = Color.White;
            authors_add_btn.Location = new Point(343, 26);
            authors_add_btn.Name = "authors_add_btn";
            authors_add_btn.Size = new Size(100, 36);
            authors_add_btn.TabIndex = 15;
            authors_add_btn.Text = "Add";
            authors_add_btn.TextColor = Color.White;
            authors_add_btn.UseVisualStyleBackColor = false;
            authors_add_btn.Click += AddAuthor;
            // 
            // authors_edit_btn
            // 
            authors_edit_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            authors_edit_btn.BackColor = Color.FromArgb(80, 77, 180);
            authors_edit_btn.BackgroundColor = Color.FromArgb(80, 77, 180);
            authors_edit_btn.BorderColor = Color.Transparent;
            authors_edit_btn.BorderRadius = 5;
            authors_edit_btn.BorderSize = 0;
            authors_edit_btn.FlatAppearance.BorderSize = 0;
            authors_edit_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            authors_edit_btn.FlatStyle = FlatStyle.Flat;
            authors_edit_btn.Font = new Font("Yu Gothic UI Semibold", 14F);
            authors_edit_btn.ForeColor = Color.White;
            authors_edit_btn.Location = new Point(131, 26);
            authors_edit_btn.Name = "authors_edit_btn";
            authors_edit_btn.Size = new Size(100, 36);
            authors_edit_btn.TabIndex = 13;
            authors_edit_btn.Text = "Edit";
            authors_edit_btn.TextColor = Color.White;
            authors_edit_btn.UseVisualStyleBackColor = false;
            authors_edit_btn.Click += EditAuthor;
            // 
            // authors_remove_btn
            // 
            authors_remove_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            authors_remove_btn.BackColor = Color.FromArgb(80, 77, 180);
            authors_remove_btn.BackgroundColor = Color.FromArgb(80, 77, 180);
            authors_remove_btn.BorderColor = Color.Transparent;
            authors_remove_btn.BorderRadius = 5;
            authors_remove_btn.BorderSize = 0;
            authors_remove_btn.FlatAppearance.BorderSize = 0;
            authors_remove_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            authors_remove_btn.FlatStyle = FlatStyle.Flat;
            authors_remove_btn.Font = new Font("Yu Gothic UI Semibold", 14F);
            authors_remove_btn.ForeColor = Color.White;
            authors_remove_btn.Location = new Point(237, 26);
            authors_remove_btn.Name = "authors_remove_btn";
            authors_remove_btn.Size = new Size(100, 36);
            authors_remove_btn.TabIndex = 14;
            authors_remove_btn.Text = "Remove";
            authors_remove_btn.TextColor = Color.White;
            authors_remove_btn.UseVisualStyleBackColor = false;
            authors_remove_btn.Click += RemoveAuthors;
            // 
            // authors_lbl1
            // 
            authors_lbl1.AutoSize = true;
            authors_lbl1.Font = new Font("Yu Gothic UI Semibold", 14F);
            authors_lbl1.Location = new Point(52, 80);
            authors_lbl1.Name = "authors_lbl1";
            authors_lbl1.Size = new Size(80, 25);
            authors_lbl1.TabIndex = 18;
            authors_lbl1.Text = "Authors";
            // 
            // authors_src
            // 
            authors_src.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            authors_src.BackColor = Color.White;
            authors_src.Font = new Font("Yu Gothic UI Semibold", 14F);
            authors_src.Location = new Point(449, 29);
            authors_src.MaxLength = 19;
            authors_src.Name = "authors_src";
            authors_src.PlaceholderText = "Search...";
            authors_src.Size = new Size(208, 32);
            authors_src.TabIndex = 16;
            authors_src.TabStop = false;
            authors_src.TextChanged += SearchAuthors;
            // 
            // panel_publishers
            // 
            panel_publishers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_publishers.AutoSize = true;
            panel_publishers.BackColor = Color.White;
            panel_publishers.Controls.Add(publishers_grd);
            panel_publishers.Controls.Add(publishers_refresh_btn);
            panel_publishers.Controls.Add(publishers_add_btn);
            panel_publishers.Controls.Add(publishers_edit_btn);
            panel_publishers.Controls.Add(publishers_remove_btn);
            panel_publishers.Controls.Add(publishers_lbl1);
            panel_publishers.Controls.Add(publishers_src);
            panel_publishers.Location = new Point(266, 56);
            panel_publishers.Name = "panel_publishers";
            panel_publishers.Size = new Size(709, 493);
            panel_publishers.TabIndex = 26;
            panel_publishers.Visible = false;
            // 
            // publishers_grd
            // 
            publishers_grd.AllowUserToAddRows = false;
            publishers_grd.AllowUserToDeleteRows = false;
            publishers_grd.AllowUserToResizeColumns = false;
            publishers_grd.AllowUserToResizeRows = false;
            publishers_grd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            publishers_grd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            publishers_grd.BackgroundColor = Color.White;
            publishers_grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            publishers_grd.Columns.AddRange(new DataGridViewColumn[] { publishers_publisher });
            publishers_grd.Location = new Point(52, 108);
            publishers_grd.Name = "publishers_grd";
            publishers_grd.ReadOnly = true;
            publishers_grd.RowHeadersVisible = false;
            publishers_grd.RowHeadersWidth = 51;
            publishers_grd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            publishers_grd.ShowCellErrors = false;
            publishers_grd.ShowCellToolTips = false;
            publishers_grd.ShowEditingIcon = false;
            publishers_grd.ShowRowErrors = false;
            publishers_grd.Size = new Size(605, 359);
            publishers_grd.StandardTab = true;
            publishers_grd.TabIndex = 11;
            // 
            // publishers_publisher
            // 
            publishers_publisher.HeaderText = "Publisher";
            publishers_publisher.MinimumWidth = 6;
            publishers_publisher.Name = "publishers_publisher";
            publishers_publisher.ReadOnly = true;
            publishers_publisher.Width = 81;
            // 
            // publishers_refresh_btn
            // 
            publishers_refresh_btn.BackColor = Color.FromArgb(80, 77, 180);
            publishers_refresh_btn.BackgroundColor = Color.FromArgb(80, 77, 180);
            publishers_refresh_btn.BorderColor = Color.Transparent;
            publishers_refresh_btn.BorderRadius = 5;
            publishers_refresh_btn.BorderSize = 0;
            publishers_refresh_btn.FlatAppearance.BorderSize = 0;
            publishers_refresh_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            publishers_refresh_btn.FlatStyle = FlatStyle.Flat;
            publishers_refresh_btn.Font = new Font("Yu Gothic UI Semibold", 14F);
            publishers_refresh_btn.ForeColor = Color.White;
            publishers_refresh_btn.Image = (Image)resources.GetObject("publishers_refresh_btn.Image");
            publishers_refresh_btn.Location = new Point(52, 26);
            publishers_refresh_btn.Name = "publishers_refresh_btn";
            publishers_refresh_btn.Size = new Size(42, 36);
            publishers_refresh_btn.TabIndex = 12;
            publishers_refresh_btn.TextColor = Color.White;
            publishers_refresh_btn.UseVisualStyleBackColor = false;
            publishers_refresh_btn.Click += RefreshPublishers;
            // 
            // publishers_add_btn
            // 
            publishers_add_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            publishers_add_btn.BackColor = Color.FromArgb(80, 77, 180);
            publishers_add_btn.BackgroundColor = Color.FromArgb(80, 77, 180);
            publishers_add_btn.BorderColor = Color.Transparent;
            publishers_add_btn.BorderRadius = 5;
            publishers_add_btn.BorderSize = 0;
            publishers_add_btn.FlatAppearance.BorderSize = 0;
            publishers_add_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            publishers_add_btn.FlatStyle = FlatStyle.Flat;
            publishers_add_btn.Font = new Font("Yu Gothic UI Semibold", 14F);
            publishers_add_btn.ForeColor = Color.White;
            publishers_add_btn.Location = new Point(343, 26);
            publishers_add_btn.Name = "publishers_add_btn";
            publishers_add_btn.Size = new Size(100, 36);
            publishers_add_btn.TabIndex = 15;
            publishers_add_btn.Text = "Add";
            publishers_add_btn.TextColor = Color.White;
            publishers_add_btn.UseVisualStyleBackColor = false;
            publishers_add_btn.Click += AddPublisher;
            // 
            // publishers_edit_btn
            // 
            publishers_edit_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            publishers_edit_btn.BackColor = Color.FromArgb(80, 77, 180);
            publishers_edit_btn.BackgroundColor = Color.FromArgb(80, 77, 180);
            publishers_edit_btn.BorderColor = Color.Transparent;
            publishers_edit_btn.BorderRadius = 5;
            publishers_edit_btn.BorderSize = 0;
            publishers_edit_btn.FlatAppearance.BorderSize = 0;
            publishers_edit_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            publishers_edit_btn.FlatStyle = FlatStyle.Flat;
            publishers_edit_btn.Font = new Font("Yu Gothic UI Semibold", 14F);
            publishers_edit_btn.ForeColor = Color.White;
            publishers_edit_btn.Location = new Point(131, 26);
            publishers_edit_btn.Name = "publishers_edit_btn";
            publishers_edit_btn.Size = new Size(100, 36);
            publishers_edit_btn.TabIndex = 13;
            publishers_edit_btn.Text = "Edit";
            publishers_edit_btn.TextColor = Color.White;
            publishers_edit_btn.UseVisualStyleBackColor = false;
            publishers_edit_btn.Click += EditPublisher;
            // 
            // publishers_remove_btn
            // 
            publishers_remove_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            publishers_remove_btn.BackColor = Color.FromArgb(80, 77, 180);
            publishers_remove_btn.BackgroundColor = Color.FromArgb(80, 77, 180);
            publishers_remove_btn.BorderColor = Color.Transparent;
            publishers_remove_btn.BorderRadius = 5;
            publishers_remove_btn.BorderSize = 0;
            publishers_remove_btn.FlatAppearance.BorderSize = 0;
            publishers_remove_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            publishers_remove_btn.FlatStyle = FlatStyle.Flat;
            publishers_remove_btn.Font = new Font("Yu Gothic UI Semibold", 14F);
            publishers_remove_btn.ForeColor = Color.White;
            publishers_remove_btn.Location = new Point(237, 26);
            publishers_remove_btn.Name = "publishers_remove_btn";
            publishers_remove_btn.Size = new Size(100, 36);
            publishers_remove_btn.TabIndex = 14;
            publishers_remove_btn.Text = "Remove";
            publishers_remove_btn.TextColor = Color.White;
            publishers_remove_btn.UseVisualStyleBackColor = false;
            publishers_remove_btn.Click += RemovePublishers;
            // 
            // publishers_lbl1
            // 
            publishers_lbl1.AutoSize = true;
            publishers_lbl1.Font = new Font("Yu Gothic UI Semibold", 14F);
            publishers_lbl1.Location = new Point(52, 80);
            publishers_lbl1.Name = "publishers_lbl1";
            publishers_lbl1.Size = new Size(99, 25);
            publishers_lbl1.TabIndex = 18;
            publishers_lbl1.Text = "Publishers";
            // 
            // publishers_src
            // 
            publishers_src.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            publishers_src.BackColor = Color.White;
            publishers_src.Font = new Font("Yu Gothic UI Semibold", 14F);
            publishers_src.Location = new Point(449, 29);
            publishers_src.MaxLength = 19;
            publishers_src.Name = "publishers_src";
            publishers_src.PlaceholderText = "Search...";
            publishers_src.Size = new Size(208, 32);
            publishers_src.TabIndex = 16;
            publishers_src.TextChanged += SearchPublishers;
            // 
            // panel_reservations
            // 
            panel_reservations.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_reservations.BackColor = Color.White;
            panel_reservations.Controls.Add(reservations_grd);
            panel_reservations.Controls.Add(reservations_refresh_btn);
            panel_reservations.Controls.Add(reservation_add_btn);
            panel_reservations.Controls.Add(reservations_edit_btn);
            panel_reservations.Controls.Add(reservations_remove_btn);
            panel_reservations.Controls.Add(label5);
            panel_reservations.Controls.Add(reservations_src);
            panel_reservations.Location = new Point(266, 56);
            panel_reservations.Name = "panel_reservations";
            panel_reservations.Size = new Size(710, 493);
            panel_reservations.TabIndex = 27;
            panel_reservations.Visible = false;
            // 
            // reservations_grd
            // 
            reservations_grd.AllowUserToAddRows = false;
            reservations_grd.AllowUserToDeleteRows = false;
            reservations_grd.AllowUserToResizeColumns = false;
            reservations_grd.AllowUserToResizeRows = false;
            reservations_grd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            reservations_grd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            reservations_grd.BackgroundColor = Color.White;
            reservations_grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            reservations_grd.Columns.AddRange(new DataGridViewColumn[] { reservations_username, reservations_title, reservations_isbn, reservations_startDate, reservations_endDate });
            reservations_grd.Location = new Point(52, 108);
            reservations_grd.Name = "reservations_grd";
            reservations_grd.ReadOnly = true;
            reservations_grd.RowHeadersVisible = false;
            reservations_grd.RowHeadersWidth = 51;
            reservations_grd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            reservations_grd.ShowCellErrors = false;
            reservations_grd.ShowCellToolTips = false;
            reservations_grd.ShowEditingIcon = false;
            reservations_grd.ShowRowErrors = false;
            reservations_grd.Size = new Size(605, 359);
            reservations_grd.StandardTab = true;
            reservations_grd.TabIndex = 11;
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
            // reservations_refresh_btn
            // 
            reservations_refresh_btn.BackColor = Color.FromArgb(80, 77, 180);
            reservations_refresh_btn.BackgroundColor = Color.FromArgb(80, 77, 180);
            reservations_refresh_btn.BorderColor = Color.Transparent;
            reservations_refresh_btn.BorderRadius = 5;
            reservations_refresh_btn.BorderSize = 0;
            reservations_refresh_btn.FlatAppearance.BorderSize = 0;
            reservations_refresh_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            reservations_refresh_btn.FlatStyle = FlatStyle.Flat;
            reservations_refresh_btn.Font = new Font("Yu Gothic UI Semibold", 14F);
            reservations_refresh_btn.ForeColor = Color.White;
            reservations_refresh_btn.Image = (Image)resources.GetObject("reservations_refresh_btn.Image");
            reservations_refresh_btn.Location = new Point(52, 26);
            reservations_refresh_btn.Name = "reservations_refresh_btn";
            reservations_refresh_btn.Size = new Size(42, 36);
            reservations_refresh_btn.TabIndex = 12;
            reservations_refresh_btn.TextColor = Color.White;
            reservations_refresh_btn.UseVisualStyleBackColor = false;
            reservations_refresh_btn.Click += RefreshReservations;
            // 
            // reservation_add_btn
            // 
            reservation_add_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            reservation_add_btn.BackColor = Color.FromArgb(80, 77, 180);
            reservation_add_btn.BackgroundColor = Color.FromArgb(80, 77, 180);
            reservation_add_btn.BorderColor = Color.Transparent;
            reservation_add_btn.BorderRadius = 5;
            reservation_add_btn.BorderSize = 0;
            reservation_add_btn.FlatAppearance.BorderSize = 0;
            reservation_add_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            reservation_add_btn.FlatStyle = FlatStyle.Flat;
            reservation_add_btn.Font = new Font("Yu Gothic UI Semibold", 14F);
            reservation_add_btn.ForeColor = Color.White;
            reservation_add_btn.Location = new Point(342, 26);
            reservation_add_btn.Name = "reservation_add_btn";
            reservation_add_btn.Size = new Size(100, 36);
            reservation_add_btn.TabIndex = 15;
            reservation_add_btn.Text = "Add";
            reservation_add_btn.TextColor = Color.White;
            reservation_add_btn.UseVisualStyleBackColor = false;
            reservation_add_btn.Click += AddReservation;
            // 
            // reservations_edit_btn
            // 
            reservations_edit_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            reservations_edit_btn.BackColor = Color.FromArgb(80, 77, 180);
            reservations_edit_btn.BackgroundColor = Color.FromArgb(80, 77, 180);
            reservations_edit_btn.BorderColor = Color.Transparent;
            reservations_edit_btn.BorderRadius = 5;
            reservations_edit_btn.BorderSize = 0;
            reservations_edit_btn.FlatAppearance.BorderSize = 0;
            reservations_edit_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            reservations_edit_btn.FlatStyle = FlatStyle.Flat;
            reservations_edit_btn.Font = new Font("Yu Gothic UI Semibold", 14F);
            reservations_edit_btn.ForeColor = Color.White;
            reservations_edit_btn.Location = new Point(130, 26);
            reservations_edit_btn.Name = "reservations_edit_btn";
            reservations_edit_btn.Size = new Size(100, 36);
            reservations_edit_btn.TabIndex = 13;
            reservations_edit_btn.Text = "Extend";
            reservations_edit_btn.TextColor = Color.White;
            reservations_edit_btn.UseVisualStyleBackColor = false;
            reservations_edit_btn.Click += EditReservation;
            // 
            // reservations_remove_btn
            // 
            reservations_remove_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            reservations_remove_btn.BackColor = Color.FromArgb(80, 77, 180);
            reservations_remove_btn.BackgroundColor = Color.FromArgb(80, 77, 180);
            reservations_remove_btn.BorderColor = Color.Transparent;
            reservations_remove_btn.BorderRadius = 5;
            reservations_remove_btn.BorderSize = 0;
            reservations_remove_btn.FlatAppearance.BorderSize = 0;
            reservations_remove_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            reservations_remove_btn.FlatStyle = FlatStyle.Flat;
            reservations_remove_btn.Font = new Font("Yu Gothic UI Semibold", 14F);
            reservations_remove_btn.ForeColor = Color.White;
            reservations_remove_btn.Location = new Point(236, 26);
            reservations_remove_btn.Name = "reservations_remove_btn";
            reservations_remove_btn.Size = new Size(100, 36);
            reservations_remove_btn.TabIndex = 14;
            reservations_remove_btn.Text = "Cancel";
            reservations_remove_btn.TextColor = Color.White;
            reservations_remove_btn.UseVisualStyleBackColor = false;
            reservations_remove_btn.Click += RemoveReservations;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI Semibold", 14F);
            label5.Location = new Point(52, 80);
            label5.Name = "label5";
            label5.Size = new Size(121, 25);
            label5.TabIndex = 25;
            label5.Text = "Reservations";
            // 
            // reservations_src
            // 
            reservations_src.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            reservations_src.BackColor = Color.White;
            reservations_src.Font = new Font("Yu Gothic UI Semibold", 14F);
            reservations_src.Location = new Point(448, 29);
            reservations_src.MaxLength = 19;
            reservations_src.Name = "reservations_src";
            reservations_src.PlaceholderText = "Search...";
            reservations_src.Size = new Size(208, 32);
            reservations_src.TabIndex = 16;
            reservations_src.TextChanged += SearchReservations;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(984, 561);
            Controls.Add(panel_header);
            Controls.Add(panel_menu);
            Controls.Add(panel_publishers);
            Controls.Add(panel_authors);
            Controls.Add(panel_categories);
            Controls.Add(panel_reservations);
            Controls.Add(panel_borrowings);
            Controls.Add(panel_users);
            Controls.Add(panel_books);
            Controls.Add(panel_dashboard);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1000, 592);
            Name = "AdminPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Panel";
            Load += OnLoad;
            panel_menu.ResumeLayout(false);
            panel_menu.PerformLayout();
            panel_header.ResumeLayout(false);
            panel_header.PerformLayout();
            panel_dashboard.ResumeLayout(false);
            panel_dashboard.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grid_dashboard).EndInit();
            panel_books.ResumeLayout(false);
            panel_books.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)books_grd).EndInit();
            panel_borrowings.ResumeLayout(false);
            panel_borrowings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)borrowings_grd).EndInit();
            panel_categories.ResumeLayout(false);
            panel_categories.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)categories_grd).EndInit();
            panel_users.ResumeLayout(false);
            panel_users.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)users_grd).EndInit();
            panel_authors.ResumeLayout(false);
            panel_authors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)authors_grd).EndInit();
            panel_publishers.ResumeLayout(false);
            panel_publishers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)publishers_grd).EndInit();
            panel_reservations.ResumeLayout(false);
            panel_reservations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)reservations_grd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel_menu;
        private Button dashboard_btn;
        private Panel panel_header;
        private Label label_title;
        private Button categories_btn;
        private Button borrowings_btn;
        private Button users_btn;
        private Button books_btn;
        private Label label_greeting;
        private Label label1;
        private Panel panel_dashboard;
        private Label label4;
        private DataGridView grid_dashboard;
        private Panel panel_books;
        private Label books_lbl1;
        private RoundedButton books_refresh_btn;
        private RoundedButton dashboard_books;
        private TextBox books_src;
        private Panel panel_borrowings;
        private RoundedButton logout_btn;
        private Panel divider_pnl1;
        private Panel divider_pnl3;
        private Panel panel_categories;
        private RoundedButton categories_refresh_btn;
        private RoundedButton categories_add_btn;
        private RoundedButton categories_edit_btn;
        private RoundedButton categories_remove_btn;
        private Label users_lbl1;
        private TextBox categories_src;
        private Label categories_lbl1;
        private RoundedButton borrowings_refresh_btn;
        private RoundedButton borrowings_borrow_btn;
        private RoundedButton borrowings_edit_btn;
        private RoundedButton borrowings_return_btn;
        private Label borrowings_lbl1;
        private TextBox borrowings_src;
        private Panel panel_users;
        private TextBox users_src;
        private Panel panel1;
        private Button button1;
        private Panel panel2;
        private Button button2;
        private Panel panel_authors;
        private RoundedButton authors_refresh_btn;
        private RoundedButton authors_add_btn;
        private RoundedButton authors_edit_btn;
        private RoundedButton authors_remove_btn;
        private Label authors_lbl1;
        private TextBox authors_src;
        private Panel panel_publishers;
        private RoundedButton publishers_refresh_btn;
        private RoundedButton publishers_add_btn;
        private RoundedButton publishers_edit_btn;
        private RoundedButton publishers_remove_btn;
        private Label publishers_lbl1;
        private TextBox publishers_src;
        private Panel panel3;
        private Panel panel4;
        private RoundedButton dashboard_users;
        private Label label2;
        private Panel panel5;
        private RoundedButton dashboard_borrowings;
        private Label label3;
        private Panel panel6;
        private DataGridView books_grd;
        private DataGridView borrowings_grd;
        private DataGridViewTextBoxColumn dashboard_count;
        private DataGridViewTextBoxColumn dashboard_title;
        private DataGridViewTextBoxColumn dashboard_author;
        private DataGridViewTextBoxColumn dashboard_publicationYear;
        private DataGridViewTextBoxColumn dashboard_category;
        private CheckBox checkBox_currentBorrowings;
        private RoundedButton roundedButton1;
        private DataGridViewTextBoxColumn borrowings_username;
        private DataGridViewTextBoxColumn borrowings_title;
        private DataGridViewTextBoxColumn borrowings_isbn;
        private DataGridViewTextBoxColumn borrowings_borrowDate;
        private DataGridViewTextBoxColumn borrowings_dueDate;
        private DataGridViewTextBoxColumn borrowings_returnDate;
        private DataGridView categories_grd;
        private DataGridViewTextBoxColumn categories_category;
        private RoundedButton users_button_add;
        private RoundedButton users_button_edit;
        private RoundedButton users_button_remove;
        private RoundedButton roundedButton5;
        private RoundedButton roundedButton6;
        private RoundedButton roundedButton7;
        private DataGridView users_grd;
        private DataGridView authors_grd;
        private DataGridView publishers_grd;
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
        private Panel divider_pnl4;
        private Panel divider_pnl;
        private Panel panel7;
        private Button reservations_btn;
        private Panel panel_reservations;
        private DataGridView reservations_grd;
        private RoundedButton reservations_refresh_btn;
        private RoundedButton reservation_add_btn;
        private RoundedButton reservations_edit_btn;
        private RoundedButton reservations_remove_btn;
        private Label label5;
        private TextBox reservations_src;
        private DataGridViewTextBoxColumn reservations_username;
        private DataGridViewTextBoxColumn reservations_title;
        private DataGridViewTextBoxColumn reservations_isbn;
        private DataGridViewTextBoxColumn reservations_startDate;
        private DataGridViewTextBoxColumn reservations_endDate;
    }
}