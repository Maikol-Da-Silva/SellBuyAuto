namespace SellBuyAuto.UserConstrols
{
    partial class UcMyPurchases
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
            btNext = new Button();
            lblPages = new Label();
            btPrevious = new Button();
            lblTitle = new Label();
            FlpVehicles = new FlowLayoutPanel();
            label1 = new Label();
            SuspendLayout();
            // 
            // btNext
            // 
            btNext.Location = new Point(651, 553);
            btNext.Name = "btNext";
            btNext.Size = new Size(75, 23);
            btNext.TabIndex = 23;
            btNext.Text = "Suivant";
            btNext.UseVisualStyleBackColor = true;
            btNext.Click += btNext_Click;
            // 
            // lblPages
            // 
            lblPages.AutoSize = true;
            lblPages.BackColor = Color.FromArgb(157, 110, 74);
            lblPages.ForeColor = SystemColors.ControlLightLight;
            lblPages.Location = new Point(558, 557);
            lblPages.Name = "lblPages";
            lblPages.Size = new Size(70, 15);
            lblPages.TabIndex = 22;
            lblPages.Text = "Page 1 sur 1";
            // 
            // btPrevious
            // 
            btPrevious.Location = new Point(453, 553);
            btPrevious.Name = "btPrevious";
            btPrevious.Size = new Size(75, 23);
            btPrevious.TabIndex = 21;
            btPrevious.Text = "Précédent";
            btPrevious.UseVisualStyleBackColor = true;
            btPrevious.Click += btPrevious_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(156, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(140, 32);
            lblTitle.TabIndex = 19;
            lblTitle.Text = "Mes achats";
            // 
            // FlpVehicles
            // 
            FlpVehicles.Anchor = AnchorStyles.None;
            FlpVehicles.AutoScroll = true;
            FlpVehicles.BackColor = Color.FromArgb(157, 110, 74);
            FlpVehicles.BorderStyle = BorderStyle.FixedSingle;
            FlpVehicles.Location = new Point(156, 81);
            FlpVehicles.Name = "FlpVehicles";
            FlpVehicles.Size = new Size(873, 436);
            FlpVehicles.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(497, 262);
            label1.Name = "label1";
            label1.Size = new Size(174, 32);
            label1.TabIndex = 24;
            label1.Text = "Chargement...";
            // 
            // UcMyPurchases
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(btNext);
            Controls.Add(lblPages);
            Controls.Add(btPrevious);
            Controls.Add(lblTitle);
            Controls.Add(FlpVehicles);
            Controls.Add(label1);
            MaximumSize = new Size(1184, 607);
            MinimumSize = new Size(1184, 607);
            Name = "UcMyPurchases";
            Size = new Size(1184, 607);
            Load += UcMyPurchases_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btNext;
        private Label lblPages;
        private Button btPrevious;
        private Label lblTitle;
        private FlowLayoutPanel FlpVehicles;
        private Label label1;
    }
}
