namespace Catering_Projectin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Etusivu));
            this.OtsikkoLB = new System.Windows.Forms.Label();
            this.NavMS = new System.Windows.Forms.MenuStrip();
            this.EtusivuTMSI = new System.Windows.Forms.ToolStripMenuItem();
            this.KirjauduTMSI = new System.Windows.Forms.ToolStripMenuItem();
            this.RekisteroidyTMSI = new System.Windows.Forms.ToolStripMenuItem();
            this.Kuv1PB = new System.Windows.Forms.PictureBox();
            this.Kuv2PB = new System.Windows.Forms.PictureBox();
            this.Kuvaus1RTB = new System.Windows.Forms.RichTextBox();
            this.Ku1LahLB = new System.Windows.Forms.Label();
            this.Ku2LahLB = new System.Windows.Forms.Label();
            this.NavMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Kuv1PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kuv2PB)).BeginInit();
            this.SuspendLayout();
            // 
            // OtsikkoLB
            // 
            this.OtsikkoLB.AutoSize = true;
            this.OtsikkoLB.Font = new System.Drawing.Font("Bell MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OtsikkoLB.Location = new System.Drawing.Point(398, 35);
            this.OtsikkoLB.Name = "OtsikkoLB";
            this.OtsikkoLB.Size = new System.Drawing.Size(307, 46);
            this.OtsikkoLB.TabIndex = 0;
            this.OtsikkoLB.Text = "Catering Projekti";
            // 
            // NavMS
            // 
            this.NavMS.Dock = System.Windows.Forms.DockStyle.None;
            this.NavMS.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NavMS.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.NavMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EtusivuTMSI,
            this.KirjauduTMSI,
            this.RekisteroidyTMSI});
            this.NavMS.Location = new System.Drawing.Point(308, 103);
            this.NavMS.Name = "NavMS";
            this.NavMS.Size = new System.Drawing.Size(374, 39);
            this.NavMS.TabIndex = 1;
            this.NavMS.Text = "menuStrip1";
            // 
            // EtusivuTMSI
            // 
            this.EtusivuTMSI.Name = "EtusivuTMSI";
            this.EtusivuTMSI.Size = new System.Drawing.Size(101, 35);
            this.EtusivuTMSI.Text = "Etusivu";
            this.EtusivuTMSI.Click += new System.EventHandler(this.EtusivuTMSI_Click);
            // 
            // KirjauduTMSI
            // 
            this.KirjauduTMSI.Name = "KirjauduTMSI";
            this.KirjauduTMSI.Size = new System.Drawing.Size(113, 35);
            this.KirjauduTMSI.Text = "Kirjaudu";
            this.KirjauduTMSI.Click += new System.EventHandler(this.KirjauduTMSI_Click);
            // 
            // RekisteroidyTMSI
            // 
            this.RekisteroidyTMSI.Name = "RekisteroidyTMSI";
            this.RekisteroidyTMSI.Size = new System.Drawing.Size(152, 35);
            this.RekisteroidyTMSI.Text = "Rekisteröidy";
            this.RekisteroidyTMSI.Click += new System.EventHandler(this.RekisteroidyTMSI_Click);
            // 
            // Kuv1PB
            // 
            this.Kuv1PB.Image = ((System.Drawing.Image)(resources.GetObject("Kuv1PB.Image")));
            this.Kuv1PB.Location = new System.Drawing.Point(28, 165);
            this.Kuv1PB.Name = "Kuv1PB";
            this.Kuv1PB.Size = new System.Drawing.Size(495, 348);
            this.Kuv1PB.TabIndex = 2;
            this.Kuv1PB.TabStop = false;
            // 
            // Kuv2PB
            // 
            this.Kuv2PB.Image = ((System.Drawing.Image)(resources.GetObject("Kuv2PB.Image")));
            this.Kuv2PB.Location = new System.Drawing.Point(574, 165);
            this.Kuv2PB.Name = "Kuv2PB";
            this.Kuv2PB.Size = new System.Drawing.Size(495, 348);
            this.Kuv2PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Kuv2PB.TabIndex = 3;
            this.Kuv2PB.TabStop = false;
            // 
            // Kuvaus1RTB
            // 
            this.Kuvaus1RTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Kuvaus1RTB.Enabled = false;
            this.Kuvaus1RTB.Location = new System.Drawing.Point(270, 611);
            this.Kuvaus1RTB.Name = "Kuvaus1RTB";
            this.Kuvaus1RTB.ReadOnly = true;
            this.Kuvaus1RTB.Size = new System.Drawing.Size(567, 171);
            this.Kuvaus1RTB.TabIndex = 4;
            this.Kuvaus1RTB.Text = resources.GetString("Kuvaus1RTB.Text");
            // 
            // Ku1LahLB
            // 
            this.Ku1LahLB.AutoSize = true;
            this.Ku1LahLB.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Ku1LahLB.Location = new System.Drawing.Point(12, 528);
            this.Ku1LahLB.Name = "Ku1LahLB";
            this.Ku1LahLB.Size = new System.Drawing.Size(519, 17);
            this.Ku1LahLB.TabIndex = 5;
            this.Ku1LahLB.Text = "Lähde: https://commons.wikimedia.org/wiki/File:DO_%26_CO_Catering_-_8968355090.jp" +
    "g";
            // 
            // Ku2LahLB
            // 
            this.Ku2LahLB.AutoSize = true;
            this.Ku2LahLB.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Ku2LahLB.Location = new System.Drawing.Point(589, 516);
            this.Ku2LahLB.Name = "Ku2LahLB";
            this.Ku2LahLB.Size = new System.Drawing.Size(467, 17);
            this.Ku2LahLB.TabIndex = 6;
            this.Ku2LahLB.Text = "Lähde: //commons.wikimedia.org/wiki/File:EVA_Air_Premium_Laurel_catering.jpg";
            // 
            // Etusivu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 772);
            this.Controls.Add(this.Ku2LahLB);
            this.Controls.Add(this.Ku1LahLB);
            this.Controls.Add(this.Kuvaus1RTB);
            this.Controls.Add(this.Kuv2PB);
            this.Controls.Add(this.Kuv1PB);
            this.Controls.Add(this.OtsikkoLB);
            this.Controls.Add(this.NavMS);
            this.MainMenuStrip = this.NavMS;
            this.Name = "Etusivu";
            this.Text = "Catering";
            this.NavMS.ResumeLayout(false);
            this.NavMS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Kuv1PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kuv2PB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label OtsikkoLB;
        private MenuStrip NavMS;
        private ToolStripMenuItem EtusivuTMSI;
        private ToolStripMenuItem KirjauduTMSI;
        private ToolStripMenuItem RekisteroidyTMSI;
        private PictureBox Kuv1PB;
        private PictureBox Kuv2PB;
        private RichTextBox Kuvaus1RTB;
        private Label Ku1LahLB;
        private Label Ku2LahLB;
    }
}