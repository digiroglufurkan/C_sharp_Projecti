
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

        public string uusiKayttaja(String enimi, String snimi, String puh, String email, String osaite, String postinumero, String toimipaikka, String titteli, bool kuvaa, PictureBox PB, String salasana)
        {
            String ktunnus = enimi.ToLower() + "." + snimi.ToLower();
            String salattu = Encrypt(salasana);
            MySqlCommand komento = new MySqlCommand();
            String lisayskysely;
            if (kuvaa) 
            {
                lisayskysely = "INSERT INTO `kayttajat`" +
                    "(`KAYTTAJA_TUNNUS`, `ETUNIMI`, `SUKUNIMI`, `EMAIL`, `PUHELIN`, `OSAITE`, `POSTINUMERO`, `TOIMIPAIKKA`, `TITTELI`, `SALASANA`,`KUVA`)" +
                    "VALUES (@usr, @enm, @snm,  @eml, @puh, @osaite,@postinumero, @toimipaikka,@titteli, @ssa,@kuva); ";
            }
            else 
            {
                lisayskysely = "INSERT INTO `kayttajat`" +
                     "(`KAYTTAJA_TUNNUS`, `ETUNIMI`, `SUKUNIMI`, `EMAIL`, `PUHELIN`, `OSAITE`, `POSTINUMERO`, `TOIMIPAIKKA`, `TITTELI`, `SALASANA`)" +
                     "VALUES (@usr, @enm, @snm,  @eml, @puh, @osaite,@postinumero, @toimipaikka,@titteli, @ssa); ";
            }
            komento.CommandText = lisayskysely;
            komento.Connection = yhteys.otaYhteys();
            komento.Parameters.Add("@enm", MySqlDbType.VarChar).Value = enimi;
            komento.Parameters.Add("@snm", MySqlDbType.VarChar).Value = snimi;
            komento.Parameters.Add("@eml", MySqlDbType.VarChar).Value = email;
            komento.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puh;
            komento.Parameters.Add("@osaite", MySqlDbType.VarChar).Value = osaite;
            komento.Parameters.Add("@postinumero", MySqlDbType.VarChar).Value = postinumero;
            komento.Parameters.Add("@toimipaikka", MySqlDbType.VarChar).Value = toimipaikka;
            komento.Parameters.Add("@titteli", MySqlDbType.VarChar).Value = titteli;
            komento.Parameters.Add("@usr", MySqlDbType.VarChar).Value = ktunnus;
            komento.Parameters.Add("@ssa", MySqlDbType.VarChar).Value = salattu;
            if (kuvaa) //jos kuva ladata converto byte from kuva
            {
                ImageConverter convert = new ImageConverter();
                komento.Parameters.Add("@kuva", MySqlDbType.LongBlob).Value = (byte[])convert.ConvertTo(PB.Image, typeof(byte[]));
            }


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