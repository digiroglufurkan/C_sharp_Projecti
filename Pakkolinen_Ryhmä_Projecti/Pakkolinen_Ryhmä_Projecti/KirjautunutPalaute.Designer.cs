namespace Pakkolinen_Ryhmä_Projecti
{
    partial class KirjautunutPalaute
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
            this.ksEtusivuOtsikkoLB = new System.Windows.Forms.Label();
            this.jaaAiheLB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ksKotisivuMS = new System.Windows.Forms.MenuStrip();
            this.ksJaaTiedostoKotisivuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ksJaaTiedostoLatauksetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ksJaaTiedostoJaaTiedostoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ksJaaTiedostoKeskustelupalstaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ksJaaTiedostoPalauteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ksJaaTiedostoAsetuksetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muokkaaProfiiliaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ksVaihdaSalasanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ksKirjauduUlosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.palauteNimiTB = new System.Windows.Forms.TextBox();
            this.palauteAiheTB = new System.Windows.Forms.TextBox();
            this.palauteTB = new System.Windows.Forms.TextBox();
            this.palauteLahetaBT = new System.Windows.Forms.Button();
            this.ksKotisivuMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // ksEtusivuOtsikkoLB
            // 
            this.ksEtusivuOtsikkoLB.AutoSize = true;
            this.ksEtusivuOtsikkoLB.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ksEtusivuOtsikkoLB.Location = new System.Drawing.Point(323, 9);
            this.ksEtusivuOtsikkoLB.Name = "ksEtusivuOtsikkoLB";
            this.ksEtusivuOtsikkoLB.Size = new System.Drawing.Size(149, 51);
            this.ksEtusivuOtsikkoLB.TabIndex = 3;
            this.ksEtusivuOtsikkoLB.Text = "Otsikko";
            // 
            // jaaAiheLB
            // 
            this.jaaAiheLB.AutoSize = true;
            this.jaaAiheLB.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.jaaAiheLB.Location = new System.Drawing.Point(164, 292);
            this.jaaAiheLB.Name = "jaaAiheLB";
            this.jaaAiheLB.Size = new System.Drawing.Size(60, 20);
            this.jaaAiheLB.TabIndex = 10;
            this.jaaAiheLB.Text = "Palaute:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(182, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Aihe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(180, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nimi:";
            // 
            // ksKotisivuMS
            // 
            this.ksKotisivuMS.Dock = System.Windows.Forms.DockStyle.None;
            this.ksKotisivuMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ksJaaTiedostoKotisivuToolStripMenuItem,
            this.ksJaaTiedostoLatauksetToolStripMenuItem,
            this.ksJaaTiedostoJaaTiedostoToolStripMenuItem,
            this.ksJaaTiedostoKeskustelupalstaToolStripMenuItem,
            this.ksJaaTiedostoPalauteToolStripMenuItem,
            this.ksJaaTiedostoAsetuksetToolStripMenuItem});
            this.ksKotisivuMS.Location = new System.Drawing.Point(123, 79);
            this.ksKotisivuMS.Name = "ksKotisivuMS";
            this.ksKotisivuMS.Size = new System.Drawing.Size(668, 28);
            this.ksKotisivuMS.TabIndex = 13;
            // 
            // ksJaaTiedostoKotisivuToolStripMenuItem
            // 
            this.ksJaaTiedostoKotisivuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ksJaaTiedostoKotisivuToolStripMenuItem.Name = "ksJaaTiedostoKotisivuToolStripMenuItem";
            this.ksJaaTiedostoKotisivuToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.ksJaaTiedostoKotisivuToolStripMenuItem.Text = "Kotisivu";
            this.ksJaaTiedostoKotisivuToolStripMenuItem.Click += new System.EventHandler(this.ksJaaTiedostoKotisivuToolStripMenuItem_Click);
            // 
            // ksJaaTiedostoLatauksetToolStripMenuItem
            // 
            this.ksJaaTiedostoLatauksetToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ksJaaTiedostoLatauksetToolStripMenuItem.Name = "ksJaaTiedostoLatauksetToolStripMenuItem";
            this.ksJaaTiedostoLatauksetToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.ksJaaTiedostoLatauksetToolStripMenuItem.Text = "Lataukset";
            this.ksJaaTiedostoLatauksetToolStripMenuItem.Click += new System.EventHandler(this.ksJaaTiedostoLatauksetToolStripMenuItem_Click);
            // 
            // ksJaaTiedostoJaaTiedostoToolStripMenuItem
            // 
            this.ksJaaTiedostoJaaTiedostoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ksJaaTiedostoJaaTiedostoToolStripMenuItem.Name = "ksJaaTiedostoJaaTiedostoToolStripMenuItem";
            this.ksJaaTiedostoJaaTiedostoToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.ksJaaTiedostoJaaTiedostoToolStripMenuItem.Text = "Jaa tiedosto";
            this.ksJaaTiedostoJaaTiedostoToolStripMenuItem.Click += new System.EventHandler(this.ksJaaTiedostoJaaTiedostoToolStripMenuItem_Click);
            // 
            // ksJaaTiedostoKeskustelupalstaToolStripMenuItem
            // 
            this.ksJaaTiedostoKeskustelupalstaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ksJaaTiedostoKeskustelupalstaToolStripMenuItem.Name = "ksJaaTiedostoKeskustelupalstaToolStripMenuItem";
            this.ksJaaTiedostoKeskustelupalstaToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.ksJaaTiedostoKeskustelupalstaToolStripMenuItem.Text = "Keskustelupalsta";
            this.ksJaaTiedostoKeskustelupalstaToolStripMenuItem.Click += new System.EventHandler(this.ksJaaTiedostoKeskustelupalstaToolStripMenuItem_Click);
            // 
            // ksJaaTiedostoPalauteToolStripMenuItem
            // 
            this.ksJaaTiedostoPalauteToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ksJaaTiedostoPalauteToolStripMenuItem.Name = "ksJaaTiedostoPalauteToolStripMenuItem";
            this.ksJaaTiedostoPalauteToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.ksJaaTiedostoPalauteToolStripMenuItem.Text = "Palaute";
            // 
            // ksJaaTiedostoAsetuksetToolStripMenuItem
            // 
            this.ksJaaTiedostoAsetuksetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muokkaaProfiiliaToolStripMenuItem,
            this.ksVaihdaSalasanaToolStripMenuItem,
            this.ksKirjauduUlosToolStripMenuItem});
            this.ksJaaTiedostoAsetuksetToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ksJaaTiedostoAsetuksetToolStripMenuItem.Name = "ksJaaTiedostoAsetuksetToolStripMenuItem";
            this.ksJaaTiedostoAsetuksetToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.ksJaaTiedostoAsetuksetToolStripMenuItem.Text = "Asetukset";
            this.ksJaaTiedostoAsetuksetToolStripMenuItem.Click += new System.EventHandler(this.ksJaaTiedostoAsetuksetToolStripMenuItem_Click);
            // 
            // muokkaaProfiiliaToolStripMenuItem
            // 
            this.muokkaaProfiiliaToolStripMenuItem.Name = "muokkaaProfiiliaToolStripMenuItem";
            this.muokkaaProfiiliaToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.muokkaaProfiiliaToolStripMenuItem.Text = "Muokkaa profiilia";
            this.muokkaaProfiiliaToolStripMenuItem.Click += new System.EventHandler(this.muokkaaProfiiliaToolStripMenuItem_Click);
            // 
            // ksVaihdaSalasanaToolStripMenuItem
            // 
            this.ksVaihdaSalasanaToolStripMenuItem.Name = "ksVaihdaSalasanaToolStripMenuItem";
            this.ksVaihdaSalasanaToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.ksVaihdaSalasanaToolStripMenuItem.Text = "Vaihda salasana";
            this.ksVaihdaSalasanaToolStripMenuItem.Click += new System.EventHandler(this.ksVaihdaSalasanaToolStripMenuItem_Click);
            // 
            // ksKirjauduUlosToolStripMenuItem
            // 
            this.ksKirjauduUlosToolStripMenuItem.Name = "ksKirjauduUlosToolStripMenuItem";
            this.ksKirjauduUlosToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.ksKirjauduUlosToolStripMenuItem.Text = "Kirjaudu ulos";
            this.ksKirjauduUlosToolStripMenuItem.Click += new System.EventHandler(this.ksKirjauduUlosToolStripMenuItem_Click);
            // 
            // palauteNimiTB
            // 
            this.palauteNimiTB.Location = new System.Drawing.Point(245, 151);
            this.palauteNimiTB.Multiline = true;
            this.palauteNimiTB.Name = "palauteNimiTB";
            this.palauteNimiTB.Size = new System.Drawing.Size(185, 20);
            this.palauteNimiTB.TabIndex = 14;
            // 
            // palauteAiheTB
            // 
            this.palauteAiheTB.Location = new System.Drawing.Point(245, 213);
            this.palauteAiheTB.Multiline = true;
            this.palauteAiheTB.Name = "palauteAiheTB";
            this.palauteAiheTB.Size = new System.Drawing.Size(185, 20);
            this.palauteAiheTB.TabIndex = 15;
            // 
            // palauteTB
            // 
            this.palauteTB.Location = new System.Drawing.Point(245, 278);
            this.palauteTB.Multiline = true;
            this.palauteTB.Name = "palauteTB";
            this.palauteTB.Size = new System.Drawing.Size(331, 79);
            this.palauteTB.TabIndex = 16;
            // 
            // palauteLahetaBT
            // 
            this.palauteLahetaBT.Location = new System.Drawing.Point(291, 384);
            this.palauteLahetaBT.Name = "palauteLahetaBT";
            this.palauteLahetaBT.Size = new System.Drawing.Size(89, 29);
            this.palauteLahetaBT.TabIndex = 17;
            this.palauteLahetaBT.Text = "Lataa";
            this.palauteLahetaBT.UseVisualStyleBackColor = true;
            // 
            // KirjautunutPalaute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.palauteLahetaBT);
            this.Controls.Add(this.palauteTB);
            this.Controls.Add(this.palauteAiheTB);
            this.Controls.Add(this.palauteNimiTB);
            this.Controls.Add(this.ksKotisivuMS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jaaAiheLB);
            this.Controls.Add(this.ksEtusivuOtsikkoLB);
            this.Name = "KirjautunutPalaute";
            this.Text = "KirjautunutPalaute";
            this.ksKotisivuMS.ResumeLayout(false);
            this.ksKotisivuMS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ksEtusivuOtsikkoLB;
        private Label jaaAiheLB;
        private Label label1;
        private Label label2;
        private MenuStrip ksKotisivuMS;
        private ToolStripMenuItem ksJaaTiedostoKotisivuToolStripMenuItem;
        private ToolStripMenuItem ksJaaTiedostoLatauksetToolStripMenuItem;
        private ToolStripMenuItem ksJaaTiedostoJaaTiedostoToolStripMenuItem;
        private ToolStripMenuItem ksJaaTiedostoKeskustelupalstaToolStripMenuItem;
        private ToolStripMenuItem ksJaaTiedostoPalauteToolStripMenuItem;
        private ToolStripMenuItem ksJaaTiedostoAsetuksetToolStripMenuItem;
        private ToolStripMenuItem muokkaaProfiiliaToolStripMenuItem;
        private ToolStripMenuItem ksVaihdaSalasanaToolStripMenuItem;
        private ToolStripMenuItem ksKirjauduUlosToolStripMenuItem;
        private TextBox palauteNimiTB;
        private TextBox palauteAiheTB;
        private TextBox palauteTB;
        private Button palauteLahetaBT;
    }
}