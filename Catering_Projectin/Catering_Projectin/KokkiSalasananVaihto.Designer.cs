namespace Catering_Projectin
{
    partial class KokkiSalasananVaihto
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
            this.kokkisalisvaihtoMS = new System.Windows.Forms.MenuStrip();
            this.kokkikotiMS = new System.Windows.Forms.ToolStripMenuItem();
            this.kokkiruoatMS = new System.Windows.Forms.ToolStripMenuItem();
            this.kokkiasetuksetMS = new System.Windows.Forms.ToolStripMenuItem();
            this.kokkiprofMS = new System.Windows.Forms.ToolStripMenuItem();
            this.kokkisalisMS = new System.Windows.Forms.ToolStripMenuItem();
            this.kokkiulosMS = new System.Windows.Forms.ToolStripMenuItem();
            this.kokkisalis1LB = new System.Windows.Forms.Label();
            this.kokkisalis2LB = new System.Windows.Forms.Label();
            this.kokkisalis1TB = new System.Windows.Forms.TextBox();
            this.kokkisalis2TB = new System.Windows.Forms.TextBox();
            this.kokkisalisBT = new System.Windows.Forms.Button();
            this.kokkisalisvaihtoMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // kokkisalisvaihtoMS
            // 
            this.kokkisalisvaihtoMS.Dock = System.Windows.Forms.DockStyle.None;
            this.kokkisalisvaihtoMS.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kokkisalisvaihtoMS.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.kokkisalisvaihtoMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kokkikotiMS,
            this.kokkiruoatMS,
            this.kokkiasetuksetMS});
            this.kokkisalisvaihtoMS.Location = new System.Drawing.Point(20, 35);
            this.kokkisalisvaihtoMS.Name = "kokkisalisvaihtoMS";
            this.kokkisalisvaihtoMS.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.kokkisalisvaihtoMS.Size = new System.Drawing.Size(274, 33);
            this.kokkisalisvaihtoMS.TabIndex = 4;
            this.kokkisalisvaihtoMS.Text = "menuStrip1";
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
            // 
            // kokkiulosMS
            // 
            this.kokkiulosMS.Name = "kokkiulosMS";
            this.kokkiulosMS.Size = new System.Drawing.Size(231, 30);
            this.kokkiulosMS.Text = "Kirjaudu ulos";
            this.kokkiulosMS.Click += new System.EventHandler(this.kokkiulosMS_Click);
            // 
            // kokkisalis1LB
            // 
            this.kokkisalis1LB.AutoSize = true;
            this.kokkisalis1LB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kokkisalis1LB.Location = new System.Drawing.Point(224, 207);
            this.kokkisalis1LB.Name = "kokkisalis1LB";
            this.kokkisalis1LB.Size = new System.Drawing.Size(107, 21);
            this.kokkisalis1LB.TabIndex = 5;
            this.kokkisalis1LB.Text = "Uusi salasana:";
            // 
            // kokkisalis2LB
            // 
            this.kokkisalis2LB.AutoSize = true;
            this.kokkisalis2LB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kokkisalis2LB.Location = new System.Drawing.Point(164, 286);
            this.kokkisalis2LB.Name = "kokkisalis2LB";
            this.kokkisalis2LB.Size = new System.Drawing.Size(167, 21);
            this.kokkisalis2LB.TabIndex = 6;
            this.kokkisalis2LB.Text = "Vahvista uusi salasana:";
            // 
            // kokkisalis1TB
            // 
            this.kokkisalis1TB.Location = new System.Drawing.Point(337, 209);
            this.kokkisalis1TB.Name = "kokkisalis1TB";
            this.kokkisalis1TB.Size = new System.Drawing.Size(188, 23);
            this.kokkisalis1TB.TabIndex = 7;
            // 
            // kokkisalis2TB
            // 
            this.kokkisalis2TB.Location = new System.Drawing.Point(337, 284);
            this.kokkisalis2TB.Name = "kokkisalis2TB";
            this.kokkisalis2TB.Size = new System.Drawing.Size(188, 23);
            this.kokkisalis2TB.TabIndex = 8;
            // 
            // kokkisalisBT
            // 
            this.kokkisalisBT.Location = new System.Drawing.Point(356, 363);
            this.kokkisalisBT.Name = "kokkisalisBT";
            this.kokkisalisBT.Size = new System.Drawing.Size(145, 40);
            this.kokkisalisBT.TabIndex = 9;
            this.kokkisalisBT.Text = "Vahvista!";
            this.kokkisalisBT.UseVisualStyleBackColor = true;
            this.kokkisalisBT.Click += new System.EventHandler(this.kokkisalisBT_Click);
            // 
            // KokkiSalasananVaihto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 548);
            this.Controls.Add(this.kokkisalisBT);
            this.Controls.Add(this.kokkisalis2TB);
            this.Controls.Add(this.kokkisalis1TB);
            this.Controls.Add(this.kokkisalis2LB);
            this.Controls.Add(this.kokkisalis1LB);
            this.Controls.Add(this.kokkisalisvaihtoMS);
            this.Name = "KokkiSalasananVaihto";
            this.Text = "KokkiSalasananVaihto";
            this.kokkisalisvaihtoMS.ResumeLayout(false);
            this.kokkisalisvaihtoMS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip kokkisalisvaihtoMS;
        private ToolStripMenuItem kokkikotiMS;
        private ToolStripMenuItem kokkiruoatMS;
        private ToolStripMenuItem kokkiasetuksetMS;
        private ToolStripMenuItem kokkiprofMS;
        private ToolStripMenuItem kokkisalisMS;
        private ToolStripMenuItem kokkiulosMS;
        private Label kokkisalis1LB;
        private Label kokkisalis2LB;
        private TextBox kokkisalis1TB;
        private TextBox kokkisalis2TB;
        private Button kokkisalisBT;
    }
}