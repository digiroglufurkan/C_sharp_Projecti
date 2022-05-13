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


namespace Pakkolinen_Ryhmä_Projecti
{
    public partial class KirjautunutMuokkaaProfiilia : Form
    {
        ProfiilinMuokkaus prof = new ProfiilinMuokkaus();
        Yhdista yhteys = new Yhdista();
        string tun;

        public KirjautunutMuokkaaProfiilia()
        {
            InitializeComponent();
            tun = Kirjaudu.ktun;
        }

        void f1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void ksKotisivuKotisivuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KirjautunutKotisivu kirKotisivu = new KirjautunutKotisivu();
            kirKotisivu.FormClosing += f1_FormClosing;
            kirKotisivu.Show();
            this.Hide();
        }

        private void KotisivuLatauksetToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void ksKotisivuKeskustelupalstaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KeskusteluPalsta kesPalsta = new KeskusteluPalsta();
            kesPalsta.FormClosing += f1_FormClosing;
            kesPalsta.Show();
            this.Hide();
        }

        private void ksKotisivuPalauteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KirjautunutPalaute kirPal = new KirjautunutPalaute();
            kirPal.FormClosing += f1_FormClosing;
            kirPal.Show();
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

        private void KirjautunutMuokkaaProfiilia_Enter(object sender, EventArgs e)
        {

        }

        private void muokkaaProfiiliaBT_Click(object sender, EventArgs e)
        {
            try
            {
                string enimi = muokkaaEtunimiTB.Text.ToString(); // luetaan etunimi
                string snimi = muokkaaSukunimiTB.Text.ToString(); // luetaan sukunimi
                string email = muokkaaEmailTB.Text.ToString(); // luetaan sähköposti
                string puh = muokkaanumeroTB.Text.ToString(); // luetaan puhelin
                string osoite = muokkaaOsoiteTB.Text.ToString(); // luetaan osoite
                string postinro = muokkaaPostiTB.Text.ToString(); // luetaan postinumero
                string postitoimi = muokkaaToimiTB.Text.ToString(); // luetaan postitoimipaikka
                string titteli = muokkaatitteliTB.Text.ToString(); // luetaan titteli
                string kuva = kuvaosoiteLB.Text.ToString(); // luetaan kuvan polku
                                                             // Katsotaan, että kentissä on tekstiä
                if (enimi.Equals("") || snimi.Equals("") || email.Equals("") || puh.Equals("") || osoite.Equals("") || postinro.Equals("") ||
                    postitoimi.Equals("") || titteli.Equals(""))
                {
                    MessageBox.Show($"Tarkista tekstikentät!");
                }
                else
                {
                    // Kutsutaan ADMINPROFMUOKKAUS class:ssa olevaa metodia
                    bool vastaus = prof.muokkaaProffa(enimi, snimi, email, puh, osoite, postinro, postitoimi, titteli, kuva, tun);
                    if (vastaus == true) // mikäli vastaus on true
                    {   //ilmoitus onnistuneesta päivityksestä
                        MessageBox.Show($"Jee! Päivitys onnistui.");
                        muokkaaEtunimiTB.Text = "";
                        muokkaaSukunimiTB.Text = "";
                        muokkaaEmailTB.Text = "";
                        muokkaanumeroTB.Text = "";
                        muokkaaOsoiteTB.Text = "";
                        muokkaaPostiTB.Text = "";
                        muokkaaToimiTB.Text = "";
                        muokkaatitteliTB.Text = "";
                        kuvaosoiteLB.Text = "";
                        //ProfKuvaPB.Visible = false;
                        //NakyvaSalasanaLB.Visible = false;
                    }
                    else // mikäli vastaus on false
                    {   //ilmoitus epäonnistuneesta päivityksestä
                        MessageBox.Show($"Päivitys ei onnistunut. :(");
                    }
                }
            }
            catch (Exception ex) // Poimitaan virhe ja näytetään se
            {
                MessageBox.Show($"{ex} v1");
            }
        }

        private void KirjautunutMuokkaaProfiilia_Load(object sender, EventArgs e)
        {
            try
            {
                
                MySqlCommand command1 = new MySqlCommand("SELECT KAYTTAJA_TUNNUS, ETUNIMI, SUKUNIMI, EMAIL, PUHELIN, OSAITE, POSTINUMERO, TOIMIPAIKKA, TITTELI, SALASANA FROM kayttajat WHERE KAYTTAJA_TUNNUS = @ktun", yhteys.otaYhteys());
                command1.Parameters.AddWithValue("@ktun", tun); 
                yhteys.avaaYhteys(); 
                MySqlDataReader reader1 = command1.ExecuteReader();
                while (reader1.Read()) 
                {   
                    this.muokkaaEtunimiTB.Text = (reader1["ETUNIMI"].ToString());
                    this.muokkaaSukunimiTB.Text = (reader1["SUKUNIMI"].ToString());
                    this.muokkaaEmailTB.Text = (reader1["EMAIL"].ToString());
                    this.muokkaanumeroTB.Text = (reader1["PUHELIN"].ToString());
                    this.muokkaaOsoiteTB.Text = (reader1["OSAITE"].ToString());
                    this.muokkaaPostiTB.Text = (reader1["POSTINUMERO"].ToString());
                    this.muokkaaToimiTB.Text = (reader1["TOIMIPAIKKA"].ToString());
                    this.muokkaatitteliTB.Text = (reader1["TITTELI"].ToString());
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

        private void vaihdaKuvaBT_Click(object sender, EventArgs e)
        {
            try
            {
                // Avataan FileDialog.
                OpenFileDialog muokkaakuvaOFD = new OpenFileDialog();
                // Filter:ssä kuva - tiedosto tyypit
                muokkaakuvaOFD.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (muokkaakuvaOFD.ShowDialog() == DialogResult.OK) // Mikäli dialogia ei keskeytetä
                {
                    string polku = muokkaakuvaOFD.FileName; // tiedoston polku
                    kuvaosoiteLB.Text = polku; // Näytetään polku
                    // Avataan kuva näytölle
                    muokkaaKuvaPB.Image = Image.FromFile(muokkaakuvaOFD.FileName);
                }
            }
            catch (Exception ex) // poimitaan virhe ja näytetään se
            {
                MessageBox.Show($"{ex} v1"); // tuossa v1 on oma yksilöistitunnus viestille
            }
        }
    }
}
