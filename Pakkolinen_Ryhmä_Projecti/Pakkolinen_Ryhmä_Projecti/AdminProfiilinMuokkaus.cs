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
/// author@ Antti Kuusisto
/// version 30.4.2022
/// <summary>
/// Sivut olemassa ja niille siirtyminen toimii, muuten kesken. Tietojen hakeminen tietokannasta Datagrid:n toimii.
/// </summary>

namespace Pakkolinen_Ryhmä_Projecti
{
    public partial class AdminProfiilinMuokkaus : Form
    {
        ADMINPROFMUOKKAUS ad = new ADMINPROFMUOKKAUS();
        public AdminProfiilinMuokkaus()
        {
            InitializeComponent();
        }
        Tiedansyotto salaus = new Tiedansyotto();
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

        private void AdminProfiilinMuokkaus_Load(object sender, EventArgs e)
        {
            try 
            { 
                Yhdista yh = new Yhdista();
                string query = "SELECT KAYTTAJA_TUNNUS, ETUNIMI, SUKUNIMI, EMAIL, PUHELIN, OSAITE, POSTINUMERO, TOIMIPAIKKA, TITTELI, SALASANA FROM kayttajat WHERE KAYTTAJA_TUNNUS = @ktun";
                MySqlCommand command1 = new MySqlCommand(query, yh.otaYhteys());
                yh.avaaYhteys();
                command1.Parameters.AddWithValue("@ktun", "testesti");
                //command1.Parameters.AddWithValue("@Emplname", txtEmplyName.Text);
                MySqlDataReader reader1 = command1.ExecuteReader();
                while (reader1.Read())
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
                    reader1.Close();
                    break;
                }
                string salattu = NakyvaSalasanaLB.Text.ToString();
                string salasana = salaus.Decrypt(salattu);
                NakyvaSalasanaLB.Text = salasana;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Virhe tietokanta yhteydessä. Palaa myöhemmin sivulle tai ota yhteys palveluntarjoajaan.");           
            }
        }

        private void ProfKuvaBT_Click(object sender, EventArgs e)
        {
            try
            {
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
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Image files | *.jpg";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    KuvanosoiteLB.Text = openFileDialog1.FileName;
                    ProfKuvaPB.Image = Image.FromFile(openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
            private void PaivitaProfiiliBT_Click(object sender, EventArgs e)
            {
                try
                {
                string enimi = EnimiTB.Text.ToString();
                string snimi = SnimiTB.Text.ToString();
                string email = EmailTB.Text.ToString();
                string puh = PuhNroTB.Text.ToString();
                string osoite = OsoiteTB.Text.ToString();
                string postinro = PostiNroTB.Text.ToString();
                string postitoimi = PtoimipaikkaTB.Text.ToString();
                string titteli = TitteliTB.Text.ToString();
                string kuva = KuvanosoiteLB.Text.ToString();
                if (enimi.Equals("") || snimi.Equals("") || email.Equals("") || puh.Equals("") || osoite.Equals("") || postinro.Equals("") ||
                    postitoimi.Equals("") || titteli.Equals("") || kuva.Equals(""))
                {
                    MessageBox.Show($"Tarkista tekstikentät");
                }
                else
                {
                    bool vastaus = ad.paivitaTiedot(enimi,snimi,email,puh,osoite,postinro,postitoimi,titteli,kuva);
                    if (vastaus == true)
                    {
                        MessageBox.Show($"Päivitys onnistui");
                    }
                    else
                    {
                        MessageBox.Show($"Päivitys ei onnistunut");
                    }
                }
            }
                catch (Exception ex)
                {
                MessageBox.Show(ex.Message);
                }
            }
    }
}
