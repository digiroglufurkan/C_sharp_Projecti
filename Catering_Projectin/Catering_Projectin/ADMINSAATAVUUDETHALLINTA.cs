using System;
using MySql.Data.MySqlClient; // pitää muistaa lisätä
using System.Data; // pitää muistaa lisätä
using System.Data.SqlClient; // pitää muistaa lisätä
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// author@ Antti Kuusisto
/// version 18.5.2022
/// <summary>
/// Ateriat ja toinen juomista toimii. Toiseen juomat osioon voisi katsoa mikäli aikaa riittää, niin 
/// tuon tietokantakyselyn sellaiseksi, että muuttuja summataan kyselyssä tietokannassa olevaan lukuun, eikä
/// lueta, summata ja lähetetä takaisin.
/// </summary>
namespace Catering_Projectin
{
    class ADMINSAATAVUUDETHALLINTA
    {
        Yhdista yh = new Yhdista();

        // ateriat table:n tietojen haku
        public DataTable haeAteriat()
        {
            // Hakukysely ja yhteyden muodostaminen
            MySqlCommand command = new MySqlCommand("SELECT * FROM ateriat", yh.otaYhteys());
            MySqlDataAdapter adapter = new MySqlDataAdapter(); // Luodaan data-adapteri tietokannasta tulevalle tiedolle
            DataTable table = new DataTable(); // Luodaan uusi DataTable jolle tulee tietokannasta tuleva tieto
            adapter.SelectCommand = command; // Adapteriin valitaan Sql komento ja tähän tulee kaikki tietokannasta tuleva tiet
            adapter.Fill(table); // Adapterissa oleva tieto siirretään DataTableen
            return table; // palautetaan DataTable 
        }

        // juomatalkoholittomat table:n tietojen haku
        public DataTable haeJuomat()
        {
            // Hakukysely ja yhteyden muodostaminen
            MySqlCommand command = new MySqlCommand("SELECT * FROM juomatalkoholittomat", yh.otaYhteys());
            MySqlDataAdapter adapter = new MySqlDataAdapter(); // Luodaan data-adapteri tietokannasta tulevalle tiedolle
            DataTable table = new DataTable(); // Luodaan uusi DataTable jolle tulee tietokannasta tuleva tieto
            adapter.SelectCommand = command; // Adapteriin valitaan Sql komento ja tähän tulee kaikki tietokannasta tuleva tiet
            adapter.Fill(table); // Adapterissa oleva tieto siirretään DataTableen
            return table; // palautetaan DataTable 
        }

        // juomatalkoholilliset table:n tietojen haku
        public DataTable haeJuomatAlko()
        {
            // Hakukysely ja yhteyden muodostaminen
            MySqlCommand command = new MySqlCommand("SELECT * FROM juomatalkoholilliset", yh.otaYhteys());
            MySqlDataAdapter adapter = new MySqlDataAdapter(); // Luodaan data-adapteri tietokannasta tulevalle tiedolle
            DataTable table = new DataTable(); // Luodaan uusi DataTable jolle tulee tietokannasta tuleva tieto
            adapter.SelectCommand = command; // Adapteriin valitaan Sql komento ja tähän tulee kaikki tietokannasta tuleva tiet
            adapter.Fill(table); // Adapterissa oleva tieto siirretään DataTableen
            return table; // palautetaan DataTable 
        }

        // aterian varaus
        public bool varaaAteria(int ma, int id)
        {
            int liVaMa = ma;// muuttuja viestiä varten
            int vaMa = 0; // muuttuja tietokannassa olevia varauksia varten
            try
            {
                // hakukysely ja yhteyden muodostus
                MySqlCommand cmd = new MySqlCommand("SELECT Varattu from ateriat WHERE AteriaID = @id", yh.otaYhteys());
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;// AteriaID:n lisäys
                yh.avaaYhteys(); // yhteyden avaus
                MySqlDataReader reader1 = cmd.ExecuteReader();// datareader:n kysely
                while (reader1.Read()) // Kun DataReader lukee
                {   // while silmukalla muuttujaan varaukset
                    vaMa = reader1.GetInt32(0);
                    reader1.Close(); //suljetaan DataReader
                    break;
                }
                ma += vaMa; // lisää varattaviin lisätään tietokannassa olevat varaukset
                // päivityskysely ja yhteyden muodostus
                MySqlCommand cmd1 = new MySqlCommand("UPDATE `ateriat` SET `Varattu` = @ma WHERE AteriaID = @id", yh.otaYhteys());
                cmd1.Parameters.Add("@ma", MySqlDbType.Int32).Value = ma; // varauksien määrä
                cmd1.Parameters.Add("@id", MySqlDbType.Int32).Value = id; // AteriaID
                yh.avaaYhteys();//yhteys auki
                if (cmd1.ExecuteNonQuery() == 1)//katsotaan suoritettiinko kysely
                {
                    yh.suljeYhteys();//suljetaan yhteys
                    // viesti paljonko varattiin ja paljonko on yhteensä varattu
                    MessageBox.Show($"Varattu lisää {liVaMa} kpl. Kaikkiaan on varattuna {ma} kpl.");
                    return true;//palautetaan true
                }
                else
                {
                    yh.suljeYhteys();//suljetaan yhteys
                    return false;//palutetaan false
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} class");
                return false;
            }
        }

