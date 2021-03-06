using System;
using MySql.Data.MySqlClient; // pitää muistaa lisätä
using System.Data; // pitää muistaa lisätä
using System.Data.SqlClient; // pitää muistaa lisätä
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// author@ Antti Kuusisto
/// version 30.5.2022
/// <summary>
/// Toiminta, kun muokataan profiilia
/// </summary>
namespace Catering_Projectin
{
    public partial class AdminMuokkaaProfiilia : Form
    {
        ADMINPROFIILINMUOKKAUS ad = new ADMINPROFIILINMUOKKAUS(); // muuttuja class:lle
        Tiedansyotto salaus = new Tiedansyotto(); // muuttuja class:lle, jossa kryptaus
        Yhdista yh = new Yhdista(); // muuttuja class:lle
        string uid = ""; // muuttuja käyttäjä tunnukselle
        private string ktun = string.Empty; // muuttuja käyttäjä tunnukselle
        public string Ktun // get/set metodi, jolla siirretään käyttäjätunnus sivulta toiselle
        {
            get { return ktun; }
            set { ktun = value; }
        }
        public AdminMuokkaaProfiilia()
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
            adKo.Ktun = uid; // Käyttäjätunnuksen siirto toiselle sivulle
            adKo.Show();
            this.Hide();
        }

        private void SaatavuudetTSMI_Click(object sender, EventArgs e)
        {
            AdminSaatavuudet adSa = new AdminSaatavuudet();
            adSa.FormClosing += formClosing;
            adSa.Ktun = uid; // Käyttäjätunnuksen siirto toiselle sivulle
            adSa.Show();
            this.Hide();
        }

        private void TyotilanneTSMI_Click(object sender, EventArgs e)
        {
            AdminTyotilanne adTy = new AdminTyotilanne();
            adTy.FormClosing += formClosing;
            adTy.Ktun = uid; // Käyttäjätunnuksen siirto toiselle sivulle
            adTy.Show();
            this.Hide();
        }
        private void KayttajatTSMI_Click(object sender, EventArgs e)
        {
            AdminKayttajaHallinta adKaHa = new AdminKayttajaHallinta();
            adKaHa.FormClosing += formClosing;
            adKaHa.Ktun = uid; // Käyttäjätunnuksen siirto toiselle sivulle
            adKaHa.Show();
            this.Hide();
        }
        private void salasanojenHallintaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminSalasananHallinta adSaHa = new AdminSalasananHallinta();
            adSaHa.FormClosing += formClosing;
            adSaHa.Ktun = uid; // Käyttäjätunnuksen siirto toiselle sivulle
            adSaHa.Show();
            this.Hide();
        }

        private void muokkaaProfiiliaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminMuokkaaProfiilia adMuPr = new AdminMuokkaaProfiilia();
            adMuPr.FormClosing += formClosing;
            adMuPr.Ktun = uid; // Käyttäjätunnuksen siirto toiselle sivulle
            adMuPr.Show();
            this.Hide();
        }

        private void vaihdaSalasanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminSalasananVaihto adSaVa = new AdminSalasananVaihto();
            adSaVa.FormClosing += formClosing;
            adSaVa.Ktun = uid; // Käyttäjätunnuksen siirto toiselle sivulle
            adSaVa.Show();
            this.Hide();
        }

        private void kirjauduUlosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Etusivu etu = new Etusivu();
            etu.FormClosing += formClosing;
            etu.Show();
            this.Hide();
        }

        private void AdminMuokkaaProfiilia_Load(object sender, EventArgs e)
        {
            string salattu = ""; // muuttuja kryptatulle salasanalle
            uid = Ktun;
            // Aloitus try:lla
            try
            {
                // Hakukysely käyttäjän tiedoista, samassa tietokantayhteyden ottaminen.
                MySqlCommand command1 = new MySqlCommand("SELECT Salasana, Etunimi, Sukunimi, Email, Puhelin, Titteli ,Osoite, Postitoimipaikka, Postinumero FROM kayttajat WHERE KayttajaTunnus = @ktun", yh.otaYhteys());
                command1.Parameters.AddWithValue("@ktun", uid); // käyttäjä tunnuksen lisäys kyselyyn
                yh.avaaYhteys(); // tietokantayhteyden avaus
                // hakukysely DataReaderiin
                MySqlDataReader reader1 = command1.ExecuteReader();
                while (reader1.Read()) // Kun DataReader lukee
                {   // while silmukalla tekstikenttiin käyttäjän tiedot
                    salattu = (reader1["Salasana"].ToString()); // kryptattu salasana muuttujaan
                    this.EnimiTB.Text = (reader1["Etunimi"].ToString());
                    this.SnimiTB.Text = (reader1["Sukunimi"].ToString());
                    this.EmailTB.Text = (reader1["Email"].ToString());
                    this.PuhNroTB.Text = (reader1["Puhelin"].ToString());
                    this.OsoiteTB.Text = (reader1["Osoite"].ToString());
                    this.PToimiTB.Text = (reader1["Postitoimipaikka"].ToString());
                    this.PostiNroTB.Text = (reader1["Postinumero"].ToString());
                    reader1.Close(); // DataReader:n sulku
                    break; // Silmukan lopetus
                }
                NakyvaSalasanaLB.Text = salaus.Decrypt(salattu); // salasanan de-kryptaus ja tulostus näytölle
                yh.suljeYhteys(); // suljetaan tietokanta yhteys
            }
            catch (Exception ex) // poimitaan virhe ja näytetään
            {
                MessageBox.Show($"{ex} v1"); // tuossa v1 on oma yksilöistitunnus viestille    
            }
        }

        private void PaivitaBT_Click(object sender, EventArgs e)
        {
            try
            {
                string enimi = EnimiTB.Text.ToString(); // luetaan etunimi
                string snimi = SnimiTB.Text.ToString(); // luetaan sukunimi
                string email = EmailTB.Text.ToString(); // luetaan sähköposti
                int puh = int.Parse(PuhNroTB.Text.ToString()); // luetaan puhelin
                string osoite = OsoiteTB.Text.ToString(); // luetaan osoite
                int postinro = int.Parse(PostiNroTB.Text.ToString()); // luetaan postinumero
                string postitoimi = PToimiTB.Text.ToString(); // luetaan postitoimipaikka
                if (enimi.Equals("") || snimi.Equals("") || email.Equals("") || puh.Equals("") || osoite.Equals("") || postinro.Equals("") ||
                    postitoimi.Equals(""))
                {
                    MessageBox.Show($"Tarkista tekstikentät");
                }
                else
                {
                    // Kutsutaan ADMINPROFMUOKKAUS class:ssa olevaa metodia
                    bool vastaus = ad.paivitaTiedot(enimi, snimi, email, puh, osoite, postinro, postitoimi, uid);
                    if (vastaus == true) // mikäli vastaus on true
                    {   //ilmoitus onnistuneesta päivityksestä
                        MessageBox.Show($"Päivitys onnistui");
                        EnimiTB.Text = "";
                        SnimiTB.Text = "";
                        EmailTB.Text = "";
                        PuhNroTB.Text = "";
                        OsoiteTB.Text = "";
                        PostiNroTB.Text = "";
                        PToimiTB.Text = "";
                        NakyvaSalasanaLB.Visible = false;
                    }
                    else // mikäli vastaus on false
                    {   //ilmoitus epäonnistuneesta päivityksestä
                        MessageBox.Show($"Päivitys ei onnistunut");
                    }
                }
            }
            catch (Exception ex) // Poimitaan virhe ja näytetään se
            {
                MessageBox.Show($"{ex} v1");
            }
        }
    }
}
