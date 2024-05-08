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
            label1 = new Label();
            gbQuickSearch = new GroupBox();
            lblModel = new Label();
            lblBrand = new Label();
            numPrice = new NumericUpDown();
            numYear = new NumericUpDown();
            lblPrice = new Label();
            lblYear = new Label();
            btSearch = new Button();
            btAdvancedSearch = new Button();
            cbModel = new ComboBox();
            cbBrand = new ComboBox();
            lblQuickSearch = new Label();
            gbQuickSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numYear).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(353, 83);
            label1.Name = "label1";
            label1.Size = new Size(486, 82);
            label1.TabIndex = 9;
            label1.Text = "SellBuyAuto";
            // 
            // gbQuickSearch
            // 
            gbQuickSearch.Controls.Add(lblModel);
            gbQuickSearch.Controls.Add(lblBrand);
            gbQuickSearch.Controls.Add(numPrice);
            gbQuickSearch.Controls.Add(numYear);
            gbQuickSearch.Controls.Add(lblPrice);
            gbQuickSearch.Controls.Add(lblYear);
            gbQuickSearch.Controls.Add(btSearch);
            gbQuickSearch.Controls.Add(btAdvancedSearch);
            gbQuickSearch.Controls.Add(cbModel);
            gbQuickSearch.Controls.Add(cbBrand);
            gbQuickSearch.Controls.Add(lblQuickSearch);
            gbQuickSearch.Location = new Point(78, 204);
            gbQuickSearch.Name = "gbQuickSearch";
            gbQuickSearch.Size = new Size(1008, 281);
            gbQuickSearch.TabIndex = 8;
            gbQuickSearch.TabStop = false;
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(338, 108);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(53, 15);
            lblModel.TabIndex = 12;
            lblModel.Text = "Modèle :";
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Location = new Point(137, 108);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(54, 15);
            lblBrand.TabIndex = 11;
            lblBrand.Text = "Marque :";
            // 
            // numPrice
            // 
            numPrice.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            numPrice.Location = new Point(740, 127);
            numPrice.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numPrice.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(120, 23);
            numPrice.TabIndex = 10;
            numPrice.Value = new decimal(new int[] { 50000, 0, 0, 0 });
            // 
            // numYear
            // 
            numYear.Location = new Point(541, 127);
            numYear.Maximum = new decimal(new int[] { 2024, 0, 0, 0 });
            numYear.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            numYear.Name = "numYear";
            numYear.Size = new Size(120, 23);
            numYear.TabIndex = 9;
            numYear.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(740, 108);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(74, 15);
            lblPrice.TabIndex = 8;
            lblPrice.Text = "Prix jusqu'à :";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(541, 108);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(63, 15);
            lblYear.TabIndex = 7;
            lblYear.Text = "Année de :";
            // 
            // btSearch
            // 
            btSearch.Location = new Point(900, 225);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(75, 23);
            btSearch.TabIndex = 6;
            btSearch.Text = "Rechercher";
            btSearch.UseVisualStyleBackColor = true;
            btSearch.Click += btSearch_Click;
            // 
            // btAdvancedSearch
            // 
            btAdvancedSearch.Location = new Point(43, 225);
            btAdvancedSearch.Name = "btAdvancedSearch";
            btAdvancedSearch.Size = new Size(120, 23);
            btAdvancedSearch.TabIndex = 5;
            btAdvancedSearch.Text = "Recherche avancée";
            btAdvancedSearch.UseVisualStyleBackColor = true;
            btAdvancedSearch.Click += btAdvancedSearch_Click;
            // 
            // cbModel
            // 
            cbModel.DropDownStyle = ComboBoxStyle.DropDownList;
            cbModel.FormattingEnabled = true;
            cbModel.Items.AddRange(new object[] { "Tous" });
            cbModel.Location = new Point(338, 126);
            cbModel.MaxDropDownItems = 100;
            cbModel.Name = "cbModel";
            cbModel.Size = new Size(121, 23);
            cbModel.TabIndex = 2;
            // 
            // cbBrand
            // 
            cbBrand.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBrand.FormattingEnabled = true;
            cbBrand.Items.AddRange(new object[] { "Tous" });
            cbBrand.Location = new Point(137, 126);
            cbBrand.MaxDropDownItems = 100;
            cbBrand.Name = "cbBrand";
            cbBrand.Size = new Size(121, 23);
            cbBrand.TabIndex = 1;
            cbBrand.SelectedIndexChanged += cbBrand_SelectedIndexChanged;
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
            // UcHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(gbQuickSearch);
            MaximumSize = new Size(1184, 607);
            MinimumSize = new Size(1184, 607);
            Name = "UcHome";
            Size = new Size(1184, 607);
            Load += UcHome_Load;
            gbQuickSearch.ResumeLayout(false);
            gbQuickSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numYear).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox gbQuickSearch;
        private Button btSearch;
        private Button btAdvancedSearch;
        private ComboBox cbModel;
        private ComboBox cbBrand;
        private Label lblQuickSearch;
        private NumericUpDown numYear;
        private Label lblPrice;
        private Label lblYear;
        private Label lblModel;
        private Label lblBrand;
        private NumericUpDown numPrice;
    }
}
