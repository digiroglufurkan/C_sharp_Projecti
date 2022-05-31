using System;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
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
    public partial class KokkiProfiilinMuokkaus : Form
    {
        KokkiProfMuokkaus kproffa = new KokkiProfMuokkaus();
        Yhdista yhteys = new Yhdista();
        string tunnus;
        public KokkiProfiilinMuokkaus()
        {
            InitializeComponent();
            tunnus = Kirjaudu.ktun; 
        }

        void f1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void kokkikotiMS_Click(object sender, EventArgs e)
        {
            KokkiKotisivu kokkikoti = new KokkiKotisivu();
            kokkikoti.FormClosing += f1_FormClosing;
            kokkikoti.Show();
            this.Hide();
        }

        private void kokkiruoatMS_Click(object sender, EventArgs e)
        {
            KokkiRuoat kokkiruoka = new KokkiRuoat();
            kokkiruoka.FormClosing += f1_FormClosing;
            kokkiruoka.Show();
            this.Hide();
        }

        private void kokkisalisMS_Click(object sender, EventArgs e)
        {
            KokkiSalasananVaihto kokkisalis = new KokkiSalasananVaihto();
            kokkisalis.FormClosing += f1_FormClosing;
            kokkisalis.Show();
            this.Hide();
        }

        private void kokkiulosMS_Click(object sender, EventArgs e)
        {
            Etusivu kokkiulos = new Etusivu();
            kokkiulos.FormClosing += f1_FormClosing;
            kokkiulos.Show();
            this.Hide();
        }

        private void kokkimuokkaaprofiiliBT_Click(object sender, EventArgs e)
        {
             try
             {
                 string etunimi = kokkietunimiTB.Text;
                 string sukunimi = kokkisukunimiTB.Text;
                 string email = kokkiemailTB.Text;
                 string puhelin = kokkipuhelinTB.Text;
                 string osoite = kokkiosoiteTB.Text;
                 string toimi = kokkitoimipaikkaTB.Text;
                 string posti = kokkipostiTB.Text;
                 if (etunimi.Equals("") || sukunimi.Equals("") || email.Equals("") || puhelin.Equals("") || osoite.Equals("") || toimi.Equals("") ||
                   posti.Equals(""))
                 {
                     MessageBox.Show($"Tarkista tekstikentät!");
                 }
                 else
                 {
                     bool muokkaa = kproffa.muokkaaKokkiProffa(etunimi, sukunimi, email, puhelin, osoite, toimi, posti, tunnus);
                     if (muokkaa == true)
                     {
                         MessageBox.Show("Päivitys onnistui!");
                         kokkietunimiTB.Text = "";
                         kokkisukunimiTB.Text = "";
                         kokkiemailTB.Text = "";
                         kokkipuhelinTB.Text = "";
                         kokkiosoiteTB.Text = "";
                         kokkitoimipaikkaTB.Text = "";
                         kokkipostiTB.Text = "";
                     }
                     else
                     {
                         MessageBox.Show("Päivitys ei onnistunut.");
                     }
                 }
             }
             catch (Exception ex) 
             {
                 MessageBox.Show($"{ex} v1");
             }
        }

        private void KokkiProfiilinMuokkaus_Load(object sender, EventArgs e)
        {
            try
            {

                MySqlCommand command1 = new MySqlCommand("SELECT KayttajaTunnus, Etunimi, Sukunimi, Email, Puhelin, Osoite, Postitoimipaikka, Postinumero FROM kayttajat WHERE KayttajaTunnus = @ktun", yhteys.otaYhteys());
                command1.Parameters.AddWithValue("@ktun", tunnus);
                yhteys.avaaYhteys();
                MySqlDataReader reader1 = command1.ExecuteReader();
                while (reader1.Read())
                {
                    this.kokkietunimiTB.Text = (reader1["Etunimi"].ToString());
                    this.kokkisukunimiTB.Text = (reader1["Sukunimi"].ToString());
                    this.kokkiemailTB.Text = (reader1["Email"].ToString());
                    this.kokkipuhelinTB.Text = (reader1["Puhelin"].ToString());
                    this.kokkiosoiteTB.Text = (reader1["Osoite"].ToString());
                    this.kokkipostiTB.Text = (reader1["Postinumero"].ToString());
                    this.kokkitoimipaikkaTB.Text = (reader1["Postitoimipaikka"].ToString());
                    reader1.Close();
                    break;
                }

                yhteys.suljeYhteys();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex} v1");
            }
        }
        }
    }

