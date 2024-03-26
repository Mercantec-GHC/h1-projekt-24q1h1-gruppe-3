using DomainModels;
using Npgsql;
using System.Buffers;
using System;
using BlazorApp;
using Microsoft.AspNetCore.SignalR;

namespace Service
{
    public class DatabaseService
    {
        public string connectionString;
        public List<Item> allItems;

        public DatabaseService(string connectionString) { this.connectionString = connectionString; this.allItems = GetAllData(); }
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

        public void AddPCGameToDatabase(PC_Game pcGameToBeCreated)
        {

            using var connection = new NpgsqlConnection(connectionString);

            connection.Open();

            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = connection;
                if (pcGameToBeCreated is PC_Game pcGame)
                {
                    string insertCommand = $@"INSERT INTO items(type, gamename, genre, price, manufacture, condition, description)
                                            VALUES('PC', '{pcGame.gameName}','{pcGame.genre}','{pcGame.price}','{pcGame.manufacture}','{pcGame.condition}','{pcGame.description}')";
                    cmd.CommandText = insertCommand;
                    cmd.ExecuteNonQuery();
                    this.allItems = GetAllData();
                }
            }

        }
        public void AddPSGameToDatabase(PS_Game psGameToBeCreated)
        {

            using var connection = new NpgsqlConnection(connectionString);

            connection.Open();

            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = connection;
                if (psGameToBeCreated is PS_Game psGame)
                {
                    string insertCommand = $@"INSERT INTO items(type, gamename, genre, price, manufacture, condition, description)
                                            VALUES('PS', '{psGame.gameName}','{psGame.genre}','{psGame.price}','{psGame.manufacture}','{psGame.condition}','{psGame.description}')";
                    cmd.CommandText = insertCommand;
                    cmd.ExecuteNonQuery();
                    this.allItems = GetAllData();
                }
            }

        }
        public void AddXboxGameToDatabase(XBOX_Game XboxGameToBeCreated)
        {

            using var connection = new NpgsqlConnection(connectionString);

            connection.Open();

            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = connection;
                if (XboxGameToBeCreated is XBOX_Game XboxGame)
                {
                    string insertCommand = $@"INSERT INTO items(type, gamename, genre, price, manufacture, condition, description)
                                            VALUES('XBOX', '{XboxGame.gameName}','{XboxGame.genre}','{XboxGame.price}','{XboxGame.manufacture}','{XboxGame.condition}','{XboxGame.description}')";
                    cmd.CommandText = insertCommand;
                    cmd.ExecuteNonQuery();
                    this.allItems = GetAllData();
                }
            }

        }
    }
}
