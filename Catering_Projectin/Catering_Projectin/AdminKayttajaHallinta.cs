using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catering_Projectin
{
    public partial class AdminKayttajaHallinta : Form
    {
        ADMINKAYTTAJIENHALLINTA adKaHa = new ADMINKAYTTAJIENHALLINTA();
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

        private void KayttajaHallintaTSMI_Click(object sender, EventArgs e)
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

        private void AdminKayttajaHallinta_Load(object sender, EventArgs e)
        {
            try
            {
                KaytHallintaDGV.DataSource = adKaHa.haeKayttajat();
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
            {
                if(e.ColumnIndex == PoistaCo.Index)
                {
                    try
                    {
                        int kId = int.Parse(KaytHallintaDGV.CurrentRow.Cells[3].Value.ToString());
                        if (kId == 0)
                        {
                            MessageBox.Show($"Et ole valinnut poistettavaa käyttäjää");
                        }
                        else
                        {
                            bool poista = adKaHa.poistaKayttaja(kId);
                            if (poista == true)
                            {
                                MessageBox.Show($"Käyttäjän poisto onnistui.");
                                KaytHallintaDGV.DataSource =adKaHa.haeKayttajat();
                            }
                            else
                            {
                                MessageBox.Show($"Käyttäjän poisto ei onnistunut");
                            }
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show($"{ex.Message} v2");
                    }
                }
                else if(e.ColumnIndex == LiAdminCo.Index)
                {
                    try
                    {
                        int kId = int.Parse(KaytHallintaDGV.CurrentRow.Cells[3].Value.ToString());
                        if (kId == 0)
                        {
                            MessageBox.Show($"Et ole valinnut käyttäjää, josta tehdä admin");
                        }
                        else
                        {
                            bool poista = adKaHa.lisaaAdmin(kId);
                            if (poista == true)
                            {
                                MessageBox.Show($"Adminin lisäys onnistui.");
                                KaytHallintaDGV.DataSource = adKaHa.haeKayttajat();
                            }
                            else
                            {
                                MessageBox.Show($"Adminin lisäys ei onnistunut");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"{ex.Message} v3");
                    }
                }
                else if(e.ColumnIndex == PoAdminCo.Index)
                {
                    try
                    {
                        int kId = int.Parse(KaytHallintaDGV.CurrentRow.Cells[3].Value.ToString());
                        if (kId == 0)
                        {
                            MessageBox.Show($"Et ole valinnut käyttäjää jolta poistaa admin oikeudet");
                        }
                        else
                        {
                            bool poista = adKaHa.poistaAdmin(kId);
                            if (poista == true)
                            {
                                MessageBox.Show($"Adminin poisto onnistui.");
                                KaytHallintaDGV.DataSource = adKaHa.haeKayttajat();
                            }
                            else
                            {
                                MessageBox.Show($"Adminin poisto ei onnistunut");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"{ex.Message} v4");
                    }
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} v1");
            }
        }
    }
}
