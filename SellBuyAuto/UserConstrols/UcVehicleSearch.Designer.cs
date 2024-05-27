namespace SellBuyAuto
{
    partial class UcVehicleSearch
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
            lblCriteria = new Label();
            FlpVehicles = new FlowLayoutPanel();
            btPrevious = new Button();
            lblPages = new Label();
            btNext = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblCriteria
            // 
            lblCriteria.AutoSize = true;
            lblCriteria.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCriteria.Location = new Point(156, 22);
            lblCriteria.Name = "lblCriteria";
            lblCriteria.Size = new Size(286, 32);
            lblCriteria.TabIndex = 0;
            lblCriteria.Text = "Résultat de la recherche";
            // 
            // FlpVehicles
            // 
            FlpVehicles.Anchor = AnchorStyles.None;
            FlpVehicles.AutoScroll = true;
            FlpVehicles.BackColor = Color.FromArgb(157, 110, 74);
            FlpVehicles.BorderStyle = BorderStyle.FixedSingle;
            FlpVehicles.ForeColor = SystemColors.ControlLightLight;
            FlpVehicles.Location = new Point(156, 81);
            FlpVehicles.Name = "FlpVehicles";
            FlpVehicles.Size = new Size(873, 436);
            FlpVehicles.TabIndex = 1;
            // 
            // btPrevious
            // 
            btPrevious.Location = new Point(453, 547);
            btPrevious.Name = "btPrevious";
            btPrevious.Size = new Size(75, 23);
            btPrevious.TabIndex = 2;
            btPrevious.Text = "Précédent";
            btPrevious.UseVisualStyleBackColor = true;
            btPrevious.Click += btPrevious_Click;
            // 
            // lblPages
            // 
            lblPages.AutoSize = true;
            lblPages.BackColor = Color.FromArgb(157, 110, 74);
            lblPages.ForeColor = SystemColors.ControlLightLight;
            lblPages.Location = new Point(558, 551);
            lblPages.Name = "lblPages";
            lblPages.Size = new Size(70, 15);
            lblPages.TabIndex = 4;
            lblPages.Text = "Page 1 sur 4";
            // 
            // btNext
            // 
            btNext.Location = new Point(651, 547);
            btNext.Name = "btNext";
            btNext.Size = new Size(75, 23);
            btNext.TabIndex = 5;
            btNext.Text = "Suivant";
            btNext.UseVisualStyleBackColor = true;
            btNext.Click += btNext_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(494, 257);
            label1.Name = "label1";
            label1.Size = new Size(174, 32);
            label1.TabIndex = 6;
            label1.Text = "Chargement...";
            // 
            // UcVehicleSearch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(btNext);
            Controls.Add(lblPages);
            Controls.Add(btPrevious);
            Controls.Add(lblCriteria);
            Controls.Add(FlpVehicles);
            Controls.Add(label1);
            MaximumSize = new Size(1184, 607);
            MinimumSize = new Size(1184, 607);
            Name = "UcVehicleSearch";
            Size = new Size(1184, 607);
            Load += UcVehicleSearch_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCriteria;
        private FlowLayoutPanel FlpVehicles;
        private Button btPrevious;
        private Label lblPages;
        private Button btNext;
        private Label label1;
    }
}
