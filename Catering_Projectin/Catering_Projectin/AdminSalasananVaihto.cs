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
/// version 19.5.2022
/// <summary>
/// Vaihtaa käyttäjän salasanan, pitää päivittää dynaaminen käyttäjätunnuksen haku, kun Kirjaudu-sivu on
/// valmis.
/// </summary>
namespace Catering_Projectin
{
    public partial class AdminSalasananVaihto : Form
    {
        ADMINSALASANAT adSa = new ADMINSALASANAT();
        string uid = ""; // muuttuja käyttäjä tunnukselle
        private string ktun = string.Empty;
        public string Ktun
        {
            get { return ktun; }
            set { ktun = value; }
        }
        public AdminSalasananVaihto()
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

        private void VaihdaBT_Click(object sender, EventArgs e)
        {
            // Muuttuja uudelle salasanalle ja sen toistolle
            string uusiSalasana = "", uusiUudestaan = "";
            //string uid = "test"; // Poistetaan, kun on valmis
            try
            {
                uusiSalasana = UusiSaSanaTB.Text; // uusi salasana 
                uusiUudestaan = UusiUdTB.Text; // uuden toisto
                if (uusiSalasana.Equals("") || uusiUudestaan.Equals("")) // tarkistus, että kentissä tekstiä
                {
                    MessageBox.Show($"Tarkista tekstikentät.");
                }
                else if (uusiSalasana != uusiUudestaan) // tarkistus, että uusi kaksi kertaa.
                {
                    MessageBox.Show($"Uudet salasanat eivät täsmää.");
                }
                else
                {   // salasanan vaihto ADMINSALASANAT class:ssa metodilla
                    bool vastaus = adSa.vaihdaSalasana(uid, uusiSalasana);
                    if (vastaus == true) // mikäli vaihto onnistui
                    {
                        MessageBox.Show($"Salasanan vaihto onnistui.");
                        UusiSaSanaTB.Text = "";
                        UusiUdTB.Text = "";
                    }
                    else
                    {
                        MessageBox.Show($"Salasanan vaihto ei onnistunut.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AdminSalasananVaihto_Load(object sender, EventArgs e)
        {
            uid = Ktun;
        }
    }
}
