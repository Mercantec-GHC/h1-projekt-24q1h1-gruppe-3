﻿using DomainModels;
using System;
using Npgsql;
using System.Collections.Generic;

namespace DomainModels
{
    public class GameDataService
    {
        public void InsertDummyDataIntoDB(List<Item> AllGames)
        {
            string connectionString = "";
            using var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = connection;
                foreach (var game in AllGames)
                {
                    if (game is PC_Game pc_Game)
                    {
                        string insertCommand = $@"INSERT INTO PC_Games(itemID, gameName, price, orderStatus, condition, created, updated, genre, manufacture, addToFaverite, description, operatingSystem, yearDeployed)
                                                          VALUES('{pc_Game.itemID}', '{pc_Game.gameName}', '{pc_Game.price}', '{pc_Game.orderStatus}', '{pc_Game.condition}', '{pc_Game.created}','{pc_Game.updated}','{pc_Game.genre}','{pc_Game.manufacture}','{pc_Game.addToFaverite}','{pc_Game.description}', '{pc_Game.operatingSystem}', '{pc_Game.yearDeployed}')";

                        cmd.CommandText = insertCommand;
                        cmd.ExecuteNonQuery();
                    }
                    else if (game is PS_Game ps_Game)
                    {
                        string insertCommand = $@"INSERT INTO PS_Games(itemID, gameName, price, orderStatus, condition, created, updated, genre, manufacture, addToFaverite, description, psModel, yearDeployed)
                                                          VALUES('{ps_Game.itemID}', '{ps_Game.gameName}', '{ps_Game.price}', '{ps_Game.orderStatus}', '{ps_Game.condition}', '{ps_Game.created}','{ps_Game.updated}','{ps_Game.genre}','{ps_Game.manufacture}','{ps_Game.addToFaverite}', '{ps_Game.description}', '{ps_Game.psModel}', '{ps_Game.yearDeployed}')";

                        cmd.CommandText = insertCommand;
                        cmd.ExecuteNonQuery();
                    }
                    else if (game is XBOX_Game xbox_Game)
                    {
                        string insertCommand = $@"INSERT INTO PS_Games(itemID, gameName, price, orderStatus, condition, created, updated, genre, manufacture, addToFaverite, description, xboxModel, yearDeployed)
                                                          VALUES('{xbox_Game.itemID}', '{xbox_Game.gameName}', '{xbox_Game.price}', '{xbox_Game.orderStatus}', '{xbox_Game.condition}', '{xbox_Game.created}','{xbox_Game.updated}','{xbox_Game.genre}','{xbox_Game.manufacture}','{xbox_Game.addToFaverite}', '{xbox_Game.description}', '{xbox_Game.xboxModel}', '{xbox_Game.yearDeployed}')";

                        cmd.CommandText = insertCommand;
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        public class CreateGames
        {
            public List<Item> GenereteDummyItems()
            {
                List<Item> allDummyData = new List<Item>();

                // Generating 40 dummy PC_Game instances
                for (int i = 1; i <= 40; i++)
                {
                    allDummyData.Add(new PC_Game(i, $"Game {i}", 100 + i, true, "New", DateTime.Now, DateTime.Now, "Action-RPG", $"Manufacturer {i}", false, $"Description for Game {i}", "Windows", DateTime.Now));
                }

                // Generating 40 dummy PS_Game instances
                for (int i = 41; i <= 80; i++)
                {
                    allDummyData.Add(new PS_Game(i, $"Game {i}", 100 + i, true, "New", DateTime.Now, DateTime.Now, "Action-Adventure", $"Manufacturer {i}", false, $"Description for Game {i}", "PS4", DateTime.Now));
                }

                // Generating 40 dummy XBOX_Game instances
                for (int i = 81; i <= 120; i++)
                {
                    allDummyData.Add(new XBOX_Game(i, $"Game {i}", 100 + i, true, "New", DateTime.Now, DateTime.Now, "First-Person Shooter", $"Manufacturer {i}", false, $"Description for Game {i}", "Xbox Series X", DateTime.Now));
                }

                return allDummyData;
            }



            //public class CreateGames
            //{
            //    public List<Item> GenereteDummyItems()
            //    {
            //        List<Item> allDummyData = new List<Item>();
            //        allDummyData.Add(new PC_Game
            //        {
            //            itemID = 1,
            //            gameName = "The Elder Scrolls V: Skyrim",
            //            price = 100,
            //            orderStatus = true,
            //            condition = "New",
            //            created = DateTime.Now,
            //            updated = DateTime.Now,
            //            genre = "Action-RPG",
            //            manufacture = "Bethesda Game Studios",
            //            addToFaverite = false,
            //            description = "Explore the world of Skyrim, filled with dragons, magic, and epic adventures."
            //        });

            //        allDummyData.Add(new PS_Game
            //        {
            //            itemID = 2,
            //            gameName = "The Elder Scrolls V: Skyrim",
            //            price = 102,
            //            orderStatus = true,
            //            condition = "New",
            //            created = DateTime.Now,
            //            updated = DateTime.Now,
            //            genre = "Action-RPG",
            //            manufacture = "Bethesda Game Studios",
            //            addToFaverite = false,
            //            description = "Explore the world of Skyrim, filled with dragons, magic, and epic adventures."

            //        });

            //        allDummyData.Add(new PC_Game
            //        {
            //            itemID = 3,
            //            gameName = "Game 3",
            //            price = 102,
            //            orderStatus = true,
            //            condition = "New",
            //            created = DateTime.Now.AddDays(-2),
            //            updated = DateTime.Now.AddDays(-2),
            //            genre = "Action-RPG",
            //            manufacture = "Manufacturer 3",
            //            addToFaverite = false,
            //            description = "A thrilling action-RPG experience with a captivating storyline and immersive gameplay."
            //        });

            //        allDummyData.Add(new PS_Game
            //        {
            //            itemID = 4,
            //            gameName = "Horizon Zero Dawn",
            //            price = 80,
            //            orderStatus = true,
            //            condition = "New",
            //            created = DateTime.Now.AddDays(-5),
            //            updated = DateTime.Now.AddDays(-5),
            //            genre = "Action-Adventure",
            //            manufacture = "Guerrilla Games",
            //            addToFaverite = false,
            //            description = "Embark on a journey through a lush post-apocalyptic world inhabited by robotic creatures."
            //        });

            //        allDummyData.Add(new PC_Game
            //        {
            //            itemID = 5,
            //            gameName = "The Witcher 3: Wild Hunt",
            //            price = 60,
            //            orderStatus = true,
            //            condition = "New",
            //            created = DateTime.Now.AddDays(-10),
            //            updated = DateTime.Now.AddDays(-10),
            //            genre = "Action-RPG",
            //            manufacture = "CD Projekt",
            //            addToFaverite = false,
            //            description = "Enter a dark fantasy world as Geralt of Rivia, a monster hunter on a quest to find his adopted daughter."
            //        });

            //        allDummyData.Add(new PS_Game
            //        {
            //            itemID = 6,
            //            gameName = "Red Dead Redemption 2",
            //            price = 90,
            //            orderStatus = true,
            //            condition = "New",
            //            created = DateTime.Now.AddDays(-15),
            //            updated = DateTime.Now.AddDays(-15),
            //            genre = "Action-Adventure",
            //            manufacture = "Rockstar Games",
            //            addToFaverite = false,
            //            description = "Experience the end of the Wild West era as outlaw Arthur Morgan in this epic tale of loyalty and survival."
            //        });

            //        allDummyData.Add(new PC_Game
            //        {
            //            itemID = 7,
            //            gameName = "Cyberpunk 2077",
            //            price = 70,
            //            orderStatus = true,
            //            condition = "New",
            //            created = DateTime.Now.AddDays(-20),
            //            updated = DateTime.Now.AddDays(-20),
            //            genre = "Action-Adventure",
            //            manufacture = "CD Projekt",
            //            addToFaverite = false,
            //            description = "Immerse yourself in the dystopian future of Night City as V, a mercenary outlaw seeking a one-of-a-kind implant."
            //        });

            //        allDummyData.Add(new PS_Game
            //        {
            //            itemID = 8,
            //            gameName = "Ghost of Tsushima",
            //            price = 75,
            //            orderStatus = true,
            //            condition = "New",
            //            created = DateTime.Now.AddDays(-25),
            //            updated = DateTime.Now.AddDays(-25),
            //            genre = "Action-Adventure",
            //            manufacture = "Sucker Punch Productions",
            //            addToFaverite = false,
            //            description = "Step into the shoes of Jin Sakai, a samurai warrior on a quest to protect Tsushima Island from Mongol invaders."
            //        });
            //        allDummyData.Add(new PC_Game
            //        {
            //            itemID = 9,
            //            gameName = "Mass Effect 2",
            //            price = 50,
            //            orderStatus = true,
            //            condition = "New",
            //            created = DateTime.Now.AddDays(-30),
            //            updated = DateTime.Now.AddDays(-30),
            //            genre = "Action-RPG",
            //            manufacture = "BioWare",
            //            addToFaverite = false,
            //            description = "Commander Shepard returns in this epic sci-fi adventure to save the galaxy from a new threat."
            //        });

            //        allDummyData.Add(new PS_Game
            //        {
            //            itemID = 10,
            //            gameName = "Uncharted 4: A Thief's End",
            //            price = 65,
            //            orderStatus = true,
            //            condition = "New",
            //            created = DateTime.Now.AddDays(-35),
            //            updated = DateTime.Now.AddDays(-35),
            //            genre = "Action-Adventure",
            //            manufacture = "Naughty Dog",
            //            addToFaverite = false,
            //            description = "Join Nathan Drake on his final adventure as he searches for a legendary pirate treasure."
            //        });

            //        allDummyData.Add(new PC_Game
            //        {
            //            itemID = 11,
            //            gameName = "Dark Souls III",
            //            price = 55,
            //            orderStatus = true,
            //            condition = "New",
            //            created = DateTime.Now.AddDays(-40),
            //            updated = DateTime.Now.AddDays(-40),
            //            genre = "Action-RPG",
            //            manufacture = "FromSoftware",
            //            addToFaverite = false,
            //            description = "Prepare to die in the challenging world of Lothric as you uncover its dark secrets and face terrifying foes."
            //        });

            //        allDummyData.Add(new PS_Game
            //        {
            //            itemID = 12,
            //            gameName = "Bloodborne",
            //            price = 45,
            //            orderStatus = true,
            //            condition = "New",
            //            created = DateTime.Now.AddDays(-45),
            //            updated = DateTime.Now.AddDays(-45),
            //            genre = "Action-RPG",
            //            manufacture = "FromSoftware",
            //            addToFaverite = false,
            //            description = "Venture into the Gothic city of Yharnam and battle nightmarish creatures in this action-packed RPG."
            //        });

            //        allDummyData.Add(new PC_Game
            //        {
            //            itemID = 13,
            //            gameName = "Divinity: Original Sin 2",
            //            price = 75,
            //            orderStatus = true,
            //            condition = "New",
            //            created = DateTime.Now.AddDays(-50),
            //            updated = DateTime.Now.AddDays(-50),
            //            genre = "RPG",
            //            manufacture = "Larian Studios",
            //            addToFaverite = false,
            //            description = "Embark on a fantastical journey alone or with friends in this critically acclaimed RPG with deep tactical gameplay."
            //        });

            //        allDummyData.Add(new PS_Game
            //        {
            //            itemID = 14,
            //            gameName = "God of War (2018)",
            //            price = 70,
            //            orderStatus = true,
            //            condition = "New",
            //            created = DateTime.Now.AddDays(-55),
            //            updated = DateTime.Now.AddDays(-55),
            //            genre = "Action-Adventure",
            //            manufacture = "Santa Monica Studio",
            //            addToFaverite = false,
            //            description = "Join Kratos and his son Atreus on a breathtaking journey through the realms of Norse mythology."
            //        });

            //        allDummyData.Add(new PC_Game
            //        {
            //            itemID = 15,
            //            gameName = "Borderlands 3",
            //            price = 55,
            //            orderStatus = true,
            //            condition = "New",
            //            created = DateTime.Now.AddDays(-60),
            //            updated = DateTime.Now.AddDays(-60),
            //            genre = "Action RPG",
            //            manufacture = "Gearbox Software",
            //            addToFaverite = false,
            //            description = "Shoot and loot your way through the chaotic world of Pandora in this irreverent co-op shooter."
            //        });

            //        allDummyData.Add(new PS_Game
            //        {
            //            itemID = 16,
            //            gameName = "Persona 5",
            //            price = 60,
            //            orderStatus = true,
            //            condition = "New",
            //            created = DateTime.Now.AddDays(-65),
            //            updated = DateTime.Now.AddDays(-65),
            //            genre = "RPG",
            //            manufacture = "Atlus",
            //            addToFaverite = false,
            //            description = "Lead a group of high school students as they balance their daily lives with battling supernatural forces."
            //        });

            //        allDummyData.Add(new PC_Game
            //        {
            //            itemID = 17,
            //            gameName = "Doom Eternal",
            //            price = 65,
            //            orderStatus = true,
            //            condition = "New",
            //            created = DateTime.Now.AddDays(-70),
            //            updated = DateTime.Now.AddDays(-70),
            //            genre = "First-Person Shooter",
            //            manufacture = "id Software",
            //            addToFaverite = false,
            //            description = "Rip and tear through hordes of demons in this fast-paced and brutal FPS sequel."
            //        });

            //        allDummyData.Add(new PS_Game
            //        {
            //            itemID = 18,
            //            gameName = "The Last of Us Part II",
            //            price = 75,
            //            orderStatus = true,
            //            condition = "New",
            //            created = DateTime.Now.AddDays(-75),
            //            updated = DateTime.Now.AddDays(-75),
            //            genre = "Action-Adventure",
            //            manufacture = "Naughty Dog",
            //            addToFaverite = false,
            //            description = "Experience the emotional journey of Ellie in a post-apocalyptic world filled with danger and moral dilemmas."
            //        });

            //        allDummyData.Add(new PC_Game
            //        {
            //            itemID = 19,
            //            gameName = "Star Wars Jedi: Fallen Order",
            //            price = 70,
            //            orderStatus = true,
            //            condition = "New",
            //            created = DateTime.Now.AddDays(-80),
            //            updated = DateTime.Now.AddDays(-80),
            //            genre = "Action-Adventure",
            //            manufacture = "Respawn Entertainment",
            //            addToFaverite = false,
            //            description = "Become a Jedi on the run and uncover the mysteries of the Force in this thrilling Star Wars adventure."
            //        });

            //        allDummyData.Add(new PS_Game
            //        {
            //            itemID = 20,
            //            gameName = "Marvel's Spider-Man",
            //            price = 65,
            //            orderStatus = true,
            //            condition = "New",
            //            created = DateTime.Now.AddDays(-85),
            //            updated = DateTime.Now.AddDays(-85),
            //            genre = "Action-Adventure",
            //            manufacture = "Insomniac Games",
            //            addToFaverite = false,
            //            description = "Swing through the streets of New York City as Spider-Man and battle iconic villains in this open-world adventure."
            //        });

            //        allDummyData.Add(new XBOX_Game
            //        {
            //            itemID = 17,
            //            gameName = "Halo Infinite",
            //            price = 70,
            //            orderStatus = true,
            //            condition = "New",
            //            created = DateTime.Now.AddDays(-30),
            //            updated = DateTime.Now.AddDays(-15),
            //            genre = "First-Person Shooter",
            //            manufacture = "343 Industries",
            //            addToFaverite = false,
            //            description = "The next chapter in the legendary Halo series, featuring an epic campaign and multiplayer experience."
            //        });

            //    return allDummyData;
            //}







            public List<User> GenerateDummyUsers()
            {
                List<User> allDummyUsers = new List<User>();

                allDummyUsers.Add(new User
                {
                    name = "John Doe",
                    userID = 1,
                    phoneNumber = "123-456-7890",
                    email = "john.doe@example.com",
                    Location = "New York, NY",
                    yearCreated = new DateTime(2020, 1, 1),
                    itemsSold = 10,
                    favorites = new List<string> { "Books", "Movies" },
                    ItemsViewed = 50
                });

                allDummyUsers.Add(new User
                {
                    name = "Jane Smith",
                    userID = 2,
                    phoneNumber = "098-765-4321",
                    email = "jane.smith@example.com",
                    Location = "Los Angeles, CA",
                    yearCreated = new DateTime(2019, 6, 15),
                    itemsSold = 15,
                    favorites = new List<string> { "Music", "Art" },
                    ItemsViewed = 75
                });

                allDummyUsers.Add(new User
                {
                    name = "Alice Johnson",
                    userID = 3,
                    phoneNumber = "111-222-3333",
                    email = "alice.johnson@example.com",
                    Location = "Chicago, IL",
                    yearCreated = new DateTime(2021, 3, 10),
                    itemsSold = 5,
                    favorites = new List<string> { "Fashion", "Cooking" },
                    ItemsViewed = 30
                });

                allDummyUsers.Add(new User
                {
                    name = "Michael Brown",
                    userID = 4,
                    phoneNumber = "444-555-6666",
                    email = "michael.brown@example.com",
                    Location = "Houston, TX",
                    yearCreated = new DateTime(2020, 9, 20),
                    itemsSold = 20,
                    favorites = new List<string> { "Electronics", "Sports" },
                    ItemsViewed = 100
                });

                allDummyUsers.Add(new User
                {
                    name = "Emily Davis",
                    userID = 5,
                    phoneNumber = "777-888-9999",
                    email = "emily.davis@example.com",
                    Location = "Miami, FL",
                    yearCreated = new DateTime(2018, 5, 8),
                    itemsSold = 25,
                    favorites = new List<string> { "Home Decor", "Travel" },
                    ItemsViewed = 120
                });

                allDummyUsers.Add(new User
                {
                    name = "William Wilson",
                    userID = 6,
                    phoneNumber = "123-456-7890",
                    email = "william.wilson@example.com",
                    Location = "Seattle, WA",
                    yearCreated = new DateTime(2017, 12, 25),
                    itemsSold = 12,
                    favorites = new List<string> { "Gardening", "Photography" },
                    ItemsViewed = 60
                });

                allDummyUsers.Add(new User
                {
                    name = "Olivia Martinez",
                    userID = 7,
                    phoneNumber = "321-654-9876",
                    email = "olivia.martinez@example.com",
                    Location = "Dallas, TX",
                    yearCreated = new DateTime(2019, 8, 14),
                    itemsSold = 18,
                    favorites = new List<string> { "Health & Fitness", "Beauty" },
                    ItemsViewed = 90
                });

                allDummyUsers.Add(new User
                {
                    name = "James Taylor",
                    userID = 8,
                    phoneNumber = "555-555-5555",
                    email = "james.taylor@example.com",
                    Location = "Atlanta, GA",
                    yearCreated = new DateTime(2022, 2, 28),
                    itemsSold = 8,
                    favorites = new List<string> { "Tech Gadgets", "Gaming" },
                    ItemsViewed = 40
                });

                allDummyUsers.Add(new User
                {
                    name = "Sophia Brown",
                    userID = 9,
                    phoneNumber = "444-444-4444",
                    email = "sophia.brown@example.com",
                    Location = "San Francisco, CA",
                    yearCreated = new DateTime(2021, 11, 11),
                    itemsSold = 30,
                    favorites = new List<string> { "Fashion", "Books" },
                    ItemsViewed = 150
                });

                allDummyUsers.Add(new User
                {
                    name = "Liam Miller",
                    userID = 10,
                    phoneNumber = "666-666-6666",
                    email = "liam.miller@example.com",
                    Location = "Boston, MA",
                    yearCreated = new DateTime(2020, 4, 30),
                    itemsSold = 22,
                    favorites = new List<string> { "Music", "Art" },
                    ItemsViewed = 110
                });

                allDummyUsers.Add(new User
                {
                    name = "Ava Garcia",
                    userID = 11,
                    phoneNumber = "777-777-7777",
                    email = "ava.garcia@example.com",
                    Location = "Denver, CO",
                    yearCreated = new DateTime(2019, 10, 5),
                    itemsSold = 16,
                    favorites = new List<string> { "Outdoor Gear", "Pets" },
                    ItemsViewed = 80
                });

                allDummyUsers.Add(new User
                {
                    name = "Noah Rodriguez",
                    userID = 12,
                    phoneNumber = "999-999-9999",
                    email = "noah.rodriguez@example.com",
                    Location = "Phoenix, AZ",
                    yearCreated = new DateTime(2022, 6, 18),
                    itemsSold = 14,
                    favorites = new List<string> { "Cooking", "Travel" },
                    ItemsViewed = 70
                });

                allDummyUsers.Add(new User
                {
                    name = "Isabella Hernandez",
                    userID = 13,
                    phoneNumber = "888-888-8888",
                    email = "isabella.hernandez@example.com",
                    Location = "Philadelphia, PA",
                    yearCreated = new DateTime(2018, 8, 22),
                    itemsSold = 19,
                    favorites = new List<string> { "Home Decor", "Crafts" },
                    ItemsViewed = 95
                });

                allDummyUsers.Add(new User
                {
                    name = "Ethan Lopez",
                    userID = 14,
                    phoneNumber = "101-202-3030",
                    email = "ethan.lopez@example.com",
                    Location = "San Diego, CA",
                    yearCreated = new DateTime(2020, 3, 15),
                    itemsSold = 28,
                    favorites = new List<string> { "Tech Gadgets", "Gaming" },
                    ItemsViewed = 140
                });

                allDummyUsers.Add(new User
                {
                    name = "Mia Gonzalez",
                    userID = 15,
                    phoneNumber = "505-606-7070",
                    email = "mia.gonzalez@example.com",
                    Location = "Portland, OR",
                    yearCreated = new DateTime(2019, 5, 28),
                    itemsSold = 11,
                    favorites = new List<string> { "Fashion", "Beauty" },
                    ItemsViewed = 55
                });

                allDummyUsers.Add(new User
                {
                    name = "Lucas Perez",
                    userID = 16,
                    phoneNumber = "303-404-5050",
                    email = "lucas.perez@example.com",
                    Location = "Austin, TX",
                    yearCreated = new DateTime(2021, 1, 8),
                    itemsSold = 17,
                    favorites = new List<string> { "Sports", "Outdoor Gear" },
                    ItemsViewed = 85
                });

                allDummyUsers.Add(new User
                {
                    name = "Amelia Flores",
                    userID = 17,
                    phoneNumber = "202-303-4040",
                    email = "amelia.flores@example.com",
                    Location = "Charlotte, NC",
                    yearCreated = new DateTime(2020, 7, 17),
                    itemsSold = 23,
                    favorites = new List<string> { "Books", "Music" },
                    ItemsViewed = 115
                });

                allDummyUsers.Add(new User
                {
                    name = "Oliver Washington",
                    userID = 18,
                    phoneNumber = "707-808-9090",
                    email = "oliver.washington@example.com",
                    Location = "Detroit, MI",
                    yearCreated = new DateTime(2019, 9, 3),
                    itemsSold = 13,
                    favorites = new List<string> { "Art", "Crafts" },
                    ItemsViewed = 65
                });

                allDummyUsers.Add(new User
                {
                    name = "Charlotte Nguyen",
                    userID = 19,
                    phoneNumber = "606-707-8080",
                    email = "charlotte.nguyen@example.com",
                    Location = "Nashville, TN",
                    yearCreated = new DateTime(2022, 4, 22),
                    itemsSold = 21,
                    favorites = new List<string> { "Music", "Movies" },
                    ItemsViewed = 105
                });

                allDummyUsers.Add(new User
                {
                    name = "Benjamin Kim",
                    userID = 20,
                    phoneNumber = "404-505-6060",
                    email = "benjamin.kim@example.com",
                    Location = "Minneapolis, MN",
                    yearCreated = new DateTime(2018, 10, 12),
                    itemsSold = 26,
                    favorites = new List<string> { "Electronics", "Tech Gadgets" },
                    ItemsViewed = 130
                });

                // Add more users as needed

                return allDummyUsers;
            }
        }
    }
}
