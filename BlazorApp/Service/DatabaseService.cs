using DomainModels;
using Npgsql;
using System.Buffers;
using System;
using BlazorApp;

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
                            else if (type == "PS")
                            {
                                allData.Add(new PS_Game()
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
                            else if (type == "XBOX")
                            {
                                allData.Add(new XBOX_Game()
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

        public void AddGameToDatabase(PC_Game pcGameToBeCreated)
        {



            var builder = WebApplication.CreateBuilder();
                
            IConfiguration Configuration = builder.Configuration;
            var connectionString = Configuration.GetConnectionString("DefaultConnection") ?? Environment.GetEnvironmentVariable("DefaultConnection");
            using var connection = new NpgsqlConnection(connectionString);

            connection.Open();

            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = connection;
                if (pcGameToBeCreated is PC_Game pcGame)
                {
                    string insertCommand = $@"INSERT INTO item(type, gamename, genre, price, manufacture, condition, description)
                                        VALUES('PC', '{pcGame.gameName}','{pcGame.genre}','{pcGame.price}','{pcGame.manufacture}','{pcGame.condition}','{pcGame.description}')";
                    cmd.CommandText = insertCommand;
                    cmd.ExecuteNonQuery();
                }
            }
        
        }
    }
}
