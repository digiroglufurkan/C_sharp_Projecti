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
            MySqlCommand komento = new MySqlCommand("SELECT TilausID, Status, LentoID FROM tyotilanne", yhteys.otaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            adapteri.SelectCommand = komento;
            adapteri.Fill(dt);
            return dt;
        }

        public DataTable tilausTilanne()
        {
            MySqlCommand komento = new MySqlCommand("SELECT TilausID, AteriaID, JuomaID, JuomaAlkoID FROM tilaus", yhteys.otaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            adapteri.SelectCommand = komento;
            adapteri.Fill(dt);
            return dt;
        }

        public DataTable statusInfo()
        {
            MySqlCommand komento = new MySqlCommand("SELECT * FROM status", yhteys.otaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            adapteri.SelectCommand = komento;
            adapteri.Fill(dt);
            return dt;

        }

        public bool paivitaTilanne(string tilaus, string status)
        {
            try
            {
                MySqlCommand koemnto = new MySqlCommand("UPDATE tyotilanne SET Status = @sta WHERE TilausID = @til", yhteys.otaYhteys());
                koemnto.Parameters.Add("@til", MySqlDbType.VarChar).Value = tilaus;
                koemnto.Parameters.Add("@sta", MySqlDbType.VarChar).Value = status;
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

