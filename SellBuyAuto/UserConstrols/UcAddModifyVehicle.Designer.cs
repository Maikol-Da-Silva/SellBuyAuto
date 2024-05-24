namespace SellBuyAuto
{
    partial class UcAddModifyVehicle
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
            lblAddModify = new Label();
            panel1 = new Panel();
            lblNbImages = new Label();
            btValidate = new Button();
            txtDescription = new TextBox();
            lblDescription = new Label();
            btImages = new Button();
            cbEngineType = new ComboBox();
            lblEngineType = new Label();
            numPrice = new NumericUpDown();
            numMileage = new NumericUpDown();
            numYear = new NumericUpDown();
            lblMileage = new Label();
            lblPrice = new Label();
            lblYear = new Label();
            txtModel = new TextBox();
            lblModel = new Label();
            txtBrand = new TextBox();
            lblBrand = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMileage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numYear).BeginInit();
            SuspendLayout();
            // 
            // lblAddModify
            // 
            lblAddModify.AutoSize = true;
            lblAddModify.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddModify.Location = new Point(83, 34);
            lblAddModify.Name = "lblAddModify";
            lblAddModify.Size = new Size(120, 40);
            lblAddModify.TabIndex = 1;
            lblAddModify.Text = "Ajouter";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(157, 110, 74);
            panel1.Controls.Add(lblNbImages);
            panel1.Controls.Add(btValidate);
            panel1.Controls.Add(txtDescription);
            panel1.Controls.Add(lblDescription);
            panel1.Controls.Add(btImages);
            panel1.Controls.Add(cbEngineType);
            panel1.Controls.Add(lblEngineType);
            panel1.Controls.Add(numPrice);
            panel1.Controls.Add(numMileage);
            panel1.Controls.Add(numYear);
            panel1.Controls.Add(lblMileage);
            panel1.Controls.Add(lblPrice);
            panel1.Controls.Add(lblYear);
            panel1.Controls.Add(txtModel);
            panel1.Controls.Add(lblModel);
            panel1.Controls.Add(txtBrand);
            panel1.Controls.Add(lblBrand);
            panel1.Location = new Point(83, 109);
            panel1.Name = "panel1";
            panel1.Size = new Size(1021, 430);
            panel1.TabIndex = 2;
            // 
            // lblNbImages
            // 
            lblNbImages.AutoSize = true;
            lblNbImages.ForeColor = SystemColors.ControlLightLight;
            lblNbImages.Location = new Point(857, 90);
            lblNbImages.Name = "lblNbImages";
            lblNbImages.Size = new Size(41, 15);
            lblNbImages.TabIndex = 36;
            lblNbImages.Text = "0 sur 5";
            // 
            // btValidate
            // 
            btValidate.BackColor = Color.Linen;
            btValidate.Location = new Point(826, 339);
            btValidate.Name = "btValidate";
            btValidate.Size = new Size(103, 23);
            btValidate.TabIndex = 33;
            btValidate.Text = "Mettre en vente";
            btValidate.UseVisualStyleBackColor = false;
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.Linen;
            txtDescription.Location = new Point(92, 210);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(604, 175);
            txtDescription.TabIndex = 30;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.ForeColor = SystemColors.ControlLightLight;
            lblDescription.Location = new Point(92, 192);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(73, 15);
            lblDescription.TabIndex = 35;
            lblDescription.Text = "Description :";
            // 
            // btImages
            // 
            btImages.BackColor = Color.Linen;
            btImages.Location = new Point(826, 64);
            btImages.Name = "btImages";
            btImages.Size = new Size(103, 23);
            btImages.TabIndex = 31;
            btImages.Text = "Charger images";
            btImages.UseVisualStyleBackColor = false;
            // 
            // cbEngineType
            // 
            cbEngineType.BackColor = Color.Linen;
            cbEngineType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEngineType.FormattingEnabled = true;
            cbEngineType.Location = new Point(593, 133);
            cbEngineType.Name = "cbEngineType";
            cbEngineType.Size = new Size(103, 23);
            cbEngineType.TabIndex = 28;
            // 
            // lblEngineType
            // 
            lblEngineType.AutoSize = true;
            lblEngineType.ForeColor = SystemColors.ControlLightLight;
            lblEngineType.Location = new Point(593, 114);
            lblEngineType.Name = "lblEngineType";
            lblEngineType.Size = new Size(81, 15);
            lblEngineType.TabIndex = 34;
            lblEngineType.Text = "Motorisation :";
            // 
            // numPrice
            // 
            numPrice.BackColor = Color.Linen;
            numPrice.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            numPrice.Location = new Point(593, 64);
            numPrice.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(103, 23);
            numPrice.TabIndex = 24;
            // 
            // numMileage
            // 
            numMileage.BackColor = Color.Linen;
            numMileage.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            numMileage.Location = new Point(342, 133);
            numMileage.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numMileage.Name = "numMileage";
            numMileage.Size = new Size(103, 23);
            numMileage.TabIndex = 27;
            // 
            // numYear
            // 
            numYear.BackColor = Color.Linen;
            numYear.Location = new Point(342, 63);
            numYear.Maximum = new decimal(new int[] { 2024, 0, 0, 0 });
            numYear.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            numYear.Name = "numYear";
            numYear.Size = new Size(103, 23);
            numYear.TabIndex = 23;
            numYear.Value = new decimal(new int[] { 2024, 0, 0, 0 });
            // 
            // lblMileage
            // 
            lblMileage.AutoSize = true;
            lblMileage.ForeColor = SystemColors.ControlLightLight;
            lblMileage.Location = new Point(342, 114);
            lblMileage.Name = "lblMileage";
            lblMileage.Size = new Size(77, 15);
            lblMileage.TabIndex = 32;
            lblMileage.Text = "Kilométrage :";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.ForeColor = SystemColors.ControlLightLight;
            lblPrice.Location = new Point(593, 45);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(33, 15);
            lblPrice.TabIndex = 29;
            lblPrice.Text = "Prix :";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.ForeColor = SystemColors.ControlLightLight;
            lblYear.Location = new Point(342, 45);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(47, 15);
            lblYear.TabIndex = 26;
            lblYear.Text = "Année :";
            // 
            // txtModel
            // 
            txtModel.BackColor = Color.Linen;
            txtModel.Location = new Point(92, 132);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(103, 23);
            txtModel.TabIndex = 25;
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.ForeColor = SystemColors.ControlLightLight;
            lblModel.Location = new Point(92, 114);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(53, 15);
            lblModel.TabIndex = 22;
            lblModel.Text = "Modèle :";
            // 
            // txtBrand
            // 
            txtBrand.BackColor = Color.Linen;
            txtBrand.Location = new Point(92, 63);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(103, 23);
            txtBrand.TabIndex = 21;
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.ForeColor = SystemColors.ControlLightLight;
            lblBrand.Location = new Point(92, 45);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(54, 15);
            lblBrand.TabIndex = 20;
            lblBrand.Text = "Marque :";
            // 
            // UcAddModifyVehicle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panel1);
            Controls.Add(lblAddModify);
            MaximumSize = new Size(1184, 607);
            MinimumSize = new Size(1184, 607);
            Name = "UcAddModifyVehicle";
            Size = new Size(1184, 607);
            Load += UcAddModifyVehicle_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMileage).EndInit();
            ((System.ComponentModel.ISupportInitialize)numYear).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblAddModify;
        private Panel panel1;
        private Label lblNbImages;
        private Button btValidate;
        private TextBox txtDescription;
        private Label lblDescription;
        private Button btImages;
        private ComboBox cbEngineType;
        private Label lblEngineType;
        private NumericUpDown numPrice;
        private NumericUpDown numMileage;
        private NumericUpDown numYear;
        private Label lblMileage;
        private Label lblPrice;
        private Label lblYear;
        private TextBox txtModel;
        private Label lblModel;
        private TextBox txtBrand;
        private Label lblBrand;
    }
}
