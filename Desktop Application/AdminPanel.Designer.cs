namespace Desktop_Application
{
    partial class adminPanel
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
            backPanel1 = new Panel();
            label1 = new Label();
            logout_btn = new Button();
            librarians_btn = new Button();
            categories_btn = new Button();
            borrowings_btn = new Button();
            members_btn = new Button();
            books_btn = new Button();
            dashboard_btn = new Button();
            close_btn = new Label();
            backPanel2 = new Panel();
            greeting_label = new Label();
            title_label = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            panel4 = new Panel();
            label6 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            panel3 = new Panel();
            label5 = new Label();
            backPanel1.SuspendLayout();
            backPanel2.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // backPanel1
            // 
            backPanel1.BackColor = Color.FromArgb(80, 77, 180);
            backPanel1.Controls.Add(logout_btn);
            backPanel1.Controls.Add(librarians_btn);
            backPanel1.Controls.Add(categories_btn);
            backPanel1.Controls.Add(borrowings_btn);
            backPanel1.Controls.Add(members_btn);
            backPanel1.Controls.Add(books_btn);
            backPanel1.Controls.Add(dashboard_btn);
            backPanel1.Location = new Point(0, 0);
            backPanel1.MinimumSize = new Size(200, 422);
            backPanel1.Name = "backPanel1";
            backPanel1.Size = new Size(260, 561);
            backPanel1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI Semibold", 14F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(63, 66);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(122, 25);
            label1.TabIndex = 11;
            label1.Text = "No. of Books";
            // 
            // logout_btn
            // 
            logout_btn.BackColor = Color.FromArgb(224, 224, 224);
            logout_btn.FlatAppearance.BorderSize = 0;
            logout_btn.FlatStyle = FlatStyle.Flat;
            logout_btn.Font = new Font("Yu Gothic UI Semibold", 12F);
            logout_btn.Location = new Point(94, 490);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(71, 31);
            logout_btn.TabIndex = 6;
            logout_btn.TabStop = false;
            logout_btn.Text = "Logout";
            logout_btn.UseVisualStyleBackColor = false;
            logout_btn.Click += Logout;
            // 
            // librarians_btn
            // 
            librarians_btn.BackColor = Color.FromArgb(80, 77, 180);
            librarians_btn.FlatAppearance.BorderSize = 0;
            librarians_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            librarians_btn.FlatStyle = FlatStyle.Flat;
            librarians_btn.Font = new Font("Yu Gothic UI Semibold", 14F);
            librarians_btn.ForeColor = Color.White;
            librarians_btn.Location = new Point(1, 360);
            librarians_btn.Name = "librarians_btn";
            librarians_btn.Size = new Size(260, 36);
            librarians_btn.TabIndex = 5;
            librarians_btn.TabStop = false;
            librarians_btn.Text = "Librarians";
            librarians_btn.UseVisualStyleBackColor = false;
            // 
            // categories_btn
            // 
            categories_btn.BackColor = Color.FromArgb(80, 77, 180);
            categories_btn.FlatAppearance.BorderSize = 0;
            categories_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            categories_btn.FlatStyle = FlatStyle.Flat;
            categories_btn.Font = new Font("Yu Gothic UI Semibold", 14F);
            categories_btn.ForeColor = Color.White;
            categories_btn.Location = new Point(1, 318);
            categories_btn.Name = "categories_btn";
            categories_btn.Size = new Size(260, 36);
            categories_btn.TabIndex = 4;
            categories_btn.TabStop = false;
            categories_btn.Text = "Categories";
            categories_btn.UseVisualStyleBackColor = false;
            // 
            // borrowings_btn
            // 
            borrowings_btn.BackColor = Color.FromArgb(80, 77, 180);
            borrowings_btn.FlatAppearance.BorderSize = 0;
            borrowings_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            borrowings_btn.FlatStyle = FlatStyle.Flat;
            borrowings_btn.Font = new Font("Yu Gothic UI Semibold", 14F);
            borrowings_btn.ForeColor = Color.White;
            borrowings_btn.Location = new Point(1, 276);
            borrowings_btn.Name = "borrowings_btn";
            borrowings_btn.Size = new Size(260, 36);
            borrowings_btn.TabIndex = 3;
            borrowings_btn.TabStop = false;
            borrowings_btn.Text = "Borrowings";
            borrowings_btn.UseVisualStyleBackColor = false;
            // 
            // members_btn
            // 
            members_btn.BackColor = Color.FromArgb(80, 77, 180);
            members_btn.FlatAppearance.BorderSize = 0;
            members_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            members_btn.FlatStyle = FlatStyle.Flat;
            members_btn.Font = new Font("Yu Gothic UI Semibold", 14F);
            members_btn.ForeColor = Color.White;
            members_btn.Location = new Point(1, 234);
            members_btn.Name = "members_btn";
            members_btn.Size = new Size(260, 36);
            members_btn.TabIndex = 2;
            members_btn.TabStop = false;
            members_btn.Text = "Members";
            members_btn.UseVisualStyleBackColor = false;
            // 
            // books_btn
            // 
            books_btn.BackColor = Color.FromArgb(80, 77, 180);
            books_btn.FlatAppearance.BorderSize = 0;
            books_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            books_btn.FlatStyle = FlatStyle.Flat;
            books_btn.Font = new Font("Yu Gothic UI Semibold", 14F);
            books_btn.ForeColor = Color.White;
            books_btn.Location = new Point(1, 192);
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
            dashboard_btn.BackColor = Color.FromArgb(80, 77, 180);
            dashboard_btn.FlatAppearance.BorderSize = 0;
            dashboard_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            dashboard_btn.FlatStyle = FlatStyle.Flat;
            dashboard_btn.Font = new Font("Yu Gothic UI Semibold", 14F);
            dashboard_btn.ForeColor = Color.White;
            dashboard_btn.Location = new Point(1, 150);
            dashboard_btn.Name = "dashboard_btn";
            dashboard_btn.Size = new Size(260, 36);
            dashboard_btn.TabIndex = 0;
            dashboard_btn.TabStop = false;
            dashboard_btn.Text = "Dashboard";
            dashboard_btn.UseVisualStyleBackColor = false;
            dashboard_btn.Click += ShowDashboard;
            // 
            // close_btn
            // 
            close_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            close_btn.AutoSize = true;
            close_btn.Cursor = Cursors.Hand;
            close_btn.Font = new Font("Yu Gothic UI Semibold", 16F);
            close_btn.ForeColor = Color.White;
            close_btn.Location = new Point(948, 9);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(27, 30);
            close_btn.TabIndex = 10;
            close_btn.Text = "X";
            close_btn.Click += CloseWindow;
            // 
            // backPanel2
            // 
            backPanel2.BackColor = Color.FromArgb(72, 69, 158);
            backPanel2.Controls.Add(greeting_label);
            backPanel2.Controls.Add(close_btn);
            backPanel2.Controls.Add(title_label);
            backPanel2.Location = new Point(0, 0);
            backPanel2.Name = "backPanel2";
            backPanel2.Size = new Size(985, 50);
            backPanel2.TabIndex = 11;
            backPanel2.MouseDown += Login_MouseDown;
            backPanel2.MouseMove += Login_MouseMove;
            backPanel2.MouseUp += Login_MouseUp;
            // 
            // greeting_label
            // 
            greeting_label.Font = new Font("Yu Gothic UI Semibold", 16F);
            greeting_label.ForeColor = Color.White;
            greeting_label.Location = new Point(335, 9);
            greeting_label.Name = "greeting_label";
            greeting_label.Size = new Size(605, 30);
            greeting_label.TabIndex = 1;
            greeting_label.Text = "Hello, Admin 🐱‍🚀";
            greeting_label.TextAlign = ContentAlignment.TopRight;
            greeting_label.MouseDown += Login_MouseDown;
            greeting_label.MouseMove += Login_MouseMove;
            greeting_label.MouseUp += Login_MouseUp;
            // 
            // title_label
            // 
            title_label.AutoSize = true;
            title_label.Font = new Font("Yu Gothic UI Semibold", 16F);
            title_label.ForeColor = Color.White;
            title_label.Location = new Point(11, 9);
            title_label.Name = "title_label";
            title_label.Size = new Size(296, 30);
            title_label.TabIndex = 0;
            title_label.Text = "Library Management System";
            title_label.MouseDown += Login_MouseDown;
            title_label.MouseMove += Login_MouseMove;
            title_label.MouseUp += Login_MouseUp;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(266, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(709, 493);
            panel1.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI Semibold", 14F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(271, 66);
            label2.Name = "label2";
            label2.Size = new Size(152, 25);
            label2.TabIndex = 12;
            label2.Text = "No. of Members";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI Semibold", 14F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(475, 66);
            label3.Name = "label3";
            label3.Size = new Size(167, 25);
            label3.TabIndex = 13;
            label3.Text = "No. of Borrowings";
            // 
            // panel4
            // 
            panel4.Controls.Add(label6);
            panel4.Location = new Point(69, 94);
            panel4.Name = "panel4";
            panel4.Size = new Size(171, 63);
            panel4.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(41, 19);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 0;
            label6.Text = "label6";
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Location = new Point(277, 94);
            panel2.Name = "panel2";
            panel2.Size = new Size(171, 63);
            panel2.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 19);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 0;
            label4.Text = "label4";
            // 
            // panel3
            // 
            panel3.Controls.Add(label5);
            panel3.Location = new Point(481, 94);
            panel3.Name = "panel3";
            panel3.Size = new Size(171, 63);
            panel3.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 19);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 0;
            label5.Text = "label5";
            // 
            // adminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(panel1);
            Controls.Add(backPanel2);
            Controls.Add(backPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "adminPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Panel";
            backPanel1.ResumeLayout(false);
            backPanel2.ResumeLayout(false);
            backPanel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel backPanel1;
        private Label close_btn;
        private Button dashboard_btn;
        private Panel backPanel2;
        private Label title_label;
        private Button categories_btn;
        private Button borrowings_btn;
        private Button members_btn;
        private Button books_btn;
        private Button logout_btn;
        private Button librarians_btn;
        private Label greeting_label;
        private Label label1;
        private Panel panel1;
        private Panel panel4;
        private Label label3;
        private Label label2;
        private Label label6;
        private Panel panel2;
        private Label label4;
        private Panel panel3;
        private Label label5;
    }
}