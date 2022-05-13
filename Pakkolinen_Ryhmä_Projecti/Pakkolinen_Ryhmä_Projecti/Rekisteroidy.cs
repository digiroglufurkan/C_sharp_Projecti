using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pakkolinen_Ryhmä_Projecti
{
    public partial class Rekistreidy : Form
    {
        public Rekistreidy()
        {
            InitializeComponent();
        }
        
      
        void f1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();

        }

        private void galleriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Galleria ga = new Galleria();
            ga.FormClosing += f1_FormClosing;
            ga.Show();
            this.Hide();
        }

        private void otaYhteyttäToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Otayhtayta ota = new Otayhtayta();
            ota.FormClosing += f1_FormClosing;
            ota.Show();
            this.Hide();
        }

        private void etusivuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Etusivu et = new Etusivu();
            et.Show();
            et.FormClosing += f1_FormClosing;
            this.Hide();
        }

        private void RekysteroidyBT_Click(object sender, EventArgs e)
        {
            if (tarkistaTextBox(ReEtunimiTB, "Vaaditan Etunimi")) { goto loppu; };
            string etunimi = ReEtunimiTB.Text;
            if (tarkistaTextBox(ReSukunimiTB, "Vaaditan Sukunimi")) { goto loppu; };
            string sukunimi = ReSukunimiTB.Text;
            if (tarkistaTextBox(RePuhelinTB, "Vaaditan Puhelin")) { goto loppu; };
            string puh = RePuhelinTB.Text;
            if (tarkistaTextBox(ReOsaiteTB, "Vaaditan Osaite")) { goto loppu; };
            string osaite = ReOsaiteTB.Text;
            if (tarkistaTextBox(ResahkopostiTB, "Vaaditan Sahköposti osaite")) { goto loppu; };
            string email = ResahkopostiTB.Text;
            if (tarkistaTextBox(RePostinumeroTB, "Vaaditan Posti Numero")) { goto loppu; };
            string postinumero = RePostinumeroTB.Text;
            if(tarkistaTextBox(RePostipaikkaTB, "Vaaditan Postitoimipaikka")) { goto loppu; };
            string toimipaikka= RePostipaikkaTB.Text;
            if (tarkistaTextBox(ReTitteliTB, "Vaaditan Titteli")) { goto loppu; };
            if (tarkistaTextBox(Resalasana1TB, "Vaaditan Salasana")) { goto loppu; };
            if (tarkistaTextBox(ReSalasana2TB, "Vaaditan Salasana Udestan")) { goto loppu; };
            string titteli = ReTitteliTB.Text;
            Tiedansyotto uusisyotto = new Tiedansyotto();
            string salasana;
            if (Resalasana1TB.Text == ReSalasana2TB.Text)
            {
                salasana = Resalasana1TB.Text;
            }
            else { MessageBox.Show("Salasana ei ole sama"); goto loppu; }
            string ktunus = uusisyotto.lisakayttaja(etunimi, sukunimi, puh, email, osaite, postinumero, toimipaikka, titteli, kuva, ReProfiiliKuvaPB,salasana);
            if (ktunus != "")
            {
                MessageBox.Show("Rekisteroidy Onnistuu Ja Kayttäyän Tunnnus : "+ ktunus);
            }
            else
            {
                MessageBox.Show("Valittevasti Ei Rekistreidy yritään udestan ");
            }
        loppu:;
        }
        private bool tarkistaTextBox(TextBox a, string b, string c = "")
        {
            if (a.Text == c)
            {
                MessageBox.Show(b);
                return true;
            }
            return false;
        }
        //Profili Kuva valitse
        bool kuva = false;
        private void RetiedostoBT_Click(object sender, EventArgs e)
        {

            OpenFileDialog open = new OpenFileDialog();
            // image filters pictruebox  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // näyttä picturebox
                ReProfiiliKuvaPB.Image = new Bitmap(open.FileName);
                kuva = true;
                
            }
         
        }

        private void kirjaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kirjaudu ki = new Kirjaudu();
            ki.FormClosing += f1_FormClosing;
            ki.Show();
            this.Hide();
        }
    }
    }

