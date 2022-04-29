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
/// version 27.4.2022
/// <summary>
/// Tehty suurinosa sivuista. Mietin vielä miten toteuttaa kohta asetukset, menustripitem vai combobox.
/// Tekeminen jatkuu kaikinpuolin myöhemmin tänään.
/// </summary>

namespace Pakkolinen_Ryhmä_Projecti
{
    public partial class KayttajatilienHallinta : Form
    {
        ADMINKAYTHALLINTA ad = new ADMINKAYTHALLINTA();
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
            KayttajatDG.DataSource = ad.fetchInformation(); // Kutsutaan OP CLASS.ssa olevaa funktiota, joka hakee tietokannasta tiedot niille varatulle aluelle
            KayttajatDG.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            var datagridview = new DataGridView();
            datagridview.RowTemplate.MinimumHeight = 125;
        }

        private void KayttajatDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bool delStudent = ad.deleteKayttaja(); // OP CLASS:ssa olevaa funktiota, joka poistaa opiilaan tiedot
            if (delStudent == true) // toiminta mikäli edellä kutsuttu funktio palauttaa OK
            {
                MessageBox.Show($"Kayttaja poistettu");// ilmoitus, että oppilas on poistettu
            }
            else // toiminta mikäli poisto ei onnistunut
            {
                MessageBox.Show($"Kayttaja ei pystytty poistamaan!"); // ilmoitus, että poisto ei onnistunut
            }
        }
    }
}
