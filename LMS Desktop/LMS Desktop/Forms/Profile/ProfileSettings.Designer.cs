﻿using Desktop_Application.Components;

namespace Desktop_Application.Forms.Profile
{
    partial class ProfileSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileSettings));
            save = new RoundedButton();
            cancel = new RoundedButton();
            label_publisher = new Label();
            header = new Panel();
            title = new Label();
            close_btn = new RoundedButton();
            label2 = new Label();
            textBox_lastName = new TextBox();
            textBox_firstName = new TextBox();
            textBox_address = new TextBox();
            label3 = new Label();
            textBox_username = new TextBox();
            label4 = new Label();
            dateOfBirth_datePicker = new DateTimePicker();
            label1 = new Label();
            textBox_email = new TextBox();
            label5 = new Label();
            button_changePassword = new RoundedButton();
            header.SuspendLayout();
            SuspendLayout();
            // 
            // save
            // 
            save.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            save.Location = new Point(172, 341);
            save.Name = "save";
            save.Size = new Size(85, 36);
            save.TabIndex = 8;
            save.TabStop = false;
            save.Text = "Save";
            save.TextColor = Color.White;
            save.UseVisualStyleBackColor = false;
            save.Click += Save;
            // 
            // cancel
            // 
            cancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cancel.BackColor = Color.WhiteSmoke;
            cancel.BackgroundColor = Color.WhiteSmoke;
            cancel.BorderColor = Color.FromArgb(80, 77, 180);
            cancel.BorderRadius = 5;
            cancel.BorderSize = 2;
            cancel.FlatAppearance.BorderSize = 0;
            cancel.FlatStyle = FlatStyle.Flat;
            cancel.Font = new Font("Yu Gothic UI Semibold", 14F);
            cancel.ForeColor = Color.Black;
            cancel.Location = new Point(262, 341);
            cancel.Name = "cancel";
            cancel.Size = new Size(85, 36);
            cancel.TabIndex = 9;
            cancel.TabStop = false;
            cancel.Text = "Cancel";
            cancel.TextColor = Color.Black;
            cancel.UseVisualStyleBackColor = false;
            // 
            // label_publisher
            // 
            label_publisher.AutoSize = true;
            label_publisher.Font = new Font("Yu Gothic UI Semibold", 14F);
            label_publisher.Location = new Point(10, 76);
            label_publisher.Name = "label_publisher";
            label_publisher.Size = new Size(102, 25);
            label_publisher.TabIndex = 90;
            label_publisher.Text = "First name";
            // 
            // header
            // 
            header.BackColor = Color.White;
            header.Controls.Add(title);
            header.Controls.Add(close_btn);
            header.Location = new Point(1, 1);
            header.Name = "header";
            header.Size = new Size(518, 55);
            header.TabIndex = 87;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Yu Gothic UI Semibold", 16F);
            title.Location = new Point(163, 11);
            title.Name = "title";
            title.Size = new Size(167, 30);
            title.TabIndex = 2;
            title.Text = "Profile Settings";
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
            close_btn.Location = new Point(471, 10);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(36, 35);
            close_btn.TabIndex = 25;
            close_btn.TabStop = false;
            close_btn.TextColor = Color.White;
            close_btn.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI Semibold", 14F);
            label2.Location = new Point(10, 113);
            label2.Name = "label2";
            label2.Size = new Size(99, 25);
            label2.TabIndex = 86;
            label2.Text = "Last name";
            // 
            // textBox_lastName
            // 
            textBox_lastName.BackColor = Color.WhiteSmoke;
            textBox_lastName.Font = new Font("Yu Gothic UI Semibold", 14F);
            textBox_lastName.Location = new Point(126, 111);
            textBox_lastName.Name = "textBox_lastName";
            textBox_lastName.Size = new Size(382, 32);
            textBox_lastName.TabIndex = 2;
            // 
            // textBox_firstName
            // 
            textBox_firstName.BackColor = Color.WhiteSmoke;
            textBox_firstName.Font = new Font("Yu Gothic UI Semibold", 14F);
            textBox_firstName.Location = new Point(126, 76);
            textBox_firstName.Name = "textBox_firstName";
            textBox_firstName.Size = new Size(382, 32);
            textBox_firstName.TabIndex = 1;
            // 
            // textBox_address
            // 
            textBox_address.BackColor = Color.WhiteSmoke;
            textBox_address.Font = new Font("Yu Gothic UI Semibold", 14F);
            textBox_address.Location = new Point(126, 252);
            textBox_address.Name = "textBox_address";
            textBox_address.Size = new Size(382, 32);
            textBox_address.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI Semibold", 14F);
            label3.Location = new Point(10, 254);
            label3.Name = "label3";
            label3.Size = new Size(80, 25);
            label3.TabIndex = 99;
            label3.Text = "Address";
            // 
            // textBox_username
            // 
            textBox_username.BackColor = Color.WhiteSmoke;
            textBox_username.Font = new Font("Yu Gothic UI Semibold", 14F);
            textBox_username.Location = new Point(126, 146);
            textBox_username.Name = "textBox_username";
            textBox_username.Size = new Size(382, 32);
            textBox_username.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI Semibold", 14F);
            label4.Location = new Point(10, 148);
            label4.Name = "label4";
            label4.Size = new Size(98, 25);
            label4.TabIndex = 101;
            label4.Text = "Username";
            // 
            // dateOfBirth_datePicker
            // 
            dateOfBirth_datePicker.CalendarFont = new Font("Yu Gothic UI Semibold", 14F);
            dateOfBirth_datePicker.CustomFormat = "dd/MM/yyyy";
            dateOfBirth_datePicker.Font = new Font("Yu Gothic UI Semibold", 14F);
            dateOfBirth_datePicker.Format = DateTimePickerFormat.Custom;
            dateOfBirth_datePicker.Location = new Point(151, 182);
            dateOfBirth_datePicker.Name = "dateOfBirth_datePicker";
            dateOfBirth_datePicker.Size = new Size(135, 32);
            dateOfBirth_datePicker.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI Semibold", 14F);
            label1.Location = new Point(10, 184);
            label1.Name = "label1";
            label1.Size = new Size(122, 25);
            label1.TabIndex = 103;
            label1.Text = "Date of Birth";
            // 
            // textBox_email
            // 
            textBox_email.BackColor = Color.WhiteSmoke;
            textBox_email.Font = new Font("Yu Gothic UI Semibold", 14F);
            textBox_email.Location = new Point(126, 217);
            textBox_email.Name = "textBox_email";
            textBox_email.Size = new Size(382, 32);
            textBox_email.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI Semibold", 14F);
            label5.Location = new Point(10, 219);
            label5.Name = "label5";
            label5.Size = new Size(59, 25);
            label5.TabIndex = 105;
            label5.Text = "Email";
            // 
            // button_changePassword
            // 
            button_changePassword.BackColor = Color.WhiteSmoke;
            button_changePassword.BackgroundColor = Color.WhiteSmoke;
            button_changePassword.BorderColor = Color.FromArgb(80, 77, 180);
            button_changePassword.BorderRadius = 5;
            button_changePassword.BorderSize = 2;
            button_changePassword.FlatAppearance.BorderSize = 0;
            button_changePassword.FlatStyle = FlatStyle.Flat;
            button_changePassword.Font = new Font("Yu Gothic UI Semibold", 14F);
            button_changePassword.ForeColor = Color.Black;
            button_changePassword.Location = new Point(126, 287);
            button_changePassword.Name = "button_changePassword";
            button_changePassword.Size = new Size(234, 36);
            button_changePassword.TabIndex = 7;
            button_changePassword.Text = "Change Password...";
            button_changePassword.TextColor = Color.Black;
            button_changePassword.UseVisualStyleBackColor = false;
            button_changePassword.Click += ChangePassword;
            // 
            // ProfileSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(520, 387);
            Controls.Add(button_changePassword);
            Controls.Add(textBox_email);
            Controls.Add(label5);
            Controls.Add(dateOfBirth_datePicker);
            Controls.Add(label1);
            Controls.Add(textBox_username);
            Controls.Add(label4);
            Controls.Add(textBox_address);
            Controls.Add(label3);
            Controls.Add(textBox_firstName);
            Controls.Add(textBox_lastName);
            Controls.Add(save);
            Controls.Add(cancel);
            Controls.Add(label_publisher);
            Controls.Add(header);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ProfileSettings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddBook";
            Load += OnLoad;
            header.ResumeLayout(false);
            header.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RoundedButton save;
        private RoundedButton cancel;
        private Label label_publisher;
        private Panel header;
        private Label title;
        private RoundedButton close_btn;
        private Label label2;
        private TextBox textBox_lastName;
        private TextBox textBox_firstName;
        private TextBox textBox_address;
        private Label label3;
        private TextBox textBox_username;
        private Label label4;
        private DateTimePicker dateOfBirth_datePicker;
        private Label label1;
        private TextBox textBox_email;
        private Label label5;
        private RoundedButton button_changePassword;
    }
}