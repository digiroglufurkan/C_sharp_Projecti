using System;
using MySql.Data.MySqlClient;
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
        Yhdista yhteys = new Yhdista();

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
            Kirjaudu kir = new Kirjaudu();
            kir.FormClosing += f1_FormClosing;
            kir.Show();
            this.Hide();
        }

        private void rekisteroidyBT_Click(object sender, EventArgs e)
        {
            // Kentän tarkistus
            if (tarkistusTextBox(reketuTB, "Vaaditaan etunimi!")) { goto loppu; };
            string etunimi = reketuTB.Text; // muuttujalle arvo
            // Kentän tarkistus
            if (tarkistusTextBox(reksukunimiTB, "Vaaditaan sukunimi!")) { goto loppu; };
            string sukunimi = reksukunimiTB.Text; // muuttujalle arvo
            // Kentän tarkistus
            if (tarkistusTextBox(rekemailTB, "Vaaditaan sähköposti!")) { goto loppu; };
            string email = rekemailTB.Text; // muuttujalle arvo
            // Kentän tarkistus
            if (tarkistusTextBox(rekpuhelinTB, "Vaaditaan puhelinnumero!")) { goto loppu; };
            int puhelin = int.Parse(rekpuhelinTB.Text); // muuttujalle arvo
            // Kentän tarkistus
            if (tarkistusTextBox(rekosoiteTB, "Vaaditaan osoite!")) { goto loppu; };
            string osoite = rekosoiteTB.Text; // muuttujalle arvo
            // Kentän tarkistus
            if (tarkistusTextBox(rekpostiTB, "Vaaditaan postinumero!")) { goto loppu; };
            int posti = int.Parse(rekpostiTB.Text); // muuttujalle arvo
            // Kentän tarkistus
            if (tarkistusTextBox(rektoimiTB, "Vaaditaan toimipaikka!")) { goto loppu; };
            string toimi = rektoimiTB.Text; // muuttujalle arvo
            // Kentän tarkistus
            if (tarkistusTextBox(rektoimiTB, "Vaaditaan toimipaikka!")) { goto loppu; };
            string yhtio = reklentoTB.Text; // muuttujalle arvo
            string icao = icaoTB.Text; // muuttujalle arvo
            string salasana; // muuttujalle arvo
            if (rekSalis1TB.Text == rekSalis2TB.Text) //tarkistus, että salasana kaksi kertaa
            {
                salasana = rekSalis1TB.Text; // muuttujalle arvo
            }
            else { MessageBox.Show("Salasanat eivät täsmää!"); goto loppu; } //virheviesti
            if (yhtio.Equals("") || icao.Equals(""))//mikäli ei yhtötä eikä ICAO:a syötetty
            {   // kysytään haluaako olla työntekijä
                DialogResult dialogResult = MessageBox.Show("Haluat siis rekisteröityä työntekijäksi", "Oletko varma?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)// mikäli vastaa kyllä
                {
                    int rooli = 3; //määritellään RooliID
                    string ktunus = reksyotto.lisatyontekija(etunimi, sukunimi, email, puhelin, osoite, posti, toimi, salasana, rooli);
                    if (ktunus != "")
                    {
                        MessageBox.Show("Rekisteröinti onnistui! Käyttäjätunnuksesi on : " + ktunus);
                    }
                    else
                    {
                        MessageBox.Show("Valitettavasti rekisteröinti ei nyt onnistunut.");
                    }

                }
                else if (dialogResult == DialogResult.No)// mikäli vastaa ei
                {
                    return;
                }
                
            }
            else
            {   // kysytään haluaako olla käyttäjä
                DialogResult dialogResult = MessageBox.Show("Haluat siis rekisteröityä käyttäjäksi", "Oletko varma?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)// mikäli vastaa kyllä
                {
                    int yhId = 0;
                    int rooli = 2; //määritellään RooliID
                    bool eka = reksyotto.yhtioTiedot(yhtio, icao);
                    MySqlCommand cmd1 = new MySqlCommand("SELECT YhtioID FROM lentoyhtionyhteyshenkilot WHERE ICAOkoodi = @icao", yhteys.otaYhteys());
                    cmd1.Parameters.Add("@icao", MySqlDbType.VarChar).Value = icao;
                    yhteys.avaaYhteys();
                    MySqlDataReader reader1 = cmd1.ExecuteReader();
                    while (reader1.Read()) // Kun DataReader lukee
                    {   // while silmukalla tekstikenttiin käyttäjän tiedot
                        yhId = (int)reader1.GetInt32(0);
                        //(reader1["Email"].ToString());
                        reader1.Close(); // DataReader:n sulku
                        break; // Silmukan lopetus
                    }
                    yhteys.suljeYhteys();
                    MessageBox.Show($"{yhId}");
                    string ktunus = reksyotto.lisakayttaja(etunimi, sukunimi, email, puhelin, osoite, posti, toimi, salasana, rooli, yhId); 
                    if (ktunus != "" || yhId != 0)
                    {
                        MessageBox.Show("Rekisteröinti onnistui! Käyttäjätunnuksesi on : " + ktunus);
                    }
                    else
                    {
                        MessageBox.Show("Valitettavasti rekisteröinti ei nyt onnistunut.");
                    }
                }
                else if (dialogResult == DialogResult.No)// mikäli vastaa ei
                {
                    return;
                }
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
