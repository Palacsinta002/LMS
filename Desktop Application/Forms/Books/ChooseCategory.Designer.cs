using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Desktop_Application.Forms.Books
{
    partial class ChooseCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseCategory));
            title = new Label();
            header = new Panel();
            close_btn = new Desktop_Application.Components.RoundedButton();
            chooseCategory_grd = new DataGridView();
            Category = new DataGridViewTextBoxColumn();
            save = new Desktop_Application.Components.RoundedButton();
            cancel = new Desktop_Application.Components.RoundedButton();
            header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chooseCategory_grd).BeginInit();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Yu Gothic UI Semibold", 16F);
            title.Location = new Point(13, 17);
            title.Name = "title";
            title.Size = new Size(226, 37);
            title.TabIndex = 2;
            title.Text = "Choose Category";
            // 
            // header
            // 
            header.BackColor = Color.White;
            header.Controls.Add(title);
            header.Controls.Add(close_btn);
            header.Location = new Point(1, 1);
            header.Margin = new Padding(3, 4, 3, 4);
            header.Name = "header";
            header.Size = new Size(282, 73);
            header.TabIndex = 64;
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
            close_btn.Location = new Point(229, 11);
            close_btn.Margin = new Padding(3, 4, 3, 4);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(41, 47);
            close_btn.TabIndex = 25;
            close_btn.TabStop = false;
            close_btn.TextColor = Color.White;
            close_btn.UseVisualStyleBackColor = false;
            // 
            // chooseCategory_grd
            // 
            chooseCategory_grd.AllowUserToAddRows = false;
            chooseCategory_grd.AllowUserToDeleteRows = false;
            chooseCategory_grd.AllowUserToResizeColumns = false;
            chooseCategory_grd.AllowUserToResizeRows = false;
            chooseCategory_grd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            chooseCategory_grd.BackgroundColor = Color.White;
            chooseCategory_grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            chooseCategory_grd.Columns.AddRange(new DataGridViewColumn[] { Category });
            chooseCategory_grd.Location = new Point(14, 83);
            chooseCategory_grd.Margin = new Padding(3, 4, 3, 4);
            chooseCategory_grd.Name = "chooseCategory_grd";
            chooseCategory_grd.ReadOnly = true;
            chooseCategory_grd.RowHeadersVisible = false;
            chooseCategory_grd.RowHeadersWidth = 51;
            chooseCategory_grd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            chooseCategory_grd.ShowCellErrors = false;
            chooseCategory_grd.ShowCellToolTips = false;
            chooseCategory_grd.ShowEditingIcon = false;
            chooseCategory_grd.ShowRowErrors = false;
            chooseCategory_grd.Size = new Size(257, 413);
            chooseCategory_grd.TabIndex = 61;
            // 
            // Category
            // 
            Category.HeaderText = "Category";
            Category.MinimumWidth = 6;
            Category.Name = "Category";
            Category.ReadOnly = true;
            Category.Width = 98;
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
            save.Location = new Point(71, 519);
            save.Margin = new Padding(3, 4, 3, 4);
            save.Name = "save";
            save.Size = new Size(97, 48);
            save.TabIndex = 79;
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
            cancel.Location = new Point(174, 519);
            cancel.Margin = new Padding(3, 4, 3, 4);
            cancel.Name = "cancel";
            cancel.Size = new Size(97, 48);
            cancel.TabIndex = 80;
            cancel.Text = "Cancel";
            cancel.TextColor = Color.Black;
            cancel.UseVisualStyleBackColor = false;
            // 
            // ChooseCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(286, 580);
            Controls.Add(save);
            Controls.Add(cancel);
            Controls.Add(header);
            Controls.Add(chooseCategory_grd);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ChooseCategory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChooseCategory";
            Load += OnLoad;
            header.ResumeLayout(false);
            header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chooseCategory_grd).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label title;
        private Panel header;
        private Components.RoundedButton close_btn;
        private DataGridView chooseCategory_grd;
        private DataGridViewTextBoxColumn Category;
        private Components.RoundedButton save;
        private Components.RoundedButton cancel;
    }
}