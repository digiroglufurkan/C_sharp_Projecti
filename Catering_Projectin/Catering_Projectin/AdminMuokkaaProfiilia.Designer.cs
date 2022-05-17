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
            this.AsetuksetTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.salasanojenHallintaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muokkaaProfiiliaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vaihdaSalasanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kirjauduUlosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KayttajatTSMI = new System.Windows.Forms.ToolStripMenuItem();
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
            this.NavMS.Size = new System.Drawing.Size(923, 39);
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
            // KayttajatTSMI
            // 
            this.KayttajatTSMI.Name = "KayttajatTSMI";
            this.KayttajatTSMI.Size = new System.Drawing.Size(243, 35);
            this.KayttajatTSMI.Text = "Käyttäjätilien hallinta";
            this.KayttajatTSMI.Click += new System.EventHandler(this.KayttajatTSMI_Click);
            // 
            // AdminMuokkaaProfiilia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 526);
            this.Controls.Add(this.OtsikkoLB);
            this.Controls.Add(this.NavMS);
            this.MainMenuStrip = this.NavMS;
            this.Name = "AdminMuokkaaProfiilia";
            this.Text = "Admin muokkaa profiilia";
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
    }
}