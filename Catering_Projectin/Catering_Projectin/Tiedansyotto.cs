
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using System.Windows.Forms;


namespace Catering_Projectin
{
    internal class Tiedansyotto
    {
        Yhdista yhteys = new Yhdista();

        public string lisatyontekija(String enimi, String snimi, String email, int puh, string osoite, int posti, string toimi, String salasana, int rooli)
        {
            String ktunnus = enimi.ToLower() + "." + snimi.ToLower();
            String salattu = Encrypt(salasana);
            MySqlCommand komento = new MySqlCommand();
            String lisayskysely;
            {
                lisayskysely = "INSERT INTO `kayttajat`(`RoolitID`,`KayttajaTunnus`,`Salasana`,`Etunimi`,`Sukunimi`,`Email`,`Puhelin`,`Osoite`,`Postitoimipaikka`,`Postinumero`)VALUES (@role,@usr,@ssa,@etu,@suku,@eml,@puh,@oso,@toim,@post);";
            }
            komento.CommandText = lisayskysely;
            komento.Connection = yhteys.otaYhteys();
            komento.Parameters.Add("@etu", MySqlDbType.VarChar).Value = enimi;
            komento.Parameters.Add("@suku", MySqlDbType.VarChar).Value = snimi;
            komento.Parameters.Add("@eml", MySqlDbType.VarChar).Value = email;
            komento.Parameters.Add("@puh", MySqlDbType.Int32).Value = puh;
            komento.Parameters.Add("@oso", MySqlDbType.VarChar).Value = osoite;
            komento.Parameters.Add("@post", MySqlDbType.Int32).Value = posti;
            komento.Parameters.Add("@toim", MySqlDbType.VarChar).Value = toimi;
            //komento.Parameters.Add("@yht", MySqlDbType.VarChar).Value = yhtio;
            //komento.Parameters.Add("@icao", MySqlDbType.VarChar).Value = icao;
            komento.Parameters.Add("@usr", MySqlDbType.VarChar).Value = ktunnus;
            komento.Parameters.Add("@ssa", MySqlDbType.VarChar).Value = salattu;
            komento.Parameters.Add("@role", MySqlDbType.Int32).Value = rooli;

            yhteys.avaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
            {
                yhteys.suljeYhteys();
                return ktunnus;
            }
            else
            {
                yhteys.suljeYhteys();
                return "";
            }
        }

