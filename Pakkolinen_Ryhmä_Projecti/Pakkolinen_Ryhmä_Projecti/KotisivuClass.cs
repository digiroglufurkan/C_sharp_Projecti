using System;
using MySql.Data.MySqlClient; 
using System.Data; 
using System.Data.SqlClient; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pakkolinen_Ryhmä_Projecti
{
    internal class KotisivuClass
    {
        Yhdista yhteys = new Yhdista();

        public DataTable haeUudet()
        {
            try
            {   
                MySqlCommand command = new MySqlCommand("SELECT KAYTTAJA_TUNNUS, TIEDOSTON_NIMI, kuvaus, Date FROM ladattavat_tiedostot", yhteys.otaYhteys());
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

        public bool lataaUusi(int id)
        {
            try
            {
                MySqlDataReader myData; // muuttuja DataReader:lle
                UInt32 FileSize; // muuttuja tiedosto koolle
                byte[] rawData; // muuttuja tiedoston datalle
                string content; // muuttuja tietotyypille
                FileStream fs; // muuttuja filestream metodille
                // Kysely ladattavat_tiedostot tietokantaan ja yhteyden muodostus
                MySqlCommand command = new MySqlCommand("SELECT TIEDOSTON_NIMI, file_size, Tiedosto, extension FROM ladattavat_tiedostot WHERE LadattavatID = @oid;", yhteys.otaYhteys());
                // id parametrin lisäys kyselyyn 
                command.Parameters.Add("@oid", MySqlDbType.UInt32).Value = id;
                yhteys.avaaYhteys(); // yhteys auki
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
                    yhteys.suljeYhteys(); // suljetaan yhteys
                    return false; // palautetaan false
                }
                string sfdname = saveFileDialog1.FileName; // otetaan talteen käyttäjän antama tiedostonimi
                                                           // määritetään mitä kirjoitetaan FileStream metodilla valittuun tiedostoon huomaa tiedoston nimeäminen ja tiedostotyypin lisäys (nimi + . + tyyppi)
                fs = new FileStream(sfdname + "." + content, FileMode.OpenOrCreate, FileAccess.Write);
                fs.Write(rawData, 0, (int)FileSize); // Kirjoitetaan tiedosto
                fs.Close(); // suljetaan FileStream
                myData.Close(); // suljetaan DataReader
                yhteys.suljeYhteys(); // suljetaan yhteys
                return true; // palautetaan true 
            }
            catch (MySql.Data.MySqlClient.MySqlException ex) // poimitaan virhe talteen
            {
                MessageBox.Show("Error " + ex.Number + " has occurred: " + ex.Message,
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // palautetaan false
            }
        }
    }
}
