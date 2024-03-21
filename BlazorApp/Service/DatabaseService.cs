using DomainModels;
using Npgsql;
using System.Buffers;
using System;


namespace Service
{
    public class DatabaseService
    {
        public string connectionString;

        public DatabaseService(string connectionString) { connectionString = connectionString; }

        public List<Item> GetAllGames()
        {
            List<Item> allGames = new List<Item>();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM Item";

                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var type = reader["type"].ToString();
                            if (type == "PCGames")
                            {
                                allGames.Add(new PC_Game(
                                    Convert.ToInt32(reader["itemID"]),
                                    reader["gameName"].ToString(),
                                    Convert.ToInt32(reader["price"]),
                                    (bool)reader["orderStatus"], // Bool
                                    reader["condition"].ToString(),
                                    (DateTime)reader["created"], // Datetime
                                    (DateTime)reader["updated"], // Datetime
                                    reader["genre"].ToString(),
                                    reader["manufacture"].ToString(),
                                    (bool)reader["addToFaverite"], // bool
                                    reader["description"].ToString(),
                                    reader["operatingSystem"].ToString(),
                                    (DateTime)(reader["yearDeployed"])
                                    )
                                );
                            }
                            else if (type == "PSGames")
                            {
                                allGames.Add(new PS_Game(
                                    Convert.ToInt32(reader["itemID"]),
                                    reader["gameName"].ToString(),
                                    Convert.ToInt32(reader["price"]),
                                    (bool)reader["orderStatus"], // Bool
                                    reader["condition"].ToString(),
                                    (DateTime)reader["created"], // Datetime
                                    (DateTime)reader["updated"], // Datetime
                                    reader["genre"].ToString(),
                                    reader["manufacture"].ToString(),
                                    (bool)reader["addToFaverite"], // bool
                                    reader["description"].ToString(),
                                    reader["psModel"].ToString(),
                                    (DateTime)(reader["yearDeployed"])

                                    )
                                );
                            }
                            else if (type == "XBOXGames")
                            {
                                allGames.Add(new XBOX_Game(
                                    Convert.ToInt32(reader["itemID"]),
                                    reader["gameName"].ToString(),
                                    Convert.ToInt32(reader["price"]),
                                    (bool)reader["orderStatus"], // Bool
                                    reader["condition"].ToString(),
                                    (DateTime)reader["created"], // Datetime
                                    (DateTime)reader["updated"], // Datetime
                                    reader["genre"].ToString(),
                                    reader["manufacture"].ToString(),
                                    (bool)reader["addToFaverite"], // bool
                                    reader["description"].ToString(),
                                    reader["xboxModel"].ToString(),
                                    (DateTime)(reader["yearDeployed"])
                                    )
                                );
                            }
                        }
                    }
                }
            }
            return allGames;
        }
    }
}
