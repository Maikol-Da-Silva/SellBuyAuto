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
            pbBookMark = new PictureBox();
            btBlockNotice = new Button();
            btBlockUser = new Button();
            ((System.ComponentModel.ISupportInitialize)pbVehicleImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBookMark).BeginInit();
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
            lblTitle.ForeColor = Color.Black;
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
            lblInfo.ForeColor = Color.Black;
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
            lblDescription.ForeColor = Color.Black;
            lblDescription.Location = new Point(202, 85);
            lblDescription.MaximumSize = new Size(500, 70);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(491, 42);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "La Toyota Corolla est une voiture compacte produite depuis 1966 par le constructeur automobile japonais Toyota.";
            // 
            // pbBookMark
            // 
            pbBookMark.Image = Properties.Resources.ToBookmark;
            pbBookMark.Location = new Point(714, 3);
            pbBookMark.Name = "pbBookMark";
            pbBookMark.Size = new Size(46, 41);
            pbBookMark.SizeMode = PictureBoxSizeMode.Zoom;
            pbBookMark.TabIndex = 4;
            pbBookMark.TabStop = false;
            pbBookMark.Click += pbBookmark_Click;
            // 
            // btBlockNotice
            // 
            btBlockNotice.BackColor = Color.Silver;
            btBlockNotice.Enabled = false;
            btBlockNotice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btBlockNotice.Location = new Point(589, 121);
            btBlockNotice.Name = "btBlockNotice";
            btBlockNotice.Size = new Size(171, 35);
            btBlockNotice.TabIndex = 9;
            btBlockNotice.Text = "Bloquer l'annonce";
            btBlockNotice.UseVisualStyleBackColor = false;
            btBlockNotice.Visible = false;
            btBlockNotice.Click += btBlockNotice_Click;
            // 
            // btBlockUser
            // 
            btBlockUser.BackColor = Color.Silver;
            btBlockUser.Enabled = false;
            btBlockUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btBlockUser.Location = new Point(589, 78);
            btBlockUser.Name = "btBlockUser";
            btBlockUser.Size = new Size(171, 35);
            btBlockUser.TabIndex = 10;
            btBlockUser.Text = "Bloquer l'utilisateur";
            btBlockUser.UseVisualStyleBackColor = false;
            btBlockUser.Visible = false;
            // 
            // UcVehicleLabel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            Controls.Add(btBlockUser);
            Controls.Add(btBlockNotice);
            Controls.Add(pbBookMark);
            Controls.Add(lblDescription);
            Controls.Add(lblInfo);
            Controls.Add(lblTitle);
            Controls.Add(pbVehicleImage);
            Margin = new Padding(55, 20, 3, 3);
            MaximumSize = new Size(763, 178);
            MinimumSize = new Size(763, 178);
            Name = "UcVehicleLabel";
            Size = new Size(763, 178);
            Load += UcVehicleLabel_Load;
            ((System.ComponentModel.ISupportInitialize)pbVehicleImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBookMark).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbVehicleImage;
        private Label lblTitle;
        private Label lblInfo;
        private Label lblDescription;
        private PictureBox pbBookMark;
        private Button btBlockNotice;
        private Button btBlockUser;
    }
}
