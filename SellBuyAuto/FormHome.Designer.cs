namespace SellBuyAuto
{
    partial class formHome
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
            gbQuickSearch = new GroupBox();
            btSearch = new Button();
            btAdvancedSearch = new Button();
            cbPrice = new ComboBox();
            cbYear = new ComboBox();
            cbModel = new ComboBox();
            cbBrand = new ComboBox();
            lblQuickSearch = new Label();
            label1 = new Label();
            lblUsername = new Label();
            menuStripWithoutLogin.SuspendLayout();
            menuStripWithLogin.SuspendLayout();
            gbQuickSearch.SuspendLayout();
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
            // 
            // rechercherToolStripMenuItem
            // 
            rechercherToolStripMenuItem.Name = "rechercherToolStripMenuItem";
            rechercherToolStripMenuItem.Size = new Size(78, 20);
            rechercherToolStripMenuItem.Text = "Rechercher";
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
            // 
            // rechercherToolStripMenuItem1
            // 
            rechercherToolStripMenuItem1.Name = "rechercherToolStripMenuItem1";
            rechercherToolStripMenuItem1.Size = new Size(78, 20);
            rechercherToolStripMenuItem1.Text = "Rechercher";
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
            // gbQuickSearch
            // 
            gbQuickSearch.Controls.Add(btSearch);
            gbQuickSearch.Controls.Add(btAdvancedSearch);
            gbQuickSearch.Controls.Add(cbPrice);
            gbQuickSearch.Controls.Add(cbYear);
            gbQuickSearch.Controls.Add(cbModel);
            gbQuickSearch.Controls.Add(cbBrand);
            gbQuickSearch.Controls.Add(lblQuickSearch);
            gbQuickSearch.Location = new Point(79, 168);
            gbQuickSearch.Name = "gbQuickSearch";
            gbQuickSearch.Size = new Size(1008, 281);
            gbQuickSearch.TabIndex = 3;
            gbQuickSearch.TabStop = false;
            // 
            // btSearch
            // 
            btSearch.Location = new Point(900, 225);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(75, 23);
            btSearch.TabIndex = 6;
            btSearch.Text = "Rechercher";
            btSearch.UseVisualStyleBackColor = true;
            // 
            // btAdvancedSearch
            // 
            btAdvancedSearch.Location = new Point(43, 225);
            btAdvancedSearch.Name = "btAdvancedSearch";
            btAdvancedSearch.Size = new Size(120, 23);
            btAdvancedSearch.TabIndex = 5;
            btAdvancedSearch.Text = "Recherche avancée";
            btAdvancedSearch.UseVisualStyleBackColor = true;
            // 
            // cbPrice
            // 
            cbPrice.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPrice.FormattingEnabled = true;
            cbPrice.Items.AddRange(new object[] { "Prix jusqu'à" });
            cbPrice.Location = new Point(740, 126);
            cbPrice.Name = "cbPrice";
            cbPrice.Size = new Size(121, 23);
            cbPrice.TabIndex = 4;
            // 
            // cbYear
            // 
            cbYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cbYear.FormattingEnabled = true;
            cbYear.Items.AddRange(new object[] { "Année de" });
            cbYear.Location = new Point(541, 126);
            cbYear.Name = "cbYear";
            cbYear.Size = new Size(121, 23);
            cbYear.TabIndex = 3;
            // 
            // cbModel
            // 
            cbModel.DropDownStyle = ComboBoxStyle.DropDownList;
            cbModel.FormattingEnabled = true;
            cbModel.Items.AddRange(new object[] { "Modèle" });
            cbModel.Location = new Point(338, 126);
            cbModel.Name = "cbModel";
            cbModel.Size = new Size(121, 23);
            cbModel.TabIndex = 2;
            // 
            // cbBrand
            // 
            cbBrand.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBrand.FormattingEnabled = true;
            cbBrand.Items.AddRange(new object[] { "Marque" });
            cbBrand.Location = new Point(137, 126);
            cbBrand.Name = "cbBrand";
            cbBrand.Size = new Size(121, 23);
            cbBrand.Sorted = true;
            cbBrand.TabIndex = 1;
            // 
            // lblQuickSearch
            // 
            lblQuickSearch.AutoSize = true;
            lblQuickSearch.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuickSearch.Location = new Point(6, 19);
            lblQuickSearch.Name = "lblQuickSearch";
            lblQuickSearch.Size = new Size(238, 37);
            lblQuickSearch.TabIndex = 0;
            lblQuickSearch.Text = "Recherche rapide";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(354, 47);
            label1.Name = "label1";
            label1.Size = new Size(486, 82);
            label1.TabIndex = 7;
            label1.Text = "SellBuyAuto";
            // 
            // lblUsername
            // 
            lblUsername.Location = new Point(882, 27);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(187, 23);
            lblUsername.TabIndex = 8;
            lblUsername.TextAlign = ContentAlignment.MiddleRight;
            // 
            // formHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 661);
            Controls.Add(lblUsername);
            Controls.Add(label1);
            Controls.Add(gbQuickSearch);
            Controls.Add(btLogin);
            Controls.Add(menuStripWithoutLogin);
            Controls.Add(menuStripWithLogin);
            MainMenuStrip = menuStripWithoutLogin;
            MaximumSize = new Size(1200, 700);
            MinimumSize = new Size(1200, 700);
            Name = "formHome";
            Text = "SellBuyAuto";
            Load += formHome_Load;
            menuStripWithoutLogin.ResumeLayout(false);
            menuStripWithoutLogin.PerformLayout();
            menuStripWithLogin.ResumeLayout(false);
            menuStripWithLogin.PerformLayout();
            gbQuickSearch.ResumeLayout(false);
            gbQuickSearch.PerformLayout();
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
        private GroupBox gbQuickSearch;
        private ComboBox cbPrice;
        private ComboBox cbYear;
        private ComboBox cbModel;
        private ComboBox cbBrand;
        private Label lblQuickSearch;
        private Button btSearch;
        private Button btAdvancedSearch;
        private Label label1;
        private Label lblUsername;
    }
}
