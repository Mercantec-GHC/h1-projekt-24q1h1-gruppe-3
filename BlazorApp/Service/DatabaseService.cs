using DomainModels;
using Npgsql;
using System.Buffers;
using System;
using BlazorApp.DomainModels;


namespace Service
{
    public class DatabaseService
    {
        public string connectionString;

        public DatabaseService(string connectionString) { this.connectionString = connectionString; }

        public List<PC_Game> GetAllPCGames()
        {
            List<PC_Game> allPCGames = new List<PC_Game>();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM pc_game";

                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            allPCGames.Add(new PC_Game(
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
                                reader["description"].ToString()
                                )
                            );
                        }
                    }
                }
            }
            return allPCGames;
        }
        public List<PS_Game> GetAllPSGames()
        {
            List<PS_Game> allPSGames = new List<PS_Game>();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM ps_game";

                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            allPSGames.Add(new PS_Game(
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
                                reader["description"].ToString()
                                )
                            );
                        }
                    }
                }
            }
            return allPSGames;
        }
        public List<XBOX_Game> GetAllXBOXGames()
        {
            List<XBOX_Game> allXBOXGames = new List<XBOX_Game>();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM xbox_game";

                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            allXBOXGames.Add(new XBOX_Game(
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
                                reader["description"].ToString()
                                )
                            );
                        }
                    }
                }
            }
            return allXBOXGames;
        }
        
        public List<All_Games> GetAllGames()
        {
            List<All_Games> allGames = new List<All_Games>();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM all_games";

                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            allGames.Add(new All_Games(
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
                                reader["description"].ToString()
                                )
                            );
                        }
                    }
                }
            }
            return allGames;
        }



    }

}
