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
///version 9.5.2022
/// <summary>
/// Admin voi vaihtaa käyttäjän salasanan ja lähettää sen käyttäjälle. Myös normaali salasanan vaihto täällä.
/// Pitäisi lisätä, että admin toiminnassa lähtee uusi salasana sähköpostiin ja 
/// tämä on kehitysidea mikä toteutetaan mikäli EHDITÄÄN.
/// Siivottu
/// </summary>
namespace Pakkolinen_Ryhmä_Projecti
{
     class SALASANOJENHALLINTATIETOKANTA
    {
        Yhdista yh = new Yhdista(); // tietokanta yhteys class
        Tiedansyotto salaus = new Tiedansyotto(); // class, jossa salasanan kryptaus on
        
        // Tavallinen salasananpäivitys
        public bool paivitaSalasana(string ktunnus, string uusiSalasana)
        {   
            try
            {
                string salattu = salaus.Encrypt(uusiSalasana); // uuden salasanan kryptaus ennen lähetystä
                                                               // alla tietokannan päivityskysely ja yhteyden muodostus
                MySqlCommand command = new MySqlCommand("Update `kayttajat` Set `SALASANA` = @ssana WHERE KAYTTAJA_TUNNUS = @ktun", yh.otaYhteys());
                command.Parameters.Add("@ktun", MySqlDbType.VarChar).Value = ktunnus; // käyttäjä tunnus kyselyyn
                command.Parameters.Add("@ssana", MySqlDbType.VarChar).Value = salattu; // salasana salattuna kyselyyn
                yh.avaaYhteys(); // yhteys tietokantaan auki
                if (command.ExecuteNonQuery() == 1) // katsotaan toteutuuko kysely
                {
                    yh.suljeYhteys(); // suljetaan yhteys
                    return true; // palautetaan true
                }
                else
                {
                    yh.suljeYhteys(); // suljetaan yhteys
                    return false; // palautetaan false
                }
            }
            catch (Exception ex) // napataan virhe ja näytetään se
            {
                MessageBox.Show(ex.Message);
                return false; // palautetaan false
            }
        }

        // Admin hallitsee salasanoja käyttäjätunnuksella
        public bool vaihdaSalasana(string id, string uusiSalasana)
        {
            try
            {
                
                string salattu = salaus.Encrypt(uusiSalasana); // uuden salasanan kryptaus ennen lähetystä
                // alla tietokannan päivityskysely ja yhteyden muodostus
                MySqlCommand command = new MySqlCommand("Update `kayttajat` Set `SALASANA` = @ssana WHERE KAYTTAJA_TUNNUS = @id", yh.otaYhteys());
                command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id; // käyttäjä tunnus kyselyyn
                command.Parameters.Add("@ssana", MySqlDbType.VarChar).Value = salattu; // salasana salattuna kyselyyn
                yh.avaaYhteys(); // yhteys tietokantaan auki
                if (command.ExecuteNonQuery() == 1) // katsotaan toteutuuko kysely
                {
                    yh.suljeYhteys(); // suljetaan yhteys
                    return true; // palautetaan true
                }
                else
                {
                    yh.suljeYhteys(); // suljetaan yhteys
                    return false; // palautetaan false
                }
            }
            catch (Exception ex) // napataan virhe ja näytetään se
            {
                MessageBox.Show(ex.Message);
                return false; // palautetaan false
            }
        }
    }
    /* KOODIVARASTO
        Alla kokeilu ei käytössä
        public string haeSalasana(string ktunnus)
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
        }
     */
}
