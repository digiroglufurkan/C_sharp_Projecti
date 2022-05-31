using System;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catering_Projectin
{
    internal class KokkiSalVaihto
    {
        Yhdista yhteys = new Yhdista();
        Tiedansyotto salaus = new Tiedansyotto();
        public bool vaihdaKokinSalis(string id, string uusiSalisYksi)
        {
            try
            {
                string salattu = salaus.Encrypt(uusiSalisYksi);
                MySqlCommand command = new MySqlCommand("Update `kayttajat` Set `Salasana` = @salis WHERE KayttajaTunnus = @id", yhteys.otaYhteys());
                command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
                command.Parameters.Add("@salis", MySqlDbType.VarChar).Value = salattu;
                yhteys.avaaYhteys();
                if (command.ExecuteNonQuery() == 1)
                {
                    yhteys.suljeYhteys();
                    return true;
                }
                else
                {
                    yhteys.suljeYhteys();
                    return false;
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
