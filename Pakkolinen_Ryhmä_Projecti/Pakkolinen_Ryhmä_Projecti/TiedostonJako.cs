using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pakkolinen_Ryhmä_Projecti
{
    internal class TiedostonJako
    {
        Yhdista yhteys = new Yhdista();


        public string lisaatiedosto(String aihe, String tiedosto)
        {
            MySqlCommand kom = new MySqlCommand();
            String tiedostonjako;
                tiedostonjako = "INSERT INTO `ladattavat_tiedostot`" + "(`TIEDOSTON_NIMI`, `Tiedosto`)" + "VALUES (@tiednimi, @tiedosto)";
            tiedostonjako = "SELECT KAYTTAJA_TUNNUS FROM `ladattavat_tiedostot`";
            kom.CommandText = tiedostonjako;
            kom.Connection = yhteys.otaYhteys();
            //kom.Parameters.Add("@kayttis", MySqlDbType.VarChar).Value = jakaja;
            kom.Parameters.Add("@tiednimi", MySqlDbType.VarChar).Value = aihe;
            kom.Parameters.Add("@tiedosto", MySqlDbType.VarChar).Value = tiedosto;
            

            yhteys.avaaYhteys();
            if (kom.ExecuteNonQuery() == 1)
            {
                yhteys.suljeYhteys();
                return "";
            }
            else
            {
                yhteys.suljeYhteys();
                return "";
            }
        }

        public string palauteyhdistys(String palaute)
        {
            MySqlCommand komento = new MySqlCommand();
            String palautejako;
            palautejako = "INSERT INTO `palaute`(`Aihe`) VALUES(@aih);";
            palautejako = "SELECT KAYTTAJA_TUNNUS FROM `kayttajat`";
            komento.CommandText = palautejako;
            komento.Connection = yhteys.otaYhteys();
            komento.Parameters.Add("@aih", MySqlDbType.VarChar).Value = palaute;
            yhteys.avaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
            {
                yhteys.suljeYhteys();
                return "";
            }
            else
            {
                yhteys.suljeYhteys();
                return "";
            }

        }
    }
}
