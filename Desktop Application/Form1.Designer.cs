namespace Desktop_Application
{
    partial class Main
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
            login_btn = new Button();
            login_title = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            username = new Label();
            password = new Label();
            SuspendLayout();
            // 
            // login_btn
            // 
            login_btn.Location = new Point(182, 314);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(75, 23);
            login_btn.TabIndex = 0;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = true;
            // 
            // login_title
            // 
            login_title.AutoSize = true;
            login_title.Font = new Font("Yu Gothic UI Semibold", 24F);
            login_title.ImeMode = ImeMode.NoControl;
            login_title.Location = new Point(91, 113);
            login_title.Name = "login_title";
            login_title.Size = new Size(101, 45);
            login_title.TabIndex = 1;
            login_title.Text = "Login";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(22, 200);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(235, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(22, 263);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(235, 23);
            textBox2.TabIndex = 3;
            // 
            // username
            // 
            username.AutoSize = true;
            username.Location = new Point(30, 178);
            username.Name = "username";
            username.Size = new Size(60, 15);
            username.TabIndex = 4;
            username.Text = "Username";
            // 
            // password
            // 
            password.AutoSize = true;
            password.Location = new Point(30, 242);
            password.Name = "password";
            password.Size = new Size(57, 15);
            password.TabIndex = 5;
            password.Text = "Password";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 461);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(login_title);
            Controls.Add(login_btn);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Main_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button login_btn;
        private Label login_title;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label username;
        private Label password;
    }
}
