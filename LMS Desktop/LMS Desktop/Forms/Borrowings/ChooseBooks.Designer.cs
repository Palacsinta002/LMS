﻿using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Desktop_Application.Forms.Borrowings
{
    partial class ChooseBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseBooks));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            header = new Panel();
            title = new Label();
            close_btn = new Desktop_Application.Components.RoundedButton();
            allBooks_grd = new DataGridView();
            allBooks_title = new DataGridViewTextBoxColumn();
            allBooks_author = new DataGridViewTextBoxColumn();
            allBooks_pubYear = new DataGridViewTextBoxColumn();
            allBooks_isbn = new DataGridViewTextBoxColumn();
            selectedBooks_grd = new DataGridView();
            selectedBooks_title = new DataGridViewTextBoxColumn();
            selectedBooks_author = new DataGridViewTextBoxColumn();
            selectedBooks_pubYear = new DataGridViewTextBoxColumn();
            selectedBooks_isbn = new DataGridViewTextBoxColumn();
            rightArrow_btn = new Desktop_Application.Components.RoundedButton();
            leftArrow_btn = new Desktop_Application.Components.RoundedButton();
            save = new Desktop_Application.Components.RoundedButton();
            cancel = new Desktop_Application.Components.RoundedButton();
            allBooks_src = new System.Windows.Forms.TextBox();
            selectedBooks_src = new System.Windows.Forms.TextBox();
            header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)allBooks_grd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)selectedBooks_grd).BeginInit();
            SuspendLayout();
            // 
            // header
            // 
            header.BackColor = Color.White;
            header.Controls.Add(title);
            header.Controls.Add(close_btn);
            header.Location = new Point(1, 1);
            header.Name = "header";
            header.Size = new Size(998, 55);
            header.TabIndex = 62;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Yu Gothic UI Semibold", 16F);
            title.Location = new Point(422, 10);
            title.Name = "title";
            title.Size = new Size(153, 30);
            title.TabIndex = 2;
            title.Text = "Choose Books";
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
            close_btn.Location = new Point(952, 9);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(36, 35);
            close_btn.TabIndex = 25;
            close_btn.TabStop = false;
            close_btn.TextColor = Color.White;
            close_btn.UseVisualStyleBackColor = false;
            // 
            // allBooks_grd
            // 
            allBooks_grd.AllowUserToAddRows = false;
            allBooks_grd.AllowUserToDeleteRows = false;
            allBooks_grd.AllowUserToResizeColumns = false;
            allBooks_grd.AllowUserToResizeRows = false;
            allBooks_grd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            allBooks_grd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            allBooks_grd.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            allBooks_grd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            allBooks_grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            allBooks_grd.Columns.AddRange(new DataGridViewColumn[] { allBooks_title, allBooks_author, allBooks_pubYear, allBooks_isbn });
            allBooks_grd.EnableHeadersVisualStyles = false;
            allBooks_grd.Location = new Point(12, 97);
            allBooks_grd.Name = "allBooks_grd";
            allBooks_grd.ReadOnly = true;
            allBooks_grd.RowHeadersVisible = false;
            allBooks_grd.RowHeadersWidth = 51;
            allBooks_grd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            allBooks_grd.ShowCellErrors = false;
            allBooks_grd.ShowCellToolTips = false;
            allBooks_grd.ShowEditingIcon = false;
            allBooks_grd.ShowRowErrors = false;
            allBooks_grd.Size = new Size(453, 437);
            allBooks_grd.StandardTab = true;
            allBooks_grd.TabIndex = 1;
            allBooks_grd.Enter += EnterGrid;
            // 
            // allBooks_title
            // 
            allBooks_title.HeaderText = "Title";
            allBooks_title.MinimumWidth = 6;
            allBooks_title.Name = "allBooks_title";
            allBooks_title.ReadOnly = true;
            allBooks_title.Width = 54;
            // 
            // allBooks_author
            // 
            allBooks_author.HeaderText = "Author";
            allBooks_author.MinimumWidth = 6;
            allBooks_author.Name = "allBooks_author";
            allBooks_author.ReadOnly = true;
            allBooks_author.Width = 69;
            // 
            // allBooks_pubYear
            // 
            allBooks_pubYear.HeaderText = "Publication Year";
            allBooks_pubYear.MinimumWidth = 6;
            allBooks_pubYear.Name = "allBooks_pubYear";
            allBooks_pubYear.ReadOnly = true;
            allBooks_pubYear.Width = 107;
            // 
            // allBooks_isbn
            // 
            allBooks_isbn.HeaderText = "ISBN";
            allBooks_isbn.MinimumWidth = 6;
            allBooks_isbn.Name = "allBooks_isbn";
            allBooks_isbn.ReadOnly = true;
            allBooks_isbn.Width = 57;
            // 
            // selectedBooks_grd
            // 
            selectedBooks_grd.AllowUserToAddRows = false;
            selectedBooks_grd.AllowUserToDeleteRows = false;
            selectedBooks_grd.AllowUserToResizeColumns = false;
            selectedBooks_grd.AllowUserToResizeRows = false;
            selectedBooks_grd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            selectedBooks_grd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            selectedBooks_grd.BackgroundColor = Color.White;
            selectedBooks_grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            selectedBooks_grd.Columns.AddRange(new DataGridViewColumn[] { selectedBooks_title, selectedBooks_author, selectedBooks_pubYear, selectedBooks_isbn });
            selectedBooks_grd.EnableHeadersVisualStyles = false;
            selectedBooks_grd.Location = new Point(535, 97);
            selectedBooks_grd.Name = "selectedBooks_grd";
            selectedBooks_grd.ReadOnly = true;
            selectedBooks_grd.RowHeadersVisible = false;
            selectedBooks_grd.RowHeadersWidth = 51;
            selectedBooks_grd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            selectedBooks_grd.ShowCellErrors = false;
            selectedBooks_grd.ShowCellToolTips = false;
            selectedBooks_grd.ShowEditingIcon = false;
            selectedBooks_grd.ShowRowErrors = false;
            selectedBooks_grd.Size = new Size(453, 437);
            selectedBooks_grd.StandardTab = true;
            selectedBooks_grd.TabIndex = 2;
            selectedBooks_grd.Enter += EnterGrid;
            // 
            // selectedBooks_title
            // 
            selectedBooks_title.HeaderText = "Title";
            selectedBooks_title.MinimumWidth = 6;
            selectedBooks_title.Name = "selectedBooks_title";
            selectedBooks_title.ReadOnly = true;
            selectedBooks_title.Width = 54;
            // 
            // selectedBooks_author
            // 
            selectedBooks_author.HeaderText = "Author";
            selectedBooks_author.MinimumWidth = 6;
            selectedBooks_author.Name = "selectedBooks_author";
            selectedBooks_author.ReadOnly = true;
            selectedBooks_author.Width = 69;
            // 
            // selectedBooks_pubYear
            // 
            selectedBooks_pubYear.HeaderText = "Publication Year";
            selectedBooks_pubYear.MinimumWidth = 6;
            selectedBooks_pubYear.Name = "selectedBooks_pubYear";
            selectedBooks_pubYear.ReadOnly = true;
            selectedBooks_pubYear.Width = 107;
            // 
            // selectedBooks_isbn
            // 
            selectedBooks_isbn.HeaderText = "ISBN";
            selectedBooks_isbn.MinimumWidth = 6;
            selectedBooks_isbn.Name = "selectedBooks_isbn";
            selectedBooks_isbn.ReadOnly = true;
            selectedBooks_isbn.Width = 57;
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
            rightArrow_btn.Location = new Point(478, 251);
            rightArrow_btn.Name = "rightArrow_btn";
            rightArrow_btn.Size = new Size(44, 38);
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
            leftArrow_btn.Location = new Point(478, 297);
            leftArrow_btn.Name = "leftArrow_btn";
            leftArrow_btn.Size = new Size(44, 38);
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
            save.Location = new Point(813, 554);
            save.Name = "save";
            save.Size = new Size(85, 36);
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
            cancel.Location = new Point(903, 554);
            cancel.Name = "cancel";
            cancel.Size = new Size(85, 36);
            cancel.TabIndex = 84;
            cancel.TabStop = false;
            cancel.Text = "Cancel";
            cancel.TextColor = Color.Black;
            cancel.UseVisualStyleBackColor = false;
            // 
            // allBooks_src
            // 
            allBooks_src.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            allBooks_src.BackColor = Color.White;
            allBooks_src.Font = new Font("Yu Gothic UI Semibold", 14F);
            allBooks_src.Location = new Point(258, 62);
            allBooks_src.MaxLength = 19;
            allBooks_src.Name = "allBooks_src";
            allBooks_src.PlaceholderText = "Search...";
            allBooks_src.Size = new Size(208, 32);
            allBooks_src.TabIndex = 5;
            allBooks_src.TabStop = false;
            allBooks_src.TextChanged += SearchAllBooks;
            // 
            // selectedBooks_src
            // 
            selectedBooks_src.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            selectedBooks_src.BackColor = Color.White;
            selectedBooks_src.Font = new Font("Yu Gothic UI Semibold", 14F);
            selectedBooks_src.Location = new Point(780, 62);
            selectedBooks_src.MaxLength = 19;
            selectedBooks_src.Name = "selectedBooks_src";
            selectedBooks_src.PlaceholderText = "Search...";
            selectedBooks_src.Size = new Size(208, 32);
            selectedBooks_src.TabIndex = 6;
            selectedBooks_src.TabStop = false;
            selectedBooks_src.TextChanged += SearchSelectedBooks;
            // 
            // ChooseBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 600);
            Controls.Add(selectedBooks_src);
            Controls.Add(allBooks_src);
            Controls.Add(save);
            Controls.Add(cancel);
            Controls.Add(leftArrow_btn);
            Controls.Add(rightArrow_btn);
            Controls.Add(selectedBooks_grd);
            Controls.Add(allBooks_grd);
            Controls.Add(header);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "ChooseBooks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChooseBooks";
            Load += OnLoad;
            header.ResumeLayout(false);
            header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)allBooks_grd).EndInit();
            ((System.ComponentModel.ISupportInitialize)selectedBooks_grd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel header;
        private Label title;
        private Components.RoundedButton close_btn;
        private DataGridView allBooks_grd;
        private DataGridView selectedBooks_grd;
        private Components.RoundedButton rightArrow_btn;
        private Components.RoundedButton leftArrow_btn;
        private DataGridViewTextBoxColumn allBooks_title;
        private DataGridViewTextBoxColumn allBooks_author;
        private DataGridViewTextBoxColumn allBooks_pubYear;
        private DataGridViewTextBoxColumn allBooks_isbn;
        private DataGridViewTextBoxColumn selectedBooks_title;
        private DataGridViewTextBoxColumn selectedBooks_author;
        private DataGridViewTextBoxColumn selectedBooks_pubYear;
        private DataGridViewTextBoxColumn selectedBooks_isbn;
        private Components.RoundedButton save;
        private Components.RoundedButton cancel;
        private System.Windows.Forms.TextBox allBooks_src;
        private System.Windows.Forms.TextBox selectedBooks_src;
    }
}