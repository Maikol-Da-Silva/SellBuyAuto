namespace SellBuyAuto
{
    partial class UcHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcHome));
            pbTitle = new PictureBox();
            pnQuickSearch = new Panel();
            lblModel = new Label();
            lblQuickSearch = new Label();
            lblBrand = new Label();
            cbBrand = new ComboBox();
            numPrice = new NumericUpDown();
            cbModel = new ComboBox();
            numYear = new NumericUpDown();
            btAdvancedSearch = new Button();
            lblPrice = new Label();
            btSearch = new Button();
            lblYear = new Label();
            ((System.ComponentModel.ISupportInitialize)pbTitle).BeginInit();
            pnQuickSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numYear).BeginInit();
            SuspendLayout();
            // 
            // pbTitle
            // 
            pbTitle.BackColor = Color.Transparent;
            pbTitle.Image = (Image)resources.GetObject("pbTitle.Image");
            pbTitle.Location = new Point(359, 64);
            pbTitle.Name = "pbTitle";
            pbTitle.Size = new Size(473, 76);
            pbTitle.SizeMode = PictureBoxSizeMode.StretchImage;
            pbTitle.TabIndex = 20;
            pbTitle.TabStop = false;
            // 
            // pnQuickSearch
            // 
            pnQuickSearch.BackColor = Color.FromArgb(157, 110, 74);
            pnQuickSearch.BorderStyle = BorderStyle.FixedSingle;
            pnQuickSearch.Controls.Add(lblModel);
            pnQuickSearch.Controls.Add(lblQuickSearch);
            pnQuickSearch.Controls.Add(lblBrand);
            pnQuickSearch.Controls.Add(cbBrand);
            pnQuickSearch.Controls.Add(numPrice);
            pnQuickSearch.Controls.Add(cbModel);
            pnQuickSearch.Controls.Add(numYear);
            pnQuickSearch.Controls.Add(btAdvancedSearch);
            pnQuickSearch.Controls.Add(lblPrice);
            pnQuickSearch.Controls.Add(btSearch);
            pnQuickSearch.Controls.Add(lblYear);
            pnQuickSearch.Location = new Point(86, 195);
            pnQuickSearch.Name = "pnQuickSearch";
            pnQuickSearch.Size = new Size(1008, 281);
            pnQuickSearch.TabIndex = 21;
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.ForeColor = SystemColors.ControlLightLight;
            lblModel.Location = new Point(335, 102);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(53, 15);
            lblModel.TabIndex = 12;
            lblModel.Text = "Modèle :";
            // 
            // lblQuickSearch
            // 
            lblQuickSearch.AutoSize = true;
            lblQuickSearch.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuickSearch.ForeColor = SystemColors.ControlLightLight;
            lblQuickSearch.Location = new Point(3, 13);
            lblQuickSearch.Name = "lblQuickSearch";
            lblQuickSearch.Size = new Size(238, 37);
            lblQuickSearch.TabIndex = 0;
            lblQuickSearch.Text = "Recherche rapide";
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.ForeColor = SystemColors.ControlLightLight;
            lblBrand.Location = new Point(134, 102);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(54, 15);
            lblBrand.TabIndex = 11;
            lblBrand.Text = "Marque :";
            // 
            // cbBrand
            // 
            cbBrand.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBrand.FormattingEnabled = true;
            cbBrand.Items.AddRange(new object[] { "Tous" });
            cbBrand.Location = new Point(134, 120);
            cbBrand.MaxDropDownItems = 100;
            cbBrand.Name = "cbBrand";
            cbBrand.Size = new Size(121, 23);
            cbBrand.TabIndex = 1;
            cbBrand.SelectedIndexChanged += cbBrand_SelectedIndexChanged;
            // 
            // numPrice
            // 
            numPrice.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            numPrice.Location = new Point(737, 121);
            numPrice.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numPrice.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(120, 23);
            numPrice.TabIndex = 4;
            numPrice.Value = new decimal(new int[] { 50000, 0, 0, 0 });
            // 
            // cbModel
            // 
            cbModel.DropDownStyle = ComboBoxStyle.DropDownList;
            cbModel.FormattingEnabled = true;
            cbModel.Items.AddRange(new object[] { "Tous" });
            cbModel.Location = new Point(335, 120);
            cbModel.MaxDropDownItems = 100;
            cbModel.Name = "cbModel";
            cbModel.Size = new Size(121, 23);
            cbModel.TabIndex = 2;
            // 
            // numYear
            // 
            numYear.Location = new Point(538, 121);
            numYear.Maximum = new decimal(new int[] { 2024, 0, 0, 0 });
            numYear.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            numYear.Name = "numYear";
            numYear.Size = new Size(120, 23);
            numYear.TabIndex = 3;
            numYear.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            // 
            // btAdvancedSearch
            // 
            btAdvancedSearch.Location = new Point(40, 219);
            btAdvancedSearch.Name = "btAdvancedSearch";
            btAdvancedSearch.Size = new Size(148, 23);
            btAdvancedSearch.TabIndex = 6;
            btAdvancedSearch.Text = "Recherche avancée";
            btAdvancedSearch.UseVisualStyleBackColor = true;
            btAdvancedSearch.Click += btAdvancedSearch_Click;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.ForeColor = SystemColors.ControlLightLight;
            lblPrice.Location = new Point(737, 102);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(74, 15);
            lblPrice.TabIndex = 8;
            lblPrice.Text = "Prix jusqu'à :";
            // 
            // btSearch
            // 
            btSearch.Location = new Point(897, 219);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(75, 23);
            btSearch.TabIndex = 5;
            btSearch.Text = "Rechercher";
            btSearch.UseVisualStyleBackColor = true;
            btSearch.Click += btSearch_Click;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.ForeColor = SystemColors.ControlLightLight;
            lblYear.Location = new Point(538, 102);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(63, 15);
            lblYear.TabIndex = 7;
            lblYear.Text = "Année de :";
            // 
            // UcHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(pnQuickSearch);
            Controls.Add(pbTitle);
            MaximumSize = new Size(1184, 607);
            MinimumSize = new Size(1184, 607);
            Name = "UcHome";
            Size = new Size(1184, 607);
            Load += UcHome_Load;
            ((System.ComponentModel.ISupportInitialize)pbTitle).EndInit();
            pnQuickSearch.ResumeLayout(false);
            pnQuickSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numYear).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pbTitle;
        private Panel pnQuickSearch;
        private Label lblModel;
        private Label lblQuickSearch;
        private Label lblBrand;
        private ComboBox cbBrand;
        private NumericUpDown numPrice;
        private ComboBox cbModel;
        private NumericUpDown numYear;
        private Button btAdvancedSearch;
        private Label lblPrice;
        private Button btSearch;
        private Label lblYear;
    }
}
