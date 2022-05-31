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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        Sqlkysely kysely = new Sqlkysely();

        DataTable lisaa_maara(DataTable dt)
        {
            DataColumn dc = new DataColumn();
            dc.ColumnName = "Maara";
            dc.DefaultValue = "1";
            dc.DataType = typeof(int);
            dt.Columns.Add(dc);
            dt.Columns[2].SetOrdinal(dt.Columns.Count - 1);
            dt.Columns["Maara"].SetOrdinal(2);

            return dt;
        }
        private void Menu_Load(object sender, EventArgs e)
        {
            DataGridViewCheckBoxColumn chkbox = new DataGridViewCheckBoxColumn();
            chkbox.HeaderText = "Valitese";
            chkbox.FalseValue = "0";
            chkbox.TrueValue = "1";

            DataGridViewCheckBoxColumn chkbox1 = new DataGridViewCheckBoxColumn();
            chkbox1.HeaderText = "Valitese";
            chkbox1.FalseValue = "0";
            chkbox1.TrueValue = "1";
            DataGridViewCheckBoxColumn chkbox2 = new DataGridViewCheckBoxColumn();
            chkbox2.HeaderText = "Valitese";
            chkbox2.FalseValue = "0";
            chkbox2.TrueValue = "1";
            DataGridViewCheckBoxColumn chkbox3 = new DataGridViewCheckBoxColumn();
            chkbox3.HeaderText = "Valitese";
            chkbox3.FalseValue = "0";
            chkbox3.TrueValue = "1";

            DataTable dt;
            dataGridView1.DataSource = kysely.lennot();
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns.Insert(0, chkbox);
            dt = kysely.haejuomatalkolimat();
            dt = lisaa_maara(dt);
            AlkohollimatGW.DataSource = dt;
            AlkohollimatGW.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            AlkohollimatGW.Columns[0].Visible = false;
            AlkohollimatGW.Columns[3].Visible = false;
            AlkohollimatGW.Columns[4].Visible = false;
            AlkohollimatGW.Columns.Insert(0, chkbox1);
            dt = kysely.haealkolijuomat();
            dt = lisaa_maara(dt);
            AlkohollisetGW.DataSource = dt;
            AlkohollisetGW.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            AlkohollisetGW.Columns[0].Visible = false;
            AlkohollisetGW.Columns[4].Visible = false;
            AlkohollisetGW.Columns[5].Visible = false;
            AlkohollisetGW.Columns.Insert(0, chkbox2);
            dt = kysely.haeateriat();
            dt = lisaa_maara(dt);
            AteriatGW.DataSource = dt;
            AteriatGW.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            AteriatGW.Columns[0].Visible = false;
            AteriatGW.Columns[3].Visible = false;
            AteriatGW.Columns[5].Visible = false;
            AteriatGW.Columns[6].Visible = false;
            AteriatGW.Columns.Insert(0, chkbox3);


        }

        string ateriatlist = "";
        string juomalist = "";
        string alkolijuoma = "";
        string lento = "";
        List<string> ateria_maara = new List<string>();
        List<string> juoma_maara = new List<string>();
        List<string> Alkoli_juomamaara = new List<string>();
        public string kaID;
        public string kanimi;
        private void button1_Click(object sender, EventArgs e)
        {

            string[] valitus;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                if (Convert.ToInt32(row.Cells[0].Value) == 1)
                {
                    lento = row.Cells[1].Value.ToString();

                }

            }

            foreach (DataGridViewRow row in AteriatGW.Rows)
            {
                if (Convert.ToInt32(row.Cells[0].Value) == 1)
                {

                    ateriatlist += row.Cells[1].Value.ToString() + ",";
                    ateria_maara.Add(row.Cells[3].Value.ToString());

                }

            }
            foreach (DataGridViewRow row in AlkohollimatGW.Rows)
            {
                if (Convert.ToInt32(row.Cells[0].Value) == 1)
                {
                    juomalist += row.Cells[1].Value.ToString() + ",";
                    juoma_maara.Add(row.Cells[3].Value.ToString());

                }

            }
            foreach (DataGridViewRow row in AlkohollisetGW.Rows)
            {
                if (Convert.ToInt32(row.Cells[0].Value) == 1)
                {
                    alkolijuoma += row.Cells[1].Value.ToString() + ",";
                    Alkoli_juomamaara.Add(row.Cells[3].Value.ToString());

                }
            }


            //MessageBox.Show(tilaus[0][0].ToString() + tilaus[0][1].ToString());
        }
        void formClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();

        }
        private void kotisivuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KayttajanKotisivu kotisivu = new KayttajanKotisivu();
            kotisivu.kaID = kaID;
            kotisivu.kaNimi = kanimi;
            kotisivu.FormClosing += formClosing;
            kotisivu.Show();
            this.Hide();
        }

        private void tilausToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lento == "")
            {
                MessageBox.Show("Olehyvä ja valitse lento");
            }
            else
            {
                if (Alkoli_juomamaara.Count > 0 || juoma_maara.Count > 0 || ateria_maara.Count > 0)
                {
                    Tilaus ti = new Tilaus();
                    //dataGridView1.Rows.Clear();
                    DataTable dt = (DataTable)dataGridView1.DataSource;
                    ti.aterialist1 = (ateriatlist.Length>0 )?ateriatlist.Substring(0, ateriatlist.Length - 1):ateriatlist;
                    ti.lento1 = lento;
                    ti.kaId = kaID;
                    ti.kanimi = kanimi;
                    ti.alkolijuomalist1 = (alkolijuoma.Length >0)? alkolijuoma.Substring(0, alkolijuoma.Length - 1): alkolijuoma;
                    ti.juomalist1 = (juomalist.Length>0)?juomalist.Substring(0, juomalist.Length - 1): juomalist;
                    ti.T_Alkoli_juomamaara = Alkoli_juomamaara;
                    ti.T_ateria_maara = ateria_maara;
                    ti.T_juoma_maara = juoma_maara;
                    ti.FormClosing += formClosing;
                    ti.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Olehyvä ja valitse ruoka tai juoma");
                }
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

        private void kirjouduUlosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Etusivu et = new Etusivu();
            et.FormClosing += formClosing;
            et.Show();
            this.Hide();
        }
    }
    
}