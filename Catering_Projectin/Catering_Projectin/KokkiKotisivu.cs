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

namespace Catering_Projectin
{
    public partial class KokkiKotisivu : Form
    {
        Yhdista yhteys = new Yhdista();
        KokkiTyoTilanne tilanne = new KokkiTyoTilanne();
        public KokkiKotisivu()
        {
            InitializeComponent();
        }
        void f1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void kokkiruoatMS_Click(object sender, EventArgs e)
        {
            KokkiRuoat ruoka = new KokkiRuoat();
            ruoka.FormClosing += f1_FormClosing;
            ruoka.Show();
            this.Hide();
        }

        private void kokkiprofMS_Click(object sender, EventArgs e)
        {
            KokkiProfiilinMuokkaus kokkiprof = new KokkiProfiilinMuokkaus();
            kokkiprof.FormClosing += f1_FormClosing;
            kokkiprof.Show();
            this.Hide();
        }

        private void kokkisalisMS_Click(object sender, EventArgs e)
        {
            KokkiSalasananVaihto kokkisalis = new KokkiSalasananVaihto();
            kokkisalis.FormClosing += f1_FormClosing;
            kokkisalis.Show();
            this.Hide();
        }

        private void kokkiulosMS_Click(object sender, EventArgs e)
        {
            Etusivu kokkiulos = new Etusivu();
            kokkiulos.FormClosing += f1_FormClosing;
            kokkiulos.Show();
            this.Hide();
        }

        private void koktilanneDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void KokkiKotisivu_Load(object sender, EventArgs e)
        {
            koktilanneDG.DataSource = tilanne.tyoTilanne();
            koktilanneDG.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            kokTilauksetDG.DataSource = tilanne.tilausTilanne();
            kokTilauksetDG.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            statusInfoDG.DataSource = tilanne.statusInfo();
            statusInfoDG.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            try
            {
                MySqlCommand komento = new MySqlCommand("SELECT TilausID FROM tyotilanne", yhteys.otaYhteys());
                MySqlDataAdapter adapteri = new MySqlDataAdapter();
                adapteri.SelectCommand = komento;
                DataTable dt = new System.Data.DataTable();
                adapteri.Fill(dt);
                tilausCB.DisplayMember = "TilausID";
                tilausCB.ValueMember = "TilausID";
                tilausCB.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                MySqlCommand komento = new MySqlCommand("SELECT StatusID FROM status", yhteys.otaYhteys());
                MySqlDataAdapter adapteri = new MySqlDataAdapter();
                adapteri.SelectCommand = komento;
                DataTable dt = new System.Data.DataTable();
                adapteri.Fill(dt);
                statusCB.DisplayMember = "StatusID";
                statusCB.ValueMember = "StatusID";
                statusCB.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tilausCB_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void tilanneBT_Click(object sender, EventArgs e)
        {
            string tilaus = "Työtilaukset";
            string status = "Status";
            try
            {
                tilaus = tilausCB.Text.ToString(); 
                status = statusCB.Text.ToString(); 
                if (tilaus.Equals("") || status.Equals("")) 
                {
                    MessageBox.Show("Tarkasta kentät!");
                }

                else
                {   
                    bool paivitys = tilanne.paivitaTilanne(tilaus, status);
                    if (paivitys == true) 
                    {
                        MessageBox.Show("Status päivitetty!");
                        koktilanneDG.DataSource = tilanne.tyoTilanne();
                        kokTilauksetDG.DataSource = tilanne.tilausTilanne();
                    }
                    else
                    {
                        MessageBox.Show("Päivitys epäonnistui!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void statusInfoDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void statusCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }

