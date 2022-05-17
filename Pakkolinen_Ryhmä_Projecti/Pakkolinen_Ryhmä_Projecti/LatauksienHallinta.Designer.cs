namespace Pakkolinen_Ryhmä_Projecti
{
    partial class LatauksienHallinta
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
            this.AdminKotisivutoolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PalautteenHallintatoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LatauksienHallintatoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KayttajatilienHallintatoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.YhteydenottojenHallintatoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MitaUuttaHallintatoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TiedostonJakotoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KeskustelupalstaHallintatoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AsetuksettoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SalasanojenHallintaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MuokkaaProfiiliaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VaihdaSalasanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KirjauduUlosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LaHallintadataGridView = new System.Windows.Forms.DataGridView();
            this.LataaColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PoistaColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TallennasaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.NavmenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LaHallintadataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // OtsikkoLB
            // 
            this.OtsikkoLB.AutoSize = true;
            this.OtsikkoLB.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OtsikkoLB.Location = new System.Drawing.Point(657, 0);
            this.OtsikkoLB.Name = "OtsikkoLB";
            this.OtsikkoLB.Size = new System.Drawing.Size(224, 62);
            this.OtsikkoLB.TabIndex = 0;
            this.OtsikkoLB.Text = "Lataukset";
            // 
            // NavmenuStrip
            // 
            this.NavmenuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.NavmenuStrip.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NavmenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.NavmenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AdminKotisivutoolStripItem,
            this.PalautteenHallintatoolStripMenuItem,
            this.LatauksienHallintatoolStripMenuItem,
            this.KayttajatilienHallintatoolStripMenuItem,
            this.YhteydenottojenHallintatoolStripMenuItem,
            this.MitaUuttaHallintatoolStripMenuItem,
            this.TiedostonJakotoolStripMenuItem,
            this.KeskustelupalstaHallintatoolStripMenuItem,
            this.AsetuksettoolStripMenuItem});
            this.NavmenuStrip.Location = new System.Drawing.Point(9, 84);
            this.NavmenuStrip.Name = "NavmenuStrip";
            this.NavmenuStrip.Size = new System.Drawing.Size(1423, 31);
            this.NavmenuStrip.TabIndex = 1;
            this.NavmenuStrip.Text = "menuStrip1";
            // 
            // AdminKotisivutoolStripItem
            // 
            this.AdminKotisivutoolStripItem.Name = "AdminKotisivutoolStripItem";
            this.AdminKotisivutoolStripItem.Size = new System.Drawing.Size(83, 27);
            this.AdminKotisivutoolStripItem.Text = "Kotisivu";
            this.AdminKotisivutoolStripItem.Click += new System.EventHandler(this.AdminKotisivutoolStripItem_Click);
            // 
            // PalautteenHallintatoolStripMenuItem
            // 
            this.PalautteenHallintatoolStripMenuItem.Name = "PalautteenHallintatoolStripMenuItem";
            this.PalautteenHallintatoolStripMenuItem.Size = new System.Drawing.Size(166, 27);
            this.PalautteenHallintatoolStripMenuItem.Text = "Palautteen hallinta";
            this.PalautteenHallintatoolStripMenuItem.Click += new System.EventHandler(this.PalautteenHallintatoolStripMenuItem_Click);
            // 
            // LatauksienHallintatoolStripMenuItem
            // 
            this.LatauksienHallintatoolStripMenuItem.Name = "LatauksienHallintatoolStripMenuItem";
            this.LatauksienHallintatoolStripMenuItem.Size = new System.Drawing.Size(165, 27);
            this.LatauksienHallintatoolStripMenuItem.Text = "Latauksien hallinta";
            this.LatauksienHallintatoolStripMenuItem.Click += new System.EventHandler(this.LatauksienHallintatoolStripMenuItem_Click);
            // 
            // KayttajatilienHallintatoolStripMenuItem
            // 
            this.KayttajatilienHallintatoolStripMenuItem.Name = "KayttajatilienHallintatoolStripMenuItem";
            this.KayttajatilienHallintatoolStripMenuItem.Size = new System.Drawing.Size(183, 27);
            this.KayttajatilienHallintatoolStripMenuItem.Text = "Käyttäjätilien hallinta";
            this.KayttajatilienHallintatoolStripMenuItem.Click += new System.EventHandler(this.KayttajatilienHallintatoolStripMenuItem_Click);
            // 
            // YhteydenottojenHallintatoolStripMenuItem
            // 
            this.YhteydenottojenHallintatoolStripMenuItem.Name = "YhteydenottojenHallintatoolStripMenuItem";
            this.YhteydenottojenHallintatoolStripMenuItem.Size = new System.Drawing.Size(211, 27);
            this.YhteydenottojenHallintatoolStripMenuItem.Text = "Yhteydenottojen hallinta";
            this.YhteydenottojenHallintatoolStripMenuItem.Click += new System.EventHandler(this.YhteydenottojenHallintatoolStripMenuItem_Click);
            // 
            // MitaUuttaHallintatoolStripMenuItem
            // 
            this.MitaUuttaHallintatoolStripMenuItem.Name = "MitaUuttaHallintatoolStripMenuItem";
            this.MitaUuttaHallintatoolStripMenuItem.Size = new System.Drawing.Size(165, 27);
            this.MitaUuttaHallintatoolStripMenuItem.Text = "Mitä uutta hallinta";
            this.MitaUuttaHallintatoolStripMenuItem.Click += new System.EventHandler(this.MitaUuttaHallintatoolStripMenuItem_Click);
            // 
            // TiedostonJakotoolStripMenuItem
            // 
            this.TiedostonJakotoolStripMenuItem.Name = "TiedostonJakotoolStripMenuItem";
            this.TiedostonJakotoolStripMenuItem.Size = new System.Drawing.Size(135, 27);
            this.TiedostonJakotoolStripMenuItem.Text = "Tiedoston jako";
            this.TiedostonJakotoolStripMenuItem.Click += new System.EventHandler(this.TiedostonJakotoolStripMenuItem_Click);
            // 
            // KeskustelupalstaHallintatoolStripMenuItem
            // 
            this.KeskustelupalstaHallintatoolStripMenuItem.Name = "KeskustelupalstaHallintatoolStripMenuItem";
            this.KeskustelupalstaHallintatoolStripMenuItem.Size = new System.Drawing.Size(210, 27);
            this.KeskustelupalstaHallintatoolStripMenuItem.Text = "Keskustelupalsta hallinta";
            this.KeskustelupalstaHallintatoolStripMenuItem.Click += new System.EventHandler(this.KeskustelupalstaHallintatoolStripMenuItem_Click);
            // 
            // AsetuksettoolStripMenuItem
            // 
            this.AsetuksettoolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SalasanojenHallintaToolStripMenuItem,
            this.MuokkaaProfiiliaToolStripMenuItem,
            this.VaihdaSalasanaToolStripMenuItem,
            this.KirjauduUlosToolStripMenuItem});
            this.AsetuksettoolStripMenuItem.Name = "AsetuksettoolStripMenuItem";
            this.AsetuksettoolStripMenuItem.Size = new System.Drawing.Size(97, 27);
            this.AsetuksettoolStripMenuItem.Text = "Asetukset";
            // 
            // SalasanojenHallintaToolStripMenuItem
            // 
            this.SalasanojenHallintaToolStripMenuItem.Name = "SalasanojenHallintaToolStripMenuItem";
            this.SalasanojenHallintaToolStripMenuItem.Size = new System.Drawing.Size(245, 28);
            this.SalasanojenHallintaToolStripMenuItem.Text = "Salasanojen hallinta";
            this.SalasanojenHallintaToolStripMenuItem.Click += new System.EventHandler(this.SalasanojenHallintaToolStripMenuItem_Click);
            // 
            // MuokkaaProfiiliaToolStripMenuItem
            // 
            this.MuokkaaProfiiliaToolStripMenuItem.Name = "MuokkaaProfiiliaToolStripMenuItem";
            this.MuokkaaProfiiliaToolStripMenuItem.Size = new System.Drawing.Size(245, 28);
            this.MuokkaaProfiiliaToolStripMenuItem.Text = "Muokkaa profiilia";
            this.MuokkaaProfiiliaToolStripMenuItem.Click += new System.EventHandler(this.MuokkaaProfiiliaToolStripMenuItem_Click);
            // 
            // VaihdaSalasanaToolStripMenuItem
            // 
            this.VaihdaSalasanaToolStripMenuItem.Name = "VaihdaSalasanaToolStripMenuItem";
            this.VaihdaSalasanaToolStripMenuItem.Size = new System.Drawing.Size(245, 28);
            this.VaihdaSalasanaToolStripMenuItem.Text = "Vaihda salasana";
            this.VaihdaSalasanaToolStripMenuItem.Click += new System.EventHandler(this.VaihdaSalasanaToolStripMenuItem_Click);
            // 
            // KirjauduUlosToolStripMenuItem
            // 
            this.KirjauduUlosToolStripMenuItem.Name = "KirjauduUlosToolStripMenuItem";
            this.KirjauduUlosToolStripMenuItem.Size = new System.Drawing.Size(245, 28);
            this.KirjauduUlosToolStripMenuItem.Text = "Kirjaudu ulos";
            this.KirjauduUlosToolStripMenuItem.Click += new System.EventHandler(this.KirjauduUlosToolStripMenuItem_Click);
            // 
            // LaHallintadataGridView
            // 
            this.LaHallintadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LaHallintadataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LataaColumn,
            this.PoistaColumn});
            this.LaHallintadataGridView.Location = new System.Drawing.Point(430, 218);
            this.LaHallintadataGridView.Name = "LaHallintadataGridView";
            this.LaHallintadataGridView.RowHeadersWidth = 51;
            this.LaHallintadataGridView.RowTemplate.Height = 29;
            this.LaHallintadataGridView.Size = new System.Drawing.Size(459, 253);
            this.LaHallintadataGridView.TabIndex = 2;
            this.LaHallintadataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LaHallintadataGridView_CellContentClick);
            // 
            // LataaColumn
            // 
            this.LataaColumn.HeaderText = "Lataa tiedosto";
            this.LataaColumn.MinimumWidth = 6;
            this.LataaColumn.Name = "LataaColumn";
            this.LataaColumn.Text = "Lataa";
            this.LataaColumn.Width = 125;
            // 
            // PoistaColumn
            // 
            this.PoistaColumn.HeaderText = "Poista";
            this.PoistaColumn.MinimumWidth = 6;
            this.PoistaColumn.Name = "PoistaColumn";
            this.PoistaColumn.Text = "Poista";
            this.PoistaColumn.Width = 125;
            // 
            // LatauksienHallinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1708, 541);
            this.Controls.Add(this.LaHallintadataGridView);
            this.Controls.Add(this.OtsikkoLB);
            this.Controls.Add(this.NavmenuStrip);
            this.MainMenuStrip = this.NavmenuStrip;
            this.Name = "LatauksienHallinta";
            this.Text = "Latauksien hallinta";
            this.Load += new System.EventHandler(this.LatauksienHallinta_Load);
            this.NavmenuStrip.ResumeLayout(false);
            this.NavmenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LaHallintadataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label OtsikkoLB;
        private MenuStrip NavmenuStrip;
        private ToolStripMenuItem AdminKotisivutoolStripItem;
        private ToolStripMenuItem PalautteenHallintatoolStripMenuItem;
        private ToolStripMenuItem LatauksienHallintatoolStripMenuItem;
        private ToolStripMenuItem KayttajatilienHallintatoolStripMenuItem;
        private ToolStripMenuItem YhteydenottojenHallintatoolStripMenuItem;
        private ToolStripMenuItem MitaUuttaHallintatoolStripMenuItem;
        private ToolStripMenuItem TiedostonJakotoolStripMenuItem;
        private ToolStripMenuItem AsetuksettoolStripMenuItem;
        private ToolStripMenuItem SalasanojenHallintaToolStripMenuItem;
        private ToolStripMenuItem MuokkaaProfiiliaToolStripMenuItem;
        private ToolStripMenuItem VaihdaSalasanaToolStripMenuItem;
        private ToolStripMenuItem KirjauduUlosToolStripMenuItem;
        private DataGridView LaHallintadataGridView;
        private DataGridViewButtonColumn LataaColumn;
        private DataGridViewButtonColumn PoistaColumn;
        private SaveFileDialog TallennasaveFileDialog;
        private ToolStripMenuItem KeskustelupalstaHallintatoolStripMenuItem;
    }
}