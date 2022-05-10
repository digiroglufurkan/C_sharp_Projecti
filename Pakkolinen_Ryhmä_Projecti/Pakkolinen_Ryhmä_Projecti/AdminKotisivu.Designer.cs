namespace Pakkolinen_Ryhmä_Projecti
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kotisivuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.palautteenHallintaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.latauksienHallintaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayttäjätilienHallintaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yhteydenottojenHallintaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitäUuttaHallintaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiedostonJakoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KeskustelupalstaHallintatoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AsetuksettoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SalasanojenHallintatoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MuokkaaProfiiliatoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vaihdaSalasanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kirjauduUlosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IdLB = new System.Windows.Forms.Label();
            this.TervehdysLB = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OtsikkoLB
            // 
            this.OtsikkoLB.AutoSize = true;
            this.OtsikkoLB.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OtsikkoLB.Location = new System.Drawing.Point(275, -1);
            this.OtsikkoLB.Name = "OtsikkoLB";
            this.OtsikkoLB.Size = new System.Drawing.Size(183, 62);
            this.OtsikkoLB.TabIndex = 0;
            this.OtsikkoLB.Text = "Otsikko";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kotisivuToolStripMenuItem,
            this.palautteenHallintaToolStripMenuItem,
            this.latauksienHallintaToolStripMenuItem,
            this.kayttäjätilienHallintaToolStripMenuItem,
            this.yhteydenottojenHallintaToolStripMenuItem,
            this.mitäUuttaHallintaToolStripMenuItem,
            this.tiedostonJakoToolStripMenuItem,
            this.KeskustelupalstaHallintatoolStripMenuItem,
            this.AsetuksettoolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(-2, 61);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1423, 31);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kotisivuToolStripMenuItem
            // 
            this.kotisivuToolStripMenuItem.Name = "kotisivuToolStripMenuItem";
            this.kotisivuToolStripMenuItem.Size = new System.Drawing.Size(83, 27);
            this.kotisivuToolStripMenuItem.Text = "Kotisivu";
            this.kotisivuToolStripMenuItem.Click += new System.EventHandler(this.kotisivuToolStripMenuItem_Click);
            // 
            // palautteenHallintaToolStripMenuItem
            // 
            this.palautteenHallintaToolStripMenuItem.Name = "palautteenHallintaToolStripMenuItem";
            this.palautteenHallintaToolStripMenuItem.Size = new System.Drawing.Size(166, 27);
            this.palautteenHallintaToolStripMenuItem.Text = "Palautteen hallinta";
            this.palautteenHallintaToolStripMenuItem.Click += new System.EventHandler(this.palautteenHallintaToolStripMenuItem_Click);
            // 
            // latauksienHallintaToolStripMenuItem
            // 
            this.latauksienHallintaToolStripMenuItem.Name = "latauksienHallintaToolStripMenuItem";
            this.latauksienHallintaToolStripMenuItem.Size = new System.Drawing.Size(165, 27);
            this.latauksienHallintaToolStripMenuItem.Text = "Latauksien hallinta";
            this.latauksienHallintaToolStripMenuItem.Click += new System.EventHandler(this.latauksienHallintaToolStripMenuItem_Click);
            // 
            // kayttäjätilienHallintaToolStripMenuItem
            // 
            this.kayttäjätilienHallintaToolStripMenuItem.Name = "kayttäjätilienHallintaToolStripMenuItem";
            this.kayttäjätilienHallintaToolStripMenuItem.Size = new System.Drawing.Size(183, 27);
            this.kayttäjätilienHallintaToolStripMenuItem.Text = "Käyttäjätilien hallinta";
            this.kayttäjätilienHallintaToolStripMenuItem.Click += new System.EventHandler(this.kayttäjätilienHallintaToolStripMenuItem_Click);
            // 
            // yhteydenottojenHallintaToolStripMenuItem
            // 
            this.yhteydenottojenHallintaToolStripMenuItem.Name = "yhteydenottojenHallintaToolStripMenuItem";
            this.yhteydenottojenHallintaToolStripMenuItem.Size = new System.Drawing.Size(211, 27);
            this.yhteydenottojenHallintaToolStripMenuItem.Text = "Yhteydenottojen hallinta";
            this.yhteydenottojenHallintaToolStripMenuItem.Click += new System.EventHandler(this.yhteydenottojenHallintaToolStripMenuItem_Click);
            // 
            // mitäUuttaHallintaToolStripMenuItem
            // 
            this.mitäUuttaHallintaToolStripMenuItem.Name = "mitäUuttaHallintaToolStripMenuItem";
            this.mitäUuttaHallintaToolStripMenuItem.Size = new System.Drawing.Size(165, 27);
            this.mitäUuttaHallintaToolStripMenuItem.Text = "Mitä uutta hallinta";
            this.mitäUuttaHallintaToolStripMenuItem.Click += new System.EventHandler(this.mitäUuttaHallintaToolStripMenuItem_Click);
            // 
            // tiedostonJakoToolStripMenuItem
            // 
            this.tiedostonJakoToolStripMenuItem.Name = "tiedostonJakoToolStripMenuItem";
            this.tiedostonJakoToolStripMenuItem.Size = new System.Drawing.Size(135, 27);
            this.tiedostonJakoToolStripMenuItem.Text = "Tiedoston jako";
            this.tiedostonJakoToolStripMenuItem.Click += new System.EventHandler(this.tiedostonJakoToolStripMenuItem_Click);
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
            this.SalasanojenHallintatoolStripMenuItem,
            this.MuokkaaProfiiliatoolStripMenuItem,
            this.vaihdaSalasanaToolStripMenuItem,
            this.kirjauduUlosToolStripMenuItem});
            this.AsetuksettoolStripMenuItem.Name = "AsetuksettoolStripMenuItem";
            this.AsetuksettoolStripMenuItem.Size = new System.Drawing.Size(97, 27);
            this.AsetuksettoolStripMenuItem.Text = "Asetukset";
            // 
            // SalasanojenHallintatoolStripMenuItem
            // 
            this.SalasanojenHallintatoolStripMenuItem.Name = "SalasanojenHallintatoolStripMenuItem";
            this.SalasanojenHallintatoolStripMenuItem.Size = new System.Drawing.Size(245, 28);
            this.SalasanojenHallintatoolStripMenuItem.Text = "Salasanojen hallinta";
            this.SalasanojenHallintatoolStripMenuItem.Click += new System.EventHandler(this.SalasanojenHallintatoolStripMenuItem_Click);
            // 
            // MuokkaaProfiiliatoolStripMenuItem
            // 
            this.MuokkaaProfiiliatoolStripMenuItem.Name = "MuokkaaProfiiliatoolStripMenuItem";
            this.MuokkaaProfiiliatoolStripMenuItem.Size = new System.Drawing.Size(245, 28);
            this.MuokkaaProfiiliatoolStripMenuItem.Text = "Muokkaa profiilia";
            this.MuokkaaProfiiliatoolStripMenuItem.Click += new System.EventHandler(this.MuokkaaProfiiliatoolStripMenuItem_Click);
            // 
            // vaihdaSalasanaToolStripMenuItem
            // 
            this.vaihdaSalasanaToolStripMenuItem.Name = "vaihdaSalasanaToolStripMenuItem";
            this.vaihdaSalasanaToolStripMenuItem.Size = new System.Drawing.Size(245, 28);
            this.vaihdaSalasanaToolStripMenuItem.Text = "Vaihda salasana";
            this.vaihdaSalasanaToolStripMenuItem.Click += new System.EventHandler(this.vaihdaSalasanaToolStripMenuItem_Click);
            // 
            // kirjauduUlosToolStripMenuItem
            // 
            this.kirjauduUlosToolStripMenuItem.Name = "kirjauduUlosToolStripMenuItem";
            this.kirjauduUlosToolStripMenuItem.Size = new System.Drawing.Size(245, 28);
            this.kirjauduUlosToolStripMenuItem.Text = "Kirjaudu ulos";
            this.kirjauduUlosToolStripMenuItem.Click += new System.EventHandler(this.kirjauduUlosToolStripMenuItem_Click);
            // 
            // IdLB
            // 
            this.IdLB.AutoSize = true;
            this.IdLB.Location = new System.Drawing.Point(371, 149);
            this.IdLB.Name = "IdLB";
            this.IdLB.Size = new System.Drawing.Size(38, 20);
            this.IdLB.TabIndex = 2;
            this.IdLB.Text = "nimi";
            // 
            // TervehdysLB
            // 
            this.TervehdysLB.AutoSize = true;
            this.TervehdysLB.Location = new System.Drawing.Point(129, 149);
            this.TervehdysLB.Name = "TervehdysLB";
            this.TervehdysLB.Size = new System.Drawing.Size(132, 20);
            this.TervehdysLB.TabIndex = 3;
            this.TervehdysLB.Text = "Tervetuloa takaisin";
            // 
            // AdminKotisivu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 450);
            this.Controls.Add(this.TervehdysLB);
            this.Controls.Add(this.IdLB);
            this.Controls.Add(this.OtsikkoLB);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminKotisivu";
            this.Text = "Kotisivu Admin";
            this.Load += new System.EventHandler(this.AdminKotisivu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label OtsikkoLB;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem kotisivuToolStripMenuItem;
        private ToolStripMenuItem palautteenHallintaToolStripMenuItem;
        private ToolStripMenuItem latauksienHallintaToolStripMenuItem;
        private ToolStripMenuItem kayttäjätilienHallintaToolStripMenuItem;
        private ToolStripMenuItem yhteydenottojenHallintaToolStripMenuItem;
        private ToolStripMenuItem mitäUuttaHallintaToolStripMenuItem;
        private ToolStripMenuItem tiedostonJakoToolStripMenuItem;
        private ToolStripMenuItem AsetuksettoolStripMenuItem;
        private ToolStripMenuItem MuokkaaProfiiliatoolStripMenuItem;
        private ToolStripMenuItem vaihdaSalasanaToolStripMenuItem;
        private ToolStripMenuItem kirjauduUlosToolStripMenuItem;
        private ToolStripMenuItem SalasanojenHallintatoolStripMenuItem;
        private Label IdLB;
        private ToolStripMenuItem KeskustelupalstaHallintatoolStripMenuItem;
        private Label TervehdysLB;
    }
}