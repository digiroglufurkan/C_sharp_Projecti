namespace Catering_Projectin
{
    partial class AdminSalasananHallinta
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
            this.KayttajaTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.AsetuksetTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.SalasananHallintaTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ProfiilinMuokkausTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.SalasananVaihtoTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.KirjauduUlosTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.KayTunLB = new System.Windows.Forms.Label();
            this.UusiSaSanaLB = new System.Windows.Forms.Label();
            this.UusiUudestaanLB = new System.Windows.Forms.Label();
            this.S = new System.Windows.Forms.TextBox();
            this.UusiSaSanaTB = new System.Windows.Forms.TextBox();
            this.UusiUdTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.NavMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // OtsikkoLB
            // 
            this.OtsikkoLB.AutoSize = true;
            this.OtsikkoLB.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OtsikkoLB.Location = new System.Drawing.Point(361, 0);
            this.OtsikkoLB.Name = "OtsikkoLB";
            this.OtsikkoLB.Size = new System.Drawing.Size(437, 62);
            this.OtsikkoLB.TabIndex = 0;
            this.OtsikkoLB.Text = "Salasanojen hallinta";
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
            this.KayttajaTSMI,
            this.AsetuksetTSMI});
            this.NavMS.Location = new System.Drawing.Point(189, 72);
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
            // KayttajaTSMI
            // 
            this.KayttajaTSMI.Name = "KayttajaTSMI";
            this.KayttajaTSMI.Size = new System.Drawing.Size(243, 35);
            this.KayttajaTSMI.Text = "Käyttäjätilien hallinta";
            this.KayttajaTSMI.Click += new System.EventHandler(this.KayttajaTSMI_Click);
            // 
            // AsetuksetTSMI
            // 
            this.AsetuksetTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SalasananHallintaTSMI,
            this.ProfiilinMuokkausTSMI,
            this.SalasananVaihtoTSMI,
            this.KirjauduUlosTSMI});
            this.AsetuksetTSMI.Name = "AsetuksetTSMI";
            this.AsetuksetTSMI.Size = new System.Drawing.Size(127, 35);
            this.AsetuksetTSMI.Text = "Asetukset";
            // 
            // SalasananHallintaTSMI
            // 
            this.SalasananHallintaTSMI.Name = "SalasananHallintaTSMI";
            this.SalasananHallintaTSMI.Size = new System.Drawing.Size(289, 36);
            this.SalasananHallintaTSMI.Text = "Salasanan hallinta";
            this.SalasananHallintaTSMI.Click += new System.EventHandler(this.SalasananHallintaTSMI_Click);
            // 
            // ProfiilinMuokkausTSMI
            // 
            this.ProfiilinMuokkausTSMI.Name = "ProfiilinMuokkausTSMI";
            this.ProfiilinMuokkausTSMI.Size = new System.Drawing.Size(289, 36);
            this.ProfiilinMuokkausTSMI.Text = "Profiilin muokkaus";
            this.ProfiilinMuokkausTSMI.Click += new System.EventHandler(this.ProfiilinMuokkausTSMI_Click);
            // 
            // SalasananVaihtoTSMI
            // 
            this.SalasananVaihtoTSMI.Name = "SalasananVaihtoTSMI";
            this.SalasananVaihtoTSMI.Size = new System.Drawing.Size(289, 36);
            this.SalasananVaihtoTSMI.Text = "Salasanan vaihto";
            this.SalasananVaihtoTSMI.Click += new System.EventHandler(this.SalasananVaihtoTSMI_Click);
            // 
            // KirjauduUlosTSMI
            // 
            this.KirjauduUlosTSMI.Name = "KirjauduUlosTSMI";
            this.KirjauduUlosTSMI.Size = new System.Drawing.Size(289, 36);
            this.KirjauduUlosTSMI.Text = "Kirjaudu ulos";
            this.KirjauduUlosTSMI.Click += new System.EventHandler(this.KirjauduUlosTSMI_Click);
            // 
            // KayTunLB
            // 
            this.KayTunLB.AutoSize = true;
            this.KayTunLB.Location = new System.Drawing.Point(396, 159);
            this.KayTunLB.Name = "KayTunLB";
            this.KayTunLB.Size = new System.Drawing.Size(110, 20);
            this.KayTunLB.TabIndex = 2;
            this.KayTunLB.Text = "Käyttäjä tunnus";
            // 
            // UusiSaSanaLB
            // 
            this.UusiSaSanaLB.AutoSize = true;
            this.UusiSaSanaLB.Location = new System.Drawing.Point(396, 228);
            this.UusiSaSanaLB.Name = "UusiSaSanaLB";
            this.UusiSaSanaLB.Size = new System.Drawing.Size(97, 20);
            this.UusiSaSanaLB.TabIndex = 3;
            this.UusiSaSanaLB.Text = "Uusi salasana";
            // 
            // UusiUudestaanLB
            // 
            this.UusiUudestaanLB.AutoSize = true;
            this.UusiUudestaanLB.Location = new System.Drawing.Point(396, 298);
            this.UusiUudestaanLB.Name = "UusiUudestaanLB";
            this.UusiUudestaanLB.Size = new System.Drawing.Size(139, 20);
            this.UusiUudestaanLB.TabIndex = 4;
            this.UusiUudestaanLB.Text = "Salasana uudestaan";
            // 
            // S
            // 
            this.S.Location = new System.Drawing.Point(692, 156);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(125, 27);
            this.S.TabIndex = 5;
            // 
            // UusiSaSanaTB
            // 
            this.UusiSaSanaTB.Location = new System.Drawing.Point(692, 225);
            this.UusiSaSanaTB.Name = "UusiSaSanaTB";
            this.UusiSaSanaTB.Size = new System.Drawing.Size(125, 27);
            this.UusiSaSanaTB.TabIndex = 6;
            // 
            // UusiUdTB
            // 
            this.UusiUdTB.Location = new System.Drawing.Point(692, 295);
            this.UusiUdTB.Name = "UusiUdTB";
            this.UusiUdTB.Size = new System.Drawing.Size(125, 27);
            this.UusiUdTB.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(634, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AdminSalasananHallinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UusiUdTB);
            this.Controls.Add(this.UusiSaSanaTB);
            this.Controls.Add(this.S);
            this.Controls.Add(this.UusiUudestaanLB);
            this.Controls.Add(this.UusiSaSanaLB);
            this.Controls.Add(this.KayTunLB);
            this.Controls.Add(this.OtsikkoLB);
            this.Controls.Add(this.NavMS);
            this.MainMenuStrip = this.NavMS;
            this.Name = "AdminSalasananHallinta";
            this.Text = "Admin salasanojen hallinta";
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
        private ToolStripMenuItem SalasananHallintaTSMI;
        private ToolStripMenuItem ProfiilinMuokkausTSMI;
        private ToolStripMenuItem SalasananVaihtoTSMI;
        private ToolStripMenuItem KirjauduUlosTSMI;
        private Label KayTunLB;
        private Label UusiSaSanaLB;
        private Label UusiUudestaanLB;
        private TextBox S;
        private TextBox UusiSaSanaTB;
        private TextBox UusiUdTB;
        private ToolStripMenuItem KayttajaTSMI;
        private Button button1;
    }
}