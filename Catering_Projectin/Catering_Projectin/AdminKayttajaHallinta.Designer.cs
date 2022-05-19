namespace Catering_Projectin
{
    partial class AdminKayttajaHallinta
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
            this.KaytHallintaDGV = new System.Windows.Forms.DataGridView();
            this.OtsikkoLB = new System.Windows.Forms.Label();
            this.NavMS = new System.Windows.Forms.MenuStrip();
            this.KotisivuTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.SaatavuudetTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.TyotilanneTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.KayttajaHallintaTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.AsetuksetTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.SalasanojenHallintaTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.MuokkaaProfiiliaTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.VaihdaSalasanaTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.KirjauduUlosTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.PoistaCo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.LiAdminCo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PoAdminCo = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.KaytHallintaDGV)).BeginInit();
            this.NavMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // KaytHallintaDGV
            // 
            this.KaytHallintaDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KaytHallintaDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PoistaCo,
            this.LiAdminCo,
            this.PoAdminCo});
            this.KaytHallintaDGV.Location = new System.Drawing.Point(294, 173);
            this.KaytHallintaDGV.Name = "KaytHallintaDGV";
            this.KaytHallintaDGV.RowHeadersWidth = 51;
            this.KaytHallintaDGV.RowTemplate.Height = 29;
            this.KaytHallintaDGV.Size = new System.Drawing.Size(586, 271);
            this.KaytHallintaDGV.TabIndex = 0;
            this.KaytHallintaDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.KaytHallintaDGV_CellContentClick);
            // 
            // OtsikkoLB
            // 
            this.OtsikkoLB.AutoSize = true;
            this.OtsikkoLB.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OtsikkoLB.Location = new System.Drawing.Point(375, 0);
            this.OtsikkoLB.Name = "OtsikkoLB";
            this.OtsikkoLB.Size = new System.Drawing.Size(457, 62);
            this.OtsikkoLB.TabIndex = 1;
            this.OtsikkoLB.Text = "Käyttäjätilien hallinta";
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
            this.KayttajaHallintaTSMI,
            this.AsetuksetTSMI});
            this.NavMS.Location = new System.Drawing.Point(193, 76);
            this.NavMS.Name = "NavMS";
            this.NavMS.Size = new System.Drawing.Size(773, 39);
            this.NavMS.TabIndex = 2;
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
            // KayttajaHallintaTSMI
            // 
            this.KayttajaHallintaTSMI.Name = "KayttajaHallintaTSMI";
            this.KayttajaHallintaTSMI.Size = new System.Drawing.Size(243, 35);
            this.KayttajaHallintaTSMI.Text = "Käyttäjätilien hallinta";
            this.KayttajaHallintaTSMI.Click += new System.EventHandler(this.KayttajaHallintaTSMI_Click);
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
            // PoistaCo
            // 
            this.PoistaCo.HeaderText = "Poista";
            this.PoistaCo.MinimumWidth = 6;
            this.PoistaCo.Name = "PoistaCo";
            this.PoistaCo.Width = 125;
            // 
            // LiAdminCo
            // 
            this.LiAdminCo.HeaderText = "Lisää admin";
            this.LiAdminCo.MinimumWidth = 6;
            this.LiAdminCo.Name = "LiAdminCo";
            this.LiAdminCo.Width = 125;
            // 
            // PoAdminCo
            // 
            this.PoAdminCo.HeaderText = "Poista admin";
            this.PoAdminCo.MinimumWidth = 6;
            this.PoAdminCo.Name = "PoAdminCo";
            this.PoAdminCo.Width = 125;
            // 
            // AdminKayttajaHallinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 546);
            this.Controls.Add(this.OtsikkoLB);
            this.Controls.Add(this.KaytHallintaDGV);
            this.Controls.Add(this.NavMS);
            this.MainMenuStrip = this.NavMS;
            this.Name = "AdminKayttajaHallinta";
            this.Text = "Käyttajätilien hallinta";
            this.Load += new System.EventHandler(this.AdminKayttajaHallinta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KaytHallintaDGV)).EndInit();
            this.NavMS.ResumeLayout(false);
            this.NavMS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView KaytHallintaDGV;
        private Label OtsikkoLB;
        private MenuStrip NavMS;
        private ToolStripMenuItem KotisivuTSMI;
        private ToolStripMenuItem SaatavuudetTSMI;
        private ToolStripMenuItem TyotilanneTSMI;
        private ToolStripMenuItem KayttajaHallintaTSMI;
        private ToolStripMenuItem AsetuksetTSMI;
        private ToolStripMenuItem SalasanojenHallintaTSMI;
        private ToolStripMenuItem MuokkaaProfiiliaTSMI;
        private ToolStripMenuItem VaihdaSalasanaTSMI;
        private ToolStripMenuItem KirjauduUlosTSMI;
        private DataGridViewButtonColumn PoistaCo;
        private DataGridViewButtonColumn LiAdminCo;
        private DataGridViewButtonColumn PoAdminCo;
    }
}