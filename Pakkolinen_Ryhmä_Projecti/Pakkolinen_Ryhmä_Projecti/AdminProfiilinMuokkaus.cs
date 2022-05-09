using System;
using MySql.Data.MySqlClient; // pitää muistaa lisätä
using System.Data.SqlClient; // pitää muistaa lisätä
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
/// author@ Antti Kuusisto
/// version 9.5.2022
/// <summary>
/// Toimii. Hakee automaattisesti kirjautuneen käyttäjän tiedot sivulle, kun 
/// sivu avataan. Voisi siirtää Onload osiosta tietokanta-asioinnin class:n.
/// Siivottu
/// </summary>

namespace Pakkolinen_Ryhmä_Projecti
{
    public partial class AdminProfiilinMuokkaus : Form
    {
        ADMINPROFMUOKKAUS ad = new ADMINPROFMUOKKAUS(); // muuttuja class:lle
        Tiedansyotto salaus = new Tiedansyotto(); // muuttuja class:lle
        Yhdista yh = new Yhdista(); // muuttuja class:lle
        string uid; // muuttuja käyttäjä tunnukselle
        public AdminProfiilinMuokkaus()
        {
            InitializeComponent();
            uid = Kirjaudu.ktun; // Käyttäjätunnuksen haku kirjautumisesta.
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

        private void PalutteenHallintatoolStripMenuItem_Click(object sender, EventArgs e)
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

        private void YhteydenottojenHallintatoolStripMenuItem_Click(object sender, EventArgs e)
        {
            YhteydenottojenHallinta yhHa = new YhteydenottojenHallinta();
            yhHa.FormClosing += formClosing;
            yhHa.Show();
            this.Hide();
        }

        private void SalasanojenHallintatoolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalasanojenHallinta saHa = new SalasanojenHallinta();
            saHa.FormClosing += formClosing;
            saHa.Show();
            this.Hide();
        }

        private void MuokkaaProfiiliatoolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminProfiilinMuokkaus adPrMu = new AdminProfiilinMuokkaus();
            adPrMu.FormClosing += formClosing;
            adPrMu.Show();
            this.Hide();
        }

        private void VaihdaSalasanatoolStripMenuItem_Click(object sender, EventArgs e)
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

        /* Formin latautuessa hakee tiedot kenttiin. Hakukysely vielä "virheellisesti" tässä eikä 
         * class:ssa.
         */
        private void AdminProfiilinMuokkaus_Load(object sender, EventArgs e)
        {
            string salattu = ""; // muuttuja kryptatulle salasanalle
            // Aloitus try:lla
            try 
            { 
                // Hakukysely käyttäjän tiedoista, samassa tietokantayhteyden ottaminen.
                MySqlCommand command1 = new MySqlCommand("SELECT KAYTTAJA_TUNNUS, ETUNIMI, SUKUNIMI, EMAIL, PUHELIN, OSAITE, POSTINUMERO, TOIMIPAIKKA, TITTELI, SALASANA FROM kayttajat WHERE KAYTTAJA_TUNNUS = @ktun", yh.otaYhteys());
                command1.Parameters.AddWithValue("@ktun", uid); // käyttäjä tunnuksen lisäys kyselyyn
                yh.avaaYhteys(); // tietokantayhteyden avaus
                // hakukysely DataReaderiin
                MySqlDataReader reader1 = command1.ExecuteReader();
                while (reader1.Read()) // Kun DataReader lukee
                {   // while silmukalla tekstikenttiin käyttäjän tiedot
                    this.EnimiTB.Text = (reader1["ETUNIMI"].ToString());
                    this.SnimiTB.Text = (reader1["SUKUNIMI"].ToString());
                    this.EmailTB.Text = (reader1["EMAIL"].ToString());
                    this.PuhNroTB.Text = (reader1["PUHELIN"].ToString());
                    this.OsoiteTB.Text = (reader1["OSAITE"].ToString());
                    this.PostiNroTB.Text = (reader1["POSTINUMERO"].ToString());
                    this.PtoimipaikkaTB.Text = (reader1["TOIMIPAIKKA"].ToString());
                    this.TitteliTB.Text = (reader1["TITTELI"].ToString());
                    salattu = (reader1["SALASANA"].ToString()); // kryptattu salasana muuttujaan
                    reader1.Close(); // DataReader:n sulku
                    break; // Silmukan lopetus
                }
                NakyvaSalasanaLB.Text = salaus.Decrypt(salattu); // salasanan de-kryptaus ja tulostus näytölle
                // Sitten kuvan haku picturebox:n. Alla kysely
                MySqlCommand cmd = new MySqlCommand("SELECT KUVA FROM kayttajat WHERE KAYTTAJA_TUNNUS = @ktun", yh.otaYhteys());
                cmd.Parameters.AddWithValue("@ktun", uid); // Käyttäjä kyselyyn
                MySqlDataAdapter da = new MySqlDataAdapter(cmd); // Kysely data-adapteriin
                DataSet ds = new DataSet(); // dataset muuttuja
                da.Fill(ds, "kayttajat"); // adapteri täytetään datalla mikä tulee table:sta tietokannassa
                int c = ds.Tables["kayttajat"].Rows.Count; // lasketaan rivien määrä table:ssa

                if (c > 0) 
                {
                    //BLOB is read into Byte array, then used to construct MemoryStream,
                    //then passed to PictureBox.
                    Byte[] byteBLOBData = new Byte[0]; // Byte data-tyypin array
                    byteBLOBData = (Byte[])(ds.Tables["kayttajat"].Rows[c - 1]["KUVA"]); 
                    MemoryStream stmBLOBData = new MemoryStream(byteBLOBData);
                    ProfKuvaPB.Image = Image.FromStream(stmBLOBData); // Kuva muodostetaan Memorystreamin avulla picturebox:n 
                }
                yh.suljeYhteys(); // suljetaan tietokanta yhteys
            }
            catch (Exception ex) // poimitaan virhe ja näytetään
            {
                MessageBox.Show($"{ex} v1"); // tuossa v1 on oma yksilöistitunnus viestille       
            }
        }

