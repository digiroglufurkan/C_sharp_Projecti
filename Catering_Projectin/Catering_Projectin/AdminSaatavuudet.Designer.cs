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
            this.AteriaSaatavuudetDGV = new System.Windows.Forms.DataGridView();
            this.JuomatDGV = new System.Windows.Forms.DataGridView();
            this.JuomatAlkoDGV = new System.Windows.Forms.DataGridView();
            this.KayttajatTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TilaaLiCo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.MaTilaaCo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TiMaaraCo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VaraaCo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.VaMaaraCo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VahVarCo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TilaaLisaaCo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.MaTiLisaaCo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VahTilCo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.NavMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AteriaSaatavuudetDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JuomatDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JuomatAlkoDGV)).BeginInit();
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
            this.KayttajatTSMI,
            this.AsetuksetTSMI});
            this.NavMS.Location = new System.Drawing.Point(218, 77);
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
            // AteriaSaatavuudetDGV
            // 
            this.AteriaSaatavuudetDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AteriaSaatavuudetDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VaraaCo,
            this.VaMaaraCo,
            this.VahVarCo,
            this.TilaaLisaaCo,
            this.MaTiLisaaCo,
            this.VahTilCo});
            this.AteriaSaatavuudetDGV.Location = new System.Drawing.Point(12, 193);
            this.AteriaSaatavuudetDGV.Name = "AteriaSaatavuudetDGV";
            this.AteriaSaatavuudetDGV.RowHeadersWidth = 51;
            this.AteriaSaatavuudetDGV.RowTemplate.Height = 29;
            this.AteriaSaatavuudetDGV.Size = new System.Drawing.Size(389, 239);
            this.AteriaSaatavuudetDGV.TabIndex = 2;
            this.AteriaSaatavuudetDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AteriaSaatavuudetDGV_CellContentClick);
            // 
            // JuomatDGV
            // 
            this.JuomatDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.JuomatDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.TilaaLiCo,
            this.MaTilaaCo});
            this.JuomatDGV.Location = new System.Drawing.Point(460, 193);
            this.JuomatDGV.Name = "JuomatDGV";
            this.JuomatDGV.RowHeadersWidth = 51;
            this.JuomatDGV.RowTemplate.Height = 29;
            this.JuomatDGV.Size = new System.Drawing.Size(387, 239);
            this.JuomatDGV.TabIndex = 3;
            this.JuomatDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.JuomatDGV_CellContentClick);
            // 
            // JuomatAlkoDGV
            // 
            this.JuomatAlkoDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.JuomatAlkoDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewButtonColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewButtonColumn2,
            this.TiMaaraCo});
            this.JuomatAlkoDGV.Location = new System.Drawing.Point(867, 193);
            this.JuomatAlkoDGV.Name = "JuomatAlkoDGV";
            this.JuomatAlkoDGV.RowHeadersWidth = 51;
            this.JuomatAlkoDGV.RowTemplate.Height = 29;
            this.JuomatAlkoDGV.Size = new System.Drawing.Size(348, 239);
            this.JuomatAlkoDGV.TabIndex = 4;
            this.JuomatAlkoDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.JuomatAlkoDGV_CellContentClick);
            // 
            // KayttajatTSMI
            // 
            this.KayttajatTSMI.Name = "KayttajatTSMI";
            this.KayttajatTSMI.Size = new System.Drawing.Size(243, 35);
            this.KayttajatTSMI.Text = "Käyttäjätilien hallinta";
            this.KayttajatTSMI.Click += new System.EventHandler(this.KayttajatTSMI_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Varaa";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Määrä";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // TilaaLiCo
            // 
            this.TilaaLiCo.HeaderText = "Tilaa lisää";
            this.TilaaLiCo.MinimumWidth = 6;
            this.TilaaLiCo.Name = "TilaaLiCo";
            this.TilaaLiCo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TilaaLiCo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TilaaLiCo.Width = 125;
            // 
            // MaTilaaCo
            // 
            this.MaTilaaCo.HeaderText = "Määrä";
            this.MaTilaaCo.MinimumWidth = 6;
            this.MaTilaaCo.Name = "MaTilaaCo";
            this.MaTilaaCo.Visible = false;
            this.MaTilaaCo.Width = 125;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "Varaa";
            this.dataGridViewButtonColumn1.MinimumWidth = 6;
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Määrä";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewButtonColumn2
            // 
            this.dataGridViewButtonColumn2.HeaderText = "Tilaa lisää";
            this.dataGridViewButtonColumn2.MinimumWidth = 6;
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.Width = 125;
            // 
            // TiMaaraCo
            // 
            this.TiMaaraCo.HeaderText = "Määrä";
            this.TiMaaraCo.MinimumWidth = 6;
            this.TiMaaraCo.Name = "TiMaaraCo";
            this.TiMaaraCo.Visible = false;
            this.TiMaaraCo.Width = 125;
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
            // VahVarCo
            // 
            this.VahVarCo.HeaderText = "Vahvista varaus";
            this.VahVarCo.MinimumWidth = 6;
            this.VahVarCo.Name = "VahVarCo";
            this.VahVarCo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.VahVarCo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.VahVarCo.Visible = false;
            this.VahVarCo.Width = 125;
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
            // VahTilCo
            // 
            this.VahTilCo.HeaderText = "Vahvista tilaus";
            this.VahTilCo.MinimumWidth = 6;
            this.VahTilCo.Name = "VahTilCo";
            this.VahTilCo.Visible = false;
            this.VahTilCo.Width = 125;
            // 
            // AdminSaatavuudet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 533);
            this.Controls.Add(this.JuomatAlkoDGV);
            this.Controls.Add(this.JuomatDGV);
            this.Controls.Add(this.AteriaSaatavuudetDGV);
            this.Controls.Add(this.OtsikkoLB);
            this.Controls.Add(this.NavMS);
            this.MainMenuStrip = this.NavMS;
            this.Name = "AdminSaatavuudet";
            this.Text = "Admin saatavuudet";
            this.Load += new System.EventHandler(this.AdminSaatavuudet_Load);
            this.NavMS.ResumeLayout(false);
            this.NavMS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AteriaSaatavuudetDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JuomatDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JuomatAlkoDGV)).EndInit();
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
        private DataGridView AteriaSaatavuudetDGV;
        private DataGridView JuomatDGV;
        private DataGridView JuomatAlkoDGV;
        private ToolStripMenuItem KayttajatTSMI;
        private DataGridViewButtonColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewButtonColumn TilaaLiCo;
        private DataGridViewTextBoxColumn MaTilaaCo;
        private DataGridViewButtonColumn dataGridViewButtonColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewButtonColumn dataGridViewButtonColumn2;
        private DataGridViewTextBoxColumn TiMaaraCo;
        private DataGridViewButtonColumn VaraaCo;
        private DataGridViewTextBoxColumn VaMaaraCo;
        private DataGridViewButtonColumn VahVarCo;
        private DataGridViewButtonColumn TilaaLisaaCo;
        private DataGridViewTextBoxColumn MaTiLisaaCo;
        private DataGridViewButtonColumn VahTilCo;
    }
}