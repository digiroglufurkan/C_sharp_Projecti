using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pakkolinen_Ryhmä_Projecti
{

    internal class ProfiilinMuokkaus
    {
        Yhdista yhteys = new Yhdista();
        public DataTable fetchInformation() // haetaan käyttäjän tiedot tietokannasta
        {   // Tämä on vanhentunut ja tulee poistumaan.
            try
            {   // Alla Sql komento jossa samassa hakukysely tietokantaan ja yhteydenluonti tietokantaan
                MySqlCommand command = new MySqlCommand("SELECT KAYTTAJA_TUNNUS, ETUNIMI, SUKUNIMI, EMAIL, PUHELIN, OSAITE, POSTINUMERO, TOIMIPAIKKA, TITTELI, SALASANA, MAARAAIKA FROM kayttajat", yhteys.otaYhteys());
                MySqlDataAdapter adapter = new MySqlDataAdapter(); // Luodaan data-adapteri tietokannasta tulevalle tiedolle
                DataTable table = new DataTable(); // Luodaan uusi DataTable jolle tulee tietokannasta tuleva tieto
                adapter.SelectCommand = command; // Adapteriin valitaan Sql komento ja tähän tulee kaikki tietokannasta tuleva tieto
                adapter.Fill(table); // Adapterissa oleva tieto siirretään DataTableen
                return table; // palautetaan DataTable 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex} v1");
                MySqlCommand command = new MySqlCommand("SELECT KAYTTAJA_TUNNUS, ETUNIMI, SUKUNIMI, EMAIL, PUHELIN, OSAITE, POSTINUMERO, TOIMIPAIKKA, TITTELI, SALASANA, MAARAAIKA FROM kayttajat", yhteys.otaYhteys());
                MySqlDataAdapter adapter = new MySqlDataAdapter(); // Luodaan data-adapteri tietokannasta tulevalle tiedolle
                DataTable table = new DataTable(); // Luodaan uusi DataTable jolle tulee tietokannasta tuleva tieto
                adapter.SelectCommand = command; // Adapteriin valitaan Sql komento ja tähän tulee kaikki tietokannasta tuleva tieto
                adapter.Fill(table); // Adapterissa oleva tieto siirretään DataTableen
                return table; // palautetaan DataTable
            }
        }

        public bool muokkaaProffa(string enimi, string snimi, string email, string puh, string osoite, string postinro, string postitoimi, string titteli, string kuva, string id)
        {
            FileStream fs; // muuttuja filestream metodille
                           //BinaryReader br;
                           // Aloitetaan try:lla
            try
            {
                /*byte[] imageData;
                fs = new FileStream(kuva, FileMode.Open, FileAccess.Read);
                br = new BinaryReader(fs);
                imageData = br.ReadBytes((int)fs.Length);
                br.Close();
                fs.Close();*/
                UInt32 FileSize; // muutuja tiedoston koolle
                byte[] rawData; // muuttuja tiedoston datalle
                                //FileStream fs; // muuttuja filestream metodille
                fs = new FileStream(kuva, FileMode.Open, FileAccess.Read); // määritellään mikä tiedosto avataan ja luetaan 
                FileSize = (uint)fs.Length; //luetaan tiedoston koko
                rawData = new byte[FileSize]; //määritellään data array:n koko
                fs.Read(rawData, 0, (int)FileSize); //luetaan tiedosto muuttujiin
                fs.Close(); // suljetaan filestream
                            // Tietokanta kysely ja avataan yhteys tietokantaan
                MySqlCommand command = new MySqlCommand(); // muuttuja Sql komennolle
                command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
                command.Parameters.Add("@eni", MySqlDbType.VarChar).Value = enimi; // lisätään parametreinä lisäyskyselyyn arvot. Kerrotaan tietokannan tietotyyppi samalla tässä VarChar eli teksti
                command.Parameters.Add("@sni", MySqlDbType.VarChar).Value = snimi; // lisätään parametreinä lisäyskyselyyn arvot. Kerrotaan tietokannan tietotyyppi samalla tässä VarChar eli teksti
                command.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puh; // lisätään parametreinä lisäyskyselyyn arvot. Kerrotaan tietokannan tietotyyppi samalla tässä VarChar eli teksti
                command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email; // lisätään parametreinä lisäyskyselyyn arvot. Kerrotaan tietokannan tietotyyppi samalla tässä VarChar eli teksti
                command.Parameters.Add("@oso", MySqlDbType.VarChar).Value = osoite; // lisätään parametreinä lisäyskyselyyn arvot.
                command.Parameters.Add("@pnro", MySqlDbType.VarChar).Value = postinro; // lisätään parametreinä lisäyskyselyyn arvot.
                command.Parameters.Add("@ptoi", MySqlDbType.VarChar).Value = postitoimi; // lisätään parametreinä lisäyskyselyyn arvot.
                command.Parameters.Add("@tit", MySqlDbType.VarChar).Value = titteli; // lisätään parametreinä lisäyskyselyyn arvot.
                command.Parameters.Add("@img", MySqlDbType.LongBlob).Value = rawData; // Kuva, huomaa tietotyyppi
                string updateQuest = "Update `kayttajat` Set `ETUNIMI` = @eni, `SUKUNIMI` = @sni, `PUHELIN` =@puh, `EMAIL` =@email, `OSAITE` =@oso, `POSTINUMERO` =@pnro, `TOIMIPAIKKA` =@ptoi, `TITTELI` =@tit, `KUVA` =@img WHERE KAYTTAJA_TUNNUS =@id"; // 
                command.CommandText = updateQuest; // liitetään tietokantakomentoon muokkauskysely
                command.Connection = yhteys.otaYhteys(); // muodostetaan yhteys tietokantaan YH CLASS:ssa olevan funktion avulla
                yhteys.avaaYhteys(); // avataan yhteys tietokantaan YH CLASS:ssa olevan funktion avulla
                if (command.ExecuteNonQuery() == 1) // Katsotaan suoritettiinko komento
                {
                    yhteys.suljeYhteys(); // Suljetaan yhteys tietokantaan YH CLASS:ssa olevan funktion avulla
                    return true; // viestin palautus
                }
                else // mikäli ei onnistunut tietokannan muokkaus
                {
                    yhteys.suljeYhteys();  // Suljetaan yhteys tietokantaan YH CLASS:ssa olevan funktion avulla 
                    return false; // viestin palautus
                }
            }
            catch (Exception ex) // Poimitaan virhe ja näytetään se.
            {
                MessageBox.Show($"{ex} v2");
                return false; // palautetaan false
            }
        }
    }
}
