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
    public partial class KokkiRuoat : Form
    {
        KokinVarasto varasto = new KokinVarasto();
        public KokkiRuoat()
        {
            InitializeComponent();
        }

        void f1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void kokkikotiMS_Click(object sender, EventArgs e)
        {
            KokkiKotisivu kokkikoti = new KokkiKotisivu();
            kokkikoti.FormClosing += f1_FormClosing;
            kokkikoti.Show();
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

        private void KokkiRuoat_Load(object sender, EventArgs e)
        {
            kokkiruoatDG.DataSource = varasto.ruokaSaldo();
            kokkiruoatDG.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            kokkiruoatDG.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            kokkijuomatDG.DataSource = varasto.juomaSaldo();
            kokkijuomatDG.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            kokkijuomatDG.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            kokkialkoDG.DataSource = varasto.alkoSaldo();
            kokkialkoDG.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            kokkialkoDG.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void kokkijuomatDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
    



        }

        private void kokkialkoDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
