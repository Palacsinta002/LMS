using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Desktop_Application.Forms.Books
{
    partial class ChooseAuthor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseAuthor));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            header = new Panel();
            title = new Label();
            close_btn = new Desktop_Application.Components.RoundedButton();
            allAuthors_grd = new DataGridView();
            allAuthors_author = new DataGridViewTextBoxColumn();
            allAuthors_books = new DataGridViewTextBoxColumn();
            selectedAuthors_grd = new DataGridView();
            selectedAuthors_Author = new DataGridViewTextBoxColumn();
            selectedAuthors_books = new DataGridViewTextBoxColumn();
            rightArrow_btn = new Desktop_Application.Components.RoundedButton();
            leftArrow_btn = new Desktop_Application.Components.RoundedButton();
            save = new Desktop_Application.Components.RoundedButton();
            cancel = new Desktop_Application.Components.RoundedButton();
            allAuthors_src = new System.Windows.Forms.TextBox();
            selectedAuthors_src = new System.Windows.Forms.TextBox();
            header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)allAuthors_grd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)selectedAuthors_grd).BeginInit();
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
            title.Location = new Point(471, 13);
            title.Name = "title";
            title.Size = new Size(213, 37);
            title.TabIndex = 2;
            title.Text = "Choose Authors";
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
            // allAuthors_grd
            // 
            allAuthors_grd.AllowUserToAddRows = false;
            allAuthors_grd.AllowUserToDeleteRows = false;
            allAuthors_grd.AllowUserToResizeColumns = false;
            allAuthors_grd.AllowUserToResizeRows = false;
            allAuthors_grd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            allAuthors_grd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            allAuthors_grd.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            allAuthors_grd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            allAuthors_grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            allAuthors_grd.Columns.AddRange(new DataGridViewColumn[] { allAuthors_author, allAuthors_books });
            allAuthors_grd.EnableHeadersVisualStyles = false;
            allAuthors_grd.Location = new Point(14, 129);
            allAuthors_grd.Margin = new Padding(3, 4, 3, 4);
            allAuthors_grd.Name = "allAuthors_grd";
            allAuthors_grd.ReadOnly = true;
            allAuthors_grd.RowHeadersVisible = false;
            allAuthors_grd.RowHeadersWidth = 51;
            allAuthors_grd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            allAuthors_grd.ShowCellErrors = false;
            allAuthors_grd.ShowCellToolTips = false;
            allAuthors_grd.ShowEditingIcon = false;
            allAuthors_grd.ShowRowErrors = false;
            allAuthors_grd.Size = new Size(518, 583);
            allAuthors_grd.StandardTab = true;
            allAuthors_grd.TabIndex = 1;
            allAuthors_grd.Enter += EnterGrid;
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
            // selectedAuthors_grd
            // 
            selectedAuthors_grd.AllowUserToAddRows = false;
            selectedAuthors_grd.AllowUserToDeleteRows = false;
            selectedAuthors_grd.AllowUserToResizeColumns = false;
            selectedAuthors_grd.AllowUserToResizeRows = false;
            selectedAuthors_grd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            selectedAuthors_grd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            selectedAuthors_grd.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            selectedAuthors_grd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            selectedAuthors_grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            selectedAuthors_grd.Columns.AddRange(new DataGridViewColumn[] { selectedAuthors_Author, selectedAuthors_books });
            selectedAuthors_grd.EnableHeadersVisualStyles = false;
            selectedAuthors_grd.Location = new Point(611, 129);
            selectedAuthors_grd.Margin = new Padding(3, 4, 3, 4);
            selectedAuthors_grd.Name = "selectedAuthors_grd";
            selectedAuthors_grd.ReadOnly = true;
            selectedAuthors_grd.RowHeadersVisible = false;
            selectedAuthors_grd.RowHeadersWidth = 51;
            selectedAuthors_grd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            selectedAuthors_grd.ShowCellErrors = false;
            selectedAuthors_grd.ShowCellToolTips = false;
            selectedAuthors_grd.ShowEditingIcon = false;
            selectedAuthors_grd.ShowRowErrors = false;
            selectedAuthors_grd.Size = new Size(518, 583);
            selectedAuthors_grd.StandardTab = true;
            selectedAuthors_grd.TabIndex = 2;
            selectedAuthors_grd.Enter += EnterGrid;
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
            rightArrow_btn.Size = new Size(50, 51);
            rightArrow_btn.TabIndex = 3;
            rightArrow_btn.TabStop = false;
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
            leftArrow_btn.Size = new Size(50, 51);
            leftArrow_btn.TabIndex = 4;
            leftArrow_btn.TabStop = false;
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
            save.Click += Save;
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
            cancel.TabStop = false;
            cancel.Text = "Cancel";
            cancel.TextColor = Color.Black;
            cancel.UseVisualStyleBackColor = false;
            // 
            // allAuthors_src
            // 
            allAuthors_src.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            allAuthors_src.BackColor = Color.White;
            allAuthors_src.Font = new Font("Yu Gothic UI Semibold", 14F);
            allAuthors_src.Location = new Point(295, 83);
            allAuthors_src.Margin = new Padding(3, 4, 3, 4);
            allAuthors_src.MaxLength = 19;
            allAuthors_src.Name = "allAuthors_src";
            allAuthors_src.PlaceholderText = "Search...";
            allAuthors_src.Size = new Size(237, 39);
            allAuthors_src.TabIndex = 5;
            allAuthors_src.TabStop = false;
            allAuthors_src.TextChanged += SearchAllAuthors;
            // 
            // selectedAuthors_src
            // 
            selectedAuthors_src.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            selectedAuthors_src.BackColor = Color.White;
            selectedAuthors_src.Font = new Font("Yu Gothic UI Semibold", 14F);
            selectedAuthors_src.Location = new Point(891, 83);
            selectedAuthors_src.Margin = new Padding(3, 4, 3, 4);
            selectedAuthors_src.MaxLength = 19;
            selectedAuthors_src.Name = "selectedAuthors_src";
            selectedAuthors_src.PlaceholderText = "Search...";
            selectedAuthors_src.Size = new Size(237, 39);
            selectedAuthors_src.TabIndex = 6;
            selectedAuthors_src.TabStop = false;
            selectedAuthors_src.TextChanged += SearchSelectedAuthors;
            // 
            // ChooseAuthor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1143, 800);
            Controls.Add(selectedAuthors_src);
            Controls.Add(allAuthors_src);
            Controls.Add(save);
            Controls.Add(cancel);
            Controls.Add(leftArrow_btn);
            Controls.Add(rightArrow_btn);
            Controls.Add(selectedAuthors_grd);
            Controls.Add(allAuthors_grd);
            Controls.Add(header);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ChooseAuthor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChooseBooks";
            Load += OnLoad;
            header.ResumeLayout(false);
            header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)allAuthors_grd).EndInit();
            ((System.ComponentModel.ISupportInitialize)selectedAuthors_grd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel header;
        private Label title;
        private Components.RoundedButton close_btn;
        private DataGridView allAuthors_grd;
        private DataGridView selectedAuthors_grd;
        private Components.RoundedButton rightArrow_btn;
        private Components.RoundedButton leftArrow_btn;
        private Components.RoundedButton save;
        private Components.RoundedButton cancel;
        private System.Windows.Forms.TextBox allAuthors_src;
        private System.Windows.Forms.TextBox selectedAuthors_src;
        private DataGridViewTextBoxColumn allAuthors_author;
        private DataGridViewTextBoxColumn allAuthors_books;
        private DataGridViewTextBoxColumn selectedAuthors_Author;
        private DataGridViewTextBoxColumn selectedAuthors_books;
    }
}