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
/// Toimii. Vielä voisi mikäli on aikaa, niin lisätä sähköpostin lähetyksen - button:n.
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

        private void YhteydenottojenhallintatoolStripMenuItem_Click(object sender, EventArgs e)
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

        // Ladataan käyttäjät DatagridVievw:n
        private void KayttajatilienHallinta_Load(object sender, EventArgs e)
        {
            KayttajatDG.DataSource = ad.fetchInformation(); // Kutsutaan ADMINKAYTHALLINTA CLASS.ssa olevaa funktiota, joka hakee tietokannasta tiedot niille varatulle aluelle
            KayttajatDG.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            var datagridview = new DataGridView();
            datagridview.RowTemplate.MinimumHeight = 200;
            DataGridViewImageColumn kuvat = new DataGridViewImageColumn();
            kuvat = (DataGridViewImageColumn)KayttajatDG.Columns[13];
            kuvat.ImageLayout = DataGridViewImageCellLayout.Stretch;
            try
            {

            }
            catch (Exception ex)
            {

            }
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

        // Toiminta DataGridVievw:ssä
        private void KayttajatDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // muuttuja käyttäjä tunnukselle
                string yTun = KayttajatDG.CurrentRow.Cells[3].Value.ToString();
                if (e.ColumnIndex == PoistaColumn.Index) // mikäli poistetaan käyttäjä
                {             
                    try
                    {
                        if (yTun.Equals(""))
                        {
                            MessageBox.Show($"Et ole valinnut poistettavaa kohdetta.");
                        }
                        else
                        {
                            // kutsutaan poisto metodia
                            bool poisto = ad.deleteKayttaja(yTun);
                            if (poisto == true)
                            {
                                MessageBox.Show($"Poisto suoritettu.");
                            }
                            else
                            {
                                MessageBox.Show($"Poisto ei onnistunut.");
                            }
                            // päivitetään datagridvievw
                            KayttajatDG.DataSource = ad.fetchInformation();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (e.ColumnIndex == LiAdminColumn.Index) // mikäli annetaan adminin oikeudet
                {
                    try
                    {
                        if (yTun.Equals(""))
                        {
                            MessageBox.Show($"Et ole valinnut lisättävää kohdetta.");
                        }
                        else
                        {
                            // kutsutaan metodia antamaan adminin oikeudet
                            bool poisto = ad.lisaaAdmin(yTun);
                            if (poisto == true)
                            {
                                MessageBox.Show($"Adminin lisäys suoritettu.");
                            }
                            else
                            {
                                MessageBox.Show($"Adminin lisäys ei onnistunut.");
                            }
                            // päivitetään datagridvievw
                            KayttajatDG.DataSource = ad.fetchInformation();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (e.ColumnIndex == PoistaAdminColumn.Index) // mikäli poistetaan adminin oikeudet
                {
                    try
                    {
                        if (yTun.Equals(""))
                        {
                            MessageBox.Show($"Et ole valinnut poistettavaa kohdetta.");
                        }
                        else
                        {
                            // kutsutaan metodia poistamaan adminin oikeudet
                            bool poisto = ad.poistaAdmin(yTun);
                            if (poisto == true)
                            {
                                MessageBox.Show($"Adminin poisto suoritettu.");
                            }
                            else
                            {
                                MessageBox.Show($"Adminin poisto ei onnistunut.");
                            }
                            // päivitetään datagridvievw
                            KayttajatDG.DataSource = ad.fetchInformation();
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
