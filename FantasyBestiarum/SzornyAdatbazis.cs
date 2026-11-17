using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace FantasyBestiarum
{
    internal class SzornyAdatbazis
    {
        readonly string connectionString = "Server=localhost;Database=fantasybestariumdb;uid:root;Password=';";

        public List<Szorny> Betoltes()
        {
            var szornyek = new List<Szorny>();
            using(MySqlConnection connection = new MySqlConnection(connectionString))
            {
                var query = "SELECT * FROM szornyek";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32("id");
                            string nev = reader.GetString("nev");
                            int veszelyessegSzint = reader.GetInt32("veszelyesseg_szint");
                            string elohely = reader.GetString("elohely");
                            string foGyengeseg = reader.GetString("fo_gyengeseg");
                            string leggyakoribbZsakmany = reader.GetString("leggyakoribb_zsakmany");
                            bool veszelyesE = reader.GetBoolean("veszelyes_e");


                            var szorny = new Szorny(id, nev, veszelyessegSzint, elohely, foGyengeseg, leggyakoribbZsakmany, veszelyesE);
                            szornyek.Add(szorny);
                        }
                    }
                }
            }
            return szornyek;
            )
        }
    }
}
