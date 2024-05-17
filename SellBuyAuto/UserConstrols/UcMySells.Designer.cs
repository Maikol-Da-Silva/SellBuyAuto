namespace SellBuyAuto
{
    partial class UcMySells
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
            lblCriteria = new Label();
            FlpVehicles = new FlowLayoutPanel();
            label1 = new Label();
            SuspendLayout();
            // 
            // btNext
            // 
            btNext.Location = new Point(634, 552);
            btNext.Name = "btNext";
            btNext.Size = new Size(75, 23);
            btNext.TabIndex = 11;
            btNext.Text = "Suivant";
            btNext.UseVisualStyleBackColor = true;
            btNext.Click += btNext_Click;
            // 
            // lblPages
            // 
            lblPages.AutoSize = true;
            lblPages.Location = new Point(541, 556);
            lblPages.Name = "lblPages";
            lblPages.Size = new Size(70, 15);
            lblPages.TabIndex = 10;
            lblPages.Text = "Page 1 sur 1";
            // 
            // btPrevious
            // 
            btPrevious.Location = new Point(436, 552);
            btPrevious.Name = "btPrevious";
            btPrevious.Size = new Size(75, 23);
            btPrevious.TabIndex = 9;
            btPrevious.Text = "Précédant";
            btPrevious.UseVisualStyleBackColor = true;
            btPrevious.Click += btPrevious_Click;
            // 
            // lblCriteria
            // 
            lblCriteria.AutoSize = true;
            lblCriteria.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCriteria.Location = new Point(39, 32);
            lblCriteria.Name = "lblCriteria";
            lblCriteria.Size = new Size(142, 32);
            lblCriteria.TabIndex = 7;
            lblCriteria.Text = "Mes ventes";
            // 
            // FlpVehicles
            // 
            FlpVehicles.Anchor = AnchorStyles.None;
            FlpVehicles.AutoScroll = true;
            FlpVehicles.BorderStyle = BorderStyle.FixedSingle;
            FlpVehicles.Location = new Point(39, 86);
            FlpVehicles.Name = "FlpVehicles";
            FlpVehicles.Size = new Size(1107, 436);
            FlpVehicles.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(497, 262);
            label1.Name = "label1";
            label1.Size = new Size(174, 32);
            label1.TabIndex = 12;
            label1.Text = "Chargement...";
            // 
            // UcMySells
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btNext);
            Controls.Add(lblPages);
            Controls.Add(btPrevious);
            Controls.Add(lblCriteria);
            Controls.Add(FlpVehicles);
            Controls.Add(label1);
            MaximumSize = new Size(1184, 607);
            MinimumSize = new Size(1184, 607);
            Name = "UcMySells";
            Size = new Size(1184, 607);
            Load += UcMySells_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btNext;
        private Label lblPages;
        private Button btPrevious;
        private Label lblCriteria;
        private FlowLayoutPanel FlpVehicles;
        private Label label1;
    }
}
