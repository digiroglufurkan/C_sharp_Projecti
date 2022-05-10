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
using System.Text.RegularExpressions;

namespace Pakkolinen_Ryhmä_Projecti
{
    public partial class KirjautunutJaaTiedosto : Form
    {
        string tun;
        string fileType;
        TiedostonJako jako = new TiedostonJako();
        Yhdista yhteys = new Yhdista();
        public KirjautunutJaaTiedosto()
        {
            InitializeComponent();
            tun = Kirjaudu.ktun;
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

        private void jaaSelaaBT_Click(object sender, EventArgs e)
        {
            try
            {
                string path = "";
                ksJaaTiedostoFD.InitialDirectory = "C:";
                ksJaaTiedostoFD.Filter = "All files(*.*) | *.*| All files(*.*) | *.*";
                DialogResult result = ksJaaTiedostoFD.ShowDialog();
                if (result == DialogResult.OK)
                {
                    ksJaaTiedostoFD.InitialDirectory = "C:";
                    string fileName = System.IO.Path.GetFileName(ksJaaTiedostoFD.FileName);
                    string fdname = ksJaaTiedostoFD.FileName;
                    valitseTiedostoTB.Text = fdname;
                    string pattern = @"(?<=\.)[^.]+$";
                    Regex rg = new Regex(pattern);
                    MatchCollection co = rg.Matches(fdname);
                    fileType = co[0].Value;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void jaaLataaBT_Click(object sender, EventArgs e)
        {
            try
            {   // Luetaan polku label:sta 
                string path = valitseTiedostoTB.Text.ToString();
                // Tietokantaan tuleva tiedostonimi
                string filename = jaaAiheTB.Text.ToString();
                // Katsotaan, että muuttujissa on tietoa
                string kuvaus = jaaKuvausTB.Text.ToString();
                if (path.Equals("") || filename.Equals("") || fileType.Equals("") || kuvaus.Equals(""))
                {
                    MessageBox.Show($"Et ole valinnut tiedostoa.");
                }
                else
                {
                    /* Kutsutaan ADMINTIEDOSTOJENHALLINTA class:ssa olevaa metodia
                     * läheteään polku, nimi ja tietotyyppi*/
                    bool lisays = jako.jaaTiedosto(path, filename, kuvaus, fileType, tun);
                    if (lisays == true) // mikäli lisäys on onnistunut
                    {
                        MessageBox.Show($"Tiedosto lisätty! :)");
                        jaaAiheTB.Text = "";
                        valitseTiedostoTB.Text = "";
                        jaaKuvausTB.Text = "";
                    }
                    else
                    {   // virhe viesti
                        MessageBox.Show($"Tiedoston lisäys ei onnistunut! :(");
                    }

                }
            }
            catch (Exception ex) // virheen poiminta ja näyttö
            {
                MessageBox.Show($"{ex.Message} virhe1");
            }
        }

        private bool vaadittuTextBox(TextBox a, string b, string c = "")
        {
            if (a.Text == c)
            {
                MessageBox.Show(b);
                return true;
            }
            return false;
        }
    }
}
