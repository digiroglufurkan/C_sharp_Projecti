﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data; 
using System.Data.SqlClient;

namespace Pakkolinen_Ryhmä_Projecti
{
    public partial class Kirjaudu : Form
    {
        public Kirjaudu()
        {
            InitializeComponent();
        }
        void f1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();

        }

        Yhdista yh = new Yhdista();
        Tiedansyotto ti = new Tiedansyotto();
        private void KirjoiduBT_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT SALASANA FROM `kayttajat` WHERE KAYTTAJA_TUNNUS='" + KiTunnusTB.Text +"'", yh.otaYhteys());
            yh.avaaYhteys();
            MySqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            if (KiSalasanaTB.Text == ti.Decrypt((String)dr.GetValue(0)))
            {
                KirjautunutKotisivu ki = new KirjautunutKotisivu();
                ki.FormClosing += f1_FormClosing;
                ki.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Käyttajan Tunnus tai Salasana Värin");

            }
            yh.suljeYhteys();


        }

        private void etusivuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Etusivu et = new Etusivu();
            et.Show();
            et.FormClosing += f1_FormClosing;
            this.Hide();
        }

        private void otaYhteyttäToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Otayhtayta ota = new Otayhtayta();
            ota.FormClosing += f1_FormClosing;
            ota.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd1 = new MySqlCommand("SELECT ETUNIMI FROM `kayttajat` WHERE EMAIL='" + KisahkopostiTB.Text + "'", yh.otaYhteys());
            yh.avaaYhteys();
            MySqlDataReader dr1 = cmd1.ExecuteReader();
            dr1.Read();

            if (dr1.HasRows)
            {
                MessageBox.Show("lahetettiin uden salasana");
                
            }
            else
            {
                //nolla salasaan Send Email
                MessageBox.Show("Käyttäjä Ei Löyttenyt");
            }
            yh.suljeYhteys();
        }
    }
}
