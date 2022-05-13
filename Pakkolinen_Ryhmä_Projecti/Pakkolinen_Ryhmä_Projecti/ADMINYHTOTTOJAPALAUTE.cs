using MySql.Data.MySqlClient; // pitää muistaa lisätä
using System.Data; // pitää muistaa lisätä
using System.Data.SqlClient; // pitää muistaa lisätä
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// author@Antti Kuusisto
/// version 9.5.2022
/// <summary>
/// Pitäisi toimia. Ei testattu.
/// </summary>
namespace Pakkolinen_Ryhmä_Projecti
{
     class ADMINYHTOTTOJAPALAUTE
    {
        Yhdista yh = new Yhdista();

        public DataTable haeYhtotot()
        {
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM otayhteytta", yh.otaYhteys());
                MySqlDataAdapter adapter = new MySqlDataAdapter(); // Luodaan data-adapteri tietokannasta tulevalle tiedolle
                DataTable table = new DataTable(); // Luodaan uusi DataTable jolle tulee tietokannasta tuleva tieto
                adapter.SelectCommand = command; // Adapteriin valitaan Sql komento ja tähän tulee kaikki tietokannasta tuleva tiet
                adapter.Fill(table); // Adapterissa oleva tieto siirretään DataTableen
                adapter.Dispose();
                return table; // palautetaan DataTable 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public bool poistaYhtotto(int id)
        {
            try
            {
                MySqlCommand command = new MySqlCommand("DELETE FROM otayhteytta WHERE ID = @id", yh.otaYhteys()); // tämä kesken
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = id; // arvojen lisäys poistokyselyyn
                yh.avaaYhteys(); // Yhteyden avaus YH CLASS:n funktiolla
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
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public DataTable haePalaute()
        {
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM palaute", yh.otaYhteys());
                MySqlDataAdapter adapter = new MySqlDataAdapter(); // Luodaan data-adapteri tietokannasta tulevalle tiedolle
                DataTable table = new DataTable(); // Luodaan uusi DataTable jolle tulee tietokannasta tuleva tieto
                adapter.SelectCommand = command; // Adapteriin valitaan Sql komento ja tähän tulee kaikki tietokannasta tuleva tiet
                adapter.Fill(table); // Adapterissa oleva tieto siirretään DataTableen
                adapter.Dispose();
                return table; // palautetaan DataTable 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public bool poistaPalaute(int id)
        {
            try
            {
                MySqlCommand command = new MySqlCommand("DELETE FROM palaute WHERE PALAUTE_ID = @id", yh.otaYhteys()); // tämä kesken
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = id; // arvojen lisäys poistokyselyyn
                yh.avaaYhteys(); // Yhteyden avaus YH CLASS:n funktiolla
                if (command.ExecuteNonQuery() == 1) // katsotaan onko komento suoritettu
                {
                    yh.suljeYhteys(); // suljetaan yhteys Yhdista CLASS:n funktiolla
                    return true; // palautetaan true
                }
                else
                {
                    yh.suljeYhteys(); // suljetaan yhteys Yhdista CLASS:n funktiolla
                    return false;  // palautetaan false
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
