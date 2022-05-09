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

    internal class SalasananVaihtoClass
    {
        Yhdista yhteys = new Yhdista();
        //Tiedansyotto salaus = new Tiedansyotto();


        public bool vaihdaSalis(string id, string uusSalisYks)
        {
            try
            {
                //string salattu = salaus.Encrypt(uusSalisYks);
                MySqlCommand command = new MySqlCommand("Update `kayttajat` Set `SALASANA` = @sala WHERE KAYTTAJA_TUNNUS = @id", yhteys.otaYhteys());
                command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
                command.Parameters.Add("@sala", MySqlDbType.VarChar).Value = uusSalisYks;
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

        public DataTable fetchInformation() 
        {   
            try
            {   
                MySqlCommand command = new MySqlCommand("SELECT KAYTTAJA_TUNNUS, SALASANA FROM kayttajat", yhteys.otaYhteys());
                MySqlDataAdapter adapter = new MySqlDataAdapter(); 
                DataTable table = new DataTable(); 
                adapter.SelectCommand = command; 
                adapter.Fill(table); 
                return table; 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex} v1");
                MySqlCommand command = new MySqlCommand("SELECT KAYTTAJA_TUNNUS, SALASANA FROM kayttajat", yhteys.otaYhteys());
                MySqlDataAdapter adapter = new MySqlDataAdapter(); 
                DataTable table = new DataTable(); 
                adapter.SelectCommand = command; 
                adapter.Fill(table); 
                return table; 
            }
        }
    }
}

