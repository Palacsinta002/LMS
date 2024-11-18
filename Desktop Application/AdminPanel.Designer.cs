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
            logout_btn = new Button();
            categories_btn = new Button();
            borrowings_btn = new Button();
            members_btn = new Button();
            books_btn = new Button();
            dashboard_btn = new Button();
            label1 = new Label();
            backPanel2 = new Panel();
            greeting_label = new Label();
            title_label = new Label();
            dashboardPanel = new Panel();
            label7 = new Label();
            panel3 = new Panel();
            pictureBox3 = new PictureBox();
            label6 = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            booksPanel = new Panel();
            label8 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            searchBox = new TextBox();
            dataGridView2 = new DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backPanel1.SuspendLayout();
            backPanel2.SuspendLayout();
            dashboardPanel.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            booksPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // backPanel1
            // 
            backPanel1.BackColor = Color.FromArgb(80, 77, 180);
            backPanel1.Controls.Add(logout_btn);
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
            // categories_btn
            // 
            categories_btn.BackColor = Color.FromArgb(80, 77, 180);
            categories_btn.FlatAppearance.BorderSize = 0;
            categories_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            categories_btn.FlatStyle = FlatStyle.Flat;
            categories_btn.Font = new Font("Yu Gothic UI Semibold", 14F);
            categories_btn.ForeColor = Color.White;
            categories_btn.Location = new Point(3, 302);
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
            borrowings_btn.Location = new Point(3, 260);
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
            members_btn.Location = new Point(1, 344);
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
            books_btn.Location = new Point(1, 218);
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
            dashboard_btn.Location = new Point(1, 176);
            dashboard_btn.Name = "dashboard_btn";
            dashboard_btn.Size = new Size(260, 36);
            dashboard_btn.TabIndex = 0;
            dashboard_btn.TabStop = false;
            dashboard_btn.Text = "Dashboard";
            dashboard_btn.UseVisualStyleBackColor = false;
            dashboard_btn.Click += ShowDashboard;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI Semibold", 12F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(66, 33);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(105, 21);
            label1.TabIndex = 11;
            label1.Text = "No. of Books";
            // 
            // backPanel2
            // 
            backPanel2.BackColor = Color.FromArgb(72, 69, 158);
            backPanel2.Controls.Add(greeting_label);
            backPanel2.Controls.Add(title_label);
            backPanel2.Location = new Point(0, 0);
            backPanel2.Name = "backPanel2";
            backPanel2.Size = new Size(985, 50);
            backPanel2.TabIndex = 11;
            // 
            // greeting_label
            // 
            greeting_label.Font = new Font("Yu Gothic UI Semibold", 16F);
            greeting_label.ForeColor = Color.White;
            greeting_label.Location = new Point(335, 9);
            greeting_label.Name = "greeting_label";
            greeting_label.Size = new Size(647, 30);
            greeting_label.TabIndex = 1;
            greeting_label.Text = "Hello, Admin 🐱‍🚀";
            greeting_label.TextAlign = ContentAlignment.TopRight;
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
            // 
            // dashboardPanel
            // 
            dashboardPanel.Controls.Add(label7);
            dashboardPanel.Controls.Add(panel3);
            dashboardPanel.Controls.Add(panel2);
            dashboardPanel.Controls.Add(panel4);
            dashboardPanel.Controls.Add(label3);
            dashboardPanel.Controls.Add(label2);
            dashboardPanel.Controls.Add(label1);
            dashboardPanel.Controls.Add(dataGridView1);
            dashboardPanel.Location = new Point(266, 56);
            dashboardPanel.Name = "dashboardPanel";
            dashboardPanel.Size = new Size(709, 493);
            dashboardPanel.TabIndex = 12;
            dashboardPanel.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic UI Semibold", 12F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(59, 171);
            label7.Margin = new Padding(0);
            label7.Name = "label7";
            label7.Size = new Size(163, 21);
            label7.TabIndex = 17;
            label7.Text = "Top Borrowed Books";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ScrollBar;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(478, 57);
            panel3.Name = "panel3";
            panel3.Size = new Size(171, 63);
            panel3.TabIndex = 16;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ActiveCaptionText;
            pictureBox3.Location = new Point(37, 21);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 24);
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.Font = new Font("Yu Gothic UI Semibold", 22F);
            label6.Location = new Point(61, 11);
            label6.Name = "label6";
            label6.Size = new Size(69, 41);
            label6.TabIndex = 0;
            label6.Text = "75";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ScrollBar;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(273, 57);
            panel2.Name = "panel2";
            panel2.Size = new Size(171, 63);
            panel2.TabIndex = 16;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ActiveCaptionText;
            pictureBox2.Location = new Point(37, 21);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 24);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI Semibold", 22F);
            label5.Location = new Point(63, 11);
            label5.Name = "label5";
            label5.Size = new Size(68, 41);
            label5.TabIndex = 0;
            label5.Text = "750";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ScrollBar;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(66, 57);
            panel4.Name = "panel4";
            panel4.Size = new Size(171, 63);
            panel4.TabIndex = 15;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaptionText;
            pictureBox1.Location = new Point(37, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 24);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI Semibold", 22F);
            label4.Location = new Point(63, 11);
            label4.Name = "label4";
            label4.Size = new Size(69, 41);
            label4.TabIndex = 0;
            label4.Text = "250";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI Semibold", 12F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(478, 33);
            label3.Name = "label3";
            label3.Size = new Size(144, 21);
            label3.TabIndex = 13;
            label3.Text = "No. of Borrowings";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI Semibold", 12F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(273, 33);
            label2.Name = "label2";
            label2.Size = new Size(130, 21);
            label2.TabIndex = 12;
            label2.Text = "No. of Members";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(59, 204);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(590, 261);
            dataGridView1.TabIndex = 18;
            // 
            // booksPanel
            // 
            booksPanel.Controls.Add(label8);
            booksPanel.Controls.Add(button4);
            booksPanel.Controls.Add(button3);
            booksPanel.Controls.Add(button2);
            booksPanel.Controls.Add(button1);
            booksPanel.Controls.Add(searchBox);
            booksPanel.Controls.Add(dataGridView2);
            booksPanel.Location = new Point(267, 56);
            booksPanel.Name = "booksPanel";
            booksPanel.Size = new Size(708, 493);
            booksPanel.TabIndex = 13;
            booksPanel.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Yu Gothic UI Semibold", 14F);
            label8.Location = new Point(58, 78);
            label8.Name = "label8";
            label8.Size = new Size(63, 25);
            label8.TabIndex = 11;
            label8.Text = "Books";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(80, 77, 180);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Yu Gothic UI Semibold", 14F);
            button4.ForeColor = Color.White;
            button4.Location = new Point(58, 20);
            button4.Name = "button4";
            button4.Size = new Size(42, 36);
            button4.TabIndex = 10;
            button4.TabStop = false;
            button4.Text = "🔁";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(80, 77, 180);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Yu Gothic UI Semibold", 14F);
            button3.ForeColor = Color.White;
            button3.Location = new Point(138, 20);
            button3.Name = "button3";
            button3.Size = new Size(93, 36);
            button3.TabIndex = 9;
            button3.TabStop = false;
            button3.Text = "Edit";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(80, 77, 180);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Yu Gothic UI Semibold", 14F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(336, 20);
            button2.Name = "button2";
            button2.Size = new Size(93, 36);
            button2.TabIndex = 8;
            button2.TabStop = false;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(80, 77, 180);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Yu Gothic UI Semibold", 14F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(237, 20);
            button1.Name = "button1";
            button1.Size = new Size(93, 36);
            button1.TabIndex = 7;
            button1.TabStop = false;
            button1.Text = "Remove";
            button1.UseVisualStyleBackColor = false;
            // 
            // searchBox
            // 
            searchBox.Font = new Font("Yu Gothic UI Semibold", 14F);
            searchBox.Location = new Point(440, 22);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(208, 32);
            searchBox.TabIndex = 1;
            searchBox.TabStop = false;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(58, 106);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(590, 359);
            dataGridView2.TabIndex = 0;
            // 
            // adminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(backPanel2);
            Controls.Add(backPanel1);
            Controls.Add(booksPanel);
            Controls.Add(dashboardPanel);
            MinimumSize = new Size(1000, 600);
            Name = "adminPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Panel";
            backPanel1.ResumeLayout(false);
            backPanel2.ResumeLayout(false);
            backPanel2.PerformLayout();
            dashboardPanel.ResumeLayout(false);
            dashboardPanel.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            booksPanel.ResumeLayout(false);
            booksPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel backPanel1;
        private Button dashboard_btn;
        private Panel backPanel2;
        private Label title_label;
        private Button categories_btn;
        private Button borrowings_btn;
        private Button members_btn;
        private Button books_btn;
        private Button logout_btn;
        private Label greeting_label;
        private Label label1;
        private Panel dashboardPanel;
        private Panel panel4;
        private Label label3;
        private Label label2;
        private Label label4;
        private PictureBox pictureBox1;
        private Panel panel3;
        private PictureBox pictureBox3;
        private Label label6;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label5;
        private Label label7;
        private DataGridView dataGridView1;
        private Panel booksPanel;
        private TextBox searchBox;
        private DataGridView dataGridView2;
        private Button button2;
        private Button button1;
        private Button button4;
        private Button button3;
        private Label label8;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}