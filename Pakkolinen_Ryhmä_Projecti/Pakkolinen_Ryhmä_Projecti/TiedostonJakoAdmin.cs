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
/// author@Antti Kuusisto
/// version 6.5.2022
/// <summary>
/// HUOMIO!!! VAATII MUOKKAAMANI TIETOKANNAN, JOTTA TOIMII. HUOMIO!!!
///  PUUTTUU DYNAAMINEN KÄYTTÄJÄTUNNUS ja vaatii päätöksen tietotyypeistä 
///  tai regex:n käyttöä tiedostotyypin poimimiseen tiedoston nimestä.
/// </summary>

namespace Pakkolinen_Ryhmä_Projecti
{
    public partial class TiedostonJakoAdmin : Form
    {
        //muuttuja tietojenlähetys class:n
        ADMINTIEDOSTOJENHALLINTA ad = new ADMINTIEDOSTOJENHALLINTA();
        Yhdista yh = new Yhdista();
        public TiedostonJakoAdmin()
        {
            InitializeComponent();
        }
        void f1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();

        }
        private void AdminKotisivutoolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminKotisivu adKo = new AdminKotisivu();
            adKo.FormClosing += f1_FormClosing;
            adKo.Show();
            this.Hide();
        }

        private void PalautteenHallintatoolStripMenuItem_Click(object sender, EventArgs e)
        {
            PalautteenHallinta paHa = new PalautteenHallinta();
            paHa.FormClosing += f1_FormClosing;
            paHa.Show();
            this.Hide();
        }

        private void LatauksienHallintatoolStripMenuItem_Click(object sender, EventArgs e)
        {
            LatauksienHallinta laHa = new LatauksienHallinta();
            laHa.FormClosing += f1_FormClosing;
            laHa.Show();
            this.Hide();
        }

        private void KayttajatilienHallintatoolStripMenuItem_Click(object sender, EventArgs e)
        {
            KayttajatilienHallinta kaTiHa = new KayttajatilienHallinta();
            kaTiHa.FormClosing += f1_FormClosing;
            kaTiHa.Show();
            this.Hide();
        }

        private void YhteydenottojenHallintatoolStripMenuItem_Click(object sender, EventArgs e)
        {
            YhteydenottojenHallinta yhHa = new YhteydenottojenHallinta();
            yhHa.FormClosing += f1_FormClosing;
            yhHa.Show();
            this.Hide();
        }

        private void MitaUuttaHallintatoolStripMenuItem_Click(object sender, EventArgs e)
        {
            MitaUuttaHallinta miUuHa = new MitaUuttaHallinta();
            miUuHa.FormClosing += f1_FormClosing;
            miUuHa.Show();
            this.Hide();
        }

        private void TiedostonJakotoolStripMenuItem_Click(object sender, EventArgs e)
        {
            TiedostonJakoAdmin tiJaAd = new TiedostonJakoAdmin();
            tiJaAd.FormClosing += f1_FormClosing;
            tiJaAd.Show();
            this.Hide();
        }

        private void SalasanojenHallintaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalasanojenHallinta saHa = new SalasanojenHallinta();
            saHa.FormClosing += f1_FormClosing;
            saHa.Show();
            this.Hide();
        }

        private void MuokkaaProfiiliaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminProfiilinMuokkaus adPrMu = new AdminProfiilinMuokkaus();
            adPrMu.FormClosing += f1_FormClosing;
            adPrMu.Show();
            this.Hide();
        }

        private void VaihdaSalasanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminSalasananVaihto adSaVa = new AdminSalasananVaihto();
            adSaVa.FormClosing += f1_FormClosing;
            adSaVa.Show();
            this.Hide();
        }

        private void KirjauduUlosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Etusivu etusivu = new Etusivu();
            etusivu.FormClosing += f1_FormClosing;
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
                openFileDialog1.Filter = "txt files (*.txt)|*.txt|js files (*.js)|*.js|py files (*.py)|*.py|html files (*.html)|*.html"; // Tiedosto tyypin suodatin"
                DialogResult result = openFileDialog1.ShowDialog(); // näyttää tiedoston valinnan
                if (result == DialogResult.OK) // Kokeilee että on kelvollinen tulos
                { 
                    openFileDialog1.InitialDirectory = "C:"; // Hakemisto, johon tiedoston valinta aukeaa
                    string fileName = System.IO.Path.GetFileName(openFileDialog1.FileName); // Tiedoston nimi
                    string sfdname = openFileDialog1.FileName; // tiedoston polku
                    string content = Path.GetExtension(sfdname); // tiedosto tyyppi
                    //path = Path.GetDirectoryName(openFileDialog1.FileName);
                    TiedostoNimiLB.Text = sfdname; // Näytetään tiedosto polku
                    TyyppiLB.Text = content; // tiedosto tyyppi. Tallennetaan label:n, kun ei tule muuta nyt mieleen
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
                // Tietotyypin luku
                string content = TyyppiLB.Text.ToString();
                // Katsotaan, että muuttujissa on tietoa
                if (path.Equals("") || filename.Equals("") || content.Equals(""))
                {
                    MessageBox.Show($"Et ole valinnut tiedostoa.");
                }
                else
                {
                    /* Kutsutaan DMINTIEDOSTOJENHALLINTA class:ssa olevaa metodia
                     * läheteään polku, nimi ja tietotyyppi*/
                    bool lisays = ad.jaaTiedosto(path, filename,content);
                    if(lisays == true) // mikäli lisäys on onnistunut
                    {
                        MessageBox.Show($"Tiedosto lisätty onnistuneesti tietokantaan.");
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
        // Malli, jota en vielä halua poistaa
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
