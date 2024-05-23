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
            pnAdvancedSearch = new Panel();
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
            pnAdvancedSearch.SuspendLayout();
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
            // pnAdvancedSearch
            // 
            pnAdvancedSearch.BackColor = Color.FromArgb(157, 110, 74);
            pnAdvancedSearch.Controls.Add(btSearch);
            pnAdvancedSearch.Controls.Add(gbPrice);
            pnAdvancedSearch.Controls.Add(cbMileage);
            pnAdvancedSearch.Controls.Add(gbYear);
            pnAdvancedSearch.Controls.Add(lblEngineType);
            pnAdvancedSearch.Controls.Add(lblModel);
            pnAdvancedSearch.Controls.Add(lblBrand);
            pnAdvancedSearch.Controls.Add(cbEngineType);
            pnAdvancedSearch.Controls.Add(cbModel);
            pnAdvancedSearch.Controls.Add(cbBrand);
            pnAdvancedSearch.Location = new Point(87, 102);
            pnAdvancedSearch.Name = "pnAdvancedSearch";
            pnAdvancedSearch.Size = new Size(1008, 451);
            pnAdvancedSearch.TabIndex = 12;
            // 
            // btSearch
            // 
            btSearch.Location = new Point(858, 366);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(77, 23);
            btSearch.TabIndex = 21;
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
            gbPrice.ForeColor = SystemColors.ControlLightLight;
            gbPrice.Location = new Point(735, 215);
            gbPrice.Name = "gbPrice";
            gbPrice.Size = new Size(200, 100);
            gbPrice.TabIndex = 17;
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
            numPriceTo.TabIndex = 9;
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
            numPriceFrom.TabIndex = 8;
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
            cbMileage.ForeColor = SystemColors.ControlLightLight;
            cbMileage.Location = new Point(405, 215);
            cbMileage.Name = "cbMileage";
            cbMileage.Size = new Size(200, 100);
            cbMileage.TabIndex = 16;
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
            numMileageTo.TabIndex = 7;
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
            numMileageFrom.TabIndex = 6;
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
            gbYear.ForeColor = SystemColors.ControlLightLight;
            gbYear.Location = new Point(85, 215);
            gbYear.Name = "gbYear";
            gbYear.Size = new Size(200, 100);
            gbYear.TabIndex = 15;
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
            numYearTo.TabIndex = 5;
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
            numYearFrom.TabIndex = 4;
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
            lblEngineType.ForeColor = SystemColors.ControlLightLight;
            lblEngineType.Location = new Point(773, 91);
            lblEngineType.Name = "lblEngineType";
            lblEngineType.Size = new Size(81, 15);
            lblEngineType.TabIndex = 20;
            lblEngineType.Text = "Motorisation :";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.ForeColor = SystemColors.ControlLightLight;
            lblModel.Location = new Point(443, 91);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(53, 15);
            lblModel.TabIndex = 19;
            lblModel.Text = "Modèle :";
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.ForeColor = SystemColors.ControlLightLight;
            lblBrand.Location = new Point(126, 91);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(54, 15);
            lblBrand.TabIndex = 18;
            lblBrand.Text = "Marque :";
            // 
            // cbEngineType
            // 
            cbEngineType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEngineType.FormattingEnabled = true;
            cbEngineType.Items.AddRange(new object[] { "Tous" });
            cbEngineType.Location = new Point(773, 109);
            cbEngineType.Name = "cbEngineType";
            cbEngineType.Size = new Size(121, 23);
            cbEngineType.TabIndex = 14;
            // 
            // cbModel
            // 
            cbModel.DropDownStyle = ComboBoxStyle.DropDownList;
            cbModel.FormattingEnabled = true;
            cbModel.Items.AddRange(new object[] { "Tous" });
            cbModel.Location = new Point(443, 109);
            cbModel.Name = "cbModel";
            cbModel.Size = new Size(121, 23);
            cbModel.TabIndex = 13;
            // 
            // cbBrand
            // 
            cbBrand.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBrand.FormattingEnabled = true;
            cbBrand.IntegralHeight = false;
            cbBrand.Items.AddRange(new object[] { "Tous" });
            cbBrand.Location = new Point(126, 109);
            cbBrand.MaxDropDownItems = 100;
            cbBrand.Name = "cbBrand";
            cbBrand.Size = new Size(121, 23);
            cbBrand.TabIndex = 12;
            cbBrand.SelectedIndexChanged += cbBrand_SelectedIndexChanged;
            // 
            // lblAdvancedSearch
            // 
            lblAdvancedSearch.AutoSize = true;
            lblAdvancedSearch.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdvancedSearch.Location = new Point(87, 32);
            lblAdvancedSearch.Name = "lblAdvancedSearch";
            lblAdvancedSearch.Size = new Size(259, 37);
            lblAdvancedSearch.TabIndex = 11;
            lblAdvancedSearch.Text = "Recherche avancée";
            // 
            // UCAdvancedSearch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(pnAdvancedSearch);
            Controls.Add(lblAdvancedSearch);
            MaximumSize = new Size(1184, 607);
            MinimumSize = new Size(1184, 607);
            Name = "UCAdvancedSearch";
            Size = new Size(1184, 607);
            Load += UCAdvancedSearch_Load;
            pnAdvancedSearch.ResumeLayout(false);
            pnAdvancedSearch.PerformLayout();
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
            PerformLayout();
        }

        #endregion
        private ComboBox cbYearTo;
        private ComboBox cbYearFrom;
        private Panel pnAdvancedSearch;
        private Button btSearch;
        private GroupBox gbPrice;
        private NumericUpDown numPriceTo;
        private NumericUpDown numPriceFrom;
        private Label lblPriceTo;
        private Label lblPriceFrom;
        private GroupBox cbMileage;
        private NumericUpDown numMileageTo;
        private NumericUpDown numMileageFrom;
        private Label lblMileageTo;
        private Label lblMileageFrom;
        private GroupBox gbYear;
        private NumericUpDown numYearTo;
        private NumericUpDown numYearFrom;
        private Label lblYearTo;
        private Label lblYearFrom;
        private Label lblEngineType;
        private Label lblModel;
        private Label lblBrand;
        private ComboBox cbEngineType;
        private ComboBox cbModel;
        private ComboBox cbBrand;
        private Label lblAdvancedSearch;
    }
}
