namespace Pakkolinen_Ryhmä_Projecti
{
    partial class KirjautunutKotisivu
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
            this.ksKotisivuMS = new System.Windows.Forms.MenuStrip();
            this.ksKotisivuKotisivuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KotisivuLatauksetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ksKotisivuJaaTiedostoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ksKotisivuKeskustelupalstaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ksKotisivuPalauteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ksKotisivuAsetuksetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ksMuokkaaProfiiliaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ksVaihdaSalasanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ksKirjauduUlosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tervetuloaLB = new System.Windows.Forms.Label();
            this.mitaUuttaLB = new System.Windows.Forms.Label();
            this.ksKotisivuDG = new System.Windows.Forms.DataGridView();
            this.toinenDG = new System.Windows.Forms.DataGridView();
            this.komenntilb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LataaCo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ksKotisivuMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ksKotisivuDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toinenDG)).BeginInit();
            this.SuspendLayout();
            // 
            // ksEtusivuOtsikkoLB
            // 
            this.ksEtusivuOtsikkoLB.AutoSize = true;
            this.ksEtusivuOtsikkoLB.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ksEtusivuOtsikkoLB.Location = new System.Drawing.Point(366, 12);
            this.ksEtusivuOtsikkoLB.Name = "ksEtusivuOtsikkoLB";
            this.ksEtusivuOtsikkoLB.Size = new System.Drawing.Size(183, 62);
            this.ksEtusivuOtsikkoLB.TabIndex = 2;
            this.ksEtusivuOtsikkoLB.Text = "Otsikko";
            // 
            // ksKotisivuMS
            // 
            this.ksKotisivuMS.Dock = System.Windows.Forms.DockStyle.None;
            this.ksKotisivuMS.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ksKotisivuMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ksKotisivuKotisivuToolStripMenuItem,
            this.KotisivuLatauksetToolStripMenuItem,
            this.ksKotisivuJaaTiedostoToolStripMenuItem,
            this.ksKotisivuKeskustelupalstaToolStripMenuItem,
            this.ksKotisivuPalauteToolStripMenuItem,
            this.ksKotisivuAsetuksetToolStripMenuItem});
            this.ksKotisivuMS.Location = new System.Drawing.Point(123, 95);
            this.ksKotisivuMS.Name = "ksKotisivuMS";
            this.ksKotisivuMS.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.ksKotisivuMS.Size = new System.Drawing.Size(691, 35);
            this.ksKotisivuMS.TabIndex = 3;
            // 
            // ksKotisivuKotisivuToolStripMenuItem
            // 
            this.ksKotisivuKotisivuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ksKotisivuKotisivuToolStripMenuItem.Name = "ksKotisivuKotisivuToolStripMenuItem";
            this.ksKotisivuKotisivuToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.ksKotisivuKotisivuToolStripMenuItem.Text = "Kotisivu";
            // 
            // KotisivuLatauksetToolStripMenuItem
            // 
            this.KotisivuLatauksetToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KotisivuLatauksetToolStripMenuItem.Name = "KotisivuLatauksetToolStripMenuItem";
            this.KotisivuLatauksetToolStripMenuItem.Size = new System.Drawing.Size(105, 29);
            this.KotisivuLatauksetToolStripMenuItem.Text = "Lataukset";
            this.KotisivuLatauksetToolStripMenuItem.Click += new System.EventHandler(this.kotisivuLatauksetToolStripMenuItem_Click);
            // 
            // ksKotisivuJaaTiedostoToolStripMenuItem
            // 
            this.ksKotisivuJaaTiedostoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ksKotisivuJaaTiedostoToolStripMenuItem.Name = "ksKotisivuJaaTiedostoToolStripMenuItem";
            this.ksKotisivuJaaTiedostoToolStripMenuItem.Size = new System.Drawing.Size(126, 29);
            this.ksKotisivuJaaTiedostoToolStripMenuItem.Text = "Jaa tiedosto";
            this.ksKotisivuJaaTiedostoToolStripMenuItem.Click += new System.EventHandler(this.ksKotisivuJaaTiedostoToolStripMenuItem_Click);
            // 
            // ksKotisivuKeskustelupalstaToolStripMenuItem
            // 
            this.ksKotisivuKeskustelupalstaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ksKotisivuKeskustelupalstaToolStripMenuItem.Name = "ksKotisivuKeskustelupalstaToolStripMenuItem";
            this.ksKotisivuKeskustelupalstaToolStripMenuItem.Size = new System.Drawing.Size(165, 29);
            this.ksKotisivuKeskustelupalstaToolStripMenuItem.Text = "Keskustelupalsta";
            this.ksKotisivuKeskustelupalstaToolStripMenuItem.Click += new System.EventHandler(this.ksKotisivuKeskustelupalstaToolStripMenuItem_Click);
            // 
            // ksKotisivuPalauteToolStripMenuItem
            // 
            this.ksKotisivuPalauteToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ksKotisivuPalauteToolStripMenuItem.Name = "ksKotisivuPalauteToolStripMenuItem";
            this.ksKotisivuPalauteToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.ksKotisivuPalauteToolStripMenuItem.Text = "Palaute";
            this.ksKotisivuPalauteToolStripMenuItem.Click += new System.EventHandler(this.ksKotisivuPalauteToolStripMenuItem_Click);
            // 
            // ksKotisivuAsetuksetToolStripMenuItem
            // 
            this.ksKotisivuAsetuksetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ksMuokkaaProfiiliaToolStripMenuItem,
            this.ksVaihdaSalasanaToolStripMenuItem,
            this.ksKirjauduUlosToolStripMenuItem});
            this.ksKotisivuAsetuksetToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ksKotisivuAsetuksetToolStripMenuItem.Name = "ksKotisivuAsetuksetToolStripMenuItem";
            this.ksKotisivuAsetuksetToolStripMenuItem.Size = new System.Drawing.Size(106, 29);
            this.ksKotisivuAsetuksetToolStripMenuItem.Text = "Asetukset";
            // 
            // ksMuokkaaProfiiliaToolStripMenuItem
            // 
            this.ksMuokkaaProfiiliaToolStripMenuItem.Name = "ksMuokkaaProfiiliaToolStripMenuItem";
            this.ksMuokkaaProfiiliaToolStripMenuItem.Size = new System.Drawing.Size(245, 30);
            this.ksMuokkaaProfiiliaToolStripMenuItem.Text = "Muokkaa profiilia";
            this.ksMuokkaaProfiiliaToolStripMenuItem.Click += new System.EventHandler(this.ksMuokkaaProfiiliaToolStripMenuItem_Click);
            // 
            // ksVaihdaSalasanaToolStripMenuItem
            // 
            this.ksVaihdaSalasanaToolStripMenuItem.Name = "ksVaihdaSalasanaToolStripMenuItem";
            this.ksVaihdaSalasanaToolStripMenuItem.Size = new System.Drawing.Size(245, 30);
            this.ksVaihdaSalasanaToolStripMenuItem.Text = "Vaihda salasana";
            this.ksVaihdaSalasanaToolStripMenuItem.Click += new System.EventHandler(this.ksVaihdaSalasanaToolStripMenuItem_Click);
            // 
            // ksKirjauduUlosToolStripMenuItem
            // 
            this.ksKirjauduUlosToolStripMenuItem.Name = "ksKirjauduUlosToolStripMenuItem";
            this.ksKirjauduUlosToolStripMenuItem.Size = new System.Drawing.Size(245, 30);
            this.ksKirjauduUlosToolStripMenuItem.Text = "Kirjaudu ulos";
            this.ksKirjauduUlosToolStripMenuItem.Click += new System.EventHandler(this.ksKirjauduUlosToolStripMenuItem_Click);
            // 
            // tervetuloaLB
            // 
            this.tervetuloaLB.AutoSize = true;
            this.tervetuloaLB.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tervetuloaLB.Location = new System.Drawing.Point(333, 152);
            this.tervetuloaLB.Name = "tervetuloaLB";
            this.tervetuloaLB.Size = new System.Drawing.Size(270, 41);
            this.tervetuloaLB.TabIndex = 4;
            this.tervetuloaLB.Text = "Tervetuloa takaisin!";
            // 
            // mitaUuttaLB
            // 
            this.mitaUuttaLB.AutoSize = true;
            this.mitaUuttaLB.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mitaUuttaLB.Location = new System.Drawing.Point(382, 207);
            this.mitaUuttaLB.Name = "mitaUuttaLB";
            this.mitaUuttaLB.Size = new System.Drawing.Size(154, 41);
            this.mitaUuttaLB.TabIndex = 6;
            this.mitaUuttaLB.Text = "Mitä uutta";
            // 
            // ksKotisivuDG
            // 
            this.ksKotisivuDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ksKotisivuDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LataaCo});
            this.ksKotisivuDG.Location = new System.Drawing.Point(45, 265);
            this.ksKotisivuDG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ksKotisivuDG.Name = "ksKotisivuDG";
            this.ksKotisivuDG.RowHeadersWidth = 51;
            this.ksKotisivuDG.RowTemplate.Height = 25;
            this.ksKotisivuDG.Size = new System.Drawing.Size(409, 319);
            this.ksKotisivuDG.TabIndex = 7;
            this.ksKotisivuDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ksKotisivuDG_CellContentClick);
            // 
            // toinenDG
            // 
            this.toinenDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.toinenDG.Location = new System.Drawing.Point(450, 265);
            this.toinenDG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.toinenDG.Name = "toinenDG";
            this.toinenDG.RowHeadersWidth = 51;
            this.toinenDG.RowTemplate.Height = 25;
            this.toinenDG.Size = new System.Drawing.Size(407, 319);
            this.toinenDG.TabIndex = 8;
            // 
            // komenntilb
            // 
            this.komenntilb.AutoSize = true;
            this.komenntilb.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.komenntilb.Location = new System.Drawing.Point(594, 220);
            this.komenntilb.Name = "komenntilb";
            this.komenntilb.Size = new System.Drawing.Size(192, 25);
            this.komenntilb.TabIndex = 9;
            this.komenntilb.Text = "Uusimmat kommentit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(168, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Uusimmat lataukset";
            // 
            // LataaCo
            // 
            this.LataaCo.HeaderText = "Lataa";
            this.LataaCo.MinimumWidth = 6;
            this.LataaCo.Name = "LataaCo";
            this.LataaCo.Text = "Lataa";
            this.LataaCo.Width = 125;
            // 
            // KirjautunutKotisivu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.komenntilb);
            this.Controls.Add(this.toinenDG);
            this.Controls.Add(this.ksKotisivuDG);
            this.Controls.Add(this.mitaUuttaLB);
            this.Controls.Add(this.tervetuloaLB);
            this.Controls.Add(this.ksEtusivuOtsikkoLB);
            this.Controls.Add(this.ksKotisivuMS);
            this.MainMenuStrip = this.ksKotisivuMS;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "KirjautunutKotisivu";
            this.Text = "Kirjautunut Kotisivu";
            this.Load += new System.EventHandler(this.KirjautunutKotisivu_Load);
            this.ksKotisivuMS.ResumeLayout(false);
            this.ksKotisivuMS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ksKotisivuDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toinenDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ksEtusivuOtsikkoLB;
        private MenuStrip ksKotisivuMS;
        private ToolStripMenuItem ksKotisivuKotisivuToolStripMenuItem;
        private ToolStripMenuItem KotisivuLatauksetToolStripMenuItem;
        private ToolStripMenuItem ksKotisivuJaaTiedostoToolStripMenuItem;
        private ToolStripMenuItem ksKotisivuKeskustelupalstaToolStripMenuItem;
        private ToolStripMenuItem ksKotisivuPalauteToolStripMenuItem;
        private ToolStripMenuItem ksKotisivuAsetuksetToolStripMenuItem;
        private ToolStripMenuItem ksMuokkaaProfiiliaToolStripMenuItem;
        private ToolStripMenuItem ksVaihdaSalasanaToolStripMenuItem;
        private ToolStripMenuItem ksKirjauduUlosToolStripMenuItem;
        private Label tervetuloaLB;
        private Label mitaUuttaLB;
        private DataGridView ksKotisivuDG;
        private DataGridView toinenDG;
        private Label komenntilb;
        private Label label2;
        private DataGridViewButtonColumn LataaCo;
    }
}