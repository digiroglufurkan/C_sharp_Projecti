namespace Pakkolinen_Ryhmä_Projecti
{
    partial class Kirjaudu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.KiTunnusTB = new System.Windows.Forms.TextBox();
            this.KiSalasanaTB = new System.Windows.Forms.TextBox();
            this.KirjoiduBT = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.KisahkopostiTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OtsitkoLB = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.etusivuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.galleriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otaYhteyttäToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Käyttäjän Tunnus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 176);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salasana";
            // 
            // KiTunnusTB
            // 
            this.KiTunnusTB.Location = new System.Drawing.Point(422, 56);
            this.KiTunnusTB.Margin = new System.Windows.Forms.Padding(5);
            this.KiTunnusTB.Name = "KiTunnusTB";
            this.KiTunnusTB.Size = new System.Drawing.Size(287, 38);
            this.KiTunnusTB.TabIndex = 3;
            // 
            // KiSalasanaTB
            // 
            this.KiSalasanaTB.Location = new System.Drawing.Point(422, 169);
            this.KiSalasanaTB.Margin = new System.Windows.Forms.Padding(5);
            this.KiSalasanaTB.Name = "KiSalasanaTB";
            this.KiSalasanaTB.Size = new System.Drawing.Size(287, 38);
            this.KiSalasanaTB.TabIndex = 4;
            // 
            // KirjoiduBT
            // 
            this.KirjoiduBT.Location = new System.Drawing.Point(472, 260);
            this.KirjoiduBT.Name = "KirjoiduBT";
            this.KirjoiduBT.Size = new System.Drawing.Size(170, 57);
            this.KirjoiduBT.TabIndex = 5;
            this.KirjoiduBT.Text = "Kirjoidu";
            this.KirjoiduBT.UseVisualStyleBackColor = true;
            this.KirjoiduBT.Click += new System.EventHandler(this.KirjoiduBT_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(263, 339);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(216, 31);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Unohditko Salasana";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.KisahkopostiTB);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(78, 223);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1032, 422);
            this.panel1.TabIndex = 7;
            this.panel1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(396, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Lähetä";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // KisahkopostiTB
            // 
            this.KisahkopostiTB.Location = new System.Drawing.Point(451, 67);
            this.KisahkopostiTB.Name = "KisahkopostiTB";
            this.KisahkopostiTB.Size = new System.Drawing.Size(447, 38);
            this.KisahkopostiTB.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Syötä Sähköposti";
            // 
            // OtsitkoLB
            // 
            this.OtsitkoLB.AutoSize = true;
            this.OtsitkoLB.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OtsitkoLB.Location = new System.Drawing.Point(515, 42);
            this.OtsitkoLB.Name = "OtsitkoLB";
            this.OtsitkoLB.Size = new System.Drawing.Size(176, 62);
            this.OtsitkoLB.TabIndex = 9;
            this.OtsitkoLB.Text = "Otsitko";
            // 
            // menuStrip
            // 
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.etusivuToolStripMenuItem,
            this.galleriaToolStripMenuItem,
            this.otaYhteyttäToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(334, 128);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(369, 39);
            this.menuStrip.TabIndex = 8;
            this.menuStrip.Text = "menuStrip";
            // 
            // etusivuToolStripMenuItem
            // 
            this.etusivuToolStripMenuItem.Name = "etusivuToolStripMenuItem";
            this.etusivuToolStripMenuItem.Size = new System.Drawing.Size(101, 35);
            this.etusivuToolStripMenuItem.Text = "Etusivu";
            this.etusivuToolStripMenuItem.Click += new System.EventHandler(this.etusivuToolStripMenuItem_Click);
            // 
            // galleriaToolStripMenuItem
            // 
            this.galleriaToolStripMenuItem.Name = "galleriaToolStripMenuItem";
            this.galleriaToolStripMenuItem.Size = new System.Drawing.Size(106, 35);
            this.galleriaToolStripMenuItem.Text = "Galleria";
            // 
            // otaYhteyttäToolStripMenuItem
            // 
            this.otaYhteyttäToolStripMenuItem.Name = "otaYhteyttäToolStripMenuItem";
            this.otaYhteyttäToolStripMenuItem.Size = new System.Drawing.Size(154, 35);
            this.otaYhteyttäToolStripMenuItem.Text = "Ota yhteyttä";
            this.otaYhteyttäToolStripMenuItem.Click += new System.EventHandler(this.otaYhteyttäToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.KirjoiduBT);
            this.panel2.Controls.Add(this.KiTunnusTB);
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.KiSalasanaTB);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(113, 210);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1012, 449);
            this.panel2.TabIndex = 10;
            // 
            // Kirjaudu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 684);
            this.Controls.Add(this.OtsitkoLB);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Kirjaudu";
            this.Text = "Kirjaudu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox KiTunnusTB;
        private TextBox KiSalasanaTB;
        private Button KirjoiduBT;
        private LinkLabel linkLabel1;
        private Panel panel1;
        private Button button1;
        private TextBox KisahkopostiTB;
        private Label label3;
        private Label OtsitkoLB;
        private MenuStrip menuStrip;
        private ToolStripMenuItem etusivuToolStripMenuItem;
        private ToolStripMenuItem galleriaToolStripMenuItem;
        private ToolStripMenuItem otaYhteyttäToolStripMenuItem;
        private Panel panel2;
    }
}