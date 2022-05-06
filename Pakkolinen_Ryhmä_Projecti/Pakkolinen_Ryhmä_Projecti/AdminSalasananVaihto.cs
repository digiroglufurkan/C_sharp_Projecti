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
/// version 30.4.2022
/// <summary>
/// Sivut olemassa ja niille siirtyminen toimii, muuten kesken. Tietojen hakeminen tietokannasta Datagrid:n toimii.
/// </summary>

namespace Pakkolinen_Ryhmä_Projecti
{
    public partial class AdminSalasananVaihto : Form
    {
        SALASANOJENHALLINTATIETOKANTA tieto = new SALASANOJENHALLINTATIETOKANTA();
        Tiedansyotto salaus =new Tiedansyotto();
        public AdminSalasananVaihto()
        {
            InitializeComponent();
        }

        void formClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();

        }

        private void AdminKotisivutoolStripMenuItem_Click(object sender, EventArgs e)
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

        private void KayttajienHallintatoolStripMenuItem_Click(object sender, EventArgs e)
        {
            KayttajatilienHallinta kaTiHa = new KayttajatilienHallinta();
            kaTiHa.FormClosing += formClosing;
            kaTiHa.Show();
            this.Hide();
        }

        private void MitaUuttaHallintatoolStripMenuItem_Click(object sender, EventArgs e)
        {
            MitaUuttaHallinta miUuHa = new MitaUuttaHallinta();
            miUuHa.FormClosing += formClosing;
            miUuHa.Show();
            this.Hide();
        }

        private void YhteydenottojenHallintatoolStripMenuItem_Click(object sender, EventArgs e)
        {
            YhteydenottojenHallinta yhHa = new YhteydenottojenHallinta();
            yhHa.FormClosing += formClosing;
            yhHa.Show();
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

        private void VaSalasanaBT_Click(object sender, EventArgs e)
        {
            string vanhaSalasana, uusiSalasana, uusiUudestaan,tarkistettu;
            try
            {
                vanhaSalasana = VaSalasanaTB.Text;
                uusiSalasana = UuSalasanaTB.Text;
                uusiUudestaan = UusiSalasanaUdTB.Text;
                tarkistettu = salaus.Decrypt(vanhaSalasana);
                if (vanhaSalasana.Equals("") || uusiSalasana.Equals("") || uusiUudestaan.Equals(""))
                {
                    MessageBox.Show($"Tarkista tekstikentät.");
                }
                else if (uusiSalasana != uusiUudestaan)
                {
                    MessageBox.Show($"Uudet salasanat eivät täsmää.");
                }
                /*else if (tarkistettu != vanhaSalasana)
                {
                    MessageBox.Show($"Vanhaa salasanaa ei löydy tieokannasta annettuväärä salasana");
                }*/
                else
                {
                    bool vastaus = tieto.vaihdaSalasana(vanhaSalasana, uusiSalasana);
                    if (vastaus == true)
                    {
                        MessageBox.Show($"Salasanan vaihto onnistui.");
                    }
                    else
                    {
                        MessageBox.Show($"Salasanan vaihto ei onnistunut.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AdminSalasananVaihto_Load(object sender, EventArgs e)
        {

        }
    }
}
