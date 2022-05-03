namespace Pakkolinen_Ryhmä_Projecti
{
    partial class Rekistreidy
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.etusivuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kirjaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.galleriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otaYhteyttäToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OtsitkoLB = new System.Windows.Forms.Label();
            this.ReEtunimiLB = new System.Windows.Forms.Label();
            this.ReSukunimiLB = new System.Windows.Forms.Label();
            this.ResahkopostiLB = new System.Windows.Forms.Label();
            this.ReEtunimiTB = new System.Windows.Forms.TextBox();
            this.ReSukunimiTB = new System.Windows.Forms.TextBox();
            this.ResahkopostiTB = new System.Windows.Forms.TextBox();
            this.RePuhelinLB = new System.Windows.Forms.Label();
            this.RePuhelinTB = new System.Windows.Forms.TextBox();
            this.ReOsaiteLB = new System.Windows.Forms.Label();
            this.ReOsaiteTB = new System.Windows.Forms.TextBox();
            this.RePostiNumeroLB = new System.Windows.Forms.Label();
            this.RePostinumeroTB = new System.Windows.Forms.TextBox();
            this.RePostiPaikkaLB = new System.Windows.Forms.Label();
            this.RePostipaikkaTB = new System.Windows.Forms.TextBox();
            this.ReTitteliTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ReprofiliKuvaLB = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.RetiedostoBT = new System.Windows.Forms.Button();
            this.RekysteroidyBT = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.etusivuToolStripMenuItem,
            this.kirjaiToolStripMenuItem,
            this.galleriaToolStripMenuItem,
            this.otaYhteyttäToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(215, 139);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(482, 39);
            this.menuStrip.TabIndex = 1;
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
            this.OtsitkoLB.Location = new System.Drawing.Point(396, 53);
            this.OtsitkoLB.Name = "OtsitkoLB";
            this.OtsitkoLB.Size = new System.Drawing.Size(176, 62);
            this.OtsitkoLB.TabIndex = 2;
            this.OtsitkoLB.Text = "Otsitko";
            // 
            // ReEtunimiLB
            // 
            this.ReEtunimiLB.AutoSize = true;
            this.ReEtunimiLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReEtunimiLB.Location = new System.Drawing.Point(53, 233);
            this.ReEtunimiLB.Name = "ReEtunimiLB";
            this.ReEtunimiLB.Size = new System.Drawing.Size(78, 28);
            this.ReEtunimiLB.TabIndex = 3;
            this.ReEtunimiLB.Text = "Etunimi";
            // 
            // ReSukunimiLB
            // 
            this.ReSukunimiLB.AutoSize = true;
            this.ReSukunimiLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReSukunimiLB.Location = new System.Drawing.Point(484, 230);
            this.ReSukunimiLB.Name = "ReSukunimiLB";
            this.ReSukunimiLB.Size = new System.Drawing.Size(93, 28);
            this.ReSukunimiLB.TabIndex = 4;
            this.ReSukunimiLB.Text = "Sukunimi";
            // 
            // ResahkopostiLB
            // 
            this.ResahkopostiLB.AutoSize = true;
            this.ResahkopostiLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResahkopostiLB.Location = new System.Drawing.Point(52, 290);
            this.ResahkopostiLB.Name = "ResahkopostiLB";
            this.ResahkopostiLB.Size = new System.Drawing.Size(110, 28);
            this.ResahkopostiLB.TabIndex = 5;
            this.ResahkopostiLB.Text = "Sahköposti";
            // 
            // ReEtunimiTB
            // 
            this.ReEtunimiTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReEtunimiTB.Location = new System.Drawing.Point(174, 230);
            this.ReEtunimiTB.Name = "ReEtunimiTB";
            this.ReEtunimiTB.Size = new System.Drawing.Size(224, 34);
            this.ReEtunimiTB.TabIndex = 6;
            // 
            // ReSukunimiTB
            // 
            this.ReSukunimiTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReSukunimiTB.Location = new System.Drawing.Point(608, 230);
            this.ReSukunimiTB.Name = "ReSukunimiTB";
            this.ReSukunimiTB.Size = new System.Drawing.Size(230, 34);
            this.ReSukunimiTB.TabIndex = 7;
            // 
            // ResahkopostiTB
            // 
            this.ResahkopostiTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResahkopostiTB.Location = new System.Drawing.Point(174, 290);
            this.ResahkopostiTB.Name = "ResahkopostiTB";
            this.ResahkopostiTB.Size = new System.Drawing.Size(304, 34);
            this.ResahkopostiTB.TabIndex = 8;
            // 
            // RePuhelinLB
            // 
            this.RePuhelinLB.AutoSize = true;
            this.RePuhelinLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RePuhelinLB.Location = new System.Drawing.Point(484, 290);
            this.RePuhelinLB.Name = "RePuhelinLB";
            this.RePuhelinLB.Size = new System.Drawing.Size(76, 28);
            this.RePuhelinLB.TabIndex = 9;
            this.RePuhelinLB.Text = "Puhelin";
            // 
            // RePuhelinTB
            // 
            this.RePuhelinTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RePuhelinTB.Location = new System.Drawing.Point(608, 290);
            this.RePuhelinTB.Name = "RePuhelinTB";
            this.RePuhelinTB.Size = new System.Drawing.Size(230, 34);
            this.RePuhelinTB.TabIndex = 10;
            // 
            // ReOsaiteLB
            // 
            this.ReOsaiteLB.AutoSize = true;
            this.ReOsaiteLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReOsaiteLB.Location = new System.Drawing.Point(53, 354);
            this.ReOsaiteLB.Name = "ReOsaiteLB";
            this.ReOsaiteLB.Size = new System.Drawing.Size(67, 28);
            this.ReOsaiteLB.TabIndex = 11;
            this.ReOsaiteLB.Text = "Osaite";
            // 
            // ReOsaiteTB
            // 
            this.ReOsaiteTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReOsaiteTB.Location = new System.Drawing.Point(174, 353);
            this.ReOsaiteTB.Name = "ReOsaiteTB";
            this.ReOsaiteTB.Size = new System.Drawing.Size(422, 34);
            this.ReOsaiteTB.TabIndex = 12;
            // 
            // RePostiNumeroLB
            // 
            this.RePostiNumeroLB.AutoSize = true;
            this.RePostiNumeroLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RePostiNumeroLB.Location = new System.Drawing.Point(602, 354);
            this.RePostiNumeroLB.Name = "RePostiNumeroLB";
            this.RePostiNumeroLB.Size = new System.Drawing.Size(131, 28);
            this.RePostiNumeroLB.TabIndex = 13;
            this.RePostiNumeroLB.Text = "Posti Numero";
            // 
            // RePostinumeroTB
            // 
            this.RePostinumeroTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RePostinumeroTB.Location = new System.Drawing.Point(733, 353);
            this.RePostinumeroTB.Name = "RePostinumeroTB";
            this.RePostinumeroTB.Size = new System.Drawing.Size(105, 34);
            this.RePostinumeroTB.TabIndex = 14;
            // 
            // RePostiPaikkaLB
            // 
            this.RePostiPaikkaLB.AutoSize = true;
            this.RePostiPaikkaLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RePostiPaikkaLB.Location = new System.Drawing.Point(52, 420);
            this.RePostiPaikkaLB.Name = "RePostiPaikkaLB";
            this.RePostiPaikkaLB.Size = new System.Drawing.Size(157, 28);
            this.RePostiPaikkaLB.TabIndex = 15;
            this.RePostiPaikkaLB.Text = "Postitoimipaikka";
            // 
            // RePostipaikkaTB
            // 
            this.RePostipaikkaTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RePostipaikkaTB.Location = new System.Drawing.Point(243, 417);
            this.RePostipaikkaTB.Name = "RePostipaikkaTB";
            this.RePostipaikkaTB.Size = new System.Drawing.Size(138, 34);
            this.RePostipaikkaTB.TabIndex = 16;
            // 
            // ReTitteliTB
            // 
            this.ReTitteliTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReTitteliTB.Location = new System.Drawing.Point(532, 420);
            this.ReTitteliTB.Name = "ReTitteliTB";
            this.ReTitteliTB.Size = new System.Drawing.Size(138, 34);
            this.ReTitteliTB.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(432, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 28);
            this.label1.TabIndex = 18;
            this.label1.Text = "Titteli";
            // 
            // ReprofiliKuvaLB
            // 
            this.ReprofiliKuvaLB.AutoSize = true;
            this.ReprofiliKuvaLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReprofiliKuvaLB.Location = new System.Drawing.Point(53, 495);
            this.ReprofiliKuvaLB.Name = "ReprofiliKuvaLB";
            this.ReprofiliKuvaLB.Size = new System.Drawing.Size(109, 28);
            this.ReprofiliKuvaLB.TabIndex = 19;
            this.ReprofiliKuvaLB.Text = "Profiilikuva";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // RetiedostoBT
            // 
            this.RetiedostoBT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RetiedostoBT.Location = new System.Drawing.Point(168, 493);
            this.RetiedostoBT.Name = "RetiedostoBT";
            this.RetiedostoBT.Size = new System.Drawing.Size(111, 33);
            this.RetiedostoBT.TabIndex = 20;
            this.RetiedostoBT.Text = "Tiedosto";
            this.RetiedostoBT.UseVisualStyleBackColor = true;
            // 
            // RekysteroidyBT
            // 
            this.RekysteroidyBT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RekysteroidyBT.Location = new System.Drawing.Point(384, 547);
            this.RekysteroidyBT.Name = "RekysteroidyBT";
            this.RekysteroidyBT.Size = new System.Drawing.Size(150, 46);
            this.RekysteroidyBT.TabIndex = 21;
            this.RekysteroidyBT.Text = "Rekystroidy";
            this.RekysteroidyBT.UseVisualStyleBackColor = true;
            this.RekysteroidyBT.Click += new System.EventHandler(this.RekysteroidyBT_Click);
            // 
            // Rekistreidy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 644);
            this.Controls.Add(this.RekysteroidyBT);
            this.Controls.Add(this.RetiedostoBT);
            this.Controls.Add(this.ReprofiliKuvaLB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReTitteliTB);
            this.Controls.Add(this.RePostipaikkaTB);
            this.Controls.Add(this.RePostiPaikkaLB);
            this.Controls.Add(this.RePostinumeroTB);
            this.Controls.Add(this.RePostiNumeroLB);
            this.Controls.Add(this.ReOsaiteTB);
            this.Controls.Add(this.ReOsaiteLB);
            this.Controls.Add(this.RePuhelinTB);
            this.Controls.Add(this.RePuhelinLB);
            this.Controls.Add(this.ResahkopostiTB);
            this.Controls.Add(this.ReSukunimiTB);
            this.Controls.Add(this.ReEtunimiTB);
            this.Controls.Add(this.ResahkopostiLB);
            this.Controls.Add(this.ReSukunimiLB);
            this.Controls.Add(this.ReEtunimiLB);
            this.Controls.Add(this.OtsitkoLB);
            this.Controls.Add(this.menuStrip);
            this.Name = "Rekistreidy";
            this.Text = "Rekisteroidy";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem etusivuToolStripMenuItem;
        private ToolStripMenuItem kirjaiToolStripMenuItem;
        private ToolStripMenuItem galleriaToolStripMenuItem;
        private ToolStripMenuItem otaYhteyttäToolStripMenuItem;
        private Label OtsitkoLB;
        private Label ReEtunimiLB;
        private Label ReSukunimiLB;
        private Label ResahkopostiLB;
        private TextBox ReEtunimiTB;
        private TextBox ReSukunimiTB;
        private TextBox ResahkopostiTB;
        private Label RePuhelinLB;
        private TextBox RePuhelinTB;
        private Label ReOsaiteLB;
        private TextBox ReOsaiteTB;
        private Label RePostiNumeroLB;
        private TextBox RePostinumeroTB;
        private Label RePostiPaikkaLB;
        private TextBox RePostipaikkaTB;
        private TextBox ReTitteliTB;
        private Label label1;
        private Label ReprofiliKuvaLB;
        private OpenFileDialog openFileDialog1;
        private Button RetiedostoBT;
        private Button RekysteroidyBT;
    }
}