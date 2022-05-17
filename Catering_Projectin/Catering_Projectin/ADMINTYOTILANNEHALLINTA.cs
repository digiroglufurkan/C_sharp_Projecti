﻿using System;
using MySql.Data.MySqlClient; // pitää muistaa lisätä
using System.Data; // pitää muistaa lisätä
using System.Data.SqlClient; // pitää muistaa lisätä
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catering_Projectin
{
    class ADMINTYOTILANNEHALLINTA
    {
        Yhdista yh = new Yhdista();

        public DataTable haeTilanne()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM tyotilanne", yh.otaYhteys());
            MySqlDataAdapter adapter = new MySqlDataAdapter(); // Luodaan data-adapteri tietokannasta tulevalle tiedolle
            DataTable table = new DataTable(); // Luodaan uusi DataTable jolle tulee tietokannasta tuleva tieto
            adapter.SelectCommand = command; // Adapteriin valitaan Sql komento ja tähän tulee kaikki tietokannasta tuleva tiet
            adapter.Fill(table); // Adapterissa oleva tieto siirretään DataTableen
            return table; // palautetaan DataTable 
        }
    }
}
