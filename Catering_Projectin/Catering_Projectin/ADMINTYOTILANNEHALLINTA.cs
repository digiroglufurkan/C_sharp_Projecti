using System;
using MySql.Data.MySqlClient; // pitää muistaa lisätä
using System.Data; // pitää muistaa lisätä
using System.Data.SqlClient; // pitää muistaa lisätä
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// author@ Antti Kuusisto
/// version 23.5.2022
/// <summary>
/// Toimii jotenkin. Hieman muokattava hakukyselyitä.
/// </summary>
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

        public bool maaraaTyo(string ktun, int tilId, int lId)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO tyotilanne (KayttajaTunnus, TilausID, Status, LentoID) VALUES(@ktun,@tid,@sta,@len)", yh.otaYhteys());
                cmd.Parameters.Add("@ktun", MySqlDbType.VarChar).Value = ktun;
                cmd.Parameters.Add("@tid", MySqlDbType.Int32).Value = tilId;
                cmd.Parameters.Add("@sta", MySqlDbType.Int32).Value = 1;
                cmd.Parameters.Add("@len", MySqlDbType.Int32).Value = lId;
                yh.avaaYhteys(); // avataan yhteys tietokantaan
                if (cmd.ExecuteNonQuery() == 1) // katsotaan onko komento suoritettu
                {
                    yh.suljeYhteys(); // suljetaan yhteys Yhdista CLASS:n funktiolla
                    return true; // vastauksen palautus
                }
                else
                {
                    yh.suljeYhteys(); // suljetaan yhteys Yhdista CLASS:n funktiolla
                    return false;  // vastauksen palautus
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool poistaMaarays(int tId)
        {
            try
            {
                // käyttäjänpoistokysely ja yhteyden muodostus
                MySqlCommand command = new MySqlCommand("DELETE FROM tyotilanne WHERE TyoID = @id", yh.otaYhteys()); // tämä kesken
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = tId; //käyttäjä tunnuksen lisäys
                yh.avaaYhteys(); // Yhteyden avaus YH CLASS:lla
                if (command.ExecuteNonQuery() == 1) // katsotaan onko komento suoritettu
                {
                    yh.suljeYhteys(); // suljetaan yhteys Yhdista CLASS:n funktiolla
                    return true; // vastauksen palautus
                }
                else
                {
                    yh.suljeYhteys(); // suljetaan yhteys Yhdista CLASS:n funktiolla
                    return false;  // vastauksen palautus
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
