using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pakkolinen_Ryhmä_Projecti
{
    public partial class KirjautunutJaaTiedosto : Form
    {
        public KirjautunutJaaTiedosto()
        {
            InitializeComponent();
        }

        void f1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void ksJaaTiedostoKotisivuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KirjautunutKotisivu kirKotisivu = new KirjautunutKotisivu();
            kirKotisivu.FormClosing += f1_FormClosing;
            kirKotisivu.Show();
            this.Hide();
        }

        private void ksJaaTiedostoLatauksetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KirjautunutLataukset kirLataukset = new KirjautunutLataukset();
            kirLataukset.FormClosing += f1_FormClosing;
            kirLataukset.Show();
            this.Hide();
        }

        private void ksJaaTiedostoKeskustelupalstaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KeskusteluPalsta kesPal = new KeskusteluPalsta();
            kesPal.FormClosing += f1_FormClosing;
            kesPal.Show();
            this.Hide();
        }

        private void ksJaaTiedostoPalauteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KirjautunutPalaute kirPal = new KirjautunutPalaute();
            kirPal.FormClosing += f1_FormClosing;
            kirPal.Show();
            this.Hide();
        }

        private void muokkaaProfiiliaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KirjautunutMuokkaaProfiilia muoPro = new KirjautunutMuokkaaProfiilia();
            muoPro.FormClosing += f1_FormClosing;
            muoPro.Show();
            this.Hide();
        }

        private void ksVaihdaSalasanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalasananVaihto salVaihto = new SalasananVaihto();
            salVaihto.FormClosing += f1_FormClosing;
            salVaihto.Show();
            this.Hide();
        }

        private void ksKirjauduUlosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Etusivu etuSiv = new Etusivu();
            etuSiv.FormClosing += f1_FormClosing;
            etuSiv.Show();
            this.Hide();
        }
    }
}
