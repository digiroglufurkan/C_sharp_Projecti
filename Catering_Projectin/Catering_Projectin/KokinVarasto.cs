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
    internal class KokinVarasto
    {
        Yhdista yhteys = new Yhdista();

        public DataTable ruokaSaldo()
        {
            MySqlCommand komento = new MySqlCommand("SELECT AterianNimi, Varasto_saldo FROM ateriat", yhteys.otaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter(); 
            DataTable dt = new DataTable(); 
            adapteri.SelectCommand = komento; 
            adapteri.Fill(dt); 
            return dt; 
        }

        public DataTable alkoSaldo()
        {
            MySqlCommand komento = new MySqlCommand("SELECT Nimi, Varasto_saldo FROM juomatalkoholilliset", yhteys.otaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            adapteri.SelectCommand = komento;
            adapteri.Fill(dt);
            return dt;
        }

        public DataTable juomaSaldo()
        {
            MySqlCommand komento = new MySqlCommand("SELECT Nimi, Varasto_saldo FROM juomatalkoholittomat", yhteys.otaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            adapteri.SelectCommand = komento;
            adapteri.Fill(dt);
            return dt;
        }
    }
}
