using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Desktop_Application.Forms.Books
{
    partial class ChooseCategories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseCategories));
            header = new Panel();
            title = new Label();
            close_btn = new Desktop_Application.Components.RoundedButton();
            allCategories_grd = new DataGridView();
            allAuthors_author = new DataGridViewTextBoxColumn();
            allAuthors_books = new DataGridViewTextBoxColumn();
            selectedCategories_grd = new DataGridView();
            selectedAuthors_Author = new DataGridViewTextBoxColumn();
            selectedAuthors_books = new DataGridViewTextBoxColumn();
            rightArrow_btn = new Desktop_Application.Components.RoundedButton();
            leftArrow_btn = new Desktop_Application.Components.RoundedButton();
            save = new Desktop_Application.Components.RoundedButton();
            cancel = new Desktop_Application.Components.RoundedButton();
            allCategories_src = new System.Windows.Forms.TextBox();
            selectedCategories_src = new System.Windows.Forms.TextBox();
            header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)allCategories_grd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)selectedCategories_grd).BeginInit();
            SuspendLayout();
            // 
            // header
            // 
            header.BackColor = Color.White;
            header.Controls.Add(title);
            header.Controls.Add(close_btn);
            header.Location = new Point(1, 1);
            header.Margin = new Padding(3, 4, 3, 4);
            header.Name = "header";
            header.Size = new Size(1141, 73);
            header.TabIndex = 62;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Yu Gothic UI Semibold", 16F);
            title.Location = new Point(457, 13);
            title.Name = "title";
            title.Size = new Size(245, 37);
            title.TabIndex = 2;
            title.Text = "Choose Categories";
            // 
            // close_btn
            // 
            close_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
            close_btn.Location = new Point(1088, 12);
            close_btn.Margin = new Padding(3, 4, 3, 4);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(41, 47);
            close_btn.TabIndex = 25;
            close_btn.TabStop = false;
            close_btn.TextColor = Color.White;
            close_btn.UseVisualStyleBackColor = false;
            // 
            // allCategories_grd
            // 
            allCategories_grd.AllowUserToAddRows = false;
            allCategories_grd.AllowUserToDeleteRows = false;
            allCategories_grd.AllowUserToResizeColumns = false;
            allCategories_grd.AllowUserToResizeRows = false;
            allCategories_grd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            allCategories_grd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            allCategories_grd.BackgroundColor = Color.White;
            allCategories_grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            allCategories_grd.Columns.AddRange(new DataGridViewColumn[] { allAuthors_author, allAuthors_books });
            allCategories_grd.Location = new Point(14, 129);
            allCategories_grd.Margin = new Padding(3, 4, 3, 4);
            allCategories_grd.Name = "allCategories_grd";
            allCategories_grd.ReadOnly = true;
            allCategories_grd.RowHeadersVisible = false;
            allCategories_grd.RowHeadersWidth = 51;
            allCategories_grd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            allCategories_grd.ShowCellErrors = false;
            allCategories_grd.ShowCellToolTips = false;
            allCategories_grd.ShowEditingIcon = false;
            allCategories_grd.ShowRowErrors = false;
            allCategories_grd.Size = new Size(518, 583);
            allCategories_grd.TabIndex = 63;
            // 
            // allAuthors_author
            // 
            allAuthors_author.HeaderText = "Author";
            allAuthors_author.MinimumWidth = 6;
            allAuthors_author.Name = "allAuthors_author";
            allAuthors_author.ReadOnly = true;
            allAuthors_author.Width = 83;
            // 
            // allAuthors_books
            // 
            allAuthors_books.HeaderText = "Book(s)";
            allAuthors_books.MinimumWidth = 6;
            allAuthors_books.Name = "allAuthors_books";
            allAuthors_books.ReadOnly = true;
            allAuthors_books.Width = 88;
            // 
            // selectedCategories_grd
            // 
            selectedCategories_grd.AllowUserToAddRows = false;
            selectedCategories_grd.AllowUserToDeleteRows = false;
            selectedCategories_grd.AllowUserToResizeColumns = false;
            selectedCategories_grd.AllowUserToResizeRows = false;
            selectedCategories_grd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            selectedCategories_grd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            selectedCategories_grd.BackgroundColor = Color.White;
            selectedCategories_grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            selectedCategories_grd.Columns.AddRange(new DataGridViewColumn[] { selectedAuthors_Author, selectedAuthors_books });
            selectedCategories_grd.Location = new Point(611, 129);
            selectedCategories_grd.Margin = new Padding(3, 4, 3, 4);
            selectedCategories_grd.Name = "selectedCategories_grd";
            selectedCategories_grd.ReadOnly = true;
            selectedCategories_grd.RowHeadersVisible = false;
            selectedCategories_grd.RowHeadersWidth = 51;
            selectedCategories_grd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            selectedCategories_grd.ShowCellErrors = false;
            selectedCategories_grd.ShowCellToolTips = false;
            selectedCategories_grd.ShowEditingIcon = false;
            selectedCategories_grd.ShowRowErrors = false;
            selectedCategories_grd.Size = new Size(518, 583);
            selectedCategories_grd.TabIndex = 64;
            // 
            // selectedAuthors_Author
            // 
            selectedAuthors_Author.HeaderText = "Author";
            selectedAuthors_Author.MinimumWidth = 6;
            selectedAuthors_Author.Name = "selectedAuthors_Author";
            selectedAuthors_Author.ReadOnly = true;
            selectedAuthors_Author.Width = 83;
            // 
            // selectedAuthors_books
            // 
            selectedAuthors_books.HeaderText = "Book(s)";
            selectedAuthors_books.MinimumWidth = 6;
            selectedAuthors_books.Name = "selectedAuthors_books";
            selectedAuthors_books.ReadOnly = true;
            selectedAuthors_books.Width = 88;
            // 
            // rightArrow_btn
            // 
            rightArrow_btn.BackColor = Color.WhiteSmoke;
            rightArrow_btn.BackgroundColor = Color.WhiteSmoke;
            rightArrow_btn.BorderColor = Color.FromArgb(80, 77, 180);
            rightArrow_btn.BorderRadius = 5;
            rightArrow_btn.BorderSize = 2;
            rightArrow_btn.FlatAppearance.BorderSize = 0;
            rightArrow_btn.FlatStyle = FlatStyle.Flat;
            rightArrow_btn.Font = new Font("Yu Gothic UI Semibold", 14F);
            rightArrow_btn.ForeColor = Color.Black;
            rightArrow_btn.Image = (Image)resources.GetObject("rightArrow_btn.Image");
            rightArrow_btn.Location = new Point(546, 335);
            rightArrow_btn.Margin = new Padding(3, 4, 3, 4);
            rightArrow_btn.Name = "rightArrow_btn";
            rightArrow_btn.Size = new Size(50, 50);
            rightArrow_btn.TabIndex = 68;
            rightArrow_btn.TextColor = Color.Black;
            rightArrow_btn.UseVisualStyleBackColor = false;
            rightArrow_btn.Click += MoveRight;
            // 
            // leftArrow_btn
            // 
            leftArrow_btn.BackColor = Color.WhiteSmoke;
            leftArrow_btn.BackgroundColor = Color.WhiteSmoke;
            leftArrow_btn.BorderColor = Color.FromArgb(80, 77, 180);
            leftArrow_btn.BorderRadius = 5;
            leftArrow_btn.BorderSize = 2;
            leftArrow_btn.FlatAppearance.BorderSize = 0;
            leftArrow_btn.FlatStyle = FlatStyle.Flat;
            leftArrow_btn.Font = new Font("Yu Gothic UI Semibold", 14F);
            leftArrow_btn.ForeColor = Color.Black;
            leftArrow_btn.Image = (Image)resources.GetObject("leftArrow_btn.Image");
            leftArrow_btn.Location = new Point(546, 396);
            leftArrow_btn.Margin = new Padding(3, 4, 3, 4);
            leftArrow_btn.Name = "leftArrow_btn";
            leftArrow_btn.Size = new Size(50, 50);
            leftArrow_btn.TabIndex = 69;
            leftArrow_btn.TextColor = Color.Black;
            leftArrow_btn.UseVisualStyleBackColor = false;
            leftArrow_btn.Click += MoveLeft;
            // 
            // save
            // 
            save.BackColor = Color.FromArgb(80, 77, 180);
            save.BackgroundColor = Color.FromArgb(80, 77, 180);
            save.BorderColor = Color.Transparent;
            save.BorderRadius = 5;
            save.BorderSize = 0;
            save.FlatAppearance.BorderSize = 0;
            save.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            save.FlatStyle = FlatStyle.Flat;
            save.Font = new Font("Yu Gothic UI Semibold", 14F);
            save.ForeColor = Color.White;
            save.Location = new Point(929, 739);
            save.Margin = new Padding(3, 4, 3, 4);
            save.Name = "save";
            save.Size = new Size(97, 48);
            save.TabIndex = 83;
            save.TabStop = false;
            save.Text = "Ok";
            save.TextColor = Color.White;
            save.UseVisualStyleBackColor = false;
            save.Click += Ok;
            // 
            // cancel
            // 
            cancel.BackColor = Color.WhiteSmoke;
            cancel.BackgroundColor = Color.WhiteSmoke;
            cancel.BorderColor = Color.FromArgb(80, 77, 180);
            cancel.BorderRadius = 5;
            cancel.BorderSize = 2;
            cancel.FlatAppearance.BorderSize = 0;
            cancel.FlatStyle = FlatStyle.Flat;
            cancel.Font = new Font("Yu Gothic UI Semibold", 14F);
            cancel.ForeColor = Color.Black;
            cancel.Location = new Point(1032, 739);
            cancel.Margin = new Padding(3, 4, 3, 4);
            cancel.Name = "cancel";
            cancel.Size = new Size(97, 48);
            cancel.TabIndex = 84;
            cancel.Text = "Cancel";
            cancel.TextColor = Color.Black;
            cancel.UseVisualStyleBackColor = false;
            // 
            // allCategories_src
            // 
            allCategories_src.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            allCategories_src.BackColor = Color.White;
            allCategories_src.Font = new Font("Yu Gothic UI Semibold", 14F);
            allCategories_src.Location = new Point(295, 82);
            allCategories_src.Margin = new Padding(3, 4, 3, 4);
            allCategories_src.MaxLength = 19;
            allCategories_src.Name = "allCategories_src";
            allCategories_src.PlaceholderText = "Search...";
            allCategories_src.Size = new Size(237, 39);
            allCategories_src.TabIndex = 85;
            allCategories_src.TabStop = false;
            allCategories_src.TextChanged += SearchAllAuthors;
            // 
            // selectedCategories_src
            // 
            selectedCategories_src.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            selectedCategories_src.BackColor = Color.White;
            selectedCategories_src.Font = new Font("Yu Gothic UI Semibold", 14F);
            selectedCategories_src.Location = new Point(892, 82);
            selectedCategories_src.Margin = new Padding(3, 4, 3, 4);
            selectedCategories_src.MaxLength = 19;
            selectedCategories_src.Name = "selectedCategories_src";
            selectedCategories_src.PlaceholderText = "Search...";
            selectedCategories_src.Size = new Size(237, 39);
            selectedCategories_src.TabIndex = 86;
            selectedCategories_src.TabStop = false;
            selectedCategories_src.TextChanged += SearchSelectedAuthors;
            // 
            // ChooseCategories
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1143, 800);
            Controls.Add(selectedCategories_src);
            Controls.Add(allCategories_src);
            Controls.Add(save);
            Controls.Add(cancel);
            Controls.Add(leftArrow_btn);
            Controls.Add(rightArrow_btn);
            Controls.Add(selectedCategories_grd);
            Controls.Add(allCategories_grd);
            Controls.Add(header);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ChooseCategories";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChooseBooks";
            Load += OnLoad;
            header.ResumeLayout(false);
            header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)allCategories_grd).EndInit();
            ((System.ComponentModel.ISupportInitialize)selectedCategories_grd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel header;
        private Label title;
        private Components.RoundedButton close_btn;
        private DataGridView allCategories_grd;
        private DataGridView selectedCategories_grd;
        private Components.RoundedButton rightArrow_btn;
        private Components.RoundedButton leftArrow_btn;
        private Components.RoundedButton save;
        private Components.RoundedButton cancel;
        private System.Windows.Forms.TextBox allCategories_src;
        private System.Windows.Forms.TextBox selectedCategories_src;
        private DataGridViewTextBoxColumn allAuthors_author;
        private DataGridViewTextBoxColumn allAuthors_books;
        private DataGridViewTextBoxColumn selectedAuthors_Author;
        private DataGridViewTextBoxColumn selectedAuthors_books;
    }
}