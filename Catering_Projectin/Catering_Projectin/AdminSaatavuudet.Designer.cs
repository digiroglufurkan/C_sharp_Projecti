namespace Catering_Projectin
{
    partial class AdminSaatavuudet
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
            this.AsetuksetTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.SalasanojenHallintaTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.MuokkaaProfiiliaTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.VaihdaSalasanaTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.KirjauduUlosTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.SaatavuudetDGV = new System.Windows.Forms.DataGridView();
            this.VaraaCo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.VaMaaraCo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TilaaLisaaCo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.MaTiLisaaCo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NavMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaatavuudetDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // OtsikkoLB
            // 
            this.OtsikkoLB.AutoSize = true;
            this.OtsikkoLB.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OtsikkoLB.Location = new System.Drawing.Point(460, 0);
            this.OtsikkoLB.Name = "OtsikkoLB";
            this.OtsikkoLB.Size = new System.Drawing.Size(286, 62);
            this.OtsikkoLB.TabIndex = 0;
            this.OtsikkoLB.Text = "Saatavuudet";
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
            this.AsetuksetTSMI});
            this.NavMS.Location = new System.Drawing.Point(345, 81);
            this.NavMS.Name = "NavMS";
            this.NavMS.Size = new System.Drawing.Size(530, 39);
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
            // SaatavuudetDGV
            // 
            this.SaatavuudetDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SaatavuudetDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VaraaCo,
            this.VaMaaraCo,
            this.TilaaLisaaCo,
            this.MaTiLisaaCo});
            this.SaatavuudetDGV.Location = new System.Drawing.Point(345, 171);
            this.SaatavuudetDGV.Name = "SaatavuudetDGV";
            this.SaatavuudetDGV.RowHeadersWidth = 51;
            this.SaatavuudetDGV.RowTemplate.Height = 29;
            this.SaatavuudetDGV.Size = new System.Drawing.Size(530, 239);
            this.SaatavuudetDGV.TabIndex = 2;
            // 
            // VaraaCo
            // 
            this.VaraaCo.HeaderText = "Varaa";
            this.VaraaCo.MinimumWidth = 6;
            this.VaraaCo.Name = "VaraaCo";
            this.VaraaCo.Width = 125;
            // 
            // VaMaaraCo
            // 
            this.VaMaaraCo.HeaderText = "Määrä";
            this.VaMaaraCo.MinimumWidth = 6;
            this.VaMaaraCo.Name = "VaMaaraCo";
            this.VaMaaraCo.Visible = false;
            this.VaMaaraCo.Width = 125;
            // 
            // TilaaLisaaCo
            // 
            this.TilaaLisaaCo.HeaderText = "Tilaa lisaa";
            this.TilaaLisaaCo.MinimumWidth = 6;
            this.TilaaLisaaCo.Name = "TilaaLisaaCo";
            this.TilaaLisaaCo.Width = 125;
            // 
            // MaTiLisaaCo
            // 
            this.MaTiLisaaCo.HeaderText = "Määrä";
            this.MaTiLisaaCo.MinimumWidth = 6;
            this.MaTiLisaaCo.Name = "MaTiLisaaCo";
            this.MaTiLisaaCo.Visible = false;
            this.MaTiLisaaCo.Width = 125;
            // 
            // AdminSaatavuudet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 533);
            this.Controls.Add(this.SaatavuudetDGV);
            this.Controls.Add(this.OtsikkoLB);
            this.Controls.Add(this.NavMS);
            this.MainMenuStrip = this.NavMS;
            this.Name = "AdminSaatavuudet";
            this.Text = "Admin saatavuudet";
            this.NavMS.ResumeLayout(false);
            this.NavMS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaatavuudetDGV)).EndInit();
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
        private ToolStripMenuItem KirjauduUlosTSMI;
        private ToolStripMenuItem VaihdaSalasanaTSMI;
        private DataGridView SaatavuudetDGV;
        private DataGridViewButtonColumn VaraaCo;
        private DataGridViewTextBoxColumn VaMaaraCo;
        private DataGridViewButtonColumn TilaaLisaaCo;
        private DataGridViewTextBoxColumn MaTiLisaaCo;
    }
}