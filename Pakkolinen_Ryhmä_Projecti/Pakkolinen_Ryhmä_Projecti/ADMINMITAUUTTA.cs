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
        Yhdista yh = new Yhdista(); // tietokantayhteys

        // Lisätään uutuus mita_uutta table:n
        public bool lisaaUutuus(int id)
        { 
            try
            {
                int lId = 0; // muuttuja LadattavatID tiedolle
                string tnimi = ""; // muuttuja TIEDOSTON_NIMI tiedolle
                string kuvaus = ""; // muuttuja kuvaus tiedolle
                string date = ""; // muuttuja DATE tiedolle
                // hakukysely ladattavat_tiedostot tietokantaan ja yhteyden muodostus
                MySqlCommand cmd = new MySqlCommand("SELECT LadattavatID, TIEDOSTON_NIMI, kuvaus, DATE FROM ladattavat_tiedostot WHERE LadattavatID = @id", yh.otaYhteys());
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id; // id:n lisäys kyselyyn
                yh.avaaYhteys(); // yhteys auki
                MySqlDataReader reader1 = cmd.ExecuteReader(); // Kysely datareader:n
                while (reader1.Read()) // while silmukalla luku
                {
                    lId = reader1.GetInt32(0); // LadattavatID
                    tnimi = reader1.GetString(1); // TIEDOSTON_NIMI
                    kuvaus = reader1.GetString(2); // kuvaus
                    date = reader1.GetString(3); // DATE
                }
                yh.suljeYhteys(); // suljetaan yhteys Yhdista CLASS:n funktiolla
                // Lisäyskysely mita_uutta tietokantaan ja yhteyden muodostus
                MySqlCommand cmd1 = new MySqlCommand("INSERT INTO mita_uutta (LadattavatID, TIEDOSTON_NIMI, kuvaus, DATE) VALUES (@lid, @tni, @kuv, @date);", yh.otaYhteys());
                cmd1.Parameters.Add("@lid", MySqlDbType.Int32).Value = lId; // LadattavatID
                cmd1.Parameters.Add("@tni", MySqlDbType.VarChar).Value = tnimi; // TIEDOSTON_NIMI
                cmd1.Parameters.Add("@kuv", MySqlDbType.VarChar).Value = kuvaus; // kuvaus
                cmd1.Parameters.Add("@date", MySqlDbType.VarChar).Value = date; // DATE
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

        // Mitä uutta datagridvievw:n sisällön hakeminen
        public DataTable haeUutuudet()
        {
            try
            {   // Alla Sql komento jossa samassa hakukysely tietokantaan ja yhteydenluonti
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

        // KIRJAUTUNEEN KOTISIVUN DATAGRIDVIVW:N TÄYTTÖ
        public DataTable haeKaksiUutuutta()
        {
            try
            {   // Alla hakukysely mita_uutta tietokantaan ja yhteydenluonti. Moniosainen kyselylause.
                MySqlCommand command = new MySqlCommand("SELECT LadattavatID, TIEDOSTON_NIMI, kuvaus, Date FROM (SELECT * FROM mita_uutta ORDER BY uutta_id DESC LIMIT 2) sub ORDER BY uutta_id ASC", yh.otaYhteys());
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

        // KIRJAUTUNEEN KOTISIVUN DATAGRIDVIVW:N LATAA BUTTON:N KUTSUMA METODI
        public bool lataaUutuus(int id)
        {
            try
            {
                MySqlDataReader myData; // muuttuja DataReader:lle
                UInt32 FileSize; // muuttuja tiedosto koolle
                byte[] rawData; // muuttuja tiedoston datalle
                string content; // muuttuja tietotyypille
                FileStream fs; // muuttuja filestream metodille
                // Kysely ladattavat_tiedostot tietokantaan ja yhteyden muodostus
                MySqlCommand command = new MySqlCommand("SELECT TIEDOSTON_NIMI, file_size, Tiedosto, extension FROM ladattavat_tiedostot WHERE LadattavatID = @oid;", yh.otaYhteys());
                // id parametrin lisäys kyselyyn 
                command.Parameters.Add("@oid", MySqlDbType.UInt32).Value = id;
                yh.avaaYhteys(); // yhteys auki
                myData = command.ExecuteReader(); // aletaan lukemaan dataa

                if (!myData.HasRows) // mikäli ei saada oikeaa dataa
                    throw new Exception("There are no BLOBs to save");

                myData.Read(); // luetaan dataa
                FileSize = myData.GetUInt32(myData.GetOrdinal("file_size")); // luetaan tiedoston koko
                rawData = new byte[FileSize]; // Tiedoston data array:n koon määritys
                content = myData.GetString(myData.GetOrdinal("extension")); // luetaan tietotyyppi
                                                                            // Luetaan tiedoston data
                myData.GetBytes(myData.GetOrdinal("Tiedosto"), 0, rawData, 0, (int)FileSize);
                // Kutsutaa saveFileDialog
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.InitialDirectory = "C:"; // Hakemisto, johon tiedoston tallennus aukeaa
                saveFileDialog1.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"; // Nyt tälläiset filter määritykset
                saveFileDialog1.Title = "Save File"; // Otsikko
                DialogResult result = saveFileDialog1.ShowDialog(); // Näytetään dialogi
                if (result == DialogResult.Cancel)
                {
                    myData.Close(); // suljetaan DataReader
                    yh.suljeYhteys(); // suljetaan yhteys
                    return false; // palautetaan false
                }
                string sfdname = saveFileDialog1.FileName; // otetaan talteen käyttäjän antama tiedostonimi
                                                           // määritetään mitä kirjoitetaan FileStream metodilla valittuun tiedostoon huomaa tiedoston nimeäminen ja tiedostotyypin lisäys (nimi + . + tyyppi)
                fs = new FileStream(sfdname + "." + content, FileMode.OpenOrCreate, FileAccess.Write);
                fs.Write(rawData, 0, (int)FileSize); // Kirjoitetaan tiedosto
                fs.Close(); // suljetaan FileStream
                myData.Close(); // suljetaan DataReader
                yh.suljeYhteys(); // suljetaan yhteys
                return true; // palautetaan true 
            }
            catch (MySql.Data.MySqlClient.MySqlException ex) // poimitaan virhe talteen
            {
                MessageBox.Show("Error " + ex.Number + " has occurred: " + ex.Message,
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // palautetaan false
            }
        }

        // uutuuden poisto mita_uutta tietokannasta
        public bool poistaUutuus(int id)
        {
            // Aloitus try:lla
            try
            {
                // Poisto kysely
                MySqlCommand command = new MySqlCommand("DELETE FROM mita_uutta WHERE uutta_id = @id", yh.otaYhteys()); // tämä kesken
                command.Parameters.Add("@id", MySqlDbType.UInt32).Value = id; // id:n lisäys poistokyselyyn
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
            catch (Exception ex) // mikäli tylee virhe
            {
                MessageBox.Show($"{ex.Message} v3");
                return false;
            }
        }
    }
}
