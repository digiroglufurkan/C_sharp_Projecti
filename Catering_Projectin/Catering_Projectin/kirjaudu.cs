using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;
using System.IO;
/// version 9.5.2022
/// <summary>
/// Kommentoitu miten luetaan kirjautumisessa käyttäjätunnus.
/// </summary>
namespace Catering_Projectin
{
    public partial class Kirjaudu : Form
    {
        public static string ktun = ""; // muuttuja adminin käyttäjä tunnukselle
        public Kirjaudu()
        {
            InitializeComponent();
        }
        void f1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();

        }

        Yhdista yh = new Yhdista();
        Tiedansyotto ti = new Tiedansyotto();

        private void KirjoiduBT_Click(object sender, EventArgs e)
        {
           
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT `Etunimi`,`Salasana`,`RoolitID`,`KayttajaID` FROM `kayttajat` WHERE  KayttajaTunnus= '" + KiTunnusTB.Text + "'", yh.otaYhteys());
                yh.avaaYhteys();
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                string sal = (String)dr.GetValue(1);
                if (KiSalasanaTB.Text == ti.Decrypt(sal))
                {
                    if (1 == Convert.ToInt32(dr.GetValue(2))) // tarkista etta onko kayttaja admin tai ei
                    {
                        
                        AdminKotisivu ki = new AdminKotisivu();
                        ki.Ktun = KiTunnusTB.Text.ToString(); // Luetaan käyttäjä tunnus muuttujaan.
                        ki.FormClosing += f1_FormClosing;
                        
                        ki.Show();
                        this.Hide();
                    }
                    else if (2 == Convert.ToInt32(dr.GetValue(2)))
                    {
                        ktun = KiTunnusTB.Text;
                        KayttajanKotisivu ka = new KayttajanKotisivu();
                        ka.kaNimi = dr.GetValue(0).ToString();
                        ka.kaID = dr.GetValue(3).ToString();
                        ka.FormClosing += f1_FormClosing;
                        ka.Show();
                        this.Hide();
                    }
                    else
                    {
                        ktun = KiTunnusTB.Text.ToString();
                        KokkiKotisivu ko = new KokkiKotisivu();
                        ko.FormClosing += f1_FormClosing;
                        ko.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Käyttajan Tunnus tai Salasana Värin");

                }
            }
            catch (Exception ex)
            {
                yh.suljeYhteys();
                MessageBox.Show(ex.Message);
            }
           
            yh.suljeYhteys();


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

        private void otaYhteyttäToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Otayhtayta ota = new Otayhtayta();
            ota.FormClosing += f1_FormClosing;
            ota.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;

        }
    }
}