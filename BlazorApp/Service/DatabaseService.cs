using DomainModels;
using Npgsql;
using System.Buffers;
using System;

namespace Service
{
    public class DatabaseService
    {
        public string connectionString;

        public DatabaseService(string connectionString) { this.connectionString = connectionString; }
        public List<Item> GetAllData()
        {
            List<Item> allData = new List<Item>();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM items";

                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var type = reader["type"].ToString().ToUpper();
                            if (type == "PC")
                            {
                                allData.Add(new PC_Game()
                                {
                                    itemID = Convert.ToInt32(reader["itemid"]),
                                    gameName = reader["gamename"].ToString(),
                                    genre = reader["genre"].ToString(),
                                    price = Convert.ToInt32(reader["price"]),
                                    manufacture = reader["manufacture"].ToString(),
                                    condition = reader["condition"].ToString(),
                                    description = reader["description"].ToString()
                                });
                            }
                        }
                        return allData;
                    }
                }
            }
        }
    }
}
