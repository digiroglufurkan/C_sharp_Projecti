namespace Pakkolinen_Ryhmä_Projecti
{
    partial class SalasanojenHallinta
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
            this.KotisivutoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.KaytTunnusLB = new System.Windows.Forms.Label();
            this.KaytTunnusTB = new System.Windows.Forms.TextBox();
            this.HaeSalasanaBT = new System.Windows.Forms.Button();
            this.UusiSalasanaLB = new System.Windows.Forms.Label();
            this.UusiSalasanaTB = new System.Windows.Forms.TextBox();
            this.NykSalasana = new System.Windows.Forms.Label();
            this.SalasanaUudelleenLB = new System.Windows.Forms.Label();
            this.SalasanaUudelleenTB = new System.Windows.Forms.TextBox();
            this.VaihdaBT = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OtsikkoLB
            // 
            this.OtsikkoLB.AutoSize = true;
            this.OtsikkoLB.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OtsikkoLB.Location = new System.Drawing.Point(703, 11);
            this.OtsikkoLB.Name = "OtsikkoLB";
            this.OtsikkoLB.Size = new System.Drawing.Size(183, 62);
            this.OtsikkoLB.TabIndex = 0;
            this.OtsikkoLB.Text = "Otsikko";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.KotisivutoolStripMenuItem,
            this.PalautteenHallintatoolStripMenuItem,
            this.LatauksienHallintatoolStripMenuItem,
            this.KayttajatilienHallintatoolStripMenuItem,
            this.YhteydenottojenHallintatoolStripMenuItem,
            this.MitaUuttaHallintatoolStripMenuItem,
            this.TiedostonJakotoolStripMenuItem,
            this.KeskustelupalstaHallintatoolStripMenuItem,
            this.AsetuksettoolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(9, 85);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1257, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // KotisivutoolStripMenuItem
            // 
            this.KotisivutoolStripMenuItem.Name = "KotisivutoolStripMenuItem";
            this.KotisivutoolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.KotisivutoolStripMenuItem.Text = "Kotisivu";
            this.KotisivutoolStripMenuItem.Click += new System.EventHandler(this.KotisivutoolStripMenuItem_Click);
            // 
            // PalautteenHallintatoolStripMenuItem
            // 
            this.PalautteenHallintatoolStripMenuItem.Name = "PalautteenHallintatoolStripMenuItem";
            this.PalautteenHallintatoolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.PalautteenHallintatoolStripMenuItem.Text = "Palautteen hallinta";
            this.PalautteenHallintatoolStripMenuItem.Click += new System.EventHandler(this.PalautteenHallintatoolStripMenuItem_Click);
            // 
            // LatauksienHallintatoolStripMenuItem
            // 
            this.LatauksienHallintatoolStripMenuItem.Name = "LatauksienHallintatoolStripMenuItem";
            this.LatauksienHallintatoolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.LatauksienHallintatoolStripMenuItem.Text = "Latauksien hallinta";
            this.LatauksienHallintatoolStripMenuItem.Click += new System.EventHandler(this.LatauksienHallintatoolStripMenuItem_Click);
            // 
            // KayttajatilienHallintatoolStripMenuItem
            // 
            this.KayttajatilienHallintatoolStripMenuItem.Name = "KayttajatilienHallintatoolStripMenuItem";
            this.KayttajatilienHallintatoolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.KayttajatilienHallintatoolStripMenuItem.Text = "Käyttäjätilien hallinta";
            this.KayttajatilienHallintatoolStripMenuItem.Click += new System.EventHandler(this.KayttajatilienHallintatoolStripMenuItem_Click);
            // 
            // YhteydenottojenHallintatoolStripMenuItem
            // 
            this.YhteydenottojenHallintatoolStripMenuItem.Name = "YhteydenottojenHallintatoolStripMenuItem";
            this.YhteydenottojenHallintatoolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.YhteydenottojenHallintatoolStripMenuItem.Text = "Yhteydenottojen hallinta";
            this.YhteydenottojenHallintatoolStripMenuItem.Click += new System.EventHandler(this.YhteydenottojenHallintatoolStripMenuItem_Click);
            // 
            // MitaUuttaHallintatoolStripMenuItem
            // 
            this.MitaUuttaHallintatoolStripMenuItem.Name = "MitaUuttaHallintatoolStripMenuItem";
            this.MitaUuttaHallintatoolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.MitaUuttaHallintatoolStripMenuItem.Text = "Mitä uutta hallinta";
            this.MitaUuttaHallintatoolStripMenuItem.Click += new System.EventHandler(this.MitaUuttaHallintatoolStripMenuItem_Click);
            // 
            // TiedostonJakotoolStripMenuItem
            // 
            this.TiedostonJakotoolStripMenuItem.Name = "TiedostonJakotoolStripMenuItem";
            this.TiedostonJakotoolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.TiedostonJakotoolStripMenuItem.Text = "Tiedoston jako";
            this.TiedostonJakotoolStripMenuItem.Click += new System.EventHandler(this.TiedostonJakotoolStripMenuItem_Click);
            // 
            // KeskustelupalstaHallintatoolStripMenuItem
            // 
            this.KeskustelupalstaHallintatoolStripMenuItem.Name = "KeskustelupalstaHallintatoolStripMenuItem";
            this.KeskustelupalstaHallintatoolStripMenuItem.Size = new System.Drawing.Size(185, 24);
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
            this.AsetuksettoolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.AsetuksettoolStripMenuItem.Text = "Asetukset";
            // 
            // SalasanojenHallintaToolStripMenuItem
            // 
            this.SalasanojenHallintaToolStripMenuItem.Name = "SalasanojenHallintaToolStripMenuItem";
            this.SalasanojenHallintaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.SalasanojenHallintaToolStripMenuItem.Text = "Salasanojen hallinta";
            this.SalasanojenHallintaToolStripMenuItem.Click += new System.EventHandler(this.SalasanojenHallintaToolStripMenuItem_Click);
            // 
            // MuokkaaProfiiliaToolStripMenuItem
            // 
            this.MuokkaaProfiiliaToolStripMenuItem.Name = "MuokkaaProfiiliaToolStripMenuItem";
            this.MuokkaaProfiiliaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.MuokkaaProfiiliaToolStripMenuItem.Text = "Muokkaa profiilia";
            this.MuokkaaProfiiliaToolStripMenuItem.Click += new System.EventHandler(this.MuokkaaProfiiliaToolStripMenuItem_Click);
            // 
            // VaihdaSalasanaToolStripMenuItem
            // 
            this.VaihdaSalasanaToolStripMenuItem.Name = "VaihdaSalasanaToolStripMenuItem";
            this.VaihdaSalasanaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.VaihdaSalasanaToolStripMenuItem.Text = "Vaihda salasana";
            this.VaihdaSalasanaToolStripMenuItem.Click += new System.EventHandler(this.VaihdaSalasanaToolStripMenuItem_Click);
            // 
            // KirjauduUlosToolStripMenuItem
            // 
            this.KirjauduUlosToolStripMenuItem.Name = "KirjauduUlosToolStripMenuItem";
            this.KirjauduUlosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.KirjauduUlosToolStripMenuItem.Text = "Kirjaudu ulos";
            this.KirjauduUlosToolStripMenuItem.Click += new System.EventHandler(this.KirjauduUlosToolStripMenuItem_Click);
            // 
            // KaytTunnusLB
            // 
            this.KaytTunnusLB.AutoSize = true;
            this.KaytTunnusLB.Location = new System.Drawing.Point(414, 174);
            this.KaytTunnusLB.Name = "KaytTunnusLB";
            this.KaytTunnusLB.Size = new System.Drawing.Size(106, 20);
            this.KaytTunnusLB.TabIndex = 2;
            this.KaytTunnusLB.Text = "Käyttäjätunnus";
            // 
            // KaytTunnusTB
            // 
            this.KaytTunnusTB.Location = new System.Drawing.Point(632, 171);
            this.KaytTunnusTB.Name = "KaytTunnusTB";
            this.KaytTunnusTB.Size = new System.Drawing.Size(137, 27);
            this.KaytTunnusTB.TabIndex = 3;
            // 
            // HaeSalasanaBT
            // 
            this.HaeSalasanaBT.Location = new System.Drawing.Point(86, 257);
            this.HaeSalasanaBT.Name = "HaeSalasanaBT";
            this.HaeSalasanaBT.Size = new System.Drawing.Size(187, 29);
            this.HaeSalasanaBT.TabIndex = 4;
            this.HaeSalasanaBT.Text = "Hae salasana";
            this.HaeSalasanaBT.UseVisualStyleBackColor = true;
            this.HaeSalasanaBT.Visible = false;
            this.HaeSalasanaBT.Click += new System.EventHandler(this.HaeSalasanaBT_Click);
            // 
            // UusiSalasanaLB
            // 
            this.UusiSalasanaLB.AutoSize = true;
            this.UusiSalasanaLB.Location = new System.Drawing.Point(414, 266);
            this.UusiSalasanaLB.Name = "UusiSalasanaLB";
            this.UusiSalasanaLB.Size = new System.Drawing.Size(97, 20);
            this.UusiSalasanaLB.TabIndex = 5;
            this.UusiSalasanaLB.Text = "Uusi salasana";
            // 
            // UusiSalasanaTB
            // 
            this.UusiSalasanaTB.Location = new System.Drawing.Point(632, 266);
            this.UusiSalasanaTB.Name = "UusiSalasanaTB";
            this.UusiSalasanaTB.Size = new System.Drawing.Size(139, 27);
            this.UusiSalasanaTB.TabIndex = 6;
            this.UusiSalasanaTB.UseSystemPasswordChar = true;
            // 
            // NykSalasana
            // 
            this.NykSalasana.AutoSize = true;
            this.NykSalasana.Location = new System.Drawing.Point(178, 351);
            this.NykSalasana.Name = "NykSalasana";
            this.NykSalasana.Size = new System.Drawing.Size(50, 20);
            this.NykSalasana.TabIndex = 7;
            this.NykSalasana.Text = "label2";
            this.NykSalasana.Visible = false;
            // 
            // SalasanaUudelleenLB
            // 
            this.SalasanaUudelleenLB.AutoSize = true;
            this.SalasanaUudelleenLB.Location = new System.Drawing.Point(414, 354);
            this.SalasanaUudelleenLB.Name = "SalasanaUudelleenLB";
            this.SalasanaUudelleenLB.Size = new System.Drawing.Size(139, 20);
            this.SalasanaUudelleenLB.TabIndex = 8;
            this.SalasanaUudelleenLB.Text = "Salasana uudestaan";
            // 
            // SalasanaUudelleenTB
            // 
            this.SalasanaUudelleenTB.Location = new System.Drawing.Point(632, 351);
            this.SalasanaUudelleenTB.Name = "SalasanaUudelleenTB";
            this.SalasanaUudelleenTB.Size = new System.Drawing.Size(139, 27);
            this.SalasanaUudelleenTB.TabIndex = 9;
            this.SalasanaUudelleenTB.UseSystemPasswordChar = true;
            // 
            // VaihdaBT
            // 
            this.VaihdaBT.Location = new System.Drawing.Point(522, 451);
            this.VaihdaBT.Name = "VaihdaBT";
            this.VaihdaBT.Size = new System.Drawing.Size(156, 29);
            this.VaihdaBT.TabIndex = 10;
            this.VaihdaBT.Text = "Vaihda";
            this.VaihdaBT.UseVisualStyleBackColor = true;
            this.VaihdaBT.Click += new System.EventHandler(this.VaihdaBT_Click);
            // 
            // SalasanojenHallinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 645);
            this.Controls.Add(this.VaihdaBT);
            this.Controls.Add(this.SalasanaUudelleenTB);
            this.Controls.Add(this.SalasanaUudelleenLB);
            this.Controls.Add(this.NykSalasana);
            this.Controls.Add(this.UusiSalasanaTB);
            this.Controls.Add(this.UusiSalasanaLB);
            this.Controls.Add(this.HaeSalasanaBT);
            this.Controls.Add(this.KaytTunnusTB);
            this.Controls.Add(this.KaytTunnusLB);
            this.Controls.Add(this.OtsikkoLB);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SalasanojenHallinta";
            this.Text = "Salasanojen hallinta";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label OtsikkoLB;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem KotisivutoolStripMenuItem;
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
        private Label KaytTunnusLB;
        private TextBox KaytTunnusTB;
        private Button HaeSalasanaBT;
        private Label UusiSalasanaLB;
        private TextBox UusiSalasanaTB;
        private Label NykSalasana;
        private Label SalasanaUudelleenLB;
        private TextBox SalasanaUudelleenTB;
        private Button VaihdaBT;
        private ToolStripMenuItem KeskustelupalstaHallintatoolStripMenuItem;
    }
}