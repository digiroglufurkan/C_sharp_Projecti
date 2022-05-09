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
    public partial class SalasananVaihto : Form
    {
        public SalasananVaihto()
        {
            InitializeComponent();
        }

        void f1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void ksKotisivuKotisivuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KirjautunutKotisivu kirKotisivu = new KirjautunutKotisivu();
            kirKotisivu.FormClosing += f1_FormClosing;
            kirKotisivu.Show();
            this.Hide();
        }

        private void KotisivuLatauksetToolStripMenuItem_Click(object sender, EventArgs e)
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
            KeskusteluPalsta kesPalsta = new KeskusteluPalsta();
            kesPalsta.FormClosing += f1_FormClosing;
            kesPalsta.Show();
            this.Hide();
        }

        private void ksKotisivuPalauteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KirjautunutPalaute kirPal = new KirjautunutPalaute();
            kirPal.FormClosing += f1_FormClosing;
            kirPal.Show();
            this.Hide();
        }

        private void ksMuokkaaProfiiliaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KirjautunutMuokkaaProfiilia muoProf = new KirjautunutMuokkaaProfiilia();
            muoProf.FormClosing += f1_FormClosing;
            muoProf.Show();
            this.Hide();
        }

        private void ksKirjauduUlosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Etusivu etuSiv = new Etusivu();
            etuSiv.FormClosing += f1_FormClosing;
            etuSiv.Show();
            this.Hide();
        }

        private void salasanavaihtoBT_Click(object sender, EventArgs e)
        {
            if(IsFormValid())
            {

            }
        }

        private void SalasananVaihto_Load(object sender, EventArgs e)
        {

        }

        private bool IsFormValid()
        {
            if(vanhasalisTB.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Lisää vanha salasana.","Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                vanhasalisTB.Focus();
                return false;
            }
            if (uusisalisTB1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Lisää uusi salasana.", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                uusisalisTB1.Focus();
                return false;
            }
            if (uusisaliTB2.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Vahvista uusi salasana.", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                uusisaliTB2.Focus();
                return false;
            }
            if (uusisalisTB1.Text.Trim() != uusisaliTB2.Text.Trim())
            {
                MessageBox.Show("Tarkista uudet salasanat.", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                uusisalisTB1.Focus();
                return false;
            }

            return true;
        }
    }
}
