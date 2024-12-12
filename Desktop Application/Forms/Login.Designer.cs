using Desktop_Application.Classes;
using Desktop_Application.Components;

namespace Desktop_Application
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            login_title = new Label();
            username_textBox = new TextBox();
            password_textBox = new TextBox();
            username_label = new Label();
            password_label = new Label();
            panel1 = new Panel();
            close_btn = new RoundedButton();
            login_btn = new RoundedButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // login_title
            // 
            login_title.AutoSize = true;
            login_title.Font = new Font("Yu Gothic UI Semibold", 24F);
            login_title.ForeColor = Color.White;
            login_title.ImeMode = ImeMode.NoControl;
            login_title.Location = new Point(93, 41);
            login_title.Name = "login_title";
            login_title.Size = new Size(101, 45);
            login_title.TabIndex = 1;
            login_title.Text = "Login";
            // 
            // username_textBox
            // 
            username_textBox.Font = new Font("Yu Gothic UI Semibold", 14F);
            username_textBox.Location = new Point(22, 135);
            username_textBox.Name = "username_textBox";
            username_textBox.Size = new Size(235, 32);
            username_textBox.TabIndex = 0;
            // 
            // password_textBox
            // 
            password_textBox.Font = new Font("Yu Gothic UI Semibold", 14F);
            password_textBox.Location = new Point(22, 211);
            password_textBox.Name = "password_textBox";
            password_textBox.PasswordChar = '●';
            password_textBox.Size = new Size(235, 32);
            password_textBox.TabIndex = 1;
            // 
            // username_label
            // 
            username_label.AutoSize = true;
            username_label.Font = new Font("Yu Gothic UI Semibold", 14F);
            username_label.ForeColor = Color.White;
            username_label.Location = new Point(22, 107);
            username_label.Name = "username_label";
            username_label.Size = new Size(98, 25);
            username_label.TabIndex = 4;
            username_label.Text = "Username";
            // 
            // password_label
            // 
            password_label.AutoSize = true;
            password_label.Font = new Font("Yu Gothic UI Semibold", 14F);
            password_label.ForeColor = Color.White;
            password_label.Location = new Point(22, 183);
            password_label.Name = "password_label";
            password_label.Size = new Size(92, 25);
            password_label.TabIndex = 5;
            password_label.Text = "Password";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(80, 77, 180);
            panel1.Controls.Add(close_btn);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(285, 43);
            panel1.TabIndex = 7;
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
            close_btn.Location = new Point(238, 10);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(36, 35);
            close_btn.TabIndex = 24;
            close_btn.TabStop = false;
            close_btn.TextColor = Color.White;
            close_btn.UseVisualStyleBackColor = false;
            close_btn.Click += CloseWindow;
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.White;
            login_btn.BackgroundColor = Color.White;
            login_btn.BorderColor = Color.Transparent;
            login_btn.BorderRadius = 5;
            login_btn.BorderSize = 0;
            login_btn.FlatAppearance.BorderSize = 0;
            login_btn.FlatAppearance.MouseDownBackColor = Color.Silver;
            login_btn.FlatStyle = FlatStyle.Flat;
            login_btn.Font = new Font("Yu Gothic UI Semibold", 14F);
            login_btn.ForeColor = Color.Black;
            login_btn.Location = new Point(172, 263);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(85, 36);
            login_btn.TabIndex = 24;
            login_btn.TabStop = false;
            login_btn.Text = "Login";
            login_btn.TextColor = Color.Black;
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += LoginCheck;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(80, 77, 180);
            ClientSize = new Size(284, 311);
            Controls.Add(login_btn);
            Controls.Add(password_label);
            Controls.Add(username_label);
            Controls.Add(password_textBox);
            Controls.Add(username_textBox);
            Controls.Add(login_title);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Login_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label login_title;
        private TextBox username_textBox;
        private TextBox password_textBox;
        private Label username_label;
        private Label password_label;
        private Panel panel1;
        private RoundedButton login_btn;
        private RoundedButton close_btn;
    }
}
