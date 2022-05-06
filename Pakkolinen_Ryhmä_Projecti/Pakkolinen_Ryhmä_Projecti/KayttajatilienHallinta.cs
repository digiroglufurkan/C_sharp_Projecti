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
    public partial class KayttajatilienHallinta : Form
    {
        ADMINKAYTHALLINTA ad = new ADMINKAYTHALLINTA(); // muuttuja ADMINKAYTHALLINTA class:lle
        public KayttajatilienHallinta()
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

        private void YhteydenottojenhallintatoolStripMenuItem_Click(object sender, EventArgs e)
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

        private void KayttajatilienHallinta_Load(object sender, EventArgs e)
        {
            KayttajatDG.DataSource = ad.fetchInformation(); // Kutsutaan ADMINKAYTHALLINTA CLASS.ssa olevaa funktiota, joka hakee tietokannasta tiedot niille varatulle aluelle
            KayttajatDG.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            var datagridview = new DataGridView();
            datagridview.RowTemplate.MinimumHeight = 125;
            string salattu = KayttajatDG.Columns[9].ToString();
            MessageBox.Show($"{salattu}");
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

        private void KayttajatDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            KaytTunnusTB.Text = KayttajatDG.CurrentRow.Cells[0].Value.ToString();
        }

        private void PoistaBT_Click(object sender, EventArgs e)
        {
            string ktun;
            try
            {
                ktun = KaytTunnusTB.Text.ToString();
                if (ktun.Equals(""))
                {
                    MessageBox.Show($"Valitse käyttäjä taulukosta ja tuplaklikka, jotta käyttäjätunnus siirtyyy tekstikenttään");
                }
                else
                {
                    bool vastaus = ad.deleteKayttaja(ktun);
                    if (vastaus==true)
                    {
                        MessageBox.Show($"Käyttäjä poistettu.");
                    }
                    else
                    {
                        MessageBox.Show($"Käyttäjän poisto epäonnistui");
                    }
                    KayttajatDG.DataSource = ad.fetchInformation();
                    KaytTunnusTB.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
