namespace Catering_Projectin
{
    partial class AdminKotisivu
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
            this.OtsikkoLB = new System.Windows.Forms.Label();
            this.NavMS = new System.Windows.Forms.MenuStrip();
            this.KotisivuTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.SaatavuudetTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.TyotilanneTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.KayttajatTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.AsetuksetTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.SalasanojenHallintaTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.MuokkaaProfiiliaTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.VaihdaSalasanaTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.KirjauduUlosTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.TilauksetDGV = new System.Windows.Forms.DataGridView();
            this.TilOtLB = new System.Windows.Forms.Label();
            this.NavMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TilauksetDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // OtsikkoLB
            // 
            this.OtsikkoLB.AutoSize = true;
            this.OtsikkoLB.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OtsikkoLB.Location = new System.Drawing.Point(454, -1);
            this.OtsikkoLB.Name = "OtsikkoLB";
            this.OtsikkoLB.Size = new System.Drawing.Size(189, 62);
            this.OtsikkoLB.TabIndex = 0;
            this.OtsikkoLB.Text = "Kotisivu";
            // 
            // NavMS
            // 
            this.NavMS.Dock = System.Windows.Forms.DockStyle.None;
            this.NavMS.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NavMS.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.NavMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.KotisivuTSMI,
            this.SaatavuudetTSMI,
            this.TyotilanneTSMI,
            this.KayttajatTSMI,
            this.AsetuksetTSMI});
            this.NavMS.Location = new System.Drawing.Point(156, 75);
            this.NavMS.Name = "NavMS";
            this.NavMS.Size = new System.Drawing.Size(773, 39);
            this.NavMS.TabIndex = 1;
            this.NavMS.Text = "menuStrip1";
            // 
            // KotisivuTSMI
            // 
            this.KotisivuTSMI.Name = "KotisivuTSMI";
            this.KotisivuTSMI.Size = new System.Drawing.Size(107, 35);
            this.KotisivuTSMI.Text = "Kotisivu";
            this.KotisivuTSMI.Click += new System.EventHandler(this.KotisivuTSMI_Click);
            // 
            // SaatavuudetTSMI
            // 
            this.SaatavuudetTSMI.Name = "SaatavuudetTSMI";
            this.SaatavuudetTSMI.Size = new System.Drawing.Size(155, 35);
            this.SaatavuudetTSMI.Text = "Saatavuudet";
            this.SaatavuudetTSMI.Click += new System.EventHandler(this.SaatavuudetTSMI_Click);
            // 
            // TyotilanneTSMI
            // 
            this.TyotilanneTSMI.Name = "TyotilanneTSMI";
            this.TyotilanneTSMI.Size = new System.Drawing.Size(133, 35);
            this.TyotilanneTSMI.Text = "Työtilanne";
            this.TyotilanneTSMI.Click += new System.EventHandler(this.TyotilanneTSMI_Click);
            // 
            // KayttajatTSMI
            // 
            this.KayttajatTSMI.Name = "KayttajatTSMI";
            this.KayttajatTSMI.Size = new System.Drawing.Size(243, 35);
            this.KayttajatTSMI.Text = "Käyttäjätilien hallinta";
            this.KayttajatTSMI.Click += new System.EventHandler(this.KayttajatTSMI_Click);
            // 
            // AsetuksetTSMI
            // 
            this.AsetuksetTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SalasanojenHallintaTSMI,
            this.MuokkaaProfiiliaTSMI,
            this.VaihdaSalasanaTSMI,
            this.KirjauduUlosTSMI});
            this.AsetuksetTSMI.Name = "AsetuksetTSMI";
            this.AsetuksetTSMI.Size = new System.Drawing.Size(127, 35);
            this.AsetuksetTSMI.Text = "Asetukset";
            // 
            // SalasanojenHallintaTSMI
            // 
            this.SalasanojenHallintaTSMI.Name = "SalasanojenHallintaTSMI";
            this.SalasanojenHallintaTSMI.Size = new System.Drawing.Size(305, 36);
            this.SalasanojenHallintaTSMI.Text = "Salasanojen hallinta";
            this.SalasanojenHallintaTSMI.Click += new System.EventHandler(this.SalasanojenHallintaTSMI_Click);
            // 
            // MuokkaaProfiiliaTSMI
            // 
            this.MuokkaaProfiiliaTSMI.Name = "MuokkaaProfiiliaTSMI";
            this.MuokkaaProfiiliaTSMI.Size = new System.Drawing.Size(305, 36);
            this.MuokkaaProfiiliaTSMI.Text = "Muokkaa profiilia";
            this.MuokkaaProfiiliaTSMI.Click += new System.EventHandler(this.MuokkaaProfiiliaTSMI_Click);
            // 
            // VaihdaSalasanaTSMI
            // 
            this.VaihdaSalasanaTSMI.Name = "VaihdaSalasanaTSMI";
            this.VaihdaSalasanaTSMI.Size = new System.Drawing.Size(305, 36);
            this.VaihdaSalasanaTSMI.Text = "Vaihda salasana";
            this.VaihdaSalasanaTSMI.Click += new System.EventHandler(this.VaihdaSalasanaTSMI_Click);
            // 
            // KirjauduUlosTSMI
            // 
            this.KirjauduUlosTSMI.Name = "KirjauduUlosTSMI";
            this.KirjauduUlosTSMI.Size = new System.Drawing.Size(305, 36);
            this.KirjauduUlosTSMI.Text = "Kirjaudu ulos";
            this.KirjauduUlosTSMI.Click += new System.EventHandler(this.KirjauduUlosTSMI_Click);
            // 
            // TilauksetDGV
            // 
            this.TilauksetDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TilauksetDGV.Location = new System.Drawing.Point(292, 186);
            this.TilauksetDGV.Name = "TilauksetDGV";
            this.TilauksetDGV.RowHeadersWidth = 51;
            this.TilauksetDGV.RowTemplate.Height = 29;
            this.TilauksetDGV.Size = new System.Drawing.Size(513, 297);
            this.TilauksetDGV.TabIndex = 2;
            // 
            // TilOtLB
            // 
            this.TilOtLB.AutoSize = true;
            this.TilOtLB.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TilOtLB.Location = new System.Drawing.Point(472, 126);
            this.TilOtLB.Name = "TilOtLB";
            this.TilOtLB.Size = new System.Drawing.Size(134, 41);
            this.TilOtLB.TabIndex = 3;
            this.TilOtLB.Text = "Tilaukset";
            // 
            // AdminKotisivu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 538);
            this.Controls.Add(this.TilOtLB);
            this.Controls.Add(this.TilauksetDGV);
            this.Controls.Add(this.OtsikkoLB);
            this.Controls.Add(this.NavMS);
            this.MainMenuStrip = this.NavMS;
            this.Name = "AdminKotisivu";
            this.Text = "Admin kotisivu";
            this.Load += new System.EventHandler(this.AdminKotisivu_Load);
            this.NavMS.ResumeLayout(false);
            this.NavMS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TilauksetDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label OtsikkoLB;
        private MenuStrip NavMS;
        private ToolStripMenuItem KotisivuTSMI;
        private ToolStripMenuItem SaatavuudetTSMI;
        private ToolStripMenuItem TyotilanneTSMI;
        private ToolStripMenuItem AsetuksetTSMI;
        private ToolStripMenuItem SalasanojenHallintaTSMI;
        private ToolStripMenuItem MuokkaaProfiiliaTSMI;
        private ToolStripMenuItem VaihdaSalasanaTSMI;
        private ToolStripMenuItem KirjauduUlosTSMI;
        private DataGridView TilauksetDGV;
        private ToolStripMenuItem KayttajatTSMI;
        private Label TilOtLB;
    }
}