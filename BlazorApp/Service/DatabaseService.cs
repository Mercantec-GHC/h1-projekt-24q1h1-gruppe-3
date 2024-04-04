using DomainModels;
using Npgsql;
using System.Buffers;
using System;
using BlazorApp;
using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.Components;
using System.Security.Cryptography.X509Certificates;
using NpgsqlTypes;

namespace Service
{
    public class DatabaseService
    {
        public string connectionString;
        public List<Item> allItems;
        public string CurrentUserID { get; private set; }


        public void SetCurrentUserID(string userID)
        {
            CurrentUserID = userID;
        }

        //er det smart at den beder om alle bruger ved opstart??

        public DatabaseService(string connectionString) { this.connectionString = connectionString; this.allItems = GetAllData(); this.allUsers = GetAllUser(); }
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
                                    description = reader["description"].ToString(),
                                    userID = Convert.ToInt32(reader["userid"])
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
                                    description = reader["description"].ToString(),
                                    userID = Convert.ToInt32(reader["userid"])
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
                                    description = reader["description"].ToString(),
                                    userID = Convert.ToInt32(reader["userid"])
                                });
                            }
                        }
                        return allData;
                    }
                }
            }
        }
        public List<User> allUsers;
        public List<User> GetAllUser()
        {
            List<User> allUser = new List<User>();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM users";

                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            allUser.Add(new User()
                            {
                                name = reader["name"].ToString(),
                                userID = Convert.ToInt32(reader["id"]),
                                phoneNumber = reader["phonenumber"].ToString(),
                                email = reader["email"].ToString(),
                                password = reader["password"].ToString(),
                                city = reader["city"].ToString()
                            });
                        }
                        return allUser;
                    }
                }
            }
        }

        public int AddPCGameToDatabase(PC_Game pcGameToBeCreated)
        {
            int newItemId = -1; // Initialize newItemId to -1 (or any default value)

            int useridToInsert = Convert.ToInt32(CurrentUserID);

            using var connection = new NpgsqlConnection(connectionString);




            connection.Open();

            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = connection;
                if (pcGameToBeCreated is PC_Game pcGame)
                {
                    string insertCommand = $@"INSERT INTO items(type, gamename, genre, price, manufacture, condition, description, userid)
                                    VALUES('PC', '{pcGame.gameName}','{pcGame.genre}','{pcGame.price}','{pcGame.manufacture}','{pcGame.condition}','{pcGame.description}','{useridToInsert}')
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

            int useridToInsert = Convert.ToInt32(CurrentUserID);

            using var connection = new NpgsqlConnection(connectionString);

            connection.Open();

            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = connection;
                if (psGameToBeCreated is PS_Game psGame)
                {
                    string insertCommand = $@"INSERT INTO items(type, gamename, genre, price, manufacture, condition, description, userid)
                                            VALUES('PS', '{psGame.gameName}','{psGame.genre}','{psGame.price}','{psGame.manufacture}','{psGame.condition}','{psGame.description}','{useridToInsert}')
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

            int useridToInsert = Convert.ToInt32(CurrentUserID);

            using var connection = new NpgsqlConnection(connectionString);

            connection.Open();

            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = connection;
                if (XboxGameToBeCreated is XBOX_Game XboxGame)
                {
                    string insertCommand = $@"INSERT INTO items(type, gamename, genre, price, manufacture, condition, description, userid)
                                            VALUES('XBOX', '{XboxGame.gameName}','{XboxGame.genre}','{XboxGame.price}','{XboxGame.manufacture}','{XboxGame.condition}','{XboxGame.description}','{useridToInsert}')
                                            RETURNING itemid";
                    cmd.CommandText = insertCommand;
                    newItemId = (int)cmd.ExecuteScalar(); // ExecuteScalar to get the ID of the newly inserted row
                    this.allItems = GetAllData();
                }
            }
            return newItemId;
        }

        public void AddUserToDatabase(string name, string email, string password, string phonenumber, string city)
        {
            using var connection = new NpgsqlConnection(connectionString);

            connection.Open();

            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = connection;
                string insertCommand = @"INSERT INTO users(name, email, password, phonenumber, city)
                                VALUES(@Name, @Email, @Password, @phonenumber,@City)";
                cmd.CommandText = insertCommand;

                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@Phonenumber", phonenumber);
                cmd.Parameters.AddWithValue("@City", city);

                cmd.ExecuteNonQuery();
            }
        }

        public List<Item> GetListedSalesForUser(int userID)
        {

            List<Item> itemsForUser = new List<Item>();

            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string sql = $@"SELECT * FROM items WHERE userid = {userID}";
                using (var command = new NpgsqlCommand(sql, connection))
                {
                    //command.Parameters.AddWithValue("@UserID", userID);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var type = reader["type"].ToString().ToUpper();
                            if (type == "PC")
                            {
                                itemsForUser.Add(new PC_Game()
                                {
                                    itemID = Convert.ToInt32(reader["itemid"]),
                                    gameName = reader["gamename"].ToString(),
                                    genre = reader["genre"].ToString(),
                                    price = Convert.ToInt32(reader["price"]),
                                    manufacture = reader["manufacture"].ToString(),
                                    condition = reader["condition"].ToString(),
                                    description = reader["description"].ToString()
                                    // Assuming a 'userID' field exists linking the item to a user
                                    // user = Convert.ToInt32(reader["userid"])
                                });
                            }
                            else if (type == "PS")
                            {
                                itemsForUser.Add(new PS_Game()
                                {
                                    itemID = Convert.ToInt32(reader["itemid"]),
                                    gameName = reader["gamename"].ToString(),
                                    genre = reader["genre"].ToString(),
                                    price = Convert.ToInt32(reader["price"]),
                                    manufacture = reader["manufacture"].ToString(),
                                    condition = reader["condition"].ToString(),
                                    description = reader["description"].ToString()
                                    // user = Convert.ToInt32(reader["userid"])
                                });
                            }
                            else if (type == "XBOX")
                            {
                                itemsForUser.Add(new XBOX_Game()
                                {
                                    itemID = Convert.ToInt32(reader["itemid"]),
                                    gameName = reader["gamename"].ToString(),
                                    genre = reader["genre"].ToString(),
                                    price = Convert.ToInt32(reader["price"]),
                                    manufacture = reader["manufacture"].ToString(),
                                    condition = reader["condition"].ToString(),
                                    description = reader["description"].ToString()
                                    // user = Convert.ToInt32(reader["userid"])
                                });
                            }
                            // Add additional cases for other item types as necessary
                        }
                    }
                }
            }
            return itemsForUser;
        }

        public void DeleteItem(int itemID)
        {
            using var connection = new NpgsqlConnection(connectionString);
            connection.Open();

            // Prepare the SQL command to delete the item with the specified ID
            string deleteItemCommand = @"DELETE FROM items WHERE itemid = @ItemID";

            using (var cmd = new NpgsqlCommand(deleteItemCommand, connection))
            {
                // Add the item ID parameter to the command
                cmd.Parameters.AddWithValue("@ItemID", itemID);

                // Execute the command to delete the item
                cmd.ExecuteNonQuery();
            }

            // Optionally, update the allItems list to reflect the deletion
            this.allItems = GetAllData();
        }


        public List<User> GetSellerDetailsFromUsers(int userID)
        {
            List<User> seller = new List<User>();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string sql = $@"SELECT * FROM users WHERE id = {userID}";

                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            seller.Add(new User()
                            {
                                name = reader["name"].ToString(),
                                userID = Convert.ToInt32(reader["id"]),
                                phoneNumber = reader["phonenumber"].ToString(),
                                email = reader["email"].ToString(),
                                city = reader["city"].ToString()
                            });
                        }
                        return seller;
                    }
                }
            }

        }

        public List<int> GetFavoritesByUserID(int id)
        {
            List<int> favorites = new List<int>();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string sql = $@"SELECT array_to_string(favorites, ',') AS favorites 
                      FROM users 
                      WHERE id={id}";

                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            foreach (var item in reader["favorites"].ToString().Split(','))
                            {
                                favorites.Add(Convert.ToInt32(item));
                            }
                            //favorites = Convert.ToInt32(reader["favorites"].ToString()).ToList();
                        }
                        return favorites;
                    }
                }
            }
        }
        public void UpdateUserInDatabase(int userID, string name, string email, string password, string phoneNumber, string city)
        {
            using var connection = new NpgsqlConnection(connectionString);

            connection.Open();

            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = connection;
                string updateCommand = @"UPDATE users SET name = @Name, email = @Email, password = @password, phonenumber = @PhoneNumber, city = @City WHERE id = @UserID";
                cmd.CommandText = updateCommand;

                cmd.Parameters.Add(new NpgsqlParameter("@Name", NpgsqlDbType.Text) { Value = name });
                cmd.Parameters.Add(new NpgsqlParameter("@Email", NpgsqlDbType.Text) { Value = email });
                cmd.Parameters.Add(new NpgsqlParameter("@password", NpgsqlDbType.Text) { Value = password });
                cmd.Parameters.Add(new NpgsqlParameter("@PhoneNumber", NpgsqlDbType.Text) { Value = phoneNumber });
                cmd.Parameters.Add(new NpgsqlParameter("@City", NpgsqlDbType.Text) { Value = city });
                cmd.Parameters.Add(new NpgsqlParameter("@UserID", NpgsqlDbType.Integer) { Value = userID });

                cmd.ExecuteNonQuery();
            }
        }
        public void DeleteUserAndItsItems(int userID)
        {
            using var connection = new NpgsqlConnection(connectionString);
            connection.Open();

            // Dernæst slet brugeren selv
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = connection;
                string deleteUserCommand = @"DELETE FROM users WHERE id = @UserID";
                cmd.CommandText = deleteUserCommand;
                cmd.Parameters.AddWithValue("@UserID", userID);
                cmd.ExecuteNonQuery();
            }
        }
        public void AddItemToFavoriteInUsers(int userid, int itemid)
        {
            using var connection = new NpgsqlConnection(connectionString);
            connection.Open();

            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = connection;
                string insertFav = $"UPDATE users SET favorites = favorites || ARRAY[{itemid}] WHERE id = {userid}";
                cmd.CommandText = insertFav;
                cmd.ExecuteNonQuery();
            }
        }
    }
}
