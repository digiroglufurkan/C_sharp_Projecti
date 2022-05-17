﻿using System;
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
    public partial class KokkiSalasananVaihto : Form
    {
        public KokkiSalasananVaihto()
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

        private void kokkiruoatMS_Click(object sender, EventArgs e)
        {
            KokkiRuoat kokkiruoka = new KokkiRuoat();
            kokkiruoka.FormClosing += f1_FormClosing;
            kokkiruoka.Show();
            this.Hide();
        }

        private void kokkiprofMS_Click(object sender, EventArgs e)
        {
            KokkiProfiilinMuokkaus kokkiprof = new KokkiProfiilinMuokkaus();
            kokkiprof.FormClosing += f1_FormClosing;
            kokkiprof.Show();
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
