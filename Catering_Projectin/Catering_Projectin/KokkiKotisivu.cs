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
    public partial class KokkiKotisivu : Form
    {
        public KokkiKotisivu()
        {
            InitializeComponent();
        }
        void f1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void kokkiruoatMS_Click(object sender, EventArgs e)
        {
            KokkiRuoat ruoka = new KokkiRuoat();
            ruoka.FormClosing += f1_FormClosing;
            ruoka.Show();
            this.Hide();
        }

        private void kokkiprofMS_Click(object sender, EventArgs e)
        {
            KokkiProfiilinMuokkaus kokkiprof = new KokkiProfiilinMuokkaus();
            kokkiprof.FormClosing += f1_FormClosing;
            kokkiprof.Show();
            this.Hide();
        }

        private void kokkisalisMS_Click(object sender, EventArgs e)
        {
            KokkiSalasananVaihto kokkisalis = new KokkiSalasananVaihto();
            kokkisalis.FormClosing += f1_FormClosing;
            kokkisalis.Show();
            this.Hide();
        }

        private void kokkiulosMS_Click(object sender, EventArgs e)
        {
            Etusivu kokkiulos = new Etusivu();
            kokkiulos.FormClosing += f1_FormClosing;
            kokkiulos.Show();
            this.Hide();
        }
    }
}
