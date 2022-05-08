using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace Pakkolinen_Ryhmä_Projecti
{
    public partial class KirjautunutMuokkaaProfiilia : Form
    {
        Yhdista yhteys = new Yhdista();

        public KirjautunutMuokkaaProfiilia()
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

        private void KirjautunutMuokkaaProfiilia_Enter(object sender, EventArgs e)
        {

        }

        private void muokkaaProfiiliaBT_Click(object sender, EventArgs e)
        {

        }
    }
}
