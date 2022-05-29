namespace Catering_Projectin
{
    partial class KokkiKotisivu
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
            this.kokkotiMS = new System.Windows.Forms.MenuStrip();
            this.kokkikotiMS = new System.Windows.Forms.ToolStripMenuItem();
            this.kokkiruoatMS = new System.Windows.Forms.ToolStripMenuItem();
            this.kokkiasetuksetMS = new System.Windows.Forms.ToolStripMenuItem();
            this.kokkiprofMS = new System.Windows.Forms.ToolStripMenuItem();
            this.kokkisalisMS = new System.Windows.Forms.ToolStripMenuItem();
            this.kokkiulosMS = new System.Windows.Forms.ToolStripMenuItem();
            this.koktilanneDG = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tilauksetLB = new System.Windows.Forms.Label();
            this.kokTilauksetDG = new System.Windows.Forms.DataGridView();
            this.tilausLB = new System.Windows.Forms.Label();
            this.statusLB = new System.Windows.Forms.Label();
            this.tilausCB = new System.Windows.Forms.ComboBox();
            this.statusCB = new System.Windows.Forms.ComboBox();
            this.tilanneBT = new System.Windows.Forms.Button();
            this.statusInfoDG = new System.Windows.Forms.DataGridView();
            this.kokkotiMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.koktilanneDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kokTilauksetDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusInfoDG)).BeginInit();
            this.SuspendLayout();
            // 
            // kokkotiMS
            // 
            this.kokkotiMS.Dock = System.Windows.Forms.DockStyle.None;
            this.kokkotiMS.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kokkotiMS.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.kokkotiMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kokkikotiMS,
            this.kokkiruoatMS,
            this.kokkiasetuksetMS});
            this.kokkotiMS.Location = new System.Drawing.Point(21, 51);
            this.kokkotiMS.Name = "kokkotiMS";
            this.kokkotiMS.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.kokkotiMS.Size = new System.Drawing.Size(274, 33);
            this.kokkotiMS.TabIndex = 3;
            this.kokkotiMS.Text = "menuStrip1";
            // 
            // kokkikotiMS
            // 
            this.kokkikotiMS.Name = "kokkikotiMS";
            this.kokkikotiMS.Size = new System.Drawing.Size(90, 29);
            this.kokkikotiMS.Text = "Kotisivu";
            // 
            // kokkiruoatMS
            // 
            this.kokkiruoatMS.Name = "kokkiruoatMS";
            this.kokkiruoatMS.Size = new System.Drawing.Size(73, 29);
            this.kokkiruoatMS.Text = "Ruoat";
            this.kokkiruoatMS.Click += new System.EventHandler(this.kokkiruoatMS_Click);
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
            // koktilanneDG
            // 
            this.koktilanneDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.koktilanneDG.Location = new System.Drawing.Point(53, 127);
            this.koktilanneDG.Name = "koktilanneDG";
            this.koktilanneDG.RowTemplate.Height = 25;
            this.koktilanneDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.koktilanneDG.Size = new System.Drawing.Size(427, 173);
            this.koktilanneDG.TabIndex = 4;
            this.koktilanneDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.koktilanneDG_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(193, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Määrätyt työtilaukset";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tilauksetLB
            // 
            this.tilauksetLB.AutoSize = true;
            this.tilauksetLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tilauksetLB.Location = new System.Drawing.Point(178, 327);
            this.tilauksetLB.Name = "tilauksetLB";
            this.tilauksetLB.Size = new System.Drawing.Size(171, 21);
            this.tilauksetLB.TabIndex = 6;
            this.tilauksetLB.Text = "Tämänhetkiset tilaukset";
            // 
            // kokTilauksetDG
            // 
            this.kokTilauksetDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kokTilauksetDG.Location = new System.Drawing.Point(53, 351);
            this.kokTilauksetDG.Name = "kokTilauksetDG";
            this.kokTilauksetDG.RowTemplate.Height = 25;
            this.kokTilauksetDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kokTilauksetDG.Size = new System.Drawing.Size(427, 173);
            this.kokTilauksetDG.TabIndex = 7;
            // 
            // tilausLB
            // 
            this.tilausLB.AutoSize = true;
            this.tilausLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tilausLB.Location = new System.Drawing.Point(690, 313);
            this.tilausLB.Name = "tilausLB";
            this.tilausLB.Size = new System.Drawing.Size(53, 21);
            this.tilausLB.TabIndex = 8;
            this.tilausLB.Text = "Tilaus:";
            // 
            // statusLB
            // 
            this.statusLB.AutoSize = true;
            this.statusLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statusLB.Location = new System.Drawing.Point(673, 369);
            this.statusLB.Name = "statusLB";
            this.statusLB.Size = new System.Drawing.Size(70, 21);
            this.statusLB.TabIndex = 9;
            this.statusLB.Text = "StatusID:";
            // 
            // tilausCB
            // 
            this.tilausCB.FormattingEnabled = true;
            this.tilausCB.Location = new System.Drawing.Point(753, 313);
            this.tilausCB.Name = "tilausCB";
            this.tilausCB.Size = new System.Drawing.Size(140, 23);
            this.tilausCB.TabIndex = 10;
            this.tilausCB.SelectedIndexChanged += new System.EventHandler(this.tilausCB_SelectedIndexChanged);
            // 
            // statusCB
            // 
            this.statusCB.FormattingEnabled = true;
            this.statusCB.Location = new System.Drawing.Point(755, 367);
            this.statusCB.Name = "statusCB";
            this.statusCB.Size = new System.Drawing.Size(138, 23);
            this.statusCB.TabIndex = 11;
            this.statusCB.SelectedIndexChanged += new System.EventHandler(this.statusCB_SelectedIndexChanged);
            // 
            // tilanneBT
            // 
            this.tilanneBT.Location = new System.Drawing.Point(772, 421);
            this.tilanneBT.Name = "tilanneBT";
            this.tilanneBT.Size = new System.Drawing.Size(99, 32);
            this.tilanneBT.TabIndex = 12;
            this.tilanneBT.Text = "Vaihda status";
            this.tilanneBT.UseVisualStyleBackColor = true;
            this.tilanneBT.Click += new System.EventHandler(this.tilanneBT_Click);
            // 
            // statusInfoDG
            // 
            this.statusInfoDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statusInfoDG.Location = new System.Drawing.Point(682, 127);
            this.statusInfoDG.Name = "statusInfoDG";
            this.statusInfoDG.RowTemplate.Height = 25;
            this.statusInfoDG.Size = new System.Drawing.Size(245, 129);
            this.statusInfoDG.TabIndex = 13;
            this.statusInfoDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.statusInfoDG_CellContentClick);
            // 
            // KokkiKotisivu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 549);
            this.Controls.Add(this.statusInfoDG);
            this.Controls.Add(this.tilanneBT);
            this.Controls.Add(this.statusCB);
            this.Controls.Add(this.tilausCB);
            this.Controls.Add(this.statusLB);
            this.Controls.Add(this.tilausLB);
            this.Controls.Add(this.kokTilauksetDG);
            this.Controls.Add(this.tilauksetLB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.koktilanneDG);
            this.Controls.Add(this.kokkotiMS);
            this.Name = "KokkiKotisivu";
            this.Text = "KokkiKotisivu";
            this.Load += new System.EventHandler(this.KokkiKotisivu_Load);
            this.kokkotiMS.ResumeLayout(false);
            this.kokkotiMS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.koktilanneDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kokTilauksetDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusInfoDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip kokkotiMS;
        private ToolStripMenuItem kokkikotiMS;
        private ToolStripMenuItem kokkiruoatMS;
        private ToolStripMenuItem kokkiasetuksetMS;
        private ToolStripMenuItem kokkiprofMS;
        private ToolStripMenuItem kokkisalisMS;
        private ToolStripMenuItem kokkiulosMS;
        private DataGridView koktilanneDG;
        private Label label1;
        private Label tilauksetLB;
        private DataGridView kokTilauksetDG;
        private Label tilausLB;
        private Label statusLB;
        private ComboBox tilausCB;
        private ComboBox statusCB;
        private Button tilanneBT;
        private DataGridView statusInfoDG;
    }
}