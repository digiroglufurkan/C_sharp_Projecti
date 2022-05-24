using System;
using System.Collections.Generic;
using System.ComponentModel;
using MySql.Data.MySqlClient; // pitää muistaa lisätä
using System.Data; // pitää muistaa lisätä
using System.Data.SqlClient; // pitää muistaa lisätä
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// author@ Antti Kuusisto
/// version 23.5.2022
/// <summary>
/// Toimii jotenkin. Hieman muokattava hakukyselyitä.
/// </summary>
namespace Catering_Projectin
{
    public partial class AdminTyotilanne : Form
    {
        Yhdista yh = new Yhdista();
        ADMINTYOTILANNEHALLINTA adTyTiHa = new ADMINTYOTILANNEHALLINTA();
        ADMINTILAUKSET adTi = new ADMINTILAUKSET(); // hyödynnetään jo muualla käytettävää class:a
        public AdminTyotilanne()
        {
            InitializeComponent();
        }

        void formClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();

        }
        private void KotisivuTSMI_Click(object sender, EventArgs e)
        {
            AdminKotisivu adKo = new AdminKotisivu();
            adKo.FormClosing += formClosing;
            adKo.Show();
            this.Hide();
        }

        private void SaatavuudetTSMI_Click(object sender, EventArgs e)
        {
            AdminSaatavuudet adSa = new AdminSaatavuudet();
            adSa.FormClosing += formClosing;
            adSa.Show();
            this.Hide();
        }

        private void TyotilanneTSMI_Click(object sender, EventArgs e)
        {
            AdminTyotilanne adTy = new AdminTyotilanne();
            adTy.FormClosing += formClosing;
            adTy.Show();
            this.Hide();
        }
        private void KayttajatTSMI_Click(object sender, EventArgs e)
        {
            AdminKayttajaHallinta adKaHa = new AdminKayttajaHallinta();
            adKaHa.FormClosing += formClosing;
            adKaHa.Show();
            this.Hide();
        }
        private void SalasanojenHallintaTSMI_Click(object sender, EventArgs e)
        {
            AdminSalasananHallinta adSaHa = new AdminSalasananHallinta();
            adSaHa.FormClosing += formClosing;
            adSaHa.Show();
            this.Hide();
        }

        private void MuokkaaProfiiliaTSMI_Click(object sender, EventArgs e)
        {
            AdminMuokkaaProfiilia adMuPr = new AdminMuokkaaProfiilia();
            adMuPr.FormClosing += formClosing;
            adMuPr.Show();
            this.Hide();
        }

        private void VaihdaSalasanaTSMI_Click(object sender, EventArgs e)
        {
            AdminSalasananVaihto adSaVa = new AdminSalasananVaihto();
            adSaVa.FormClosing += formClosing;
            adSaVa.Show();
            this.Hide();
        }

        private void KirjauduUlosTSMI_Click(object sender, EventArgs e)
        {
            Etusivu etu = new Etusivu();
            etu.FormClosing += formClosing;
            etu.Show();
            this.Hide();
        }

        // Toiminta, kun sivu ladataan
        private void AdminTyotilanne_Load(object sender, EventArgs e)
        {
            TyotilanneDGV.DataSource = adTyTiHa.haeTilanne();//DGV:n täyttö
            TyotilanneDGV.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);// datagridview:n muotoilua
            //hyödynnetään etusivulle tilaukset hakevaa metodia
            TilauksetDGV.DataSource = adTi.haeTilaukset();
            TilauksetDGV.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            //Mahdollistetaan valinta riviltä
            TilauksetDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //TilauksetDGV.
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT KayttajaTunnus FROM kayttajat WHERE RoolitID = 3", yh.otaYhteys());
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Tun");
                TekijaCo.DisplayMember = "KayttajaTunnus";
                TekijaCo.ValueMember = "KayttajaTunnus";
                TekijaCo.DataSource = ds.Tables["Tun"];
                //DataTable tbl = new DataTable();
                //adapter.Fill(tbl);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            /*TekijaCo.DataSource = adTyTiHa.haeKokit();
            TekijaCo.ValueMember = TekijaCo.Kayttajat.ToString();
            TekijaCo.DisplayMember = TekijaCo.ValueMember;*/
        }
       
        private void TilauksetDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { // /*
            try
            {   // mikäli painetaan varaa - button:a
                if (e.ColumnIndex == MaaraaCo.Index)
                {
                    TekijaCo.Visible = true; // kayttäjätunnus TB näkyviin
                    VahMaCo.Visible = true; // vahvistus BT näkyviin
                }
                // mikäli painetaan varauksen vahvistusta
                else if (e.ColumnIndex == VahMaCo.Index)
                    try
                    {
                        // muuttuja datagridvievw:n riville
                        DataGridViewRow row = new DataGridViewRow();
                        // napin rivin lisäys muuttujaan
                        row = TilauksetDGV.SelectedRows[0];
                        // tarkistetaan, että on syötetty varattava määrä
                        if (row.Cells[1].Value != null)
                        {
                            // varausmäärä muuttujaan
                            string ktun = row.Cells[1].Value.ToString();
                            //TilausID muuttujaan
                            int id = int.Parse(row.Cells[3].Value.ToString());
                            // määrän ja id:n lähetys class:n
                            bool varaus = adTyTiHa.maaraaTyo(ktun, id);
                            // mikäli varaus onnistui
                            if (varaus == true)
                            {
                                // DGV:n päivitys
                                TilauksetDGV.DataSource = adTyTiHa.haeTilanne();
                                // Varausmäärä TB piiloon
                                TekijaCo.Visible = false;
                                // Vahvista varaus BT piiloon
                                VahMaCo.Visible = false;
                            }
                            else // viesti, että varaus ei onnistunut
                            {
                                MessageBox.Show($"Työn määrääminen ei onnistunut.");
                            }
                        }
                        else // viesti ettei ole valittu varattavaa määrää
                        {
                            MessageBox.Show($"Et syöttänyt käyttäjä tunnusta!");
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"{ex.Message} v2");
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} v1");
            }
            // */
        }
          
        private void TyotilanneDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
