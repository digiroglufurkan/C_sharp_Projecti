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
    internal class KirjautunutPalauteClass
    {
        Yhdista yhteys = new Yhdista(); // yhteys

        public bool palauteJuttu(string palaute, string id)
        {
            try
            {
                MySqlCommand command = new MySqlCommand("INSERT INTO palaute (KAYTTAJA_TUNNUS, Aihe) VALUES (@ktun, @palaute);", yhteys.otaYhteys());
                command.Parameters.Add("@ktun", MySqlDbType.VarChar).Value = id; // kirjautunut käyttäjä
                command.Parameters.Add("@palaute", MySqlDbType.VarChar).Value = palaute; // palautenimi
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
        }
    }

