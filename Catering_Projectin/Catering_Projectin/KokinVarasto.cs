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
            MySqlCommand komento = new MySqlCommand("SELECT AterianNimi, Varasto_saldo, Varattu FROM ateriat", yhteys.otaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter(); 
            DataTable dt = new DataTable(); 
            adapteri.SelectCommand = komento; 
            adapteri.Fill(dt); 
            return dt; 
        }

        public DataTable alkoSaldo()
        {
            MySqlCommand komento = new MySqlCommand("SELECT Nimi, Varasto_saldo, Varattu FROM juomatalkoholilliset", yhteys.otaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            adapteri.SelectCommand = komento;
            adapteri.Fill(dt);
            return dt;
        }

        public DataTable juomaSaldo()
        {
            MySqlCommand komento = new MySqlCommand("SELECT * FROM juomatalkoholittomat", yhteys.otaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            adapteri.SelectCommand = komento;
            adapteri.Fill(dt);
            return dt;
        }

        

        public bool juomaVahvistus(int id)
        {
            try
            {
                MySqlCommand command = new MySqlCommand("UPDATE juomatalkoholittomat SET Varasto_saldo = Varasto_saldo + 500 WHERE JuomaID = @id", yhteys.otaYhteys()); 
                command.Parameters.Add("@id", MySqlDbType.UInt32).Value = id;
                yhteys.avaaYhteys(); 
                if (command.ExecuteNonQuery() == 1) 
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

        public bool alkoVahvistus(int id)
        {
            try
            { // alkoissa ei toiminut JuomaAlkoID vaan piti laittaa Nimi(?) mikä ei ehkä toimi jos alkoja on enemmän, mutta nyt toimii 
                MySqlCommand command = new MySqlCommand("UPDATE juomatalkoholilliset SET Varasto_saldo = Varasto_saldo + 500 WHERE Nimi = @id", yhteys.otaYhteys());
                command.Parameters.Add("@id", MySqlDbType.UInt32).Value = id;
                yhteys.avaaYhteys();
                if (command.ExecuteNonQuery() == 1)
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
