using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace FantasyBestiarum
{
    internal class SzornyAdatbazis
    {
        private readonly string connectionString;

        public SzornyAdatbazis()
        {
            connectionString = "server=localhost;database=fantasybestariumdb;uid=root;pwd =;";
        }

        public List<Szorny> Feltolt()
        {
            var szornyek = new List<Szorny>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
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
                            int veszelyessegSzint = reader.GetInt32("VeszelyessegiSzint");
                            string elohely = reader.GetString("elohely");
                            string foGyengeseg = reader.GetString("FoGyengeseg");
                            string leggyakoribbZsakmany = reader.GetString("LeggyakoribbZsakmany");
                            bool veszelyesE = reader.GetBoolean("VeszelyesE");


                            var szorny = new Szorny(id, nev, veszelyessegSzint, elohely, foGyengeseg, leggyakoribbZsakmany, veszelyesE);
                            szornyek.Add(szorny);
                        }
                    }
                }

              }
            return szornyek;
        }
    }
}
