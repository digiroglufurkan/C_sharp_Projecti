using System;
using MySql.Data.MySqlClient; // pitää muistaa lisätä
using System.Data; // pitää muistaa lisätä
using System.Data.SqlClient; // pitää muistaa lisätä
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// author@ Antti Kuusisto
/// version 19.5.2022
/// <summary>
/// Tietokannassa olevien salasanojen hallinta
/// </summary>
namespace Catering_Projectin
{
    internal class ADMINSALASANAT
    {
        Yhdista yh = new Yhdista();
        Tiedansyotto salaus = new Tiedansyotto(); // class, jossa salasanan kryptaus on

        //käyttäjän salasanan vaihtaminen
        public bool paivitaKaytSalasana(string ktun, string saSana)
        {
            try
            {
                string salattu = salaus.Encrypt(saSana); // uuden salasanan kryptaus ennen lähetystä
                // alla tietokannan päivityskysely ja yhteyden muodostus
                MySqlCommand command = new MySqlCommand("Update `kayttajat` Set `Salasana` = @ssana WHERE KayttajaTunnus = @id", yh.otaYhteys());
                command.Parameters.Add("@id", MySqlDbType.VarChar).Value = ktun; // käyttäjä tunnus kyselyyn
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //adminin oman salasanan vaihtaminen
        public bool vaihdaSalasana(string ktun, string saSana)
        {
            try
            {
                string salattu = salaus.Encrypt(saSana); // uuden salasanan kryptaus ennen lähetystä
                                                         // alla tietokannan päivityskysely ja yhteyden muodostus
                MySqlCommand command = new MySqlCommand("Update `kayttajat` Set `Salasana` = @ssana WHERE KayttajaTunnus = @ktun", yh.otaYhteys());
                command.Parameters.Add("@ktun", MySqlDbType.VarChar).Value = ktun; // käyttäjä tunnus kyselyyn
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
}
