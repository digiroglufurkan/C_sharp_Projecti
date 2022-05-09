using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pakkolinen_Ryhmä_Projecti
{
    public partial class KeskusteluPalsta : Form
    {

        string tun;
        KeskusteluPalstaClass pals  = new KeskusteluPalstaClass();
        Yhdista yhteys = new Yhdista();
        public KeskusteluPalsta()
        {
            InitializeComponent();
            tun = Kirjaudu.ktun; 
        }

        private void populate(String name, String kommentti)
        {
            kommenttiDG.Rows.Add(name, kommentti);
        }

        void f1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void ksKeskusteluKotisivuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KirjautunutKotisivu kirKotisivu = new KirjautunutKotisivu();
            kirKotisivu.FormClosing += f1_FormClosing;
            kirKotisivu.Show();
            this.Hide();
        }

        private void ksKotisivuLatauksetToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void ksKotisivuPalauteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KirjautunutPalaute kirPal = new KirjautunutPalaute();
            kirPal.FormClosing += f1_FormClosing;
            kirPal.Show();
            this.Hide();
        }

        private void ksMuokkaaProfiiliaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KirjautunutMuokkaaProfiilia kirPro = new KirjautunutMuokkaaProfiilia();
            kirPro.FormClosing += f1_FormClosing;
            kirPro.Show();
            this.Hide();
        }

        private void ksVaihdaSalasanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalasananVaihto salVai = new SalasananVaihto();
            salVai.FormClosing += f1_FormClosing;
            salVai.Show();
            this.Hide();
        }

        private void ksKirjauduUlosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Etusivu etuSiv = new Etusivu();
            etuSiv.FormClosing += f1_FormClosing;
            etuSiv.Show();
            this.Hide();
        }

        private void kommenttiBT_Click(object sender, EventArgs e)
        {
            try
            {
                string kommentoi = kommenttiBT.Text.ToString();
                if (kommentoi.Equals(""))
                {
                    MessageBox.Show("Kirjoita kommentti!!");
                }
                else
                {
                    bool palsta = pals.palstaJuttu(kommentoi, tun);
                    if (palsta == true)
                    {
                        MessageBox.Show("Kommentti julkaistu! :)");
                        kommenttiBT.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Kommenttia ei julkaistu! :(");
                    }
                }
            }
            catch (Exception ex) // virheen poiminta ja näyttö
            {
                MessageBox.Show($"{ex.Message} virhe1");
            }
        }
    }
}
