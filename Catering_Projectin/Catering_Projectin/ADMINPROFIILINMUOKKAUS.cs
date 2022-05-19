using System;
using MySql.Data.MySqlClient; // pitää muistaa lisätä
using System.Data; // pitää muistaa lisätä
using System.Data.SqlClient; // pitää muistaa lisätä
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catering_Projectin
{
    class ADMINPROFIILINMUOKKAUS
    {
        Yhdista yh = new Yhdista();
        public bool paivitaTiedot(string enimi, string snimi, string email, string puh, string osoite, string postinro, string postitoimi, string titteli
            , string id)
        {
            try
            {
                MySqlCommand command = new MySqlCommand("Update `kayttajat` Set `ETUNIMI` = @eni, `SUKUNIMI` = @sni, `PUHELIN` =@puh, `EMAIL` =@email, `OSAITE` =@oso, `POSTINUMERO` =@pnro, `TOIMIPAIKKA` =@ptoi, `TITTELI` =@tit, `KUVA` =@img WHERE KAYTTAJA_TUNNUS =@id", yh.otaYhteys());
                yh.avaaYhteys(); // avataan yhteys tietokantaan YH CLASS:ssa olevan funktion avulla
                if (command.ExecuteNonQuery() == 1) // Katsotaan suoritettiinko komento
                {
                    yh.suljeYhteys(); // Suljetaan yhteys tietokantaan YH CLASS:ssa olevan funktion avulla
                    return true; // viestin palautus
                }
                else // mikäli ei onnistunut tietokannan muokkaus
                {
                    yh.suljeYhteys();  // Suljetaan yhteys tietokantaan YH CLASS:ssa olevan funktion avulla 
                    return false; // viestin palautus
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
