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
/// version 19.5.2022
/// <summary>
/// Vaihtaa halutun käyttäjän salasanan
/// </summary>
namespace Catering_Projectin
{
    public partial class AdminSalasananHallinta : Form
    {
        ADMINSALASANAT adSa = new ADMINSALASANAT();
        public AdminSalasananHallinta()
        {
            InitializeComponent();
        }

        void formClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();

        }
        private void KotisivuTSMI_Click(object sender, EventArgs e)
        {
            AdminKotisivu adKo = new AdminKotisivu();
            adKo.FormClosing += formClosing;
            adKo.Show();
            this.Hide();
        }

        private void SaatavuudetTSMI_Click(object sender, EventArgs e)
        {
            AdminSaatavuudet adSa = new AdminSaatavuudet();
            adSa.FormClosing += formClosing;
            adSa.Show();
            this.Hide();
        }

        private void TyotilanneTSMI_Click(object sender, EventArgs e)
        {
            AdminTyotilanne adTy = new AdminTyotilanne();
            adTy.FormClosing += formClosing;
            adTy.Show();
            this.Hide();
        }
        private void KayttajaTSMI_Click(object sender, EventArgs e)
        {
            AdminKayttajaHallinta adKaHa = new AdminKayttajaHallinta();
            adKaHa.FormClosing += formClosing;
            adKaHa.Show();
            this.Hide();
        }
        private void SalasananHallintaTSMI_Click(object sender, EventArgs e)
        {
            AdminSalasananHallinta adSaHa = new AdminSalasananHallinta();
            adSaHa.FormClosing += formClosing;
            adSaHa.Show();
            this.Hide();
        }

        private void ProfiilinMuokkausTSMI_Click(object sender, EventArgs e)
        {
            AdminMuokkaaProfiilia adMuPr = new AdminMuokkaaProfiilia();
            adMuPr.FormClosing += formClosing;
            adMuPr.Show();
            this.Hide();
        }

        private void SalasananVaihtoTSMI_Click(object sender, EventArgs e)
        {
            AdminSalasananVaihto adSaVa = new AdminSalasananVaihto();
            adSaVa.FormClosing += formClosing;
            adSaVa.Show();
            this.Hide();
        }

        private void KirjauduUlosTSMI_Click(object sender, EventArgs e)
        {
            Etusivu etu = new Etusivu();
            etu.FormClosing += formClosing;
            etu.Show();
            this.Hide();
        }

        private void VaihdaBT_Click(object sender, EventArgs e)
        {
            string ktunnus = "",uusiSalasana = "", uusiUudestaan = "";
            try
            {
                ktunnus = KaytTunTB.Text.ToString(); // luetaan käyttäjätunnus muuttujaan
                uusiSalasana = UusiSaSanaTB.Text.ToString(); // luetaan uusi salasana muuttujaan
                uusiUudestaan = UusiUdTB.Text.ToString(); // uuden salasanan toisto muuttujaan
                if (ktunnus.Equals("") || uusiSalasana.Equals("") || uusiUudestaan.Equals("")) // tarkistetaan, että kentissä on tekstiä
                {
                    MessageBox.Show($"Tarkista tekstikentät");
                }
                else if (uusiSalasana != uusiUudestaan) // tarkistetaan, että uusi salasana ja toisto täsmäävät
                {
                    MessageBox.Show($"Salasanat eivät täsmää.");
                }
                else
                {   // kutsutaan metodia ADMINSALASANAT class:ssa, joka päivittää salasanan.
                    bool paivitys = adSa.paivitaKaytSalasana(ktunnus, uusiSalasana);
                    if (paivitys == true) // mikäli päivitys onnistui
                    {
                        MessageBox.Show($"Salasana päivitetty");
                        KaytTunTB.Text = "";
                        UusiSaSanaTB.Text = "";
                        UusiUdTB.Text = "";
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
    }
}
