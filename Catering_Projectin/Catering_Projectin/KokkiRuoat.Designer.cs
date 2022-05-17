namespace Catering_Projectin
{
    partial class KokkiRuoat
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
            this.kokinvarastoMS = new System.Windows.Forms.MenuStrip();
            this.kokkikotiMS = new System.Windows.Forms.ToolStripMenuItem();
            this.kokkiruoatMS = new System.Windows.Forms.ToolStripMenuItem();
            this.kokkiasetuksetMS = new System.Windows.Forms.ToolStripMenuItem();
            this.kokkiprofMS = new System.Windows.Forms.ToolStripMenuItem();
            this.kokkisalisMS = new System.Windows.Forms.ToolStripMenuItem();
            this.kokkiulosMS = new System.Windows.Forms.ToolStripMenuItem();
            this.kokkiruoatDG = new System.Windows.Forms.DataGridView();
            this.kokinvarastoMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kokkiruoatDG)).BeginInit();
            this.SuspendLayout();
            // 
            // kokinvarastoMS
            // 
            this.kokinvarastoMS.Dock = System.Windows.Forms.DockStyle.None;
            this.kokinvarastoMS.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kokinvarastoMS.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.kokinvarastoMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kokkikotiMS,
            this.kokkiruoatMS,
            this.kokkiasetuksetMS});
            this.kokinvarastoMS.Location = new System.Drawing.Point(23, 38);
            this.kokinvarastoMS.Name = "kokinvarastoMS";
            this.kokinvarastoMS.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.kokinvarastoMS.Size = new System.Drawing.Size(394, 33);
            this.kokinvarastoMS.TabIndex = 4;
            this.kokinvarastoMS.Text = "menuStrip1";
            // 
            // kokkikotiMS
            // 
            this.kokkikotiMS.Name = "kokkikotiMS";
            this.kokkikotiMS.Size = new System.Drawing.Size(90, 29);
            this.kokkikotiMS.Text = "Kotisivu";
            this.kokkikotiMS.Click += new System.EventHandler(this.kokkikotiMS_Click);
            // 
            // kokkiruoatMS
            // 
            this.kokkiruoatMS.Name = "kokkiruoatMS";
            this.kokkiruoatMS.Size = new System.Drawing.Size(73, 29);
            this.kokkiruoatMS.Text = "Ruoat";
            // 
            // kokkiasetuksetMS
            // 
            this.kokkiasetuksetMS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kokkiprofMS,
            this.kokkisalisMS,
            this.kokkiulosMS});
            this.kokkiasetuksetMS.Name = "kokkiasetuksetMS";
            this.kokkiasetuksetMS.Size = new System.Drawing.Size(104, 29);
            this.kokkiasetuksetMS.Text = "Asetukset";
            // 
            // kokkiprofMS
            // 
            this.kokkiprofMS.Name = "kokkiprofMS";
            this.kokkiprofMS.Size = new System.Drawing.Size(231, 30);
            this.kokkiprofMS.Text = "Muokkaa profiilia";
            this.kokkiprofMS.Click += new System.EventHandler(this.kokkiprofMS_Click);
            // 
            // kokkisalisMS
            // 
            this.kokkisalisMS.Name = "kokkisalisMS";
            this.kokkisalisMS.Size = new System.Drawing.Size(231, 30);
            this.kokkisalisMS.Text = "Vaihda salasana";
            this.kokkisalisMS.Click += new System.EventHandler(this.kokkisalisMS_Click);
            // 
            // kokkiulosMS
            // 
            this.kokkiulosMS.Name = "kokkiulosMS";
            this.kokkiulosMS.Size = new System.Drawing.Size(231, 30);
            this.kokkiulosMS.Text = "Kirjaudu ulos";
            this.kokkiulosMS.Click += new System.EventHandler(this.kokkiulosMS_Click);
            // 
            // kokkiruoatDG
            // 
            this.kokkiruoatDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kokkiruoatDG.Location = new System.Drawing.Point(185, 119);
            this.kokkiruoatDG.Name = "kokkiruoatDG";
            this.kokkiruoatDG.RowTemplate.Height = 25;
            this.kokkiruoatDG.Size = new System.Drawing.Size(561, 382);
            this.kokkiruoatDG.TabIndex = 5;
            // 
            // KokkiRuoat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 545);
            this.Controls.Add(this.kokkiruoatDG);
            this.Controls.Add(this.kokinvarastoMS);
            this.Name = "KokkiRuoat";
            this.Text = "KokkiRuoat";
            this.kokinvarastoMS.ResumeLayout(false);
            this.kokinvarastoMS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kokkiruoatDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip kokinvarastoMS;
        private ToolStripMenuItem kokkikotiMS;
        private ToolStripMenuItem kokkiruoatMS;
        private ToolStripMenuItem kokkiasetuksetMS;
        private ToolStripMenuItem kokkiprofMS;
        private ToolStripMenuItem kokkisalisMS;
        private ToolStripMenuItem kokkiulosMS;
        private DataGridView kokkiruoatDG;
    }
}