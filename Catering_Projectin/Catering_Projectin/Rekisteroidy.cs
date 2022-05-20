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
            /* string lentoyhtio = reklentoTB.Text;
             string titteli = rektitteliTB.Text;
             string etunimi = reketuTB.Text;
             string sukunimi = reksukunimiTB.Text;  
             string email = rekemailTB.Text;
             string puhelin = rekpuhelinTB.Text;
             string osoite = rekosoiteTB.Text;
             string posti = rekpostiTB.Text;
             string toimi = rektoimiTB.Text;
             string icao = icaoTB.Text;
             if (etunimi.Equals("") || sukunimi.Equals("") || email.Equals("") || puhelin.Equals("") || osoite.Equals("") || posti.Equals("") || toimi.Equals("") || titteli.Equals(""))
             {
                 MessageBox.Show("Tarkista kentät!");
             }
             else if (lentoyhtio.Equals("") || icao.Equals(""))
             {
                 MessageBox.Show("Haluat siis rekisteröityä työntekijäksi?");
             }
             else
             {
                 MessageBox.Show("Haluat siis rekisteröityä käyttäjäksi?");
             }*/
        }
    }
}
