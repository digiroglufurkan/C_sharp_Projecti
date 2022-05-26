namespace Catering_Projectin
{
    partial class KokkiKotisivu
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.kokkotiMS = new System.Windows.Forms.MenuStrip();
            this.kokkikotiMS = new System.Windows.Forms.ToolStripMenuItem();
            this.kokkiruoatMS = new System.Windows.Forms.ToolStripMenuItem();
            this.kokkiasetuksetMS = new System.Windows.Forms.ToolStripMenuItem();
            this.kokkiprofMS = new System.Windows.Forms.ToolStripMenuItem();
            this.kokkisalisMS = new System.Windows.Forms.ToolStripMenuItem();
            this.kokkiulosMS = new System.Windows.Forms.ToolStripMenuItem();
            this.koktilanneDG = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lahetaTilanneBT = new System.Windows.Forms.DataGridViewButtonColumn();
            this.statusC = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.kokkotiMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.koktilanneDG)).BeginInit();
            this.SuspendLayout();
            // 
            // kokkotiMS
            // 
            this.kokkotiMS.Dock = System.Windows.Forms.DockStyle.None;
            this.kokkotiMS.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kokkotiMS.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.kokkotiMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kokkikotiMS,
            this.kokkiruoatMS,
            this.kokkiasetuksetMS});
            this.kokkotiMS.Location = new System.Drawing.Point(21, 51);
            this.kokkotiMS.Name = "kokkotiMS";
            this.kokkotiMS.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.kokkotiMS.Size = new System.Drawing.Size(274, 33);
            this.kokkotiMS.TabIndex = 3;
            this.kokkotiMS.Text = "menuStrip1";
            // 
            // kokkikotiMS
            // 
            this.kokkikotiMS.Name = "kokkikotiMS";
            this.kokkikotiMS.Size = new System.Drawing.Size(90, 29);
            this.kokkikotiMS.Text = "Kotisivu";
            // 
            // kokkiruoatMS
            // 
            this.kokkiruoatMS.Name = "kokkiruoatMS";
            this.kokkiruoatMS.Size = new System.Drawing.Size(73, 29);
            this.kokkiruoatMS.Text = "Ruoat";
            this.kokkiruoatMS.Click += new System.EventHandler(this.kokkiruoatMS_Click);
            // 
            // kokkiasetuksetMS
            // 
            this.kokkiasetuksetMS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kokkiprofMS,
            this.kokkisalisMS,
            this.kokkiulosMS});
            this.kokkiasetuksetMS.Name = "kokkiasetuksetMS";
            this.kokkiasetuksetMS.Size = new System.Drawing.Size(104, 29);
            this.kokkiasetuksetMS.Text = "Asetukset";
            // 
            // kokkiprofMS
            // 
            this.kokkiprofMS.Name = "kokkiprofMS";
            this.kokkiprofMS.Size = new System.Drawing.Size(231, 30);
            this.kokkiprofMS.Text = "Muokkaa profiilia";
            this.kokkiprofMS.Click += new System.EventHandler(this.kokkiprofMS_Click);
            // 
            // kokkisalisMS
            // 
            this.kokkisalisMS.Name = "kokkisalisMS";
            this.kokkisalisMS.Size = new System.Drawing.Size(231, 30);
            this.kokkisalisMS.Text = "Vaihda salasana";
            this.kokkisalisMS.Click += new System.EventHandler(this.kokkisalisMS_Click);
            // 
            // kokkiulosMS
            // 
            this.kokkiulosMS.Name = "kokkiulosMS";
            this.kokkiulosMS.Size = new System.Drawing.Size(231, 30);
            this.kokkiulosMS.Text = "Kirjaudu ulos";
            this.kokkiulosMS.Click += new System.EventHandler(this.kokkiulosMS_Click);
            // 
            // koktilanneDG
            // 
            this.koktilanneDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.koktilanneDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lahetaTilanneBT,
            this.statusC});
            this.koktilanneDG.Location = new System.Drawing.Point(188, 129);
            this.koktilanneDG.Name = "koktilanneDG";
            this.koktilanneDG.RowTemplate.Height = 25;
            this.koktilanneDG.Size = new System.Drawing.Size(561, 382);
            this.koktilanneDG.TabIndex = 4;
            this.koktilanneDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.koktilanneDG_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(419, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Työtilanne";
            // 
            // lahetaTilanneBT
            // 
            this.lahetaTilanneBT.Frozen = true;
            this.lahetaTilanneBT.HeaderText = "Lähetä";
            this.lahetaTilanneBT.MinimumWidth = 50;
            this.lahetaTilanneBT.Name = "lahetaTilanneBT";
            // 
            // statusC
            // 
            this.statusC.FillWeight = 200F;
            this.statusC.HeaderText = "Status";
            this.statusC.MinimumWidth = 20;
            this.statusC.Name = "statusC";
            this.statusC.Width = 120;
            // 
            // KokkiKotisivu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 550);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.koktilanneDG);
            this.Controls.Add(this.kokkotiMS);
            this.Name = "KokkiKotisivu";
            this.Text = "KokkiKotisivu";
            this.Load += new System.EventHandler(this.KokkiKotisivu_Load);
            this.kokkotiMS.ResumeLayout(false);
            this.kokkotiMS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.koktilanneDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip kokkotiMS;
        private ToolStripMenuItem kokkikotiMS;
        private ToolStripMenuItem kokkiruoatMS;
        private ToolStripMenuItem kokkiasetuksetMS;
        private ToolStripMenuItem kokkiprofMS;
        private ToolStripMenuItem kokkisalisMS;
        private ToolStripMenuItem kokkiulosMS;
        private DataGridView koktilanneDG;
        private Label label1;
        private DataGridViewButtonColumn lahetaTilanneBT;
        private DataGridViewComboBoxColumn statusC;
    }
}