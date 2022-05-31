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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Kuvaus1RTB = new System.Windows.Forms.RichTextBox();
            this.NavMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.NavMS.Size = new System.Drawing.Size(524, 39);
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
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(110, 204);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 231);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(640, 204);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(303, 236);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // Kuvaus1RTB
            // 
            this.Kuvaus1RTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Kuvaus1RTB.Enabled = false;
            this.Kuvaus1RTB.Location = new System.Drawing.Point(268, 527);
            this.Kuvaus1RTB.Name = "Kuvaus1RTB";
            this.Kuvaus1RTB.ReadOnly = true;
            this.Kuvaus1RTB.Size = new System.Drawing.Size(567, 171);
            this.Kuvaus1RTB.TabIndex = 4;
            this.Kuvaus1RTB.Text = resources.GetString("Kuvaus1RTB.Text");
            // 
            // Etusivu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 772);
            this.Controls.Add(this.Kuvaus1RTB);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.OtsikkoLB);
            this.Controls.Add(this.NavMS);
            this.MainMenuStrip = this.NavMS;
            this.Name = "Etusivu";
            this.Text = "Catering";
            this.NavMS.ResumeLayout(false);
            this.NavMS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label OtsikkoLB;
        private MenuStrip NavMS;
        private ToolStripMenuItem EtusivuTMSI;
        private ToolStripMenuItem KirjauduTMSI;
        private ToolStripMenuItem RekisteroidyTMSI;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private RichTextBox Kuvaus1RTB;
    }
}