using MySql.Data.MySqlClient; // pitää muistaa lisätä
using System.Data; // pitää muistaa lisätä
using System.Data.SqlClient; // pitää muistaa lisätä
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pakkolinen_Ryhmä_Projecti
{
     class ADMINYHTOTTOJAPALAUTE
    {
        Yhdista yh = new Yhdista();

        public DataTable haeYhtotot()
        {
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM otayhteytta", yh.otaYhteys());
                MySqlDataAdapter adapter = new MySqlDataAdapter(); // Luodaan data-adapteri tietokannasta tulevalle tiedolle
                DataTable table = new DataTable(); // Luodaan uusi DataTable jolle tulee tietokannasta tuleva tieto
                adapter.SelectCommand = command; // Adapteriin valitaan Sql komento ja tähän tulee kaikki tietokannasta tuleva tiet
                adapter.Fill(table); // Adapterissa oleva tieto siirretään DataTableen
                adapter.Dispose();
                return table; // palautetaan DataTable 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public bool poistaYhtotto(string id)
        {
            try
            {
                bool va; // määritys palutettavalle muutujalle
                MySqlCommand command = new MySqlCommand("DELETE FROM otayhteytta WHERE ID = @id", yh.otaYhteys()); // tämä kesken
                command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id; // arvojen lisäys poistokyselyyn
                yh.avaaYhteys(); // Yhteyden avaus YH CLASS:n funktiolla
                if (command.ExecuteNonQuery() == 1) // katsotaan onko komento suoritettu
                {
                    yh.suljeYhteys(); // suljetaan yhteys Yhdista CLASS:n funktiolla
                    va = true; // vastaus viesti
                    return va; // vastauksen palautus
                }
                else
                {
                    yh.suljeYhteys(); // suljetaan yhteys Yhdista CLASS:n funktiolla
                    va = false;// vastaus viesti
                    return va;  // vastauksen palautus
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public DataTable haePalaute()
        {
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM palaute", yh.otaYhteys());
                MySqlDataAdapter adapter = new MySqlDataAdapter(); // Luodaan data-adapteri tietokannasta tulevalle tiedolle
                DataTable table = new DataTable(); // Luodaan uusi DataTable jolle tulee tietokannasta tuleva tieto
                adapter.SelectCommand = command; // Adapteriin valitaan Sql komento ja tähän tulee kaikki tietokannasta tuleva tiet
                adapter.Fill(table); // Adapterissa oleva tieto siirretään DataTableen
                adapter.Dispose();
                return table; // palautetaan DataTable 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public bool poistaPalaute(string id)
        {
            try
            {
                bool va; // määritys palutettavalle muutujalle
                MySqlCommand command = new MySqlCommand("DELETE FROM palaute WHERE ID = @id", yh.otaYhteys()); // tämä kesken
                command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id; // arvojen lisäys poistokyselyyn
                yh.avaaYhteys(); // Yhteyden avaus YH CLASS:n funktiolla
                if (command.ExecuteNonQuery() == 1) // katsotaan onko komento suoritettu
                {
                    yh.suljeYhteys(); // suljetaan yhteys Yhdista CLASS:n funktiolla
                    va = true; // vastaus viesti
                    return va; // vastauksen palautus
                }
                else
                {
                    yh.suljeYhteys(); // suljetaan yhteys Yhdista CLASS:n funktiolla
                    va = false;// vastaus viesti
                    return va;  // vastauksen palautus
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
