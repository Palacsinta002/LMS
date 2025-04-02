namespace Desktop_Application.Forms.Users
{
    partial class ShowPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowPassword));
            header = new Panel();
            title = new Label();
            close_btn = new Desktop_Application.Components.RoundedButton();
            button_ok = new Desktop_Application.Components.RoundedButton();
            label3 = new Label();
            label_password = new Label();
            header.SuspendLayout();
            SuspendLayout();
            // 
            // header
            // 
            header.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            header.BackColor = Color.White;
            header.Controls.Add(title);
            header.Controls.Add(close_btn);
            header.Location = new Point(1, 1);
            header.Name = "header";
            header.Size = new Size(318, 55);
            header.TabIndex = 27;
            // 
            // title
            // 
            title.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            title.AutoSize = true;
            title.Font = new Font("Yu Gothic UI Semibold", 16F);
            title.Location = new Point(77, 12);
            title.Name = "title";
            title.Size = new Size(156, 30);
            title.TabIndex = 2;
            title.Text = "User Password";
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
            close_btn.Location = new Point(272, 10);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(36, 35);
            close_btn.TabIndex = 25;
            close_btn.TabStop = false;
            close_btn.TextColor = Color.White;
            close_btn.UseVisualStyleBackColor = false;
            // 
            // button_ok
            // 
            button_ok.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_ok.BackColor = Color.WhiteSmoke;
            button_ok.BackgroundColor = Color.WhiteSmoke;
            button_ok.BorderColor = Color.FromArgb(80, 77, 180);
            button_ok.BorderRadius = 5;
            button_ok.BorderSize = 2;
            button_ok.FlatAppearance.BorderSize = 0;
            button_ok.FlatAppearance.MouseDownBackColor = Color.FromArgb(63, 65, 158);
            button_ok.FlatStyle = FlatStyle.Flat;
            button_ok.Font = new Font("Yu Gothic UI Semibold", 14F);
            button_ok.ForeColor = Color.Black;
            button_ok.Location = new Point(228, 153);
            button_ok.Name = "button_ok";
            button_ok.Size = new Size(80, 36);
            button_ok.TabIndex = 30;
            button_ok.TabStop = false;
            button_ok.Text = "OK";
            button_ok.TextColor = Color.Black;
            button_ok.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.Font = new Font("Yu Gothic UI Semibold", 14F);
            label3.Location = new Point(12, 68);
            label3.Name = "label3";
            label3.Size = new Size(285, 58);
            label3.TabIndex = 33;
            label3.Text = "The user's randomly generated password:";
            // 
            // label_password
            // 
            label_password.Font = new Font("Yu Gothic UI Semibold", 16F);
            label_password.Location = new Point(12, 126);
            label_password.Name = "label_password";
            label_password.Size = new Size(198, 37);
            label_password.TabIndex = 34;
            label_password.Text = "[password]";
            // 
            // ShowPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(320, 201);
            Controls.Add(label_password);
            Controls.Add(button_ok);
            Controls.Add(label3);
            Controls.Add(header);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ShowPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RemoveBookConfirmation";
            Load += OnLoad;
            header.ResumeLayout(false);
            header.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel header;
        private Label title;
        private Components.RoundedButton close_btn;
        private Components.RoundedButton button_ok;
        private Label label3;
        private Label label_password;
    }
}