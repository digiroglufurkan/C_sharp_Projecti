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
    public partial class Tilaus : Form
    {
        public Tilaus()
        {
            InitializeComponent();
        }
        Sqlkysely kysely = new Sqlkysely();
        Tiedansyotto tiedansyotto = new Tiedansyotto();
        public string  aterialist1;
        public string juomalist1;
        public string alkolijuomalist1;
        public string lento1;
        public List<string> T_ateria_maara;
        public List<string> T_juoma_maara;
        public List<string> T_Alkoli_juomamaara;
        float summa = 0;
        public string kaId;
        public string kanimi;
        void formClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();

        }
        DataTable dt = new DataTable();
        private void Tilaus_Load(object sender, EventArgs e)
        {
            
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("Category",typeof(string));
            dt.Columns.Add("Nimi", typeof(string));
            dt.Columns.Add("Maara", typeof(string));
            dt.Columns.Add("Hinta", typeof(string));
            dt.Columns.Add("Summa",typeof(float));
            int a = 0;
            foreach (DataRow drow in kysely.haeateriattila(aterialist1).Rows)
            {
                dt.Rows.Add(drow[0].ToString(), "Ateria", drow[2].ToString(),T_ateria_maara[a],drow[4].ToString()) ;
                a++;
            }
            a= 0;
            foreach (DataRow drow in kysely.haealkolijuomatlist(alkolijuomalist1).Rows)
            {
                dt.Rows.Add(drow[0].ToString(),"Alkoli Juoma", drow[1].ToString(), T_Alkoli_juomamaara[a], drow[3].ToString());
                a++;
            }
            a = 0;
            foreach (DataRow drow in kysely.haejuomatalkolimattila(juomalist1).Rows)
            {
                dt.Rows.Add(drow[0].ToString(), "Juoma", drow[1].ToString(),T_juoma_maara[a], drow[2].ToString());
                a++;
            }
             
              foreach(DataRow drow in dt.Rows)
            {
                 drow[5]= float.Parse(drow[4].ToString()) * float.Parse(drow[3].ToString());
                 summa += float.Parse(drow[5].ToString());
            }
            dataGridView1.DataSource = dt;
            dt.Rows.Add("", "", "", "", "", summa);

            dt = kysely.lennotID(lento1);
            lahtopaikka.Text= dt.Rows[0][1].ToString();
            maaranpaa.Text= dt.Rows[0][2].ToString();
            lentoaika.Text= dt.Rows[0][3].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            tiedansyotto.lisaTilaa(kaId, summa.ToString(),lento1);
            String tilaid = kysely.haetilaid(kaId);

            for (int i = 0; i < dataGridView1.Rows.Count-2; i++)
            {
                   DataGridViewRow row = dataGridView1.Rows[i];
                    switch (row.Cells[1].Value.ToString())
                    {
                        case "Juoma":
                            tiedansyotto.lisaTilaatieto(tilaid, "", row.Cells[0].Value.ToString(), "", row.Cells[3].Value.ToString());

                            break;
                        case "Alkoli Juoma":
                            tiedansyotto.lisaTilaatieto(tilaid, "", "", row.Cells[0].Value.ToString(), row.Cells[3].Value.ToString());

                            break;
                        case "Ateria":
                            tiedansyotto.lisaTilaatieto(tilaid, row.Cells[0].Value.ToString(), "", "", row.Cells[3].Value.ToString());

                            break;
                    }
            }
            MessageBox.Show("Tilasi on tallennettu");
        }

        private void kotisivuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KayttajanKotisivu kotisivu = new KayttajanKotisivu();
            kotisivu.kaNimi = kanimi;
            kotisivu.kaID = kaId;
            kotisivu.FormClosing += formClosing;
            kotisivu.Show();
            this.Hide();
        }

        private void tilausToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu me = new Menu();
            me.kaID = kaId;
            me.kanimi = kanimi;
            me.FormClosing += formClosing;
            me.Show();
            this.Hide();
        }
    }

}
