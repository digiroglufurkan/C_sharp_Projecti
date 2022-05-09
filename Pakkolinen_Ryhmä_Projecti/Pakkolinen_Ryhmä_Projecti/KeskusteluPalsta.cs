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

namespace Pakkolinen_Ryhmä_Projecti
{
    public partial class KeskusteluPalsta : Form
    {

        Yhdista yhteys = new Yhdista();
        //MySqlConnection con = new MySqlConnection;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt = new DataTable();
        public KeskusteluPalsta()
        {
            InitializeComponent();
            // properties
            kommenttiDG.ColumnCount = 2;
            kommenttiDG.Columns[0].Name = "KAYTTAJA_TUNNUS";
            kommenttiDG.Columns[1].Name = "KOMMENTTI";

            kommenttiDG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // selection
            kommenttiDG.SelectionMode= DataGridViewSelectionMode.FullRowSelect;
            kommenttiDG.MultiSelect = false;
        }

        // insert
        private void add(string name, string com)
        {
            string sql = "INSERT INTO keskustelualue(KAYTTAJA_TUNNUS, KOMMENTTI) VALUES(@kayttis, @kommentti)";
                cmd = new MySqlCommand(sql);
            
            try
            {
                yhteys.avaaYhteys();
                if(cmd.ExecuteNonQuery()>0)
                {
                    MessageBox.Show("Kommenttisi on lähetetty.");
                }
                yhteys.suljeYhteys();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                yhteys.suljeYhteys();
            }
        }

        private void populate(String name, String kommentti)
        {
            kommenttiDG.Rows.Add(name, kommentti);
        }
        //retrieve
        private void retrieve()
        {
            kommenttiDG.Rows.Clear();

            string sql = "SELECT * FROM keskustelualue ";
            cmd = new MySqlCommand(sql);
            try
            {
                yhteys.avaaYhteys();

                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    populate(row[0].ToString(), row[1].ToString());
                }

                yhteys.suljeYhteys();

                dt.Rows.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                yhteys.suljeYhteys();
            }
        }



        void f1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void ksKeskusteluKotisivuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KirjautunutKotisivu kirKotisivu = new KirjautunutKotisivu();
            kirKotisivu.FormClosing += f1_FormClosing;
            kirKotisivu.Show();
            this.Hide();
        }

        private void ksKotisivuLatauksetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KirjautunutLataukset kirLat = new KirjautunutLataukset();
            kirLat.FormClosing += f1_FormClosing;
            kirLat.Show();
            this.Hide();
        }

        private void ksKotisivuJaaTiedostoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KirjautunutJaaTiedosto kirJaa = new KirjautunutJaaTiedosto();
            kirJaa.FormClosing += f1_FormClosing;
            kirJaa.Show();
            this.Hide();
        }

        private void ksKotisivuPalauteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KirjautunutPalaute kirPal = new KirjautunutPalaute();
            kirPal.FormClosing += f1_FormClosing;
            kirPal.Show();
            this.Hide();
        }

        private void ksMuokkaaProfiiliaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KirjautunutMuokkaaProfiilia kirPro = new KirjautunutMuokkaaProfiilia();
            kirPro.FormClosing += f1_FormClosing;
            kirPro.Show();
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


    }
}
