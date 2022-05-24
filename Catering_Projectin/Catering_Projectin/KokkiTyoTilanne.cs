using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data;

namespace Catering_Projectin
{
    internal class KokkiTyoTilanne
    {
        Yhdista yhteys = new Yhdista();

        public DataTable tyoTilanne()
        {
            MySqlCommand komento = new MySqlCommand("SELECT TilausID, Status FROM tyotilanne", yhteys.otaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            adapteri.SelectCommand = komento;
            adapteri.Fill(dt);
            return dt;

        }


    }
}
