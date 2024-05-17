namespace SellBuyAuto
{
    partial class UcVehicleSold
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
            txtEmail = new TextBox();
            lblEmail = new Label();
            lblTitle = new Label();
            btValidate = new Button();
            btCancel = new Button();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(109, 102);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(158, 23);
            txtEmail.TabIndex = 0;
            txtEmail.KeyUp += txtEmail_KeyUp;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(109, 84);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(80, 15);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Adresse Mail :";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(18, 41);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(340, 21);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Veuillez rentrer l'adresse mail de l'acheteur";
            // 
            // btValidate
            // 
            btValidate.Location = new Point(146, 141);
            btValidate.Name = "btValidate";
            btValidate.Size = new Size(75, 23);
            btValidate.TabIndex = 3;
            btValidate.Text = "Valider";
            btValidate.UseVisualStyleBackColor = true;
            btValidate.Click += btValidate_Click;
            btValidate.KeyUp += btValidate_KeyUp;
            // 
            // btCancel
            // 
            btCancel.BackColor = Color.IndianRed;
            btCancel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btCancel.ForeColor = SystemColors.ControlLightLight;
            btCancel.Location = new Point(337, 3);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(33, 27);
            btCancel.TabIndex = 4;
            btCancel.Text = "X";
            btCancel.UseVisualStyleBackColor = false;
            btCancel.Click += btCancel_Click;
            // 
            // UcVehicleSold
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btCancel);
            Controls.Add(btValidate);
            Controls.Add(lblTitle);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Name = "UcVehicleSold";
            Size = new Size(373, 185);
            Load += UcVehicleSold_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private Label lblEmail;
        private Label lblTitle;
        private Button btValidate;
        private Button btCancel;
    }
}
