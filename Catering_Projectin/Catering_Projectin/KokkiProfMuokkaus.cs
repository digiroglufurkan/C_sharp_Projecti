using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catering_Projectin
{
    internal class KokkiProfMuokkaus
    {
        Yhdista yhteys = new Yhdista();

        public bool muokkaaKokkiProffa(string enimi, string snimi, string email, string puhelin, string osoite, string toimi, string posti, string id)
        {
            try
            {
                MySqlCommand command = new MySqlCommand(); 
                command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
                command.Parameters.Add("@etu", MySqlDbType.VarChar).Value = enimi; 
                command.Parameters.Add("@suku", MySqlDbType.VarChar).Value = snimi; 
                command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email; 
                command.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puhelin; 
                command.Parameters.Add("@oso", MySqlDbType.VarChar).Value = osoite; 
                command.Parameters.Add("@toimi", MySqlDbType.VarChar).Value = toimi; 
                command.Parameters.Add("@post", MySqlDbType.VarChar).Value = posti; 
                string updateQuest = "Update `kayttajat` Set `Etunimi` = @etu, `Sukunimi` = @suku, `Email` =@email, `Puhelin` =@puh, `Osoite` =@oso, `Postitoimipaikka` =@toimi, `Postinumero` =@post WHERE KayttajaTunnus =@id";  
                command.CommandText = updateQuest; 
                command.Connection = yhteys.otaYhteys(); 
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
                MessageBox.Show($"{ex} v2");
                return false; 
            }
        }

        public DataTable haeProfTiedot() 
        {   
            try
            {   
                MySqlCommand command = new MySqlCommand("SELECT KayttajaTunnus, Etunimi, Sukunimi, Email, Puhelin, Osoite, Postitoimipaikka, Postinumero FROM kayttajat", yhteys.otaYhteys());
                MySqlDataAdapter adapter = new MySqlDataAdapter(); 
                DataTable table = new DataTable(); 
                adapter.SelectCommand = command; 
                adapter.Fill(table); 
                return table;  
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex} v1");
                MySqlCommand command = new MySqlCommand("SELECT KayttajaTunnus, Etunimi, Sukunimi, Email, Puhelin, Osoite, Postitoimipaikka, Postinumero FROM kayttajat", yhteys.otaYhteys());
                MySqlDataAdapter adapter = new MySqlDataAdapter(); 
                DataTable table = new DataTable(); 
                adapter.SelectCommand = command; 
                adapter.Fill(table); 
                return table; 
            }
        }
    }
}
