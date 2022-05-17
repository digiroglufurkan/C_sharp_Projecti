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
    public partial class AdminSaatavuudet : Form
    {
        ADMINSAATAVUUDETHALLINTA adSaHa = new ADMINSAATAVUUDETHALLINTA();
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

        private void AdminSaatavuudet_Load(object sender, EventArgs e)
        {
            AteriaSaatavuudetDGV.DataSource = adSaHa.haeAteriat();
            AteriaSaatavuudetDGV.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);// datagridview:n muotoilua
            JuomatDGV.DataSource = adSaHa.haeJuomat();
            JuomatDGV.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            JuomatAlkoDGV.DataSource = adSaHa.haeJuomatAlko();
            JuomatAlkoDGV.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void AteriaSaatavuudetDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == VaraaCo.Index)
                {
                    VaMaaraCo.Visible = true;
                    VahVarCo.Visible = true;
                }
                else if (e.ColumnIndex == VahVarCo.Index )
                    try
                    {
                        int varMar = int.Parse(VaMaaraCo.ToString());
                        MessageBox.Show($"{varMar}");

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

        private void JuomatDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void JuomatAlkoDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
