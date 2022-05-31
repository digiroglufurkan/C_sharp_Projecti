using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catering_Projectin
{
    public partial class Rekisteroidy : Form
    {
        Tiedansyotto reksyotto = new Tiedansyotto();

        public Rekisteroidy()
        {
            InitializeComponent();
        }

        void f1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void Rekisteroidy_Load(object sender, EventArgs e)
        {

        }

        private void reketusivuMS_Click(object sender, EventArgs e)
        {
            Etusivu etusivu = new Etusivu();
            etusivu.FormClosing += f1_FormClosing;
            etusivu.Show();
            this.Hide();
        }

        private void rekkirjauduMS_Click(object sender, EventArgs e)
        {

        }

        private void rekisteroidyBT_Click(object sender, EventArgs e)
        {
            if (tarkistusTextBox(reketuTB, "Vaaditaan etunimi!")) { goto loppu; };
            string etunimi = reketuTB.Text;
            if (tarkistusTextBox(reksukunimiTB, "Vaaditaan sukunimi!")) { goto loppu; };
            string sukunimi = reksukunimiTB.Text;
            if (tarkistusTextBox(rekemailTB, "Vaaditaan sähköposti!")) { goto loppu; };
            string email = rekemailTB.Text;
            if (tarkistusTextBox(rekpuhelinTB, "Vaaditaan puhelinnumero!")) { goto loppu; };
            string puhelin = rekpuhelinTB.Text;
            if (tarkistusTextBox(rekosoiteTB, "Vaaditaan osoite!")) { goto loppu; };
            string osoite = rekosoiteTB.Text;
            if (tarkistusTextBox(rekpostiTB, "Vaaditaan postinumero!")) { goto loppu; };
            string posti = rekpostiTB.Text;
            if (tarkistusTextBox(rektoimiTB, "Vaaditaan toimipaikka!")) { goto loppu; };
            string toimi = rektoimiTB.Text;
            if (tarkistusTextBox(rektoimiTB, "Vaaditaan toimipaikka!")) { goto loppu; };
            string yhtio = reklentoTB.Text;
            string icao = icaoTB.Text;


            // Tiedansyotto reksyotto = new Tiedansyotto();
            string salasana;
            if (rekSalis1TB.Text == rekSalis2TB.Text)
            {
                salasana = rekSalis1TB.Text;
            }
            else { MessageBox.Show("Salasanat eivät täsmää!"); goto loppu; }

            string ktunus = reksyotto.lisakayttaja(etunimi, sukunimi, email, puhelin, osoite, posti, toimi, yhtio, icao, salasana);

            if (ktunus != "")
            {
                MessageBox.Show("Rekisteröinti onnistui! Käyttäjätunnuksesi on : " + ktunus);
            }
            else
            {
                MessageBox.Show("Valitettavasti rekisteröinti ei nyt onnistunut.");
            }

            if (yhtio.Equals("") || icao.Equals(""))
            {
                MessageBox.Show("Haluat siis rekisteröityä työntekijäksi?");


            }
            else
            {
                MessageBox.Show("Haluat siis rekisteröityä käyttäjäksi?");
                

            }

            loppu:;
        }

        private bool tarkistusTextBox(TextBox a, string b, string c = "")
        {
            if (a.Text == c)
            {
                MessageBox.Show(b);
                return true;
            }
            return false;
        }

        private void reketunimiLB_Click(object sender, EventArgs e)
        {

        }
    }
}
