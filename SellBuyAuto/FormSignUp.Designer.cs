namespace SellBuyAuto
{
    partial class FormSignUp
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
            lblTitle = new Label();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblUsername = new Label();
            txtUsername = new TextBox();
            btShowPassword = new Button();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btShowPassword2 = new Button();
            lblConfirmPassword = new Label();
            txtConfirmPassword = new TextBox();
            btSignUp = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Snap ITC", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(109, 45);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.RightToLeft = RightToLeft.No;
            lblTitle.Size = new Size(205, 35);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "SellBuyAuto";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new Point(124, 123);
            this.lblEmail.Margin = new Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new Size(42, 15);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Email :";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(128, 142);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(158, 23);
            txtEmail.TabIndex = 2;
            txtEmail.KeyUp += txtName_KeyUp;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(124, 183);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(105, 15);
            lblUsername.TabIndex = 11;
            lblUsername.Text = "Nom d'utilisateur :";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(128, 202);
            txtUsername.Margin = new Padding(4, 3, 4, 3);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(158, 23);
            txtUsername.TabIndex = 3;
            txtUsername.KeyUp += txtUsername_KeyUp;
            // 
            // btShowPassword
            // 
            btShowPassword.BackgroundImage = Properties.Resources.ShowPassword;
            btShowPassword.BackgroundImageLayout = ImageLayout.Stretch;
            btShowPassword.Location = new Point(259, 263);
            btShowPassword.Margin = new Padding(4, 3, 4, 3);
            btShowPassword.Name = "btShowPassword";
            btShowPassword.Size = new Size(27, 23);
            btShowPassword.TabIndex = 14;
            btShowPassword.UseVisualStyleBackColor = true;
            btShowPassword.Click += btShowPassword_Click;
            btShowPassword.KeyUp += btShowPassword_KeyUp;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(124, 245);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(83, 15);
            lblPassword.TabIndex = 13;
            lblPassword.Text = "Mot de passe :";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(128, 263);
            txtPassword.Margin = new Padding(4, 3, 4, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(158, 23);
            txtPassword.TabIndex = 4;
            txtPassword.KeyUp += txtPassword_KeyUp;
            // 
            // btShowPassword2
            // 
            btShowPassword2.BackgroundImage = Properties.Resources.ShowPassword;
            btShowPassword2.BackgroundImageLayout = ImageLayout.Stretch;
            btShowPassword2.Location = new Point(259, 328);
            btShowPassword2.Margin = new Padding(4, 3, 4, 3);
            btShowPassword2.Name = "btShowPassword2";
            btShowPassword2.Size = new Size(27, 23);
            btShowPassword2.TabIndex = 17;
            btShowPassword2.UseVisualStyleBackColor = true;
            btShowPassword2.Click += btShowPassword_Click;
            btShowPassword2.KeyUp += btShowPassword2_KeyUp;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Location = new Point(124, 309);
            lblConfirmPassword.Margin = new Padding(4, 0, 4, 0);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(157, 15);
            lblConfirmPassword.TabIndex = 16;
            lblConfirmPassword.Text = "Confirmation Mot de passe :";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(128, 328);
            txtConfirmPassword.Margin = new Padding(4, 3, 4, 3);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(158, 23);
            txtConfirmPassword.TabIndex = 5;
            txtConfirmPassword.KeyUp += txtConfirmPassword_KeyUp;
            // 
            // btSignUp
            // 
            btSignUp.Location = new Point(125, 386);
            btSignUp.Margin = new Padding(4, 3, 4, 3);
            btSignUp.Name = "btSignUp";
            btSignUp.Size = new Size(159, 27);
            btSignUp.TabIndex = 6;
            btSignUp.Text = "S'enregistrer";
            btSignUp.UseVisualStyleBackColor = true;
            btSignUp.Click += btSignUp_Click;
            // 
            // FormSignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 509);
            Controls.Add(btSignUp);
            Controls.Add(btShowPassword2);
            Controls.Add(lblConfirmPassword);
            Controls.Add(txtConfirmPassword);
            Controls.Add(btShowPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblTitle);
            Margin = new Padding(4, 3, 4, 3);
            MaximumSize = new Size(429, 548);
            MinimumSize = new Size(429, 548);
            Name = "FormSignUp";
            Text = "FormSignUp";
            KeyUp += FormSignUp_KeyUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btShowPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btShowPassword2;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Button btSignUp;
    }
}