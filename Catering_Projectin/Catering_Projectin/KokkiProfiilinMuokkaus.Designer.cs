namespace Catering_Projectin
{
    partial class KokkiProfiilinMuokkaus
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
            this.kokkimuokkaaprofMS = new System.Windows.Forms.MenuStrip();
            this.kokkikotiMS = new System.Windows.Forms.ToolStripMenuItem();
            this.kokkiruoatMS = new System.Windows.Forms.ToolStripMenuItem();
            this.kokkiasetuksetMS = new System.Windows.Forms.ToolStripMenuItem();
            this.kokkiprofMS = new System.Windows.Forms.ToolStripMenuItem();
            this.kokkisalisMS = new System.Windows.Forms.ToolStripMenuItem();
            this.kokkiulosMS = new System.Windows.Forms.ToolStripMenuItem();
            this.kokkisalis1LB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.kokkietunimiTB = new System.Windows.Forms.TextBox();
            this.kokkiemailTB = new System.Windows.Forms.TextBox();
            this.kokkipuhelinTB = new System.Windows.Forms.TextBox();
            this.kokkitoimipaikkaTB = new System.Windows.Forms.TextBox();
            this.kokkisukunimiTB = new System.Windows.Forms.TextBox();
            this.kokkititteliTB = new System.Windows.Forms.TextBox();
            this.kokkiosoiteTB = new System.Windows.Forms.TextBox();
            this.kokkipostiTB = new System.Windows.Forms.TextBox();
            this.kokkimuokkaaprofiiliBT = new System.Windows.Forms.Button();
            this.kokkimuokkaaprofMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // kokkimuokkaaprofMS
            // 
            this.kokkimuokkaaprofMS.Dock = System.Windows.Forms.DockStyle.None;
            this.kokkimuokkaaprofMS.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kokkimuokkaaprofMS.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.kokkimuokkaaprofMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kokkikotiMS,
            this.kokkiruoatMS,
            this.kokkiasetuksetMS});
            this.kokkimuokkaaprofMS.Location = new System.Drawing.Point(22, 37);
            this.kokkimuokkaaprofMS.Name = "kokkimuokkaaprofMS";
            this.kokkimuokkaaprofMS.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.kokkimuokkaaprofMS.Size = new System.Drawing.Size(394, 33);
            this.kokkimuokkaaprofMS.TabIndex = 4;
            this.kokkimuokkaaprofMS.Text = "menuStrip1";
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
            // kokkisalis1LB
            // 
            this.kokkisalis1LB.AutoSize = true;
            this.kokkisalis1LB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kokkisalis1LB.Location = new System.Drawing.Point(149, 185);
            this.kokkisalis1LB.Name = "kokkisalis1LB";
            this.kokkisalis1LB.Size = new System.Drawing.Size(66, 21);
            this.kokkisalis1LB.TabIndex = 6;
            this.kokkisalis1LB.Text = "Etunimi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(473, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sukunimi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(124, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sähköposti:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(149, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Puhelin:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(88, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Postitoimipaikka:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(501, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Titteli:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(494, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Osoite:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(451, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Postinumero:";
            // 
            // kokkietunimiTB
            // 
            this.kokkietunimiTB.Location = new System.Drawing.Point(221, 185);
            this.kokkietunimiTB.Name = "kokkietunimiTB";
            this.kokkietunimiTB.Size = new System.Drawing.Size(173, 23);
            this.kokkietunimiTB.TabIndex = 16;
            // 
            // kokkiemailTB
            // 
            this.kokkiemailTB.Location = new System.Drawing.Point(221, 241);
            this.kokkiemailTB.Name = "kokkiemailTB";
            this.kokkiemailTB.Size = new System.Drawing.Size(173, 23);
            this.kokkiemailTB.TabIndex = 17;
            // 
            // kokkipuhelinTB
            // 
            this.kokkipuhelinTB.Location = new System.Drawing.Point(221, 298);
            this.kokkipuhelinTB.Name = "kokkipuhelinTB";
            this.kokkipuhelinTB.Size = new System.Drawing.Size(173, 23);
            this.kokkipuhelinTB.TabIndex = 18;
            // 
            // kokkitoimipaikkaTB
            // 
            this.kokkitoimipaikkaTB.Location = new System.Drawing.Point(221, 361);
            this.kokkitoimipaikkaTB.Name = "kokkitoimipaikkaTB";
            this.kokkitoimipaikkaTB.Size = new System.Drawing.Size(173, 23);
            this.kokkitoimipaikkaTB.TabIndex = 19;
            // 
            // kokkisukunimiTB
            // 
            this.kokkisukunimiTB.Location = new System.Drawing.Point(558, 187);
            this.kokkisukunimiTB.Name = "kokkisukunimiTB";
            this.kokkisukunimiTB.Size = new System.Drawing.Size(173, 23);
            this.kokkisukunimiTB.TabIndex = 20;
            // 
            // kokkititteliTB
            // 
            this.kokkititteliTB.Location = new System.Drawing.Point(558, 241);
            this.kokkititteliTB.Name = "kokkititteliTB";
            this.kokkititteliTB.Size = new System.Drawing.Size(173, 23);
            this.kokkititteliTB.TabIndex = 21;
            // 
            // kokkiosoiteTB
            // 
            this.kokkiosoiteTB.Location = new System.Drawing.Point(558, 294);
            this.kokkiosoiteTB.Name = "kokkiosoiteTB";
            this.kokkiosoiteTB.Size = new System.Drawing.Size(173, 23);
            this.kokkiosoiteTB.TabIndex = 22;
            // 
            // kokkipostiTB
            // 
            this.kokkipostiTB.Location = new System.Drawing.Point(558, 357);
            this.kokkipostiTB.Name = "kokkipostiTB";
            this.kokkipostiTB.Size = new System.Drawing.Size(173, 23);
            this.kokkipostiTB.TabIndex = 23;
            // 
            // kokkimuokkaaprofiiliBT
            // 
            this.kokkimuokkaaprofiiliBT.Location = new System.Drawing.Point(371, 435);
            this.kokkimuokkaaprofiiliBT.Name = "kokkimuokkaaprofiiliBT";
            this.kokkimuokkaaprofiiliBT.Size = new System.Drawing.Size(149, 32);
            this.kokkimuokkaaprofiiliBT.TabIndex = 26;
            this.kokkimuokkaaprofiiliBT.Text = "Vahvista muutokset!";
            this.kokkimuokkaaprofiiliBT.UseVisualStyleBackColor = true;
            // 
            // KokkiProfiilinMuokkaus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 527);
            this.Controls.Add(this.kokkimuokkaaprofiiliBT);
            this.Controls.Add(this.kokkipostiTB);
            this.Controls.Add(this.kokkiosoiteTB);
            this.Controls.Add(this.kokkititteliTB);
            this.Controls.Add(this.kokkisukunimiTB);
            this.Controls.Add(this.kokkitoimipaikkaTB);
            this.Controls.Add(this.kokkipuhelinTB);
            this.Controls.Add(this.kokkiemailTB);
            this.Controls.Add(this.kokkietunimiTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kokkisalis1LB);
            this.Controls.Add(this.kokkimuokkaaprofMS);
            this.Name = "KokkiProfiilinMuokkaus";
            this.Text = "KokkiProfiilinMuokkaus";
            this.kokkimuokkaaprofMS.ResumeLayout(false);
            this.kokkimuokkaaprofMS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip kokkimuokkaaprofMS;
        private ToolStripMenuItem kokkikotiMS;
        private ToolStripMenuItem kokkiruoatMS;
        private ToolStripMenuItem kokkiasetuksetMS;
        private ToolStripMenuItem kokkiprofMS;
        private ToolStripMenuItem kokkisalisMS;
        private ToolStripMenuItem kokkiulosMS;
        private Label kokkisalis1LB;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox kokkietunimiTB;
        private TextBox kokkiemailTB;
        private TextBox kokkipuhelinTB;
        private TextBox kokkitoimipaikkaTB;
        private TextBox kokkisukunimiTB;
        private TextBox kokkititteliTB;
        private TextBox kokkiosoiteTB;
        private TextBox kokkipostiTB;
        private Button kokkimuokkaaprofiiliBT;
    }
}