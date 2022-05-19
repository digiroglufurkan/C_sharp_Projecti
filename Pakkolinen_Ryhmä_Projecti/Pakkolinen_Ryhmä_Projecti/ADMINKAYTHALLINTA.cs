using MySql.Data.MySqlClient; // pitää muistaa lisätä
using System.Data; // pitää muistaa lisätä
using System.Data.SqlClient; // pitää muistaa lisätä
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// author@ Antti Kuusisto
/// version 7.5.2022
/// <summary>
/// Tietojen hakeminen tietokannasta Datagrid:n toimii sekä käyttäjän poistaminen.
/// </summary>

namespace Pakkolinen_Ryhmä_Projecti
{
    class ADMINKAYTHALLINTA
    {
        Yhdista yh = new Yhdista();
        public DataTable fetchInformation() // haetaan käyttäjien tiedot tietokannasta
        {   // Aloitetaan try:lla
            try
            {   // Alla Sql komento jossa samassa hakukysely tietokantaan ja yhteydenluonti tietokantaan
                MySqlCommand command = new MySqlCommand("SELECT * FROM kayttajat", yh.otaYhteys());
                MySqlDataAdapter adapter = new MySqlDataAdapter(); // Luodaan data-adapteri tietokannasta tulevalle tiedolle
                DataTable table = new DataTable(); // Luodaan uusi DataTable jolle tulee tietokannasta tuleva tieto
                adapter.SelectCommand = command; // Adapteriin valitaan Sql komento ja tähän tulee kaikki tietokannasta tuleva tiet
                adapter.Fill(table); // Adapterissa oleva tieto siirretään DataTableen
                //adapter.Dispose();
                return table; // palautetaan DataTable 
                }
            catch (Exception ex) // poimitaan virhe ja toiminta sen jälkeen
            {
                MySqlCommand command2 = new MySqlCommand("SELECT KAYTTAJA_TUNNUS, ETUNIMI, SUKUNIMI, EMAIL, PUHELIN, OSAITE, POSTINUMERO, TOIMIPAIKKA, TITTELI, SALASANA, MAARAAIKA, ADMIN FROM kayttajat", yh.otaYhteys());
                MySqlDataAdapter adapter2 = new MySqlDataAdapter(); // Luodaan data-adapteri tietokannasta tulevalle tiedolle
                DataTable table2 = new DataTable(); // Luodaan uusi DataTable jolle tulee tietokannasta tuleva tieto
                adapter2.SelectCommand = command2; // Adapteriin valitaan Sql komento ja tähän tulee kaikki tietokannasta tuleva tieto
                adapter2.Fill(table2); // Adapterissa oleva tieto siirretään DataTableen
                return table2; // palautetaan DataTable
            }
            
        }

        // Poistetaan käyttäjä
        public bool deleteKayttaja(string ktun)
        {
            try
            {
                // käyttäjänpoistokysely ja yhteyden muodostus
                MySqlCommand command = new MySqlCommand("DELETE FROM kayttajat WHERE KAYTTAJA_TUNNUS = @ktun", yh.otaYhteys()); // tämä kesken
                command.Parameters.Add("@ktun", MySqlDbType.VarChar).Value = ktun; //käyttäjä tunnuksen lisäys
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

        // Annetaan Admin oikeudet
        public bool lisaaAdmin(string ktun)
        {
            try
            {   int adNum = 1; // ilmoittaa, että on admin
                // Päivityskysely ja yhteyden muodostaminen
                MySqlCommand command = new MySqlCommand("Update `kayttajat` Set `ADMIN` = @ad WHERE KAYTTAJA_TUNNUS = @id", yh.otaYhteys());
                command.Parameters.Add("@id", MySqlDbType.VarChar).Value = ktun; //käyttäjä tunnuksen lisäys
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
        public bool poistaAdmin(string ktun)
        {
            try
            {
                int adNum = 0; // ilmoittaa, että ei ole admin
                // Päivityskysely ja yhteyden muodostaminen
                MySqlCommand command = new MySqlCommand("Update `kayttajat` Set `ADMIN` = @ad WHERE KAYTTAJA_TUNNUS = @id", yh.otaYhteys());
                command.Parameters.Add("@id", MySqlDbType.VarChar).Value = ktun; //käyttäjä tunnuksen lisäys
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
            catch(Exception ex) // poimitaan virhe
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
