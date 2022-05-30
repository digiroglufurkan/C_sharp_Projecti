using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// author@ Antti Kuusisto
/// version 30.5.2022
/// <summary>
/// Hakee adminille varastosaldon ja varauksien määrän ja antaa mahdollisuuden varata ja tilata lisää tuotteita.
/// </summary>
namespace Catering_Projectin
{
    public partial class AdminSaatavuudet : Form
    {
        // muuttuja Class:lle, jossa kommunikoidaan tietokannan kanssa
        ADMINSAATAVUUDETHALLINTA adSaHa = new ADMINSAATAVUUDETHALLINTA();
        string uid = ""; // muuttuja käyttäjä tunnukselle
        private string ktun = string.Empty; // muuttuja käyttäjä tunnukselle
        public string Ktun // get/set metodi, jolla siirretään käyttäjätunnus sivulta toiselle
        {
            get { return ktun; }
            set { ktun = value; }
        }
        public AdminSaatavuudet()
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
            adKo.Ktun = uid; // Käyttäjätunnuksen siirto toiselle sivulle
            adKo.Show();
            this.Hide();
        }

        private void SaatavuudetTSMI_Click(object sender, EventArgs e)
        {
            AdminSaatavuudet adSa = new AdminSaatavuudet();
            adSa.FormClosing += formClosing;
            adSa.Ktun = uid; // Käyttäjätunnuksen siirto toiselle sivulle
            adSa.Show();
            this.Hide();
        }

        private void TyotilanneTSMI_Click(object sender, EventArgs e)
        {
            AdminTyotilanne adTy = new AdminTyotilanne();
            adTy.FormClosing += formClosing;
            adTy.Ktun = uid; // Käyttäjätunnuksen siirto toiselle sivulle
            adTy.Show();
            this.Hide();
        }
        private void KayttajatTSMI_Click(object sender, EventArgs e)
        {
            AdminKayttajaHallinta adKaHa = new AdminKayttajaHallinta();
            adKaHa.FormClosing += formClosing;
            adKaHa.Ktun = uid; // Käyttäjätunnuksen siirto toiselle sivulle
            adKaHa.Show();
            this.Hide();
        }
        private void SalasanojenHallintaTSMI_Click(object sender, EventArgs e)
        {
            AdminSalasananHallinta adSaHa = new AdminSalasananHallinta();
            adSaHa.FormClosing += formClosing;
            adSaHa.Ktun = uid; // Käyttäjätunnuksen siirto toiselle sivulle
            adSaHa.Show();
            this.Hide();
        }

        private void MuokkaaProfiiliaTSMI_Click(object sender, EventArgs e)
        {
            AdminMuokkaaProfiilia adMuPr = new AdminMuokkaaProfiilia();
            adMuPr.FormClosing += formClosing;
            adMuPr.Ktun = uid; // Käyttäjätunnuksen siirto toiselle sivulle
            adMuPr.Show(); 
            this.Hide();
        }

