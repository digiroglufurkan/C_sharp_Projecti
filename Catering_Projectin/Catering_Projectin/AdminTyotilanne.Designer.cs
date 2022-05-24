namespace Catering_Projectin
{
    partial class AdminTyotilanne
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
            this.TyotilanneDGV = new System.Windows.Forms.DataGridView();
            this.TilauksetDGV = new System.Windows.Forms.DataGridView();
            this.TilLB = new System.Windows.Forms.Label();
            this.TyoTilanneLB = new System.Windows.Forms.Label();
            this.IlmAsiakCo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.MaaraaCo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TekijaCo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.VahMaCo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.NavMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TyotilanneDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TilauksetDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // OtsikkoLB
            // 
            this.OtsikkoLB.AutoSize = true;
            this.OtsikkoLB.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OtsikkoLB.Location = new System.Drawing.Point(454, 0);
            this.OtsikkoLB.Name = "OtsikkoLB";
            this.OtsikkoLB.Size = new System.Drawing.Size(241, 62);
            this.OtsikkoLB.TabIndex = 0;
            this.OtsikkoLB.Text = "Työtilanne";
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
            this.NavMS.Location = new System.Drawing.Point(192, 77);
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
            // TyotilanneDGV
            // 
            this.TyotilanneDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TyotilanneDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IlmAsiakCo});
            this.TyotilanneDGV.Location = new System.Drawing.Point(581, 182);
            this.TyotilanneDGV.Name = "TyotilanneDGV";
            this.TyotilanneDGV.RowHeadersWidth = 51;
            this.TyotilanneDGV.RowTemplate.Height = 29;
            this.TyotilanneDGV.Size = new System.Drawing.Size(598, 225);
            this.TyotilanneDGV.TabIndex = 2;
            this.TyotilanneDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TyotilanneDGV_CellContentClick);
            // 
            // TilauksetDGV
            // 
            this.TilauksetDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TilauksetDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaaraaCo,
            this.TekijaCo,
            this.VahMaCo});
            this.TilauksetDGV.Location = new System.Drawing.Point(12, 182);
            this.TilauksetDGV.Name = "TilauksetDGV";
            this.TilauksetDGV.RowHeadersWidth = 51;
            this.TilauksetDGV.RowTemplate.Height = 29;
            this.TilauksetDGV.Size = new System.Drawing.Size(538, 225);
            this.TilauksetDGV.TabIndex = 3;
            this.TilauksetDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TilauksetDGV_CellContentClick);
            // 
            // TilLB
            // 
            this.TilLB.AutoSize = true;
            this.TilLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TilLB.Location = new System.Drawing.Point(192, 136);
            this.TilLB.Name = "TilLB";
            this.TilLB.Size = new System.Drawing.Size(88, 28);
            this.TilLB.TabIndex = 4;
            this.TilLB.Text = "Tilaukset";
            // 
            // TyoTilanneLB
            // 
            this.TyoTilanneLB.AutoSize = true;
            this.TyoTilanneLB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TyoTilanneLB.Location = new System.Drawing.Point(899, 136);
            this.TyoTilanneLB.Name = "TyoTilanneLB";
            this.TyoTilanneLB.Size = new System.Drawing.Size(92, 25);
            this.TyoTilanneLB.TabIndex = 5;
            this.TyoTilanneLB.Text = "Työtilanne";
            // 
            // IlmAsiakCo
            // 
            this.IlmAsiakCo.HeaderText = "Ilmoita";
            this.IlmAsiakCo.MinimumWidth = 6;
            this.IlmAsiakCo.Name = "IlmAsiakCo";
            this.IlmAsiakCo.Width = 125;
            // 
            // MaaraaCo
            // 
            this.MaaraaCo.HeaderText = "Määrää työ";
            this.MaaraaCo.MinimumWidth = 6;
            this.MaaraaCo.Name = "MaaraaCo";
            this.MaaraaCo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaaraaCo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.MaaraaCo.Width = 125;
            // 
            // TekijaCo
            // 
            this.TekijaCo.HeaderText = "Tunnus";
            this.TekijaCo.MinimumWidth = 6;
            this.TekijaCo.Name = "TekijaCo";
            this.TekijaCo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TekijaCo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TekijaCo.Visible = false;
            this.TekijaCo.Width = 125;
            // 
            // VahMaCo
            // 
            this.VahMaCo.HeaderText = "Vahvista";
            this.VahMaCo.MinimumWidth = 6;
            this.VahMaCo.Name = "VahMaCo";
            this.VahMaCo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.VahMaCo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.VahMaCo.Visible = false;
            this.VahMaCo.Width = 125;
            // 
            // AdminTyotilanne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 450);
            this.Controls.Add(this.TyoTilanneLB);
            this.Controls.Add(this.TilLB);
            this.Controls.Add(this.TilauksetDGV);
            this.Controls.Add(this.TyotilanneDGV);
            this.Controls.Add(this.OtsikkoLB);
            this.Controls.Add(this.NavMS);
            this.MainMenuStrip = this.NavMS;
            this.Name = "AdminTyotilanne";
            this.Text = "Admin työtilanne";
            this.Load += new System.EventHandler(this.AdminTyotilanne_Load);
            this.NavMS.ResumeLayout(false);
            this.NavMS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TyotilanneDGV)).EndInit();
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
        private DataGridView TyotilanneDGV;
        private ToolStripMenuItem KayttajatTSMI;
        private DataGridViewButtonColumn IlmAsiakCo;
        private DataGridView TilauksetDGV;
        private DataGridViewButtonColumn MaaraaCo;
        private DataGridViewComboBoxColumn TekijaCo;
        private DataGridViewButtonColumn VahMaCo;
        private Label TilLB;
        private Label TyoTilanneLB;
    }
}