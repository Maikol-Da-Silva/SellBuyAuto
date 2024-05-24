namespace SellBuyAuto.UserConstrols
{
    partial class UcLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcLogin));
            pnBackGround = new Panel();
            pbTitle = new PictureBox();
            groupBox1 = new GroupBox();
            lblUsername = new Label();
            lblSignUp = new Label();
            txtUsername = new TextBox();
            btShowPassword = new Button();
            txtPassword = new TextBox();
            btLogin = new Button();
            label1 = new Label();
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
            pnBackGround.Location = new Point(377, 27);
            pnBackGround.MaximumSize = new Size(429, 548);
            pnBackGround.MinimumSize = new Size(429, 548);
            pnBackGround.Name = "pnBackGround";
            pnBackGround.Size = new Size(429, 548);
            pnBackGround.TabIndex = 0;
            // 
            // pbTitle
            // 
            pbTitle.BackColor = Color.White;
            pbTitle.Image = (Image)resources.GetObject("pbTitle.Image");
            pbTitle.Location = new Point(110, 78);
            pbTitle.Name = "pbTitle";
            pbTitle.Size = new Size(206, 35);
            pbTitle.SizeMode = PictureBoxSizeMode.StretchImage;
            pbTitle.TabIndex = 22;
            pbTitle.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Linen;
            groupBox1.Controls.Add(lblUsername);
            groupBox1.Controls.Add(lblSignUp);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Controls.Add(btShowPassword);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(btLogin);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(114, 171);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 283);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(17, 32);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(145, 15);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Nom d'utilisateur / Email :";
            // 
            // lblSignUp
            // 
            lblSignUp.AutoSize = true;
            lblSignUp.Cursor = Cursors.Hand;
            lblSignUp.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblSignUp.Location = new Point(65, 263);
            lblSignUp.Margin = new Padding(4, 0, 4, 0);
            lblSignUp.Name = "lblSignUp";
            lblSignUp.Size = new Size(65, 13);
            lblSignUp.TabIndex = 7;
            lblSignUp.Text = "S'enregistrer";
            lblSignUp.Click += lblSignUp_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(20, 50);
            txtUsername.Margin = new Padding(4, 3, 4, 3);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(158, 23);
            txtUsername.TabIndex = 0;
            txtUsername.KeyDown += txtUsername_KeyDown;
            // 
            // btShowPassword
            // 
            btShowPassword.BackgroundImage = Properties.Resources.ShowPassword;
            btShowPassword.BackgroundImageLayout = ImageLayout.Stretch;
            btShowPassword.Location = new Point(152, 140);
            btShowPassword.Margin = new Padding(4, 3, 4, 3);
            btShowPassword.Name = "btShowPassword";
            btShowPassword.Size = new Size(27, 23);
            btShowPassword.TabIndex = 6;
            btShowPassword.UseVisualStyleBackColor = true;
            btShowPassword.Click += btShowPassword_Click;
            btShowPassword.Enter += btShowPassword_Enter;
            btShowPassword.KeyDown += txtUsername_KeyDown;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(20, 140);
            txtPassword.Margin = new Padding(4, 3, 4, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(158, 23);
            txtPassword.TabIndex = 2;
            txtPassword.KeyDown += txtUsername_KeyDown;
            // 
            // btLogin
            // 
            btLogin.Location = new Point(20, 219);
            btLogin.Margin = new Padding(4, 3, 4, 3);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(159, 27);
            btLogin.TabIndex = 5;
            btLogin.Text = "Login";
            btLogin.UseVisualStyleBackColor = true;
            btLogin.Click += btLogin_Click;
            btLogin.KeyDown += txtUsername_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 122);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 3;
            label1.Text = "Mot de passe :";
            // 
            // UcLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pnBackGround);
            MaximumSize = new Size(1184, 607);
            MinimumSize = new Size(1184, 607);
            Name = "UcLogin";
            Size = new Size(1184, 607);
            Enter += UcLogin_Enter;
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
        private Label lblUsername;
        private Label lblSignUp;
        private TextBox txtUsername;
        private Button btShowPassword;
        private TextBox txtPassword;
        private Button btLogin;
        private Label label1;
    }
}
