using MySql.Data.MySqlClient; // pitää muistaa lisätä
using System.Data; // pitää muistaa lisätä
using System.Data.SqlClient; // pitää muistaa lisätä
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// author@ Antti Kuusisto
/// version 30.4.2022
/// <summary>
/// Sivut olemassa ja niille siirtyminen toimii, muuten kesken. Tietojen hakeminen tietokannasta Datagrid:n toimii.
/// </summary>

namespace Pakkolinen_Ryhmä_Projecti
{
    class ADMINKAYTHALLINTA
    {
        Yhdista yh = new Yhdista();
        public DataTable fetchInformation() // haetaan opiskelijoiden tiedot tietokannasta
        {   // Alla Sql komento jossa samassa hakukysely tietokantaan ja yhteydenluonti tietokantaan
            try 
            {
                MySqlCommand command = new MySqlCommand("SELECT KAYTTAJA_TUNNUS, ETUNIMI, SUKUNIMI, EMAIL, PUHELIN, OSAITE, POSTINUMERO, TOIMIPAIKKA, TITTELI, SALASANA, MAARAAIKA FROM kayttajat", yh.otaYhteys());
                MySqlDataAdapter adapter = new MySqlDataAdapter(); // Luodaan data-adapteri tietokannasta tulevalle tiedolle
                DataTable table = new DataTable(); // Luodaan uusi DataTable jolle tulee tietokannasta tuleva tieto
                adapter.SelectCommand = command; // Adapteriin valitaan Sql komento ja tähän tulee kaikki tietokannasta tuleva tieto
                adapter.Fill(table); // Adapterissa oleva tieto siirretään DataTableen
                return table; // palautetaan DataTable 
            }
            catch (Exception ex)
            {
                MySqlCommand command = new MySqlCommand("SELECT KAYTTAJA_TUNNUS, ETUNIMI, SUKUNIMI, EMAIL, PUHELIN, OSAITE, POSTINUMERO, TOIMIPAIKKA, TITTELI, SALASANA, MAARAAIKA FROM kayttajat", yh.otaYhteys());
                MySqlDataAdapter adapter = new MySqlDataAdapter(); // Luodaan data-adapteri tietokannasta tulevalle tiedolle
                DataTable table = new DataTable(); // Luodaan uusi DataTable jolle tulee tietokannasta tuleva tieto
                adapter.SelectCommand = command; // Adapteriin valitaan Sql komento ja tähän tulee kaikki tietokannasta tuleva tieto
                adapter.Fill(table); // Adapterissa oleva tieto siirretään DataTableen
                return table; // palautetaan DataTable
            }
            
        }

        public bool deleteKayttaja(string ktun)
        {
            bool va; // määritys palutettavalle muutujalle
            MySqlCommand command = new MySqlCommand("DELETE FROM kayttajat WHERE KAYTTAJA_TUNNUS = @ktun", yh.otaYhteys()); // tämä kesken
            command.Parameters.Add("@ktun", MySqlDbType.VarChar).Value = ktun; // arvojen lisäys poistokyselyyn
            yh.avaaYhteys(); // Yhteyden avaus YH CLASS:n funktiolla
            if (command.ExecuteNonQuery() == 1) // katsotaan onko komento suoritettu
            {
                yh.suljeYhteys(); // suljetaan yhteys Yhdista CLASS:n funktiolla
                va = true; // vastaus viesti
                return va; // vastauksen palautus
            }
            else
            {
                yh.suljeYhteys(); // suljetaan yhteys Yhdista CLASS:n funktiolla
                va = false;// vastaus viesti
                return va;  // vastauksen palautus
            }
        }
    }
}
