using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kaikille_pakollinen_projekti
{
    public partial class SivuForm : Form
    {
        public SivuForm()
        {
            InitializeComponent();
        }
        private void SivuForm_Load(object sender, EventArgs e) // Toiminta, kun Form ladataan
        {
            KotisivuPanel.Visible = true; // Tämä on sivuston etusivu. Oma panel ja näkyvissä
            RekisteroidyPanel.Visible = false; // Rekisteröityminen. Oma panel ja pois näkyvistä
            KirjauduPanel.Visible = false; // Kirjautuminen ja pois näkyvistä.
            GalleriaJulkPanel.Visible = false; //Galleria julkinen.
        }

        // Etusivun rekisteröidy linkki
        private void RekisteroidyLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RekisteroidyPanel.Visible = true; // Rekisteröityminen näkyväksi
            KotisivuPanel.Visible = false; // Etusivu piiloon
        }

        // Etusivun kirjaudu linkki
        private void KirjauduLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KirjauduPanel.Visible = true; // Kirjautuminen näkyväksi
            KotisivuPanel.Visible = false; // Etusivu piiloon
        }

        // Etusivun Galleria linkki
        private void GalleriaLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GalleriaJulkPanel.Visible = true; // Julkinen Galleria näkyväksi
            KotisivuPanel.Visible = false; // Etusivu piiloon

        }

        // Rekisteröidy sivun Etusivu linkki
        private void RKotiLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KotisivuPanel.Visible = true; // Etusivu näkyväksi
            RekisteroidyPanel.Visible = false; // Rekisteröityminen piiloon
        }
        // Rekisteröidy-sivun Kirjautuminen-sivu linkki
        private void RKirjauduLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KirjauduPanel.Visible = true; // Kirjautuminen näkyväksi
            RekisteroidyPanel.Visible = false; // Rekisteröityminen piiloon
        }

        // Rekisteröidy-sivun Galleria-sivu linkki
        private void RGalleriaLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        { 
            GalleriaJulkPanel.Visible = true; // Julkinen Galleria näkyväksi
            RekisteroidyPanel.Visible = false; // Rekisteröityminen piiloon
        }
       
        // Kirjautuminen-sivun Etusivu linkki
        private void KEtusivuLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KotisivuPanel.Visible = true; // Etusivu näkyväksi
            KirjauduPanel.Visible = false; // Kirjautuminen piiloon
        }

        // Kirjautuminen-sivun Rekisteröityminen-sivu linkki
        private void KRekisteroidyLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RekisteroidyPanel.Visible = true; // Rekisteröityminen näkyväksi
            KirjauduPanel.Visible = false; // Kirjautuminen piiloon
        }

        // Kirjautuminen-sivun Galleria-sivu linkki
        private void KGalleriaLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GalleriaJulkPanel.Visible = true; // Julkinen Galleria näkyväksi
            KirjauduPanel.Visible = false; // Kirjautuminen piiloon
        }

        // Galleria-sivun Etusivu linkki
        private void GEtusivuLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KotisivuPanel.Visible = true; // Etusivu näkyväksi
            GalleriaJulkPanel.Visible = false; // Julkinen Galleria piiloon
        }

        // Galleria-sivun Kirjautuminen-sivu linkki
        private void GKirjauduLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KirjauduPanel.Visible = true; // Kirjautuminen näkyväksi
            GalleriaJulkPanel.Visible = false; // Julkinen Galleria piiloon
        }

        // Galleria-sivun Rekisteröityminen-sivu linkki
        private void GRekisteroidyLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RekisteroidyPanel.Visible = true; // Rekisteröityminen näkyväksi
            GalleriaJulkPanel.Visible = false; // Julkinen Galleria piiloon
        }
        private bool tarkistaTextBox ( TextBox a, string b)
        { 
            if (a.Text == "" && a.Text != "Ole Hyvä ja Syottä tiedot")
            {
                MessageBox.Show(b);
                return true;
            }
                return false;
        }
        private void RetallennaBT_Click(object sender, EventArgs e)
        {
            if (tarkistaTextBox(ReEtunimiTB, "Vaaditan Etunimi")) { goto loppu; };
            string etunimi = ReEtunimiTB.Text;
            if (tarkistaTextBox(ReSukunimiTB, "Vaaditan Sukunimi")) { goto loppu; };
            string sukunimi = ReSukunimiTB.Text;
            if (tarkistaTextBox(RePuhelinTB, "Vaaditan Puhelin")) { goto loppu; };
            string puh = RePuhelinTB.Text;
            if (tarkistaTextBox(ReOsaiteTB, "Vaaditan Osaite")) { goto loppu; };
            string osaite = ReOsaiteTB.Text;
            string sukupuoli = ReSukupuoliCB.Text;
            if (tarkistaTextBox(ReEmailTB, "Vaaditan Sahköposti osaite")) { goto loppu; };
            string email = ReEmailTB.Text;
            Tiedansyotto uusisyotto = new Tiedansyotto();
            if (uusisyotto.lisakayttaja(etunimi, sukunimi, puh, email, osaite, sukupuoli))
            {
                MessageBox.Show("onnistu");
            }
            else
            {
                MessageBox.Show("Epåonnistu");
            }
        loppu:;
        }
    }
}
