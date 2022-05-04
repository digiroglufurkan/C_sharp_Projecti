using System;
using MySql.Data.MySqlClient; // pitää muistaa lisätä
using System.Data; // pitää muistaa lisätä
using System.Data.SqlClient; // pitää muistaa lisätä
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
///author@Antti Kuusisto
///version 3.5.2022
/// <summary>
/// Admin voi vaihtaa käyttäjän salasanan ja lähettää sen käyttäjälle.
/// </summary>
namespace Pakkolinen_Ryhmä_Projecti
{
     class SALASANOJENHALLINTATIETOKANTA
    {
        Yhdista yh = new Yhdista();
        Tiedansyotto salaus = new Tiedansyotto();
        /*public string haeSalasana(string ktunnus)
        {
            string sana = "";
            string salattu = "";
            string salasana = "";
            try
            {
                string query = "SELECT SALASANA FROM kayttajat WHERE KAYTTAJA_TUNNUS =@ktunnus";
                MySqlCommand command1 = new MySqlCommand(query, yh.otaYhteys());
                yh.avaaYhteys();
                command1.Parameters.AddWithValue("@ktunnus", ktunnus);
                //command1.Parameters.AddWithValue("@Emplname", txtEmplyName.Text);
                MySqlDataReader reader1 = command1.ExecuteReader();
                while (reader1.Read())
                {
                    salattu = reader1["SALASANA"].ToString();
                    reader1.Close();
                    break;
                }
                sana = salattu;
                salasana = salaus.Decrypt(sana);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return salasana;
        }*/

        public bool paivitaSalasana(string ktunnus, string uusiSalasana)
        {   //"Update `Yhteystiedot` Set `etunimi`
            //command.Parameters.Add("@fnm", MySqlDbType.VarChar).Value = fName;
            bool vastaus;
            string salattu = salaus.Encrypt(uusiSalasana);
            MySqlCommand command = new MySqlCommand();
            command.Parameters.Add("@ktun", MySqlDbType.VarChar).Value = ktunnus;
            command.Parameters.Add("@ssana", MySqlDbType.VarChar).Value = salattu;
            string updateQuest = "Update `kayttajat` Set `SALASANA` = @ssana WHERE KAYTTAJA_TUNNUS = @ktun"; // Sql lisäys kysely tässä opiskelijanumero on primary key
            command.CommandText = updateQuest; // liitetään tietokantakomentoon muokkauskysely
            command.Connection = yh.otaYhteys(); // muodostetaan yhteys tietokantaan YH CLASS:ssa olevan funktion avulla
            yh.avaaYhteys();
            if (command.ExecuteNonQuery() == 1)
            {
                yh.suljeYhteys();
                vastaus = true;
                return vastaus;
            }
            else
            {
                yh.suljeYhteys();
                vastaus = false;
                return vastaus;
            }
        }

        public bool vaihdaSalasana(string vanhaSalasana, string uusiSalasana)
        {
            try
            {
                bool vastaus;
                string salattu = salaus.Encrypt(uusiSalasana);
                MySqlCommand command = new MySqlCommand();
                command.Parameters.Add("@vssa", MySqlDbType.VarChar).Value = vanhaSalasana;
                command.Parameters.Add("@ssana", MySqlDbType.VarChar).Value = salattu;
                string updateQuest = "Update `kayttajat` Set `SALASANA` = @ssana WHERE SALASANA = @vssa"; // Sql lisäys kysely tässä opiskelijanumero on primary key
                command.CommandText = updateQuest; // liitetään tietokantakomentoon muokkauskysely
                command.Connection = yh.otaYhteys(); // muodostetaan yhteys tietokantaan YH CLASS:ssa olevan funktion avulla
                yh.avaaYhteys();
                if (command.ExecuteNonQuery() == 1)
                {
                    yh.suljeYhteys();
                    vastaus = true;
                    return vastaus;
                }
                else
                {
                    yh.suljeYhteys();
                    vastaus = false;
                    return vastaus;
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
