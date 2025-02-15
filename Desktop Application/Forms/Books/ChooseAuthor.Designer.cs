using System.Security.Policy;
using Library_Management_System.Components;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library_Management_System.Forms.Books
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
            cancel = new RoundedButton();
            save = new RoundedButton();
            chooseAuthor_grd = new DataGridView();
            Author = new DataGridViewTextBoxColumn();
            Books = new DataGridViewTextBoxColumn();
            header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chooseAuthor_grd).BeginInit();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Yu Gothic UI Semibold", 16F);
            title.Location = new Point(156, 13);
            title.Name = "title";
            title.Size = new Size(163, 30);
            title.TabIndex = 2;
            title.Text = "Choose Author";
            // 
            // header
            // 
            header.BackColor = Color.White;
            header.Controls.Add(title);
            header.Controls.Add(close_btn);
            header.Location = new Point(1, 1);
            header.Name = "header";
            header.Size = new Size(474, 55);
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
            close_btn.Location = new Point(427, 8);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(36, 35);
            close_btn.TabIndex = 25;
            close_btn.TabStop = false;
            close_btn.TextColor = Color.White;
            close_btn.UseVisualStyleBackColor = false;
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
            cancel.Location = new Point(240, 387);
            cancel.Name = "cancel";
            cancel.Size = new Size(80, 36);
            cancel.TabIndex = 49;
            cancel.Text = "Cancel";
            cancel.TextColor = Color.Black;
            cancel.UseVisualStyleBackColor = false;
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
            save.Location = new Point(154, 387);
            save.Name = "save";
            save.Size = new Size(80, 36);
            save.TabIndex = 59;
            save.TabStop = false;
            save.Text = "OK";
            save.TextColor = Color.White;
            save.UseVisualStyleBackColor = false;
            save.Click += Ok;
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
            chooseAuthor_grd.Location = new Point(12, 62);
            chooseAuthor_grd.Name = "chooseAuthor_grd";
            chooseAuthor_grd.ReadOnly = true;
            chooseAuthor_grd.RowHeadersVisible = false;
            chooseAuthor_grd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            chooseAuthor_grd.ShowCellErrors = false;
            chooseAuthor_grd.ShowCellToolTips = false;
            chooseAuthor_grd.ShowEditingIcon = false;
            chooseAuthor_grd.ShowRowErrors = false;
            chooseAuthor_grd.Size = new Size(452, 310);
            chooseAuthor_grd.TabIndex = 0;
            // 
            // Author
            // 
            Author.HeaderText = "Author";
            Author.Name = "Author";
            Author.ReadOnly = true;
            Author.Width = 69;
            // 
            // Books
            // 
            Books.HeaderText = "Author's Books";
            Books.Name = "Books";
            Books.ReadOnly = true;
            Books.Width = 112;
            // 
            // ChooseAuthor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(476, 435);
            Controls.Add(chooseAuthor_grd);
            Controls.Add(header);
            Controls.Add(cancel);
            Controls.Add(save);
            FormBorderStyle = FormBorderStyle.None;
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
        private RoundedButton cancel;
        private RoundedButton save;
        private DataGridView chooseAuthor_grd;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewTextBoxColumn Books;
    }
}