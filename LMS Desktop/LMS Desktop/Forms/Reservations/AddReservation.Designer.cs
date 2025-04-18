﻿using Desktop_Application.Forms.Books;
using Desktop_Application.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Desktop_Application.Forms.Reservations
{
    partial class AddReservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddReservation));
            header = new Panel();
            title = new Label();
            close_btn = new Desktop_Application.Components.RoundedButton();
            label2 = new Label();
            dropDown_user = new System.Windows.Forms.ComboBox();
            label_publisher = new Label();
            chooseBooks = new System.Windows.Forms.Button();
            textBox_books = new System.Windows.Forms.TextBox();
            save = new Desktop_Application.Components.RoundedButton();
            cancel = new Desktop_Application.Components.RoundedButton();
            header.SuspendLayout();
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
            header.Size = new Size(438, 73);
            header.TabIndex = 61;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Yu Gothic UI Semibold", 16F);
            title.Location = new Point(95, 15);
            title.Name = "title";
            title.Size = new Size(230, 37);
            title.TabIndex = 2;
            title.Text = "Add Reservations";
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
            close_btn.Location = new Point(384, 13);
            close_btn.Margin = new Padding(3, 4, 3, 4);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(41, 47);
            close_btn.TabIndex = 25;
            close_btn.TabStop = false;
            close_btn.TextColor = Color.White;
            close_btn.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI Semibold", 14F);
            label2.Location = new Point(14, 148);
            label2.Name = "label2";
            label2.Size = new Size(80, 32);
            label2.TabIndex = 59;
            label2.Text = "Books";
            // 
            // dropDown_user
            // 
            dropDown_user.BackColor = Color.WhiteSmoke;
            dropDown_user.DropDownStyle = ComboBoxStyle.DropDownList;
            dropDown_user.Font = new Font("Yu Gothic UI Semibold", 14F);
            dropDown_user.FormattingEnabled = true;
            dropDown_user.Location = new Point(93, 92);
            dropDown_user.Margin = new Padding(3, 4, 3, 4);
            dropDown_user.MaxDropDownItems = 10;
            dropDown_user.Name = "dropDown_user";
            dropDown_user.Size = new Size(327, 39);
            dropDown_user.TabIndex = 1;
            // 
            // label_publisher
            // 
            label_publisher.AutoSize = true;
            label_publisher.Font = new Font("Yu Gothic UI Semibold", 14F);
            label_publisher.Location = new Point(14, 96);
            label_publisher.Name = "label_publisher";
            label_publisher.Size = new Size(63, 32);
            label_publisher.TabIndex = 71;
            label_publisher.Text = "User";
            // 
            // chooseBooks
            // 
            chooseBooks.Location = new Point(378, 144);
            chooseBooks.Margin = new Padding(3, 4, 3, 4);
            chooseBooks.Name = "chooseBooks";
            chooseBooks.Size = new Size(42, 43);
            chooseBooks.TabIndex = 2;
            chooseBooks.Text = "...";
            chooseBooks.UseVisualStyleBackColor = true;
            chooseBooks.Click += OpenChooseBooks;
            // 
            // textBox_books
            // 
            textBox_books.BackColor = Color.WhiteSmoke;
            textBox_books.Enabled = false;
            textBox_books.Font = new Font("Yu Gothic UI Semibold", 14F);
            textBox_books.Location = new Point(93, 144);
            textBox_books.Margin = new Padding(3, 4, 3, 4);
            textBox_books.Name = "textBox_books";
            textBox_books.Size = new Size(278, 39);
            textBox_books.TabIndex = 73;
            // 
            // save
            // 
            save.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
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
            save.Location = new Point(120, 204);
            save.Margin = new Padding(3, 4, 3, 4);
            save.Name = "save";
            save.Size = new Size(97, 48);
            save.TabIndex = 81;
            save.TabStop = false;
            save.Text = "Save";
            save.TextColor = Color.White;
            save.UseVisualStyleBackColor = false;
            save.Click += Save;
            // 
            // cancel
            // 
            cancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cancel.BackColor = Color.WhiteSmoke;
            cancel.BackgroundColor = Color.WhiteSmoke;
            cancel.BorderColor = Color.FromArgb(80, 77, 180);
            cancel.BorderRadius = 5;
            cancel.BorderSize = 2;
            cancel.FlatAppearance.BorderSize = 0;
            cancel.FlatStyle = FlatStyle.Flat;
            cancel.Font = new Font("Yu Gothic UI Semibold", 14F);
            cancel.ForeColor = Color.Black;
            cancel.Location = new Point(223, 204);
            cancel.Margin = new Padding(3, 4, 3, 4);
            cancel.Name = "cancel";
            cancel.Size = new Size(97, 48);
            cancel.TabIndex = 82;
            cancel.TabStop = false;
            cancel.Text = "Cancel";
            cancel.TextColor = Color.Black;
            cancel.UseVisualStyleBackColor = false;
            // 
            // AddReservations
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(440, 266);
            Controls.Add(save);
            Controls.Add(cancel);
            Controls.Add(chooseBooks);
            Controls.Add(textBox_books);
            Controls.Add(dropDown_user);
            Controls.Add(label_publisher);
            Controls.Add(header);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddReservations";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddBorrowing";
            Load += OnLoad;
            header.ResumeLayout(false);
            header.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox dropDown_user;
        private Panel header;
        private Label title;
        private Components.RoundedButton close_btn;
        private Label label2;
        private Label label_publisher;
        private System.Windows.Forms.Button chooseBooks;
        private System.Windows.Forms.TextBox textBox_books;
        private Components.RoundedButton save;
        private Components.RoundedButton cancel;
    }
}