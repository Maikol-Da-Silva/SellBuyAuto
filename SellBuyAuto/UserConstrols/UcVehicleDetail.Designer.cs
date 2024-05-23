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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcVehicleDetail));
            pbImage = new PictureBox();
            btImagePrevious = new Button();
            btImageNext = new Button();
            lblBrandModel = new Label();
            lblPrice = new Label();
            lblYear = new Label();
            lblMileage = new Label();
            lblEngineType = new Label();
            lblDescription = new Label();
            btBuy = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pbImage
            // 
            pbImage.Location = new Point(171, 120);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(542, 311);
            pbImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbImage.TabIndex = 0;
            pbImage.TabStop = false;
            // 
            // btImagePrevious
            // 
            btImagePrevious.Location = new Point(132, 256);
            btImagePrevious.Name = "btImagePrevious";
            btImagePrevious.Size = new Size(33, 23);
            btImagePrevious.TabIndex = 1;
            btImagePrevious.Text = "<";
            btImagePrevious.UseVisualStyleBackColor = true;
            btImagePrevious.Click += btImagePrevious_Click;
            // 
            // btImageNext
            // 
            btImageNext.Location = new Point(719, 256);
            btImageNext.Name = "btImageNext";
            btImageNext.Size = new Size(33, 23);
            btImageNext.TabIndex = 2;
            btImageNext.Text = ">";
            btImageNext.UseVisualStyleBackColor = true;
            btImageNext.Click += btImageNext_Click;
            // 
            // lblBrandModel
            // 
            lblBrandModel.AutoSize = true;
            lblBrandModel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBrandModel.ForeColor = SystemColors.ControlLightLight;
            lblBrandModel.Location = new Point(171, 45);
            lblBrandModel.MinimumSize = new Size(542, 45);
            lblBrandModel.Name = "lblBrandModel";
            lblBrandModel.Size = new Size(542, 45);
            lblBrandModel.TabIndex = 4;
            lblBrandModel.Text = "Audi RS3";
            lblBrandModel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = SystemColors.ControlLightLight;
            lblPrice.Location = new Point(719, 331);
            lblPrice.MaximumSize = new Size(462, 37);
            lblPrice.MinimumSize = new Size(462, 37);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(462, 37);
            lblPrice.TabIndex = 5;
            lblPrice.Text = "Prix : 45000 CHF";
            lblPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Italic);
            lblYear.ForeColor = SystemColors.ControlLightLight;
            lblYear.Location = new Point(722, 222);
            lblYear.MaximumSize = new Size(462, 30);
            lblYear.MinimumSize = new Size(462, 30);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(462, 30);
            lblYear.TabIndex = 6;
            lblYear.Text = "Année : 2019";
            lblYear.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMileage
            // 
            lblMileage.AutoSize = true;
            lblMileage.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Italic);
            lblMileage.ForeColor = SystemColors.ControlLightLight;
            lblMileage.Location = new Point(722, 252);
            lblMileage.MaximumSize = new Size(462, 30);
            lblMileage.MinimumSize = new Size(462, 30);
            lblMileage.Name = "lblMileage";
            lblMileage.Size = new Size(462, 30);
            lblMileage.TabIndex = 7;
            lblMileage.Text = "Kilométrage : 80000 km";
            lblMileage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEngineType
            // 
            lblEngineType.AutoSize = true;
            lblEngineType.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Italic);
            lblEngineType.ForeColor = SystemColors.ControlLightLight;
            lblEngineType.Location = new Point(722, 282);
            lblEngineType.MaximumSize = new Size(462, 30);
            lblEngineType.MinimumSize = new Size(462, 30);
            lblEngineType.Name = "lblEngineType";
            lblEngineType.Size = new Size(462, 30);
            lblEngineType.TabIndex = 8;
            lblEngineType.Text = "Motorisation : Essence";
            lblEngineType.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescription.ForeColor = SystemColors.ControlLightLight;
            lblDescription.Location = new Point(171, 437);
            lblDescription.MaximumSize = new Size(542, 130);
            lblDescription.MinimumSize = new Size(542, 130);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(542, 130);
            lblDescription.TabIndex = 9;
            lblDescription.Text = "La Lamborghini Huracan est une voiture de sport emblématique, réputée pour son design audacieux, ses performances exceptionnelles et son moteur V10 puissant.";
            lblDescription.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btBuy
            // 
            btBuy.BackColor = Color.Linen;
            btBuy.Location = new Point(911, 380);
            btBuy.Name = "btBuy";
            btBuy.Size = new Size(75, 23);
            btBuy.TabIndex = 1;
            btBuy.Text = "Acheter";
            btBuy.UseVisualStyleBackColor = false;
            btBuy.Click += btBuy_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-20, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += btBack_Click;
            // 
            // UcVehicleDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(157, 110, 74);
            Controls.Add(pictureBox1);
            Controls.Add(btImageNext);
            Controls.Add(lblBrandModel);
            Controls.Add(btBuy);
            Controls.Add(lblDescription);
            Controls.Add(lblEngineType);
            Controls.Add(lblMileage);
            Controls.Add(lblYear);
            Controls.Add(lblPrice);
            Controls.Add(btImagePrevious);
            Controls.Add(pbImage);
            MaximumSize = new Size(1184, 607);
            MinimumSize = new Size(1184, 607);
            Name = "UcVehicleDetail";
            Size = new Size(1184, 607);
            Load += UcVehicleDetail_Load;
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbImage;
        private Button btImagePrevious;
        private Button btImageNext;
        private Label lblBrandModel;
        private Label lblPrice;
        private Label lblYear;
        private Label lblMileage;
        private Label lblEngineType;
        private Label lblDescription;
        private Button btBuy;
        private PictureBox pictureBox1;
    }
}
