namespace SellBuyAuto
{
    partial class FormMain
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
            menuStripWithoutLogin = new MenuStrip();
            accueilToolStripMenuItem = new ToolStripMenuItem();
            rechercherToolStripMenuItem = new ToolStripMenuItem();
            menuStripWithLogin = new MenuStrip();
            accueilToolStripMenuItem1 = new ToolStripMenuItem();
            rechercherToolStripMenuItem1 = new ToolStripMenuItem();
            favorisToolStripMenuItem = new ToolStripMenuItem();
            vendreToolStripMenuItem = new ToolStripMenuItem();
            mesVentesToolStripMenuItem = new ToolStripMenuItem();
            mesAchatsToolStripMenuItem = new ToolStripMenuItem();
            btLogin = new Button();
            lblUsername = new Label();
            menuStripWithoutLogin.SuspendLayout();
            menuStripWithLogin.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripWithoutLogin
            // 
            menuStripWithoutLogin.Items.AddRange(new ToolStripItem[] { accueilToolStripMenuItem, rechercherToolStripMenuItem });
            menuStripWithoutLogin.Location = new Point(0, 0);
            menuStripWithoutLogin.Name = "menuStripWithoutLogin";
            menuStripWithoutLogin.Size = new Size(1184, 24);
            menuStripWithoutLogin.TabIndex = 0;
            menuStripWithoutLogin.Text = "menuStrip1";
            // 
            // accueilToolStripMenuItem
            // 
            accueilToolStripMenuItem.Name = "accueilToolStripMenuItem";
            accueilToolStripMenuItem.Size = new Size(58, 20);
            accueilToolStripMenuItem.Text = "Accueil";
            accueilToolStripMenuItem.Click += accueilToolStripMenuItem_Click;
            // 
            // rechercherToolStripMenuItem
            // 
            rechercherToolStripMenuItem.Name = "rechercherToolStripMenuItem";
            rechercherToolStripMenuItem.Size = new Size(78, 20);
            rechercherToolStripMenuItem.Text = "Rechercher";
            rechercherToolStripMenuItem.Click += rechercherToolStripMenuItem_Click;
            // 
            // menuStripWithLogin
            // 
            menuStripWithLogin.Enabled = false;
            menuStripWithLogin.Items.AddRange(new ToolStripItem[] { accueilToolStripMenuItem1, rechercherToolStripMenuItem1, favorisToolStripMenuItem, vendreToolStripMenuItem, mesVentesToolStripMenuItem, mesAchatsToolStripMenuItem });
            menuStripWithLogin.Location = new Point(0, 0);
            menuStripWithLogin.Name = "menuStripWithLogin";
            menuStripWithLogin.Size = new Size(1184, 24);
            menuStripWithLogin.TabIndex = 1;
            menuStripWithLogin.Text = "menuStrip1";
            menuStripWithLogin.Visible = false;
            // 
            // accueilToolStripMenuItem1
            // 
            accueilToolStripMenuItem1.Name = "accueilToolStripMenuItem1";
            accueilToolStripMenuItem1.Size = new Size(58, 20);
            accueilToolStripMenuItem1.Text = "Accueil";
            accueilToolStripMenuItem1.Click += accueilToolStripMenuItem1_Click;
            // 
            // rechercherToolStripMenuItem1
            // 
            rechercherToolStripMenuItem1.Name = "rechercherToolStripMenuItem1";
            rechercherToolStripMenuItem1.Size = new Size(78, 20);
            rechercherToolStripMenuItem1.Text = "Rechercher";
            rechercherToolStripMenuItem1.Click += rechercherToolStripMenuItem1_Click;
            // 
            // favorisToolStripMenuItem
            // 
            favorisToolStripMenuItem.Name = "favorisToolStripMenuItem";
            favorisToolStripMenuItem.Size = new Size(56, 20);
            favorisToolStripMenuItem.Text = "Favoris";
            // 
            // vendreToolStripMenuItem
            // 
            vendreToolStripMenuItem.Name = "vendreToolStripMenuItem";
            vendreToolStripMenuItem.Size = new Size(55, 20);
            vendreToolStripMenuItem.Text = "Vendre";
            // 
            // mesVentesToolStripMenuItem
            // 
            mesVentesToolStripMenuItem.Name = "mesVentesToolStripMenuItem";
            mesVentesToolStripMenuItem.Size = new Size(78, 20);
            mesVentesToolStripMenuItem.Text = "Mes ventes";
            // 
            // mesAchatsToolStripMenuItem
            // 
            mesAchatsToolStripMenuItem.Name = "mesAchatsToolStripMenuItem";
            mesAchatsToolStripMenuItem.Size = new Size(78, 20);
            mesAchatsToolStripMenuItem.Text = "Mes achats";
            // 
            // btLogin
            // 
            btLogin.Location = new Point(1075, 27);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(97, 23);
            btLogin.TabIndex = 2;
            btLogin.Text = "Se connecter";
            btLogin.UseVisualStyleBackColor = true;
            btLogin.Click += btLogin_Click;
            // 
            // lblUsername
            // 
            lblUsername.Location = new Point(882, 27);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(187, 23);
            lblUsername.TabIndex = 8;
            lblUsername.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 661);
            Controls.Add(lblUsername);
            Controls.Add(btLogin);
            Controls.Add(menuStripWithoutLogin);
            Controls.Add(menuStripWithLogin);
            MainMenuStrip = menuStripWithoutLogin;
            MaximumSize = new Size(1200, 700);
            MinimumSize = new Size(1200, 700);
            Name = "FormMain";
            Text = "SellBuyAuto";
            Load += FormMain_Load;
            menuStripWithoutLogin.ResumeLayout(false);
            menuStripWithoutLogin.PerformLayout();
            menuStripWithLogin.ResumeLayout(false);
            menuStripWithLogin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripWithoutLogin;
        private ToolStripMenuItem accueilToolStripMenuItem;
        private ToolStripMenuItem rechercherToolStripMenuItem;
        private MenuStrip menuStripWithLogin;
        private ToolStripMenuItem accueilToolStripMenuItem1;
        private ToolStripMenuItem rechercherToolStripMenuItem1;
        private ToolStripMenuItem favorisToolStripMenuItem;
        private ToolStripMenuItem vendreToolStripMenuItem;
        private ToolStripMenuItem mesVentesToolStripMenuItem;
        private ToolStripMenuItem mesAchatsToolStripMenuItem;
        private Button btLogin;
        private Label lblUsername;
    }
}
