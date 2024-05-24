namespace SellBuyAuto.UserConstrols
{
    partial class UcSignUp
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcSignUp));
            pnBackGround = new Panel();
            pbTitle = new PictureBox();
            groupBox1 = new GroupBox();
            btShowPassword = new Button();
            txtEmail = new TextBox();
            btSignUp = new Button();
            lblEmail = new Label();
            btShowPassword2 = new Button();
            txtUsername = new TextBox();
            lblConfirmPassword = new Label();
            lblUsername = new Label();
            txtConfirmPassword = new TextBox();
            txtPassword = new TextBox();
            lblPassword = new Label();
            pnBackGround.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbTitle).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pnBackGround
            // 
            pnBackGround.BackgroundImage = Properties.Resources._1000_F_336826195_T0kFSG8IDzzALG0V3gSNkJBtuVlBuUTE;
            pnBackGround.BackgroundImageLayout = ImageLayout.Stretch;
            pnBackGround.BorderStyle = BorderStyle.FixedSingle;
            pnBackGround.Controls.Add(pbTitle);
            pnBackGround.Controls.Add(groupBox1);
            pnBackGround.Location = new Point(378, 29);
            pnBackGround.MaximumSize = new Size(429, 548);
            pnBackGround.MinimumSize = new Size(429, 548);
            pnBackGround.Name = "pnBackGround";
            pnBackGround.Size = new Size(429, 548);
            pnBackGround.TabIndex = 1;
            // 
            // pbTitle
            // 
            pbTitle.BackColor = Color.White;
            pbTitle.Image = (Image)resources.GetObject("pbTitle.Image");
            pbTitle.Location = new Point(115, 73);
            pbTitle.Name = "pbTitle";
            pbTitle.Size = new Size(206, 35);
            pbTitle.SizeMode = PictureBoxSizeMode.StretchImage;
            pbTitle.TabIndex = 21;
            pbTitle.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Linen;
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
            groupBox1.Location = new Point(116, 144);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 332);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
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
            btShowPassword.KeyDown += txtEmail_KeyDown;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(22, 51);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(158, 23);
            txtEmail.TabIndex = 2;
            txtEmail.KeyDown += txtEmail_KeyDown;
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
            btSignUp.KeyDown += txtEmail_KeyDown;
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
            btShowPassword2.KeyDown += txtEmail_KeyDown;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(22, 111);
            txtUsername.Margin = new Padding(4, 3, 4, 3);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(158, 23);
            txtUsername.TabIndex = 3;
            txtUsername.KeyDown += txtEmail_KeyDown;
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
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(22, 237);
            txtConfirmPassword.Margin = new Padding(4, 3, 4, 3);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(158, 23);
            txtConfirmPassword.TabIndex = 5;
            txtConfirmPassword.KeyDown += txtEmail_KeyDown;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(22, 172);
            txtPassword.Margin = new Padding(4, 3, 4, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(158, 23);
            txtPassword.TabIndex = 4;
            txtPassword.KeyDown += txtEmail_KeyDown;
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
            // UcSignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pnBackGround);
            MaximumSize = new Size(1184, 607);
            MinimumSize = new Size(1184, 607);
            Name = "UcSignUp";
            Size = new Size(1184, 607);
            pnBackGround.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbTitle).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnBackGround;
        private PictureBox pbTitle;
        private GroupBox groupBox1;
        private Button btShowPassword;
        private TextBox txtEmail;
        private Button btSignUp;
        private Label lblEmail;
        private Button btShowPassword2;
        private TextBox txtUsername;
        private Label lblConfirmPassword;
        private Label lblUsername;
        private TextBox txtConfirmPassword;
        private TextBox txtPassword;
        private Label lblPassword;
    }
}
