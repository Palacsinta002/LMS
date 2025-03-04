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
            menu_pnl = new Panel();
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
            header_pnl = new Panel();
            hello_lbl = new Label();
            title_lbl = new Label();
            dashboard_pnl = new Panel();
            panel5 = new Panel();
            dashboard_borrowings = new RoundedButton();
            label3 = new Label();
            panel4 = new Panel();
            dashboard_users = new RoundedButton();
            label2 = new Label();
            panel3 = new Panel();
            dashboard_books = new RoundedButton();
            panel6 = new Panel();
            dashboard_grd = new DataGridView();
            dashboard_count = new DataGridViewTextBoxColumn();
            dashboard_title = new DataGridViewTextBoxColumn();
            dashboard_author = new DataGridViewTextBoxColumn();
            dashboard_publicationYear = new DataGridViewTextBoxColumn();
            dashboard_category = new DataGridViewTextBoxColumn();
            label4 = new Label();
            books_pnl = new Panel();
            books_refresh_btn = new RoundedButton();
            books_lbl1 = new Label();
            books_src = new TextBox();
            books_grd = new DataGridView();
            title = new DataGridViewTextBoxColumn();
            author = new DataGridViewTextBoxColumn();
            publicationYear = new DataGridViewTextBoxColumn();
            category = new DataGridViewTextBoxColumn();
            publisher = new DataGridViewTextBoxColumn();
            isbn = new DataGridViewTextBoxColumn();
            borrowings_pnl = new Panel();
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
            categories_pnl = new Panel();
            categories_grd = new DataGridView();
            categories_category = new DataGridViewTextBoxColumn();
            categories_refresh_btn = new RoundedButton();
            categories_add_btn = new RoundedButton();
            categories_edit_btn = new RoundedButton();
            categories_remove_btn = new RoundedButton();
            categories_lbl1 = new Label();
            categories_src = new TextBox();
            users_pnl = new Panel();
            roundedButton1 = new RoundedButton();
            users_lbl1 = new Label();
            users_src = new TextBox();
            authors_pnl = new Panel();
            authors_refresh_btn = new RoundedButton();
            authors_add_btn = new RoundedButton();
            authors_edit_btn = new RoundedButton();
            authors_remove_btn = new RoundedButton();
            authors_lbl1 = new Label();
            authors_src = new TextBox();
            publishers_pnl = new Panel();
            publishers_refresh_btn = new RoundedButton();
            publishers_add_btn = new RoundedButton();
            publishers_edit_btn = new RoundedButton();
            publishers_remove_btn = new RoundedButton();
            publishers_lbl1 = new Label();
            publishers_src = new TextBox();
            roundedButton2 = new RoundedButton();
            roundedButton3 = new RoundedButton();
            roundedButton4 = new RoundedButton();
            roundedButton5 = new RoundedButton();
            roundedButton6 = new RoundedButton();
            roundedButton7 = new RoundedButton();
            menu_pnl.SuspendLayout();
            header_pnl.SuspendLayout();
            dashboard_pnl.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dashboard_grd).BeginInit();
            books_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)books_grd).BeginInit();
            borrowings_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)borrowings_grd).BeginInit();
            categories_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)categories_grd).BeginInit();
            users_pnl.SuspendLayout();
            authors_pnl.SuspendLayout();
            publishers_pnl.SuspendLayout();
            SuspendLayout();
            // 
            // menu_pnl
            // 
            menu_pnl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            menu_pnl.BackColor = Color.FromArgb(80, 77, 180);
            menu_pnl.Controls.Add(panel2);
            menu_pnl.Controls.Add(button2);
            menu_pnl.Controls.Add(panel1);
            menu_pnl.Controls.Add(button1);
            menu_pnl.Controls.Add(divider_pnl4);
            menu_pnl.Controls.Add(divider_pnl);
            menu_pnl.Controls.Add(divider_pnl1);
            menu_pnl.Controls.Add(divider_pnl3);
            menu_pnl.Controls.Add(logout_btn);
            menu_pnl.Controls.Add(categories_btn);
            menu_pnl.Controls.Add(borrowings_btn);
            menu_pnl.Controls.Add(users_btn);
            menu_pnl.Controls.Add(books_btn);
            menu_pnl.Controls.Add(dashboard_btn);
            menu_pnl.Location = new Point(0, 0);
            menu_pnl.Margin = new Padding(3, 4, 3, 4);
            menu_pnl.MinimumSize = new Size(301, 748);
            menu_pnl.Name = "menu_pnl";
            menu_pnl.Size = new Size(301, 748);
            menu_pnl.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.BackColor = Color.White;
            panel2.Location = new Point(38, 440);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(229, 1);
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
            button2.Location = new Point(0, 441);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(301, 56);
            button2.TabIndex = 30;
            button2.TabStop = false;
            button2.Text = "Publishers";
            button2.UseVisualStyleBackColor = false;
            button2.Click += ShowPublishers;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.White;
            panel1.Location = new Point(38, 383);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(229, 1);
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
            button1.Location = new Point(0, 384);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(301, 56);
            button1.TabIndex = 28;
            button1.TabStop = false;
            button1.Text = "Authors";
            button1.UseVisualStyleBackColor = false;
            button1.Click += ShowAuthors;
            // 
            // divider_pnl4
            // 
            divider_pnl4.AutoSize = true;
            divider_pnl4.BackColor = Color.White;
            divider_pnl4.Location = new Point(38, 497);
            divider_pnl4.Margin = new Padding(3, 4, 3, 4);
            divider_pnl4.Name = "divider_pnl4";
            divider_pnl4.Size = new Size(229, 1);
            divider_pnl4.TabIndex = 27;
            // 
            // divider_pnl
            // 
            divider_pnl.AutoSize = true;
            divider_pnl.BackColor = Color.White;
            divider_pnl.Location = new Point(38, 268);
            divider_pnl.Margin = new Padding(3, 4, 3, 4);
            divider_pnl.Name = "divider_pnl";
            divider_pnl.Size = new Size(229, 1);
            divider_pnl.TabIndex = 25;
            // 
            // divider_pnl1
            // 
            divider_pnl1.AutoSize = true;
            divider_pnl1.BackColor = Color.White;
            divider_pnl1.Location = new Point(38, 211);
            divider_pnl1.Margin = new Padding(3, 4, 3, 4);
            divider_pnl1.Name = "divider_pnl1";
            divider_pnl1.Size = new Size(229, 1);
            divider_pnl1.TabIndex = 24;
            // 
            // divider_pnl3
            // 
            divider_pnl3.AutoSize = true;
            divider_pnl3.BackColor = Color.White;
            divider_pnl3.Location = new Point(38, 325);
            divider_pnl3.Margin = new Padding(3, 4, 3, 4);
            divider_pnl3.Name = "divider_pnl3";
            divider_pnl3.Size = new Size(229, 1);
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
            logout_btn.Location = new Point(94, 633);
            logout_btn.Margin = new Padding(3, 4, 3, 4);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(110, 48);
            logout_btn.TabIndex = 23;
            logout_btn.TabStop = false;
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
            categories_btn.Location = new Point(0, 327);
            categories_btn.Margin = new Padding(3, 4, 3, 4);
            categories_btn.Name = "categories_btn";
            categories_btn.Size = new Size(301, 56);
            categories_btn.TabIndex = 4;
            categories_btn.TabStop = false;
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
            borrowings_btn.Location = new Point(0, 269);
            borrowings_btn.Margin = new Padding(3, 4, 3, 4);
            borrowings_btn.Name = "borrowings_btn";
            borrowings_btn.Size = new Size(301, 56);
            borrowings_btn.TabIndex = 3;
            borrowings_btn.TabStop = false;
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
            users_btn.Location = new Point(0, 499);
            users_btn.Margin = new Padding(3, 4, 3, 4);
            users_btn.Name = "users_btn";
            users_btn.Size = new Size(301, 56);
            users_btn.TabIndex = 2;
            users_btn.TabStop = false;
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
            books_btn.Location = new Point(0, 212);
            books_btn.Margin = new Padding(3, 4, 3, 4);
            books_btn.Name = "books_btn";
            books_btn.Size = new Size(301, 56);
            books_btn.TabIndex = 1;
            books_btn.TabStop = false;
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
            dashboard_btn.Location = new Point(0, 155);
            dashboard_btn.Margin = new Padding(3, 4, 3, 4);
            dashboard_btn.Name = "dashboard_btn";
            dashboard_btn.Size = new Size(301, 56);
            dashboard_btn.TabIndex = 0;
            dashboard_btn.TabStop = false;
            dashboard_btn.Text = "Dashboard";
            dashboard_btn.UseVisualStyleBackColor = false;
            dashboard_btn.Click += ShowDashboard;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Yu Gothic UI Semibold", 12F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(25, 8);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(187, 28);
            label1.TabIndex = 11;
            label1.Text = "No. of Books";
            // 
            // header_pnl
            // 
            header_pnl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            header_pnl.AutoScroll = true;
            header_pnl.BackColor = Color.FromArgb(72, 69, 158);
            header_pnl.Controls.Add(hello_lbl);
            header_pnl.Controls.Add(title_lbl);
            header_pnl.Location = new Point(0, 0);
            header_pnl.Margin = new Padding(3, 4, 3, 4);
            header_pnl.Name = "header_pnl";
            header_pnl.Size = new Size(1126, 67);
            header_pnl.TabIndex = 11;
            // 
            // hello_lbl
            // 
            hello_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            hello_lbl.Font = new Font("Yu Gothic UI Semibold", 16F);
            hello_lbl.ForeColor = Color.White;
            hello_lbl.Location = new Point(386, 12);
            hello_lbl.Name = "hello_lbl";
            hello_lbl.Size = new Size(736, 40);
            hello_lbl.TabIndex = 1;
            hello_lbl.Text = "Hello, Admin 🐱‍🚀";
            hello_lbl.TextAlign = ContentAlignment.TopRight;
            // 
            // title_lbl
            // 
            title_lbl.AutoSize = true;
            title_lbl.Font = new Font("Yu Gothic UI Semibold", 16F);
            title_lbl.ForeColor = Color.White;
            title_lbl.Location = new Point(13, 12);
            title_lbl.Name = "title_lbl";
            title_lbl.Size = new Size(367, 37);
            title_lbl.TabIndex = 0;
            title_lbl.Text = "Library Management System";
            // 
            // dashboard_pnl
            // 
            dashboard_pnl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dashboard_pnl.AutoScroll = true;
            dashboard_pnl.Controls.Add(panel5);
            dashboard_pnl.Controls.Add(panel4);
            dashboard_pnl.Controls.Add(panel3);
            dashboard_pnl.Controls.Add(panel6);
            dashboard_pnl.Location = new Point(304, 75);
            dashboard_pnl.Margin = new Padding(3, 4, 3, 4);
            dashboard_pnl.Name = "dashboard_pnl";
            dashboard_pnl.Size = new Size(810, 657);
            dashboard_pnl.TabIndex = 12;
            dashboard_pnl.Visible = false;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top;
            panel5.AutoSize = true;
            panel5.Controls.Add(dashboard_borrowings);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(523, 40);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(229, 133);
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
            dashboard_borrowings.Location = new Point(17, 40);
            dashboard_borrowings.Margin = new Padding(3, 4, 3, 4);
            dashboard_borrowings.MaximumSize = new Size(286, 133);
            dashboard_borrowings.Name = "dashboard_borrowings";
            dashboard_borrowings.Size = new Size(195, 84);
            dashboard_borrowings.TabIndex = 19;
            dashboard_borrowings.Text = "0";
            dashboard_borrowings.TextColor = Color.White;
            dashboard_borrowings.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.Font = new Font("Yu Gothic UI Semibold", 12F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(25, 8);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(187, 28);
            label3.TabIndex = 11;
            label3.Text = "No. of Borrowings";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top;
            panel4.AutoSize = true;
            panel4.Controls.Add(dashboard_users);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(293, 40);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(229, 133);
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
            dashboard_users.Location = new Point(17, 40);
            dashboard_users.Margin = new Padding(3, 4, 3, 4);
            dashboard_users.MaximumSize = new Size(286, 133);
            dashboard_users.Name = "dashboard_users";
            dashboard_users.Size = new Size(195, 84);
            dashboard_users.TabIndex = 19;
            dashboard_users.Text = "0";
            dashboard_users.TextColor = Color.White;
            dashboard_users.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.Font = new Font("Yu Gothic UI Semibold", 12F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(25, 8);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(187, 28);
            label2.TabIndex = 11;
            label2.Text = "No. of Users";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top;
            panel3.AutoSize = true;
            panel3.Controls.Add(dashboard_books);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(62, 40);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(229, 133);
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
            dashboard_books.Location = new Point(17, 40);
            dashboard_books.Margin = new Padding(3, 4, 3, 4);
            dashboard_books.MaximumSize = new Size(286, 133);
            dashboard_books.Name = "dashboard_books";
            dashboard_books.Size = new Size(195, 84);
            dashboard_books.TabIndex = 19;
            dashboard_books.Text = "0";
            dashboard_books.TextColor = Color.White;
            dashboard_books.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top;
            panel6.Controls.Add(dashboard_grd);
            panel6.Controls.Add(label4);
            panel6.Location = new Point(45, 192);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(726, 447);
            panel6.TabIndex = 24;
            // 
            // dashboard_grd
            // 
            dashboard_grd.AllowUserToAddRows = false;
            dashboard_grd.AllowUserToDeleteRows = false;
            dashboard_grd.AllowUserToResizeColumns = false;
            dashboard_grd.AllowUserToResizeRows = false;
            dashboard_grd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dashboard_grd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dashboard_grd.BackgroundColor = Color.FromArgb(224, 224, 224);
            dashboard_grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dashboard_grd.Columns.AddRange(new DataGridViewColumn[] { dashboard_count, dashboard_title, dashboard_author, dashboard_publicationYear, dashboard_category });
            dashboard_grd.Location = new Point(17, 43);
            dashboard_grd.Margin = new Padding(3, 4, 3, 4);
            dashboard_grd.Name = "dashboard_grd";
            dashboard_grd.ReadOnly = true;
            dashboard_grd.RowHeadersVisible = false;
            dashboard_grd.RowHeadersWidth = 51;
            dashboard_grd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dashboard_grd.ShowCellErrors = false;
            dashboard_grd.ShowCellToolTips = false;
            dashboard_grd.ShowEditingIcon = false;
            dashboard_grd.ShowRowErrors = false;
            dashboard_grd.Size = new Size(690, 387);
            dashboard_grd.TabIndex = 18;
            // 
            // dashboard_count
            // 
            dashboard_count.HeaderText = "#";
            dashboard_count.MinimumWidth = 6;
            dashboard_count.Name = "dashboard_count";
            dashboard_count.ReadOnly = true;
            dashboard_count.Width = 47;
            // 
            // dashboard_title
            // 
            dashboard_title.HeaderText = "Title";
            dashboard_title.MinimumWidth = 6;
            dashboard_title.Name = "dashboard_title";
            dashboard_title.ReadOnly = true;
            dashboard_title.Width = 67;
            // 
            // dashboard_author
            // 
            dashboard_author.HeaderText = "Author";
            dashboard_author.MinimumWidth = 6;
            dashboard_author.Name = "dashboard_author";
            dashboard_author.ReadOnly = true;
            dashboard_author.Width = 83;
            // 
            // dashboard_publicationYear
            // 
            dashboard_publicationYear.HeaderText = "Publication Year";
            dashboard_publicationYear.MinimumWidth = 6;
            dashboard_publicationYear.Name = "dashboard_publicationYear";
            dashboard_publicationYear.ReadOnly = true;
            dashboard_publicationYear.Width = 144;
            // 
            // dashboard_category
            // 
            dashboard_category.HeaderText = "Category";
            dashboard_category.MinimumWidth = 6;
            dashboard_category.Name = "dashboard_category";
            dashboard_category.ReadOnly = true;
            dashboard_category.Width = 98;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI Semibold", 12F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(15, 11);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(201, 28);
            label4.TabIndex = 17;
            label4.Text = "Top Borrowed Books";
            // 
            // books_pnl
            // 
            books_pnl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            books_pnl.Controls.Add(roundedButton5);
            books_pnl.Controls.Add(roundedButton6);
            books_pnl.Controls.Add(books_refresh_btn);
            books_pnl.Controls.Add(roundedButton7);
            books_pnl.Controls.Add(books_lbl1);
            books_pnl.Controls.Add(books_src);
            books_pnl.Controls.Add(books_grd);
            books_pnl.Location = new Point(304, 75);
            books_pnl.Margin = new Padding(3, 4, 3, 4);
            books_pnl.Name = "books_pnl";
            books_pnl.Size = new Size(809, 657);
            books_pnl.TabIndex = 13;
            books_pnl.Visible = false;
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
            books_refresh_btn.Location = new Point(59, 35);
            books_refresh_btn.Margin = new Padding(3, 4, 3, 4);
            books_refresh_btn.Name = "books_refresh_btn";
            books_refresh_btn.Size = new Size(41, 48);
            books_refresh_btn.TabIndex = 15;
            books_refresh_btn.TabStop = false;
            books_refresh_btn.TextColor = Color.White;
            books_refresh_btn.UseVisualStyleBackColor = false;
            books_refresh_btn.Click += RefreshBooks;
            // 
            // books_lbl1
            // 
            books_lbl1.AutoSize = true;
            books_lbl1.Font = new Font("Yu Gothic UI Semibold", 14F);
            books_lbl1.Location = new Point(59, 107);
            books_lbl1.Name = "books_lbl1";
            books_lbl1.Size = new Size(80, 32);
            books_lbl1.TabIndex = 11;
            books_lbl1.Text = "Books";
            // 
            // books_src
            // 
            books_src.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            books_src.BackColor = Color.White;
            books_src.Font = new Font("Yu Gothic UI Semibold", 14F);
            books_src.Location = new Point(512, 39);
            books_src.Margin = new Padding(3, 4, 3, 4);
            books_src.MaxLength = 19;
            books_src.Name = "books_src";
            books_src.PlaceholderText = "Search...";
            books_src.Size = new Size(237, 39);
            books_src.TabIndex = 1;
            books_src.TabStop = false;
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
            books_grd.Columns.AddRange(new DataGridViewColumn[] { title, author, publicationYear, category, publisher, isbn });
            books_grd.Location = new Point(59, 144);
            books_grd.Margin = new Padding(3, 4, 3, 4);
            books_grd.Name = "books_grd";
            books_grd.ReadOnly = true;
            books_grd.RowHeadersVisible = false;
            books_grd.RowHeadersWidth = 51;
            books_grd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            books_grd.ShowCellErrors = false;
            books_grd.ShowCellToolTips = false;
            books_grd.ShowEditingIcon = false;
            books_grd.ShowRowErrors = false;
            books_grd.Size = new Size(690, 479);
            books_grd.TabIndex = 0;
            // 
            // title
            // 
            title.HeaderText = "Title";
            title.MinimumWidth = 6;
            title.Name = "title";
            title.ReadOnly = true;
            title.Width = 67;
            // 
            // author
            // 
            author.HeaderText = "Author";
            author.MinimumWidth = 6;
            author.Name = "author";
            author.ReadOnly = true;
            author.Width = 83;
            // 
            // publicationYear
            // 
            publicationYear.HeaderText = "Publication Year";
            publicationYear.MinimumWidth = 6;
            publicationYear.Name = "publicationYear";
            publicationYear.ReadOnly = true;
            publicationYear.Width = 144;
            // 
            // category
            // 
            category.HeaderText = "Categroy";
            category.MinimumWidth = 6;
            category.Name = "category";
            category.ReadOnly = true;
            category.Width = 98;
            // 
            // publisher
            // 
            publisher.HeaderText = "Publisher";
            publisher.MinimumWidth = 6;
            publisher.Name = "publisher";
            publisher.ReadOnly = true;
            publisher.Width = 98;
            // 
            // isbn
            // 
            isbn.HeaderText = "ISBN";
            isbn.MinimumWidth = 6;
            isbn.Name = "isbn";
            isbn.ReadOnly = true;
            isbn.Width = 70;
            // 
            // borrowings_pnl
            // 
            borrowings_pnl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            borrowings_pnl.BackColor = Color.White;
            borrowings_pnl.Controls.Add(checkBox_currentBorrowings);
            borrowings_pnl.Controls.Add(borrowings_grd);
            borrowings_pnl.Controls.Add(borrowings_refresh_btn);
            borrowings_pnl.Controls.Add(borrowings_borrow_btn);
            borrowings_pnl.Controls.Add(borrowings_edit_btn);
            borrowings_pnl.Controls.Add(borrowings_return_btn);
            borrowings_pnl.Controls.Add(borrowings_lbl1);
            borrowings_pnl.Controls.Add(borrowings_src);
            borrowings_pnl.Location = new Point(304, 75);
            borrowings_pnl.Margin = new Padding(3, 4, 3, 4);
            borrowings_pnl.Name = "borrowings_pnl";
            borrowings_pnl.Size = new Size(809, 657);
            borrowings_pnl.TabIndex = 14;
            borrowings_pnl.Visible = false;
            // 
            // checkBox_currentBorrowings
            // 
            checkBox_currentBorrowings.AutoSize = true;
            checkBox_currentBorrowings.Location = new Point(537, 107);
            checkBox_currentBorrowings.Margin = new Padding(3, 4, 3, 4);
            checkBox_currentBorrowings.Name = "checkBox_currentBorrowings";
            checkBox_currentBorrowings.RightToLeft = RightToLeft.Yes;
            checkBox_currentBorrowings.Size = new Size(228, 24);
            checkBox_currentBorrowings.TabIndex = 31;
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
            borrowings_grd.Location = new Point(59, 144);
            borrowings_grd.Margin = new Padding(3, 4, 3, 4);
            borrowings_grd.Name = "borrowings_grd";
            borrowings_grd.ReadOnly = true;
            borrowings_grd.RowHeadersVisible = false;
            borrowings_grd.RowHeadersWidth = 51;
            borrowings_grd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            borrowings_grd.ShowCellErrors = false;
            borrowings_grd.ShowCellToolTips = false;
            borrowings_grd.ShowEditingIcon = false;
            borrowings_grd.ShowRowErrors = false;
            borrowings_grd.Size = new Size(690, 479);
            borrowings_grd.TabIndex = 30;
            // 
            // borrowings_username
            // 
            borrowings_username.HeaderText = "Username";
            borrowings_username.MinimumWidth = 6;
            borrowings_username.Name = "borrowings_username";
            borrowings_username.ReadOnly = true;
            borrowings_username.Width = 104;
            // 
            // borrowings_title
            // 
            borrowings_title.HeaderText = "Title";
            borrowings_title.MinimumWidth = 6;
            borrowings_title.Name = "borrowings_title";
            borrowings_title.ReadOnly = true;
            borrowings_title.Width = 67;
            // 
            // borrowings_isbn
            // 
            borrowings_isbn.HeaderText = "ISBN";
            borrowings_isbn.MinimumWidth = 6;
            borrowings_isbn.Name = "borrowings_isbn";
            borrowings_isbn.ReadOnly = true;
            borrowings_isbn.Width = 70;
            // 
            // borrowings_borrowDate
            // 
            borrowings_borrowDate.HeaderText = "Borrow Date";
            borrowings_borrowDate.MinimumWidth = 6;
            borrowings_borrowDate.Name = "borrowings_borrowDate";
            borrowings_borrowDate.ReadOnly = true;
            borrowings_borrowDate.Width = 122;
            // 
            // borrowings_dueDate
            // 
            borrowings_dueDate.HeaderText = "Due Date";
            borrowings_dueDate.MinimumWidth = 6;
            borrowings_dueDate.Name = "borrowings_dueDate";
            borrowings_dueDate.ReadOnly = true;
            borrowings_dueDate.Width = 101;
            // 
            // borrowings_returnDate
            // 
            borrowings_returnDate.HeaderText = "Return Date";
            borrowings_returnDate.MinimumWidth = 6;
            borrowings_returnDate.Name = "borrowings_returnDate";
            borrowings_returnDate.ReadOnly = true;
            borrowings_returnDate.Width = 117;
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
            borrowings_refresh_btn.Location = new Point(59, 35);
            borrowings_refresh_btn.Margin = new Padding(3, 4, 3, 4);
            borrowings_refresh_btn.Name = "borrowings_refresh_btn";
            borrowings_refresh_btn.Size = new Size(41, 48);
            borrowings_refresh_btn.TabIndex = 29;
            borrowings_refresh_btn.TabStop = false;
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
            borrowings_borrow_btn.Location = new Point(391, 35);
            borrowings_borrow_btn.Margin = new Padding(3, 4, 3, 4);
            borrowings_borrow_btn.Name = "borrowings_borrow_btn";
            borrowings_borrow_btn.Size = new Size(114, 48);
            borrowings_borrow_btn.TabIndex = 28;
            borrowings_borrow_btn.TabStop = false;
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
            borrowings_edit_btn.Location = new Point(149, 35);
            borrowings_edit_btn.Margin = new Padding(3, 4, 3, 4);
            borrowings_edit_btn.Name = "borrowings_edit_btn";
            borrowings_edit_btn.Size = new Size(114, 48);
            borrowings_edit_btn.TabIndex = 27;
            borrowings_edit_btn.TabStop = false;
            borrowings_edit_btn.Text = "Edit";
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
            borrowings_return_btn.Location = new Point(270, 35);
            borrowings_return_btn.Margin = new Padding(3, 4, 3, 4);
            borrowings_return_btn.Name = "borrowings_return_btn";
            borrowings_return_btn.Size = new Size(114, 48);
            borrowings_return_btn.TabIndex = 26;
            borrowings_return_btn.TabStop = false;
            borrowings_return_btn.Text = "Return";
            borrowings_return_btn.TextColor = Color.White;
            borrowings_return_btn.UseVisualStyleBackColor = false;
            borrowings_return_btn.Click += RemoveBorrowings;
            // 
            // borrowings_lbl1
            // 
            borrowings_lbl1.AutoSize = true;
            borrowings_lbl1.Font = new Font("Yu Gothic UI Semibold", 14F);
            borrowings_lbl1.Location = new Point(59, 107);
            borrowings_lbl1.Name = "borrowings_lbl1";
            borrowings_lbl1.Size = new Size(137, 32);
            borrowings_lbl1.TabIndex = 25;
            borrowings_lbl1.Text = "Borrowings";
            // 
            // borrowings_src
            // 
            borrowings_src.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            borrowings_src.BackColor = Color.White;
            borrowings_src.Font = new Font("Yu Gothic UI Semibold", 14F);
            borrowings_src.Location = new Point(512, 39);
            borrowings_src.Margin = new Padding(3, 4, 3, 4);
            borrowings_src.MaxLength = 19;
            borrowings_src.Name = "borrowings_src";
            borrowings_src.PlaceholderText = "Search...";
            borrowings_src.Size = new Size(237, 39);
            borrowings_src.TabIndex = 24;
            borrowings_src.TabStop = false;
            borrowings_src.TextChanged += SearchBorrowings;
            // 
            // categories_pnl
            // 
            categories_pnl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            categories_pnl.BackColor = Color.White;
            categories_pnl.Controls.Add(categories_grd);
            categories_pnl.Controls.Add(categories_refresh_btn);
            categories_pnl.Controls.Add(categories_add_btn);
            categories_pnl.Controls.Add(categories_edit_btn);
            categories_pnl.Controls.Add(categories_remove_btn);
            categories_pnl.Controls.Add(categories_lbl1);
            categories_pnl.Controls.Add(categories_src);
            categories_pnl.Location = new Point(304, 75);
            categories_pnl.Margin = new Padding(3, 4, 3, 4);
            categories_pnl.Name = "categories_pnl";
            categories_pnl.Size = new Size(809, 657);
            categories_pnl.TabIndex = 23;
            categories_pnl.Visible = false;
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
            categories_grd.Location = new Point(59, 144);
            categories_grd.Margin = new Padding(3, 4, 3, 4);
            categories_grd.Name = "categories_grd";
            categories_grd.ReadOnly = true;
            categories_grd.RowHeadersVisible = false;
            categories_grd.RowHeadersWidth = 51;
            categories_grd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            categories_grd.ShowCellErrors = false;
            categories_grd.ShowCellToolTips = false;
            categories_grd.ShowEditingIcon = false;
            categories_grd.ShowRowErrors = false;
            categories_grd.Size = new Size(690, 479);
            categories_grd.TabIndex = 31;
            // 
            // categories_category
            // 
            categories_category.HeaderText = "Category";
            categories_category.MinimumWidth = 6;
            categories_category.Name = "categories_category";
            categories_category.ReadOnly = true;
            categories_category.Width = 98;
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
            categories_refresh_btn.Location = new Point(59, 35);
            categories_refresh_btn.Margin = new Padding(3, 4, 3, 4);
            categories_refresh_btn.Name = "categories_refresh_btn";
            categories_refresh_btn.Size = new Size(41, 48);
            categories_refresh_btn.TabIndex = 22;
            categories_refresh_btn.TabStop = false;
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
            categories_add_btn.Location = new Point(391, 35);
            categories_add_btn.Margin = new Padding(3, 4, 3, 4);
            categories_add_btn.Name = "categories_add_btn";
            categories_add_btn.Size = new Size(114, 48);
            categories_add_btn.TabIndex = 21;
            categories_add_btn.TabStop = false;
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
            categories_edit_btn.Location = new Point(149, 35);
            categories_edit_btn.Margin = new Padding(3, 4, 3, 4);
            categories_edit_btn.Name = "categories_edit_btn";
            categories_edit_btn.Size = new Size(114, 48);
            categories_edit_btn.TabIndex = 20;
            categories_edit_btn.TabStop = false;
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
            categories_remove_btn.Location = new Point(270, 35);
            categories_remove_btn.Margin = new Padding(3, 4, 3, 4);
            categories_remove_btn.Name = "categories_remove_btn";
            categories_remove_btn.Size = new Size(114, 48);
            categories_remove_btn.TabIndex = 19;
            categories_remove_btn.TabStop = false;
            categories_remove_btn.Text = "Remove";
            categories_remove_btn.TextColor = Color.White;
            categories_remove_btn.UseVisualStyleBackColor = false;
            categories_remove_btn.Click += RemoveCategories;
            // 
            // categories_lbl1
            // 
            categories_lbl1.AutoSize = true;
            categories_lbl1.Font = new Font("Yu Gothic UI Semibold", 14F);
            categories_lbl1.Location = new Point(59, 107);
            categories_lbl1.Name = "categories_lbl1";
            categories_lbl1.Size = new Size(130, 32);
            categories_lbl1.TabIndex = 18;
            categories_lbl1.Text = "Categories";
            // 
            // categories_src
            // 
            categories_src.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            categories_src.BackColor = Color.White;
            categories_src.Font = new Font("Yu Gothic UI Semibold", 14F);
            categories_src.Location = new Point(512, 39);
            categories_src.Margin = new Padding(3, 4, 3, 4);
            categories_src.MaxLength = 19;
            categories_src.Name = "categories_src";
            categories_src.PlaceholderText = "Search...";
            categories_src.Size = new Size(237, 39);
            categories_src.TabIndex = 17;
            categories_src.TabStop = false;
            categories_src.TextChanged += SearchCategories;
            // 
            // users_pnl
            // 
            users_pnl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            users_pnl.Controls.Add(roundedButton2);
            users_pnl.Controls.Add(roundedButton1);
            users_pnl.Controls.Add(roundedButton3);
            users_pnl.Controls.Add(roundedButton4);
            users_pnl.Controls.Add(users_lbl1);
            users_pnl.Controls.Add(users_src);
            users_pnl.Location = new Point(304, 75);
            users_pnl.Margin = new Padding(3, 4, 3, 4);
            users_pnl.Name = "users_pnl";
            users_pnl.Size = new Size(809, 657);
            users_pnl.TabIndex = 24;
            users_pnl.Visible = false;
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
            roundedButton1.Location = new Point(59, 35);
            roundedButton1.Margin = new Padding(3, 4, 3, 4);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(41, 48);
            roundedButton1.TabIndex = 16;
            roundedButton1.TabStop = false;
            roundedButton1.TextColor = Color.White;
            roundedButton1.UseVisualStyleBackColor = false;
            roundedButton1.Click += RefreshUsers;
            // 
            // users_lbl1
            // 
            users_lbl1.AutoSize = true;
            users_lbl1.Font = new Font("Yu Gothic UI Semibold", 14F);
            users_lbl1.Location = new Point(59, 107);
            users_lbl1.Name = "users_lbl1";
            users_lbl1.Size = new Size(73, 32);
            users_lbl1.TabIndex = 11;
            users_lbl1.Text = "Users";
            // 
            // users_src
            // 
            users_src.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            users_src.BackColor = Color.White;
            users_src.Font = new Font("Yu Gothic UI Semibold", 14F);
            users_src.Location = new Point(512, 39);
            users_src.Margin = new Padding(3, 4, 3, 4);
            users_src.MaxLength = 19;
            users_src.Name = "users_src";
            users_src.PlaceholderText = "Search...";
            users_src.Size = new Size(237, 39);
            users_src.TabIndex = 1;
            users_src.TabStop = false;
            users_src.TextChanged += SearchUsers;
            // 
            // authors_pnl
            // 
            authors_pnl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            authors_pnl.BackColor = Color.White;
            authors_pnl.Controls.Add(authors_refresh_btn);
            authors_pnl.Controls.Add(authors_add_btn);
            authors_pnl.Controls.Add(authors_edit_btn);
            authors_pnl.Controls.Add(authors_remove_btn);
            authors_pnl.Controls.Add(authors_lbl1);
            authors_pnl.Controls.Add(authors_src);
            authors_pnl.Location = new Point(304, 75);
            authors_pnl.Margin = new Padding(3, 4, 3, 4);
            authors_pnl.Name = "authors_pnl";
            authors_pnl.Size = new Size(809, 657);
            authors_pnl.TabIndex = 25;
            authors_pnl.Visible = false;
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
            authors_refresh_btn.Location = new Point(59, 35);
            authors_refresh_btn.Margin = new Padding(3, 4, 3, 4);
            authors_refresh_btn.Name = "authors_refresh_btn";
            authors_refresh_btn.Size = new Size(41, 48);
            authors_refresh_btn.TabIndex = 22;
            authors_refresh_btn.TabStop = false;
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
            authors_add_btn.Location = new Point(391, 35);
            authors_add_btn.Margin = new Padding(3, 4, 3, 4);
            authors_add_btn.Name = "authors_add_btn";
            authors_add_btn.Size = new Size(114, 48);
            authors_add_btn.TabIndex = 21;
            authors_add_btn.TabStop = false;
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
            authors_edit_btn.Location = new Point(149, 35);
            authors_edit_btn.Margin = new Padding(3, 4, 3, 4);
            authors_edit_btn.Name = "authors_edit_btn";
            authors_edit_btn.Size = new Size(114, 48);
            authors_edit_btn.TabIndex = 20;
            authors_edit_btn.TabStop = false;
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
            authors_remove_btn.Location = new Point(270, 35);
            authors_remove_btn.Margin = new Padding(3, 4, 3, 4);
            authors_remove_btn.Name = "authors_remove_btn";
            authors_remove_btn.Size = new Size(114, 48);
            authors_remove_btn.TabIndex = 19;
            authors_remove_btn.TabStop = false;
            authors_remove_btn.Text = "Remove";
            authors_remove_btn.TextColor = Color.White;
            authors_remove_btn.UseVisualStyleBackColor = false;
            authors_remove_btn.Click += RemoveAuthor;
            // 
            // authors_lbl1
            // 
            authors_lbl1.AutoSize = true;
            authors_lbl1.Font = new Font("Yu Gothic UI Semibold", 14F);
            authors_lbl1.Location = new Point(59, 107);
            authors_lbl1.Name = "authors_lbl1";
            authors_lbl1.Size = new Size(100, 32);
            authors_lbl1.TabIndex = 18;
            authors_lbl1.Text = "Authors";
            // 
            // authors_src
            // 
            authors_src.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            authors_src.BackColor = Color.White;
            authors_src.Font = new Font("Yu Gothic UI Semibold", 14F);
            authors_src.Location = new Point(512, 39);
            authors_src.Margin = new Padding(3, 4, 3, 4);
            authors_src.MaxLength = 19;
            authors_src.Name = "authors_src";
            authors_src.PlaceholderText = "Search...";
            authors_src.Size = new Size(237, 39);
            authors_src.TabIndex = 17;
            authors_src.TabStop = false;
            authors_src.TextChanged += SearchAuthors;
            // 
            // publishers_pnl
            // 
            publishers_pnl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            publishers_pnl.AutoSize = true;
            publishers_pnl.BackColor = Color.White;
            publishers_pnl.Controls.Add(publishers_refresh_btn);
            publishers_pnl.Controls.Add(publishers_add_btn);
            publishers_pnl.Controls.Add(publishers_edit_btn);
            publishers_pnl.Controls.Add(publishers_remove_btn);
            publishers_pnl.Controls.Add(publishers_lbl1);
            publishers_pnl.Controls.Add(publishers_src);
            publishers_pnl.Location = new Point(304, 75);
            publishers_pnl.Margin = new Padding(3, 4, 3, 4);
            publishers_pnl.Name = "publishers_pnl";
            publishers_pnl.Size = new Size(809, 657);
            publishers_pnl.TabIndex = 26;
            publishers_pnl.Visible = false;
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
            publishers_refresh_btn.Location = new Point(59, 35);
            publishers_refresh_btn.Margin = new Padding(3, 4, 3, 4);
            publishers_refresh_btn.Name = "publishers_refresh_btn";
            publishers_refresh_btn.Size = new Size(41, 48);
            publishers_refresh_btn.TabIndex = 22;
            publishers_refresh_btn.TabStop = false;
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
            publishers_add_btn.Location = new Point(391, 35);
            publishers_add_btn.Margin = new Padding(3, 4, 3, 4);
            publishers_add_btn.Name = "publishers_add_btn";
            publishers_add_btn.Size = new Size(114, 48);
            publishers_add_btn.TabIndex = 21;
            publishers_add_btn.TabStop = false;
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
            publishers_edit_btn.Location = new Point(149, 35);
            publishers_edit_btn.Margin = new Padding(3, 4, 3, 4);
            publishers_edit_btn.Name = "publishers_edit_btn";
            publishers_edit_btn.Size = new Size(114, 48);
            publishers_edit_btn.TabIndex = 20;
            publishers_edit_btn.TabStop = false;
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
            publishers_remove_btn.Location = new Point(270, 35);
            publishers_remove_btn.Margin = new Padding(3, 4, 3, 4);
            publishers_remove_btn.Name = "publishers_remove_btn";
            publishers_remove_btn.Size = new Size(114, 48);
            publishers_remove_btn.TabIndex = 19;
            publishers_remove_btn.TabStop = false;
            publishers_remove_btn.Text = "Remove";
            publishers_remove_btn.TextColor = Color.White;
            publishers_remove_btn.UseVisualStyleBackColor = false;
            publishers_remove_btn.Click += RemovePublishers;
            // 
            // publishers_lbl1
            // 
            publishers_lbl1.AutoSize = true;
            publishers_lbl1.Font = new Font("Yu Gothic UI Semibold", 14F);
            publishers_lbl1.Location = new Point(59, 107);
            publishers_lbl1.Name = "publishers_lbl1";
            publishers_lbl1.Size = new Size(124, 32);
            publishers_lbl1.TabIndex = 18;
            publishers_lbl1.Text = "Publishers";
            // 
            // publishers_src
            // 
            publishers_src.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            publishers_src.BackColor = Color.White;
            publishers_src.Font = new Font("Yu Gothic UI Semibold", 14F);
            publishers_src.Location = new Point(512, 39);
            publishers_src.Margin = new Padding(3, 4, 3, 4);
            publishers_src.MaxLength = 19;
            publishers_src.Name = "publishers_src";
            publishers_src.PlaceholderText = "Search...";
            publishers_src.Size = new Size(237, 39);
            publishers_src.TabIndex = 17;
            publishers_src.TabStop = false;
            publishers_src.TextChanged += SearchPublishers;
            // 
            // roundedButton2
            // 
            roundedButton2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            roundedButton2.BackColor = Color.FromArgb(80, 77, 180);
            roundedButton2.BackgroundColor = Color.FromArgb(80, 77, 180);
            roundedButton2.BorderColor = Color.Transparent;
            roundedButton2.BorderRadius = 5;
            roundedButton2.BorderSize = 0;
            roundedButton2.FlatAppearance.BorderSize = 0;
            roundedButton2.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            roundedButton2.FlatStyle = FlatStyle.Flat;
            roundedButton2.Font = new Font("Yu Gothic UI Semibold", 14F);
            roundedButton2.ForeColor = Color.White;
            roundedButton2.Location = new Point(392, 35);
            roundedButton2.Margin = new Padding(3, 4, 3, 4);
            roundedButton2.Name = "roundedButton2";
            roundedButton2.Size = new Size(114, 48);
            roundedButton2.TabIndex = 29;
            roundedButton2.TabStop = false;
            roundedButton2.Text = "Add";
            roundedButton2.TextColor = Color.White;
            roundedButton2.UseVisualStyleBackColor = false;
            roundedButton2.Click += AddUser;
            // 
            // roundedButton3
            // 
            roundedButton3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            roundedButton3.BackColor = Color.FromArgb(80, 77, 180);
            roundedButton3.BackgroundColor = Color.FromArgb(80, 77, 180);
            roundedButton3.BorderColor = Color.Transparent;
            roundedButton3.BorderRadius = 5;
            roundedButton3.BorderSize = 0;
            roundedButton3.FlatAppearance.BorderSize = 0;
            roundedButton3.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            roundedButton3.FlatStyle = FlatStyle.Flat;
            roundedButton3.Font = new Font("Yu Gothic UI Semibold", 14F);
            roundedButton3.ForeColor = Color.White;
            roundedButton3.Location = new Point(150, 35);
            roundedButton3.Margin = new Padding(3, 4, 3, 4);
            roundedButton3.Name = "roundedButton3";
            roundedButton3.Size = new Size(114, 48);
            roundedButton3.TabIndex = 28;
            roundedButton3.TabStop = false;
            roundedButton3.Text = "Edit";
            roundedButton3.TextColor = Color.White;
            roundedButton3.UseVisualStyleBackColor = false;
            roundedButton3.Click += EditUser;
            // 
            // roundedButton4
            // 
            roundedButton4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            roundedButton4.BackColor = Color.FromArgb(80, 77, 180);
            roundedButton4.BackgroundColor = Color.FromArgb(80, 77, 180);
            roundedButton4.BorderColor = Color.Transparent;
            roundedButton4.BorderRadius = 5;
            roundedButton4.BorderSize = 0;
            roundedButton4.FlatAppearance.BorderSize = 0;
            roundedButton4.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            roundedButton4.FlatStyle = FlatStyle.Flat;
            roundedButton4.Font = new Font("Yu Gothic UI Semibold", 14F);
            roundedButton4.ForeColor = Color.White;
            roundedButton4.Location = new Point(271, 35);
            roundedButton4.Margin = new Padding(3, 4, 3, 4);
            roundedButton4.Name = "roundedButton4";
            roundedButton4.Size = new Size(114, 48);
            roundedButton4.TabIndex = 27;
            roundedButton4.TabStop = false;
            roundedButton4.Text = "Remove";
            roundedButton4.TextColor = Color.White;
            roundedButton4.UseVisualStyleBackColor = false;
            roundedButton4.Click += RemoveUsers;
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
            roundedButton5.Location = new Point(392, 35);
            roundedButton5.Margin = new Padding(3, 4, 3, 4);
            roundedButton5.Name = "roundedButton5";
            roundedButton5.Size = new Size(114, 48);
            roundedButton5.TabIndex = 29;
            roundedButton5.TabStop = false;
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
            roundedButton6.Location = new Point(150, 35);
            roundedButton6.Margin = new Padding(3, 4, 3, 4);
            roundedButton6.Name = "roundedButton6";
            roundedButton6.Size = new Size(114, 48);
            roundedButton6.TabIndex = 28;
            roundedButton6.TabStop = false;
            roundedButton6.Text = "Edit";
            roundedButton6.TextColor = Color.White;
            roundedButton6.UseVisualStyleBackColor = false;
            roundedButton6.Click += EditBook;
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
            roundedButton7.Location = new Point(271, 35);
            roundedButton7.Margin = new Padding(3, 4, 3, 4);
            roundedButton7.Name = "roundedButton7";
            roundedButton7.Size = new Size(114, 48);
            roundedButton7.TabIndex = 27;
            roundedButton7.TabStop = false;
            roundedButton7.Text = "Remove";
            roundedButton7.TextColor = Color.White;
            roundedButton7.UseVisualStyleBackColor = false;
            roundedButton7.Click += RemoveBooks;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1125, 748);
            Controls.Add(header_pnl);
            Controls.Add(menu_pnl);
            Controls.Add(categories_pnl);
            Controls.Add(borrowings_pnl);
            Controls.Add(users_pnl);
            Controls.Add(books_pnl);
            Controls.Add(dashboard_pnl);
            Controls.Add(publishers_pnl);
            Controls.Add(authors_pnl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1140, 779);
            Name = "AdminPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Panel";
            Load += OnLoad;
            menu_pnl.ResumeLayout(false);
            menu_pnl.PerformLayout();
            header_pnl.ResumeLayout(false);
            header_pnl.PerformLayout();
            dashboard_pnl.ResumeLayout(false);
            dashboard_pnl.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dashboard_grd).EndInit();
            books_pnl.ResumeLayout(false);
            books_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)books_grd).EndInit();
            borrowings_pnl.ResumeLayout(false);
            borrowings_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)borrowings_grd).EndInit();
            categories_pnl.ResumeLayout(false);
            categories_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)categories_grd).EndInit();
            users_pnl.ResumeLayout(false);
            users_pnl.PerformLayout();
            authors_pnl.ResumeLayout(false);
            authors_pnl.PerformLayout();
            publishers_pnl.ResumeLayout(false);
            publishers_pnl.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel menu_pnl;
        private Button dashboard_btn;
        private Panel header_pnl;
        private Label title_lbl;
        private Button categories_btn;
        private Button borrowings_btn;
        private Button users_btn;
        private Button books_btn;
        private Label hello_lbl;
        private Label label1;
        private Panel dashboard_pnl;
        private Label label4;
        private DataGridView dashboard_grd;
        private Panel books_pnl;
        private Label books_lbl1;
        private RoundedButton books_refresh_btn;
        private RoundedButton dashboard_books;
        private TextBox books_src;
        private Panel borrowings_pnl;
        private RoundedButton logout_btn;
        private Panel divider_pnl4;
        private Panel divider_pnl;
        private Panel divider_pnl1;
        private Panel divider_pnl3;
        private Panel categories_pnl;
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
        private Panel users_pnl;
        private TextBox users_src;
        private Panel panel1;
        private Button button1;
        private Panel panel2;
        private Button button2;
        private Panel authors_pnl;
        private RoundedButton authors_refresh_btn;
        private RoundedButton authors_add_btn;
        private RoundedButton authors_edit_btn;
        private RoundedButton authors_remove_btn;
        private Label authors_lbl1;
        private TextBox authors_src;
        private Panel publishers_pnl;
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
        private DataGridViewTextBoxColumn title;
        private DataGridViewTextBoxColumn author;
        private DataGridViewTextBoxColumn publicationYear;
        private DataGridViewTextBoxColumn category;
        private DataGridViewTextBoxColumn publisher;
        private DataGridViewTextBoxColumn isbn;
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
        private RoundedButton roundedButton2;
        private RoundedButton roundedButton3;
        private RoundedButton roundedButton4;
        private RoundedButton roundedButton5;
        private RoundedButton roundedButton6;
        private RoundedButton roundedButton7;
    }
}