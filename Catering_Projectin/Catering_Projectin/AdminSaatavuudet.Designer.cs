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
            this.KayttajatTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.AsetuksetTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.SalasanojenHallintaTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.MuokkaaProfiiliaTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.VaihdaSalasanaTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.KirjauduUlosTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.AteriaSaatavuudetDGV = new System.Windows.Forms.DataGridView();
            this.VaraaCo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.VaMaaraCo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VahVarCo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TilaaLisaaCo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.MaTiLisaaCo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VahTilCo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.JuomatDGV = new System.Windows.Forms.DataGridView();
            this.VaraaJuCo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.VaJuMaaraCo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VahJuVa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TilaaLiJuCo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.MaTilaaJuCo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VahTiJuCo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.JuomatAlkoDGV = new System.Windows.Forms.DataGridView();
            this.VarAlkoCO = new System.Windows.Forms.DataGridViewButtonColumn();
            this.VarAlkoMaCo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VahAlkoVarCo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TilaaAlkoCo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TilAlkoMaaraCo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VahAlkoTilCo = new System.Windows.Forms.DataGridViewButtonColumn();
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
            // JuomatDGV
            // 
            this.JuomatDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.JuomatDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VaraaJuCo,
            this.VaJuMaaraCo,
            this.VahJuVa,
            this.TilaaLiJuCo,
            this.MaTilaaJuCo,
            this.VahTiJuCo});
            this.JuomatDGV.Location = new System.Drawing.Point(460, 193);
            this.JuomatDGV.Name = "JuomatDGV";
            this.JuomatDGV.RowHeadersWidth = 51;
            this.JuomatDGV.RowTemplate.Height = 29;
            this.JuomatDGV.Size = new System.Drawing.Size(387, 239);
            this.JuomatDGV.TabIndex = 3;
            this.JuomatDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.JuomatDGV_CellContentClick);
            // 
            // VaraaJuCo
            // 
            this.VaraaJuCo.HeaderText = "Varaa";
            this.VaraaJuCo.MinimumWidth = 6;
            this.VaraaJuCo.Name = "VaraaJuCo";
            this.VaraaJuCo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.VaraaJuCo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.VaraaJuCo.Width = 125;
            // 
            // VaJuMaaraCo
            // 
            this.VaJuMaaraCo.HeaderText = "Määrä";
            this.VaJuMaaraCo.MinimumWidth = 6;
            this.VaJuMaaraCo.Name = "VaJuMaaraCo";
            this.VaJuMaaraCo.Visible = false;
            this.VaJuMaaraCo.Width = 125;
            // 
            // VahJuVa
            // 
            this.VahJuVa.HeaderText = "Vahvista varaus";
            this.VahJuVa.MinimumWidth = 6;
            this.VahJuVa.Name = "VahJuVa";
            this.VahJuVa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.VahJuVa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.VahJuVa.Visible = false;
            this.VahJuVa.Width = 125;
            // 
            // TilaaLiJuCo
            // 
            this.TilaaLiJuCo.HeaderText = "Tilaa lisää";
            this.TilaaLiJuCo.MinimumWidth = 6;
            this.TilaaLiJuCo.Name = "TilaaLiJuCo";
            this.TilaaLiJuCo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TilaaLiJuCo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TilaaLiJuCo.Width = 125;
            // 
            // MaTilaaJuCo
            // 
            this.MaTilaaJuCo.HeaderText = "Määrä";
            this.MaTilaaJuCo.MinimumWidth = 6;
            this.MaTilaaJuCo.Name = "MaTilaaJuCo";
            this.MaTilaaJuCo.Visible = false;
            this.MaTilaaJuCo.Width = 125;
            // 
            // VahTiJuCo
            // 
            this.VahTiJuCo.HeaderText = "Vahvista tilaus";
            this.VahTiJuCo.MinimumWidth = 6;
            this.VahTiJuCo.Name = "VahTiJuCo";
            this.VahTiJuCo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.VahTiJuCo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.VahTiJuCo.Visible = false;
            this.VahTiJuCo.Width = 125;
            // 
            // JuomatAlkoDGV
            // 
            this.JuomatAlkoDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.JuomatAlkoDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VarAlkoCO,
            this.VarAlkoMaCo,
            this.VahAlkoVarCo,
            this.TilaaAlkoCo,
            this.TilAlkoMaaraCo,
            this.VahAlkoTilCo});
            this.JuomatAlkoDGV.Location = new System.Drawing.Point(925, 193);
            this.JuomatAlkoDGV.Name = "JuomatAlkoDGV";
            this.JuomatAlkoDGV.RowHeadersWidth = 51;
            this.JuomatAlkoDGV.RowTemplate.Height = 29;
            this.JuomatAlkoDGV.Size = new System.Drawing.Size(348, 239);
            this.JuomatAlkoDGV.TabIndex = 4;
            this.JuomatAlkoDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.JuomatAlkoDGV_CellContentClick);
            // 
            // VarAlkoCO
            // 
            this.VarAlkoCO.HeaderText = "Varaa";
            this.VarAlkoCO.MinimumWidth = 6;
            this.VarAlkoCO.Name = "VarAlkoCO";
            this.VarAlkoCO.Width = 125;
            // 
            // VarAlkoMaCo
            // 
            this.VarAlkoMaCo.HeaderText = "Määrä";
            this.VarAlkoMaCo.MinimumWidth = 6;
            this.VarAlkoMaCo.Name = "VarAlkoMaCo";
            this.VarAlkoMaCo.Visible = false;
            this.VarAlkoMaCo.Width = 125;
            // 
            // VahAlkoVarCo
            // 
            this.VahAlkoVarCo.HeaderText = "Vahvista";
            this.VahAlkoVarCo.MinimumWidth = 6;
            this.VahAlkoVarCo.Name = "VahAlkoVarCo";
            this.VahAlkoVarCo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.VahAlkoVarCo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.VahAlkoVarCo.Visible = false;
            this.VahAlkoVarCo.Width = 125;
            // 
            // TilaaAlkoCo
            // 
            this.TilaaAlkoCo.HeaderText = "Tilaa lisää";
            this.TilaaAlkoCo.MinimumWidth = 6;
            this.TilaaAlkoCo.Name = "TilaaAlkoCo";
            this.TilaaAlkoCo.Width = 125;
            // 
            // TilAlkoMaaraCo
            // 
            this.TilAlkoMaaraCo.HeaderText = "Määrä";
            this.TilAlkoMaaraCo.MinimumWidth = 6;
            this.TilAlkoMaaraCo.Name = "TilAlkoMaaraCo";
            this.TilAlkoMaaraCo.Visible = false;
            this.TilAlkoMaaraCo.Width = 125;
            // 
            // VahAlkoTilCo
            // 
            this.VahAlkoTilCo.HeaderText = "Vahvista";
            this.VahAlkoTilCo.MinimumWidth = 6;
            this.VahAlkoTilCo.Name = "VahAlkoTilCo";
            this.VahAlkoTilCo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.VahAlkoTilCo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.VahAlkoTilCo.Visible = false;
            this.VahAlkoTilCo.Width = 125;
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
        private DataGridViewButtonColumn VaraaCo;
        private DataGridViewTextBoxColumn VaMaaraCo;
        private DataGridViewButtonColumn VahVarCo;
        private DataGridViewButtonColumn TilaaLisaaCo;
        private DataGridViewTextBoxColumn MaTiLisaaCo;
        private DataGridViewButtonColumn VahTilCo;
        private DataGridViewButtonColumn VaraaJuCo;
        private DataGridViewTextBoxColumn VaJuMaaraCo;
        private DataGridViewButtonColumn VahJuVa;
        private DataGridViewButtonColumn TilaaLiJuCo;
        private DataGridViewTextBoxColumn MaTilaaJuCo;
        private DataGridViewButtonColumn VahTiJuCo;
        private DataGridViewButtonColumn VarAlkoCO;
        private DataGridViewTextBoxColumn VarAlkoMaCo;
        private DataGridViewButtonColumn VahAlkoVarCo;
        private DataGridViewButtonColumn TilaaAlkoCo;
        private DataGridViewTextBoxColumn TilAlkoMaaraCo;
        private DataGridViewButtonColumn VahAlkoTilCo;
    }
}