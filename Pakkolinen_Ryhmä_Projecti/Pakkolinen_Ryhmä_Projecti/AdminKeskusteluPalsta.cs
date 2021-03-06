using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // pitää muistaa lisätä
using System.Data; // pitää muistaa lisätä
using System.Data.SqlClient; // pitää muistaa lisätä
/// author@ Antti Kuusisto
/// version 9.5.2022
/// <summary>
/// Pitäisi toimia ei vielä testattu.
/// </summary>
namespace Pakkolinen_Ryhmä_Projecti
{
    public partial class AdminKeskusteluPalsta : Form
    {
        Yhdista yh = new Yhdista();
        HALLINTAKESKUSTELUPALSTA ad = new HALLINTAKESKUSTELUPALSTA();
        public AdminKeskusteluPalsta()
        {
            InitializeComponent();
        }
        void formClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();

        }
        private void KotisivutoolStripMenuItem_Click(object sender, EventArgs e)
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

        private void KeskustelupalstaHallintatoolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminKeskusteluPalsta adKeHa = new AdminKeskusteluPalsta();
            adKeHa.FormClosing += formClosing;
            adKeHa.Show();
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

        private void AdminKeskusteluPalsta_Load(object sender, EventArgs e)
        {
            PalstaDGW.DataSource = ad.haeKeskustelut(); // Kutsutaan ADMINKAYTHALLINTA CLASS.ssa olevaa funktiota, joka hakee tietokannasta tiedot niille varatulle aluelle
            PalstaDGW.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            //var datagridview = new DataGridView();
        }

        private void PalstaDGW_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == PoistaColumn.Index)
                {
                    try
                    {
                        int tun = int.Parse(PalstaDGW.CurrentRow.Cells[1].Value.ToString());
                        if (tun.Equals(""))
                        {
                            MessageBox.Show($"Et ole valinnut poistettavaa kohdetta.");
                        }
                        else
                        {
                            bool poisto = ad.poistaKeskustelu(tun);
                            if (poisto == true)
                            {
                                MessageBox.Show($"Poisto suoritettu.");
                            }
                            else
                            {
                                MessageBox.Show($"Poisto ei onnistunut.");
                            }
                            PalstaDGW.DataSource = ad.haeKeskustelut();
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
        }
    }
}
