using System;
using System.Windows;
using System.Windows.Forms;


namespace Pakkolinen_Ryhmä_Projecti
{
    public partial class Etusivu : Form

    {
        
        public Etusivu()
        {
            InitializeComponent();
        }

        void f1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();

        }
        private void rekistrToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            Rekistreidy re = new Rekistreidy();
            re.FormClosing += f1_FormClosing;
            re.Show();
            this.Hide();
        }
       
        private void galleriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Galleria ga = new Galleria();
            ga.FormClosing += f1_FormClosing;
            ga.Show();
            this.Hide();
        }

        private void kirjaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kirjaudu ki = new Kirjaudu();
            ki.FormClosing += f1_FormClosing;
            ki.Show();
            this.Hide();
        }

        private void otaYhteyttäToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Otayhtayta ota = new Otayhtayta();
            ota.FormClosing += f1_FormClosing;
            ota.Show();
            this.Hide();
        }
    }
}