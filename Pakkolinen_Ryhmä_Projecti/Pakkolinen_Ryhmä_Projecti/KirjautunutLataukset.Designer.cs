namespace Pakkolinen_Ryhmä_Projecti
{
    partial class KirjautunutLataukset
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
            this.ksLatauksetKotisivuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ksLatauksetLatauksetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ksLatauksetJaaTiedostoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ksLatauksetKeskustelupalstaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ksLatauksetPalauteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ksLatauksetAsetuksetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ksMuokkaaProfiiliaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ksVaihdaSalasanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ksKirjauduUlosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.latauksetLB = new System.Windows.Forms.Label();
            this.ksLatauksetDG = new System.Windows.Forms.DataGridView();
            this.latausColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.ksKotisivuMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ksLatauksetDG)).BeginInit();
            this.SuspendLayout();
            // 
            // ksEtusivuOtsikkoLB
            // 
            this.ksEtusivuOtsikkoLB.AutoSize = true;
            this.ksEtusivuOtsikkoLB.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ksEtusivuOtsikkoLB.Location = new System.Drawing.Point(328, 9);
            this.ksEtusivuOtsikkoLB.Name = "ksEtusivuOtsikkoLB";
            this.ksEtusivuOtsikkoLB.Size = new System.Drawing.Size(149, 51);
            this.ksEtusivuOtsikkoLB.TabIndex = 3;
            this.ksEtusivuOtsikkoLB.Text = "Otsikko";
            // 
            // ksKotisivuMS
            // 
            this.ksKotisivuMS.Dock = System.Windows.Forms.DockStyle.None;
            this.ksKotisivuMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ksLatauksetKotisivuToolStripMenuItem,
            this.ksLatauksetLatauksetToolStripMenuItem,
            this.ksLatauksetJaaTiedostoToolStripMenuItem,
            this.ksLatauksetKeskustelupalstaToolStripMenuItem,
            this.ksLatauksetPalauteToolStripMenuItem,
            this.ksLatauksetAsetuksetToolStripMenuItem});
            this.ksKotisivuMS.Location = new System.Drawing.Point(123, 82);
            this.ksKotisivuMS.Name = "ksKotisivuMS";
            this.ksKotisivuMS.Size = new System.Drawing.Size(548, 28);
            this.ksKotisivuMS.TabIndex = 4;
            // 
            // ksLatauksetKotisivuToolStripMenuItem
            // 
            this.ksLatauksetKotisivuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ksLatauksetKotisivuToolStripMenuItem.Name = "ksLatauksetKotisivuToolStripMenuItem";
            this.ksLatauksetKotisivuToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.ksLatauksetKotisivuToolStripMenuItem.Text = "Kotisivu";
            this.ksLatauksetKotisivuToolStripMenuItem.Click += new System.EventHandler(this.ksLatauksetKotisivuToolStripMenuItem_Click);
            // 
            // ksLatauksetLatauksetToolStripMenuItem
            // 
            this.ksLatauksetLatauksetToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ksLatauksetLatauksetToolStripMenuItem.Name = "ksLatauksetLatauksetToolStripMenuItem";
            this.ksLatauksetLatauksetToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.ksLatauksetLatauksetToolStripMenuItem.Text = "Lataukset";
            // 
            // ksLatauksetJaaTiedostoToolStripMenuItem
            // 
            this.ksLatauksetJaaTiedostoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ksLatauksetJaaTiedostoToolStripMenuItem.Name = "ksLatauksetJaaTiedostoToolStripMenuItem";
            this.ksLatauksetJaaTiedostoToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.ksLatauksetJaaTiedostoToolStripMenuItem.Text = "Jaa tiedosto";
            this.ksLatauksetJaaTiedostoToolStripMenuItem.Click += new System.EventHandler(this.ksLatauksetJaaTiedostoToolStripMenuItem_Click);
            // 
            // ksLatauksetKeskustelupalstaToolStripMenuItem
            // 
            this.ksLatauksetKeskustelupalstaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ksLatauksetKeskustelupalstaToolStripMenuItem.Name = "ksLatauksetKeskustelupalstaToolStripMenuItem";
            this.ksLatauksetKeskustelupalstaToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.ksLatauksetKeskustelupalstaToolStripMenuItem.Text = "Keskustelupalsta";
            this.ksLatauksetKeskustelupalstaToolStripMenuItem.Click += new System.EventHandler(this.ksLatauksetKeskustelupalstaToolStripMenuItem_Click);
            // 
            // ksLatauksetPalauteToolStripMenuItem
            // 
            this.ksLatauksetPalauteToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ksLatauksetPalauteToolStripMenuItem.Name = "ksLatauksetPalauteToolStripMenuItem";
            this.ksLatauksetPalauteToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.ksLatauksetPalauteToolStripMenuItem.Text = "Palaute";
            this.ksLatauksetPalauteToolStripMenuItem.Click += new System.EventHandler(this.ksLatauksetPalauteToolStripMenuItem_Click);
            // 
            // ksLatauksetAsetuksetToolStripMenuItem
            // 
            this.ksLatauksetAsetuksetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ksMuokkaaProfiiliaToolStripMenuItem,
            this.ksVaihdaSalasanaToolStripMenuItem,
            this.ksKirjauduUlosToolStripMenuItem});
            this.ksLatauksetAsetuksetToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ksLatauksetAsetuksetToolStripMenuItem.Name = "ksLatauksetAsetuksetToolStripMenuItem";
            this.ksLatauksetAsetuksetToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.ksLatauksetAsetuksetToolStripMenuItem.Text = "Asetukset";
            // 
            // ksMuokkaaProfiiliaToolStripMenuItem
            // 
            this.ksMuokkaaProfiiliaToolStripMenuItem.Name = "ksMuokkaaProfiiliaToolStripMenuItem";
            this.ksMuokkaaProfiiliaToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.ksMuokkaaProfiiliaToolStripMenuItem.Text = "Muokkaa profiilia";
            this.ksMuokkaaProfiiliaToolStripMenuItem.Click += new System.EventHandler(this.ksMuokkaaProfiiliaToolStripMenuItem_Click);
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
            // latauksetLB
            // 
            this.latauksetLB.AutoSize = true;
            this.latauksetLB.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.latauksetLB.Location = new System.Drawing.Point(364, 130);
            this.latauksetLB.Name = "latauksetLB";
            this.latauksetLB.Size = new System.Drawing.Size(77, 20);
            this.latauksetLB.TabIndex = 7;
            this.latauksetLB.Text = "Mitä uutta";
            // 
            // ksLatauksetDG
            // 
            this.ksLatauksetDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ksLatauksetDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.latausColumn});
            this.ksLatauksetDG.Location = new System.Drawing.Point(57, 188);
            this.ksLatauksetDG.Name = "ksLatauksetDG";
            this.ksLatauksetDG.RowTemplate.Height = 25;
            this.ksLatauksetDG.Size = new System.Drawing.Size(686, 220);
            this.ksLatauksetDG.TabIndex = 8;
            this.ksLatauksetDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ksLatauksetDG_CellContentClick);
            this.ksLatauksetDG.Click += new System.EventHandler(this.ksLatauksetDG_Click);
            // 
            // latausColumn
            // 
            this.latausColumn.HeaderText = "Lataa tiedosto";
            this.latausColumn.Name = "latausColumn";
            this.latausColumn.ReadOnly = true;
            // 
            // KirjautunutLataukset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ksLatauksetDG);
            this.Controls.Add(this.latauksetLB);
            this.Controls.Add(this.ksKotisivuMS);
            this.Controls.Add(this.ksEtusivuOtsikkoLB);
            this.Name = "KirjautunutLataukset";
            this.Text = "Kirjautunut Lataukset";
            this.Load += new System.EventHandler(this.KirjautunutLataukset_Load);
            this.ksKotisivuMS.ResumeLayout(false);
            this.ksKotisivuMS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ksLatauksetDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ksEtusivuOtsikkoLB;
        private MenuStrip ksKotisivuMS;
        private ToolStripMenuItem ksLatauksetKotisivuToolStripMenuItem;
        private ToolStripMenuItem ksLatauksetLatauksetToolStripMenuItem;
        private ToolStripMenuItem ksLatauksetJaaTiedostoToolStripMenuItem;
        private ToolStripMenuItem ksLatauksetKeskustelupalstaToolStripMenuItem;
        private ToolStripMenuItem ksLatauksetPalauteToolStripMenuItem;
        private ToolStripMenuItem ksLatauksetAsetuksetToolStripMenuItem;
        private ToolStripMenuItem ksMuokkaaProfiiliaToolStripMenuItem;
        private ToolStripMenuItem ksVaihdaSalasanaToolStripMenuItem;
        private ToolStripMenuItem ksKirjauduUlosToolStripMenuItem;
        private Label latauksetLB;
        private DataGridView ksLatauksetDG;
        private DataGridViewButtonColumn latausColumn;
        private SaveFileDialog saveFileDialog2;
    }
}