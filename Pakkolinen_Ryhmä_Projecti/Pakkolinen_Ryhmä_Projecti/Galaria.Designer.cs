namespace Pakkolinen_Ryhmä_Projecti
{
    partial class Galleria
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
            this.components = new System.ComponentModel.Container();
            this.OtsitkoLB = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.etusivuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kirjaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rekistroidyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otaYhteyttäToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // OtsitkoLB
            // 
            this.OtsitkoLB.AutoSize = true;
            this.OtsitkoLB.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OtsitkoLB.Location = new System.Drawing.Point(441, 38);
            this.OtsitkoLB.Name = "OtsitkoLB";
            this.OtsitkoLB.Size = new System.Drawing.Size(176, 62);
            this.OtsitkoLB.TabIndex = 3;
            this.OtsitkoLB.Text = "Otsitko";
            // 
            // menuStrip
            // 
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.etusivuToolStripMenuItem,
            this.kirjaiToolStripMenuItem,
            this.rekistroidyToolStripMenuItem,
            this.otaYhteyttäToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(218, 125);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(528, 39);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip";
            // 
            // etusivuToolStripMenuItem
            // 
            this.etusivuToolStripMenuItem.Name = "etusivuToolStripMenuItem";
            this.etusivuToolStripMenuItem.Size = new System.Drawing.Size(101, 35);
            this.etusivuToolStripMenuItem.Text = "Etusivu";
            this.etusivuToolStripMenuItem.Click += new System.EventHandler(this.etusivuToolStripMenuItem_Click);
            // 
            // kirjaiToolStripMenuItem
            // 
            this.kirjaiToolStripMenuItem.Name = "kirjaiToolStripMenuItem";
            this.kirjaiToolStripMenuItem.Size = new System.Drawing.Size(113, 35);
            this.kirjaiToolStripMenuItem.Text = "Kirjaudu";
            this.kirjaiToolStripMenuItem.Click += new System.EventHandler(this.kirjaiToolStripMenuItem_Click);
            // 
            // rekistroidyToolStripMenuItem
            // 
            this.rekistroidyToolStripMenuItem.Name = "rekistroidyToolStripMenuItem";
            this.rekistroidyToolStripMenuItem.Size = new System.Drawing.Size(152, 35);
            this.rekistroidyToolStripMenuItem.Text = "Rekisteröidy";
            this.rekistroidyToolStripMenuItem.Click += new System.EventHandler(this.rekistroidyToolStripMenuItem_Click);
            // 
            // otaYhteyttäToolStripMenuItem
            // 
            this.otaYhteyttäToolStripMenuItem.Name = "otaYhteyttäToolStripMenuItem";
            this.otaYhteyttäToolStripMenuItem.Size = new System.Drawing.Size(154, 35);
            this.otaYhteyttäToolStripMenuItem.Text = "Ota yhteyttä";
            this.otaYhteyttäToolStripMenuItem.Click += new System.EventHandler(this.otaYhteyttäToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(47, 207);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 253);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(359, 207);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(275, 253);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(663, 207);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(273, 253);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // Galleria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 519);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.OtsitkoLB);
            this.Controls.Add(this.menuStrip);
            this.Name = "Galleria";
            this.Text = "Galleria";
            this.Load += new System.EventHandler(this.Galleria_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label OtsitkoLB;
        private MenuStrip menuStrip;
        private ToolStripMenuItem etusivuToolStripMenuItem;
        private ToolStripMenuItem kirjaiToolStripMenuItem;
        private ToolStripMenuItem rekistroidyToolStripMenuItem;
        private ToolStripMenuItem otaYhteyttäToolStripMenuItem;
        private ImageList imageList1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}