using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catering_Projectin
{
    public partial class AdminMuokkaaProfiilia : Form
    {
        public AdminMuokkaaProfiilia()
        {
            InitializeComponent();
        }
        void formClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();

        }
        private void KotisivuTSMI_Click(object sender, EventArgs e)
        {
            AdminKotisivu adKo = new AdminKotisivu();
            adKo.FormClosing += formClosing;
            adKo.Show();
            this.Hide();
        }

        private void SaatavuudetTSMI_Click(object sender, EventArgs e)
        {
            AdminSaatavuudet adSa = new AdminSaatavuudet();
            adSa.FormClosing += formClosing;
            adSa.Show();
            this.Hide();
        }

        private void TyotilanneTSMI_Click(object sender, EventArgs e)
        {
            AdminTyotilanne adTy = new AdminTyotilanne();
            adTy.FormClosing += formClosing;
            adTy.Show();
            this.Hide();
        }
        private void KayttajatTSMI_Click(object sender, EventArgs e)
        {
            AdminKayttajaHallinta adKaHa = new AdminKayttajaHallinta();
            adKaHa.FormClosing += formClosing;
            adKaHa.Show();
            this.Hide();
        }
        private void salasanojenHallintaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminSalasananHallinta adSaHa = new AdminSalasananHallinta();
            adSaHa.FormClosing += formClosing;
            adSaHa.Show();
            this.Hide();
        }

        private void muokkaaProfiiliaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminMuokkaaProfiilia adMuPr = new AdminMuokkaaProfiilia();
            adMuPr.FormClosing += formClosing;
            adMuPr.Show();
            this.Hide();
        }

        private void vaihdaSalasanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminSalasananVaihto adSaVa = new AdminSalasananVaihto();
            adSaVa.FormClosing += formClosing;
            adSaVa.Show();
            this.Hide();
        }

        private void kirjauduUlosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Etusivu etu = new Etusivu();
            etu.FormClosing += formClosing;
            etu.Show();
            this.Hide();
        }


    }
}
