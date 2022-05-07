﻿using System;
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
    public partial class PalautteenHallinta : Form
    {
        ADMINYHTOTTOJAPALAUTE ad = new ADMINYHTOTTOJAPALAUTE();
        public PalautteenHallinta()
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

        private void PaHallintadataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex != PoistaColumn.Index)
                {
                    return;
                }
                else
                {
                    try
                    {
                        string yTun = PaHallintadataGridView.CurrentRow.Cells[1].Value.ToString();
                        if (yTun.Equals(""))
                        {
                            MessageBox.Show($"Et ole valinnut poistettavaa kohdetta.");
                        }
                        else
                        {
                            bool poisto = ad.poistaPalaute(yTun);
                            if (poisto == true)
                            {
                                MessageBox.Show($"Poisto suoritettu.");
                            }
                            else
                            {
                                MessageBox.Show($"Poisto ei onnistunut.");
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
        }

        private void PalautteenHallinta_Load(object sender, EventArgs e)
        {
            PaHallintadataGridView.DataSource = ad.haeYhtotot(); // Kutsutaan ADMINYHTOTTOJAPALAUTE CLASS.ssa olevaa funktiota, joka hakee tietokannasta tiedot niille varatulle aluelle
            if (PaHallintadataGridView.DataSource == null)
            {
                MessageBox.Show($"Virhe tietokannan kanssa.");
            }
            else
            {
                PaHallintadataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                var datagridview = new DataGridView();
                datagridview.RowTemplate.MinimumHeight = 125;
            }
        }
    }
}
