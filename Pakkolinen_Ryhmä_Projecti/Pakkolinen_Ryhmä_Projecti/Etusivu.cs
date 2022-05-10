using System;
using System.Windows;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;


namespace Pakkolinen_Ryhmä_Projecti
{
    public partial class Etusivu : Form

    {
        
        public Etusivu()
        {
            InitializeComponent();
        }

        void f1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();

        }
        private void rekistrToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            Rekistreidy re = new Rekistreidy();
            re.FormClosing += f1_FormClosing;
            re.Show();
            this.Hide();
        }
       
        private void galleriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Galleria ga = new Galleria();
            ga.FormClosing += f1_FormClosing;
            ga.Show();
            this.Hide();
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

        Yhdista yh = new Yhdista();
        Tiedansyotto ti = new Tiedansyotto();
        List<byte[]> bytekuva = new List<byte[]>();
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
        
            MemoryStream mstream = new MemoryStream(bytekuva[random.Next(a)]);
            EtusivuKuvaPB.Image = Image.FromStream(mstream);
        }
        int a = 0;
        private void Etusivu_Load(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT ladattavat_tiedostot.Tiedosto FROM galleria INNER JOIN ladattavat_tiedostot on ladattavat_tiedostot.LadattavatID = galleria.LadattavatID", yh.otaYhteys());
            yh.avaaYhteys();
            MySqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            
            while (dr.Read())
            {
                bytekuva.Add((byte[])dr[0]);
                a++;
            }
            yh.suljeYhteys();
            MemoryStream mstream = new MemoryStream(bytekuva[0]);
            EtusivuKuvaPB.Image = Image.FromStream(mstream);
            timer1.Enabled = true;
        }
    }
}