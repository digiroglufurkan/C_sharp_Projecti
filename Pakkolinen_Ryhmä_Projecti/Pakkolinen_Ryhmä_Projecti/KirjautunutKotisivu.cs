using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace Pakkolinen_Ryhmä_Projecti
{
    public partial class KirjautunutKotisivu : Form
    {
        string tun;
        KotisivuClass kot = new KotisivuClass();
        public KirjautunutKotisivu()
        {
            InitializeComponent();
            tun = Kirjaudu.ktun;
        }

        void f1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        //private void kotisivuLatauksetToolStripMenuItem_Click(object sender, EventArgs e)
      

        private void kotisivuLatauksetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KirjautunutLataukset kirLat = new KirjautunutLataukset();
            kirLat.FormClosing += f1_FormClosing;
            kirLat.Show();
            this.Hide();
        }

        private void ksKotisivuJaaTiedostoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KirjautunutJaaTiedosto kirJaa = new KirjautunutJaaTiedosto();
            kirJaa.FormClosing += f1_FormClosing;
            kirJaa.Show();
            this.Hide();
        }

        private void ksKotisivuKeskustelupalstaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KeskusteluPalsta kesPal = new KeskusteluPalsta();
            kesPal.FormClosing += f1_FormClosing;
            kesPal.Show();
            this.Hide();
        }

        private void ksKotisivuPalauteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KirjautunutPalaute kirPal = new KirjautunutPalaute();
            kirPal.FormClosing += f1_FormClosing;
            kirPal.Show();
            this.Hide();
        }

        private void ksKirjauduUlosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            Etusivu etuSiv = new Etusivu();
            etuSiv.Show();
            etuSiv.FormClosing += f1_FormClosing;
            this.Hide();
            
        }

        private void ksMuokkaaProfiiliaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KirjautunutMuokkaaProfiilia muoPro = new KirjautunutMuokkaaProfiilia();
            muoPro.Show();
            muoPro.FormClosing += f1_FormClosing;
            this.Hide();
        }

        private void ksVaihdaSalasanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalasananVaihto salVai = new SalasananVaihto();
            salVai.Show();
            salVai.FormClosing += f1_FormClosing;
            this.Hide();
        }

        private void KirjautunutKotisivu_Load(object sender, EventArgs e)
        {
            ksKotisivuDG.DataSource = kot.haeUudet();
            ksKotisivuDG.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void ksKotisivuDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == LataaCo.Index) // mikäli klikataan poista-buttonia
            {
                try // aloitetaan try:lla
                {   // Otetaan id kentästä yksilöivä tunnus
                    int yTun = int.Parse(ksKotisivuDG.CurrentRow.Cells[1].Value.ToString());
                    if (yTun.Equals("")) // kokeillaan onko saatu talteen id tieto
                    {   // virheviesti
                        MessageBox.Show($"Et ole valinnut ladattavaa kohdetta.");
                    }
                    else
                    {   //Kutsutaan ADMINMITAUUTTA CLASS.ssa olevaa metodia, joka poistaa tiedoston tietokannasta
                        bool poisto = kot.lataaUusi(yTun); //lähetetään id ja otetaan paluu parametrinä bool-arvo
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
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message} v1");
                }
            }
            else
            {
                return;
            }
        }
    }
}
