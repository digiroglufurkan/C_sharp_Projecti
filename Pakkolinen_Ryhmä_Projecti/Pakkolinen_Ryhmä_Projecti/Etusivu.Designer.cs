namespace Pakkolinen_Ryhmä_Projecti
{
    partial class Etusivu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Etusivu));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.rekistrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kirjaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.galleriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otaYhteyttäToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OtsitkoLB = new System.Windows.Forms.Label();
            this.EtusivuKuvaPB = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EtusivuKuvaPB)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rekistrToolStripMenuItem,
            this.kirjaiToolStripMenuItem,
            this.galleriaToolStripMenuItem,
            this.otaYhteyttäToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(132, 119);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(533, 39);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // rekistrToolStripMenuItem
            // 
            this.rekistrToolStripMenuItem.Name = "rekistrToolStripMenuItem";
            this.rekistrToolStripMenuItem.Size = new System.Drawing.Size(152, 35);
            this.rekistrToolStripMenuItem.Text = "Rekisteröidy";
            this.rekistrToolStripMenuItem.Click += new System.EventHandler(this.rekistrToolStripMenuItem_Click);
            // 
            // kirjaiToolStripMenuItem
            // 
            this.kirjaiToolStripMenuItem.Name = "kirjaiToolStripMenuItem";
            this.kirjaiToolStripMenuItem.Size = new System.Drawing.Size(113, 35);
            this.kirjaiToolStripMenuItem.Text = "Kirjaudu";
            this.kirjaiToolStripMenuItem.Click += new System.EventHandler(this.kirjaiToolStripMenuItem_Click);
            // 
            // galleriaToolStripMenuItem
            // 
            this.galleriaToolStripMenuItem.Name = "galleriaToolStripMenuItem";
            this.galleriaToolStripMenuItem.Size = new System.Drawing.Size(106, 35);
            this.galleriaToolStripMenuItem.Text = "Galleria";
            this.galleriaToolStripMenuItem.Click += new System.EventHandler(this.galleriaToolStripMenuItem_Click);
            // 
            // otaYhteyttäToolStripMenuItem
            // 
            this.otaYhteyttäToolStripMenuItem.Name = "otaYhteyttäToolStripMenuItem";
            this.otaYhteyttäToolStripMenuItem.Size = new System.Drawing.Size(154, 35);
            this.otaYhteyttäToolStripMenuItem.Text = "Ota yhteyttä";
            this.otaYhteyttäToolStripMenuItem.Click += new System.EventHandler(this.otaYhteyttäToolStripMenuItem_Click);
            // 
            // OtsitkoLB
            // 
            this.OtsitkoLB.AutoSize = true;
            this.OtsitkoLB.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OtsitkoLB.Location = new System.Drawing.Point(316, 30);
            this.OtsitkoLB.Name = "OtsitkoLB";
            this.OtsitkoLB.Size = new System.Drawing.Size(176, 62);
            this.OtsitkoLB.TabIndex = 1;
            this.OtsitkoLB.Text = "Otsitko";
            // 
            // EtusivuKuvaPB
            // 
            this.EtusivuKuvaPB.Location = new System.Drawing.Point(249, 189);
            this.EtusivuKuvaPB.Name = "EtusivuKuvaPB";
            this.EtusivuKuvaPB.Size = new System.Drawing.Size(287, 201);
            this.EtusivuKuvaPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EtusivuKuvaPB.TabIndex = 2;
            this.EtusivuKuvaPB.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(44, 407);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(728, 123);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Etusivu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(807, 579);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.EtusivuKuvaPB);
            this.Controls.Add(this.OtsitkoLB);
            this.Controls.Add(this.menuStrip);
            this.Name = "Etusivu";
            this.Text = "Etusivu";
            this.Load += new System.EventHandler(this.Etusivu_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EtusivuKuvaPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem rekistrToolStripMenuItem;
        private ToolStripMenuItem kirjaiToolStripMenuItem;
        private ToolStripMenuItem galleriaToolStripMenuItem;
        private ToolStripMenuItem otaYhteyttäToolStripMenuItem;
        private Label OtsitkoLB;
        private PictureBox EtusivuKuvaPB;
        private RichTextBox richTextBox1;
        private System.Windows.Forms.Timer timer1;
    }
}