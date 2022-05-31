using System;
using MySql.Data.MySqlClient; // pitää muistaa lisätä
using System.Data; // pitää muistaa lisätä
using System.Data.SqlClient; // pitää muistaa lisätä
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catering_Projectin
{
    internal class Sqlkysely
    {
        Yhdista yh = new Yhdista();
        public DataTable haelento()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM tyotilanne", yh.otaYhteys());
            MySqlDataAdapter adapter = new MySqlDataAdapter(); // Luodaan data-adapteri tietokannasta tulevalle tiedolle
            DataTable table = new DataTable(); // Luodaan uusi DataTable jolle tulee tietokannasta tuleva tieto
            adapter.SelectCommand = command; // Adapteriin valitaan Sql komento ja tähän tulee kaikki tietokannasta tuleva tiet
            adapter.Fill(table); // Adapterissa oleva tieto siirretään DataTableen
            return table; // palautetaan DataTable 
        }
        public DataTable haeateriat()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `ateriat`", yh.otaYhteys());
            MySqlDataAdapter adapter = new MySqlDataAdapter(); // Luodaan data-adapteri tietokannasta tulevalle tiedolle
            DataTable table = new DataTable(); // Luodaan uusi DataTable jolle tulee tietokannasta tuleva tieto
            adapter.SelectCommand = command; // Adapteriin valitaan Sql komento ja tähän tulee kaikki tietokannasta tuleva tiet
            adapter.Fill(table); // Adapterissa oleva tieto siirretään DataTableen
            return table; // palautetaan DataTable 
        }
        public DataTable haealkolijuomat()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `juomatalkoholilliset`", yh.otaYhteys());
            MySqlDataAdapter adapter = new MySqlDataAdapter(); // Luodaan data-adapteri tietokannasta tulevalle tiedolle
            DataTable table = new DataTable(); // Luodaan uusi DataTable jolle tulee tietokannasta tuleva tieto
            adapter.SelectCommand = command; // Adapteriin valitaan Sql komento ja tähän tulee kaikki tietokannasta tuleva tiet
            adapter.Fill(table); // Adapterissa oleva tieto siirretään DataTableen
            return table; // palautetaan DataTable 
        }
        public DataTable haealkolijuomatlist(string id )
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `juomatalkoholilliset`  WHERE JuomaAlkoID  in (" + id + ");", yh.otaYhteys());
            MySqlDataAdapter adapter = new MySqlDataAdapter(); // Luodaan data-adapteri tietokannasta tulevalle tiedolle
            DataTable table = new DataTable(); // Luodaan uusi DataTable jolle tulee tietokannasta tuleva tieto
            adapter.SelectCommand = command; // Adapteriin valitaan Sql komento ja tähän tulee kaikki tietokannasta tuleva tiet
            adapter.Fill(table); // Adapterissa oleva tieto siirretään DataTableen
            return table; // palautetaan DataTable 
        }
        public DataTable haejuomatalkolimat()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `juomatalkoholittomat`", yh.otaYhteys());
            MySqlDataAdapter adapter = new MySqlDataAdapter(); // Luodaan data-adapteri tietokannasta tulevalle tiedolle
            DataTable table = new DataTable(); // Luodaan uusi DataTable jolle tulee tietokannasta tuleva tieto
            adapter.SelectCommand = command; // Adapteriin valitaan Sql komento ja tähän tulee kaikki tietokannasta tuleva tiet
            adapter.Fill(table); // Adapterissa oleva tieto siirretään DataTableen
            return table; // palautetaan DataTable 
        }
        public DataTable haejuomatalkolimattila(string id )
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `juomatalkoholittomat` WHERE JuomaID in (" + id + ");", yh.otaYhteys());
            MySqlDataAdapter adapter = new MySqlDataAdapter(); // Luodaan data-adapteri tietokannasta tulevalle tiedolle
            DataTable table = new DataTable(); // Luodaan uusi DataTable jolle tulee tietokannasta tuleva tieto
            adapter.SelectCommand = command; // Adapteriin valitaan Sql komento ja tähän tulee kaikki tietokannasta tuleva tiet
            adapter.Fill(table); // Adapterissa oleva tieto siirretään DataTableen
            return table; // palautetaan DataTable 
        }

        public DataTable lennot()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `lennot`", yh.otaYhteys());
            MySqlDataAdapter adapter = new MySqlDataAdapter(); // Luodaan data-adapteri tietokannasta tulevalle tiedolle
            DataTable table = new DataTable(); // Luodaan uusi DataTable jolle tulee tietokannasta tuleva tieto
            adapter.SelectCommand = command; // Adapteriin valitaan Sql komento ja tähän tulee kaikki tietokannasta tuleva tiet
            adapter.Fill(table); // Adapterissa oleva tieto siirretään DataTableen
            return table; // palautetaan DataTable 
        }

        public DataTable lennotID(string id)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `lennot`WHERE  LentoID in (" + id + ");", yh.otaYhteys());
            MySqlDataAdapter adapter = new MySqlDataAdapter(); // Luodaan data-adapteri tietokannasta tulevalle tiedolle
            DataTable table = new DataTable(); // Luodaan uusi DataTable jolle tulee tietokannasta tuleva tieto
            adapter.SelectCommand = command; // Adapteriin valitaan Sql komento ja tähän tulee kaikki tietokannasta tuleva tiet
            adapter.Fill(table); // Adapterissa oleva tieto siirretään DataTableen
            return table; // palautetaan DataTable 
        }

        public DataTable yleisiakysely(string cmd)
        {
            MySqlCommand command = new MySqlCommand(cmd, yh.otaYhteys());
            MySqlDataAdapter adapter = new MySqlDataAdapter(); // Luodaan data-adapteri tietokannasta tulevalle tiedolle
            DataTable table = new DataTable(); // Luodaan uusi DataTable jolle tulee tietokannasta tuleva tieto
            adapter.SelectCommand = command; // Adapteriin valitaan Sql komento ja tähän tulee kaikki tietokannasta tuleva tiet
            adapter.Fill(table); // Adapterissa oleva tieto siirretään DataTableen
            return table; // palautetaan DataTable 
        }

        public DataTable haeateriattila(string id)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `ateriat` WHERE AteriaID in (" + id + ");", yh.otaYhteys());
            MySqlDataAdapter adapter = new MySqlDataAdapter(); // Luodaan data-adapteri tietokannasta tulevalle tiedolle
            DataTable table = new DataTable(); // Luodaan uusi DataTable jolle tulee tietokannasta tuleva tieto
            adapter.SelectCommand = command; // Adapteriin valitaan Sql komento ja tähän tulee kaikki tietokannasta tuleva tiet
            adapter.Fill(table); // Adapterissa oleva tieto siirretään DataTableen
            return table; // palautetaan DataTable 
        }
        public String haetilaid(string id)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `tilaus` WHERE kayttajaID = " +id + " ORDER by TilausID DESC LIMIT 1", yh.otaYhteys());
            MySqlDataAdapter adapter = new MySqlDataAdapter(); // Luodaan data-adapteri tietokannasta tulevalle tiedolle
            DataTable table = new DataTable(); // Luodaan uusi DataTable jolle tulee tietokannasta tuleva tieto
            adapter.SelectCommand = command; // Adapteriin valitaan Sql komento ja tähän tulee kaikki tietokannasta tuleva tiet
            adapter.Fill(table); // Adapterissa oleva tieto siirretään DataTableen
            return table.Rows[0][0].ToString(); // palautetaan DataTable 
        }
        public DataTable tilauksia_ID(string id)
        {
            string sql = " SELECT * FROM (SELECT t.kayttajaID, t.TilausID,t.Status,l.ICAOkoodi,l.Lahtopaikka, l.LentoAika FROM tilaus t, lennot l where t.LentoID=l.LentoID) as tablo WHERE kayttajaID  in (" + id + ");";
            MySqlCommand command = new MySqlCommand(sql, yh.otaYhteys());
            MySqlDataAdapter adapter = new MySqlDataAdapter(); // Luodaan data-adapteri tietokannasta tulevalle tiedolle
            DataTable table = new DataTable(); // Luodaan uusi DataTable jolle tulee tietokannasta tuleva tieto
            adapter.SelectCommand = command; // Adapteriin valitaan Sql komento ja tähän tulee kaikki tietokannasta tuleva tiet
            adapter.Fill(table); // Adapterissa oleva tieto siirretään DataTable
            return table; // palautetaan DataTable 
        }

        public DataTable kirjoidutiedot(string id)
        {
            string sql = "SELECT `Etunimi`,`Salasana`,`RoolitID`,`KayttajaID` FROM `kayttajat` WHERE  KayttajaTunnus= '" + id + "'";
            MySqlCommand command = new MySqlCommand(sql, yh.otaYhteys());
            MySqlDataAdapter adapter = new MySqlDataAdapter(); // Luodaan data-adapteri tietokannasta tulevalle tiedolle
            DataTable table = new DataTable(); // Luodaan uusi DataTable jolle tulee tietokannasta tuleva tieto
            adapter.SelectCommand = command; // Adapteriin valitaan Sql komento ja tähän tulee kaikki tietokannasta tuleva tiet
            adapter.Fill(table); // Adapterissa oleva tieto siirretään DataTable
            return table; // palautetaan DataTable 
        }
        public DataTable tilauksia(string id)
        {
            string sqltext= "SELECT * FROM (SELECT T.TilausID,T.Maara, J.Nimi FROM `tilausyhdiste` T, `Juomatalkoholilliset` J WHERE t.JuomaAlkoID=j.JuomaAlkoID UNION SELECT T.TilausID,T.Maara, K.Nimi FROM `tilausyhdiste` T, `juomatalkoholittomat` K WHERE t.JuomaID = K.JuomaID    UNION SELECT T.TilausID,T.Maara, A.AterianNimi FROM `tilausyhdiste` T, `ateriat` A WHERE t.AteriatID = A.AteriaID) AS d WHERE TilausID in (" + id + ");";
          
            MySqlCommand command = new MySqlCommand(sqltext, yh.otaYhteys());
            MySqlDataAdapter adapter = new MySqlDataAdapter(); // Luodaan data-adapteri tietokannasta tulevalle tiedolle
            DataTable table = new DataTable(); // Luodaan uusi DataTable jolle tulee tietokannasta tuleva tieto
            adapter.SelectCommand = command; // Adapteriin valitaan Sql komento ja tähän tulee kaikki tietokannasta tuleva tiet
            adapter.Fill(table); // Adapterissa oleva tieto siirretään DataTableen
            return table; // palautetaan DataTable 
        }
        public DataTable haeakaytajatiedot(string id)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `kayttajat` WHERE KayttajaID  in (" + id + ");", yh.otaYhteys());
            MySqlDataAdapter adapter = new MySqlDataAdapter(); // Luodaan data-adapteri tietokannasta tulevalle tiedolle
            DataTable table = new DataTable(); // Luodaan uusi DataTable jolle tulee tietokannasta tuleva tieto
            adapter.SelectCommand = command; // Adapteriin valitaan Sql komento ja tähän tulee kaikki tietokannasta tuleva tiet
            adapter.Fill(table); // Adapterissa oleva tieto siirretään DataTableen
            return table; // palautetaan DataTable 
        }

        public bool updatetili(string id, string ktunnus, string salasana, string etu, string puh, string suku, string email, string postinumero, string toimi, string osaite)
        {

                MySqlCommand cmd = new MySqlCommand("Update `kayttajat` Set `Etunimi` = @eni, `Sukunimi` = @sni, `Email` =@email, `Puhelin` =@puh, `Osoite` =@oso,`Postitoimipaikka` =@ptoi, `Postinumero` = @pnro, `KayttajaTunnus` = @ktun, `Salasana` = @sal  WHERE KayttajaID =@id", yh.otaYhteys());
                // Alla parametrien määrittely.
                cmd.Parameters.Add("@eni", MySqlDbType.VarChar).Value = etu;
                cmd.Parameters.Add("@sni", MySqlDbType.VarChar).Value = suku;
                cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
                cmd.Parameters.Add("@puh", MySqlDbType.Int32).Value =  puh;
                cmd.Parameters.Add("@oso", MySqlDbType.VarChar).Value = osaite;
                cmd.Parameters.Add("@ptoi", MySqlDbType.VarChar).Value = toimi;
                cmd.Parameters.Add("@pnro", MySqlDbType.Int32).Value =  postinumero;
                cmd.Parameters.Add("@ktun", MySqlDbType.VarChar).Value = ktunnus;
                cmd.Parameters.Add("@sal", MySqlDbType.VarChar).Value = salasana;
                cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

            yh.avaaYhteys(); // avataan yhteys tietokantaan YH CLASS:ssa olevan funktion avulla
                if (cmd.ExecuteNonQuery() == 1) // Katsotaan suoritettiinko komento
                {
                    yh.suljeYhteys(); // Suljetaan yhteys tietokantaan YH CLASS:ssa olevan funktion avulla
                    return true; // viestin palautus
                }
                else // mikäli ei onnistunut tietokannan muokkaus
                {
                    yh.suljeYhteys();  // Suljetaan yhteys tietokantaan YH CLASS:ssa olevan funktion avulla 
                MessageBox.Show("virhe");
                    return false; // viestin palautus
                }
        }

    }
}
