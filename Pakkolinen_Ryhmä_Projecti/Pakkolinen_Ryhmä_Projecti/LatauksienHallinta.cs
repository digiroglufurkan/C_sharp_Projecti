using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// author@Antti Kuusisto
/// version 9.5.2022
/// <summary>
/// HUOMIO!!! VAATII MUOKKAAMANI TIETOKANNAN, JOTTA TOIMII. HUOMIO!!!
/// Tiedoston poisto toimii. Lataus toimii.
/// Siivottu.
/// </summary>

namespace Pakkolinen_Ryhmä_Projecti
{
    public partial class LatauksienHallinta : Form
    {
        ADMINTIEDOSTOJENHALLINTA ad = new ADMINTIEDOSTOJENHALLINTA();
        public LatauksienHallinta()
        {
            InitializeComponent();
        }
        void formClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();

        }
        private void AdminKotisivutoolStripItem_Click(object sender, EventArgs e)
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

        // Toiminta, kun sivu ladataan
        private void LatauksienHallinta_Load(object sender, EventArgs e)
        {
            // Kutsutaan ADMINTIEDOSTOJENHALLINTA CLASS.ssa olevaa metodia, joka hakee tietokannasta tiedot niille varatulle aluelle
            LaHallintadataGridView.DataSource = ad.haeLataukset();
            LaHallintadataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);// datagridview:n muotoilua
            var datagridview = new DataGridView();
            datagridview.RowTemplate.MinimumHeight = 200;
        }

        // Toiminta, kun klikataan dataGridView:sä olevaa buttonia
        private void LaHallintadataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try // aloitetaan try:lla
            {
                if (e.ColumnIndex == PoistaColumn.Index) // mikäli klikataan poista-buttonia
                {   
                    try // aloitetaan try:lla
                    {   // Otetaan id kentästä yksilöivä tunnus
                        int yTun = int.Parse(LaHallintadataGridView.CurrentRow.Cells[2].Value.ToString());
                        if (yTun.Equals("")) // kokeillaan onko saatu talteen id tieto
                        {   // virheviesti
                            MessageBox.Show($"Et ole valinnut poistettavaa kohdetta.");
                        }
                        else
                        {   //Kutsutaan ADMINKAYTHALLINTA CLASS.ssa olevaa funktiota, joka poistaa tiedoston tietokannasta
                            bool poisto = ad.poistaTiedosto(yTun); //lähetetään id ja otetaan paluu parametrinä bool-arvo
                            if (poisto == true) // mikäli bool arvo on true
                            {   // viesti onnistuneesta toimenpiteestä
                                MessageBox.Show($"Poisto suoritettu.");
                            }
                            else // mikäli bool arvo on false
                            {   // virheviesti
                                MessageBox.Show($"Poisto ei onnistunut.");
                            }
                            // päivitetään taulukko ajan tasalle
                            LaHallintadataGridView.DataSource = ad.haeLataukset();
                        }
                    }
                    catch (Exception ex) //poimitaan virhe ja näytetään se
                    {
                        MessageBox.Show($"{ex.Message} v2");
                    }
                }
                // toiminta mikäli klikataan lataa-button:a
                else if(e.ColumnIndex == LataaColumn.Index)
                {   // aloitetaan try:lla
                    try
                    {   // Otetaan id kentästä yksilöivä tunnus
                        int yTun = int.Parse(LaHallintadataGridView.CurrentRow.Cells[2].Value.ToString());
                        if (yTun.Equals("")) // kokeillaan onko saatu talteen id tieto
                        {   // virheviesti
                            MessageBox.Show($"Et ole valinnut poistettavaa kohdetta.");
                        }
                        else
                        {   //Kutsutaan ADMINKAYTHALLINTA CLASS.ssa olevaa funktiota, joka lataa tiedoston tietokannasta
                            bool poisto = ad.lataaTiedosto(yTun); // lähetetään id ja otetaan paluu parametrinä bool-arvo
                            if (poisto == true) // mikäli bool arvo on true
                            {   // viesti onnistuneesta toimenpiteestä
                                MessageBox.Show($"Lataus suoritettu.");
                            }
                            else // mikäli bool arvo on false
                            {   // virheviesti
                                MessageBox.Show($"Lataus ei onnistunut.");
                            }
                        }
                    }
                    catch (Exception ex) //poimitaan virhe ja näytetään se
                    {
                        MessageBox.Show($"{ex.Message} v3");
                    }
                }
                else // mikäli klikataan, jotain muuta kenttää
                {
                    return;
                }
            }
            catch (Exception ex) //poimitaan virhe ja näytetään se
            {
                MessageBox.Show($"{ex.Message} v1");
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
            *try
            {
                elseif (e.ColumnIndex != LataaColumn.Index)
                {
                    return;
                }
                else
                {
                    try
                    {
                        int yTun = int.Parse(LaHallintadataGridView.CurrentRow.Cells[2].ToString());
                        if (yTun.Equals(""))
                        {
                            MessageBox.Show($"Et ole valinnut poistettavaa kohdetta.");
                        }
                        else
                        {
                            bool poisto = ad.lataaTiedosto(yTun);
                            if (poisto == true)
                            {
                                MessageBox.Show($"Lataus suoritettu.");
                            }
                            else
                            {
                                MessageBox.Show($"Lataus ei onnistunut.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
 */