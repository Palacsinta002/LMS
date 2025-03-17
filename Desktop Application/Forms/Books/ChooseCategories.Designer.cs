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
            close_btn = new Components.RoundedButton();
            allCategories_grd = new DataGridView();
            selectedCategories_grd = new DataGridView();
            rightArrow_btn = new Components.RoundedButton();
            leftArrow_btn = new Components.RoundedButton();
            save = new Components.RoundedButton();
            cancel = new Components.RoundedButton();
            allCategories_src = new System.Windows.Forms.TextBox();
            selectedCategories_src = new System.Windows.Forms.TextBox();
            allCategories_category = new DataGridViewTextBoxColumn();
            selectedCategories_category = new DataGridViewTextBoxColumn();
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
            header.Name = "header";
            header.Size = new Size(998, 55);
            header.TabIndex = 62;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Yu Gothic UI Semibold", 16F);
            title.Location = new Point(400, 10);
            title.Name = "title";
            title.Size = new Size(199, 30);
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
            close_btn.Location = new Point(952, 9);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(36, 35);
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
            allCategories_grd.Columns.AddRange(new DataGridViewColumn[] { allCategories_category });
            allCategories_grd.Location = new Point(12, 97);
            allCategories_grd.Name = "allCategories_grd";
            allCategories_grd.ReadOnly = true;
            allCategories_grd.RowHeadersVisible = false;
            allCategories_grd.RowHeadersWidth = 51;
            allCategories_grd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            allCategories_grd.ShowCellErrors = false;
            allCategories_grd.ShowCellToolTips = false;
            allCategories_grd.ShowEditingIcon = false;
            allCategories_grd.ShowRowErrors = false;
            allCategories_grd.Size = new Size(453, 437);
            allCategories_grd.TabIndex = 63;
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
            selectedCategories_grd.Columns.AddRange(new DataGridViewColumn[] { selectedCategories_category });
            selectedCategories_grd.Location = new Point(535, 97);
            selectedCategories_grd.Name = "selectedCategories_grd";
            selectedCategories_grd.ReadOnly = true;
            selectedCategories_grd.RowHeadersVisible = false;
            selectedCategories_grd.RowHeadersWidth = 51;
            selectedCategories_grd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            selectedCategories_grd.ShowCellErrors = false;
            selectedCategories_grd.ShowCellToolTips = false;
            selectedCategories_grd.ShowEditingIcon = false;
            selectedCategories_grd.ShowRowErrors = false;
            selectedCategories_grd.Size = new Size(453, 437);
            selectedCategories_grd.TabIndex = 64;
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
            leftArrow_btn.Location = new Point(478, 297);
            leftArrow_btn.Name = "leftArrow_btn";
            leftArrow_btn.Size = new Size(44, 38);
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
            save.Location = new Point(813, 554);
            save.Name = "save";
            save.Size = new Size(85, 36);
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
            cancel.Location = new Point(903, 554);
            cancel.Name = "cancel";
            cancel.Size = new Size(85, 36);
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
            allCategories_src.Location = new Point(258, 62);
            allCategories_src.MaxLength = 19;
            allCategories_src.Name = "allCategories_src";
            allCategories_src.PlaceholderText = "Search...";
            allCategories_src.Size = new Size(208, 32);
            allCategories_src.TabIndex = 85;
            allCategories_src.TabStop = false;
            allCategories_src.TextChanged += SearchAllCategories;
            // 
            // selectedCategories_src
            // 
            selectedCategories_src.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            selectedCategories_src.BackColor = Color.White;
            selectedCategories_src.Font = new Font("Yu Gothic UI Semibold", 14F);
            selectedCategories_src.Location = new Point(780, 62);
            selectedCategories_src.MaxLength = 19;
            selectedCategories_src.Name = "selectedCategories_src";
            selectedCategories_src.PlaceholderText = "Search...";
            selectedCategories_src.Size = new Size(208, 32);
            selectedCategories_src.TabIndex = 86;
            selectedCategories_src.TabStop = false;
            selectedCategories_src.TextChanged += SearchSelectedCategories;
            // 
            // allCategories_category
            // 
            allCategories_category.HeaderText = "Category";
            allCategories_category.Name = "allCategories_category";
            allCategories_category.ReadOnly = true;
            allCategories_category.Width = 80;
            // 
            // selectedCategories_category
            // 
            selectedCategories_category.HeaderText = "Category";
            selectedCategories_category.Name = "selectedCategories_category";
            selectedCategories_category.ReadOnly = true;
            selectedCategories_category.Width = 80;
            // 
            // ChooseCategories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 600);
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
        private DataGridViewTextBoxColumn allCategories_category;
        private DataGridViewTextBoxColumn selectedCategories_category;
    }
}