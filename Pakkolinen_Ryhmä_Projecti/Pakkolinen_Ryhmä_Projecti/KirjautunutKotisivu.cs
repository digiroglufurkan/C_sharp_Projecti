using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace Pakkolinen_Ryhmä_Projecti
{
    public partial class KirjautunutKotisivu : Form
    {
        string tun;
        KotisivuClass kot = new KotisivuClass();
        public KirjautunutKotisivu()
        {
            InitializeComponent();
            tun = Kirjaudu.ktun;
        }

        void f1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        //private void kotisivuLatauksetToolStripMenuItem_Click(object sender, EventArgs e)
      

        private void kotisivuLatauksetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KirjautunutLataukset kirLat = new KirjautunutLataukset();
            kirLat.FormClosing += f1_FormClosing;
            kirLat.Show();
            this.Hide();
        }

        private void ksKotisivuJaaTiedostoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KirjautunutJaaTiedosto kirJaa = new KirjautunutJaaTiedosto();
            kirJaa.FormClosing += f1_FormClosing;
            kirJaa.Show();
            this.Hide();
        }

        private void ksKotisivuKeskustelupalstaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KeskusteluPalsta kesPal = new KeskusteluPalsta();
            kesPal.FormClosing += f1_FormClosing;
            kesPal.Show();
            this.Hide();
        }

        private void ksKotisivuPalauteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KirjautunutPalaute kirPal = new KirjautunutPalaute();
            kirPal.FormClosing += f1_FormClosing;
            kirPal.Show();
            this.Hide();
        }

        private void ksKirjauduUlosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            Etusivu etuSiv = new Etusivu();
            etuSiv.Show();
            etuSiv.FormClosing += f1_FormClosing;
            this.Hide();
            
        }

        private void ksMuokkaaProfiiliaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KirjautunutMuokkaaProfiilia muoPro = new KirjautunutMuokkaaProfiilia();
            muoPro.Show();
            muoPro.FormClosing += f1_FormClosing;
            this.Hide();
        }

        private void ksVaihdaSalasanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalasananVaihto salVai = new SalasananVaihto();
            salVai.Show();
            salVai.FormClosing += f1_FormClosing;
            this.Hide();
        }

        private void KirjautunutKotisivu_Load(object sender, EventArgs e)
        {
            ksKotisivuDG.DataSource = kot.haeUudet();
            ksKotisivuDG.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void ksKotisivuDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
