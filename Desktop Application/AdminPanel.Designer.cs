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
            close_btn = new Label();
            label1 = new Label();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // close_btn
            // 
            close_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            close_btn.AutoSize = true;
            close_btn.Cursor = Cursors.Hand;
            close_btn.Font = new Font("Yu Gothic UI Semibold", 12F);
            close_btn.Location = new Point(752, 9);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(20, 21);
            close_btn.TabIndex = 7;
            close_btn.Text = "X";
            close_btn.Click += CloseWindow;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(314, 111);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 8;
            label1.Text = "label1";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(80, 77, 180);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 422);
            panel1.TabIndex = 9;
            // 
            // adminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(close_btn);
            MinimumSize = new Size(800, 500);
            Name = "adminPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Panel";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label close_btn;
        private Label label1;
        private Panel panel1;
    }
}