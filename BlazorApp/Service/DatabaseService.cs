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

        public List<Item> GetAllGames()
        {
            List<Item> allGames = new List<Item>();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM ps_games";

                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            allGames.Add(new PS_Game()
                            {
                                itemID = Convert.ToInt32(reader["itemID"]),
                                gameName = reader["gameName"].ToString(),
                                condition = reader["condition"].ToString(),
                                created = Convert.ToDateTime(reader["created"]),
                                updated = Convert.ToDateTime(reader["updated"]),
                                genre = reader["genre"].ToString(),
                                manufacture = reader["manufacture"].ToString(),
                                description = reader["description"].ToString(),
                            });
                        }
                    }
                }
            }
            return allGames;
        }
        public void AddAllPSGames(NpgsqlConnection connection, List<Item> allGames)
        {
            string sql = "SELECT * FROM pc_games";

            using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
            {
                using (NpgsqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        PS_Game game = new PS_Game();
                        game.itemID = reader.GetInt32(reader.GetOrdinal("itemID"));
                        game.gameName = reader.GetString(reader.GetOrdinal("gameName"));
                        game.price = reader.GetInt32(reader.GetOrdinal("price"));
                        game.orderStatus = reader.GetBoolean(reader.GetOrdinal("orderStatus"));
                        game.condition = reader.GetString(reader.GetOrdinal("condition"));
                        game.created = reader.GetDateTime(reader.GetOrdinal("created"));
                        game.updated = reader.GetDateTime(reader.GetOrdinal("updated"));
                        game.genre = reader.GetString(reader.GetOrdinal("genre"));
                        game.manufacture = reader.GetString(reader.GetOrdinal("manufacture"));
                        game.addToFaverite = reader.GetBoolean(reader.GetOrdinal("addToFaverite"));
                        game.description = reader.GetString(reader.GetOrdinal("description"));
                        game.yearDeployed = reader.GetInt32(reader.GetOrdinal("yearDeployed"));
                        game.pictures = reader.GetString(reader.GetOrdinal("pictures")).Split(',').ToList(); // Assuming pictures are stored as a comma-separated string
                        game.psModel = reader.GetString(reader.GetOrdinal("psModel"));

                        allGames.Add(game);
                    }
                }
            }
        }
    }
}
