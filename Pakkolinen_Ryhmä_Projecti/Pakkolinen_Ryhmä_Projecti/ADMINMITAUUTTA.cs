using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; // pitää muistaa lisätä
using System.Data; // pitää muistaa lisätä
using System.Data.SqlClient; // pitää muistaa lisätä

namespace Pakkolinen_Ryhmä_Projecti
{
    class ADMINMITAUUTTA
    {
        Yhdista yh = new Yhdista();
        public bool lisaaUutuus(int id)
        {
            //SELECT * FROM ladattavat_tiedostot WHERE LadattavatID = 29; hakukysely malli.
            try
            {
                int lId = 0;
                string tnimi = "";
                string kuvaus = "";
                string date = "";
                MySqlCommand cmd = new MySqlCommand("SELECT LadattavatID, TIEDOSTON_NIMI, kuvaus, DATE FROM ladattavat_tiedostot WHERE LadattavatID = @id", yh.otaYhteys());
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id; // id:n lisäys kyselyyn
                yh.avaaYhteys();
                MySqlDataReader reader1 = cmd.ExecuteReader();
                while (reader1.Read())
                {
                    lId = reader1.GetInt32(0);
                    tnimi = reader1.GetString(1);
                    kuvaus = reader1.GetString(2);
                    date = reader1.GetString(3);
                }
                yh.suljeYhteys(); // suljetaan yhteys Yhdista CLASS:n funktiolla
                //MessageBox.Show($"{lId} {tnimi} {kuvaus} {date}");
                MySqlCommand cmd1 = new MySqlCommand("INSERT INTO mita_uutta (LadattavatID, TIEDOSTON_NIMI, kuvaus, DATE) VALUES (@lid, @tni, @kuv, @date);", yh.otaYhteys());
                cmd1.Parameters.Add("@lid", MySqlDbType.Int32).Value = lId;
                cmd1.Parameters.Add("@tni", MySqlDbType.VarChar).Value = tnimi;
                cmd1.Parameters.Add("@kuv", MySqlDbType.VarChar).Value = kuvaus;
                cmd1.Parameters.Add("@date", MySqlDbType.VarChar).Value = date;
                yh.avaaYhteys(); // avataan yhteys tietokantaan
                if (cmd1.ExecuteNonQuery() == 1) // katsotaan onko komento suoritettu
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public DataTable haeUutuudet()
        {
            try
            {   // Alla Sql komento jossa samassa hakukysely tietokantaan ja yhteydenluonti tietokantaan
                MySqlCommand command = new MySqlCommand("SELECT * FROM mita_uutta", yh.otaYhteys());
                MySqlDataAdapter adapter = new MySqlDataAdapter(); // Luodaan data-adapteri tietokannasta tulevalle tiedolle
                DataTable table = new DataTable(); // Luodaan uusi DataTable jolle tulee tietokannasta tuleva tieto
                adapter.SelectCommand = command; // Adapteriin valitaan Sql komento ja tähän tulee kaikki tietokannasta tuleva tiet
                adapter.Fill(table); // Adapterissa oleva tieto siirretään DataTable.n
                adapter.Dispose(); // ?
                return table; // palautetaan DataTable 
            }
            catch (Exception ex) // mikäli virhe
            {
                MessageBox.Show(ex.Message);
                DataTable table = new DataTable();
                return table; // palautetaan DataTable
            }
        }
        public DataTable haeKaksiUutuutta()
        {
            try
            {   // Alla Sql komento jossa samassa hakukysely tietokantaan ja yhteydenluonti tietokantaan
                MySqlCommand command = new MySqlCommand("SELECT * FROM (SELECT * FROM mita_uutta ORDER BY uutta_id DESC LIMIT 2) sub ORDER BY uutta_id ASC", yh.otaYhteys());
                MySqlDataAdapter adapter = new MySqlDataAdapter(); // Luodaan data-adapteri tietokannasta tulevalle tiedolle
                DataTable table = new DataTable(); // Luodaan uusi DataTable jolle tulee tietokannasta tuleva tieto
                adapter.SelectCommand = command; // Adapteriin valitaan Sql komento ja tähän tulee kaikki tietokannasta tuleva tiet
                adapter.Fill(table); // Adapterissa oleva tieto siirretään DataTable.n
                adapter.Dispose(); // ?
                return table; // palautetaan DataTable 
            }
            catch (Exception ex) // mikäli virhe
            {
                MessageBox.Show(ex.Message);
                DataTable table = new DataTable();
                return table; // palautetaan DataTable
            }
        }
    }
}
