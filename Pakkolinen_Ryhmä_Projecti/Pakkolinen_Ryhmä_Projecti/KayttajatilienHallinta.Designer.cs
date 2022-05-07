namespace Pakkolinen_Ryhmä_Projecti
{
    partial class KayttajatilienHallinta
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
            this.NavmenuStrip = new System.Windows.Forms.MenuStrip();
            this.AdminKotisivutoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PalautteenHallintatoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LatauksienHallintatoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KayttajatilienHallintatoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.YhteydenottojenhallintatoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MitaUuttaHallintatoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TiedostonJakotoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AsetuksettoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SalasanojenHallintaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MuokkaaProfiiliaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VaihdaSalasanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KirjauduUlosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KayttajatDG = new System.Windows.Forms.DataGridView();
            this.PoistaColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.NavmenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KayttajatDG)).BeginInit();
            this.SuspendLayout();
            // 
            // OtsikkoLB
            // 
            this.OtsikkoLB.AutoSize = true;
            this.OtsikkoLB.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OtsikkoLB.Location = new System.Drawing.Point(651, 17);
            this.OtsikkoLB.Name = "OtsikkoLB";
            this.OtsikkoLB.Size = new System.Drawing.Size(183, 62);
            this.OtsikkoLB.TabIndex = 0;
            this.OtsikkoLB.Text = "Otsikko";
            // 
            // NavmenuStrip
            // 
            this.NavmenuStrip.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NavmenuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.NavmenuStrip.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NavmenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.NavmenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AdminKotisivutoolStripMenuItem,
            this.PalautteenHallintatoolStripMenuItem,
            this.LatauksienHallintatoolStripMenuItem,
            this.KayttajatilienHallintatoolStripMenuItem,
            this.YhteydenottojenhallintatoolStripMenuItem,
            this.MitaUuttaHallintatoolStripMenuItem,
            this.TiedostonJakotoolStripMenuItem,
            this.AsetuksettoolStripMenuItem});
            this.NavmenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.NavmenuStrip.Location = new System.Drawing.Point(9, 86);
            this.NavmenuStrip.Name = "NavmenuStrip";
            this.NavmenuStrip.Size = new System.Drawing.Size(1483, 38);
            this.NavmenuStrip.TabIndex = 1;
            this.NavmenuStrip.Text = "menuStrip1";
            // 
            // AdminKotisivutoolStripMenuItem
            // 
            this.AdminKotisivutoolStripMenuItem.Name = "AdminKotisivutoolStripMenuItem";
            this.AdminKotisivutoolStripMenuItem.Size = new System.Drawing.Size(101, 34);
            this.AdminKotisivutoolStripMenuItem.Text = "Kotisivu";
            this.AdminKotisivutoolStripMenuItem.Click += new System.EventHandler(this.AdminKotisivutoolStripMenuItem_Click);
            // 
            // PalautteenHallintatoolStripMenuItem
            // 
            this.PalautteenHallintatoolStripMenuItem.Name = "PalautteenHallintatoolStripMenuItem";
            this.PalautteenHallintatoolStripMenuItem.Size = new System.Drawing.Size(201, 34);
            this.PalautteenHallintatoolStripMenuItem.Text = "Palautteen hallinta";
            this.PalautteenHallintatoolStripMenuItem.Click += new System.EventHandler(this.PalautteenHallintatoolStripMenuItem_Click);
            // 
            // LatauksienHallintatoolStripMenuItem
            // 
            this.LatauksienHallintatoolStripMenuItem.Name = "LatauksienHallintatoolStripMenuItem";
            this.LatauksienHallintatoolStripMenuItem.Size = new System.Drawing.Size(201, 34);
            this.LatauksienHallintatoolStripMenuItem.Text = "Latauksien hallinta";
            this.LatauksienHallintatoolStripMenuItem.Click += new System.EventHandler(this.LatauksienHallintatoolStripMenuItem_Click);
            // 
            // KayttajatilienHallintatoolStripMenuItem
            // 
            this.KayttajatilienHallintatoolStripMenuItem.Name = "KayttajatilienHallintatoolStripMenuItem";
            this.KayttajatilienHallintatoolStripMenuItem.Size = new System.Drawing.Size(223, 34);
            this.KayttajatilienHallintatoolStripMenuItem.Text = "Käyttäjätilien hallinta";
            this.KayttajatilienHallintatoolStripMenuItem.Click += new System.EventHandler(this.KayttajatilienHallintatoolStripMenuItem_Click);
            // 
            // YhteydenottojenhallintatoolStripMenuItem
            // 
            this.YhteydenottojenhallintatoolStripMenuItem.Name = "YhteydenottojenhallintatoolStripMenuItem";
            this.YhteydenottojenhallintatoolStripMenuItem.Size = new System.Drawing.Size(261, 34);
            this.YhteydenottojenhallintatoolStripMenuItem.Text = "Yhteydenottojen hallinta";
            this.YhteydenottojenhallintatoolStripMenuItem.Click += new System.EventHandler(this.YhteydenottojenhallintatoolStripMenuItem_Click);
            // 
            // MitaUuttaHallintatoolStripMenuItem
            // 
            this.MitaUuttaHallintatoolStripMenuItem.Name = "MitaUuttaHallintatoolStripMenuItem";
            this.MitaUuttaHallintatoolStripMenuItem.Size = new System.Drawing.Size(199, 34);
            this.MitaUuttaHallintatoolStripMenuItem.Text = "Mitä uutta hallinta";
            this.MitaUuttaHallintatoolStripMenuItem.Click += new System.EventHandler(this.MitaUuttaHallintatoolStripMenuItem_Click);
            // 
            // TiedostonJakotoolStripMenuItem
            // 
            this.TiedostonJakotoolStripMenuItem.Name = "TiedostonJakotoolStripMenuItem";
            this.TiedostonJakotoolStripMenuItem.Size = new System.Drawing.Size(169, 34);
            this.TiedostonJakotoolStripMenuItem.Text = "Tiedoston jako";
            this.TiedostonJakotoolStripMenuItem.Click += new System.EventHandler(this.TiedostonJakotoolStripMenuItem_Click);
            // 
            // AsetuksettoolStripMenuItem
            // 
            this.AsetuksettoolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SalasanojenHallintaToolStripMenuItem,
            this.MuokkaaProfiiliaToolStripMenuItem,
            this.VaihdaSalasanaToolStripMenuItem,
            this.KirjauduUlosToolStripMenuItem});
            this.AsetuksettoolStripMenuItem.Name = "AsetuksettoolStripMenuItem";
            this.AsetuksettoolStripMenuItem.Size = new System.Drawing.Size(120, 34);
            this.AsetuksettoolStripMenuItem.Text = "Asetukset";
            // 
            // SalasanojenHallintaToolStripMenuItem
            // 
            this.SalasanojenHallintaToolStripMenuItem.Name = "SalasanojenHallintaToolStripMenuItem";
            this.SalasanojenHallintaToolStripMenuItem.Size = new System.Drawing.Size(287, 34);
            this.SalasanojenHallintaToolStripMenuItem.Text = "Salasanojen hallinta";
            this.SalasanojenHallintaToolStripMenuItem.Click += new System.EventHandler(this.SalasanojenHallintaToolStripMenuItem_Click);
            // 
            // MuokkaaProfiiliaToolStripMenuItem
            // 
            this.MuokkaaProfiiliaToolStripMenuItem.Name = "MuokkaaProfiiliaToolStripMenuItem";
            this.MuokkaaProfiiliaToolStripMenuItem.Size = new System.Drawing.Size(287, 34);
            this.MuokkaaProfiiliaToolStripMenuItem.Text = "Muokkaa profiilia";
            this.MuokkaaProfiiliaToolStripMenuItem.Click += new System.EventHandler(this.MuokkaaProfiiliaToolStripMenuItem_Click);
            // 
            // VaihdaSalasanaToolStripMenuItem
            // 
            this.VaihdaSalasanaToolStripMenuItem.Name = "VaihdaSalasanaToolStripMenuItem";
            this.VaihdaSalasanaToolStripMenuItem.Size = new System.Drawing.Size(287, 34);
            this.VaihdaSalasanaToolStripMenuItem.Text = "Vaihda Salasana";
            this.VaihdaSalasanaToolStripMenuItem.Click += new System.EventHandler(this.VaihdaSalasanaToolStripMenuItem_Click);
            // 
            // KirjauduUlosToolStripMenuItem
            // 
            this.KirjauduUlosToolStripMenuItem.Name = "KirjauduUlosToolStripMenuItem";
            this.KirjauduUlosToolStripMenuItem.Size = new System.Drawing.Size(287, 34);
            this.KirjauduUlosToolStripMenuItem.Text = "Kirjaudu ulos";
            this.KirjauduUlosToolStripMenuItem.Click += new System.EventHandler(this.KirjauduUlosToolStripMenuItem_Click);
            // 
            // KayttajatDG
            // 
            this.KayttajatDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.KayttajatDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KayttajatDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PoistaColumn});
            this.KayttajatDG.Location = new System.Drawing.Point(12, 228);
            this.KayttajatDG.Name = "KayttajatDG";
            this.KayttajatDG.RowHeadersWidth = 51;
            this.KayttajatDG.RowTemplate.Height = 29;
            this.KayttajatDG.Size = new System.Drawing.Size(1726, 268);
            this.KayttajatDG.TabIndex = 2;
            this.KayttajatDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.KayttajatDG_CellContentClick);
            // 
            // PoistaColumn
            // 
            this.PoistaColumn.HeaderText = "Poista";
            this.PoistaColumn.MinimumWidth = 6;
            this.PoistaColumn.Name = "PoistaColumn";
            this.PoistaColumn.Text = "Poista";
            // 
            // KayttajatilienHallinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1745, 589);
            this.Controls.Add(this.KayttajatDG);
            this.Controls.Add(this.OtsikkoLB);
            this.Controls.Add(this.NavmenuStrip);
            this.MainMenuStrip = this.NavmenuStrip;
            this.Name = "KayttajatilienHallinta";
            this.Text = "Kayttajatilien hallinta";
            this.Load += new System.EventHandler(this.KayttajatilienHallinta_Load);
            this.NavmenuStrip.ResumeLayout(false);
            this.NavmenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KayttajatDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label OtsikkoLB;
        private MenuStrip NavmenuStrip;
        private ToolStripMenuItem AdminKotisivutoolStripMenuItem;
        private ToolStripMenuItem PalautteenHallintatoolStripMenuItem;
        private ToolStripMenuItem LatauksienHallintatoolStripMenuItem;
        private ToolStripMenuItem KayttajatilienHallintatoolStripMenuItem;
        private ToolStripMenuItem YhteydenottojenhallintatoolStripMenuItem;
        private ToolStripMenuItem MitaUuttaHallintatoolStripMenuItem;
        private ToolStripMenuItem TiedostonJakotoolStripMenuItem;
        private DataGridView KayttajatDG;
        private ToolStripMenuItem AsetuksettoolStripMenuItem;
        private ToolStripMenuItem SalasanojenHallintaToolStripMenuItem;
        private ToolStripMenuItem MuokkaaProfiiliaToolStripMenuItem;
        private ToolStripMenuItem VaihdaSalasanaToolStripMenuItem;
        private ToolStripMenuItem KirjauduUlosToolStripMenuItem;
        private DataGridViewButtonColumn PoistaColumn;
    }
}