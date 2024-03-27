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

        public int AddPCGameToDatabase(PC_Game pcGameToBeCreated)
        {
            int newItemId = -1; // Initialize newItemId to -1 (or any default value)

            using var connection = new NpgsqlConnection(connectionString);

            connection.Open();

            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = connection;
                if (pcGameToBeCreated is PC_Game pcGame)
                {
                    string insertCommand = $@"INSERT INTO items(type, gamename, genre, price, manufacture, condition, description)
                                    VALUES('PC', '{pcGame.gameName}','{pcGame.genre}','{pcGame.price}','{pcGame.manufacture}','{pcGame.condition}','{pcGame.description}')
                                    RETURNING itemid"; // Include RETURNING id to get the ID of the newly inserted row
                    cmd.CommandText = insertCommand;
                    newItemId = (int)cmd.ExecuteScalar(); // ExecuteScalar to get the ID of the newly inserted row
                    this.allItems = GetAllData(); // You may or may not need to update allItems
                }
            }

            return newItemId; // Return the ID of the newly added item
        }
        public int AddPSGameToDatabase(PS_Game psGameToBeCreated)
        {
            int newItemId = -1;
            using var connection = new NpgsqlConnection(connectionString);

            connection.Open();

            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = connection;
                if (psGameToBeCreated is PS_Game psGame)
                {
                    string insertCommand = $@"INSERT INTO items(type, gamename, genre, price, manufacture, condition, description)
                                            VALUES('PS', '{psGame.gameName}','{psGame.genre}','{psGame.price}','{psGame.manufacture}','{psGame.condition}','{psGame.description}')
                                            RETURNING itemid";
                    cmd.CommandText = insertCommand;
                    newItemId = (int)cmd.ExecuteScalar(); // ExecuteScalar to get the ID of the newly inserted row
                    this.allItems = GetAllData();

                }
            }
            return newItemId;
        }
        public int AddXboxGameToDatabase(XBOX_Game XboxGameToBeCreated)
        {
            int newItemId = -1;
            using var connection = new NpgsqlConnection(connectionString);

            connection.Open();

            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = connection;
                if (XboxGameToBeCreated is XBOX_Game XboxGame)
                {
                    string insertCommand = $@"INSERT INTO items(type, gamename, genre, price, manufacture, condition, description)
                                            VALUES('XBOX', '{XboxGame.gameName}','{XboxGame.genre}','{XboxGame.price}','{XboxGame.manufacture}','{XboxGame.condition}','{XboxGame.description}')
                                            RETURNING itemid";
                    cmd.CommandText = insertCommand;
                    newItemId = (int)cmd.ExecuteScalar(); // ExecuteScalar to get the ID of the newly inserted row
                    this.allItems = GetAllData();
                }
            }
            return newItemId;
        }
    }
}
