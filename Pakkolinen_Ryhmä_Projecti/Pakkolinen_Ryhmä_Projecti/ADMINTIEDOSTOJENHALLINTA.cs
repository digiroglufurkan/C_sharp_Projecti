using MySql.Data.MySqlClient; // pitää muistaa lisätä
using System.Data; // pitää muistaa lisätä
using System.Data.SqlClient; // pitää muistaa lisätä
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// author@Antti Kuusisto
/// version 6.5.2022
/// <summary>
/// HUOMIO!!! VAATII MUOKKAAMANI TIETOKANNAN, JOTTA TOIMII. HUOMIO!!!
/// Tiedoston poisto toimii. Lataus tietokannasta toimii. Tietokantaan lataus: PUUTTUU DYNAAMINEN KÄYTTÄJÄTUNNUS
/// ja vaatii päätöksen tietotyypeistä tai regex:n käyttöä tyypin poimimiseen tiedoston nimestä.
/// </summary>
namespace Pakkolinen_Ryhmä_Projecti
{
    class ADMINTIEDOSTOJENHALLINTA
    {
        Yhdista yh = new Yhdista();// Muuttuja tietokanta yhteyden class:n

        public bool jaaTiedosto(string path, string filename,string content)
        // Metodi tiedoston lisäämiseen tietokantaan. Muuttujat sijainti,nimi,tietotyyppi.
        {
            /*try // jokin kokeilu joka kommentoitu pois käytöstä.
            {
                bool va;
                //string path = Path.GetDirectoryName(openFileDialog1.FileName);
                //string filename = System.IO.Path.GetFileName(openFileDialog1.FileName);
                byte[] rawData = File.ReadAllBytes(path);
                FileInfo info = new FileInfo(filename);//
                MySqlCommand command = new MySqlCommand("INSERT INTO ladattavat_tiedostot (KAYTTAJA_TUNNUS, TIEDOSTON_NIMI, Tiedosto) VALUES (?id, ?fileName, ?rawData);", yh.otaYhteys());
                MySqlParameter TIEDOSTON_NIMI = new MySqlParameter("?fileName", MySqlDbType.VarChar);
                MySqlParameter Tiedosto = new MySqlParameter("?rawData", MySqlDbType.Blob, rawData.Length);
                MySqlParameter KAYTTAJA_TUNNUS = new MySqlParameter("?id", MySqlDbType.VarChar);
                Tiedosto.Value = rawData;
                TIEDOSTON_NIMI.Value = info.Name;
                KAYTTAJA_TUNNUS.Value = "testesti";
                command.Parameters.Add(Tiedosto);
                command.Parameters.Add(TIEDOSTON_NIMI);
                command.Parameters.Add(KAYTTAJA_TUNNUS);
                yh.avaaYhteys();
                if (command.ExecuteNonQuery() == 1) // Katsotaan suoritettiinko komento
                {
                    yh.suljeYhteys(); // Suljetaan yhteys tietokantaan YH CLASS:ssa olevan funktion avulla
                    va = true; // Vastaus viesti
                    return va; // viestin palautus
                }
                else // mikäli ei onnistunut tietokannan muokkaus
                {
                    yh.suljeYhteys();  // Suljetaan yhteys tietokantaan YH CLASS:ssa olevan funktion avulla 
                    va = false; // Vastaus viesti
                    return va; // viestin palautus
                }
                /*yh.suljeYhteys();
                MessageBox.Show($"Tiedosto ladattu tietokantaan.");*/
            /*}
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} virhe2 ");
                return false;
            }*/
            // Aloitus try:lla
            try
            {
                UInt32 FileSize; // muutuja tiedoston koolle
                byte[] rawData; // muuttuja tiedoston datalle
                FileStream fs; // muuttuja filestream metodille
                fs = new FileStream(path, FileMode.Open, FileAccess.Read); // määritellään mikä tiedosto avataan ja luetaan 
                FileSize = (uint)fs.Length; //luetaan tiedoston koko
                rawData = new byte[FileSize]; //määritellään data array:n koko
                fs.Read(rawData, 0, (int)FileSize); //luetaan tiedosto muuttujiin
                fs.Close(); // suljetaan filestream
                // Tietokanta kysely ja avataan yhteys tietokantaan
                MySqlCommand command = new MySqlCommand("INSERT INTO ladattavat_tiedostot (KAYTTAJA_TUNNUS, TIEDOSTON_NIMI, file_size, Tiedosto, extension) VALUES (@ktun, @FileName, @FileSize, @File, @ext);", yh.otaYhteys());
                command.Parameters.Add("@ktun", MySqlDbType.VarChar).Value = "testesti"; // käyttäjä, joka lisää tiedoston
                command.Parameters.Add("@FileName", MySqlDbType.VarChar).Value = filename; // tiedoston nimi
                command.Parameters.Add("@FileSize", MySqlDbType.VarChar).Value = FileSize; // tiedoston koko
                command.Parameters.Add("@File", MySqlDbType.LongBlob).Value = rawData; // tiedoston data
                command.Parameters.Add("@ext", MySqlDbType.VarChar).Value = content; // tietotyypi
                yh.avaaYhteys(); // avataan yhteys tietokantaan
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
                /*command.ExecuteNonQuery();

                MessageBox.Show("File Inserted into database successfully!",
                    "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                yh.suljeYhteys();
                return true;*/
            }
            catch (MySql.Data.MySqlClient.MySqlException ex) // mikäli tulee viehe
            {
                MessageBox.Show("Error " + ex.Number + " has occurred: " + ex.Message,
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
}
        public DataTable haeLataukset()
        {
            // Aloitetaan try:lla
            try
            {   // Alla Sql komento jossa samassa hakukysely tietokantaan ja yhteydenluonti tietokantaan
                MySqlCommand command = new MySqlCommand("SELECT LadattavatID, KAYTTAJA_TUNNUS, TIEDOSTON_NIMI, file_size,extension, DATE FROM ladattavat_tiedostot", yh.otaYhteys());
                MySqlDataAdapter adapter = new MySqlDataAdapter(); // Luodaan data-adapteri tietokannasta tulevalle tiedolle
                DataTable table = new DataTable(); // Luodaan uusi DataTable jolle tulee tietokannasta tuleva tieto
                adapter.SelectCommand = command; // Adapteriin valitaan Sql komento ja tähän tulee kaikki tietokannasta tuleva tiet
                adapter.Fill(table); // Adapterissa oleva tieto siirretään DataTable.n
                adapter.Dispose(); // ?
                return table; // palautetaan DataTable 
            }
            catch (Exception ex) // mikäli virhe
            {
                /*MySqlCommand command = new MySqlCommand("SELECT KAYTTAJA_TUNNUS, ETUNIMI, SUKUNIMI, EMAIL, PUHELIN, OSAITE, POSTINUMERO, TOIMIPAIKKA, TITTELI, SALASANA, MAARAAIKA FROM kayttajat", yh.otaYhteys());
                MySqlDataAdapter adapter = new MySqlDataAdapter(); // Luodaan data-adapteri tietokannasta tulevalle tiedolle
                DataTable table = new DataTable(); // Luodaan uusi DataTable jolle tulee tietokannasta tuleva tieto
                adapter.SelectCommand = command; // Adapteriin valitaan Sql komento ja tähän tulee kaikki tietokannasta tuleva tieto
                adapter.Fill(table); // Adapterissa oleva tieto siirretään DataTableen*/
                MessageBox.Show(ex.Message);
                DataTable table = new DataTable();
                return table; // palautetaan DataTable
            }
        }
        public bool poistaTiedosto(int id)
        {   // Aloitus try:lla
            try
            {
                // Poisto kysely
                MySqlCommand command = new MySqlCommand("DELETE FROM ladattavat_tiedostot WHERE LadattavatID = @id", yh.otaYhteys()); // tämä kesken
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
            catch(Exception ex) // mikäli tylee virhe
            {
                MessageBox.Show($"{ex.Message} v3");
                return false;
            }
        }
        /* TIEDOSTON LATAUKSEEN KAKSI(2) VERSIOTA. KÄYTÖSSÄ OLEVA TOIMII,
           POIS KOMMENTOITU SEKOAA, JOS KESKEYTTÄÄ TALLENNUS DIALOGIN.
           VAIN KÄYTÖSSÄ OLEVA ON KOMMENTOITU.
      */public bool lataaTiedosto(int id)
        {   
            //SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            //string sfdname;
            try
            {
                 MySqlDataReader myData; // muuttuja DataReader:lle
                 //string SQL;
                 UInt32 FileSize; // muuttuja tiedosto koolle
                byte[] rawData; // muuttuja tiedoston datalle
                string content; // muuttuja tietotyypille
                FileStream fs; // muuttuja filestream metodille
                // Kysely tietokantaan ja yhteyden avaus
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
                 saveFileDialog1.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"; // Nyt tälläiset filter määritykset
                 saveFileDialog1.Title = "Save File"; // Otsikko
                 saveFileDialog1.ShowDialog(); // Näytetään dialogi
                 string sfdname = saveFileDialog1.FileName; // otetaan talteen käyttäjän antama tiedostonimi
                 // määritetään mitä kirjoitetaan FileStream metodilla valittuun tiedostoon 
                 fs = new FileStream(sfdname + content, FileMode.OpenOrCreate, FileAccess.Write); 
                 fs.Write(rawData, 0, (int)FileSize); // Kirjoitetaan tiedosto
                 fs.Close(); // suljetaan FileStream
                 myData.Close(); // suljetaan DataReader
                yh.suljeYhteys(); // suljetaan yhteys
                 return true; // palautetaan true 
                /*MySqlDataReader myData;
                string SQL;
                UInt32 FileSize;
                byte[] rawData;
                FileStream fs;
                BinaryWriter bw;                        // Streams the BLOB to the FileStream object.
                int bufferSize = 100;                   // Size of the BLOB buffer.
                byte[] outbyte = new byte[bufferSize];  // The BLOB byte[] buffer to be filled by GetBytes.
                long retval;                            // The bytes returned from GetBytes.
                long startIndex = 0;                    // The starting position in the BLOB output.
                MySqlCommand command = new MySqlCommand("SELECT Tiedosto FROM ladattavat_tiedostot WHERE LadattavatID = @oid;", yh.otaYhteys());
                command.Parameters.Add("@oid", MySqlDbType.UInt32).Value = id;
                yh.avaaYhteys();
                myData = command.ExecuteReader(CommandBehavior.SequentialAccess);

                if (!myData.HasRows)
                    throw new Exception("There are no BLOBs to save");

                //myData.Read();
                while (myData.Read())
                {
                    // Get the publisher id, which must occur before getting the logo.
                    //pub_id = myReader.GetString(0);
                    
                    saveFileDialog1.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
                    saveFileDialog1.Title = "Save File";
                    saveFileDialog1.ShowDialog();
                    sfdname = saveFileDialog1.FileName;
                    fs = new FileStream(sfdname + ".js", FileMode.OpenOrCreate, FileAccess.Write);//@"C:\newfile.png", 
                    bw = new BinaryWriter(fs);

                    // Reset the starting byte for the new BLOB.
                    startIndex = 0;

                    // Read the bytes into outbyte[] and retain the number of bytes returned.
                    retval = myData.GetBytes(0, startIndex, outbyte, 0, bufferSize);

                    // Continue reading and writing while there are bytes beyond the size of the buffer.
                    while (retval == bufferSize)
                    {
                        bw.Write(outbyte);
                        bw.Flush();

                        // Reposition the start index to the end of the last buffer and fill the buffer.
                        startIndex += bufferSize;
                        retval = myData.GetBytes(1, startIndex, outbyte, 0, bufferSize);
                    }

                    // Write the remaining buffer.
                    bw.Write(outbyte, 0, (int)retval - 1);
                    bw.Flush();

                    // Close the output file.
                    bw.Close();
                    fs.Close();
                }
                    MessageBox.Show("File successfully written to disk!",
                        "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    myData.Close();
                    yh.suljeYhteys();
                    return true;*/
                /*FileSize = myData.GetUInt32(myData.GetOrdinal("file_size"));
                rawData = new byte[FileSize];

                myData.GetBytes(myData.GetOrdinal("Tiedosto"), 0, rawData, 0, (int)FileSize);
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
                saveFileDialog1.Title = "Save File";
                saveFileDialog1.ShowDialog();
                string sfdname = saveFileDialog1.FileName;
                fs = new FileStream(sfdname + ".js", FileMode.OpenOrCreate, FileAccess.Write);//@"C:\newfile.png", 
                fs.Write(rawData, 0, (int)FileSize);
                fs.Close();
                MessageBox.Show("File successfully written to disk!",
                    "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                */
            }
            catch(MySql.Data.MySqlClient.MySqlException ex) // poimitaan virhe talteen
            {
                MessageBox.Show("Error " + ex.Number + " has occurred: " + ex.Message,
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // palautetaan false
            }
        }
    }
}
