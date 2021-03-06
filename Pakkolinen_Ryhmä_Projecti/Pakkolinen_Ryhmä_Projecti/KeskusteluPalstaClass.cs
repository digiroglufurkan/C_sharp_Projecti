using System;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pakkolinen_Ryhmä_Projecti
{
    internal class KeskusteluPalstaClass
    {
        Yhdista yhteys = new Yhdista(); // yhteys

        public bool palstaJuttu(string kommentti, string id)//string kommentti, string idstring id, string kommentti
        {
            try
            {
                MySqlCommand command = new MySqlCommand("INSERT INTO keskustelualue (KAYTTAJA_TUNNUS, KOMMENTTI) VALUES (@id, @kom);", yhteys.otaYhteys());
                command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id; // kirjautunut käyttäjä
                command.Parameters.Add("@kom", MySqlDbType.VarChar).Value = kommentti; // kommentti
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
            catch (MySql.Data.MySqlClient.MySqlException ex) // mikäli tulee virhe
            {
                MessageBox.Show("Error " + ex.Number + " has occurred: " + ex.Message,
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public DataTable haeKommentit()
        {
            try
            {   
                MySqlCommand command = new MySqlCommand("SELECT * FROM keskustelualue", yhteys.otaYhteys());
                MySqlDataAdapter adapter = new MySqlDataAdapter(); 
                DataTable table = new DataTable(); 
                adapter.SelectCommand = command; 
                adapter.Fill(table); 
                adapter.Dispose(); 
                return table; 
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                DataTable table = new DataTable();
                return table; 
            }
        }
    }
}

