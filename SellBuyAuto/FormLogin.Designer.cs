namespace SellBuyAuto
{
    partial class FormLogin
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
            txtUsername = new TextBox();
            lblUsername = new Label();
            label1 = new Label();
            txtPassword = new TextBox();
            lblTitle = new Label();
            btLogin = new Button();
            lblSignUp = new Label();
            btShowPassword = new Button();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(127, 168);
            txtUsername.Margin = new Padding(4, 3, 4, 3);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(158, 23);
            txtUsername.TabIndex = 0;
            txtUsername.KeyUp += txtUsername_KeyUp;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(124, 150);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(145, 15);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Nom d'utilisateur / Email :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(124, 240);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 3;
            label1.Text = "Mot de passe :";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(127, 258);
            txtPassword.Margin = new Padding(4, 3, 4, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(158, 23);
            txtPassword.TabIndex = 2;
            txtPassword.KeyUp += txtPassword_KeyUp;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Snap ITC", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(106, 44);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.RightToLeft = RightToLeft.No;
            lblTitle.Size = new Size(205, 35);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "SellBuyAuto";
            // 
            // btLogin
            // 
            btLogin.Location = new Point(127, 337);
            btLogin.Margin = new Padding(4, 3, 4, 3);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(159, 27);
            btLogin.TabIndex = 5;
            btLogin.Text = "Login";
            btLogin.UseVisualStyleBackColor = true;
            btLogin.Click += btLogin_Click;
            // 
            // lblSignUp
            // 
            lblSignUp.AutoSize = true;
            lblSignUp.Cursor = Cursors.Hand;
            lblSignUp.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblSignUp.Location = new Point(172, 381);
            lblSignUp.Margin = new Padding(4, 0, 4, 0);
            lblSignUp.Name = "lblSignUp";
            lblSignUp.Size = new Size(65, 13);
            lblSignUp.TabIndex = 7;
            lblSignUp.Text = "S'enregistrer";
            lblSignUp.Click += lblSignUp_Click;
            // 
            // btShowPassword
            // 
            btShowPassword.BackgroundImage = Properties.Resources.ShowPassword;
            btShowPassword.BackgroundImageLayout = ImageLayout.Stretch;
            btShowPassword.Location = new Point(259, 258);
            btShowPassword.Margin = new Padding(4, 3, 4, 3);
            btShowPassword.Name = "btShowPassword";
            btShowPassword.Size = new Size(27, 23);
            btShowPassword.TabIndex = 6;
            btShowPassword.UseVisualStyleBackColor = true;
            btShowPassword.Click += btShowPassword_Click;
            btShowPassword.KeyUp += btShowPassword_KeyUp;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 509);
            Controls.Add(lblSignUp);
            Controls.Add(btShowPassword);
            Controls.Add(btLogin);
            Controls.Add(lblTitle);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Margin = new Padding(4, 3, 4, 3);
            MaximumSize = new Size(429, 548);
            MinimumSize = new Size(429, 548);
            Name = "FormLogin";
            Text = "Login";
            KeyUp += FormLogin_KeyUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button btShowPassword;
        private System.Windows.Forms.Label lblSignUp;
    }
}