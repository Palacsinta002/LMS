using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            header = new Panel();
            title = new Label();
            close_btn = new Components.RoundedButton();
            borrowings_grd = new DataGridView();
            borrowingsUsername = new DataGridViewTextBoxColumn();
            borrowingsTitle = new DataGridViewTextBoxColumn();
            borrowingsIsbn = new DataGridViewTextBoxColumn();
            borrowDate = new DataGridViewTextBoxColumn();
            returnDate = new DataGridViewTextBoxColumn();
            dueDate = new DataGridViewTextBoxColumn();
            header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)borrowings_grd).BeginInit();
            SuspendLayout();
            // 
            // header
            // 
            header.BackColor = Color.White;
            header.Controls.Add(title);
            header.Controls.Add(close_btn);
            header.Location = new Point(1, 1);
            header.Name = "header";
            header.Size = new Size(979, 55);
            header.TabIndex = 62;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Yu Gothic UI Semibold", 16F);
            title.Location = new Point(410, 10);
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
            close_btn.Location = new Point(933, 9);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(36, 35);
            close_btn.TabIndex = 25;
            close_btn.TabStop = false;
            close_btn.TextColor = Color.White;
            close_btn.UseVisualStyleBackColor = false;
            // 
            // borrowings_grd
            // 
            borrowings_grd.AllowUserToAddRows = false;
            borrowings_grd.AllowUserToDeleteRows = false;
            borrowings_grd.AllowUserToResizeColumns = false;
            borrowings_grd.AllowUserToResizeRows = false;
            borrowings_grd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            borrowings_grd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            borrowings_grd.BackgroundColor = Color.White;
            borrowings_grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            borrowings_grd.Columns.AddRange(new DataGridViewColumn[] { borrowingsUsername, borrowingsTitle, borrowingsIsbn, borrowDate, returnDate, dueDate });
            borrowings_grd.Location = new Point(126, 116);
            borrowings_grd.Name = "borrowings_grd";
            borrowings_grd.ReadOnly = true;
            borrowings_grd.RowHeadersVisible = false;
            borrowings_grd.RowHeadersWidth = 51;
            borrowings_grd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            borrowings_grd.ShowCellErrors = false;
            borrowings_grd.ShowCellToolTips = false;
            borrowings_grd.ShowEditingIcon = false;
            borrowings_grd.ShowRowErrors = false;
            borrowings_grd.Size = new Size(604, 359);
            borrowings_grd.TabIndex = 63;
            // 
            // borrowingsUsername
            // 
            borrowingsUsername.HeaderText = "Username";
            borrowingsUsername.Name = "borrowingsUsername";
            borrowingsUsername.ReadOnly = true;
            borrowingsUsername.Width = 85;
            // 
            // borrowingsTitle
            // 
            borrowingsTitle.HeaderText = "Title";
            borrowingsTitle.Name = "borrowingsTitle";
            borrowingsTitle.ReadOnly = true;
            borrowingsTitle.Width = 54;
            // 
            // borrowingsIsbn
            // 
            borrowingsIsbn.HeaderText = "ISBN";
            borrowingsIsbn.Name = "borrowingsIsbn";
            borrowingsIsbn.ReadOnly = true;
            borrowingsIsbn.Width = 57;
            // 
            // borrowDate
            // 
            borrowDate.HeaderText = "Borrow Date";
            borrowDate.Name = "borrowDate";
            borrowDate.ReadOnly = true;
            borrowDate.Width = 97;
            // 
            // returnDate
            // 
            returnDate.HeaderText = "Return Date";
            returnDate.Name = "returnDate";
            returnDate.ReadOnly = true;
            returnDate.Width = 94;
            // 
            // dueDate
            // 
            dueDate.HeaderText = "Due Date";
            dueDate.Name = "dueDate";
            dueDate.ReadOnly = true;
            dueDate.Width = 80;
            // 
            // ChooseBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(981, 554);
            Controls.Add(borrowings_grd);
            Controls.Add(header);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChooseBooks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChooseBooks";
            header.ResumeLayout(false);
            header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)borrowings_grd).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel header;
        private Label title;
        private Components.RoundedButton close_btn;
        private DataGridView borrowings_grd;
        private DataGridViewTextBoxColumn borrowingsUsername;
        private DataGridViewTextBoxColumn borrowingsTitle;
        private DataGridViewTextBoxColumn borrowingsIsbn;
        private DataGridViewTextBoxColumn borrowDate;
        private DataGridViewTextBoxColumn returnDate;
        private DataGridViewTextBoxColumn dueDate;
    }
}