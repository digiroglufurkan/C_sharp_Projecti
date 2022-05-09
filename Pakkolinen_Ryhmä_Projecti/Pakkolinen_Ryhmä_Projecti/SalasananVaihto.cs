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
        SalasananVaihtoClass salis = new SalasananVaihtoClass();
        //Tiedansyotto salaus = new Tiedansyotto();
        string tun;
        public SalasananVaihto()
        {
            InitializeComponent();
            tun = Kirjaudu.ktun;
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
            string uusSalisYks, uusSalisKaks;
            try
            {
                uusSalisYks = uusisalisTB1.Text;
                uusSalisKaks = uusisalisTB2.Text;
                if (uusSalisYks.Equals("") || uusSalisKaks.Equals(""))
                {
                    MessageBox.Show("Tarkista kentät!");
                }
                else if (uusSalisYks != uusSalisKaks)
                {
                    MessageBox.Show("Uudet salasanat eivät täsmää!");
                }
                else
                {
                    bool vaihto = salis.vaihdaSalis(tun, uusSalisYks);
                    if (vaihto == true)
                    {
                        MessageBox.Show("Salasanan vaihto onnistui! :)");
                        uusisalisTB1.Text = "";
                        uusisalisTB2.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Salasanaa ei vaihdettu!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SalasananVaihto_Load(object sender, EventArgs e)
        {

        }

    }
}
