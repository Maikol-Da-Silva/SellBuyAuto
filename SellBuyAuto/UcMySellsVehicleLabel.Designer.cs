namespace SellBuyAuto
{
    partial class UcMySellsVehicleLabel
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
            lblDescription = new Label();
            lblInfo = new Label();
            lblTitle = new Label();
            pbVehicleImage = new PictureBox();
            btModify = new Button();
            btDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)pbVehicleImage).BeginInit();
            SuspendLayout();
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescription.Location = new Point(202, 85);
            lblDescription.MaximumSize = new Size(500, 70);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(491, 42);
            lblDescription.TabIndex = 7;
            lblDescription.Text = "La Toyota Corolla est une voiture compacte produite depuis 1966 par le constructeur automobile japonais Toyota.";
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInfo.Location = new Point(202, 50);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(258, 21);
            lblInfo.TabIndex = 6;
            lblInfo.Text = "Kilomètrage : 88000km Prix : 45000";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(202, 3);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(133, 37);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Audi RS3";
            // 
            // pbVehicleImage
            // 
            pbVehicleImage.Location = new Point(3, 3);
            pbVehicleImage.Name = "pbVehicleImage";
            pbVehicleImage.Size = new Size(172, 172);
            pbVehicleImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbVehicleImage.TabIndex = 4;
            pbVehicleImage.TabStop = false;
            // 
            // btModify
            // 
            btModify.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btModify.Location = new Point(622, 25);
            btModify.Name = "btModify";
            btModify.Size = new Size(109, 35);
            btModify.TabIndex = 8;
            btModify.Text = "Modifier";
            btModify.UseVisualStyleBackColor = true;
            btModify.Click += btModify_Click;
            // 
            // btDelete
            // 
            btDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btDelete.Location = new Point(622, 118);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(109, 35);
            btDelete.TabIndex = 9;
            btDelete.Text = "Supprimer";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // UcMySellsVehicleLabel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btDelete);
            Controls.Add(btModify);
            Controls.Add(lblDescription);
            Controls.Add(lblInfo);
            Controls.Add(lblTitle);
            Controls.Add(pbVehicleImage);
            Margin = new Padding(175, 20, 3, 3);
            MaximumSize = new Size(763, 178);
            MinimumSize = new Size(763, 178);
            Name = "UcMySellsVehicleLabel";
            Size = new Size(763, 178);
            Load += UcMySellsVehicleLabel_Load;
            ((System.ComponentModel.ISupportInitialize)pbVehicleImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDescription;
        private Label lblInfo;
        private Label lblTitle;
        private PictureBox pbVehicleImage;
        private Button btModify;
        private Button btDelete;
    }
}
