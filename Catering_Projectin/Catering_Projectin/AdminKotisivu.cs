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
/// Adminin kotisivun toiminta
/// </summary>
namespace Catering_Projectin
{
    public partial class AdminKotisivu : Form
    {
        ADMINTILAUKSET adTi = new ADMINTILAUKSET();
        string uid = ""; // muuttuja käyttäjä tunnukselle
        private string ktun = string.Empty; // muuttuja käyttäjä tunnukselle
        public string Ktun // get/set metodi, jolla siirretään käyttäjätunnus sivulta toiselle
        {
            get { return ktun; }
            set { ktun = value; }
        }
        public AdminKotisivu()
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
            adMuPr.Ktun = uid; // Käyttäjätunnuksen siirto toiselle sivulle
            adMuPr.FormClosing += formClosing;
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

        //Toiminta, kun sivu ladataan
        private void AdminKotisivu_Load(object sender, EventArgs e)
        {
            uid = Ktun; // Haetaan käyttäjätunnus kirjautumisesta tälle sivulle.
            TilauksetDGV.DataSource = adTi.haeTilaukset(); // Päivitetään DGV, jossa näytetään tilaukset
            TilauksetDGV.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);// datagridview:n muotoilua
        }


    }
}