        public bool yhtioTiedot(string yhtio, string icao)
        {
            try
            {
                int yhtId = 0;
                MySqlCommand cmd = new MySqlCommand("INSERT INTO `lentoyhtionyhteyshenkilot`(YhtionNimi,ICAOkoodi) VALUES (@yht,@icao)", yhteys.otaYhteys());
                cmd.Parameters.Add("@yht", MySqlDbType.VarChar).Value = yhtio;
                cmd.Parameters.Add("@icao", MySqlDbType.VarChar).Value = icao;
                yhteys.avaaYhteys();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    /*MySqlCommand cmd1 = new MySqlCommand("SELECT YhtioID FROM lentoyhtionyhteyshenkilot WHERE ICAOkoodi = @icao");
                    cmd1.Parameters.Add("@icao", MySqlDbType.VarChar).Value = icao;
                    MySqlDataReader reader1 = cmd1.ExecuteReader();
                    while (reader1.Read()) // Kun DataReader lukee
                    {   // while silmukalla tekstikenttiin käyttäjän tiedot
                        yhtId = (int)reader1.GetInt32(0);
                        //(reader1["Email"].ToString());
                        reader1.Close(); // DataReader:n sulku
                        break; // Silmukan lopetus
                    }*/
                    yhteys.suljeYhteys();
                    //MessageBox.Show($"{yhtId}");
                    return true;
                }
                else
                {
                    //yhteys.suljeYhteys();
                    return false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public string lisakayttaja(String enimi, String snimi, String email, int puh, string osoite, int posti, string toimi, String salasana, int rooli, int yhtID)
        {
            try
            {
                String ktunnus = enimi.ToLower() + "." + snimi.ToLower();
                String salattu = Encrypt(salasana);
                MySqlCommand komento = new MySqlCommand();
                String lisayskysely;
                {
                    lisayskysely = "INSERT INTO `kayttajat`(`RoolitID`,`KayttajaTunnus`,`Salasana`,`Etunimi`,`Sukunimi`,`Email`,`Puhelin`,`Osoite`,`Postitoimipaikka`,`Postinumero`,`YhtioID`)VALUES (@role,@usr,@ssa,@etu,@suku,@eml,@puh,@oso,@toim,@post,@yhtId);";
                }
                komento.CommandText = lisayskysely;
                komento.Connection = yhteys.otaYhteys();
                komento.Parameters.Add("@etu", MySqlDbType.VarChar).Value = enimi;
                komento.Parameters.Add("@suku", MySqlDbType.VarChar).Value = snimi;
                komento.Parameters.Add("@eml", MySqlDbType.VarChar).Value = email;
                komento.Parameters.Add("@puh", MySqlDbType.Int32).Value = puh;
                komento.Parameters.Add("@oso", MySqlDbType.VarChar).Value = osoite;
                komento.Parameters.Add("@post", MySqlDbType.Int32).Value = posti;
                komento.Parameters.Add("@toim", MySqlDbType.VarChar).Value = toimi;
                komento.Parameters.Add("@usr", MySqlDbType.VarChar).Value = ktunnus;
                komento.Parameters.Add("@ssa", MySqlDbType.VarChar).Value = salattu;
                komento.Parameters.Add("@role", MySqlDbType.Int32).Value = rooli;
                komento.Parameters.Add("@yhtId", MySqlDbType.Int32).Value = yhtID;

                yhteys.avaaYhteys();
                if (komento.ExecuteNonQuery() == 1)
                {
                    yhteys.suljeYhteys();
                    return ktunnus;
                }
                else
                {
                    yhteys.suljeYhteys();
                    return "";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "";
            }
        }
        public bool lisaTilaa(String kayyttajaID, String hinta, String lentoID)
        {
            MySqlCommand komento = new MySqlCommand();
            String lisayskysely;
            lisayskysely = "INSERT INTO `tilaus`( `kayttajaID`,`LentoID`, `Hinta`) VALUES (@kID,@lentoID,@hinta);";
            komento.CommandText = lisayskysely;
            komento.Connection = yhteys.otaYhteys();
            //komento.Parameters.Add("@tID", MySqlDbType.VarChar).Value = tilaID;
            komento.Parameters.Add("@kID", MySqlDbType.Int16).Value = Convert.ToUInt16(kayyttajaID);
            komento.Parameters.Add("@lentoID", MySqlDbType.Int16).Value = Convert.ToUInt16(lentoID);
            komento.Parameters.Add("@hinta", MySqlDbType.Float).Value = float.Parse(hinta);
            yhteys.avaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
            {
                yhteys.suljeYhteys();
                return true;
            }
            yhteys.suljeYhteys();
            return false;
        }
        public bool lisaTilaatieto(String tilaID, String AteriaID, String JuomaId, String AjuomaID, String Maara)
        {
            MySqlCommand komento = new MySqlCommand();
            String lisayskysely;
            if (AteriaID != "")
            {
                lisayskysely = "INSERT INTO `tilausyhdiste`(`TilausID`, `AteriatID`,  `Maara`) VALUES (@tID,@ateriaID,@maara);";
                komento.CommandText = lisayskysely;
                komento.Connection = yhteys.otaYhteys();
                komento.Parameters.Add("@tID", MySqlDbType.Int16).Value = Convert.ToInt16(tilaID);
                komento.Parameters.Add("@ateriaID", MySqlDbType.Int16).Value = Convert.ToInt16(AteriaID);
            }
            else if (JuomaId != "")
            {
                lisayskysely = "INSERT INTO `tilausyhdiste`(`TilausID`, `JuomaID`,  `Maara`) VALUES (@tID,@juomaID,@maara);";
                komento.CommandText = lisayskysely;
                komento.Connection = yhteys.otaYhteys();
                komento.Parameters.Add("@tID", MySqlDbType.Int16).Value = Convert.ToInt16(tilaID);
                komento.Parameters.Add("@juomaID", MySqlDbType.Int16).Value = Convert.ToInt16(JuomaId);
            }
            //lisayskysely = "INSERT INTO `tilausyhdiste`(`TilausID`, `AteriatID`, `JuomaAlkoID`, `JuomaID`, `Maara`) VALUES (@tID,@ateriaID,@ajuomaID,@juomaID,@maara);";
            else
            {
                lisayskysely = "INSERT INTO `tilausyhdiste`(`TilausID`, `JuomaAlkoID`,  `Maara`) VALUES (@tID,@ajuomaID,@maara);";
                komento.CommandText = lisayskysely;
                komento.Connection = yhteys.otaYhteys();
                komento.Parameters.Add("@tID", MySqlDbType.Int16).Value = Convert.ToInt16(tilaID);
                komento.Parameters.Add("@ajuomaID", MySqlDbType.Int16).Value = Convert.ToInt16(AjuomaID);
            }

            komento.Parameters.Add("@maara", MySqlDbType.Int16).Value = Convert.ToInt16(Maara);
            yhteys.avaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
            {
                yhteys.suljeYhteys();
                return true;
            }
            yhteys.suljeYhteys();
            return false;
        }

        public bool lisaOtayhtayta(String email, String aihe, String teksti, String nimi)
        {
            MySqlCommand komento = new MySqlCommand();
            String lisayskysely;
            lisayskysely = "INSERT INTO `otayhteytta`( `Name`,`lahettaja_email`, `Aihe`, `Text`) VALUES(@nimi, @eml, @aihe, @text);";
            komento.CommandText = lisayskysely;
            komento.Connection = yhteys.otaYhteys();
            komento.Parameters.Add("@text", MySqlDbType.VarChar).Value = teksti;
            komento.Parameters.Add("@aihe", MySqlDbType.VarChar).Value = aihe;
            komento.Parameters.Add("@eml", MySqlDbType.VarChar).Value = email;
            komento.Parameters.Add("@nimi", MySqlDbType.VarChar).Value = nimi;
            yhteys.avaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
            {
                yhteys.suljeYhteys();
                return true;
            }
            yhteys.suljeYhteys();
            return false;
        }
        public string Encrypt(string clearText)
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            // .Unicode = Gets an encoding for the UTF-16 format using the little endian byte order.
            // .GetBytes = When overridden in a derived class, encodes all the characters in the specified string into a sequence of bytes.
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            // Aes = Represents the abstract base class from which all implementations of the Advanced Encryption Standard (AES) must inherit
            // .Create = Creates a cryptographic object that is used to perform the symmetric algorithm.
            using (Aes encryptor = Aes.Create())
            {
                // Rfc2898DeriveBytes = Implements password-based key derivation functionality, PBKDF2, by using a pseudo-random number generator based on HMACSHA1.
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                // .Key = Gets or sets the secret key for the symmetric algorithm.
                // .IV = Gets or sets the initialization vector (IV) for the symmetric algorithm. 
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    // CryptoStream = Defines a stream that links data streams to cryptographic transformations.
                    // .CreateEncryptor() = Creates a symmetric encryptor object with the current Key property and initialization vector (IV).
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }
        public string Decrypt(string cipherText)
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            // .FromBase64String = Converts a CryptoStream from base 64.
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            // Aes = Represents the abstract base class from which all implementations of the Advanced Encryption Standard (AES) must inherit
            // .Create = Creates a cryptographic object that is used to perform the symmetric algorithm.
            using (Aes encryptor = Aes.Create())
            {
                // Rfc2898DeriveBytes = Implements password-based key derivation functionality, PBKDF2, by using a pseudo-random number generator based on HMACSHA1.
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                // .Key = Gets or sets the secret key for the symmetric algorithm.
                // .IV = Gets or sets the initialization vector (IV) for the symmetric algorithm. 
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    // CryptoStream = Defines a stream that links data streams to cryptographic transformations.
                    // .CreateEncryptor() = Creates a symmetric encryptor object with the current Key property and initialization vector (IV).
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }

                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }

    }
}