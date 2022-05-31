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
    public partial class KayttajanKotisivu : Form
    {
        public KayttajanKotisivu()
        {
            InitializeComponent();
        }
        public string kaNimi;
        public string kaID;
        Sqlkysely kysely = new Sqlkysely();
        private void KayttajanKotisivu_Load(object sender, EventArgs e)
        {

            tervetuluaLB.Text = "Tervetulua " + kaNimi;
            DataTable dt = kysely.tilauksia_ID(kaID);
            string idlist = "";
            foreach (DataRow dr in dt.Rows)
            {
                idlist += dr[0].ToString() + ",";
            }
            idlist = idlist.Substring(0, idlist.Length - 1);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;

        }

        void formClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu me = new Menu();
            me.kaID = kaID;
            me.kanimi = kaNimi;
            me.FormClosing += formClosing;
            me.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string id = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                dataGridView2.DataSource = kysely.tilauksia(id);
                dataGridView2.Columns[0].Visible = false;
            }
            catch
            {

            }

        }

        private void muokkaTiliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kayttayatili tili = new kayttayatili();
            tili.kaId = kaID;
            tili.FormClosing += formClosing;
            tili.Show();
            this.Hide();
        }

        private void tilausToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Etusivu et = new Etusivu();
            et.FormClosing += formClosing;
            et.Show();
            this.Hide();
        }

    
    }
}