        private void VaihdaSalasanaTSMI_Click(object sender, EventArgs e)
        {
            AdminSalasananVaihto adSaVa = new AdminSalasananVaihto();
            adSaVa.FormClosing += formClosing;
            adSaVa.Ktun = uid; // Käyttäjätunnuksen siirto toiselle sivulle
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

        // toiminta, kun sivu latautuu
        private void AdminSaatavuudet_Load(object sender, EventArgs e)
        {
            try
            {
                uid = Ktun;
                AteriaSaatavuudetDGV.DataSource = adSaHa.haeAteriat(); //Aterioiden saatavuudet datagridvievw:n
                AteriaSaatavuudetDGV.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);// datagridview:n muotoilua
                                                                                                 // Mahdollistetaan riviltä tiedonluku
                AteriaSaatavuudetDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                JuomatDGV.DataSource = adSaHa.haeJuomat(); //Juomien saatavuudet datagridvievw:n
                JuomatDGV.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells); // datagridview:n muotoilua
                                                                                       // Mahdollistetaan riviltä tiedonluku
                JuomatDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                JuomatAlkoDGV.DataSource = adSaHa.haeJuomatAlko(); //Viinojen saatavuudet datagridvievw:n
                JuomatAlkoDGV.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells); // datagridview:n muotoilua
                                                                                           // Mahdollistetaan riviltä tiedonluku
                JuomatAlkoDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        // toiminta, kun klikataan datagridvievw:ta
        private void AteriaSaatavuudetDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {   // mikäli painetaan varaa - button:a
                if (e.ColumnIndex == VaraaCo.Index)
                {
                    VaMaaraCo.Visible = true; // varaus määrä TB näkyviin
                    VahVarCo.Visible = true; // vahvistus BT näkyviin
                }
                // mikäli painetaan varauksen vahvistusta
                else if (e.ColumnIndex == VahVarCo.Index)
                    try
                    {
                        // muuttuja datagridvievw:n riville
                        DataGridViewRow row = new DataGridViewRow();
                        // napin rivin lisäys muuttujaan
                        row = AteriaSaatavuudetDGV.SelectedRows[0];
                        // tarkistetaan, että on syötetty varattava määrä
                        if (row.Cells[1].Value != null)
                        {
                            // varausmäärä muuttujaan
                            int varMar = int.Parse(row.Cells[1].Value.ToString());
                            //AteriaID muuttujaan
                            int id = int.Parse(row.Cells[6].Value.ToString());
                            // määrän ja id:n lähetys class:n
                            bool varaus = adSaHa.varaaAteria(varMar, id);
                            // mikäli varaus onnistui
                            if (varaus == true)
                            {
                                // DGV:n päivitys
                                AteriaSaatavuudetDGV.DataSource = adSaHa.haeAteriat();
                                // Varausmäärä TB piiloon
                                VaMaaraCo.Visible = false;
                                // Vahvista varaus BT piiloon
                                VahVarCo.Visible = false;
                            }
                            else // viesti, että varaus ei onnistunut
                            {
                                MessageBox.Show($"Aterioiden varaus ei onnistunut.");
                            }
                        }
                        else // viesti ettei ole valittu varattavaa määrää
                        {
                            MessageBox.Show($"Et syöttänyt varaus määrää!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"{ex.Message} v2");
                    }
                // mikäli painetaan tilaa lisää
                else if(e.ColumnIndex == TilaaLisaaCo.Index)
                {
                    MaTiLisaaCo.Visible = true;
                    VahTilCo.Visible = true;
                }
                //kun painetaan tilauksen vahvistusta
                else if(e.ColumnIndex == VahTilCo.Index)
                    try
                    {
                        // muuttuja datagridvievw:n riville
                        DataGridViewRow row = new DataGridViewRow();
                        // napin rivin lisäys muuttujaan
                        row = AteriaSaatavuudetDGV.SelectedRows[0];
                        // tarkistetaan, että on syötetty tilattava määrä
                        if (row.Cells[4].Value != null)
                        {
                            // tilausmäärä muuttujaan
                            int varMar = int.Parse(row.Cells[4].Value.ToString());
                            //JuomaID muuttujaan
                            int id = int.Parse(row.Cells[6].Value.ToString());
                            // määrän ja id:n lähetys class:n
                            bool tilaus = adSaHa.tilaaAteria(varMar, id);
                            // mikäli tilaus onnistui
                            if (tilaus == true)
                            {
                                // DGV:n päivitys
                                AteriaSaatavuudetDGV.DataSource = adSaHa.haeAteriat();
                                MaTiLisaaCo.Visible = false; // tilausmäärä TB piiloon
                                VahTilCo.Visible = false; // Vahvista tilaus BT piiloon
                            }
                            else // viesti, että tilaus ei onnistunut
                            {
                                MessageBox.Show($"Aterioiden tilaus ei onnistunut.");
                            }
                        }
                        else // viesti ettei ole valittu tilattavaa määrää
                        {
                            MessageBox.Show($"Et syöttänyt tilaus määrää!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"{ex.Message} v3");
                    }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} v1");
            }
        }

        // toiminta, kun klikataan datagridvievw:ta
        private void JuomatDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // mikäli painetaan varaa - button:a
                if (e.ColumnIndex == VaraaJuCo.Index)
                {
                    VaJuMaaraCo.Visible = true; // varaus määrä TB näkyviin
                    VahJuVa.Visible = true; // vahvistus BT näkyviin
                }
                // mikäli painetaan varauksen vahvistusta
                else if (e.ColumnIndex == VahJuVa.Index)
                    try
                    {
                        // muuttuja datagridvievw:n riville
                        DataGridViewRow row = new DataGridViewRow();
                        // napin rivin lisäys muuttujaan
                        row = JuomatDGV.SelectedRows[0];
                        // tarkistetaan, että on syötetty varattava määrä
                        if (row.Cells[1].Value != null)
                        {
                            // varausmäärä muuttujaan
                            int varMar = int.Parse(row.Cells[1].Value.ToString());
                            //JuomaID muuttujaan
                            int id = int.Parse(row.Cells[6].Value.ToString());
                            // määrän ja id:n lähetys class:n
                            bool varaus = adSaHa.varaaJuoma(varMar, id);
                            // mikäli varaus onnistui
                            if (varaus == true)
                            {
                                // DGV:n päivitys
                                JuomatDGV.DataSource = adSaHa.haeJuomat();
                                VaJuMaaraCo.Visible = false; // Varausmäärä TB piiloon
                                VahJuVa.Visible = false; // Vahvista varaus BT piiloon
                            }
                            else // viesti, että varaus ei onnistunut
                            {
                                MessageBox.Show($"Juomien varaus ei onnistunut.");
                            }
                        }
                        else // viesti ettei ole valittu varattavaa määrää
                        {
                            MessageBox.Show($"Et syöttänyt varaus määrää!");
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"{ex.Message} v2");
                    }
                // mikäli painetaan tilaa - button:a
                else if (e.ColumnIndex == TilaaLiJuCo.Index)
                {
                    MaTilaaJuCo.Visible = true; // tilaus määrä TB näkyviin
                    VahTiJuCo.Visible = true; // vahvistus BT näkyviin
                }
                // mikäli painetaan tilauksen vahvistusta
                else if (e.ColumnIndex == VahTiJuCo.Index)
                {
                    try
                    {
                        // muuttuja datagridvievw:n riville
                        DataGridViewRow row = new DataGridViewRow();
                        // napin rivin lisäys muuttujaan
                        row = JuomatDGV.SelectedRows[0];
                        // tarkistetaan, että on syötetty tilattava määrä
                        if (row.Cells[4].Value != null)
                        {
                            // tilausmäärä muuttujaan
                            int varMar = int.Parse(row.Cells[4].Value.ToString());
                            //JuomaID muuttujaan
                            int id = int.Parse(row.Cells[6].Value.ToString());
                            // määrän ja id:n lähetys class:n
                            bool tilaus = adSaHa.tilaaJuoma(varMar, id);
                            // mikäli tilaus onnistui
                            if (tilaus == true)
                            {
                                // DGV:n päivitys
                                JuomatDGV.DataSource = adSaHa.haeJuomat();
                                MaTilaaJuCo.Visible = false; // tilausmäärä TB piiloon
                                VahTiJuCo.Visible = false; // Vahvista tilaus BT piiloon
                            }
                            else // viesti, että tilaus ei onnistunut
                            {
                                MessageBox.Show($"Juomien tilaus ei onnistunut.");
                            }
                        }
                        else // viesti ettei ole valittu tilattavaa määrää
                        {
                            MessageBox.Show($"Et syöttänyt tilaus määrää!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"{ex.Message} juomat");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} v1");
            }
        }

        // toiminta, kun klikataan datagridvievw:ta
        private void JuomatAlkoDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // mikäli painetaan varaa - button:a
                if (e.ColumnIndex == VarAlkoCO.Index)
                {
                    VarAlkoMaCo.Visible = true; // varaus määrä TB näkyviin
                    VahAlkoVarCo.Visible = true; // vahvistus BT näkyviin
                }
                // mikäli painetaan varauksen vahvistusta
                else if (e.ColumnIndex == VahAlkoVarCo.Index)
                    try
                    {
                        // muuttuja datagridvievw:n riville
                        DataGridViewRow row = new DataGridViewRow();
                        // napin rivin lisäys muuttujaan
                        row = JuomatAlkoDGV.SelectedRows[0];
                        // tarkistetaan, että on syötetty varattava määrä
                        if (row.Cells[1].Value != null)
                        {
                            // varausmäärä muuttujaan
                            int varMar = int.Parse(row.Cells[1].Value.ToString());
                            //JuomaID muuttujaan
                            int id = int.Parse(row.Cells[6].Value.ToString());
                            // määrän ja id:n lähetys class:n
                            bool varaus = adSaHa.varaaJuomaAlko(varMar, id);
                            // mikäli varaus onnistui
                            if (varaus == true)
                            {
                                // DGV:n päivitys
                                JuomatAlkoDGV.DataSource = adSaHa.haeJuomatAlko();
                                VarAlkoMaCo.Visible = false; // Varausmäärä TB piiloon
                                VahAlkoVarCo.Visible = false; // Vahvista varaus BT piiloon
                            }
                            else // viesti, että varaus ei onnistunut
                            {
                                MessageBox.Show($"Juomien varaus ei onnistunut.");
                            }
                        }
                        else // viesti ettei ole valittu varattavaa määrää
                        {
                            MessageBox.Show($"Et syöttänyt varaus määrää!");
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"{ex.Message} v2");
                    }
                // mikäli painetaan tilaa - button:a
                else if (e.ColumnIndex == TilaaAlkoCo.Index)
                {
                    TilAlkoMaaraCo.Visible = true; // tilaus määrä TB näkyviin
                    VahAlkoTilCo.Visible = true; // vahvistus BT näkyviin
                }
                // mikäli painetaan tilauksen vahvistusta
                else if (e.ColumnIndex == VahTiJuCo.Index)
                {
                    try
                    {
                        // muuttuja datagridvievw:n riville
                        DataGridViewRow row = new DataGridViewRow();
                        // napin rivin lisäys muuttujaan
                        row = JuomatAlkoDGV.SelectedRows[0];
                        // tarkistetaan, että on syötetty tilattava määrä
                        if (row.Cells[4].Value != null)
                        {
                            // tilausmäärä muuttujaan
                            int varMar = int.Parse(row.Cells[4].Value.ToString());
                            //JuomaID muuttujaan
                            int id = int.Parse(row.Cells[6].Value.ToString());
                            // määrän ja id:n lähetys class:n
                            bool tilaus = adSaHa.tilaaJuomaAlko(varMar, id);
                            // mikäli tilaus onnistui
                            if (tilaus == true)
                            {
                                // DGV:n päivitys
                                JuomatAlkoDGV.DataSource = adSaHa.haeJuomatAlko();
                                TilAlkoMaaraCo.Visible = false; // tilausmäärä TB piiloon
                                VahAlkoTilCo.Visible = false; // Vahvista tilaus BT piiloon
                            }
                            else // viesti, että tilaus ei onnistunut
                            {
                                MessageBox.Show($"Juomien tilaus ei onnistunut.");
                            }
                        }
                        else // viesti ettei ole valittu tilattavaa määrää
                        {
                            MessageBox.Show($"Et syöttänyt tilaus määrää!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"{ex.Message} juomat");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
