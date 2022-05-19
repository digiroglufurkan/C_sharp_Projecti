using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// author@ Antti Kuusisto
/// version 9.5.2022
/// <summary>
/// Toimii. Admin voi vaihtaa tietokannassa olevan salasanan käyttäjälle syöttämällä tunnuksen ja
/// uuden salasanan. Ylimääräiset visuaaliset elementit muutettu visible false.
/// Siivottu
/// </summary>

namespace Pakkolinen_Ryhmä_Projecti
{
    public partial class SalasanojenHallinta : Form
    {
        SALASANOJENHALLINTATIETOKANTA tieto = new SALASANOJENHALLINTATIETOKANTA();
        public SalasanojenHallinta()
        {
            InitializeComponent();
        }
        void formClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();

        }

        private void KotisivutoolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminKotisivu adKo = new AdminKotisivu();
            adKo.FormClosing += formClosing;
            adKo.Show();
            this.Hide();
        }

        private void PalautteenHallintatoolStripMenuItem_Click(object sender, EventArgs e)
        {
            PalautteenHallinta paHa = new PalautteenHallinta();
            paHa.FormClosing += formClosing;
            paHa.Show();
            this.Hide();
        }

        private void LatauksienHallintatoolStripMenuItem_Click(object sender, EventArgs e)
        {
            LatauksienHallinta laHa = new LatauksienHallinta();
            laHa.FormClosing += formClosing;
            laHa.Show();
            this.Hide();
        }

        private void KayttajatilienHallintatoolStripMenuItem_Click(object sender, EventArgs e)
        {
            KayttajatilienHallinta kaTiHa = new KayttajatilienHallinta();
            kaTiHa.FormClosing += formClosing;
            kaTiHa.Show();
            this.Hide();
        }

        private void YhteydenottojenHallintatoolStripMenuItem_Click(object sender, EventArgs e)
        {
            YhteydenottojenHallinta yhHa = new YhteydenottojenHallinta();
            yhHa.FormClosing += formClosing;
            yhHa.Show();
            this.Hide();
        }

        private void MitaUuttaHallintatoolStripMenuItem_Click(object sender, EventArgs e)
        {
            MitaUuttaHallinta miUuHa = new MitaUuttaHallinta();
            miUuHa.FormClosing += formClosing;
            miUuHa.Show();
            this.Hide();
        }

        private void TiedostonJakotoolStripMenuItem_Click(object sender, EventArgs e)
        {
            TiedostonJakoAdmin tiJaAd = new TiedostonJakoAdmin();
            tiJaAd.FormClosing += formClosing;
            tiJaAd.Show();
            this.Hide();
        }

        private void SalasanojenHallintaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalasanojenHallinta saHa = new SalasanojenHallinta();
            saHa.FormClosing += formClosing;
            saHa.Show();
            this.Hide();
        }

        private void MuokkaaProfiiliaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminProfiilinMuokkaus adPrMu = new AdminProfiilinMuokkaus();
            adPrMu.FormClosing += formClosing;
            adPrMu.Show();
            this.Hide();
        }

        private void VaihdaSalasanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminSalasananVaihto adSaVa = new AdminSalasananVaihto();
            adSaVa.FormClosing += formClosing;
            adSaVa.Show();
            this.Hide();
        }

        private void KirjauduUlosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Etusivu etusivu = new Etusivu();
            etusivu.FormClosing += formClosing;
            etusivu.Show();
            this.Hide();
        }

        // Ei käytössä oli kokeilu.
        private void HaeSalasanaBT_Click(object sender, EventArgs e)
        {
            
        }

        private void VaihdaBT_Click(object sender, EventArgs e)
        {
            string ktunnus, uusiSalasana, uusiUudestaan;
            try
            {
                ktunnus = KaytTunnusTB.Text.ToString(); // luetaan käyttäjätunnus muuttujaan
                uusiSalasana = UusiSalasanaTB.Text.ToString(); // luetaan uusi salasana muuttujaan
                uusiUudestaan = SalasanaUudelleenTB.Text.ToString(); // uuden salasanan toisto muuttujaan
                if (ktunnus.Equals("") || uusiSalasana.Equals("") || uusiUudestaan.Equals("")) // tarkistetaan, että kentissä on tekstiä
                {
                    MessageBox.Show($"Tarkista tekstikentät");
                }
                else if (uusiSalasana != uusiUudestaan) // tarkistetaan, että uusi salasana ja toisto täsmäävät
                {
                    MessageBox.Show($"Salasanat eivät täsmää.");
                }
                else
                {   // kutsutaan metodia class:ssa, joka päivittää salasanan.
                    bool paivitys = tieto.paivitaSalasana(ktunnus, uusiSalasana);
                    if (paivitys == true) // mikäli päivitys onnistui
                    {
                        MessageBox.Show($"Salasana päivitetty");
                        KaytTunnusTB.Text = "";
                        UusiSalasanaTB.Text = "";
                        SalasanaUudelleenTB.Text = "";
                    }
                    else
                    {
                        MessageBox.Show($"Salasanan päivitys epäonnistui.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void KeskustelupalstaHallintatoolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminKeskusteluPalsta adKeHa = new AdminKeskusteluPalsta();
            adKeHa.FormClosing += formClosing;
            adKeHa.Show();
            this.Hide();
        }

        private void SalasanojenHallinta_Load(object sender, EventArgs e)
        {

        }
    }
    /* KOODIVARASTO
     * string ktunnus;
            try
            {
                ktunnus = KaytTunnusTB.Text.ToString();
                if (ktunnus.Equals(""))
                {
                    MessageBox.Show($"Kirjoita käyttäjätunnus sille tarkoitettuun kenttään.");
                }
                else
                {
                    string salasana = tieto.haeSalasana(ktunnus);
                    NykSalasana.Text = salasana;
                    NykSalasana.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
     */
}
