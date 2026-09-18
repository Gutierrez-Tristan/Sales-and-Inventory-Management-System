namespace SalesAndInventory
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
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(520, 32);
            label1.Name = "label1";
            label1.Size = new Size(97, 41);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(393, 101);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 1;
            label2.Text = "UserName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(393, 226);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(284, 628);
            panel1.TabIndex = 4;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(393, 139);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(297, 27);
            txtUsername.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(393, 268);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(297, 27);
            txtPassword.TabIndex = 6;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(255, 128, 0);
            btnLogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(450, 376);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(194, 50);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(59, 211);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 141);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(888, 626);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Panel panel1;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private PictureBox pictureBox1;
    }
}
