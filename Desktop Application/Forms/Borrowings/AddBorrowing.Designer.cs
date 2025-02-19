using Desktop_Application.Forms.Books;
using Desktop_Application.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Desktop_Application.Forms.Borrowings
{
    partial class AddBorrowing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBorrowing));
            header = new Panel();
            title = new Label();
            close_btn = new Components.RoundedButton();
            save = new Components.RoundedButton();
            label2 = new Label();
            cancel = new Components.RoundedButton();
            label3 = new Label();
            borrowDate_datePicker = new DateTimePicker();
            dueDate_datePicker = new DateTimePicker();
            label5 = new Label();
            dropDown_user = new System.Windows.Forms.ComboBox();
            label_publisher = new Label();
            chooseBooks = new System.Windows.Forms.Button();
            textBox_books = new System.Windows.Forms.TextBox();
            header.SuspendLayout();
            SuspendLayout();
            // 
            // header
            // 
            header.BackColor = Color.White;
            header.Controls.Add(title);
            header.Controls.Add(close_btn);
            header.Location = new Point(1, 1);
            header.Name = "header";
            header.Size = new Size(383, 55);
            header.TabIndex = 61;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Yu Gothic UI Semibold", 16F);
            title.Location = new Point(107, 11);
            title.Name = "title";
            title.Size = new Size(164, 30);
            title.TabIndex = 2;
            title.Text = "Add Borrowing";
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
            close_btn.Location = new Point(336, 10);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(36, 35);
            close_btn.TabIndex = 25;
            close_btn.TabStop = false;
            close_btn.TextColor = Color.White;
            close_btn.UseVisualStyleBackColor = false;
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
            save.Location = new Point(110, 232);
            save.Name = "save";
            save.Size = new Size(80, 36);
            save.TabIndex = 6;
            save.TabStop = false;
            save.Text = "Save";
            save.TextColor = Color.White;
            save.UseVisualStyleBackColor = false;
            save.Click += Save;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI Semibold", 14F);
            label2.Location = new Point(12, 111);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 59;
            label2.Text = "Books";
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
            cancel.Location = new Point(196, 232);
            cancel.Name = "cancel";
            cancel.Size = new Size(80, 36);
            cancel.TabIndex = 7;
            cancel.Text = "Cancel";
            cancel.TextColor = Color.Black;
            cancel.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI Semibold", 14F);
            label3.Location = new Point(12, 149);
            label3.Name = "label3";
            label3.Size = new Size(119, 25);
            label3.TabIndex = 64;
            label3.Text = "Borrow Date";
            // 
            // borrowDate_datePicker
            // 
            borrowDate_datePicker.CalendarFont = new Font("Yu Gothic UI Semibold", 14F);
            borrowDate_datePicker.Font = new Font("Yu Gothic UI Semibold", 14F);
            borrowDate_datePicker.Format = DateTimePickerFormat.Short;
            borrowDate_datePicker.Location = new Point(137, 146);
            borrowDate_datePicker.Name = "borrowDate_datePicker";
            borrowDate_datePicker.Size = new Size(135, 32);
            borrowDate_datePicker.TabIndex = 3;
            // 
            // dueDate_datePicker
            // 
            dueDate_datePicker.CalendarFont = new Font("Yu Gothic UI Semibold", 14F);
            dueDate_datePicker.Font = new Font("Yu Gothic UI Semibold", 14F);
            dueDate_datePicker.Format = DateTimePickerFormat.Short;
            dueDate_datePicker.Location = new Point(137, 184);
            dueDate_datePicker.Name = "dueDate_datePicker";
            dueDate_datePicker.Size = new Size(135, 32);
            dueDate_datePicker.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI Semibold", 14F);
            label5.Location = new Point(12, 187);
            label5.Name = "label5";
            label5.Size = new Size(93, 25);
            label5.TabIndex = 68;
            label5.Text = "Due Date";
            // 
            // dropDown_user
            // 
            dropDown_user.BackColor = Color.WhiteSmoke;
            dropDown_user.DropDownStyle = ComboBoxStyle.DropDownList;
            dropDown_user.Font = new Font("Yu Gothic UI Semibold", 14F);
            dropDown_user.FormattingEnabled = true;
            dropDown_user.Location = new Point(81, 69);
            dropDown_user.MaxDropDownItems = 10;
            dropDown_user.Name = "dropDown_user";
            dropDown_user.Size = new Size(287, 33);
            dropDown_user.TabIndex = 1;
            // 
            // label_publisher
            // 
            label_publisher.AutoSize = true;
            label_publisher.Font = new Font("Yu Gothic UI Semibold", 14F);
            label_publisher.Location = new Point(12, 72);
            label_publisher.Name = "label_publisher";
            label_publisher.Size = new Size(50, 25);
            label_publisher.TabIndex = 71;
            label_publisher.Text = "User";
            // 
            // chooseBooks
            // 
            chooseBooks.Location = new Point(331, 108);
            chooseBooks.Name = "chooseBooks";
            chooseBooks.Size = new Size(37, 32);
            chooseBooks.TabIndex = 72;
            chooseBooks.Text = "...";
            chooseBooks.UseVisualStyleBackColor = true;
            chooseBooks.Click += ChooseBooks;
            // 
            // textBox_books
            // 
            textBox_books.BackColor = Color.WhiteSmoke;
            textBox_books.Enabled = false;
            textBox_books.Font = new Font("Yu Gothic UI Semibold", 14F);
            textBox_books.Location = new Point(81, 108);
            textBox_books.Name = "textBox_books";
            textBox_books.Size = new Size(244, 32);
            textBox_books.TabIndex = 73;
            // 
            // AddBorrowing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(385, 283);
            Controls.Add(chooseBooks);
            Controls.Add(textBox_books);
            Controls.Add(dropDown_user);
            Controls.Add(label_publisher);
            Controls.Add(dueDate_datePicker);
            Controls.Add(label5);
            Controls.Add(borrowDate_datePicker);
            Controls.Add(label3);
            Controls.Add(header);
            Controls.Add(save);
            Controls.Add(label2);
            Controls.Add(cancel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddBorrowing";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddBorrowing";
            Load += OnLoad;
            header.ResumeLayout(false);
            header.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button chooseCategory;
        private System.Windows.Forms.TextBox textBox_category;
        private System.Windows.Forms.ComboBox dropDown_user;
        private Panel header;
        private Label title;
        private Components.RoundedButton close_btn;
        private Components.RoundedButton save;
        private System.Windows.Forms.TextBox textBox_pubYear;
        private Label label_pubYear;
        private Label label2;
        private Label label_category;
        private Label label_publisher;
        private System.Windows.Forms.TextBox textBox_title;
        private Components.RoundedButton cancel;
        private Label label_title;
        private Label label3;
        private DateTimePicker borrowDate_datePicker;
        private DateTimePicker dueDate_datePicker;
        private Label label5;
        private System.Windows.Forms.Button chooseBooks;
        private System.Windows.Forms.TextBox textBox_books;
    }
}