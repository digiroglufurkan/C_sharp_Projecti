namespace Catering_Projectin
{
    public partial class Etusivu : Form
    {
        public Etusivu()
        {
            InitializeComponent();
        }
        void formClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();

        }

        private void EtusivuTMSI_Click(object sender, EventArgs e)
        {
            Etusivu etu = new Etusivu();
            etu.FormClosing += formClosing;
            etu.Show();
            this.Hide();
        }

        private void KirjauduTMSI_Click(object sender, EventArgs e)
        {
            Kirjaudu kir = new Kirjaudu();
            kir.FormClosing += formClosing;
            kir.Show();
            this.Hide();
        }

        private void RekisteroidyTMSI_Click(object sender, EventArgs e)
        {
            Rekisteroidy rek = new Rekisteroidy();
            rek.FormClosing += formClosing;
            rek.Show();
            this.Hide();
        }
    }
}