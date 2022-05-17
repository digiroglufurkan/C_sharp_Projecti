
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;

namespace Catering_Projectin
{
    class Yhdista
    {
        private MySqlConnection yhteys = new MySqlConnection("datasource=localhost; port=3306;username=root;password=SafV6iE3.0;database=catering;SSL Mode = None");

        public MySqlConnection otaYhteys()
        {
            return yhteys;
        }

        public void avaaYhteys()
        {
            if (yhteys.State == ConnectionState.Closed)
            {
                yhteys.Open();
            }
        }

        public void suljeYhteys()
        {
            if (yhteys.State == ConnectionState.Open)
            {
                yhteys.Close();
            }
        }
    }
}