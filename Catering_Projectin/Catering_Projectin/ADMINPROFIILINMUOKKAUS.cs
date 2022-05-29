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
        public bool paivitaTiedot(string enimi, string snimi, string email, int puh, string osoite, int postinro, string postitoimi
            , string id)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("Update `kayttajat` Set `Etunimi` = @eni, `Sukunimi` = @sni, `Email` =@email, `Puhelin` =@puh, `Osoite` =@oso,`Postitoimipaikka` =@ptoi, `Postinumero` =@pnro WHERE KayttajaTunnus =@id", yh.otaYhteys());
                cmd.Parameters.Add("@eni", MySqlDbType.VarChar).Value = enimi;
                cmd.Parameters.Add("@sni", MySqlDbType.VarChar).Value = snimi;
                cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
                cmd.Parameters.Add("@puh",MySqlDbType.Int32).Value = puh;
                cmd.Parameters.Add("@oso",MySqlDbType.VarChar).Value = osoite;
                cmd.Parameters.Add("@ptoi", MySqlDbType.VarChar).Value = postitoimi;
                cmd.Parameters.Add("@pnro", MySqlDbType.Int32).Value = postinro;
                cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

                yh.avaaYhteys(); // avataan yhteys tietokantaan YH CLASS:ssa olevan funktion avulla
                if (cmd.ExecuteNonQuery() == 1) // Katsotaan suoritettiinko komento
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
                MessageBox.Show($"{ex.Message} class");
                return false;
            }
        }
    }
}
