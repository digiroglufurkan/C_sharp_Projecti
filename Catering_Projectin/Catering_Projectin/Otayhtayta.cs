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
    public partial class Otayhtayta : Form
    {
        public Otayhtayta()
        {
            InitializeComponent();
        }

        private void OtLahetaBT_Click(object sender, EventArgs e)
        {
            if (tarkistaTextBox(OtEmailTB.Text, "Vaaditan Sahköposti osaite")) { goto loppu; };
            if (tarkistaTextBox(OtNimiTB.Text, "Vaaditan Nimisi ")) { goto loppu; };
            if (tarkistaTextBox(OtAiheTB.Text, "Vaaditan Aihe")) { goto loppu; };
            if (tarkistaTextBox(OtTekstiRTB.Text, "Vaaditan Teksti")) { goto loppu; };
            Tiedansyotto ti = new Tiedansyotto();
            /*if (ti.lisaOtayhtayta(OtEmailTB.Text, OtAiheTB.Text, OtTekstiRTB.Text, OtNimiTB.Text))
            {
                MessageBox.Show("Viestisi on vastaanotettu");
                OtEmailTB.Text = "";
                OtAiheTB.Text = "";
                OtTekstiRTB.Text = "";
                OtNimiTB.Text = "";
            }
            else
            {
                MessageBox.Show("Valittevasti  ei vastaanotettu");
            }*/
        loppu:;
        }

        private bool tarkistaTextBox(string a, string b, string c = "")
        {
            if (a == c)
            {
                MessageBox.Show(b);
                return true;
            }
            return false;
        }

        void f1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();

        }

        private void etusivuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Etusivu et = new Etusivu();
            et.Show();
            et.FormClosing += f1_FormClosing;
            this.Hide();

        }

        private void rekistrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rekisteroidy re = new Rekisteroidy();
            re.FormClosing += f1_FormClosing;
            re.Show();
            this.Hide();
        }

        private void kirjaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kirjaudu ki = new Kirjaudu();
            ki.FormClosing += f1_FormClosing;
            ki.Show();
            this.Hide();
        }


    }
}