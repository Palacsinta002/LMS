using Desktop_Application.Components;

namespace Desktop_Application.Forms.Profile
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            save = new RoundedButton();
            cancel = new RoundedButton();
            label_publisher = new Label();
            header = new Panel();
            title = new Label();
            close_btn = new RoundedButton();
            label2 = new Label();
            textBox_newPassword = new TextBox();
            textBox_currentPassword = new TextBox();
            textBox_newPasswordAgain = new TextBox();
            label4 = new Label();
            button_pwdRequirements = new Button();
            header.SuspendLayout();
            SuspendLayout();
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
            save.Location = new Point(172, 197);
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
            cancel.Location = new Point(262, 197);
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
            label_publisher.Size = new Size(162, 25);
            label_publisher.TabIndex = 90;
            label_publisher.Text = "Current Password";
            // 
            // header
            // 
            header.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            header.BackColor = Color.White;
            header.Controls.Add(title);
            header.Controls.Add(close_btn);
            header.Location = new Point(1, 1);
            header.Name = "header";
            header.Size = new Size(363, 55);
            header.TabIndex = 87;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Yu Gothic UI Semibold", 16F);
            title.Location = new Point(78, 11);
            title.Name = "title";
            title.Size = new Size(188, 30);
            title.TabIndex = 2;
            title.Text = "Change Password";
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
            close_btn.Location = new Point(316, 10);
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
            label2.Size = new Size(136, 25);
            label2.TabIndex = 86;
            label2.Text = "New Password";
            // 
            // textBox_newPassword
            // 
            textBox_newPassword.BackColor = Color.WhiteSmoke;
            textBox_newPassword.Font = new Font("Yu Gothic UI Semibold", 14F);
            textBox_newPassword.Location = new Point(194, 111);
            textBox_newPassword.MaxLength = 16;
            textBox_newPassword.Name = "textBox_newPassword";
            textBox_newPassword.PasswordChar = '*';
            textBox_newPassword.Size = new Size(153, 32);
            textBox_newPassword.TabIndex = 2;
            // 
            // textBox_currentPassword
            // 
            textBox_currentPassword.BackColor = Color.WhiteSmoke;
            textBox_currentPassword.Font = new Font("Yu Gothic UI Semibold", 14F);
            textBox_currentPassword.Location = new Point(194, 76);
            textBox_currentPassword.MaxLength = 16;
            textBox_currentPassword.Name = "textBox_currentPassword";
            textBox_currentPassword.PasswordChar = '*';
            textBox_currentPassword.Size = new Size(153, 32);
            textBox_currentPassword.TabIndex = 1;
            // 
            // textBox_newPasswordAgain
            // 
            textBox_newPasswordAgain.BackColor = Color.WhiteSmoke;
            textBox_newPasswordAgain.Font = new Font("Yu Gothic UI Semibold", 14F);
            textBox_newPasswordAgain.Location = new Point(194, 146);
            textBox_newPasswordAgain.MaxLength = 16;
            textBox_newPasswordAgain.Name = "textBox_newPasswordAgain";
            textBox_newPasswordAgain.PasswordChar = '*';
            textBox_newPasswordAgain.Size = new Size(153, 32);
            textBox_newPasswordAgain.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI Semibold", 14F);
            label4.Location = new Point(10, 148);
            label4.Name = "label4";
            label4.Size = new Size(147, 25);
            label4.TabIndex = 101;
            label4.Text = "Password Again";
            // 
            // button_pwdRequirements
            // 
            button_pwdRequirements.BackColor = Color.WhiteSmoke;
            button_pwdRequirements.Cursor = Cursors.Hand;
            button_pwdRequirements.FlatAppearance.BorderSize = 0;
            button_pwdRequirements.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            button_pwdRequirements.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            button_pwdRequirements.FlatStyle = FlatStyle.Flat;
            button_pwdRequirements.Image = (Image)resources.GetObject("button_pwdRequirements.Image");
            button_pwdRequirements.Location = new Point(314, 112);
            button_pwdRequirements.Name = "button_pwdRequirements";
            button_pwdRequirements.Size = new Size(32, 28);
            button_pwdRequirements.TabIndex = 103;
            button_pwdRequirements.UseVisualStyleBackColor = false;
            button_pwdRequirements.Click += ShowPasswordRequirements;
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(365, 243);
            Controls.Add(button_pwdRequirements);
            Controls.Add(textBox_newPasswordAgain);
            Controls.Add(label4);
            Controls.Add(textBox_currentPassword);
            Controls.Add(textBox_newPassword);
            Controls.Add(save);
            Controls.Add(cancel);
            Controls.Add(label_publisher);
            Controls.Add(header);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ChangePassword";
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
        private TextBox textBox_newPassword;
        private TextBox textBox_currentPassword;
        private TextBox textBox_newPasswordAgain;
        private Label label4;
        private Button button_pwdRequirements;
    }
}