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
            gbForm = new GroupBox();
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
            lblAddModify = new Label();
            gbForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMileage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numYear).BeginInit();
            SuspendLayout();
            // 
            // gbForm
            // 
            gbForm.Controls.Add(lblNbImages);
            gbForm.Controls.Add(btValidate);
            gbForm.Controls.Add(txtDescription);
            gbForm.Controls.Add(lblDescription);
            gbForm.Controls.Add(btImages);
            gbForm.Controls.Add(cbEngineType);
            gbForm.Controls.Add(lblEngineType);
            gbForm.Controls.Add(numPrice);
            gbForm.Controls.Add(numMileage);
            gbForm.Controls.Add(numYear);
            gbForm.Controls.Add(lblMileage);
            gbForm.Controls.Add(lblPrice);
            gbForm.Controls.Add(lblYear);
            gbForm.Controls.Add(txtModel);
            gbForm.Controls.Add(lblModel);
            gbForm.Controls.Add(txtBrand);
            gbForm.Controls.Add(lblBrand);
            gbForm.Location = new Point(71, 105);
            gbForm.Name = "gbForm";
            gbForm.Size = new Size(1021, 430);
            gbForm.TabIndex = 0;
            gbForm.TabStop = false;
            // 
            // lblNbImages
            // 
            lblNbImages.AutoSize = true;
            lblNbImages.Location = new Point(844, 113);
            lblNbImages.Name = "lblNbImages";
            lblNbImages.Size = new Size(41, 15);
            lblNbImages.TabIndex = 19;
            lblNbImages.Text = "0 sur 5";
            // 
            // btValidate
            // 
            btValidate.Location = new Point(813, 362);
            btValidate.Name = "btValidate";
            btValidate.Size = new Size(103, 23);
            btValidate.TabIndex = 18;
            btValidate.Text = "Mettre en vente";
            btValidate.UseVisualStyleBackColor = true;
            btValidate.Click += btValidate_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(79, 233);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(604, 175);
            txtDescription.TabIndex = 17;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(79, 215);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(73, 15);
            lblDescription.TabIndex = 16;
            lblDescription.Text = "Description :";
            // 
            // btImages
            // 
            btImages.Location = new Point(813, 87);
            btImages.Name = "btImages";
            btImages.Size = new Size(103, 23);
            btImages.TabIndex = 15;
            btImages.Text = "Charger images";
            btImages.UseVisualStyleBackColor = true;
            btImages.Click += btImages_Click;
            // 
            // cbEngineType
            // 
            cbEngineType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEngineType.FormattingEnabled = true;
            cbEngineType.Location = new Point(580, 156);
            cbEngineType.Name = "cbEngineType";
            cbEngineType.Size = new Size(103, 23);
            cbEngineType.TabIndex = 14;
            // 
            // lblEngineType
            // 
            lblEngineType.AutoSize = true;
            lblEngineType.Location = new Point(580, 137);
            lblEngineType.Name = "lblEngineType";
            lblEngineType.Size = new Size(81, 15);
            lblEngineType.TabIndex = 13;
            lblEngineType.Text = "Motorisation :";
            // 
            // numPrice
            // 
            numPrice.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            numPrice.Location = new Point(580, 87);
            numPrice.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(103, 23);
            numPrice.TabIndex = 12;
            // 
            // numMileage
            // 
            numMileage.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            numMileage.Location = new Point(329, 156);
            numMileage.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numMileage.Name = "numMileage";
            numMileage.Size = new Size(103, 23);
            numMileage.TabIndex = 11;
            // 
            // numYear
            // 
            numYear.Location = new Point(329, 86);
            numYear.Maximum = new decimal(new int[] { 2024, 0, 0, 0 });
            numYear.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            numYear.Name = "numYear";
            numYear.Size = new Size(103, 23);
            numYear.TabIndex = 10;
            numYear.Value = new decimal(new int[] { 2024, 0, 0, 0 });
            // 
            // lblMileage
            // 
            lblMileage.AutoSize = true;
            lblMileage.Location = new Point(329, 137);
            lblMileage.Name = "lblMileage";
            lblMileage.Size = new Size(77, 15);
            lblMileage.TabIndex = 8;
            lblMileage.Text = "Kilométrage :";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(580, 68);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(33, 15);
            lblPrice.TabIndex = 6;
            lblPrice.Text = "Prix :";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(329, 68);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(47, 15);
            lblYear.TabIndex = 4;
            lblYear.Text = "Année :";
            // 
            // txtModel
            // 
            txtModel.Location = new Point(79, 155);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(103, 23);
            txtModel.TabIndex = 3;
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(79, 137);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(53, 15);
            lblModel.TabIndex = 2;
            lblModel.Text = "Modèle :";
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(79, 86);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(103, 23);
            txtBrand.TabIndex = 1;
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Location = new Point(79, 68);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(54, 15);
            lblBrand.TabIndex = 0;
            lblBrand.Text = "Marque :";
            // 
            // lblAddModify
            // 
            lblAddModify.AutoSize = true;
            lblAddModify.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddModify.Location = new Point(71, 33);
            lblAddModify.Name = "lblAddModify";
            lblAddModify.Size = new Size(120, 40);
            lblAddModify.TabIndex = 1;
            lblAddModify.Text = "Ajouter";
            // 
            // UcAddModifyVehicle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblAddModify);
            Controls.Add(gbForm);
            MaximumSize = new Size(1184, 607);
            MinimumSize = new Size(1184, 607);
            Name = "UcAddModifyVehicle";
            Size = new Size(1184, 607);
            Load += UcAddModifyVehicle_Load;
            gbForm.ResumeLayout(false);
            gbForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMileage).EndInit();
            ((System.ComponentModel.ISupportInitialize)numYear).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbForm;
        private TextBox txtBrand;
        private Label lblBrand;
        private Label lblMileage;
        private Label lblPrice;
        private Label lblYear;
        private TextBox txtModel;
        private Label lblModel;
        private NumericUpDown numPrice;
        private NumericUpDown numMileage;
        private NumericUpDown numYear;
        private Label lblEngineType;
        private TextBox txtDescription;
        private Label lblDescription;
        private Button btImages;
        private ComboBox cbEngineType;
        private Button btValidate;
        private Label lblAddModify;
        private Label lblNbImages;
    }
}
