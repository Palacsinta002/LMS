namespace Desktop_Application.Forms.Profile
{
    partial class PasswordRequirements
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordRequirements));
            header = new Panel();
            title = new Label();
            close_btn = new Desktop_Application.Components.RoundedButton();
            label_title = new Label();
            button_ok = new Desktop_Application.Components.RoundedButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
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
            header.Size = new Size(258, 55);
            header.TabIndex = 27;
            // 
            // title
            // 
            title.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            title.AutoSize = true;
            title.Font = new Font("Yu Gothic UI Semibold", 16F);
            title.Location = new Point(42, 12);
            title.Name = "title";
            title.Size = new Size(152, 30);
            title.TabIndex = 2;
            title.Text = "Requirements";
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
            close_btn.Location = new Point(212, 10);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(36, 35);
            close_btn.TabIndex = 25;
            close_btn.TabStop = false;
            close_btn.TextColor = Color.White;
            close_btn.UseVisualStyleBackColor = false;
            // 
            // label_title
            // 
            label_title.Font = new Font("Yu Gothic UI Semibold", 14F);
            label_title.Location = new Point(22, 98);
            label_title.Name = "label_title";
            label_title.Size = new Size(172, 30);
            label_title.TabIndex = 28;
            label_title.Text = "󠁯• Upper case letter";
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
            button_ok.Location = new Point(168, 209);
            button_ok.Name = "button_ok";
            button_ok.Size = new Size(80, 36);
            button_ok.TabIndex = 30;
            button_ok.TabStop = false;
            button_ok.Text = "OK";
            button_ok.TextColor = Color.Black;
            button_ok.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Font = new Font("Yu Gothic UI Semibold", 14F);
            label1.Location = new Point(22, 128);
            label1.Name = "label1";
            label1.Size = new Size(172, 30);
            label1.TabIndex = 31;
            label1.Text = "󠁯• Lower case letter";
            // 
            // label2
            // 
            label2.Font = new Font("Yu Gothic UI Semibold", 14F);
            label2.Location = new Point(22, 158);
            label2.Name = "label2";
            label2.Size = new Size(173, 55);
            label2.TabIndex = 32;
            label2.Text = "󠁯• 󠁏󠁏Special character or number";
            // 
            // label3
            // 
            label3.Font = new Font("Yu Gothic UI Semibold", 14F);
            label3.Location = new Point(12, 68);
            label3.Name = "label3";
            label3.Size = new Size(182, 30);
            label3.TabIndex = 33;
            label3.Text = "󠁏󠁏At least one...";
            // 
            // PasswordRequirements
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(260, 257);
            Controls.Add(button_ok);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label_title);
            Controls.Add(header);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PasswordRequirements";
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
        private Label label_title;
        private Components.RoundedButton button_ok;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}