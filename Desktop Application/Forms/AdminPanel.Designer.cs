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
            members_btn = new Button();
            books_btn = new Button();
            dashboard_btn = new Button();
            dashboard_lbl1 = new Label();
            header_pnl = new Panel();
            greeting_lbl = new Label();
            title_lbl = new Label();
            dashboard_pnl = new Panel();
            panel5 = new Panel();
            roundedButton2 = new RoundedButton();
            label2 = new Label();
            panel4 = new Panel();
            roundedButton1 = new RoundedButton();
            label1 = new Label();
            panel3 = new Panel();
            dashboard_btn1 = new RoundedButton();
            panel6 = new Panel();
            dashboard_grd = new DataGridView();
            dashboard_lbl4 = new Label();
            books_pnl = new Panel();
            books_refresh_btn = new RoundedButton();
            books_add_btn = new RoundedButton();
            books_edit_btn = new RoundedButton();
            books_remove_btn = new RoundedButton();
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
            borrowings_refresh_btn = new RoundedButton();
            borrowings_borrow_btn = new RoundedButton();
            borrowings_edit_btn = new RoundedButton();
            borrowings_return_btn = new RoundedButton();
            borrowings_lbl1 = new Label();
            borrowings_src = new TextBox();
            borrowings_grd = new DataGridView();
            categories_pnl = new Panel();
            categories_refresh_btn = new RoundedButton();
            categories_add_btn = new RoundedButton();
            categories_edit_btn = new RoundedButton();
            categories_remove_btn = new RoundedButton();
            categories_lbl1 = new Label();
            categories_src = new TextBox();
            categories_grd = new DataGridView();
            members_pnl = new Panel();
            members_refresh_btn = new RoundedButton();
            members_remove_btn = new RoundedButton();
            members_edit_btn = new RoundedButton();
            members_lbl1 = new Label();
            members_src = new TextBox();
            members_grd = new DataGridView();
            authors_pnl = new Panel();
            authors_refresh_btn = new RoundedButton();
            authors_add_btn = new RoundedButton();
            authors_edit_btn = new RoundedButton();
            authors_remove_btn = new RoundedButton();
            authors_lbl1 = new Label();
            authors_src = new TextBox();
            authors_grd = new DataGridView();
            publishers_pnl = new Panel();
            publishers_refresh_btn = new RoundedButton();
            publishers_add_btn = new RoundedButton();
            publishers_edit_btn = new RoundedButton();
            publishers_remove_btn = new RoundedButton();
            publishers_lbl1 = new Label();
            publishers_src = new TextBox();
            publishers_grd = new DataGridView();
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
            members_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)members_grd).BeginInit();
            authors_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)authors_grd).BeginInit();
            publishers_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)publishers_grd).BeginInit();
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
            menu_pnl.Controls.Add(members_btn);
            menu_pnl.Controls.Add(books_btn);
            menu_pnl.Controls.Add(dashboard_btn);
            menu_pnl.Location = new Point(0, 0);
            menu_pnl.MinimumSize = new Size(263, 561);
            menu_pnl.Name = "menu_pnl";
            menu_pnl.Size = new Size(263, 561);
            menu_pnl.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.BackColor = Color.White;
            panel2.Location = new Point(33, 326);
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
            button2.Location = new Point(0, 328);
            button2.Name = "button2";
            button2.Size = new Size(260, 36);
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
            panel1.Location = new Point(33, 287);
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
            button1.Location = new Point(0, 289);
            button1.Name = "button1";
            button1.Size = new Size(260, 36);
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
            divider_pnl4.Location = new Point(33, 365);
            divider_pnl4.Name = "divider_pnl4";
            divider_pnl4.Size = new Size(200, 1);
            divider_pnl4.TabIndex = 27;
            // 
            // divider_pnl
            // 
            divider_pnl.AutoSize = true;
            divider_pnl.BackColor = Color.White;
            divider_pnl.Location = new Point(33, 209);
            divider_pnl.Name = "divider_pnl";
            divider_pnl.Size = new Size(200, 1);
            divider_pnl.TabIndex = 25;
            // 
            // divider_pnl1
            // 
            divider_pnl1.AutoSize = true;
            divider_pnl1.BackColor = Color.White;
            divider_pnl1.Location = new Point(33, 170);
            divider_pnl1.Name = "divider_pnl1";
            divider_pnl1.Size = new Size(200, 1);
            divider_pnl1.TabIndex = 24;
            // 
            // divider_pnl3
            // 
            divider_pnl3.AutoSize = true;
            divider_pnl3.BackColor = Color.White;
            divider_pnl3.Location = new Point(33, 248);
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
            logout_btn.Location = new Point(87, 476);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(85, 36);
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
            categories_btn.Location = new Point(0, 250);
            categories_btn.Name = "categories_btn";
            categories_btn.Size = new Size(260, 36);
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
            borrowings_btn.Location = new Point(0, 211);
            borrowings_btn.Name = "borrowings_btn";
            borrowings_btn.Size = new Size(260, 36);
            borrowings_btn.TabIndex = 3;
            borrowings_btn.TabStop = false;
            borrowings_btn.Text = "Borrowings";
            borrowings_btn.UseVisualStyleBackColor = false;
            borrowings_btn.Click += ShowBorrowings;
            // 
            // members_btn
            // 
            members_btn.AutoSize = true;
            members_btn.BackColor = Color.FromArgb(80, 77, 180);
            members_btn.FlatAppearance.BorderSize = 0;
            members_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            members_btn.FlatStyle = FlatStyle.Flat;
            members_btn.Font = new Font("Yu Gothic UI Semibold", 14F);
            members_btn.ForeColor = Color.White;
            members_btn.Location = new Point(0, 367);
            members_btn.Name = "members_btn";
            members_btn.Size = new Size(260, 36);
            members_btn.TabIndex = 2;
            members_btn.TabStop = false;
            members_btn.Text = "Members";
            members_btn.UseVisualStyleBackColor = false;
            members_btn.Click += ShowMembers;
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
            books_btn.Location = new Point(0, 172);
            books_btn.Name = "books_btn";
            books_btn.Size = new Size(260, 36);
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
            dashboard_btn.Location = new Point(0, 133);
            dashboard_btn.Name = "dashboard_btn";
            dashboard_btn.Size = new Size(260, 36);
            dashboard_btn.TabIndex = 0;
            dashboard_btn.TabStop = false;
            dashboard_btn.Text = "Dashboard";
            dashboard_btn.UseVisualStyleBackColor = false;
            dashboard_btn.Click += ShowDashboard;
            // 
            // dashboard_lbl1
            // 
            dashboard_lbl1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dashboard_lbl1.Font = new Font("Yu Gothic UI Semibold", 12F);
            dashboard_lbl1.ForeColor = Color.Black;
            dashboard_lbl1.Location = new Point(22, 6);
            dashboard_lbl1.Margin = new Padding(0);
            dashboard_lbl1.Name = "dashboard_lbl1";
            dashboard_lbl1.Size = new Size(105, 21);
            dashboard_lbl1.TabIndex = 11;
            dashboard_lbl1.Text = "No. of Books";
            // 
            // header_pnl
            // 
            header_pnl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            header_pnl.AutoScroll = true;
            header_pnl.BackColor = Color.FromArgb(72, 69, 158);
            header_pnl.Controls.Add(greeting_lbl);
            header_pnl.Controls.Add(title_lbl);
            header_pnl.Location = new Point(0, 0);
            header_pnl.Name = "header_pnl";
            header_pnl.Size = new Size(985, 50);
            header_pnl.TabIndex = 11;
            // 
            // greeting_lbl
            // 
            greeting_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            greeting_lbl.Font = new Font("Yu Gothic UI Semibold", 16F);
            greeting_lbl.ForeColor = Color.White;
            greeting_lbl.Location = new Point(318, 9);
            greeting_lbl.Name = "greeting_lbl";
            greeting_lbl.Size = new Size(664, 30);
            greeting_lbl.TabIndex = 1;
            greeting_lbl.Text = "Hello, Admin 🐱‍🚀";
            greeting_lbl.TextAlign = ContentAlignment.TopRight;
            // 
            // title_lbl
            // 
            title_lbl.AutoSize = true;
            title_lbl.Font = new Font("Yu Gothic UI Semibold", 16F);
            title_lbl.ForeColor = Color.White;
            title_lbl.Location = new Point(11, 9);
            title_lbl.Name = "title_lbl";
            title_lbl.Size = new Size(296, 30);
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
            dashboard_pnl.Location = new Point(266, 56);
            dashboard_pnl.Name = "dashboard_pnl";
            dashboard_pnl.Size = new Size(709, 493);
            dashboard_pnl.TabIndex = 12;
            dashboard_pnl.Visible = false;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top;
            panel5.AutoSize = true;
            panel5.Controls.Add(roundedButton2);
            panel5.Controls.Add(label2);
            panel5.Location = new Point(458, 41);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 100);
            panel5.TabIndex = 23;
            // 
            // roundedButton2
            // 
            roundedButton2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            roundedButton2.AutoSize = true;
            roundedButton2.BackColor = Color.FromArgb(80, 77, 180);
            roundedButton2.BackgroundColor = Color.FromArgb(80, 77, 180);
            roundedButton2.BorderColor = Color.Transparent;
            roundedButton2.BorderRadius = 10;
            roundedButton2.BorderSize = 0;
            roundedButton2.FlatAppearance.BorderSize = 0;
            roundedButton2.FlatAppearance.MouseDownBackColor = Color.FromArgb(80, 77, 180);
            roundedButton2.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 77, 180);
            roundedButton2.FlatStyle = FlatStyle.Flat;
            roundedButton2.Font = new Font("Yu Gothic UI Semibold", 22F);
            roundedButton2.ForeColor = Color.White;
            roundedButton2.Location = new Point(15, 30);
            roundedButton2.MaximumSize = new Size(250, 100);
            roundedButton2.Name = "roundedButton2";
            roundedButton2.Size = new Size(171, 63);
            roundedButton2.TabIndex = 19;
            roundedButton2.Text = "250";
            roundedButton2.TextColor = Color.White;
            roundedButton2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.Font = new Font("Yu Gothic UI Semibold", 12F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(22, 6);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(105, 21);
            label2.TabIndex = 11;
            label2.Text = "No. of Books";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top;
            panel4.AutoSize = true;
            panel4.Controls.Add(roundedButton1);
            panel4.Controls.Add(label1);
            panel4.Location = new Point(256, 41);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 100);
            panel4.TabIndex = 23;
            // 
            // roundedButton1
            // 
            roundedButton1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            roundedButton1.AutoSize = true;
            roundedButton1.BackColor = Color.FromArgb(80, 77, 180);
            roundedButton1.BackgroundColor = Color.FromArgb(80, 77, 180);
            roundedButton1.BorderColor = Color.Transparent;
            roundedButton1.BorderRadius = 10;
            roundedButton1.BorderSize = 0;
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatAppearance.MouseDownBackColor = Color.FromArgb(80, 77, 180);
            roundedButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 77, 180);
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.Font = new Font("Yu Gothic UI Semibold", 22F);
            roundedButton1.ForeColor = Color.White;
            roundedButton1.Location = new Point(15, 30);
            roundedButton1.MaximumSize = new Size(250, 100);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(171, 63);
            roundedButton1.TabIndex = 19;
            roundedButton1.Text = "250";
            roundedButton1.TextColor = Color.White;
            roundedButton1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Yu Gothic UI Semibold", 12F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(22, 6);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(105, 21);
            label1.TabIndex = 11;
            label1.Text = "No. of Books";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top;
            panel3.AutoSize = true;
            panel3.Controls.Add(dashboard_btn1);
            panel3.Controls.Add(dashboard_lbl1);
            panel3.Location = new Point(54, 41);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 100);
            panel3.TabIndex = 22;
            // 
            // dashboard_btn1
            // 
            dashboard_btn1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dashboard_btn1.AutoSize = true;
            dashboard_btn1.BackColor = Color.FromArgb(80, 77, 180);
            dashboard_btn1.BackgroundColor = Color.FromArgb(80, 77, 180);
            dashboard_btn1.BorderColor = Color.Transparent;
            dashboard_btn1.BorderRadius = 10;
            dashboard_btn1.BorderSize = 0;
            dashboard_btn1.FlatAppearance.BorderSize = 0;
            dashboard_btn1.FlatAppearance.MouseDownBackColor = Color.FromArgb(80, 77, 180);
            dashboard_btn1.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 77, 180);
            dashboard_btn1.FlatStyle = FlatStyle.Flat;
            dashboard_btn1.Font = new Font("Yu Gothic UI Semibold", 22F);
            dashboard_btn1.ForeColor = Color.White;
            dashboard_btn1.Location = new Point(15, 30);
            dashboard_btn1.MaximumSize = new Size(250, 100);
            dashboard_btn1.Name = "dashboard_btn1";
            dashboard_btn1.Size = new Size(171, 63);
            dashboard_btn1.TabIndex = 19;
            dashboard_btn1.Text = "250";
            dashboard_btn1.TextColor = Color.White;
            dashboard_btn1.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top;
            panel6.Controls.Add(dashboard_grd);
            panel6.Controls.Add(dashboard_lbl4);
            panel6.Location = new Point(39, 155);
            panel6.Name = "panel6";
            panel6.Size = new Size(635, 325);
            panel6.TabIndex = 24;
            // 
            // dashboard_grd
            // 
            dashboard_grd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dashboard_grd.BackgroundColor = Color.FromArgb(224, 224, 224);
            dashboard_grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dashboard_grd.Location = new Point(15, 39);
            dashboard_grd.Name = "dashboard_grd";
            dashboard_grd.Size = new Size(604, 273);
            dashboard_grd.TabIndex = 18;
            // 
            // dashboard_lbl4
            // 
            dashboard_lbl4.AutoSize = true;
            dashboard_lbl4.Font = new Font("Yu Gothic UI Semibold", 12F);
            dashboard_lbl4.ForeColor = Color.Black;
            dashboard_lbl4.Location = new Point(13, 11);
            dashboard_lbl4.Margin = new Padding(0);
            dashboard_lbl4.Name = "dashboard_lbl4";
            dashboard_lbl4.Size = new Size(163, 21);
            dashboard_lbl4.TabIndex = 17;
            dashboard_lbl4.Text = "Top Borrowed Books";
            // 
            // books_pnl
            // 
            books_pnl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            books_pnl.Controls.Add(books_refresh_btn);
            books_pnl.Controls.Add(books_add_btn);
            books_pnl.Controls.Add(books_edit_btn);
            books_pnl.Controls.Add(books_remove_btn);
            books_pnl.Controls.Add(books_lbl1);
            books_pnl.Controls.Add(books_src);
            books_pnl.Controls.Add(books_grd);
            books_pnl.Location = new Point(266, 56);
            books_pnl.Name = "books_pnl";
            books_pnl.Size = new Size(708, 493);
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
            books_refresh_btn.Location = new Point(52, 26);
            books_refresh_btn.Name = "books_refresh_btn";
            books_refresh_btn.Size = new Size(36, 36);
            books_refresh_btn.TabIndex = 15;
            books_refresh_btn.TabStop = false;
            books_refresh_btn.TextColor = Color.White;
            books_refresh_btn.UseVisualStyleBackColor = false;
            books_refresh_btn.Click += RefreshBooks;
            // 
            // books_add_btn
            // 
            books_add_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            books_add_btn.BackColor = Color.FromArgb(80, 77, 180);
            books_add_btn.BackgroundColor = Color.FromArgb(80, 77, 180);
            books_add_btn.BorderColor = Color.Transparent;
            books_add_btn.BorderRadius = 5;
            books_add_btn.BorderSize = 0;
            books_add_btn.FlatAppearance.BorderSize = 0;
            books_add_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            books_add_btn.FlatStyle = FlatStyle.Flat;
            books_add_btn.Font = new Font("Yu Gothic UI Semibold", 14F);
            books_add_btn.ForeColor = Color.White;
            books_add_btn.Location = new Point(349, 26);
            books_add_btn.Name = "books_add_btn";
            books_add_btn.Size = new Size(93, 36);
            books_add_btn.TabIndex = 14;
            books_add_btn.TabStop = false;
            books_add_btn.Text = "Add";
            books_add_btn.TextColor = Color.White;
            books_add_btn.UseVisualStyleBackColor = false;
            books_add_btn.Click += AddBook;
            // 
            // books_edit_btn
            // 
            books_edit_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            books_edit_btn.BackColor = Color.FromArgb(80, 77, 180);
            books_edit_btn.BackgroundColor = Color.FromArgb(80, 77, 180);
            books_edit_btn.BorderColor = Color.Transparent;
            books_edit_btn.BorderRadius = 5;
            books_edit_btn.BorderSize = 0;
            books_edit_btn.FlatAppearance.BorderSize = 0;
            books_edit_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            books_edit_btn.FlatStyle = FlatStyle.Flat;
            books_edit_btn.Font = new Font("Yu Gothic UI Semibold", 14F);
            books_edit_btn.ForeColor = Color.White;
            books_edit_btn.Location = new Point(151, 26);
            books_edit_btn.Name = "books_edit_btn";
            books_edit_btn.Size = new Size(93, 36);
            books_edit_btn.TabIndex = 13;
            books_edit_btn.TabStop = false;
            books_edit_btn.Text = "Edit";
            books_edit_btn.TextColor = Color.White;
            books_edit_btn.UseVisualStyleBackColor = false;
            books_edit_btn.Click += EditBook;
            // 
            // books_remove_btn
            // 
            books_remove_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            books_remove_btn.BackColor = Color.FromArgb(80, 77, 180);
            books_remove_btn.BackgroundColor = Color.FromArgb(80, 77, 180);
            books_remove_btn.BorderColor = Color.Transparent;
            books_remove_btn.BorderRadius = 5;
            books_remove_btn.BorderSize = 0;
            books_remove_btn.FlatAppearance.BorderSize = 0;
            books_remove_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            books_remove_btn.FlatStyle = FlatStyle.Flat;
            books_remove_btn.Font = new Font("Yu Gothic UI Semibold", 14F);
            books_remove_btn.ForeColor = Color.White;
            books_remove_btn.Location = new Point(250, 26);
            books_remove_btn.Name = "books_remove_btn";
            books_remove_btn.Size = new Size(93, 36);
            books_remove_btn.TabIndex = 12;
            books_remove_btn.TabStop = false;
            books_remove_btn.Text = "Remove";
            books_remove_btn.TextColor = Color.White;
            books_remove_btn.UseVisualStyleBackColor = false;
            books_remove_btn.Click += RemoveBook;
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
            books_src.Location = new Point(448, 29);
            books_src.MaxLength = 19;
            books_src.Name = "books_src";
            books_src.PlaceholderText = "Search...";
            books_src.Size = new Size(208, 32);
            books_src.TabIndex = 1;
            books_src.TabStop = false;
            books_src.TextChanged += SearchBook;
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
            books_grd.Location = new Point(52, 108);
            books_grd.Name = "books_grd";
            books_grd.ReadOnly = true;
            books_grd.RowHeadersVisible = false;
            books_grd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            books_grd.ShowCellErrors = false;
            books_grd.ShowCellToolTips = false;
            books_grd.ShowEditingIcon = false;
            books_grd.ShowRowErrors = false;
            books_grd.Size = new Size(604, 359);
            books_grd.TabIndex = 0;
            // 
            // title
            // 
            title.HeaderText = "Title";
            title.Name = "title";
            title.ReadOnly = true;
            title.Width = 54;
            // 
            // author
            // 
            author.HeaderText = "Author";
            author.Name = "author";
            author.ReadOnly = true;
            author.Width = 69;
            // 
            // publicationYear
            // 
            publicationYear.HeaderText = "Publication Year";
            publicationYear.Name = "publicationYear";
            publicationYear.ReadOnly = true;
            publicationYear.Width = 107;
            // 
            // category
            // 
            category.HeaderText = "Categroy";
            category.Name = "category";
            category.ReadOnly = true;
            category.Width = 80;
            // 
            // publisher
            // 
            publisher.HeaderText = "Publisher";
            publisher.Name = "publisher";
            publisher.ReadOnly = true;
            publisher.Width = 81;
            // 
            // isbn
            // 
            isbn.HeaderText = "ISBN";
            isbn.Name = "isbn";
            isbn.ReadOnly = true;
            isbn.Width = 57;
            // 
            // borrowings_pnl
            // 
            borrowings_pnl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            borrowings_pnl.BackColor = Color.White;
            borrowings_pnl.Controls.Add(borrowings_refresh_btn);
            borrowings_pnl.Controls.Add(borrowings_borrow_btn);
            borrowings_pnl.Controls.Add(borrowings_edit_btn);
            borrowings_pnl.Controls.Add(borrowings_return_btn);
            borrowings_pnl.Controls.Add(borrowings_lbl1);
            borrowings_pnl.Controls.Add(borrowings_src);
            borrowings_pnl.Controls.Add(borrowings_grd);
            borrowings_pnl.Location = new Point(266, 56);
            borrowings_pnl.Name = "borrowings_pnl";
            borrowings_pnl.Size = new Size(708, 493);
            borrowings_pnl.TabIndex = 14;
            borrowings_pnl.Visible = false;
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
            borrowings_refresh_btn.Size = new Size(36, 36);
            borrowings_refresh_btn.TabIndex = 29;
            borrowings_refresh_btn.TabStop = false;
            borrowings_refresh_btn.TextColor = Color.White;
            borrowings_refresh_btn.UseVisualStyleBackColor = false;
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
            borrowings_borrow_btn.Location = new Point(349, 26);
            borrowings_borrow_btn.Name = "borrowings_borrow_btn";
            borrowings_borrow_btn.Size = new Size(93, 36);
            borrowings_borrow_btn.TabIndex = 28;
            borrowings_borrow_btn.TabStop = false;
            borrowings_borrow_btn.Text = "Borrow";
            borrowings_borrow_btn.TextColor = Color.White;
            borrowings_borrow_btn.UseVisualStyleBackColor = false;
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
            borrowings_edit_btn.Location = new Point(151, 26);
            borrowings_edit_btn.Name = "borrowings_edit_btn";
            borrowings_edit_btn.Size = new Size(93, 36);
            borrowings_edit_btn.TabIndex = 27;
            borrowings_edit_btn.TabStop = false;
            borrowings_edit_btn.Text = "Edit";
            borrowings_edit_btn.TextColor = Color.White;
            borrowings_edit_btn.UseVisualStyleBackColor = false;
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
            borrowings_return_btn.Location = new Point(250, 26);
            borrowings_return_btn.Name = "borrowings_return_btn";
            borrowings_return_btn.Size = new Size(93, 36);
            borrowings_return_btn.TabIndex = 26;
            borrowings_return_btn.TabStop = false;
            borrowings_return_btn.Text = "Return";
            borrowings_return_btn.TextColor = Color.White;
            borrowings_return_btn.UseVisualStyleBackColor = false;
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
            borrowings_src.Location = new Point(448, 29);
            borrowings_src.MaxLength = 19;
            borrowings_src.Name = "borrowings_src";
            borrowings_src.PlaceholderText = "Search...";
            borrowings_src.Size = new Size(208, 32);
            borrowings_src.TabIndex = 24;
            borrowings_src.TabStop = false;
            // 
            // borrowings_grd
            // 
            borrowings_grd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            borrowings_grd.BackgroundColor = Color.White;
            borrowings_grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            borrowings_grd.Location = new Point(52, 108);
            borrowings_grd.Name = "borrowings_grd";
            borrowings_grd.Size = new Size(604, 359);
            borrowings_grd.TabIndex = 23;
            // 
            // categories_pnl
            // 
            categories_pnl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            categories_pnl.BackColor = Color.White;
            categories_pnl.Controls.Add(categories_refresh_btn);
            categories_pnl.Controls.Add(categories_add_btn);
            categories_pnl.Controls.Add(categories_edit_btn);
            categories_pnl.Controls.Add(categories_remove_btn);
            categories_pnl.Controls.Add(categories_lbl1);
            categories_pnl.Controls.Add(categories_src);
            categories_pnl.Controls.Add(categories_grd);
            categories_pnl.Location = new Point(266, 56);
            categories_pnl.Name = "categories_pnl";
            categories_pnl.Size = new Size(708, 493);
            categories_pnl.TabIndex = 23;
            categories_pnl.Visible = false;
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
            categories_refresh_btn.Size = new Size(36, 36);
            categories_refresh_btn.TabIndex = 22;
            categories_refresh_btn.TabStop = false;
            categories_refresh_btn.TextColor = Color.White;
            categories_refresh_btn.UseVisualStyleBackColor = false;
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
            categories_add_btn.Location = new Point(349, 26);
            categories_add_btn.Name = "categories_add_btn";
            categories_add_btn.Size = new Size(93, 36);
            categories_add_btn.TabIndex = 21;
            categories_add_btn.TabStop = false;
            categories_add_btn.Text = "Add";
            categories_add_btn.TextColor = Color.White;
            categories_add_btn.UseVisualStyleBackColor = false;
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
            categories_edit_btn.Location = new Point(151, 26);
            categories_edit_btn.Name = "categories_edit_btn";
            categories_edit_btn.Size = new Size(93, 36);
            categories_edit_btn.TabIndex = 20;
            categories_edit_btn.TabStop = false;
            categories_edit_btn.Text = "Edit";
            categories_edit_btn.TextColor = Color.White;
            categories_edit_btn.UseVisualStyleBackColor = false;
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
            categories_remove_btn.Location = new Point(250, 26);
            categories_remove_btn.Name = "categories_remove_btn";
            categories_remove_btn.Size = new Size(93, 36);
            categories_remove_btn.TabIndex = 19;
            categories_remove_btn.TabStop = false;
            categories_remove_btn.Text = "Remove";
            categories_remove_btn.TextColor = Color.White;
            categories_remove_btn.UseVisualStyleBackColor = false;
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
            categories_src.Location = new Point(448, 29);
            categories_src.MaxLength = 19;
            categories_src.Name = "categories_src";
            categories_src.PlaceholderText = "Search...";
            categories_src.Size = new Size(208, 32);
            categories_src.TabIndex = 17;
            categories_src.TabStop = false;
            // 
            // categories_grd
            // 
            categories_grd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            categories_grd.BackgroundColor = Color.White;
            categories_grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            categories_grd.Location = new Point(52, 108);
            categories_grd.Name = "categories_grd";
            categories_grd.Size = new Size(604, 359);
            categories_grd.TabIndex = 16;
            // 
            // members_pnl
            // 
            members_pnl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            members_pnl.Controls.Add(members_refresh_btn);
            members_pnl.Controls.Add(members_remove_btn);
            members_pnl.Controls.Add(members_edit_btn);
            members_pnl.Controls.Add(members_lbl1);
            members_pnl.Controls.Add(members_src);
            members_pnl.Controls.Add(members_grd);
            members_pnl.Location = new Point(266, 56);
            members_pnl.Name = "members_pnl";
            members_pnl.Size = new Size(708, 493);
            members_pnl.TabIndex = 24;
            members_pnl.Visible = false;
            // 
            // members_refresh_btn
            // 
            members_refresh_btn.BackColor = Color.FromArgb(80, 77, 180);
            members_refresh_btn.BackgroundColor = Color.FromArgb(80, 77, 180);
            members_refresh_btn.BorderColor = Color.Transparent;
            members_refresh_btn.BorderRadius = 5;
            members_refresh_btn.BorderSize = 0;
            members_refresh_btn.FlatAppearance.BorderSize = 0;
            members_refresh_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            members_refresh_btn.FlatStyle = FlatStyle.Flat;
            members_refresh_btn.Font = new Font("Yu Gothic UI Semibold", 14F);
            members_refresh_btn.ForeColor = Color.White;
            members_refresh_btn.Image = (Image)resources.GetObject("members_refresh_btn.Image");
            members_refresh_btn.Location = new Point(52, 26);
            members_refresh_btn.Name = "members_refresh_btn";
            members_refresh_btn.Size = new Size(36, 36);
            members_refresh_btn.TabIndex = 15;
            members_refresh_btn.TabStop = false;
            members_refresh_btn.TextColor = Color.White;
            members_refresh_btn.UseVisualStyleBackColor = false;
            // 
            // members_remove_btn
            // 
            members_remove_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            members_remove_btn.BackColor = Color.FromArgb(80, 77, 180);
            members_remove_btn.BackgroundColor = Color.FromArgb(80, 77, 180);
            members_remove_btn.BorderColor = Color.Transparent;
            members_remove_btn.BorderRadius = 5;
            members_remove_btn.BorderSize = 0;
            members_remove_btn.FlatAppearance.BorderSize = 0;
            members_remove_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            members_remove_btn.FlatStyle = FlatStyle.Flat;
            members_remove_btn.Font = new Font("Yu Gothic UI Semibold", 14F);
            members_remove_btn.ForeColor = Color.White;
            members_remove_btn.Location = new Point(349, 26);
            members_remove_btn.Name = "members_remove_btn";
            members_remove_btn.Size = new Size(93, 36);
            members_remove_btn.TabIndex = 14;
            members_remove_btn.TabStop = false;
            members_remove_btn.Text = "Remove";
            members_remove_btn.TextColor = Color.White;
            members_remove_btn.UseVisualStyleBackColor = false;
            // 
            // members_edit_btn
            // 
            members_edit_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            members_edit_btn.BackColor = Color.FromArgb(80, 77, 180);
            members_edit_btn.BackgroundColor = Color.FromArgb(80, 77, 180);
            members_edit_btn.BorderColor = Color.Transparent;
            members_edit_btn.BorderRadius = 5;
            members_edit_btn.BorderSize = 0;
            members_edit_btn.FlatAppearance.BorderSize = 0;
            members_edit_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            members_edit_btn.FlatStyle = FlatStyle.Flat;
            members_edit_btn.Font = new Font("Yu Gothic UI Semibold", 14F);
            members_edit_btn.ForeColor = Color.White;
            members_edit_btn.Location = new Point(250, 26);
            members_edit_btn.Name = "members_edit_btn";
            members_edit_btn.Size = new Size(93, 36);
            members_edit_btn.TabIndex = 12;
            members_edit_btn.TabStop = false;
            members_edit_btn.Text = "Edit";
            members_edit_btn.TextColor = Color.White;
            members_edit_btn.UseVisualStyleBackColor = false;
            // 
            // members_lbl1
            // 
            members_lbl1.AutoSize = true;
            members_lbl1.Font = new Font("Yu Gothic UI Semibold", 14F);
            members_lbl1.Location = new Point(52, 80);
            members_lbl1.Name = "members_lbl1";
            members_lbl1.Size = new Size(93, 25);
            members_lbl1.TabIndex = 11;
            members_lbl1.Text = "Members";
            // 
            // members_src
            // 
            members_src.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            members_src.BackColor = Color.White;
            members_src.Font = new Font("Yu Gothic UI Semibold", 14F);
            members_src.Location = new Point(448, 29);
            members_src.MaxLength = 19;
            members_src.Name = "members_src";
            members_src.PlaceholderText = "Search...";
            members_src.Size = new Size(208, 32);
            members_src.TabIndex = 1;
            members_src.TabStop = false;
            // 
            // members_grd
            // 
            members_grd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            members_grd.BackgroundColor = Color.White;
            members_grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            members_grd.Location = new Point(52, 108);
            members_grd.Name = "members_grd";
            members_grd.Size = new Size(604, 359);
            members_grd.TabIndex = 0;
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
            authors_pnl.Controls.Add(authors_grd);
            authors_pnl.Location = new Point(266, 56);
            authors_pnl.Name = "authors_pnl";
            authors_pnl.Size = new Size(708, 493);
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
            authors_refresh_btn.Location = new Point(52, 26);
            authors_refresh_btn.Name = "authors_refresh_btn";
            authors_refresh_btn.Size = new Size(36, 36);
            authors_refresh_btn.TabIndex = 22;
            authors_refresh_btn.TabStop = false;
            authors_refresh_btn.TextColor = Color.White;
            authors_refresh_btn.UseVisualStyleBackColor = false;
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
            authors_add_btn.Location = new Point(349, 26);
            authors_add_btn.Name = "authors_add_btn";
            authors_add_btn.Size = new Size(93, 36);
            authors_add_btn.TabIndex = 21;
            authors_add_btn.TabStop = false;
            authors_add_btn.Text = "Add";
            authors_add_btn.TextColor = Color.White;
            authors_add_btn.UseVisualStyleBackColor = false;
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
            authors_edit_btn.Location = new Point(151, 26);
            authors_edit_btn.Name = "authors_edit_btn";
            authors_edit_btn.Size = new Size(93, 36);
            authors_edit_btn.TabIndex = 20;
            authors_edit_btn.TabStop = false;
            authors_edit_btn.Text = "Edit";
            authors_edit_btn.TextColor = Color.White;
            authors_edit_btn.UseVisualStyleBackColor = false;
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
            authors_remove_btn.Location = new Point(250, 26);
            authors_remove_btn.Name = "authors_remove_btn";
            authors_remove_btn.Size = new Size(93, 36);
            authors_remove_btn.TabIndex = 19;
            authors_remove_btn.TabStop = false;
            authors_remove_btn.Text = "Remove";
            authors_remove_btn.TextColor = Color.White;
            authors_remove_btn.UseVisualStyleBackColor = false;
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
            authors_src.Location = new Point(448, 29);
            authors_src.MaxLength = 19;
            authors_src.Name = "authors_src";
            authors_src.PlaceholderText = "Search...";
            authors_src.Size = new Size(208, 32);
            authors_src.TabIndex = 17;
            authors_src.TabStop = false;
            // 
            // authors_grd
            // 
            authors_grd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            authors_grd.BackgroundColor = Color.White;
            authors_grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            authors_grd.Location = new Point(52, 108);
            authors_grd.Name = "authors_grd";
            authors_grd.Size = new Size(604, 359);
            authors_grd.TabIndex = 16;
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
            publishers_pnl.Controls.Add(publishers_grd);
            publishers_pnl.Location = new Point(266, 56);
            publishers_pnl.Name = "publishers_pnl";
            publishers_pnl.Size = new Size(708, 493);
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
            publishers_refresh_btn.Location = new Point(52, 26);
            publishers_refresh_btn.Name = "publishers_refresh_btn";
            publishers_refresh_btn.Size = new Size(36, 36);
            publishers_refresh_btn.TabIndex = 22;
            publishers_refresh_btn.TabStop = false;
            publishers_refresh_btn.TextColor = Color.White;
            publishers_refresh_btn.UseVisualStyleBackColor = false;
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
            publishers_add_btn.Location = new Point(349, 26);
            publishers_add_btn.Name = "publishers_add_btn";
            publishers_add_btn.Size = new Size(93, 36);
            publishers_add_btn.TabIndex = 21;
            publishers_add_btn.TabStop = false;
            publishers_add_btn.Text = "Add";
            publishers_add_btn.TextColor = Color.White;
            publishers_add_btn.UseVisualStyleBackColor = false;
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
            publishers_edit_btn.Location = new Point(151, 26);
            publishers_edit_btn.Name = "publishers_edit_btn";
            publishers_edit_btn.Size = new Size(93, 36);
            publishers_edit_btn.TabIndex = 20;
            publishers_edit_btn.TabStop = false;
            publishers_edit_btn.Text = "Edit";
            publishers_edit_btn.TextColor = Color.White;
            publishers_edit_btn.UseVisualStyleBackColor = false;
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
            publishers_remove_btn.Location = new Point(250, 26);
            publishers_remove_btn.Name = "publishers_remove_btn";
            publishers_remove_btn.Size = new Size(93, 36);
            publishers_remove_btn.TabIndex = 19;
            publishers_remove_btn.TabStop = false;
            publishers_remove_btn.Text = "Remove";
            publishers_remove_btn.TextColor = Color.White;
            publishers_remove_btn.UseVisualStyleBackColor = false;
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
            publishers_src.Location = new Point(448, 29);
            publishers_src.MaxLength = 19;
            publishers_src.Name = "publishers_src";
            publishers_src.PlaceholderText = "Search...";
            publishers_src.Size = new Size(208, 32);
            publishers_src.TabIndex = 17;
            publishers_src.TabStop = false;
            // 
            // publishers_grd
            // 
            publishers_grd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            publishers_grd.BackgroundColor = Color.White;
            publishers_grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            publishers_grd.Location = new Point(52, 108);
            publishers_grd.Name = "publishers_grd";
            publishers_grd.Size = new Size(604, 359);
            publishers_grd.TabIndex = 16;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(984, 561);
            Controls.Add(header_pnl);
            Controls.Add(menu_pnl);
            Controls.Add(dashboard_pnl);
            Controls.Add(publishers_pnl);
            Controls.Add(authors_pnl);
            Controls.Add(categories_pnl);
            Controls.Add(borrowings_pnl);
            Controls.Add(members_pnl);
            Controls.Add(books_pnl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1000, 600);
            Name = "AdminPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Panel";
            Load += ShowDashboard;
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
            members_pnl.ResumeLayout(false);
            members_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)members_grd).EndInit();
            authors_pnl.ResumeLayout(false);
            authors_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)authors_grd).EndInit();
            publishers_pnl.ResumeLayout(false);
            publishers_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)publishers_grd).EndInit();
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
        private Button members_btn;
        private Button books_btn;
        private Label greeting_lbl;
        private Label dashboard_lbl1;
        private Panel dashboard_pnl;
        private Label dashboard_lbl4;
        private DataGridView dashboard_grd;
        private Panel books_pnl;
        private Label books_lbl1;
        private RoundedButton books_remove_btn;
        private RoundedButton books_add_btn;
        private RoundedButton books_edit_btn;
        private RoundedButton books_refresh_btn;
        private RoundedButton dashboard_btn1;
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
        private Label members_lbl1;
        private TextBox categories_src;
        private DataGridView categories_grd;
        private Label categories_lbl1;
        private RoundedButton borrowings_refresh_btn;
        private RoundedButton borrowings_borrow_btn;
        private RoundedButton borrowings_edit_btn;
        private RoundedButton borrowings_return_btn;
        private Label borrowings_lbl1;
        private TextBox borrowings_src;
        private DataGridView borrowings_grd;
        private Panel members_pnl;
        private RoundedButton members_refresh_btn;
        private RoundedButton members_remove_btn;
        private RoundedButton members_edit_btn;
        private TextBox members_src;
        private DataGridView members_grd;
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
        private DataGridView authors_grd;
        private Panel publishers_pnl;
        private RoundedButton publishers_refresh_btn;
        private RoundedButton publishers_add_btn;
        private RoundedButton publishers_edit_btn;
        private RoundedButton publishers_remove_btn;
        private Label publishers_lbl1;
        private TextBox publishers_src;
        private DataGridView publishers_grd;
        private Panel panel3;
        private Panel panel4;
        private RoundedButton roundedButton1;
        private Label label1;
        private Panel panel5;
        private RoundedButton roundedButton2;
        private Label label2;
        private Panel panel6;
        private DataGridViewTextBoxColumn title;
        private DataGridViewTextBoxColumn author;
        private DataGridViewTextBoxColumn publicationYear;
        private DataGridViewTextBoxColumn category;
        private DataGridViewTextBoxColumn publisher;
        private DataGridViewTextBoxColumn isbn;
        private DataGridView books_grd;
    }
}