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
            label_title = new Label();
            textBox_username = new TextBox();
            textBox_password = new TextBox();
            label_username = new Label();
            label_password = new Label();
            panel_header = new Panel();
            rButton_close = new RoundedButton();
            rButton_login = new RoundedButton();
            label_usernameError = new Label();
            label_passwordError = new Label();
            button_showPassword = new Button();
            panel_header.SuspendLayout();
            SuspendLayout();
            // 
            // label_title
            // 
            label_title.AutoSize = true;
            label_title.Font = new Font("Yu Gothic UI Semibold", 24F);
            label_title.ForeColor = Color.White;
            label_title.ImeMode = ImeMode.NoControl;
            label_title.Location = new Point(93, 32);
            label_title.Name = "label_title";
            label_title.Size = new Size(101, 45);
            label_title.TabIndex = 1;
            label_title.Text = "Login";
            // 
            // textBox_username
            // 
            textBox_username.Font = new Font("Yu Gothic UI Semibold", 14F);
            textBox_username.Location = new Point(22, 131);
            textBox_username.Name = "textBox_username";
            textBox_username.Size = new Size(235, 32);
            textBox_username.TabIndex = 0;
            textBox_username.TextChanged += UsernameTextChanged;
            // 
            // textBox_password
            // 
            textBox_password.Font = new Font("Yu Gothic UI Semibold", 14F);
            textBox_password.Location = new Point(22, 207);
            textBox_password.MaxLength = 20;
            textBox_password.Name = "textBox_password";
            textBox_password.PasswordChar = '*';
            textBox_password.Size = new Size(235, 32);
            textBox_password.TabIndex = 1;
            textBox_password.TextChanged += PasswordTextChanged;
            // 
            // label_username
            // 
            label_username.AutoSize = true;
            label_username.Font = new Font("Yu Gothic UI Semibold", 14F);
            label_username.ForeColor = Color.White;
            label_username.Location = new Point(22, 103);
            label_username.Name = "label_username";
            label_username.Size = new Size(98, 25);
            label_username.TabIndex = 4;
            label_username.Text = "Username";
            // 
            // label_password
            // 
            label_password.AutoSize = true;
            label_password.Font = new Font("Yu Gothic UI Semibold", 14F);
            label_password.ForeColor = Color.White;
            label_password.Location = new Point(22, 179);
            label_password.Name = "label_password";
            label_password.Size = new Size(92, 25);
            label_password.TabIndex = 5;
            label_password.Text = "Password";
            // 
            // panel_header
            // 
            panel_header.BackColor = Color.FromArgb(80, 77, 180);
            panel_header.Controls.Add(rButton_close);
            panel_header.Location = new Point(1, 1);
            panel_header.Name = "panel_header";
            panel_header.Size = new Size(282, 43);
            panel_header.TabIndex = 7;
            // 
            // rButton_close
            // 
            rButton_close.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            rButton_close.BackColor = Color.Transparent;
            rButton_close.BackgroundColor = Color.Transparent;
            rButton_close.BorderColor = Color.Transparent;
            rButton_close.BorderRadius = 0;
            rButton_close.BorderSize = 0;
            rButton_close.Cursor = Cursors.Hand;
            rButton_close.FlatAppearance.BorderSize = 0;
            rButton_close.FlatAppearance.MouseDownBackColor = Color.Transparent;
            rButton_close.FlatAppearance.MouseOverBackColor = Color.Transparent;
            rButton_close.FlatStyle = FlatStyle.Flat;
            rButton_close.Font = new Font("Yu Gothic UI Semibold", 14F);
            rButton_close.ForeColor = Color.White;
            rButton_close.Image = (Image)resources.GetObject("rButton_close.Image");
            rButton_close.Location = new Point(237, 7);
            rButton_close.Name = "rButton_close";
            rButton_close.Size = new Size(36, 35);
            rButton_close.TabIndex = 24;
            rButton_close.TabStop = false;
            rButton_close.TextColor = Color.White;
            rButton_close.UseVisualStyleBackColor = false;
            // 
            // rButton_login
            // 
            rButton_login.BackColor = Color.White;
            rButton_login.BackgroundColor = Color.White;
            rButton_login.BorderColor = Color.Transparent;
            rButton_login.BorderRadius = 5;
            rButton_login.BorderSize = 0;
            rButton_login.FlatAppearance.BorderSize = 0;
            rButton_login.FlatAppearance.MouseDownBackColor = Color.Silver;
            rButton_login.FlatStyle = FlatStyle.Flat;
            rButton_login.Font = new Font("Yu Gothic UI Semibold", 14F);
            rButton_login.ForeColor = Color.Black;
            rButton_login.Location = new Point(172, 263);
            rButton_login.Name = "rButton_login";
            rButton_login.Size = new Size(85, 36);
            rButton_login.TabIndex = 24;
            rButton_login.TabStop = false;
            rButton_login.Text = "Login";
            rButton_login.TextColor = Color.Black;
            rButton_login.UseVisualStyleBackColor = false;
            rButton_login.Click += LoginCheck;
            // 
            // label_usernameError
            // 
            label_usernameError.AutoSize = true;
            label_usernameError.Font = new Font("Yu Gothic UI Semibold", 9F);
            label_usernameError.ForeColor = Color.White;
            label_usernameError.Location = new Point(22, 164);
            label_usernameError.Name = "label_usernameError";
            label_usernameError.Size = new Size(10, 15);
            label_usernameError.TabIndex = 25;
            label_usernameError.Text = " ";
            // 
            // label_passwordError
            // 
            label_passwordError.AutoSize = true;
            label_passwordError.Font = new Font("Yu Gothic UI Semibold", 9F);
            label_passwordError.ForeColor = Color.White;
            label_passwordError.Location = new Point(22, 240);
            label_passwordError.Name = "label_passwordError";
            label_passwordError.Size = new Size(10, 15);
            label_passwordError.TabIndex = 26;
            label_passwordError.Text = " ";
            // 
            // button_showPassword
            // 
            button_showPassword.BackColor = Color.White;
            button_showPassword.Cursor = Cursors.Hand;
            button_showPassword.FlatAppearance.BorderSize = 0;
            button_showPassword.FlatAppearance.MouseDownBackColor = Color.White;
            button_showPassword.FlatAppearance.MouseOverBackColor = Color.White;
            button_showPassword.FlatStyle = FlatStyle.Flat;
            button_showPassword.Image = (Image)resources.GetObject("button_showPassword.Image");
            button_showPassword.Location = new Point(224, 208);
            button_showPassword.Name = "button_showPassword";
            button_showPassword.Size = new Size(32, 28);
            button_showPassword.TabIndex = 27;
            button_showPassword.UseVisualStyleBackColor = false;
            button_showPassword.Click += ShowPassword;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(80, 77, 180);
            ClientSize = new Size(284, 311);
            Controls.Add(panel_header);
            Controls.Add(label_title);
            Controls.Add(label_username);
            Controls.Add(label_password);
            Controls.Add(label_usernameError);
            Controls.Add(label_passwordError);
            Controls.Add(button_showPassword);
            Controls.Add(textBox_username);
            Controls.Add(textBox_password);
            Controls.Add(rButton_login);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Load += OnLoad;
            panel_header.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label_title;
        private TextBox textBox_username;
        private TextBox textBox_password;
        private Label label_username;
        private Label label_password;
        private Panel panel_header;
        private RoundedButton rButton_login;
        private RoundedButton rButton_close;
        private Label label_usernameError;
        private Label label_passwordError;
        private Button button_showPassword;
    }
}
