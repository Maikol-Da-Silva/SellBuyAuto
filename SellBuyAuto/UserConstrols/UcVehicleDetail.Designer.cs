namespace SellBuyAuto
{
    partial class UcVehicleDetail
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
            pbImage = new PictureBox();
            btImagePrevious = new Button();
            btImageNext = new Button();
            btBack = new Button();
            lblBrandModel = new Label();
            lblPrice = new Label();
            lblYear = new Label();
            lblMileage = new Label();
            lblEngineType = new Label();
            lblDescription = new Label();
            btBuy = new Button();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            SuspendLayout();
            // 
            // pbImage
            // 
            pbImage.BorderStyle = BorderStyle.FixedSingle;
            pbImage.Location = new Point(322, 3);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(542, 311);
            pbImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbImage.TabIndex = 0;
            pbImage.TabStop = false;
            // 
            // btImagePrevious
            // 
            btImagePrevious.Location = new Point(283, 139);
            btImagePrevious.Name = "btImagePrevious";
            btImagePrevious.Size = new Size(33, 23);
            btImagePrevious.TabIndex = 1;
            btImagePrevious.Text = "<";
            btImagePrevious.UseVisualStyleBackColor = true;
            btImagePrevious.Click += btImagePrevious_Click;
            // 
            // btImageNext
            // 
            btImageNext.Location = new Point(870, 139);
            btImageNext.Name = "btImageNext";
            btImageNext.Size = new Size(33, 23);
            btImageNext.TabIndex = 2;
            btImageNext.Text = ">";
            btImageNext.UseVisualStyleBackColor = true;
            btImageNext.Click += btImageNext_Click;
            // 
            // btBack
            // 
            btBack.Location = new Point(3, 3);
            btBack.Name = "btBack";
            btBack.Size = new Size(75, 23);
            btBack.TabIndex = 3;
            btBack.Text = "Revenir";
            btBack.UseVisualStyleBackColor = true;
            btBack.Click += btBack_Click;
            // 
            // lblBrandModel
            // 
            lblBrandModel.AutoSize = true;
            lblBrandModel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBrandModel.Location = new Point(107, 334);
            lblBrandModel.Name = "lblBrandModel";
            lblBrandModel.Size = new Size(157, 45);
            lblBrandModel.TabIndex = 4;
            lblBrandModel.Text = "Audi RS3";
            lblBrandModel.TextAlign = ContentAlignment.TopRight;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(870, 334);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(228, 37);
            lblPrice.TabIndex = 5;
            lblPrice.Text = "Prix : 45000 CHF";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblYear.Location = new Point(119, 392);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(134, 30);
            lblYear.TabIndex = 6;
            lblYear.Text = "Année : 2019";
            // 
            // lblMileage
            // 
            lblMileage.AutoSize = true;
            lblMileage.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMileage.Location = new Point(463, 392);
            lblMileage.Name = "lblMileage";
            lblMileage.Size = new Size(243, 30);
            lblMileage.TabIndex = 7;
            lblMileage.Text = "Kilométrage : 80000 km";
            // 
            // lblEngineType
            // 
            lblEngineType.AutoSize = true;
            lblEngineType.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEngineType.Location = new Point(870, 392);
            lblEngineType.Name = "lblEngineType";
            lblEngineType.Size = new Size(227, 30);
            lblEngineType.TabIndex = 8;
            lblEngineType.Text = "Motorisation : Essence";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescription.Location = new Point(252, 469);
            lblDescription.MaximumSize = new Size(700, 130);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(687, 90);
            lblDescription.TabIndex = 9;
            lblDescription.Text = "La Lamborghini Huracan est une voiture de sport emblématique, réputée pour son design audacieux, ses performances exceptionnelles et son moteur V10 puissant.";
            // 
            // btBuy
            // 
            btBuy.Location = new Point(1023, 536);
            btBuy.Name = "btBuy";
            btBuy.Size = new Size(75, 23);
            btBuy.TabIndex = 10;
            btBuy.Text = "Acheter";
            btBuy.UseVisualStyleBackColor = true;
            btBuy.Click += btBuy_Click;
            // 
            // UcVehicleDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btBuy);
            Controls.Add(lblDescription);
            Controls.Add(lblEngineType);
            Controls.Add(lblMileage);
            Controls.Add(lblYear);
            Controls.Add(lblPrice);
            Controls.Add(lblBrandModel);
            Controls.Add(btBack);
            Controls.Add(btImageNext);
            Controls.Add(btImagePrevious);
            Controls.Add(pbImage);
            MaximumSize = new Size(1184, 607);
            MinimumSize = new Size(1184, 607);
            Name = "UcVehicleDetail";
            Size = new Size(1184, 607);
            Load += UcVehicleDetail_Load;
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbImage;
        private Button btImagePrevious;
        private Button btImageNext;
        private Button btBack;
        private Label lblBrandModel;
        private Label lblPrice;
        private Label lblYear;
        private Label lblMileage;
        private Label lblEngineType;
        private Label lblDescription;
        private Button btBuy;
    }
}
