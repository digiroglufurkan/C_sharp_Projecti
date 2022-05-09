using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; // pitää muistaa lisätä
using System.Data; // pitää muistaa lisätä
using System.Data.SqlClient; // pitää muistaa lisätä
/// author@ Antti Kuusisto
/// version 9.5.2022
/// <summary>
/// Pitäisi toimia ei vielä testattu
/// </summary>
namespace Pakkolinen_Ryhmä_Projecti
{
     class HALLINTAKESKUSTELUPALSTA
    {
        Yhdista yh = new Yhdista();

        public DataTable haeKeskustelut()
        {
            // Aloitua try:lla
            try
            {    
                MySqlCommand command1 = new MySqlCommand("SELECT * FROM keskustelualue", yh.otaYhteys());
                MySqlDataAdapter adapter = new MySqlDataAdapter(); // Luodaan data-adapteri tietokannasta tulevalle tiedolle
                DataTable table = new DataTable(); // Luodaan uusi DataTable jolle tulee tietokannasta tuleva tieto
                adapter.SelectCommand = command1; // Adapteriin valitaan Sql komento ja tähän tulee kaikki tietokannasta tuleva tiet
                adapter.Fill(table); // Adapterissa oleva tieto siirretään DataTableen
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

        public bool poistaKeskustelu(int tun)
        {
            try
            {
                MySqlCommand command = new MySqlCommand("DELETE FROM keskustelualue WHERE KESKUSTELU_ID = @tun", yh.otaYhteys()); // tämä kesken
                command.Parameters.Add("@tun", MySqlDbType.Int32).Value = tun; // arvojen lisäys poistokyselyyn
                yh.avaaYhteys(); // Yhteyden avaus YH CLASS:n funktiolla
                if (command.ExecuteNonQuery() == 1) // katsotaan onko komento suoritettu
                {
                    yh.suljeYhteys(); // suljetaan yhteys Yhdista CLASS:n funktiolla
                    return true; // vastauksen palautus
                }
                else
                {
                    yh.suljeYhteys(); // suljetaan yhteys Yhdista CLASS:n funktiolla
                    return false;  // vastauksen palautus
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            
        }
    }
}
