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
using System.Text.RegularExpressions; // TÄMÄ PITÄÄ OLLA, JOTTA TOIMII
/// author@Antti Kuusisto
/// version 6.5.2022
/// <summary>
/// HUOMIO!!! VAATII MUOKKAAMANI TIETOKANNAN, JOTTA TOIMII. HUOMIO!!!
/// Toimii lisää dynaamisesti käyttäjä tunnuksen ja poimii regex:llä tiedosto tyypin.
/// Siivottu
/// </summary>

namespace Pakkolinen_Ryhmä_Projecti
{
    public partial class TiedostonJakoAdmin : Form
    {
        string uid; // Muuttuja käyttäjä tunnukselle
        string fileType; // Muuttuja tiedosto tyypille
        ADMINTIEDOSTOJENHALLINTA ad = new ADMINTIEDOSTOJENHALLINTA(); //muuttuja tietojenlähetys class:n
        Yhdista yh = new Yhdista(); // tietokanta yhteys class
        public TiedostonJakoAdmin()
        {
            InitializeComponent();
            uid = Kirjaudu.ktun; // Käyttäjä tunnuksen haku kirjautumisen sivulta
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

        private void KayttajatilienHallintatoolStripMenuItem_Click(object sender, EventArgs e)
        {
            KayttajatilienHallinta kaTiHa = new KayttajatilienHallinta();
            kaTiHa.FormClosing += formClosing;
            kaTiHa.Show();
            this.Hide();
        }

        private void YhteydenottojenHallintatoolStripMenuItem_Click(object sender, EventArgs e)
        {
            YhteydenottojenHallinta yhHa = new YhteydenottojenHallinta();
            yhHa.FormClosing += formClosing;
            yhHa.Show();
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

        // Valitaan tiedosto - button:n toiminta
        private void VaTieBT_Click(object sender, EventArgs e)
        {   // Aloitetaan try:lla
            try
            {
                string path = ""; // muuttuja tiedosto sijainnille
                openFileDialog1.InitialDirectory = "C:"; // Hakemisto, johon tiedoston valinta aukeaa
                openFileDialog1.Filter = "All files(*.*) | *.*| All files(*.*) | *.*";// Tiedosto tyypin suodatin" //"txt files (*.txt)|*.txt|js files (*.js)|*.js|py files (*.py)|*.py|html files (*.html)|*.html"; 
                DialogResult result = openFileDialog1.ShowDialog(); // näyttää tiedoston valinnan
                if (result == DialogResult.OK) // Kokeilee että  ei keskeytetä dialogia
                { 
                    openFileDialog1.InitialDirectory = "C:"; // Hakemisto, johon tiedoston valinta aukeaa
                    string fileName = System.IO.Path.GetFileName(openFileDialog1.FileName); // Tiedoston nimi
                    string sfdname = openFileDialog1.FileName; // tiedoston polku
                    //string content = Path.GetExtension(sfdname); // tiedosto tyyppi
                    TiedostoNimiLB.Text = sfdname; // Näytetään tiedosto polku
                    string pattern = @"(?<=\.)[^.]+$"; // regex jolla poimitaan tiedosto tyyppi
                    Regex rg = new Regex(pattern); // Uusi regex muuttuja ja ehdon liittäminen
                    MatchCollection co = rg.Matches(sfdname); // Regex match:n keräävä muuttuja
                    fileType = co[0].Value; // tiedosto tyyppi muuttujaan, joka määritelty aiemmin. 
                }
            }
            catch (Exception ex) // virheen poiminta ja näyttö
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void JaaBT_Click(object sender, EventArgs e)
        {   // Aloitetaan try:lla
            try
            {   // Luetaan polku label:sta 
                string path = TiedostoNimiLB.Text.ToString();
                // Tietokantaan tuleva tiedostonimi
                string filename = AiheTB.Text.ToString();
                // Katsotaan, että muuttujissa on tietoa
                string kuvaus = KuvausTB.Text.ToString();
                if (path.Equals("") || filename.Equals("") || fileType.Equals("") || kuvaus.Equals(""))
                {
                    MessageBox.Show($"Et ole valinnut tiedostoa.");
                }
                else
                {
                    /* Kutsutaan ADMINTIEDOSTOJENHALLINTA class:ssa olevaa metodia
                     * läheteään polku, nimi ja tietotyyppi*/
                    bool lisays = ad.jaaTiedosto(path, filename, kuvaus,fileType,uid);
                    if(lisays == true) // mikäli lisäys on onnistunut
                    {
                        MessageBox.Show($"Tiedosto lisätty onnistuneesti tietokantaan.");
                        AiheTB.Text = "";
                        TiedostoNimiLB.Text = "";
                        KuvausTB.Text = "";
                    }
                    else
                    {   // virhe viesti
                        MessageBox.Show($"Tiedoston lisäys tietokantaan ei onnistunut");
                    }

                }
            }
            catch (Exception ex) // virheen poiminta ja näyttö
            {
                MessageBox.Show($"{ex.Message} virhe1");
            }
        }

        private void KeskustelupalstaHallintatoolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminKeskusteluPalsta adKeHa = new AdminKeskusteluPalsta();
            adKeHa.FormClosing += formClosing;
            adKeHa.Show();
            this.Hide();
        }
        // KOODIVARASTO
        /* public void SaveToMysql()
         {
             try
             {
                 string path = Path.GetDirectoryName(openFileDialog1.FileName);
                 string filename = System.IO.Path.GetFileName(openFileDialog1.FileName);
                 byte[] rawData = File.ReadAllBytes(filename);
                 FileInfo info = new FileInfo(path);
                 MySqlCommand command = new MySqlCommand("INSERT INTO file (fileName, fileBlob) VALUES (?fileName, ?fileName);", yh.otaYhteys());
                 MySqlParameter blobName = new MySqlParameter("?fileName", MySqlDbType.String);
                 MySqlParameter blobData = new MySqlParameter("?rawData", MySqlDbType.Blob, rawData.Length);
                 blobData.Value = rawData;
                 blobName.Value = info.Name;
                 command.Parameters.Add(blobData);
                 command.Parameters.Add(blobName);
                 yh.avaaYhteys();
                 command.ExecuteNonQuery();
                 yh.suljeYhteys();
                 MessageBox.Show($"Tiedosto ladattu tietokantaan.");
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
         }
         /*var fileContent = string.Empty;
         var filePath = string.Empty;

         using (OpenFileDialog openFileDialog = new OpenFileDialog())
         {
             openFileDialog.InitialDirectory = "c:\\";
             openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
             openFileDialog.FilterIndex = 2;
             openFileDialog.RestoreDirectory = true;

             if (openFileDialog.ShowDialog() == DialogResult.OK)
             {
                 //Get the path of specified file
                 filePath = openFileDialog.FileName;

                 //Read the contents of the file into a stream
                 var fileStream = openFileDialog.OpenFile();

                 using (StreamReader reader = new StreamReader(fileStream))
                 {
                     fileContent = reader.ReadToEnd();
                 }
             }
         }*/
    }
}
