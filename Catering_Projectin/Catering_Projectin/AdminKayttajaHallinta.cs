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
/// Toiminta tietokannassa käyttäjätilien hallinnalle
/// </summary>
namespace Catering_Projectin
{
    public partial class AdminKayttajaHallinta : Form
    {
        ADMINKAYTTAJIENHALLINTA adKaHa = new ADMINKAYTTAJIENHALLINTA();
        string uid = ""; // muuttuja käyttäjä tunnukselle
        private string ktun = string.Empty; // muuttuja käyttäjä tunnukselle
        public string Ktun // get/set metodi, jolla siirretään käyttäjätunnus sivulta toiselle
        {
            get { return ktun; }
            set { ktun = value; }
        }
        public AdminKayttajaHallinta()
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

        private void KayttajaHallintaTSMI_Click(object sender, EventArgs e)
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

        // toiminta, kun sivu ladataan
        private void AdminKayttajaHallinta_Load(object sender, EventArgs e)
        {
            
            try
            {
                uid = Ktun; // käyttäjätunnuksen haku
                KaytHallintaDGV.DataSource = adKaHa.haeKayttajat(); // DGV:n, jossa tilit täyttö
                KaytHallintaDGV.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);// datagridview:n muotoilua
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void KaytHallintaDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {   // mikäli painetaan poista-button:a
                if (e.ColumnIndex == PoistaCo.Index)
                {
                    try
                    {   // luetaan id numero
                        int kId = int.Parse(KaytHallintaDGV.CurrentRow.Cells[3].Value.ToString());
                        if (kId == 0)
                        {   //virheviesti
                            MessageBox.Show($"Et ole valinnut poistettavaa käyttäjää");
                        }
                        else
                        {   // kutsutaan metodia, jolla poistetaan käyttäjä
                            bool poista = adKaHa.poistaKayttaja(kId);
                            if (poista == true)// mikäli poisto onnistui
                            {
                                // viesti
                                MessageBox.Show($"Käyttäjän poisto onnistui.");
                                //DGV:n päivitys
                                KaytHallintaDGV.DataSource = adKaHa.haeKayttajat();
                            }
                            else
                            {   //virheviesti
                                MessageBox.Show($"Käyttäjän poisto ei onnistunut");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"{ex.Message} v2");
                    }
                }
                //mikäli painetaan lisää admin-button:a
                else if (e.ColumnIndex == LiAdminCo.Index)
                {
                    try
                    {
                        // luetaan id numero
                        int kId = int.Parse(KaytHallintaDGV.CurrentRow.Cells[3].Value.ToString());
                        if (kId == 0)
                        {   //virheviesti
                            MessageBox.Show($"Et ole valinnut käyttäjää, josta tehdä admin");
                        }
                        else
                        {   // kutsutaan metodia, jolla lisätään admin
                            bool poista = adKaHa.lisaaAdmin(kId);
                            if (poista == true)// mikäli lisäys onnistui
                            {
                                MessageBox.Show($"Adminin lisäys onnistui.");// viesti
                                KaytHallintaDGV.DataSource = adKaHa.haeKayttajat();//DGV:n päivitys
                            }
                            else
                            {   //virheviesti
                                MessageBox.Show($"Adminin lisäys ei onnistunut");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"{ex.Message} v3");
                    }
                }
                //mikäli painetaan poista admin-button:a
                else if (e.ColumnIndex == PoAdminCo.Index)
                {
                    try
                    {   // luetaan id numero
                        int kId = int.Parse(KaytHallintaDGV.CurrentRow.Cells[3].Value.ToString());
                        if (kId == 0)
                        {   //virheviesti
                            MessageBox.Show($"Et ole valinnut käyttäjää jolta poistaa admin oikeudet");
                        }
                        else
                        {   // kutsutaan metodia, jolla poistetaan admin
                            bool poista = adKaHa.poistaAdmin(kId);
                            if (poista == true) // mikäli poisto onnistui
                            {
                                MessageBox.Show($"Adminin poisto onnistui.");// viesti
                                KaytHallintaDGV.DataSource = adKaHa.haeKayttajat();//DGV:n päivitys
                            }
                            else
                            {   //virheviesti
                                MessageBox.Show($"Adminin poisto ei onnistunut");
                            }
                        }
                    }
                    catch (Exception ex)
                    {   //virheviesti
                        MessageBox.Show($"{ex.Message} v4");
                    }
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {   //virheviesti
                MessageBox.Show($"{ex.Message} v1");
            }
        }
    }
}
