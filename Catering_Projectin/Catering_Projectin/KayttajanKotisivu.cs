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
    public partial class KayttajanKotisivu : Form
    {
        public KayttajanKotisivu()
        {
            InitializeComponent();
        }
        public string kaNimi;
        public string kaID;
        private void KayttajanKotisivu_Load(object sender, EventArgs e)
        {
            tervetuluaLB.Text = "Tervetulua " + kaNimi;
        }

        void formClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();

        }
        private void kotisivuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu me = new Menu();
            me.kaID = kaID;
            me.FormClosing += formClosing;
            me.Show();
            this.Hide();
        }
    }
}
