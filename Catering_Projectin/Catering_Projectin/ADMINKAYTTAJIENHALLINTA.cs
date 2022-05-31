using System;
using MySql.Data.MySqlClient; // pitää muistaa lisätä
using System.Data; // pitää muistaa lisätä
using System.Data.SqlClient; // pitää muistaa lisätä
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// author@ Antti Kuusisto
/// version 30.5.2022
/// <summary>
/// Toiminta toiminta tietokannassa, kun hallitaan käyttäjätilejä
/// </summary>
namespace Catering_Projectin
{
    class ADMINKAYTTAJIENHALLINTA
    {
        Yhdista yh = new Yhdista();

        public DataTable haeKayttajat()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM kayttajat", yh.otaYhteys());
            MySqlDataAdapter adapter = new MySqlDataAdapter(); // Luodaan data-adapteri tietokannasta tulevalle tiedolle
            DataTable table = new DataTable(); // Luodaan uusi DataTable jolle tulee tietokannasta tuleva tieto
            adapter.SelectCommand = command; // Adapteriin valitaan Sql komento ja tähän tulee kaikki tietokannasta tuleva tiet
            adapter.Fill(table); // Adapterissa oleva tieto siirretään DataTableen
            return table; // palautetaan DataTable 
        }

        public bool poistaKayttaja(int id)
        {
            try
            {
                // käyttäjänpoistokysely ja yhteyden muodostus
                MySqlCommand command = new MySqlCommand("DELETE FROM kayttajat WHERE KayttajaID = @id", yh.otaYhteys()); // tämä kesken
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = id; //käyttäjä tunnuksen lisäys
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
            catch (Exception ex) // poimitaan virhe
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool lisaaAdmin(int id)
        {
            try
            {
                int adNum = 1; // ilmoittaa, että on admin
                // Päivityskysely ja yhteyden muodostaminen
                MySqlCommand command = new MySqlCommand("Update `kayttajat` Set `RoolitID` = @ad WHERE KayttajaID = @id", yh.otaYhteys());
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = id; //käyttäjä tunnuksen lisäys
                command.Parameters.Add("@ad", MySqlDbType.Int32).Value = adNum; // admin arvon lisäys
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
            catch (Exception ex) // poimitaan virhe
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        // Poistetaan Admin oikeudet
        public bool poistaAdmin(int id)
        {
            try
            {
                int rooli = 3;
                // Päivityskysely ja yhteyden muodostaminen
                MySqlCommand command = new MySqlCommand("Update `kayttajat` Set `RoolitID` = @ad WHERE KayttajaID = @id", yh.otaYhteys());
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = id; //käyttäjä tunnuksen lisäys
                command.Parameters.Add("@ad", MySqlDbType.Int32).Value = rooli; // admin arvon lisäys
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
            catch (Exception ex) // poimitaan virhe
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
