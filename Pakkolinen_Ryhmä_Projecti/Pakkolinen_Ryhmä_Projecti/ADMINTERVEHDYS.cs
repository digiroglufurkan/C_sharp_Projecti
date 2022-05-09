using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; // pitää muistaa lisätä
using System.Data; // pitää muistaa lisätä
using System.Data.SqlClient; // pitää muistaa lisätä
/// author@ Antti Kuusisto
/// version 9.5.2022
/// <summary>
/// Hakee käyttäjän nimen. Ehkä myös tulee hakemaan profiilikuvan.
/// </summary>
namespace Pakkolinen_Ryhmä_Projecti
{
    class ADMINTERVEHDYS
    {
        Yhdista yh = new Yhdista(); // muuttuja class:lle
        public string nimi(string id)
        {
            string nimi = "";
            string enimi = "";
            string snimi = "";
            try
            {
                MySqlCommand command1 = new MySqlCommand("SELECT ETUNIMI, SUKUNIMI FROM kayttajat WHERE KAYTTAJA_TUNNUS = @ktun", yh.otaYhteys());
                command1.Parameters.AddWithValue("@ktun", id);
                yh.avaaYhteys();
                // hakukysely DataReaderiin
                MySqlDataReader reader1 = command1.ExecuteReader();
                while (reader1.Read()) // Kun DataReader lukee
                {   // while silmukalla tekstikenttiin käyttäjän tiedot
                    enimi = (reader1["ETUNIMI"].ToString());
                    snimi = (reader1["SUKUNIMI"].ToString());
                    reader1.Close(); // DataReader:n sulku
                    break; // Silmukan lopetus
                }
                nimi = $"{enimi} {snimi}";
                yh.suljeYhteys();
                return nimi;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return nimi;
            }
        }
    }
}
