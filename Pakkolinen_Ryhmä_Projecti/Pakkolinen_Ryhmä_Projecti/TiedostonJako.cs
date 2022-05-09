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
    internal class TiedostonJako
    {
        Yhdista yhteys = new Yhdista();


        public bool jaaTiedosto(string path, string filename, string kuvaus, string content, string id)
        {

            {
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
                    MySqlCommand command = new MySqlCommand("INSERT INTO ladattavat_tiedostot (KAYTTAJA_TUNNUS, TIEDOSTON_NIMI, kuvaus, file_size, Tiedosto, extension) VALUES (@ktun, @FileName, @kuvaus, @FileSize, @File, @ext);", yhteys.otaYhteys());
                    command.Parameters.Add("@ktun", MySqlDbType.VarChar).Value = id; // käyttäjä, joka lisää tiedoston
                    command.Parameters.Add("@FileName", MySqlDbType.VarChar).Value = filename; // tiedoston nimi
                    command.Parameters.Add("@kuvaus", MySqlDbType.VarChar).Value = kuvaus; // tiedoston kuvaus
                    command.Parameters.Add("@FileSize", MySqlDbType.VarChar).Value = FileSize; // tiedoston koko
                    command.Parameters.Add("@File", MySqlDbType.LongBlob).Value = rawData; // tiedoston data
                    command.Parameters.Add("@ext", MySqlDbType.VarChar).Value = content; // tietotyypi
                    yhteys.avaaYhteys(); // avataan yhteys tietokantaan
                    if (command.ExecuteNonQuery() == 1) // katsotaan onko komento suoritettu
                    {
                        yhteys.suljeYhteys(); // suljetaan yhteys Yhdista CLASS:n funktiolla
                        return true; // vastauksen palautus
                    }
                    else
                    {
                        yhteys.suljeYhteys(); // suljetaan yhteys Yhdista CLASS:n funktiolla
                        return false;  // vastauksen palautus
                    }
                }
                catch (MySql.Data.MySqlClient.MySqlException ex) // mikäli tulee viehe
                {
                    MessageBox.Show("Error " + ex.Number + " has occurred: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }
        }
    }
}
            
