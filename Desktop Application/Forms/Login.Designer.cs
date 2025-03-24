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
            title = new Label();
            username_textBox = new TextBox();
            password_textBox = new TextBox();
            username_label = new Label();
            password_label = new Label();
            header = new Panel();
            close_btn = new RoundedButton();
            login_btn = new RoundedButton();
            usernameError_lbl = new Label();
            passwordError_lbl = new Label();
            showPassword_btn = new Button();
            header.SuspendLayout();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Yu Gothic UI Semibold", 24F);
            title.ForeColor = Color.White;
            title.ImeMode = ImeMode.NoControl;
            title.Location = new Point(93, 32);
            title.Name = "title";
            title.Size = new Size(101, 45);
            title.TabIndex = 1;
            title.Text = "Login";
            // 
            // username_textBox
            // 
            username_textBox.Font = new Font("Yu Gothic UI Semibold", 14F);
            username_textBox.Location = new Point(22, 131);
            username_textBox.Name = "username_textBox";
            username_textBox.Size = new Size(235, 32);
            username_textBox.TabIndex = 0;
            username_textBox.TextChanged += UsernameTextChanged;
            // 
            // password_textBox
            // 
            password_textBox.Font = new Font("Yu Gothic UI Semibold", 14F);
            password_textBox.Location = new Point(22, 207);
            password_textBox.MaxLength = 20;
            password_textBox.Name = "password_textBox";
            password_textBox.PasswordChar = '*';
            password_textBox.Size = new Size(235, 32);
            password_textBox.TabIndex = 1;
            password_textBox.TextChanged += PasswordTextChanged;
            // 
            // username_label
            // 
            username_label.AutoSize = true;
            username_label.Font = new Font("Yu Gothic UI Semibold", 14F);
            username_label.ForeColor = Color.White;
            username_label.Location = new Point(22, 103);
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
            password_label.Location = new Point(22, 179);
            password_label.Name = "password_label";
            password_label.Size = new Size(92, 25);
            password_label.TabIndex = 5;
            password_label.Text = "Password";
            // 
            // header
            // 
            header.BackColor = Color.FromArgb(80, 77, 180);
            header.Controls.Add(close_btn);
            header.Location = new Point(1, 1);
            header.Name = "header";
            header.Size = new Size(282, 43);
            header.TabIndex = 7;
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
            close_btn.Location = new Point(237, 7);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(36, 35);
            close_btn.TabIndex = 24;
            close_btn.TabStop = false;
            close_btn.TextColor = Color.White;
            close_btn.UseVisualStyleBackColor = false;
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
            // usernameError_lbl
            // 
            usernameError_lbl.AutoSize = true;
            usernameError_lbl.Font = new Font("Yu Gothic UI Semibold", 9F);
            usernameError_lbl.ForeColor = Color.White;
            usernameError_lbl.Location = new Point(22, 164);
            usernameError_lbl.Name = "usernameError_lbl";
            usernameError_lbl.Size = new Size(10, 15);
            usernameError_lbl.TabIndex = 25;
            usernameError_lbl.Text = " ";
            // 
            // passwordError_lbl
            // 
            passwordError_lbl.AutoSize = true;
            passwordError_lbl.Font = new Font("Yu Gothic UI Semibold", 9F);
            passwordError_lbl.ForeColor = Color.White;
            passwordError_lbl.Location = new Point(22, 240);
            passwordError_lbl.Name = "passwordError_lbl";
            passwordError_lbl.Size = new Size(10, 15);
            passwordError_lbl.TabIndex = 26;
            passwordError_lbl.Text = " ";
            // 
            // showPassword_btn
            // 
            showPassword_btn.BackColor = Color.White;
            showPassword_btn.Cursor = Cursors.Hand;
            showPassword_btn.FlatAppearance.BorderSize = 0;
            showPassword_btn.FlatAppearance.MouseDownBackColor = Color.White;
            showPassword_btn.FlatAppearance.MouseOverBackColor = Color.White;
            showPassword_btn.FlatStyle = FlatStyle.Flat;
            showPassword_btn.Image = (Image)resources.GetObject("showPassword_btn.Image");
            showPassword_btn.Location = new Point(224, 208);
            showPassword_btn.Name = "showPassword_btn";
            showPassword_btn.Size = new Size(32, 28);
            showPassword_btn.TabIndex = 27;
            showPassword_btn.UseVisualStyleBackColor = false;
            showPassword_btn.Click += ShowPassword;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(80, 77, 180);
            ClientSize = new Size(284, 311);
            Controls.Add(showPassword_btn);
            Controls.Add(passwordError_lbl);
            Controls.Add(usernameError_lbl);
            Controls.Add(header);
            Controls.Add(login_btn);
            Controls.Add(password_label);
            Controls.Add(username_label);
            Controls.Add(password_textBox);
            Controls.Add(username_textBox);
            Controls.Add(title);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Load += OnLoad;
            header.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label title;
        private TextBox username_textBox;
        private TextBox password_textBox;
        private Label username_label;
        private Label password_label;
        private Panel header;
        private RoundedButton login_btn;
        private RoundedButton close_btn;
        private Label usernameError_lbl;
        private Label passwordError_lbl;
        private Button showPassword_btn;
    }
}