        // juoman varaus
        public bool varaaJuoma(int ma, int id)
        {
            int liVaMa = ma; // muuttuja viestiä varten
            int vaMa = 0; // muuttuja tietokannassa olevia varauksia varten
            try
            {
                // hakukysely ja yhteyden muodostus
                MySqlCommand cmd = new MySqlCommand("SELECT Varattu from juomatalkoholittomat WHERE JuomaID = @id", yh.otaYhteys());
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;// JuomaID:n lisäys
                yh.avaaYhteys();//yhteys auki
                MySqlDataReader reader1 = cmd.ExecuteReader();// datareader:n kysely
                while (reader1.Read()) // Kun DataReader lukee
                {   // while silmukalla muuttujaan varaukset
                    vaMa = reader1.GetInt32(0);
                    reader1.Close(); //suljetaan DataReader
                    break;
                }
                ma += vaMa;// lisää varattaviin lisätään tietokannassa olevat varaukset
                // päivityskysely ja yhteyden muodostus
                MySqlCommand cmd1 = new MySqlCommand("UPDATE `juomatalkoholittomat` SET `Varattu` = @ma WHERE JuomaID = @id", yh.otaYhteys());
                cmd1.Parameters.Add("@ma", MySqlDbType.Int32).Value = ma;// varauksien määrä
                cmd1.Parameters.Add("@id", MySqlDbType.Int32).Value = id;// JuomaID
                yh.avaaYhteys();//yhteys auki
                if (cmd1.ExecuteNonQuery() == 1)//katsotaan suoritettiinko kysely
                {
                    yh.suljeYhteys();//suljetaan yhteys
                    // viesti paljonko varattiin ja paljonko on yhteensä varattu
                    MessageBox.Show($"Varattu lisää {liVaMa} kpl. Kaikkiaan on varattuna {ma} kpl.");
                    return true;//palautetaan true
                }
                else
                {
                    yh.suljeYhteys();//suljetaan yhteys
                    return false;//palutetaan false
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} class");
                return false;
            }
        }

        // juoman tilaus
        public bool tilaaJuoma(int ma, int id)
        {
            int liVaMa = ma; // muuttuja viestiä varten
            int tiMa = 0;// muuttuja tietokannassa olevia tilauksia varten
            try
            {
                // hakukysely ja yhteyden muodostus
                MySqlCommand cmd = new MySqlCommand("SELECT Varasto_saldo from juomatalkoholittomat WHERE JuomaID = @id", yh.otaYhteys());
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;// JuomaID:n lisäys
                yh.avaaYhteys();//yhteys auki
                MySqlDataReader reader1 = cmd.ExecuteReader();// datareader:n kysely
                while (reader1.Read()) // Kun DataReader lukee
                {   // while silmukalla muuttujaan varaukset
                    tiMa = reader1.GetInt32(0);
                    reader1.Close();//suljetaan DataReader
                    break;
                }
                ma += tiMa;// lisää tilattaviin lisätään tietokannassa olevat tilattavat
                // päivityskysely ja yhteyden muodostus
                MySqlCommand cmd1 = new MySqlCommand("UPDATE `juomatalkoholittomat` SET `Varasto_saldo` = @ma WHERE JuomaID = @id", yh.otaYhteys());
                cmd1.Parameters.Add("@ma", MySqlDbType.Int32).Value = ma;// tilauksien määrä
                cmd1.Parameters.Add("@id", MySqlDbType.Int32).Value = id;// JuomaID
                yh.avaaYhteys();//yhteys auki
                if (cmd1.ExecuteNonQuery() == 1)//katsotaan suoritettiinko kysely
                {
                    yh.suljeYhteys();//suljetaan yhteys
                    //viesti paljonko on tilattu lisää.
                    MessageBox.Show($"Tilattu lisää {liVaMa} kpl.");
                    return true;//palutetaan true
                }
                else
                {
                    yh.suljeYhteys();//suljetaan yhteys
                    return false;//palautetaan false
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} class");
                return false;
            }
        }
    }
}
