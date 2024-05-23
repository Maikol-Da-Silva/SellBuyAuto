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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSignUp));
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
            groupBox1 = new GroupBox();
            pbTitle = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbTitle).BeginInit();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(18, 32);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(42, 15);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Email :";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(22, 51);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(158, 23);
            txtEmail.TabIndex = 2;
            txtEmail.KeyDown += FormSignUp_KeyUp;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(18, 92);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(105, 15);
            lblUsername.TabIndex = 11;
            lblUsername.Text = "Nom d'utilisateur :";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(22, 111);
            txtUsername.Margin = new Padding(4, 3, 4, 3);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(158, 23);
            txtUsername.TabIndex = 3;
            txtUsername.KeyDown += FormSignUp_KeyUp;
            // 
            // btShowPassword
            // 
            btShowPassword.BackgroundImage = Properties.Resources.ShowPassword;
            btShowPassword.BackgroundImageLayout = ImageLayout.Stretch;
            btShowPassword.Location = new Point(153, 172);
            btShowPassword.Margin = new Padding(4, 3, 4, 3);
            btShowPassword.Name = "btShowPassword";
            btShowPassword.Size = new Size(27, 23);
            btShowPassword.TabIndex = 14;
            btShowPassword.UseVisualStyleBackColor = true;
            btShowPassword.Click += btShowPassword_Click;
            btShowPassword.Enter += btShowPassword_Enter;
            btShowPassword.KeyDown += FormSignUp_KeyUp;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(18, 154);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(83, 15);
            lblPassword.TabIndex = 13;
            lblPassword.Text = "Mot de passe :";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(22, 172);
            txtPassword.Margin = new Padding(4, 3, 4, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(158, 23);
            txtPassword.TabIndex = 4;
            txtPassword.KeyDown += FormSignUp_KeyUp;
            // 
            // btShowPassword2
            // 
            btShowPassword2.BackgroundImage = Properties.Resources.ShowPassword;
            btShowPassword2.BackgroundImageLayout = ImageLayout.Stretch;
            btShowPassword2.Location = new Point(153, 237);
            btShowPassword2.Margin = new Padding(4, 3, 4, 3);
            btShowPassword2.Name = "btShowPassword2";
            btShowPassword2.Size = new Size(27, 23);
            btShowPassword2.TabIndex = 17;
            btShowPassword2.UseVisualStyleBackColor = true;
            btShowPassword2.Click += btShowPassword_Click;
            btShowPassword2.Enter += btShowPassword2_Enter;
            btShowPassword2.KeyDown += FormSignUp_KeyUp;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Location = new Point(18, 218);
            lblConfirmPassword.Margin = new Padding(4, 0, 4, 0);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(157, 15);
            lblConfirmPassword.TabIndex = 16;
            lblConfirmPassword.Text = "Confirmation Mot de passe :";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(22, 237);
            txtConfirmPassword.Margin = new Padding(4, 3, 4, 3);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(158, 23);
            txtConfirmPassword.TabIndex = 5;
            txtConfirmPassword.KeyDown += FormSignUp_KeyUp;
            // 
            // btSignUp
            // 
            btSignUp.Location = new Point(19, 295);
            btSignUp.Margin = new Padding(4, 3, 4, 3);
            btSignUp.Name = "btSignUp";
            btSignUp.Size = new Size(159, 27);
            btSignUp.TabIndex = 6;
            btSignUp.Text = "S'enregistrer";
            btSignUp.UseVisualStyleBackColor = true;
            btSignUp.Click += btSignUp_Click;
            btSignUp.KeyDown += FormSignUp_KeyUp;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.WhiteSmoke;
            groupBox1.Controls.Add(btShowPassword);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(btSignUp);
            groupBox1.Controls.Add(lblEmail);
            groupBox1.Controls.Add(btShowPassword2);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Controls.Add(lblConfirmPassword);
            groupBox1.Controls.Add(lblUsername);
            groupBox1.Controls.Add(txtConfirmPassword);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(lblPassword);
            groupBox1.Location = new Point(107, 109);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 332);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            // 
            // pbTitle
            // 
            pbTitle.BackColor = Color.White;
            pbTitle.Image = (Image)resources.GetObject("pbTitle.Image");
            pbTitle.Location = new Point(106, 38);
            pbTitle.Name = "pbTitle";
            pbTitle.Size = new Size(206, 35);
            pbTitle.SizeMode = PictureBoxSizeMode.StretchImage;
            pbTitle.TabIndex = 19;
            pbTitle.TabStop = false;
            // 
            // FormSignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1000_F_336826195_T0kFSG8IDzzALG0V3gSNkJBtuVlBuUTE;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(413, 509);
            Controls.Add(pbTitle);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 3, 4, 3);
            MaximumSize = new Size(429, 548);
            MinimumSize = new Size(429, 548);
            Name = "FormSignUp";
            Text = "FormSignUp";
            KeyDown += FormSignUp_KeyUp;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbTitle).EndInit();
            ResumeLayout(false);
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
        private GroupBox groupBox1;
        private PictureBox pbTitle;
    }
}