namespace Catering_Projectin
{
    partial class Rekisteroidy
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
            this.rekMS = new System.Windows.Forms.MenuStrip();
            this.reketusivuMS = new System.Windows.Forms.ToolStripMenuItem();
            this.rekkirjauduMS = new System.Windows.Forms.ToolStripMenuItem();
            this.RekisteroidyTMSI = new System.Windows.Forms.ToolStripMenuItem();
            this.OtsikkoLB = new System.Windows.Forms.Label();
            this.reklentoLB = new System.Windows.Forms.Label();
            this.reketunimiLB = new System.Windows.Forms.Label();
            this.rekemailLB = new System.Windows.Forms.Label();
            this.rekosoiteLB = new System.Windows.Forms.Label();
            this.reksukunimiLB = new System.Windows.Forms.Label();
            this.rekpuhelinLB = new System.Windows.Forms.Label();
            this.rekpostiLB = new System.Windows.Forms.Label();
            this.icaoLB = new System.Windows.Forms.Label();
            this.rektoimiLB = new System.Windows.Forms.Label();
            this.reklentoTB = new System.Windows.Forms.TextBox();
            this.reketuTB = new System.Windows.Forms.TextBox();
            this.rekemailTB = new System.Windows.Forms.TextBox();
            this.rekosoiteTB = new System.Windows.Forms.TextBox();
            this.rektoimiTB = new System.Windows.Forms.TextBox();
            this.reksukunimiTB = new System.Windows.Forms.TextBox();
            this.rekpuhelinTB = new System.Windows.Forms.TextBox();
            this.rekpostiTB = new System.Windows.Forms.TextBox();
            this.icaoTB = new System.Windows.Forms.TextBox();
            this.rekisteroidyBT = new System.Windows.Forms.Button();
            this.rekSalis1LB = new System.Windows.Forms.Label();
            this.rekSalis2LB = new System.Windows.Forms.Label();
            this.rekSalis1TB = new System.Windows.Forms.TextBox();
            this.rekSalis2TB = new System.Windows.Forms.TextBox();
            this.rekMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // rekMS
            // 
            this.rekMS.Dock = System.Windows.Forms.DockStyle.None;
            this.rekMS.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rekMS.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rekMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reketusivuMS,
            this.rekkirjauduMS,
            this.RekisteroidyTMSI});
            this.rekMS.Location = new System.Drawing.Point(331, 74);
            this.rekMS.Name = "rekMS";
            this.rekMS.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.rekMS.Size = new System.Drawing.Size(311, 33);
            this.rekMS.TabIndex = 2;
            this.rekMS.Text = "menuStrip1";
            // 
            // reketusivuMS
            // 
            this.reketusivuMS.Name = "reketusivuMS";
            this.reketusivuMS.Size = new System.Drawing.Size(84, 29);
            this.reketusivuMS.Text = "Etusivu";
            this.reketusivuMS.Click += new System.EventHandler(this.reketusivuMS_Click);
            // 
            // rekkirjauduMS
            // 
            this.rekkirjauduMS.Name = "rekkirjauduMS";
            this.rekkirjauduMS.Size = new System.Drawing.Size(95, 29);
            this.rekkirjauduMS.Text = "Kirjaudu";
            this.rekkirjauduMS.Click += new System.EventHandler(this.rekkirjauduMS_Click);
            // 
            // RekisteroidyTMSI
            // 
            this.RekisteroidyTMSI.Name = "RekisteroidyTMSI";
            this.RekisteroidyTMSI.Size = new System.Drawing.Size(125, 29);
            this.RekisteroidyTMSI.Text = "Rekisteröidy";
            // 
            // OtsikkoLB
            // 
            this.OtsikkoLB.AutoSize = true;
            this.OtsikkoLB.Font = new System.Drawing.Font("Bell MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OtsikkoLB.Location = new System.Drawing.Point(359, 9);
            this.OtsikkoLB.Name = "OtsikkoLB";
            this.OtsikkoLB.Size = new System.Drawing.Size(247, 38);
            this.OtsikkoLB.TabIndex = 3;
            this.OtsikkoLB.Text = "Catering Projekti";
            // 
            // reklentoLB
            // 
            this.reklentoLB.AutoSize = true;
            this.reklentoLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reklentoLB.Location = new System.Drawing.Point(147, 174);
            this.reklentoLB.Name = "reklentoLB";
            this.reklentoLB.Size = new System.Drawing.Size(87, 21);
            this.reklentoLB.TabIndex = 4;
            this.reklentoLB.Text = "Lentoyhtiö:";
            // 
            // reketunimiLB
            // 
            this.reketunimiLB.AutoSize = true;
            this.reketunimiLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reketunimiLB.Location = new System.Drawing.Point(168, 217);
            this.reketunimiLB.Name = "reketunimiLB";
            this.reketunimiLB.Size = new System.Drawing.Size(66, 21);
            this.reketunimiLB.TabIndex = 6;
            this.reketunimiLB.Text = "Etunimi:";
            this.reketunimiLB.Click += new System.EventHandler(this.reketunimiLB_Click);
            // 
            // rekemailLB
            // 
            this.rekemailLB.AutoSize = true;
            this.rekemailLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rekemailLB.Location = new System.Drawing.Point(144, 255);
            this.rekemailLB.Name = "rekemailLB";
            this.rekemailLB.Size = new System.Drawing.Size(90, 21);
            this.rekemailLB.TabIndex = 7;
            this.rekemailLB.Text = "Sähköposti:";
            // 
            // rekosoiteLB
            // 
            this.rekosoiteLB.AutoSize = true;
            this.rekosoiteLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rekosoiteLB.Location = new System.Drawing.Point(176, 299);
            this.rekosoiteLB.Name = "rekosoiteLB";
            this.rekosoiteLB.Size = new System.Drawing.Size(58, 21);
            this.rekosoiteLB.TabIndex = 8;
            this.rekosoiteLB.Text = "Osoite:";
            // 
            // reksukunimiLB
            // 
            this.reksukunimiLB.AutoSize = true;
            this.reksukunimiLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reksukunimiLB.Location = new System.Drawing.Point(494, 217);
            this.reksukunimiLB.Name = "reksukunimiLB";
            this.reksukunimiLB.Size = new System.Drawing.Size(79, 21);
            this.reksukunimiLB.TabIndex = 10;
            this.reksukunimiLB.Text = "Sukunimi:";
            // 
            // rekpuhelinLB
            // 
            this.rekpuhelinLB.AutoSize = true;
            this.rekpuhelinLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rekpuhelinLB.Location = new System.Drawing.Point(508, 253);
            this.rekpuhelinLB.Name = "rekpuhelinLB";
            this.rekpuhelinLB.Size = new System.Drawing.Size(65, 21);
            this.rekpuhelinLB.TabIndex = 11;
            this.rekpuhelinLB.Text = "Puhelin:";
            // 
            // rekpostiLB
            // 
            this.rekpostiLB.AutoSize = true;
            this.rekpostiLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rekpostiLB.Location = new System.Drawing.Point(472, 295);
            this.rekpostiLB.Name = "rekpostiLB";
            this.rekpostiLB.Size = new System.Drawing.Size(101, 21);
            this.rekpostiLB.TabIndex = 12;
            this.rekpostiLB.Text = "Postinumero:";
            // 
            // icaoLB
            // 
            this.icaoLB.AutoSize = true;
            this.icaoLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.icaoLB.Location = new System.Drawing.Point(524, 178);
            this.icaoLB.Name = "icaoLB";
            this.icaoLB.Size = new System.Drawing.Size(49, 21);
            this.icaoLB.TabIndex = 13;
            this.icaoLB.Text = "ICAO:";
            // 
            // rektoimiLB
            // 
            this.rektoimiLB.AutoSize = true;
            this.rektoimiLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rektoimiLB.Location = new System.Drawing.Point(107, 345);
            this.rektoimiLB.Name = "rektoimiLB";
            this.rektoimiLB.Size = new System.Drawing.Size(127, 21);
            this.rektoimiLB.TabIndex = 14;
            this.rektoimiLB.Text = "Postitoimipaikka:";
            // 
            // reklentoTB
            // 
            this.reklentoTB.Location = new System.Drawing.Point(240, 174);
            this.reklentoTB.Name = "reklentoTB";
            this.reklentoTB.Size = new System.Drawing.Size(173, 23);
            this.reklentoTB.TabIndex = 15;
            // 
            // reketuTB
            // 
            this.reketuTB.Location = new System.Drawing.Point(240, 217);
            this.reketuTB.Name = "reketuTB";
            this.reketuTB.Size = new System.Drawing.Size(173, 23);
            this.reketuTB.TabIndex = 16;
            // 
            // rekemailTB
            // 
            this.rekemailTB.Location = new System.Drawing.Point(240, 257);
            this.rekemailTB.Name = "rekemailTB";
            this.rekemailTB.Size = new System.Drawing.Size(173, 23);
            this.rekemailTB.TabIndex = 17;
            // 
            // rekosoiteTB
            // 
            this.rekosoiteTB.Location = new System.Drawing.Point(240, 301);
            this.rekosoiteTB.Name = "rekosoiteTB";
            this.rekosoiteTB.Size = new System.Drawing.Size(173, 23);
            this.rekosoiteTB.TabIndex = 18;
            // 
            // rektoimiTB
            // 
            this.rektoimiTB.Location = new System.Drawing.Point(240, 343);
            this.rektoimiTB.Name = "rektoimiTB";
            this.rektoimiTB.Size = new System.Drawing.Size(173, 23);
            this.rektoimiTB.TabIndex = 19;
            // 
            // reksukunimiTB
            // 
            this.reksukunimiTB.Location = new System.Drawing.Point(579, 217);
            this.reksukunimiTB.Name = "reksukunimiTB";
            this.reksukunimiTB.Size = new System.Drawing.Size(173, 23);
            this.reksukunimiTB.TabIndex = 21;
            // 
            // rekpuhelinTB
            // 
            this.rekpuhelinTB.Location = new System.Drawing.Point(579, 255);
            this.rekpuhelinTB.Name = "rekpuhelinTB";
            this.rekpuhelinTB.Size = new System.Drawing.Size(173, 23);
            this.rekpuhelinTB.TabIndex = 22;
            // 
            // rekpostiTB
            // 
            this.rekpostiTB.Location = new System.Drawing.Point(579, 297);
            this.rekpostiTB.Name = "rekpostiTB";
            this.rekpostiTB.Size = new System.Drawing.Size(173, 23);
            this.rekpostiTB.TabIndex = 23;
            // 
            // icaoTB
            // 
            this.icaoTB.Location = new System.Drawing.Point(579, 176);
            this.icaoTB.Name = "icaoTB";
            this.icaoTB.Size = new System.Drawing.Size(173, 23);
            this.icaoTB.TabIndex = 24;
            // 
            // rekisteroidyBT
            // 
            this.rekisteroidyBT.Location = new System.Drawing.Point(405, 481);
            this.rekisteroidyBT.Name = "rekisteroidyBT";
            this.rekisteroidyBT.Size = new System.Drawing.Size(149, 32);
            this.rekisteroidyBT.TabIndex = 25;
            this.rekisteroidyBT.Text = "Rekisteröidy!";
            this.rekisteroidyBT.UseVisualStyleBackColor = true;
            this.rekisteroidyBT.Click += new System.EventHandler(this.rekisteroidyBT_Click);
            // 
            // rekSalis1LB
            // 
            this.rekSalis1LB.AutoSize = true;
            this.rekSalis1LB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rekSalis1LB.Location = new System.Drawing.Point(160, 394);
            this.rekSalis1LB.Name = "rekSalis1LB";
            this.rekSalis1LB.Size = new System.Drawing.Size(74, 21);
            this.rekSalis1LB.TabIndex = 26;
            this.rekSalis1LB.Text = "Salasana:";
            // 
            // rekSalis2LB
            // 
            this.rekSalis2LB.AutoSize = true;
            this.rekSalis2LB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rekSalis2LB.Location = new System.Drawing.Point(439, 394);
            this.rekSalis2LB.Name = "rekSalis2LB";
            this.rekSalis2LB.Size = new System.Drawing.Size(134, 21);
            this.rekSalis2LB.TabIndex = 27;
            this.rekSalis2LB.Text = "Vahvista salasana:";
            // 
            // rekSalis1TB
            // 
            this.rekSalis1TB.Location = new System.Drawing.Point(240, 392);
            this.rekSalis1TB.Name = "rekSalis1TB";
            this.rekSalis1TB.Size = new System.Drawing.Size(173, 23);
            this.rekSalis1TB.TabIndex = 28;
            // 
            // rekSalis2TB
            // 
            this.rekSalis2TB.Location = new System.Drawing.Point(579, 392);
            this.rekSalis2TB.Name = "rekSalis2TB";
            this.rekSalis2TB.Size = new System.Drawing.Size(173, 23);
            this.rekSalis2TB.TabIndex = 29;
            // 
            // Rekisteroidy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 535);
            this.Controls.Add(this.rekSalis2TB);
            this.Controls.Add(this.rekSalis1TB);
            this.Controls.Add(this.rekSalis2LB);
            this.Controls.Add(this.rekSalis1LB);
            this.Controls.Add(this.rekisteroidyBT);
            this.Controls.Add(this.icaoTB);
            this.Controls.Add(this.rekpostiTB);
            this.Controls.Add(this.rekpuhelinTB);
            this.Controls.Add(this.reksukunimiTB);
            this.Controls.Add(this.rektoimiTB);
            this.Controls.Add(this.rekosoiteTB);
            this.Controls.Add(this.rekemailTB);
            this.Controls.Add(this.reketuTB);
            this.Controls.Add(this.reklentoTB);
            this.Controls.Add(this.rektoimiLB);
            this.Controls.Add(this.icaoLB);
            this.Controls.Add(this.rekpostiLB);
            this.Controls.Add(this.rekpuhelinLB);
            this.Controls.Add(this.reksukunimiLB);
            this.Controls.Add(this.rekosoiteLB);
            this.Controls.Add(this.rekemailLB);
            this.Controls.Add(this.reketunimiLB);
            this.Controls.Add(this.reklentoLB);
            this.Controls.Add(this.OtsikkoLB);
            this.Controls.Add(this.rekMS);
            this.Name = "Rekisteroidy";
            this.Text = "Rekisteroidy";
            this.Load += new System.EventHandler(this.Rekisteroidy_Load);
            this.rekMS.ResumeLayout(false);
            this.rekMS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip rekMS;
        private ToolStripMenuItem reketusivuMS;
        private ToolStripMenuItem rekkirjauduMS;
        private ToolStripMenuItem RekisteroidyTMSI;
        private Label OtsikkoLB;
        private Label reklentoLB;
        private Label reketunimiLB;
        private Label rekemailLB;
        private Label rekosoiteLB;
        private Label reksukunimiLB;
        private Label rekpuhelinLB;
        private Label rekpostiLB;
        private Label icaoLB;
        private Label rektoimiLB;
        private TextBox reklentoTB;
        private TextBox reketuTB;
        private TextBox rekemailTB;
        private TextBox rekosoiteTB;
        private TextBox rektoimiTB;
        private TextBox reksukunimiTB;
        private TextBox rekpuhelinTB;
        private TextBox rekpostiTB;
        private TextBox icaoTB;
        private Button rekisteroidyBT;
        private Label rekSalis1LB;
        private Label rekSalis2LB;
        private TextBox rekSalis1TB;
        private TextBox rekSalis2TB;
    }
}