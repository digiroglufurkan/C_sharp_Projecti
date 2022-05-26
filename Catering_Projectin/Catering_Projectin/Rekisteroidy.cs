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
    public partial class Rekisteroidy : Form
    {
        public Rekisteroidy()
        {
            InitializeComponent();
        }

        void f1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void Rekisteroidy_Load(object sender, EventArgs e)
        {

        }

        private void reketusivuMS_Click(object sender, EventArgs e)
        {
            Etusivu etusivu = new Etusivu();
            etusivu.FormClosing += f1_FormClosing;
            etusivu.Show();
            this.Hide();
        }

        private void rekkirjauduMS_Click(object sender, EventArgs e)
        {

        }

        private void rekisteroidyBT_Click(object sender, EventArgs e)
        {
        }
    }
}
