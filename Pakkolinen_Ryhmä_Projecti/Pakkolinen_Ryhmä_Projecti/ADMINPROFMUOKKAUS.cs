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
     class ADMINPROFMUOKKAUS
    {
        Yhdista yh = new Yhdista();

        public DataTable fetchInformation() // haetaan opiskelijoiden tiedot tietokannasta
        {   // Alla Sql komento jossa samassa hakukysely tietokantaan ja yhteydenluonti tietokantaan
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT KAYTTAJA_TUNNUS, ETUNIMI, SUKUNIMI, EMAIL, PUHELIN, OSAITE, POSTINUMERO, TOIMIPAIKKA, TITTELI, SALASANA, MAARAAIKA FROM kayttajat", yh.otaYhteys());
                MySqlDataAdapter adapter = new MySqlDataAdapter(); // Luodaan data-adapteri tietokannasta tulevalle tiedolle
                DataTable table = new DataTable(); // Luodaan uusi DataTable jolle tulee tietokannasta tuleva tieto
                adapter.SelectCommand = command; // Adapteriin valitaan Sql komento ja tähän tulee kaikki tietokannasta tuleva tieto
                adapter.Fill(table); // Adapterissa oleva tieto siirretään DataTableen
                return table; // palautetaan DataTable 
            }
            catch (Exception ex)
            {
                MySqlCommand command = new MySqlCommand("SELECT KAYTTAJA_TUNNUS, ETUNIMI, SUKUNIMI, EMAIL, PUHELIN, OSAITE, POSTINUMERO, TOIMIPAIKKA, TITTELI, SALASANA, MAARAAIKA FROM kayttajat", yh.otaYhteys());
                MySqlDataAdapter adapter = new MySqlDataAdapter(); // Luodaan data-adapteri tietokannasta tulevalle tiedolle
                DataTable table = new DataTable(); // Luodaan uusi DataTable jolle tulee tietokannasta tuleva tieto
                adapter.SelectCommand = command; // Adapteriin valitaan Sql komento ja tähän tulee kaikki tietokannasta tuleva tieto
                adapter.Fill(table); // Adapterissa oleva tieto siirretään DataTableen
                return table; // palautetaan DataTable
            }

        }
        public bool paivitaTiedot(string enimi,string snimi,string email,string puh,string osoite,string postinro,string postitoimi,string titteli
            ,string kuva)
        {
            FileStream fs;
            BinaryReader br;
            try
            {
                byte[] imageData;
                fs = new FileStream(kuva, FileMode.Open, FileAccess.Read);
                br = new BinaryReader(fs);
                imageData = br.ReadBytes((int)fs.Length);
                br.Close();
                fs.Close();
                MySqlCommand command = new MySqlCommand(); // muuttuja Sql komennolle
                command.Parameters.Add("@eni", MySqlDbType.VarChar).Value = enimi; // lisätään parametreinä lisäyskyselyyn arvot. Kerrotaan tietokannan tietotyyppi samalla tässä VarChar eli teksti
                command.Parameters.Add("@sni", MySqlDbType.VarChar).Value = snimi; // lisätään parametreinä lisäyskyselyyn arvot. Kerrotaan tietokannan tietotyyppi samalla tässä VarChar eli teksti
                command.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puh; // lisätään parametreinä lisäyskyselyyn arvot. Kerrotaan tietokannan tietotyyppi samalla tässä VarChar eli teksti
                command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email; // lisätään parametreinä lisäyskyselyyn arvot. Kerrotaan tietokannan tietotyyppi samalla tässä VarChar eli teksti
                command.Parameters.Add("@oso", MySqlDbType.VarChar).Value = osoite; 
                command.Parameters.Add("@pnro", MySqlDbType.VarChar).Value = postinro;
                command.Parameters.Add("@ptoi", MySqlDbType.VarChar).Value = postitoimi;
                command.Parameters.Add("@tit", MySqlDbType.VarChar).Value = titteli;
                command.Parameters.Add("@img", MySqlDbType.LongBlob).Value = imageData; // Kuva, huomaa tietotyyppi
                string updateQuest = "Update `kayttajat` Set `ETUNIMI` = @eni, `SUKUNIMI` = @sni, `PUHELIN` =@puh, `EMAIL` =@email, `OSAITE` =@oso, `POSTINUMERO` =@pnro, `TOIMIPAIKKA` =@ptoi, `TITTELI` =@tit, `KUVA` =@img WHERE ETUNIMI =@eni"; // Sql lisäys kysely tässä opiskelijanumero on primary key
                command.CommandText = updateQuest; // liitetään tietokantakomentoon muokkauskysely
                command.Connection = yh.otaYhteys(); // muodostetaan yhteys tietokantaan YH CLASS:ssa olevan funktion avulla
                yh.avaaYhteys(); // avataan yhteys tietokantaan YH CLASS:ssa olevan funktion avulla
                if (command.ExecuteNonQuery() == 1) // Katsotaan suoritettiinko komento
                {
                    yh.suljeYhteys(); // Suljetaan yhteys tietokantaan YH CLASS:ssa olevan funktion avulla
                    bool apu = true; // Vastaus viesti
                    return apu; // viestin palautus
                }
                else // mikäli ei onnistunut tietokannan muokkaus
                {
                    yh.suljeYhteys();  // Suljetaan yhteys tietokantaan YH CLASS:ssa olevan funktion avulla 
                    bool apu = false; // Vastaus viesti
                    return apu; // viestin palautus
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
