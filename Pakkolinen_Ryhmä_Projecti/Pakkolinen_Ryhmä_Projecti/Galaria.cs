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
using System.IO;

namespace Pakkolinen_Ryhmä_Projecti
{
    public partial class Galleria : Form
    {
        public Galleria()
        {
            InitializeComponent();
        }

        void f1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();

        }


        private void kirjaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kirjaudu ki = new Kirjaudu();
            ki.FormClosing += f1_FormClosing;
            ki.Show();
            this.Hide();

        }
        private void otaYhteyttäToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Otayhtayta ota = new Otayhtayta();
            ota.FormClosing += f1_FormClosing;
            ota.Show();
            this.Hide();
        }

        private void rekistroidyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rekistreidy re = new Rekistreidy();
            re.FormClosing += f1_FormClosing;
            re.Show();
            this.Hide();
        }

        private void etusivuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Etusivu et = new Etusivu();
            et.Show();
            et.FormClosing += f1_FormClosing;
            this.Hide();
        }
        Yhdista yh = new Yhdista();
        Tiedansyotto ti = new Tiedansyotto();
        private void Galleria_Load(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT kuva FROM `galleria`", yh.otaYhteys());
            yh.avaaYhteys();
            MySqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            List<byte[]> bytekuva = new List<byte[]>();
            while (dr.Read())
            {
               bytekuva.Add((byte[])dr[0]);
                
            }
            yh.suljeYhteys();
            MemoryStream mstream = new MemoryStream(bytekuva[0]);
            pictureBox1.Image = Image.FromStream(mstream);
            mstream = new MemoryStream(bytekuva[1]);
            pictureBox2.Image = Image.FromStream(mstream);
            mstream = new MemoryStream(bytekuva[2]);
            pictureBox3.Image = Image.FromStream(mstream);
          

        }
    }
}
