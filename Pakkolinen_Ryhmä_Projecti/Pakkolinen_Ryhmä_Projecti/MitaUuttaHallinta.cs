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
/// version 30.4.2022
/// <summary>
/// Sivut olemassa ja niille siirtyminen toimii, muuten kesken. Tietojen hakeminen tietokannasta Datagrid:n toimii.
/// </summary>

namespace Pakkolinen_Ryhmä_Projecti
{
    public partial class MitaUuttaHallinta : Form
    {
        ADMINTIEDOSTOJENHALLINTA adT = new ADMINTIEDOSTOJENHALLINTA();
        ADMINMITAUUTTA adM = new ADMINMITAUUTTA();
        public MitaUuttaHallinta()
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

        private void KeskustelupalstaHallintatoolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminKeskusteluPalsta adKeHa = new AdminKeskusteluPalsta();
            adKeHa.FormClosing += formClosing;
            adKeHa.Show();
            this.Hide();
        }

        private void MitaUuttaHallinta_Load(object sender, EventArgs e)
        {
            // Kutsutaan ADMINTIEDOSTOJENHALLINTA CLASS.ssa olevaa metodia, joka hakee tietokannasta tiedot niille varatulle aluelle
            TalTieDGV.DataSource = adT.haeLataukset();
            TalTieDGV.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);// datagridview:n muotoilua
            var datagridview = new DataGridView();
            datagridview.RowTemplate.MinimumHeight = 200;
            MitaUuttaDGV.DataSource = adM.haeUutuudet();
            MitaUuttaDGV.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            TestDGV.DataSource = adM.haeKaksiUutuutta();
            TestDGV.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void TalTieDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == ValitseCo.Index) // mikäli klikataan poista-buttonia
            {
                try // aloitetaan try:lla
                {   // Otetaan id kentästä yksilöivä tunnus
                    int yTun = int.Parse(TalTieDGV.CurrentRow.Cells[1].Value.ToString());
                    if (yTun.Equals("")) // kokeillaan onko saatu talteen id tieto
                    {   // virheviesti
                        MessageBox.Show($"Et ole valinnut lisättävää kohdetta.");
                    }
                    else
                    {   //Kutsutaan ADMINKAYTHALLINTA CLASS.ssa olevaa funktiota, joka poistaa tiedoston tietokannasta
                        bool poisto = adM.lisaaUutuus(yTun); //lähetetään id ja otetaan paluu parametrinä bool-arvo
                        if (poisto == true) // mikäli bool arvo on true
                        {   // viesti onnistuneesta toimenpiteestä
                            MessageBox.Show($"Poisto suoritettu.");
                        }
                        else // mikäli bool arvo on false
                        {   // virheviesti
                            MessageBox.Show($"Poisto ei onnistunut.");

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                return;
            }
        }
    }
}
