namespace Electro_Fih
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            txtboxEmail = new CustomControls.RJControls.RJTextBox();
            txtboxPassword = new CustomControls.RJControls.RJTextBox();
            lblEmail = new Label();
            lblPassword = new Label();
            btnLogin = new RJControls.RJButton();
            lblMessage = new Label();
            btnRegister = new RJControls.RJButton();
            panel1 = new Panel();
            loginPageLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)loginPageLogo).BeginInit();
            SuspendLayout();
            // 
            // txtboxEmail
            // 
            txtboxEmail.BackColor = SystemColors.Window;
            txtboxEmail.BorderColor = Color.FromArgb(42, 14, 77);
            txtboxEmail.BorderFocusColor = Color.FromArgb(42, 14, 77);
            txtboxEmail.BorderRadius = 15;
            txtboxEmail.BorderSize = 2;
            txtboxEmail.ForeColor = Color.FromArgb(42, 14, 77);
            txtboxEmail.Location = new Point(204, 365);
            txtboxEmail.Margin = new Padding(3, 5, 3, 5);
            txtboxEmail.Multiline = false;
            txtboxEmail.Name = "txtboxEmail";
            txtboxEmail.Padding = new Padding(10, 9, 10, 9);
            txtboxEmail.PasswordChar = false;
            txtboxEmail.PlaceholderColor = Color.DarkGray;
            txtboxEmail.PlaceholderText = "";
            txtboxEmail.Size = new Size(250, 39);
            txtboxEmail.TabIndex = 0;
            txtboxEmail.Texts = "";
            txtboxEmail.UnderlinedStyle = false;
            // 
            // txtboxPassword
            // 
            txtboxPassword.BackColor = SystemColors.Window;
            txtboxPassword.BorderColor = Color.FromArgb(42, 14, 77);
            txtboxPassword.BorderFocusColor = Color.FromArgb(42, 14, 77);
            txtboxPassword.BorderRadius = 15;
            txtboxPassword.BorderSize = 2;
            txtboxPassword.ForeColor = Color.FromArgb(42, 14, 77);
            txtboxPassword.Location = new Point(204, 460);
            txtboxPassword.Margin = new Padding(3, 5, 3, 5);
            txtboxPassword.Multiline = false;
            txtboxPassword.Name = "txtboxPassword";
            txtboxPassword.Padding = new Padding(10, 9, 10, 9);
            txtboxPassword.PasswordChar = true;
            txtboxPassword.PlaceholderColor = Color.DarkGray;
            txtboxPassword.PlaceholderText = "";
            txtboxPassword.Size = new Size(250, 39);
            txtboxPassword.TabIndex = 1;
            txtboxPassword.Texts = "";
            txtboxPassword.UnderlinedStyle = false;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(211, 334);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(59, 22);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            lblEmail.Click += lblEmail_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.White;
            lblPassword.Location = new Point(211, 429);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(66, 22);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Jelszó";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(108, 38, 217);
            btnLogin.BackgroundColor = Color.FromArgb(108, 38, 217);
            btnLogin.BorderColor = Color.White;
            btnLogin.BorderRadius = 15;
            btnLogin.BorderSize = 2;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(255, 542);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(150, 50);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Bejelentkezés";
            btnLogin.TextColor = Color.White;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMessage.ForeColor = Color.White;
            lblMessage.Location = new Point(270, 725);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 22);
            lblMessage.TabIndex = 5;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(108, 38, 217);
            btnRegister.BackgroundColor = Color.FromArgb(108, 38, 217);
            btnRegister.BorderColor = Color.White;
            btnRegister.BorderRadius = 15;
            btnRegister.BorderSize = 2;
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(255, 625);
            btnRegister.Margin = new Padding(3, 4, 3, 4);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(150, 50);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Regisztráció";
            btnRegister.TextColor = Color.White;
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(661, 105);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 750);
            panel1.TabIndex = 7;
            // 
            // loginPageLogo
            // 
            loginPageLogo.BackgroundImage = (Image)resources.GetObject("loginPageLogo.BackgroundImage");
            loginPageLogo.BackgroundImageLayout = ImageLayout.Zoom;
            loginPageLogo.Location = new Point(762, 212);
            loginPageLogo.Margin = new Padding(3, 4, 3, 4);
            loginPageLogo.Name = "loginPageLogo";
            loginPageLogo.Size = new Size(689, 570);
            loginPageLogo.TabIndex = 8;
            loginPageLogo.TabStop = false;
            loginPageLogo.Click += loginPageLogo_Click;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 14, 77);
            ClientSize = new Size(1609, 1036);
            Controls.Add(loginPageLogo);
            Controls.Add(panel1);
            Controls.Add(btnRegister);
            Controls.Add(lblMessage);
            Controls.Add(btnLogin);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(txtboxPassword);
            Controls.Add(txtboxEmail);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Electro-Fih";
            FormClosed += LoginPage_FormClosed;
            ((System.ComponentModel.ISupportInitialize)loginPageLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.RJControls.RJTextBox txtboxEmail;
        private CustomControls.RJControls.RJTextBox txtboxPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private RJControls.RJButton btnLogin;
        private System.Windows.Forms.Label lblMessage;
        private RJControls.RJButton btnRegister;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox loginPageLogo;
    }
}