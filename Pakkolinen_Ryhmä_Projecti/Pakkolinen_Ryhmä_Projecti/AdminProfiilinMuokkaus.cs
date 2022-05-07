using System;
using MySql.Data.MySqlClient; // pitää muistaa lisätä
using System.Data; // pitää muistaa lisätä
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
/// version 7.5.2022
/// <summary>
/// Tiedot eivät tule Dynaamisesti, mutta muuten toimii salasanan näyttöä lukuunottamatta.
/// </summary>

namespace Pakkolinen_Ryhmä_Projecti
{
    public partial class AdminProfiilinMuokkaus : Form
    {
        ADMINPROFMUOKKAUS ad = new ADMINPROFMUOKKAUS();
        Tiedansyotto salaus = new Tiedansyotto();
        Yhdista yh = new Yhdista();
        public AdminProfiilinMuokkaus()
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

        /* Formin latautuessa hakee tiedot kenttiin. Hakukysely vielä "virheellisesti" tässä.
         * Salasanan decrypt:nen ei toimi.*/
        private void AdminProfiilinMuokkaus_Load(object sender, EventArgs e)
        {   // Aloitua try:lla
            try 
            { 
                // Hakukysely käyttäjän tiedoista. Kuvan haku puuttuu vielä.
                string query = "SELECT KAYTTAJA_TUNNUS, ETUNIMI, SUKUNIMI, EMAIL, PUHELIN, OSAITE, POSTINUMERO, TOIMIPAIKKA, TITTELI, SALASANA FROM kayttajat WHERE KAYTTAJA_TUNNUS = @ktun";
                // Komento tässä hieman erilainen
                MySqlCommand command1 = new MySqlCommand(query, yh.otaYhteys());
                command1.Parameters.AddWithValue("@ktun", "testesti");
                yh.avaaYhteys();
                // hakukysely DataReaderiin
                MySqlDataReader reader1 = command1.ExecuteReader();
                string salattu;
                while (reader1.Read()) // Kun DataReader lukee
                {
                    this.EnimiTB.Text = (reader1["ETUNIMI"].ToString());
                    this.SnimiTB.Text = (reader1["SUKUNIMI"].ToString());
                    this.EmailTB.Text = (reader1["EMAIL"].ToString());
                    this.PuhNroTB.Text = (reader1["PUHELIN"].ToString());
                    this.OsoiteTB.Text = (reader1["OSAITE"].ToString());
                    this.PostiNroTB.Text = (reader1["POSTINUMERO"].ToString());
                    this.PtoimipaikkaTB.Text = (reader1["TOIMIPAIKKA"].ToString());
                    this.TitteliTB.Text = (reader1["TITTELI"].ToString());
                    this.NakyvaSalasanaLB.Text = (reader1["SALASANA"].ToString());
                    reader1.Close(); // DataReader:n sulku
                    //string salattu = NakyvaSalasanaLB.Text.ToString();
                    //string salasana = salaus.Decrypt(salattu);
                    //NakyvaSalasanaLB.Text = salattu;
                    //MessageBox.Show(salattu);
                    break; // Silmukan lopetus
                }
                /*string salattu = NakyvaSalasanaLB.Text.ToString();
                string salasana = Decrypt(salattu);
                NakyvaSalasanaLB.Text = salasana;*/
            }
            catch (Exception ex) // poimitaan virhe ja näytetään
            {
                MessageBox.Show($"{ex} v1");           
            }
        }

        // Profiilikuvan vaihtaminen
        private void ProfKuvaBT_Click(object sender, EventArgs e)
        {   // Aloitus try:lla
            try
            {   // JOKIN MALLI / HARJOITUS, JOTA EN OLE VIELÄ POISTANUT
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
                }*/
                // Avataan FileDialog.
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                // Filter:ssä kuva tiedostot nyt
                openFileDialog1.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (openFileDialog1.ShowDialog() == DialogResult.OK) // Mikäli dialogin ehdot täyttyvät
                {
                    string sfdname = openFileDialog1.FileName; // tiedoston polku
                    KuvanosoiteLB.Text = sfdname; // Näytetään polku
                    // Avataan kuva näytölle
                    ProfKuvaPB.Image = Image.FromFile(openFileDialog1.FileName);
                }
            }
            catch (Exception ex) // poimitaan virhe ja näytetään se
            {
                MessageBox.Show($"{ex} v1");
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
                        bool vastaus = ad.paivitaTiedot(enimi,snimi,email,puh,osoite,postinro,postitoimi,titteli,kuva);
                        if (vastaus == true) // mikäli vastaus on true
                        {   //ilmoitus onnistuneesta päivityksestä
                            MessageBox.Show($"Päivitys onnistui");
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
        public string Decrypt(string cipherText) // Tähän vaihdettu public, jotta voi käyttää muualta käsin. Selvitän voiko näin toimia vai pitääkö keksiä toinen tapa.
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            // .FromBase64String = Converts a CryptoStream from base 64.
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            // Aes = Represents the abstract base class from which all implementations of the Advanced Encryption Standard (AES) must inherit
            // .Create = Creates a cryptographic object that is used to perform the symmetric algorithm.
            using (Aes encryptor = Aes.Create())
            {
                // Rfc2898DeriveBytes = Implements password-based key derivation functionality, PBKDF2, by using a pseudo-random number generator based on HMACSHA1.
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                // .Key = Gets or sets the secret key for the symmetric algorithm.
                // .IV = Gets or sets the initialization vector (IV) for the symmetric algorithm. 
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    // CryptoStream = Defines a stream that links data streams to cryptographic transformations.
                    // .CreateEncryptor() = Creates a symmetric encryptor object with the current Key property and initialization vector (IV).
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }
    }
}
