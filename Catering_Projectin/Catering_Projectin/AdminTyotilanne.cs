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
/// version 30.5.2022
/// <summary>
/// Uuden tilauksen määrääminen tehtäväksi
/// </summary>
namespace Catering_Projectin
{
    public partial class AdminTyotilanne : Form
    {
        Yhdista yh = new Yhdista();
        ADMINTYOTILANNEHALLINTA adTyTiHa = new ADMINTYOTILANNEHALLINTA();
        ADMINTILAUKSET adTi = new ADMINTILAUKSET(); // hyödynnetään jo muualla käytettävää class:a
        string uid = ""; // muuttuja käyttäjä tunnukselle
        private string ktun = string.Empty;
        public string Ktun
        {
            get { return ktun; }
            set { ktun = value; }
        }
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
            adKo.Ktun = uid;
            adKo.Show();
            this.Hide();
        }

        private void SaatavuudetTSMI_Click(object sender, EventArgs e)
        {
            AdminSaatavuudet adSa = new AdminSaatavuudet();
            adSa.FormClosing += formClosing;
            adSa.Ktun = uid;
            adSa.Show();
            this.Hide();
        }

        private void TyotilanneTSMI_Click(object sender, EventArgs e)
        {
            AdminTyotilanne adTy = new AdminTyotilanne();
            adTy.FormClosing += formClosing;
            adTy.Ktun = uid;
            adTy.Show();
            this.Hide();
        }
        private void KayttajatTSMI_Click(object sender, EventArgs e)
        {
            AdminKayttajaHallinta adKaHa = new AdminKayttajaHallinta();
            adKaHa.FormClosing += formClosing;
            adKaHa.Ktun = uid;
            adKaHa.Show();
            this.Hide();
        }
        private void SalasanojenHallintaTSMI_Click(object sender, EventArgs e)
        {
            AdminSalasananHallinta adSaHa = new AdminSalasananHallinta();
            adSaHa.FormClosing += formClosing;
            adSaHa.Ktun = uid;
            adSaHa.Show();
            this.Hide();
        }

        private void MuokkaaProfiiliaTSMI_Click(object sender, EventArgs e)
        {
            AdminMuokkaaProfiilia adMuPr = new AdminMuokkaaProfiilia();
            adMuPr.FormClosing += formClosing;
            adMuPr.Ktun = uid;
            adMuPr.Show();
            this.Hide();
        }

        private void VaihdaSalasanaTSMI_Click(object sender, EventArgs e)
        {
            AdminSalasananVaihto adSaVa = new AdminSalasananVaihto();
            adSaVa.FormClosing += formClosing;
            adSaVa.Ktun = uid;
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
            
            try
            {
                uid = Ktun;
                TyotilanneDGV.DataSource = adTyTiHa.haeTilanne();//DGV:n täyttö
                TyotilanneDGV.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);// datagridview:n muotoilua
                                                                                          //hyödynnetään etusivulle tilaukset hakevaa metodia
                TilauksetDGV.DataSource = adTi.haeTilaukset();
                TilauksetDGV.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                //Mahdollistetaan valinta riviltä
                TilauksetDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                //TilauksetDGV.
                // haetaan tilukseen valittava tekijä
                MySqlCommand cmd = new MySqlCommand("SELECT KayttajaTunnus FROM kayttajat WHERE RoolitID = 3", yh.otaYhteys());
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataSet ds = new DataSet(); // DataSet:llä käsitellään tietokannantieto
                adapter.Fill(ds, "Tun"); // Täytetään DataSet ja nimetään se
                //valitaan minkä niminen column näytetään kyselystä
                TekijaCo.DisplayMember = "KayttajaTunnus";
                //valitaan minkä niminen column antaa arvot
                TekijaCo.ValueMember = "KayttajaTunnus";
                //ComboBox:n DataSource
                TekijaCo.DataSource = ds.Tables["Tun"];
                //DataTable tbl = new DataTable();
                //adapter.Fill(tbl);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       
        private void TilauksetDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
            try
            {   // mikäli painetaan varaa - button:a
                if (e.ColumnIndex == MaaraaCo.Index)
                {
                    TekijaCo.Visible = true; // kayttäjätunnus CB näkyviin
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
                            //LentoID muuttujaan
                            int lId = int.Parse(row.Cells[5].Value.ToString());
                            // määrän, tilausID:n ja lentoID:n lähetys class:n
                            bool varaus = adTyTiHa.maaraaTyo(ktun, id, lId);
                            // mikäli määrääminen onnistui
                            if (varaus == true)
                            {
                                MessageBox.Show($"Työ määrätty.");
                                // DGV:n päivitys
                                TyotilanneDGV.DataSource = adTyTiHa.haeTilanne();
                                // kayttäjätunnus CB piiloon
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
            
        }
          
        private void TyotilanneDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {   //mikäli painetaan poista-button:a
                if(e.ColumnIndex == PoistaCo.Index)
                {   // luetaan id
                    int tId = int.Parse(TyotilanneDGV.CurrentRow.Cells[2].Value.ToString());
                    if (tId == 0)
                    {   //virheviesti
                        MessageBox.Show($"Et ole valinnut poistettavaa käyttäjää");
                    }
                    else
                    {   // kutsutaan metodia, jolla poistetaan työmääräys
                        bool poista = adTyTiHa.poistaMaarays(tId);
                        if (poista == true)//mikäli poisto onnistui
                        {
                            MessageBox.Show($"Työmääräyksen poisto onnistui.");//viesti
                            TyotilanneDGV.DataSource = adTyTiHa.haeTilanne();//DGV:n päivitys
                        }
                        else
                        {   //virheviesti
                            MessageBox.Show($"Työmääräyksen poisto ei onnistunut");
                        }
                    }
                }
                else 
                {
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message} v1");
            }
        }
    }
}
