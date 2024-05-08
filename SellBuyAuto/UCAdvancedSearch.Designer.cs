namespace SellBuyAuto
{
    partial class UCAdvancedSearch
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
            gbAdvancedSearch = new GroupBox();
            btSearch = new Button();
            gbPrice = new GroupBox();
            numPriceTo = new NumericUpDown();
            numPriceFrom = new NumericUpDown();
            lblPriceTo = new Label();
            lblPriceFrom = new Label();
            cbMileage = new GroupBox();
            numMileageTo = new NumericUpDown();
            numMileageFrom = new NumericUpDown();
            lblMileageTo = new Label();
            lblMileageFrom = new Label();
            gbYear = new GroupBox();
            numYearTo = new NumericUpDown();
            numYearFrom = new NumericUpDown();
            lblYearTo = new Label();
            lblYearFrom = new Label();
            lblEngineType = new Label();
            lblModel = new Label();
            lblBrand = new Label();
            cbEngineType = new ComboBox();
            cbModel = new ComboBox();
            cbBrand = new ComboBox();
            lblAdvancedSearch = new Label();
            gbAdvancedSearch.SuspendLayout();
            gbPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPriceTo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPriceFrom).BeginInit();
            cbMileage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMileageTo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMileageFrom).BeginInit();
            gbYear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numYearTo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numYearFrom).BeginInit();
            SuspendLayout();
            // 
            // gbAdvancedSearch
            // 
            gbAdvancedSearch.Controls.Add(btSearch);
            gbAdvancedSearch.Controls.Add(gbPrice);
            gbAdvancedSearch.Controls.Add(cbMileage);
            gbAdvancedSearch.Controls.Add(gbYear);
            gbAdvancedSearch.Controls.Add(lblEngineType);
            gbAdvancedSearch.Controls.Add(lblModel);
            gbAdvancedSearch.Controls.Add(lblBrand);
            gbAdvancedSearch.Controls.Add(cbEngineType);
            gbAdvancedSearch.Controls.Add(cbModel);
            gbAdvancedSearch.Controls.Add(cbBrand);
            gbAdvancedSearch.Controls.Add(lblAdvancedSearch);
            gbAdvancedSearch.Location = new Point(73, 76);
            gbAdvancedSearch.Name = "gbAdvancedSearch";
            gbAdvancedSearch.Size = new Size(1008, 451);
            gbAdvancedSearch.TabIndex = 11;
            gbAdvancedSearch.TabStop = false;
            // 
            // btSearch
            // 
            btSearch.Location = new Point(849, 383);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(75, 23);
            btSearch.TabIndex = 15;
            btSearch.Text = "Rechercher";
            btSearch.UseVisualStyleBackColor = true;
            btSearch.Click += btSearch_Click;
            // 
            // gbPrice
            // 
            gbPrice.Controls.Add(numPriceTo);
            gbPrice.Controls.Add(numPriceFrom);
            gbPrice.Controls.Add(lblPriceTo);
            gbPrice.Controls.Add(lblPriceFrom);
            gbPrice.Location = new Point(724, 232);
            gbPrice.Name = "gbPrice";
            gbPrice.Size = new Size(200, 100);
            gbPrice.TabIndex = 14;
            gbPrice.TabStop = false;
            gbPrice.Text = "Prix";
            // 
            // numPriceTo
            // 
            numPriceTo.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            numPriceTo.Location = new Point(123, 52);
            numPriceTo.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numPriceTo.Name = "numPriceTo";
            numPriceTo.Size = new Size(62, 23);
            numPriceTo.TabIndex = 20;
            numPriceTo.Value = new decimal(new int[] { 1000000, 0, 0, 0 });
            numPriceTo.ValueChanged += numPriceTo_ValueChanged;
            // 
            // numPriceFrom
            // 
            numPriceFrom.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            numPriceFrom.Location = new Point(18, 53);
            numPriceFrom.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numPriceFrom.Name = "numPriceFrom";
            numPriceFrom.Size = new Size(62, 23);
            numPriceFrom.TabIndex = 19;
            numPriceFrom.ValueChanged += numPriceFrom_ValueChanged;
            // 
            // lblPriceTo
            // 
            lblPriceTo.AutoSize = true;
            lblPriceTo.Location = new Point(123, 34);
            lblPriceTo.Name = "lblPriceTo";
            lblPriceTo.Size = new Size(21, 15);
            lblPriceTo.TabIndex = 12;
            lblPriceTo.Text = "À :";
            // 
            // lblPriceFrom
            // 
            lblPriceFrom.AutoSize = true;
            lblPriceFrom.Location = new Point(18, 34);
            lblPriceFrom.Name = "lblPriceFrom";
            lblPriceFrom.Size = new Size(27, 15);
            lblPriceFrom.TabIndex = 10;
            lblPriceFrom.Text = "De :";
            // 
            // cbMileage
            // 
            cbMileage.Controls.Add(numMileageTo);
            cbMileage.Controls.Add(numMileageFrom);
            cbMileage.Controls.Add(lblMileageTo);
            cbMileage.Controls.Add(lblMileageFrom);
            cbMileage.Location = new Point(394, 232);
            cbMileage.Name = "cbMileage";
            cbMileage.Size = new Size(200, 100);
            cbMileage.TabIndex = 13;
            cbMileage.TabStop = false;
            cbMileage.Text = "Kilométrage";
            // 
            // numMileageTo
            // 
            numMileageTo.Increment = new decimal(new int[] { 10000, 0, 0, 0 });
            numMileageTo.Location = new Point(123, 53);
            numMileageTo.Maximum = new decimal(new int[] { 400000, 0, 0, 0 });
            numMileageTo.Name = "numMileageTo";
            numMileageTo.Size = new Size(62, 23);
            numMileageTo.TabIndex = 18;
            numMileageTo.Value = new decimal(new int[] { 400000, 0, 0, 0 });
            numMileageTo.ValueChanged += numMileageTo_ValueChanged;
            // 
            // numMileageFrom
            // 
            numMileageFrom.Increment = new decimal(new int[] { 10000, 0, 0, 0 });
            numMileageFrom.Location = new Point(18, 52);
            numMileageFrom.Maximum = new decimal(new int[] { 400000, 0, 0, 0 });
            numMileageFrom.Name = "numMileageFrom";
            numMileageFrom.Size = new Size(62, 23);
            numMileageFrom.TabIndex = 17;
            numMileageFrom.ValueChanged += numMileageFrom_ValueChanged;
            // 
            // lblMileageTo
            // 
            lblMileageTo.AutoSize = true;
            lblMileageTo.Location = new Point(123, 34);
            lblMileageTo.Name = "lblMileageTo";
            lblMileageTo.Size = new Size(21, 15);
            lblMileageTo.TabIndex = 12;
            lblMileageTo.Text = "À :";
            // 
            // lblMileageFrom
            // 
            lblMileageFrom.AutoSize = true;
            lblMileageFrom.Location = new Point(18, 34);
            lblMileageFrom.Name = "lblMileageFrom";
            lblMileageFrom.Size = new Size(27, 15);
            lblMileageFrom.TabIndex = 10;
            lblMileageFrom.Text = "De :";
            // 
            // gbYear
            // 
            gbYear.Controls.Add(numYearTo);
            gbYear.Controls.Add(numYearFrom);
            gbYear.Controls.Add(lblYearTo);
            gbYear.Controls.Add(lblYearFrom);
            gbYear.Location = new Point(74, 232);
            gbYear.Name = "gbYear";
            gbYear.Size = new Size(200, 100);
            gbYear.TabIndex = 9;
            gbYear.TabStop = false;
            gbYear.Text = "Année";
            // 
            // numYearTo
            // 
            numYearTo.Location = new Point(123, 52);
            numYearTo.Maximum = new decimal(new int[] { 2024, 0, 0, 0 });
            numYearTo.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            numYearTo.Name = "numYearTo";
            numYearTo.Size = new Size(62, 23);
            numYearTo.TabIndex = 16;
            numYearTo.Value = new decimal(new int[] { 2024, 0, 0, 0 });
            numYearTo.ValueChanged += numYearTo_ValueChanged;
            // 
            // numYearFrom
            // 
            numYearFrom.Location = new Point(18, 53);
            numYearFrom.Maximum = new decimal(new int[] { 2024, 0, 0, 0 });
            numYearFrom.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            numYearFrom.Name = "numYearFrom";
            numYearFrom.Size = new Size(62, 23);
            numYearFrom.TabIndex = 15;
            numYearFrom.Value = new decimal(new int[] { 1900, 0, 0, 0 });
            numYearFrom.ValueChanged += numYearFrom_ValueChanged;
            // 
            // lblYearTo
            // 
            lblYearTo.AutoSize = true;
            lblYearTo.Location = new Point(123, 34);
            lblYearTo.Name = "lblYearTo";
            lblYearTo.Size = new Size(21, 15);
            lblYearTo.TabIndex = 12;
            lblYearTo.Text = "À :";
            // 
            // lblYearFrom
            // 
            lblYearFrom.AutoSize = true;
            lblYearFrom.Location = new Point(18, 34);
            lblYearFrom.Name = "lblYearFrom";
            lblYearFrom.Size = new Size(27, 15);
            lblYearFrom.TabIndex = 10;
            lblYearFrom.Text = "De :";
            // 
            // lblEngineType
            // 
            lblEngineType.AutoSize = true;
            lblEngineType.Location = new Point(762, 108);
            lblEngineType.Name = "lblEngineType";
            lblEngineType.Size = new Size(81, 15);
            lblEngineType.TabIndex = 8;
            lblEngineType.Text = "Motorisation :";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(432, 108);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(53, 15);
            lblModel.TabIndex = 7;
            lblModel.Text = "Modèle :";
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Location = new Point(115, 108);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(54, 15);
            lblBrand.TabIndex = 6;
            lblBrand.Text = "Marque :";
            // 
            // cbEngineType
            // 
            cbEngineType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEngineType.FormattingEnabled = true;
            cbEngineType.Items.AddRange(new object[] { "Tous" });
            cbEngineType.Location = new Point(762, 126);
            cbEngineType.Name = "cbEngineType";
            cbEngineType.Size = new Size(121, 23);
            cbEngineType.TabIndex = 5;
            // 
            // cbModel
            // 
            cbModel.DropDownStyle = ComboBoxStyle.DropDownList;
            cbModel.FormattingEnabled = true;
            cbModel.Items.AddRange(new object[] { "Tous" });
            cbModel.Location = new Point(432, 126);
            cbModel.Name = "cbModel";
            cbModel.Size = new Size(121, 23);
            cbModel.TabIndex = 2;
            // 
            // cbBrand
            // 
            cbBrand.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBrand.FormattingEnabled = true;
            cbBrand.IntegralHeight = false;
            cbBrand.Items.AddRange(new object[] { "Tous" });
            cbBrand.Location = new Point(115, 126);
            cbBrand.MaxDropDownItems = 100;
            cbBrand.Name = "cbBrand";
            cbBrand.Size = new Size(121, 23);
            cbBrand.TabIndex = 1;
            cbBrand.SelectedIndexChanged += cbBrand_SelectedIndexChanged;
            // 
            // lblAdvancedSearch
            // 
            lblAdvancedSearch.AutoSize = true;
            lblAdvancedSearch.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdvancedSearch.Location = new Point(6, 19);
            lblAdvancedSearch.Name = "lblAdvancedSearch";
            lblAdvancedSearch.Size = new Size(259, 37);
            lblAdvancedSearch.TabIndex = 0;
            lblAdvancedSearch.Text = "Recherche avancée";
            // 
            // UCAdvancedSearch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gbAdvancedSearch);
            MaximumSize = new Size(1184, 607);
            MinimumSize = new Size(1184, 607);
            Name = "UCAdvancedSearch";
            Size = new Size(1184, 607);
            Load += UCAdvancedSearch_Load;
            gbAdvancedSearch.ResumeLayout(false);
            gbAdvancedSearch.PerformLayout();
            gbPrice.ResumeLayout(false);
            gbPrice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPriceTo).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPriceFrom).EndInit();
            cbMileage.ResumeLayout(false);
            cbMileage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numMileageTo).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMileageFrom).EndInit();
            gbYear.ResumeLayout(false);
            gbYear.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numYearTo).EndInit();
            ((System.ComponentModel.ISupportInitialize)numYearFrom).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbAdvancedSearch;
        private GroupBox gbPrice;
        private Label lblPriceTo;
        private Label lblPriceFrom;
        private GroupBox cbMileage;
        private Label lblMileageTo;
        private Label lblMileageFrom;
        private GroupBox gbYear;
        private Label lblYearTo;
        private ComboBox cbYearTo;
        private Label lblYearFrom;
        private ComboBox cbYearFrom;
        private Label lblEngineType;
        private Label lblModel;
        private Label lblBrand;
        private ComboBox cbEngineType;
        private ComboBox cbModel;
        private ComboBox cbBrand;
        private Label lblAdvancedSearch;
        private NumericUpDown numYearFrom;
        private NumericUpDown numYearTo;
        private NumericUpDown numMileageTo;
        private NumericUpDown numMileageFrom;
        private NumericUpDown numPriceFrom;
        private NumericUpDown numPriceTo;
        private Button btSearch;
    }
}
