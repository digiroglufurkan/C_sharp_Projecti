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
using System.Text.RegularExpressions; // poista

namespace Pakkolinen_Ryhmä_Projecti
{
    public partial class KirjautunutPalaute : Form
    {
        string tun;
        KirjautunutPalauteClass pal = new KirjautunutPalauteClass();
        Yhdista yhteys = new Yhdista();
        public KirjautunutPalaute()
        {
            InitializeComponent();
            tun = Kirjaudu.ktun;
        }

        void f1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void ksJaaTiedostoKotisivuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KirjautunutKotisivu kirKot = new KirjautunutKotisivu();
            kirKot.FormClosing += f1_FormClosing;
            kirKot.Show();
            this.Hide();
        }

        private void ksJaaTiedostoLatauksetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KirjautunutLataukset kirLat = new KirjautunutLataukset();
            kirLat.FormClosing += f1_FormClosing;
            kirLat.Show();
            this.Hide();
        }

        private void ksJaaTiedostoJaaTiedostoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KirjautunutJaaTiedosto kirJaa = new KirjautunutJaaTiedosto();
            kirJaa.FormClosing += f1_FormClosing;
            kirJaa.Show();
            this.Hide();
        }

        private void ksJaaTiedostoKeskustelupalstaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KeskusteluPalsta kesPalsta = new KeskusteluPalsta();
            kesPalsta.FormClosing += f1_FormClosing;
            kesPalsta.Show();
            this.Hide();
        }

        private void muokkaaProfiiliaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KirjautunutMuokkaaProfiilia muoProf = new KirjautunutMuokkaaProfiilia();
            muoProf.FormClosing += f1_FormClosing;
            muoProf.Show();
            this.Hide();
        }

        private void ksVaihdaSalasanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalasananVaihto salVai = new SalasananVaihto();
            salVai.FormClosing += f1_FormClosing;
            salVai.Show();
            this.Hide();
        }

        private void ksKirjauduUlosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Etusivu etuSiv = new Etusivu();
            etuSiv.FormClosing += f1_FormClosing;
            etuSiv.Show();
            this.Hide();
        }

        private void ksJaaTiedostoAsetuksetToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void palauteLahetaBT_Click(object sender, EventArgs e)
        {
            try
            {
                string palaute = palauteTB.Text.ToString();
                if (palaute.Equals(""))
                {
                    MessageBox.Show("Kirjoita palaute!");
                }
                else
                {
                    bool pala = pal.palauteJuttu(palaute, tun); 
                    if (pala == true)
                    {
                        MessageBox.Show("Palaute lähetetty! :)");
                        palauteTB.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Palaute ei mennyt eteenpäin! :(");
                    }
                }
            }
            catch (Exception ex) // virheen poiminta ja näyttö
            {
                MessageBox.Show($"{ex.Message} virhe1");
            }
        }

        
    }
    }

