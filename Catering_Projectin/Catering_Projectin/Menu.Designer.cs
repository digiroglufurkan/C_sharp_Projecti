namespace Catering_Projectin
{
    partial class Menu
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.kotisivuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tilausToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asatuksetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AteriatGW = new System.Windows.Forms.DataGridView();
            this.AlkohollisetGW = new System.Windows.Forms.DataGridView();
            this.AlkohollimatGW = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.muokkaTiliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kirjouduUlosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AteriatGW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlkohollisetGW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlkohollimatGW)).BeginInit();
            this.SuspendLayout();
            // 
            // OtsikkoLB
            // 
            this.OtsikkoLB.AutoSize = true;
            this.OtsikkoLB.Font = new System.Drawing.Font("Bell MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OtsikkoLB.Location = new System.Drawing.Point(526, 50);
            this.OtsikkoLB.Name = "OtsikkoLB";
            this.OtsikkoLB.Size = new System.Drawing.Size(307, 46);
            this.OtsikkoLB.TabIndex = 16;
            this.OtsikkoLB.Text = "Catering Projekti";
            // 
            // menuStrip
            // 
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kotisivuToolStripMenuItem,
            this.tilausToolStripMenuItem,
            this.asatuksetToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(498, 122);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(525, 39);
            this.menuStrip.TabIndex = 15;
            this.menuStrip.Text = "menuStrip";
            // 
            // kotisivuToolStripMenuItem
            // 
            this.kotisivuToolStripMenuItem.Name = "kotisivuToolStripMenuItem";
            this.kotisivuToolStripMenuItem.Size = new System.Drawing.Size(107, 35);
            this.kotisivuToolStripMenuItem.Text = "Kotisivu";
            this.kotisivuToolStripMenuItem.Click += new System.EventHandler(this.kotisivuToolStripMenuItem_Click);
            // 
            // tilausToolStripMenuItem
            // 
            this.tilausToolStripMenuItem.Name = "tilausToolStripMenuItem";
            this.tilausToolStripMenuItem.Size = new System.Drawing.Size(133, 35);
            this.tilausToolStripMenuItem.Text = "Tee Tilaus ";
            this.tilausToolStripMenuItem.Click += new System.EventHandler(this.tilausToolStripMenuItem_Click);
            // 
            // asatuksetToolStripMenuItem
            // 
            this.asatuksetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muokkaTiliToolStripMenuItem,
            this.kirjouduUlosToolStripMenuItem});
            this.asatuksetToolStripMenuItem.Name = "asatuksetToolStripMenuItem";
            this.asatuksetToolStripMenuItem.Size = new System.Drawing.Size(127, 35);
            this.asatuksetToolStripMenuItem.Text = "Asatukset";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(43, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = "Valite Lento";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(46, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(787, 201);
            this.dataGridView1.TabIndex = 18;
            // 
            // AteriatGW
            // 
            this.AteriatGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AteriatGW.Location = new System.Drawing.Point(46, 480);
            this.AteriatGW.Name = "AteriatGW";
            this.AteriatGW.RowHeadersWidth = 51;
            this.AteriatGW.RowTemplate.Height = 29;
            this.AteriatGW.Size = new System.Drawing.Size(787, 201);
            this.AteriatGW.TabIndex = 19;
            // 
            // AlkohollisetGW
            // 
            this.AlkohollisetGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AlkohollisetGW.Location = new System.Drawing.Point(936, 480);
            this.AlkohollisetGW.Name = "AlkohollisetGW";
            this.AlkohollisetGW.RowHeadersWidth = 51;
            this.AlkohollisetGW.RowTemplate.Height = 29;
            this.AlkohollisetGW.Size = new System.Drawing.Size(338, 201);
            this.AlkohollisetGW.TabIndex = 22;
            // 
            // AlkohollimatGW
            // 
            this.AlkohollimatGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AlkohollimatGW.Location = new System.Drawing.Point(936, 230);
            this.AlkohollimatGW.Name = "AlkohollimatGW";
            this.AlkohollimatGW.RowHeadersWidth = 51;
            this.AlkohollimatGW.RowTemplate.Height = 29;
            this.AlkohollimatGW.Size = new System.Drawing.Size(338, 201);
            this.AlkohollimatGW.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(43, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 31);
            this.label2.TabIndex = 23;
            this.label2.Text = "Ateriat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(936, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 31);
            this.label4.TabIndex = 25;
            this.label4.Text = "Juomat Alkohollimat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(936, 439);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 31);
            this.label5.TabIndex = 26;
            this.label5.Text = "Alkohollliset Juomat";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(587, 727);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 40);
            this.button1.TabIndex = 27;
            this.button1.Text = "Lisää Tilaus";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // muokkaTiliToolStripMenuItem
            // 
            this.muokkaTiliToolStripMenuItem.Name = "muokkaTiliToolStripMenuItem";
            this.muokkaTiliToolStripMenuItem.Size = new System.Drawing.Size(239, 36);
            this.muokkaTiliToolStripMenuItem.Text = "Muokka Tili";
            this.muokkaTiliToolStripMenuItem.Click += new System.EventHandler(this.muokkaTiliToolStripMenuItem_Click);
            // 
            // kirjouduUlosToolStripMenuItem
            // 
            this.kirjouduUlosToolStripMenuItem.Name = "kirjouduUlosToolStripMenuItem";
            this.kirjouduUlosToolStripMenuItem.Size = new System.Drawing.Size(239, 36);
            this.kirjouduUlosToolStripMenuItem.Text = "Kirjoudu Ulos";
            this.kirjouduUlosToolStripMenuItem.Click += new System.EventHandler(this.kirjouduUlosToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 795);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AlkohollisetGW);
            this.Controls.Add(this.AlkohollimatGW);
            this.Controls.Add(this.AteriatGW);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OtsikkoLB);
            this.Controls.Add(this.menuStrip);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AteriatGW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlkohollisetGW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlkohollimatGW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label OtsikkoLB;
        private MenuStrip menuStrip;
        private ToolStripMenuItem kotisivuToolStripMenuItem;
        private ToolStripMenuItem tilausToolStripMenuItem;
        private ToolStripMenuItem asatuksetToolStripMenuItem;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridView AteriatGW;
        private DataGridView AlkohollisetGW;
        private DataGridView AlkohollimatGW;
        private Label label2;
        private Label label4;
        private Label label5;
        private Button button1;
        private ToolStripMenuItem muokkaTiliToolStripMenuItem;
        private ToolStripMenuItem kirjouduUlosToolStripMenuItem;
    }
}