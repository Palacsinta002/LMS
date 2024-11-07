namespace Desktop_Application
{
    partial class adminPanel
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
            panel1 = new Panel();
            button1 = new Button();
            close_btn = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(80, 77, 180);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, 0);
            panel1.MinimumSize = new Size(200, 422);
            panel1.Name = "panel1";
            panel1.Size = new Size(260, 561);
            panel1.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(0, 146);
            button1.Name = "button1";
            button1.Size = new Size(260, 61);
            button1.TabIndex = 0;
            button1.TabStop = false;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // close_btn
            // 
            close_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            close_btn.AutoSize = true;
            close_btn.Cursor = Cursors.Hand;
            close_btn.Font = new Font("Yu Gothic UI Semibold", 12F);
            close_btn.Location = new Point(952, 60);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(20, 21);
            close_btn.TabIndex = 10;
            close_btn.Text = "X";
            close_btn.Click += CloseWindow;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(72, 69, 158);
            panel2.Location = new Point(1, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(983, 50);
            panel2.TabIndex = 11;
            panel2.MouseDown += Login_MouseDown;
            panel2.MouseMove += Login_MouseMove;
            panel2.MouseUp += Login_MouseUp;
            // 
            // adminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(panel2);
            Controls.Add(close_btn);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "adminPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Panel";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label close_btn;
        private Button button1;
        private Panel panel2;
    }
}