        // Profiilikuvan vaihtaminen
        private void ProfKuvaBT_Click(object sender, EventArgs e)
        {   // Aloitus try:lla
            try
            {   
                // Avataan FileDialog.
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                // Filter:ssä kuva - tiedosto tyypit
                openFileDialog1.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (openFileDialog1.ShowDialog() == DialogResult.OK) // Mikäli dialogia ei keskeytetä
                {
                    string sfdname = openFileDialog1.FileName; // tiedoston polku
                    KuvanosoiteLB.Text = sfdname; // Näytetään polku
                    // Avataan kuva näytölle
                    ProfKuvaPB.Image = Image.FromFile(openFileDialog1.FileName);
                }
            }
            catch (Exception ex) // poimitaan virhe ja näytetään se
            {
                MessageBox.Show($"{ex} v1"); // tuossa v1 on oma yksilöistitunnus viestille
            }
        }

        //Toiminta, kun painetaan Päivitä profiili - button:a.
        private void PaivitaProfiiliBT_Click(object sender, EventArgs e)
        {   // Aloitetaan try:lla
            try
                {
                    string enimi = EnimiTB.Text.ToString(); // luetaan etunimi
                    string snimi = SnimiTB.Text.ToString(); // luetaan sukunimi
                    string email = EmailTB.Text.ToString(); // luetaan sähköposti
                    string puh = PuhNroTB.Text.ToString(); // luetaan puhelin
                    string osoite = OsoiteTB.Text.ToString(); // luetaan osoite
                    string postinro = PostiNroTB.Text.ToString(); // luetaan postinumero
                    string postitoimi = PtoimipaikkaTB.Text.ToString(); // luetaan postitoimipaikka
                    string titteli = TitteliTB.Text.ToString(); // luetaan titteli
                    string kuva = KuvanosoiteLB.Text.ToString(); // luetaan kuvan polku
                                                                 // Katsotaan, että kentissä on tekstiä
                if (enimi.Equals("") || snimi.Equals("") || email.Equals("") || puh.Equals("") || osoite.Equals("") || postinro.Equals("") ||
                    postitoimi.Equals("") || titteli.Equals("") || kuva.Equals(""))
                    {
                        MessageBox.Show($"Tarkista tekstikentät");
                    }
                    else
                    {
                        // Kutsutaan ADMINPROFMUOKKAUS class:ssa olevaa metodia
                        bool vastaus = ad.paivitaTiedot(enimi,snimi,email,puh,osoite,postinro,postitoimi,titteli,kuva,uid);
                        if (vastaus == true) // mikäli vastaus on true
                        {   //ilmoitus onnistuneesta päivityksestä
                            MessageBox.Show($"Päivitys onnistui");
                            EnimiTB.Text = "";
                            SnimiTB.Text = "";
                            EmailTB.Text = "";
                            PuhNroTB.Text = "";
                            OsoiteTB.Text = "";
                            PostiNroTB.Text = "";
                            PtoimipaikkaTB.Text = "";
                            TitteliTB.Text = "";
                            KuvanosoiteLB.Text = "";
                            ProfKuvaPB.Visible = false;
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

        private void KeskustelupalstaHallintatoolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminKeskusteluPalsta adKeHa = new AdminKeskusteluPalsta();
            adKeHa.FormClosing += formClosing;
            adKeHa.Show();
            this.Hide();
        }
    }
}
/* TESTIKOODIN VARASTO TÄTÄ EI VIELÄ VIITSI HÄVITTÄÄ
    // JOKIN MALLI / HARJOITUS, JOTA EN OLE VIELÄ POISTANUT
                //ProfKuvaopenFileDialog valKuv = new ProfKuvaopenFileDialog();
                /*string path = ""; // muuttuja tiedosto sijainnille
                ProfKuvaopenFileDialog.InitialDirectory = "C:"; // Hakemisto, johon tiedoston valinta aukeaa
                ProfKuvaopenFileDialog.Filter = "Image files | *.jpg"; // Tiedosto tyypin suodatin
                DialogResult result = ProfKuvaopenFileDialog.ShowDialog(); // näyttää tiedoston valinnan
                if (result == DialogResult.OK) // Kokeilee että on kelvollinen tulos
                {
                    //openFileDialog1.Filter = "Doc Files|*.doc|Docx File|*.docx|PDF doc|*.pdf";
                    ProfKuvaopenFileDialog.InitialDirectory = "C:"; // Hakemisto, johon tiedoston valinta aukeaa
                    string fileName = System.IO.Path.GetFileName(ProfKuvaopenFileDialog.FileName); // Tiedosto tyypin suodatin
                    path = Path.GetDirectoryName(ProfKuvaopenFileDialog.FileName);
                    KuvanosoiteLB.Text = path + "/" + fileName;
                    ProfKuvaPB.Image = Image.FromFile(fileName);
                }
*/