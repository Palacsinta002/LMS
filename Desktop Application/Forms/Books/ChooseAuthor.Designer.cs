using System.Security.Policy;
using Desktop_Application.Components;
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
            title = new Label();
            header = new Panel();
            close_btn = new RoundedButton();
            chooseAuthor_grd = new DataGridView();
            Author = new DataGridViewTextBoxColumn();
            Books = new DataGridViewTextBoxColumn();
            save = new RoundedButton();
            cancel = new RoundedButton();
            header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chooseAuthor_grd).BeginInit();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Yu Gothic UI Semibold", 16F);
            title.Location = new Point(178, 17);
            title.Name = "title";
            title.Size = new Size(201, 37);
            title.TabIndex = 2;
            title.Text = "Choose Author";
            // 
            // header
            // 
            header.BackColor = Color.White;
            header.Controls.Add(title);
            header.Controls.Add(close_btn);
            header.Location = new Point(1, 1);
            header.Margin = new Padding(3, 4, 3, 4);
            header.Name = "header";
            header.Size = new Size(542, 73);
            header.TabIndex = 60;
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
            close_btn.Location = new Point(488, 11);
            close_btn.Margin = new Padding(3, 4, 3, 4);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(41, 47);
            close_btn.TabIndex = 25;
            close_btn.TabStop = false;
            close_btn.TextColor = Color.White;
            close_btn.UseVisualStyleBackColor = false;
            // 
            // chooseAuthor_grd
            // 
            chooseAuthor_grd.AllowUserToAddRows = false;
            chooseAuthor_grd.AllowUserToDeleteRows = false;
            chooseAuthor_grd.AllowUserToResizeColumns = false;
            chooseAuthor_grd.AllowUserToResizeRows = false;
            chooseAuthor_grd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            chooseAuthor_grd.BackgroundColor = Color.White;
            chooseAuthor_grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            chooseAuthor_grd.Columns.AddRange(new DataGridViewColumn[] { Author, Books });
            chooseAuthor_grd.Location = new Point(14, 83);
            chooseAuthor_grd.Margin = new Padding(3, 4, 3, 4);
            chooseAuthor_grd.Name = "chooseAuthor_grd";
            chooseAuthor_grd.ReadOnly = true;
            chooseAuthor_grd.RowHeadersVisible = false;
            chooseAuthor_grd.RowHeadersWidth = 51;
            chooseAuthor_grd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            chooseAuthor_grd.ShowCellErrors = false;
            chooseAuthor_grd.ShowCellToolTips = false;
            chooseAuthor_grd.ShowEditingIcon = false;
            chooseAuthor_grd.ShowRowErrors = false;
            chooseAuthor_grd.Size = new Size(517, 413);
            chooseAuthor_grd.TabIndex = 0;
            // 
            // Author
            // 
            Author.HeaderText = "Author";
            Author.MinimumWidth = 6;
            Author.Name = "Author";
            Author.ReadOnly = true;
            Author.Width = 83;
            // 
            // Books
            // 
            Books.HeaderText = "Author's Books";
            Books.MinimumWidth = 6;
            Books.Name = "Books";
            Books.ReadOnly = true;
            Books.Width = 136;
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
            save.Location = new Point(170, 519);
            save.Margin = new Padding(3, 4, 3, 4);
            save.Name = "save";
            save.Size = new Size(97, 48);
            save.TabIndex = 81;
            save.TabStop = false;
            save.Text = "OK";
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
            cancel.Location = new Point(273, 519);
            cancel.Margin = new Padding(3, 4, 3, 4);
            cancel.Name = "cancel";
            cancel.Size = new Size(97, 48);
            cancel.TabIndex = 82;
            cancel.Text = "Cancel";
            cancel.TextColor = Color.Black;
            cancel.UseVisualStyleBackColor = false;
            // 
            // ChooseAuthor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(544, 580);
            Controls.Add(save);
            Controls.Add(cancel);
            Controls.Add(chooseAuthor_grd);
            Controls.Add(header);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ChooseAuthor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChhoseAuthor";
            Load += OnLoad;
            header.ResumeLayout(false);
            header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chooseAuthor_grd).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label title;
        private Panel header;
        private RoundedButton close_btn;
        private DataGridView chooseAuthor_grd;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewTextBoxColumn Books;
        private RoundedButton save;
        private RoundedButton cancel;
    }
}