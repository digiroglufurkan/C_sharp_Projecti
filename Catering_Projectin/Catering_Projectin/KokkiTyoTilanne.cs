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
            MySqlCommand komento = new MySqlCommand("SELECT TilausID  FROM tyotilanne", yhteys.otaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            adapteri.SelectCommand = komento;
            adapteri.Fill(dt);
            return dt;

        }

        public bool paivitaTilanne(string stat)
        {
            try
            {
                MySqlCommand koemnto = new MySqlCommand("UPDATE FROM Tyotilanne WHERE Status = @stat", yhteys.otaYhteys());
                koemnto.Parameters.Add("stat", MySqlDbType.VarChar).Value = stat;
                yhteys.avaaYhteys();
                if (koemnto.ExecuteNonQuery() == 1) 
                {
                    yhteys.suljeYhteys(); 
                    return true; 
                }
                else
                {
                    yhteys.suljeYhteys(); 
                    return false;  
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
         }
    }

