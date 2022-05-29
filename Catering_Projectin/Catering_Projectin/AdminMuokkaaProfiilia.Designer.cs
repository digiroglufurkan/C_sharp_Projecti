namespace Catering_Projectin
{
    partial class AdminMuokkaaProfiilia
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
            this.salasanojenHallintaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muokkaaProfiiliaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vaihdaSalasanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kirjauduUlosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ENimiLB = new System.Windows.Forms.Label();
            this.SNimi = new System.Windows.Forms.Label();
            this.EmailLB = new System.Windows.Forms.Label();
            this.OsoiteLB = new System.Windows.Forms.Label();
            this.PToimiLB = new System.Windows.Forms.Label();
            this.PostiNroLB = new System.Windows.Forms.Label();
            this.PuhNroLB = new System.Windows.Forms.Label();
            this.EnimiTB = new System.Windows.Forms.TextBox();
            this.EmailTB = new System.Windows.Forms.TextBox();
            this.PToimiTB = new System.Windows.Forms.TextBox();
            this.SnimiTB = new System.Windows.Forms.TextBox();
            this.PuhNroTB = new System.Windows.Forms.TextBox();
            this.OsoiteTB = new System.Windows.Forms.TextBox();
            this.PostiNroTB = new System.Windows.Forms.TextBox();
            this.PaivitaBT = new System.Windows.Forms.Button();
            this.SalasanaLB = new System.Windows.Forms.Label();
            this.NakyvaSalasanaLB = new System.Windows.Forms.Label();
            this.NavMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // OtsikkoLB
            // 
            this.OtsikkoLB.AutoSize = true;
            this.OtsikkoLB.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OtsikkoLB.Location = new System.Drawing.Point(395, -1);
            this.OtsikkoLB.Name = "OtsikkoLB";
            this.OtsikkoLB.Size = new System.Drawing.Size(386, 62);
            this.OtsikkoLB.TabIndex = 0;
            this.OtsikkoLB.Text = "Muokkaa profiilia";
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
            this.NavMS.Location = new System.Drawing.Point(208, 76);
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
            this.salasanojenHallintaToolStripMenuItem,
            this.muokkaaProfiiliaToolStripMenuItem,
            this.vaihdaSalasanaToolStripMenuItem,
            this.kirjauduUlosToolStripMenuItem});
            this.AsetuksetTSMI.Name = "AsetuksetTSMI";
            this.AsetuksetTSMI.Size = new System.Drawing.Size(127, 35);
            this.AsetuksetTSMI.Text = "Asetukset";
            // 
            // salasanojenHallintaToolStripMenuItem
            // 
            this.salasanojenHallintaToolStripMenuItem.Name = "salasanojenHallintaToolStripMenuItem";
            this.salasanojenHallintaToolStripMenuItem.Size = new System.Drawing.Size(305, 36);
            this.salasanojenHallintaToolStripMenuItem.Text = "Salasanojen hallinta";
            this.salasanojenHallintaToolStripMenuItem.Click += new System.EventHandler(this.salasanojenHallintaToolStripMenuItem_Click);
            // 
            // muokkaaProfiiliaToolStripMenuItem
            // 
            this.muokkaaProfiiliaToolStripMenuItem.Name = "muokkaaProfiiliaToolStripMenuItem";
            this.muokkaaProfiiliaToolStripMenuItem.Size = new System.Drawing.Size(305, 36);
            this.muokkaaProfiiliaToolStripMenuItem.Text = "Muokkaa profiilia";
            this.muokkaaProfiiliaToolStripMenuItem.Click += new System.EventHandler(this.muokkaaProfiiliaToolStripMenuItem_Click);
            // 
            // vaihdaSalasanaToolStripMenuItem
            // 
            this.vaihdaSalasanaToolStripMenuItem.Name = "vaihdaSalasanaToolStripMenuItem";
            this.vaihdaSalasanaToolStripMenuItem.Size = new System.Drawing.Size(305, 36);
            this.vaihdaSalasanaToolStripMenuItem.Text = "Vaihda salasana";
            this.vaihdaSalasanaToolStripMenuItem.Click += new System.EventHandler(this.vaihdaSalasanaToolStripMenuItem_Click);
            // 
            // kirjauduUlosToolStripMenuItem
            // 
            this.kirjauduUlosToolStripMenuItem.Name = "kirjauduUlosToolStripMenuItem";
            this.kirjauduUlosToolStripMenuItem.Size = new System.Drawing.Size(305, 36);
            this.kirjauduUlosToolStripMenuItem.Text = "Kirjaudu ulos";
            this.kirjauduUlosToolStripMenuItem.Click += new System.EventHandler(this.kirjauduUlosToolStripMenuItem_Click);
            // 
            // ENimiLB
            // 
            this.ENimiLB.AutoSize = true;
            this.ENimiLB.Location = new System.Drawing.Point(192, 163);
            this.ENimiLB.Name = "ENimiLB";
            this.ENimiLB.Size = new System.Drawing.Size(59, 20);
            this.ENimiLB.TabIndex = 2;
            this.ENimiLB.Text = "Etunimi";
            // 
            // SNimi
            // 
            this.SNimi.AutoSize = true;
            this.SNimi.Location = new System.Drawing.Point(662, 163);
            this.SNimi.Name = "SNimi";
            this.SNimi.Size = new System.Drawing.Size(69, 20);
            this.SNimi.TabIndex = 3;
            this.SNimi.Text = "Sukunimi";
            // 
            // EmailLB
            // 
            this.EmailLB.AutoSize = true;
            this.EmailLB.Location = new System.Drawing.Point(192, 235);
            this.EmailLB.Name = "EmailLB";
            this.EmailLB.Size = new System.Drawing.Size(82, 20);
            this.EmailLB.TabIndex = 4;
            this.EmailLB.Text = "Sähköposti";
            // 
            // OsoiteLB
            // 
            this.OsoiteLB.AutoSize = true;
            this.OsoiteLB.Location = new System.Drawing.Point(662, 304);
            this.OsoiteLB.Name = "OsoiteLB";
            this.OsoiteLB.Size = new System.Drawing.Size(52, 20);
            this.OsoiteLB.TabIndex = 6;
            this.OsoiteLB.Text = "Osoite";
            // 
            // PToimiLB
            // 
            this.PToimiLB.AutoSize = true;
            this.PToimiLB.Location = new System.Drawing.Point(192, 378);
            this.PToimiLB.Name = "PToimiLB";
            this.PToimiLB.Size = new System.Drawing.Size(118, 20);
            this.PToimiLB.TabIndex = 7;
            this.PToimiLB.Text = "Postitoimipaikka";
            // 
            // PostiNroLB
            // 
            this.PostiNroLB.AutoSize = true;
            this.PostiNroLB.Location = new System.Drawing.Point(662, 378);
            this.PostiNroLB.Name = "PostiNroLB";
            this.PostiNroLB.Size = new System.Drawing.Size(91, 20);
            this.PostiNroLB.TabIndex = 8;
            this.PostiNroLB.Text = "Postinumero";
            // 
            // PuhNroLB
            // 
            this.PuhNroLB.AutoSize = true;
            this.PuhNroLB.Location = new System.Drawing.Point(662, 235);
            this.PuhNroLB.Name = "PuhNroLB";
            this.PuhNroLB.Size = new System.Drawing.Size(57, 20);
            this.PuhNroLB.TabIndex = 9;
            this.PuhNroLB.Text = "Puhelin";
            // 
            // EnimiTB
            // 
            this.EnimiTB.Location = new System.Drawing.Point(431, 156);
            this.EnimiTB.Name = "EnimiTB";
            this.EnimiTB.Size = new System.Drawing.Size(125, 27);
            this.EnimiTB.TabIndex = 10;
            // 
            // EmailTB
            // 
            this.EmailTB.Location = new System.Drawing.Point(431, 235);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(125, 27);
            this.EmailTB.TabIndex = 11;
            // 
            // PToimiTB
            // 
            this.PToimiTB.Location = new System.Drawing.Point(431, 378);
            this.PToimiTB.Name = "PToimiTB";
            this.PToimiTB.Size = new System.Drawing.Size(125, 27);
            this.PToimiTB.TabIndex = 13;
            // 
            // SnimiTB
            // 
            this.SnimiTB.Location = new System.Drawing.Point(873, 156);
            this.SnimiTB.Name = "SnimiTB";
            this.SnimiTB.Size = new System.Drawing.Size(125, 27);
            this.SnimiTB.TabIndex = 14;
            // 
            // PuhNroTB
            // 
            this.PuhNroTB.Location = new System.Drawing.Point(873, 232);
            this.PuhNroTB.Name = "PuhNroTB";
            this.PuhNroTB.Size = new System.Drawing.Size(125, 27);
            this.PuhNroTB.TabIndex = 15;
            // 
            // OsoiteTB
            // 
            this.OsoiteTB.Location = new System.Drawing.Point(873, 304);
            this.OsoiteTB.Name = "OsoiteTB";
            this.OsoiteTB.Size = new System.Drawing.Size(125, 27);
            this.OsoiteTB.TabIndex = 16;
            // 
            // PostiNroTB
            // 
            this.PostiNroTB.Location = new System.Drawing.Point(873, 378);
            this.PostiNroTB.Name = "PostiNroTB";
            this.PostiNroTB.Size = new System.Drawing.Size(125, 27);
            this.PostiNroTB.TabIndex = 17;
            // 
            // PaivitaBT
            // 
            this.PaivitaBT.Location = new System.Drawing.Point(575, 485);
            this.PaivitaBT.Name = "PaivitaBT";
            this.PaivitaBT.Size = new System.Drawing.Size(94, 29);
            this.PaivitaBT.TabIndex = 18;
            this.PaivitaBT.Text = "Päivitä";
            this.PaivitaBT.UseVisualStyleBackColor = true;
            this.PaivitaBT.Click += new System.EventHandler(this.PaivitaBT_Click);
            // 
            // SalasanaLB
            // 
            this.SalasanaLB.AutoSize = true;
            this.SalasanaLB.Location = new System.Drawing.Point(192, 433);
            this.SalasanaLB.Name = "SalasanaLB";
            this.SalasanaLB.Size = new System.Drawing.Size(67, 20);
            this.SalasanaLB.TabIndex = 19;
            this.SalasanaLB.Text = "Salasana";
            // 
            // NakyvaSalasanaLB
            // 
            this.NakyvaSalasanaLB.AutoSize = true;
            this.NakyvaSalasanaLB.Location = new System.Drawing.Point(431, 433);
            this.NakyvaSalasanaLB.Name = "NakyvaSalasanaLB";
            this.NakyvaSalasanaLB.Size = new System.Drawing.Size(50, 20);
            this.NakyvaSalasanaLB.TabIndex = 20;
            this.NakyvaSalasanaLB.Text = "label1";
            // 
            // AdminMuokkaaProfiilia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 526);
            this.Controls.Add(this.NakyvaSalasanaLB);
            this.Controls.Add(this.SalasanaLB);
            this.Controls.Add(this.PaivitaBT);
            this.Controls.Add(this.PostiNroTB);
            this.Controls.Add(this.OsoiteTB);
            this.Controls.Add(this.PuhNroTB);
            this.Controls.Add(this.SnimiTB);
            this.Controls.Add(this.PToimiTB);
            this.Controls.Add(this.EmailTB);
            this.Controls.Add(this.EnimiTB);
            this.Controls.Add(this.PuhNroLB);
            this.Controls.Add(this.PostiNroLB);
            this.Controls.Add(this.PToimiLB);
            this.Controls.Add(this.OsoiteLB);
            this.Controls.Add(this.EmailLB);
            this.Controls.Add(this.SNimi);
            this.Controls.Add(this.ENimiLB);
            this.Controls.Add(this.OtsikkoLB);
            this.Controls.Add(this.NavMS);
            this.MainMenuStrip = this.NavMS;
            this.Name = "AdminMuokkaaProfiilia";
            this.Text = "Admin muokkaa profiilia";
            this.Load += new System.EventHandler(this.AdminMuokkaaProfiilia_Load);
            this.NavMS.ResumeLayout(false);
            this.NavMS.PerformLayout();
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
        private ToolStripMenuItem salasanojenHallintaToolStripMenuItem;
        private ToolStripMenuItem muokkaaProfiiliaToolStripMenuItem;
        private ToolStripMenuItem vaihdaSalasanaToolStripMenuItem;
        private ToolStripMenuItem kirjauduUlosToolStripMenuItem;
        private ToolStripMenuItem KayttajatTSMI;
        private Label ENimiLB;
        private Label SNimi;
        private Label EmailLB;
        private Label OsoiteLB;
        private Label PToimiLB;
        private Label PostiNroLB;
        private Label PuhNroLB;
        private TextBox EnimiTB;
        private TextBox EmailTB;
        private TextBox PToimiTB;
        private TextBox SnimiTB;
        private TextBox PuhNroTB;
        private TextBox OsoiteTB;
        private TextBox PostiNroTB;
        private Button PaivitaBT;
        private Label SalasanaLB;
        private Label NakyvaSalasanaLB;
    }
}