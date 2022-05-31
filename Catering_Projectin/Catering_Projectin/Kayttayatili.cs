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
    public partial class kayttayatili : Form
    {
        public kayttayatili()
        {
            InitializeComponent();
        }
        public string kaId;
        Sqlkysely kysely =new Sqlkysely();
        DataTable dt = new DataTable();
        Tiedansyotto syotto = new Tiedansyotto();   
        private void kayttayatili_Load(object sender, EventArgs e)
        {
            try
            {
                dt = kysely.haeakaytajatiedot(kaId);
                MuemailTB.Text = dt.Rows[0][6].ToString();
                MuketuTB.Text = dt.Rows[0][4].ToString();
                MuosoiteTB.Text = dt.Rows[0][9].ToString();
                MusukunimiTB.Text = dt.Rows[0][5].ToString();
                MupuhelinTB.Text = dt.Rows[0][7].ToString();
                MutoimiTB.Text = dt.Rows[0][10].ToString();
                MupostiTB.Text = dt.Rows[0][11].ToString();
                tunnus.Text = dt.Rows[0][2].ToString();

            }
            catch
            {

            }
        }

        private void rekisteroidyBT_Click(object sender, EventArgs e)
        {
            
        }

        private void paivittaBT_Click(object sender, EventArgs e)
        {
            string etu = MuketuTB.Text;
            string suku = MusukunimiTB.Text;
            string osa = MuosoiteTB.Text;
            string puh = MupuhelinTB.Text;
            string toi = MutoimiTB.Text.Trim();
            string pos = MupostiTB.Text.Trim();
            string ema = MusukunimiTB.Text.Trim();
            string tun = tunnus.Text;
            string sal;
            if (MuSalis1TB.Text != "" & MuSalis1TB.Text == MuSalis2TB.Text)
            {
                sal = syotto.Encrypt(MuSalis1TB.Text);

            }
            else
            {
                sal = dt.Rows[0][3].ToString();
            }
            kysely.updatetili(kaId, tun, sal, etu, puh, suku, ema, pos, toi, osa);
        }
    }
}
