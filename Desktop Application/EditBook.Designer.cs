namespace Desktop_Application
{
    partial class EditBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditBook));
            editBook_lbl1 = new Label();
            editBook_lbl2 = new Label();
            editBook_title_txt = new TextBox();
            editBook_cancel_btn = new RoundedButton();
            editBook_publisher_txt = new TextBox();
            editBook_lbl4 = new Label();
            editBook_author_txt = new TextBox();
            editBook_lbl5 = new Label();
            editBook_lbl6 = new Label();
            editBook_lbl7 = new Label();
            editBook_lbl3 = new Label();
            editBook_isbn_txt = new TextBox();
            editBook_publicationYear_txt = new TextBox();
            editBook_save_btn = new RoundedButton();
            close_btn = new RoundedButton();
            panel1 = new Panel();
            editBook_category_dwn = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // editBook_lbl1
            // 
            editBook_lbl1.AutoSize = true;
            editBook_lbl1.Font = new Font("Yu Gothic UI Semibold", 16F);
            editBook_lbl1.Location = new Point(126, 12);
            editBook_lbl1.Name = "editBook_lbl1";
            editBook_lbl1.Size = new Size(108, 30);
            editBook_lbl1.TabIndex = 2;
            editBook_lbl1.Text = "Edit Book";
            editBook_lbl1.MouseDown += EditBook_MouseDown;
            editBook_lbl1.MouseMove += EditBook_MouseMove;
            editBook_lbl1.MouseUp += EditBook_MouseUp;
            // 
            // editBook_lbl2
            // 
            editBook_lbl2.AutoSize = true;
            editBook_lbl2.Font = new Font("Yu Gothic UI Semibold", 14F);
            editBook_lbl2.Location = new Point(12, 73);
            editBook_lbl2.Name = "editBook_lbl2";
            editBook_lbl2.Size = new Size(49, 25);
            editBook_lbl2.TabIndex = 3;
            editBook_lbl2.Text = "Title";
            // 
            // editBook_title_txt
            // 
            editBook_title_txt.BackColor = Color.WhiteSmoke;
            editBook_title_txt.Font = new Font("Yu Gothic UI Semibold", 14F);
            editBook_title_txt.Location = new Point(109, 70);
            editBook_title_txt.Name = "editBook_title_txt";
            editBook_title_txt.Size = new Size(243, 32);
            editBook_title_txt.TabIndex = 9;
            // 
            // editBook_cancel_btn
            // 
            editBook_cancel_btn.BackColor = Color.WhiteSmoke;
            editBook_cancel_btn.BackgroundColor = Color.WhiteSmoke;
            editBook_cancel_btn.BorderColor = Color.FromArgb(80, 77, 180);
            editBook_cancel_btn.BorderRadius = 5;
            editBook_cancel_btn.BorderSize = 2;
            editBook_cancel_btn.FlatAppearance.BorderSize = 0;
            editBook_cancel_btn.FlatStyle = FlatStyle.Flat;
            editBook_cancel_btn.Font = new Font("Yu Gothic UI Semibold", 14F);
            editBook_cancel_btn.ForeColor = Color.Black;
            editBook_cancel_btn.Location = new Point(272, 312);
            editBook_cancel_btn.Name = "editBook_cancel_btn";
            editBook_cancel_btn.Size = new Size(80, 36);
            editBook_cancel_btn.TabIndex = 0;
            editBook_cancel_btn.Text = "Cancel";
            editBook_cancel_btn.TextColor = Color.Black;
            editBook_cancel_btn.UseVisualStyleBackColor = false;
            editBook_cancel_btn.Click += Cancel;
            // 
            // editBook_publisher_txt
            // 
            editBook_publisher_txt.BackColor = Color.WhiteSmoke;
            editBook_publisher_txt.Font = new Font("Yu Gothic UI Semibold", 14F);
            editBook_publisher_txt.Location = new Point(109, 146);
            editBook_publisher_txt.Name = "editBook_publisher_txt";
            editBook_publisher_txt.Size = new Size(243, 32);
            editBook_publisher_txt.TabIndex = 11;
            // 
            // editBook_lbl4
            // 
            editBook_lbl4.AutoSize = true;
            editBook_lbl4.Font = new Font("Yu Gothic UI Semibold", 14F);
            editBook_lbl4.Location = new Point(12, 149);
            editBook_lbl4.Name = "editBook_lbl4";
            editBook_lbl4.Size = new Size(91, 25);
            editBook_lbl4.TabIndex = 10;
            editBook_lbl4.Text = "Publisher";
            // 
            // editBook_author_txt
            // 
            editBook_author_txt.BackColor = Color.WhiteSmoke;
            editBook_author_txt.Font = new Font("Yu Gothic UI Semibold", 14F);
            editBook_author_txt.Location = new Point(109, 184);
            editBook_author_txt.Name = "editBook_author_txt";
            editBook_author_txt.Size = new Size(243, 32);
            editBook_author_txt.TabIndex = 13;
            // 
            // editBook_lbl5
            // 
            editBook_lbl5.AutoSize = true;
            editBook_lbl5.Font = new Font("Yu Gothic UI Semibold", 14F);
            editBook_lbl5.Location = new Point(12, 187);
            editBook_lbl5.Name = "editBook_lbl5";
            editBook_lbl5.Size = new Size(72, 25);
            editBook_lbl5.TabIndex = 12;
            editBook_lbl5.Text = "Author";
            // 
            // editBook_lbl6
            // 
            editBook_lbl6.AutoSize = true;
            editBook_lbl6.Font = new Font("Yu Gothic UI Semibold", 14F);
            editBook_lbl6.Location = new Point(12, 225);
            editBook_lbl6.Name = "editBook_lbl6";
            editBook_lbl6.Size = new Size(90, 25);
            editBook_lbl6.TabIndex = 14;
            editBook_lbl6.Text = "Category";
            // 
            // editBook_lbl7
            // 
            editBook_lbl7.AutoSize = true;
            editBook_lbl7.Font = new Font("Yu Gothic UI Semibold", 14F);
            editBook_lbl7.Location = new Point(12, 263);
            editBook_lbl7.Name = "editBook_lbl7";
            editBook_lbl7.Size = new Size(54, 25);
            editBook_lbl7.TabIndex = 16;
            editBook_lbl7.Text = "ISBN";
            // 
            // editBook_lbl3
            // 
            editBook_lbl3.AutoSize = true;
            editBook_lbl3.Font = new Font("Yu Gothic UI Semibold", 14F);
            editBook_lbl3.Location = new Point(12, 111);
            editBook_lbl3.Name = "editBook_lbl3";
            editBook_lbl3.Size = new Size(150, 25);
            editBook_lbl3.TabIndex = 18;
            editBook_lbl3.Text = "Publication Year";
            // 
            // editBook_isbn_txt
            // 
            editBook_isbn_txt.BackColor = Color.WhiteSmoke;
            editBook_isbn_txt.Font = new Font("Yu Gothic UI Semibold", 14F);
            editBook_isbn_txt.Location = new Point(109, 260);
            editBook_isbn_txt.MaxLength = 13;
            editBook_isbn_txt.Name = "editBook_isbn_txt";
            editBook_isbn_txt.Size = new Size(243, 32);
            editBook_isbn_txt.TabIndex = 19;
            // 
            // editBook_publicationYear_txt
            // 
            editBook_publicationYear_txt.BackColor = Color.WhiteSmoke;
            editBook_publicationYear_txt.Font = new Font("Yu Gothic UI Semibold", 14F);
            editBook_publicationYear_txt.Location = new Point(168, 108);
            editBook_publicationYear_txt.MaxLength = 4;
            editBook_publicationYear_txt.Name = "editBook_publicationYear_txt";
            editBook_publicationYear_txt.Size = new Size(184, 32);
            editBook_publicationYear_txt.TabIndex = 20;
            editBook_publicationYear_txt.TextAlign = HorizontalAlignment.Center;
            // 
            // editBook_save_btn
            // 
            editBook_save_btn.BackColor = Color.FromArgb(80, 77, 180);
            editBook_save_btn.BackgroundColor = Color.FromArgb(80, 77, 180);
            editBook_save_btn.BorderColor = Color.Transparent;
            editBook_save_btn.BorderRadius = 5;
            editBook_save_btn.BorderSize = 0;
            editBook_save_btn.FlatAppearance.BorderSize = 0;
            editBook_save_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            editBook_save_btn.FlatStyle = FlatStyle.Flat;
            editBook_save_btn.Font = new Font("Yu Gothic UI Semibold", 14F);
            editBook_save_btn.ForeColor = Color.White;
            editBook_save_btn.Location = new Point(186, 312);
            editBook_save_btn.Name = "editBook_save_btn";
            editBook_save_btn.Size = new Size(80, 36);
            editBook_save_btn.TabIndex = 21;
            editBook_save_btn.TabStop = false;
            editBook_save_btn.Text = "Save";
            editBook_save_btn.TextColor = Color.White;
            editBook_save_btn.UseVisualStyleBackColor = false;
            editBook_save_btn.Click += SaveBook;
            // 
            // close_btn
            // 
            close_btn.BackColor = Color.Transparent;
            close_btn.BackgroundColor = Color.Transparent;
            close_btn.BorderColor = Color.Transparent;
            close_btn.BorderRadius = 0;
            close_btn.BorderSize = 0;
            close_btn.Cursor = Cursors.Hand;
            close_btn.FlatAppearance.BorderSize = 0;
            close_btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            close_btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            close_btn.FlatStyle = FlatStyle.Flat;
            close_btn.Font = new Font("Yu Gothic UI Semibold", 14F);
            close_btn.ForeColor = Color.White;
            close_btn.Image = (Image)resources.GetObject("close_btn.Image");
            close_btn.Location = new Point(315, 10);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(36, 35);
            close_btn.TabIndex = 25;
            close_btn.TabStop = false;
            close_btn.TextColor = Color.White;
            close_btn.UseVisualStyleBackColor = false;
            close_btn.Click += CloseWindow;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(editBook_lbl1);
            panel1.Controls.Add(close_btn);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(363, 55);
            panel1.TabIndex = 26;
            panel1.MouseDown += EditBook_MouseDown;
            panel1.MouseMove += EditBook_MouseMove;
            panel1.MouseUp += EditBook_MouseUp;
            // 
            // editBook_category_dwn
            // 
            editBook_category_dwn.BackColor = Color.WhiteSmoke;
            editBook_category_dwn.Font = new Font("Yu Gothic UI Semibold", 14F);
            editBook_category_dwn.FormattingEnabled = true;
            editBook_category_dwn.Location = new Point(109, 221);
            editBook_category_dwn.Name = "editBook_category_dwn";
            editBook_category_dwn.Size = new Size(242, 33);
            editBook_category_dwn.TabIndex = 27;
            // 
            // EditBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(363, 365);
            Controls.Add(editBook_category_dwn);
            Controls.Add(panel1);
            Controls.Add(editBook_save_btn);
            Controls.Add(editBook_publicationYear_txt);
            Controls.Add(editBook_isbn_txt);
            Controls.Add(editBook_lbl3);
            Controls.Add(editBook_lbl7);
            Controls.Add(editBook_lbl6);
            Controls.Add(editBook_author_txt);
            Controls.Add(editBook_lbl5);
            Controls.Add(editBook_publisher_txt);
            Controls.Add(editBook_lbl4);
            Controls.Add(editBook_title_txt);
            Controls.Add(editBook_lbl2);
            Controls.Add(editBook_cancel_btn);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EditBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditBooks";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label editBook_lbl1;
        private Label editBook_lbl2;
        private TextBox editBook_title_txt;
        private RoundedButton editBook_cancel_btn;
        private TextBox editBook_publisher_txt;
        private Label editBook_lbl4;
        private TextBox editBook_author_txt;
        private Label editBook_lbl5;
        private Label editBook_lbl6;
        private Label editBook_lbl7;
        private Label editBook_lbl3;
        private TextBox editBook_isbn_txt;
        private TextBox editBook_publicationYear_txt;
        private RoundedButton editBook_save_btn;
        private RoundedButton close_btn;
        private Panel panel1;
        private ComboBox editBook_category_dwn;
    }
}