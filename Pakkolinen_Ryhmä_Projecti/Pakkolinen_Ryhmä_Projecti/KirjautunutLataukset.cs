using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pakkolinen_Ryhmä_Projecti
{
    public partial class KirjautunutLataukset : Form
    {
        string tun;
        KirjautunutLatauksetClass lataus = new KirjautunutLatauksetClass();
        public KirjautunutLataukset()
        {
            InitializeComponent();
            tun = Kirjaudu.ktun;
        }

        void f1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void ksLatauksetKotisivuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KirjautunutKotisivu kirKot = new KirjautunutKotisivu();
            kirKot.FormClosing += f1_FormClosing;
            kirKot.Show();
            this.Hide();
        }

        private void ksLatauksetJaaTiedostoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KirjautunutJaaTiedosto kirJaa = new KirjautunutJaaTiedosto();
            kirJaa.FormClosing += f1_FormClosing;
            kirJaa.Show();
            this.Hide();
        }

        private void ksLatauksetKeskustelupalstaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KeskusteluPalsta kesPal = new KeskusteluPalsta();
            kesPal.FormClosing += f1_FormClosing;
            kesPal.Show();
            this.Hide();
        }

        private void ksLatauksetPalauteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KirjautunutLataukset kirLat = new KirjautunutLataukset();
            kirLat.FormClosing += f1_FormClosing;
            kirLat.Show();
            this.Hide();
        }

        private void ksMuokkaaProfiiliaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KirjautunutMuokkaaProfiilia kirPro = new KirjautunutMuokkaaProfiilia();
            kirPro.FormClosing += f1_FormClosing;
            kirPro.Show();
            this.Hide();
        }

        private void ksVaihdaSalasanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalasananVaihto salVaihto = new SalasananVaihto();
            salVaihto.FormClosing += f1_FormClosing;
            salVaihto.Show();
            this.Hide();
        }

        private void ksKirjauduUlosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Etusivu etuSiv = new Etusivu();
            etuSiv.FormClosing += f1_FormClosing;
            etuSiv.Show();
            this.Hide();
        }

        private void ksLatauksetDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (e.ColumnIndex == latausColumn.Index)
                {
                    try
                    {
                        int yktunnus = int.Parse(ksLatauksetDG.CurrentRow.Cells[1].Value.ToString());
                        if (yktunnus.Equals(""))
                        {
                            MessageBox.Show("Et ole valinnut tiedostoa!");
                        }
                        else
                        {
                            bool lataa = lataus.kirjautunutLataa(yktunnus);
                            if (lataa == true)
                            {
                                MessageBox.Show("Tiedosto ladattu!");
                            }
                            else
                            {
                                MessageBox.Show("Tiedostoa ei voitu ladata!");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"{ex.Message} v3");
                    }
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} v1");
            }
            }


        private void ksLatauksetDG_Click(object sender, EventArgs e)
        {

        }

        private void KirjautunutLataukset_Load(object sender, EventArgs e)
        {
            ksLatauksetDG.DataSource = lataus.haeTiedostot();
            //ksLatauksetDG.AutoResizeColumn(DataGridViewAutoSizeColumnMode.AllCells);
            var datagridview = new DataGridView();
            datagridview.RowTemplate.MinimumHeight = 100;
        }
    }
}

