namespace SellBuyAuto
{
    partial class UcVehicleLabel
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
            pbVehicleImage = new PictureBox();
            lblTitle = new Label();
            lblInfo = new Label();
            lblDescription = new Label();
            ((System.ComponentModel.ISupportInitialize)pbVehicleImage).BeginInit();
            SuspendLayout();
            // 
            // pbVehicleImage
            // 
            pbVehicleImage.Location = new Point(3, 3);
            pbVehicleImage.Name = "pbVehicleImage";
            pbVehicleImage.Size = new Size(172, 172);
            pbVehicleImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbVehicleImage.TabIndex = 0;
            pbVehicleImage.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(202, 3);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(133, 37);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Audi RS3";
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInfo.Location = new Point(202, 50);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(258, 21);
            lblInfo.TabIndex = 2;
            lblInfo.Text = "Kilomètrage : 88000km Prix : 45000";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescription.Location = new Point(202, 85);
            lblDescription.MaximumSize = new Size(500, 70);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(491, 42);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "La Toyota Corolla est une voiture compacte produite depuis 1966 par le constructeur automobile japonais Toyota.";
            // 
            // UcVehicleLabel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblDescription);
            Controls.Add(lblInfo);
            Controls.Add(lblTitle);
            Controls.Add(pbVehicleImage);
            Margin = new Padding(175, 20, 3, 3);
            MaximumSize = new Size(763, 178);
            MinimumSize = new Size(763, 178);
            Name = "UcVehicleLabel";
            Size = new Size(763, 178);
            Load += UcVehicleLabel_Load;
            ((System.ComponentModel.ISupportInitialize)pbVehicleImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbVehicleImage;
        private Label lblTitle;
        private Label lblInfo;
        private Label lblDescription;
    }
}
