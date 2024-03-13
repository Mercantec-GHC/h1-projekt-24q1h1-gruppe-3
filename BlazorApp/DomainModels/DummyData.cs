using DomainModels;

namespace DomainModels
{
    public class DummyData
    {
        public List<Item> GenereteDummyItems()
        {
            List<Item> allDummyData = new List<Item>();
            allDummyData.Add(new PC_Game
            {
                itemID = 1,
                gameName = "The Elder Scrolls V: Skyrim",
                price = 100,
                orderStatus = true,
                condition = "New",
                created = DateTime.Now,
                updated = DateTime.Now,
                genre = "Action-RPG",
                manufacture = "Bethesda Game Studios",
                addToFaverite = false,
                description = "Explore the world of Skyrim, filled with dragons, magic, and epic adventures."
            });

            allDummyData.Add(new PS_Game
            {
                itemID = 2,
                gameName = "The Elder Scrolls V: Skyrim",
                price = 100,
                orderStatus = true,
                condition = "New",
                created = DateTime.Now,
                updated = DateTime.Now,
                genre = "Action-RPG",
                manufacture = "Bethesda Game Studios",
                addToFaverite = false,
                description = "Explore the world of Skyrim, filled with dragons, magic, and epic adventures."
            });

            allDummyData.Add(new PC_Game
            {
                itemID = 3,
                gameName = "Game 3",
                price = 102,
                orderStatus = true,
                condition = "New",
                created = DateTime.Now.AddDays(-2),
                updated = DateTime.Now.AddDays(-2),
                genre = "Action-RPG",
                manufacture = "Manufacturer 3",
                addToFaverite = false,
                description = "A thrilling action-RPG experience with a captivating storyline and immersive gameplay."
            });

            allDummyData.Add(new PS_Game
            {
                itemID = 4,
                gameName = "Horizon Zero Dawn",
                price = 80,
                orderStatus = true,
                condition = "New",
                created = DateTime.Now.AddDays(-5),
                updated = DateTime.Now.AddDays(-5),
                genre = "Action-Adventure",
                manufacture = "Guerrilla Games",
                addToFaverite = false,
                description = "Embark on a journey through a lush post-apocalyptic world inhabited by robotic creatures."
            });

            allDummyData.Add(new PC_Game
            {
                itemID = 5,
                gameName = "The Witcher 3: Wild Hunt",
                price = 60,
                orderStatus = true,
                condition = "New",
                created = DateTime.Now.AddDays(-10),
                updated = DateTime.Now.AddDays(-10),
                genre = "Action-RPG",
                manufacture = "CD Projekt",
                addToFaverite = false,
                description = "Enter a dark fantasy world as Geralt of Rivia, a monster hunter on a quest to find his adopted daughter."
            });

            allDummyData.Add(new PS_Game
            {
                itemID = 6,
                gameName = "Red Dead Redemption 2",
                price = 90,
                orderStatus = true,
                condition = "New",
                created = DateTime.Now.AddDays(-15),
                updated = DateTime.Now.AddDays(-15),
                genre = "Action-Adventure",
                manufacture = "Rockstar Games",
                addToFaverite = false,
                description = "Experience the end of the Wild West era as outlaw Arthur Morgan in this epic tale of loyalty and survival."
            });

            allDummyData.Add(new PC_Game
            {
                itemID = 7,
                gameName = "Cyberpunk 2077",
                price = 70,
                orderStatus = true,
                condition = "New",
                created = DateTime.Now.AddDays(-20),
                updated = DateTime.Now.AddDays(-20),
                genre = "Action-Adventure",
                manufacture = "CD Projekt",
                addToFaverite = false,
                description = "Immerse yourself in the dystopian future of Night City as V, a mercenary outlaw seeking a one-of-a-kind implant."
            });

            allDummyData.Add(new PS_Game
            {
                itemID = 8,
                gameName = "Ghost of Tsushima",
                price = 75,
                orderStatus = true,
                condition = "New",
                created = DateTime.Now.AddDays(-25),
                updated = DateTime.Now.AddDays(-25),
                genre = "Action-Adventure",
                manufacture = "Sucker Punch Productions",
                addToFaverite = false,
                description = "Step into the shoes of Jin Sakai, a samurai warrior on a quest to protect Tsushima Island from Mongol invaders."
            });
            allDummyData.Add(new PC_Game
            {
                itemID = 9,
                gameName = "Mass Effect 2",
                price = 50,
                orderStatus = true,
                condition = "New",
                created = DateTime.Now.AddDays(-30),
                updated = DateTime.Now.AddDays(-30),
                genre = "Action-RPG",
                manufacture = "BioWare",
                addToFaverite = false,
                description = "Commander Shepard returns in this epic sci-fi adventure to save the galaxy from a new threat."
            });

            allDummyData.Add(new PS_Game
            {
                itemID = 10,
                gameName = "Uncharted 4: A Thief's End",
                price = 65,
                orderStatus = true,
                condition = "New",
                created = DateTime.Now.AddDays(-35),
                updated = DateTime.Now.AddDays(-35),
                genre = "Action-Adventure",
                manufacture = "Naughty Dog",
                addToFaverite = false,
                description = "Join Nathan Drake on his final adventure as he searches for a legendary pirate treasure."
            });

            allDummyData.Add(new PC_Game
            {
                itemID = 11,
                gameName = "Dark Souls III",
                price = 55,
                orderStatus = true,
                condition = "New",
                created = DateTime.Now.AddDays(-40),
                updated = DateTime.Now.AddDays(-40),
                genre = "Action-RPG",
                manufacture = "FromSoftware",
                addToFaverite = false,
                description = "Prepare to die in the challenging world of Lothric as you uncover its dark secrets and face terrifying foes."
            });

            allDummyData.Add(new PS_Game
            {
                itemID = 12,
                gameName = "Bloodborne",
                price = 45,
                orderStatus = true,
                condition = "New",
                created = DateTime.Now.AddDays(-45),
                updated = DateTime.Now.AddDays(-45),
                genre = "Action-RPG",
                manufacture = "FromSoftware",
                addToFaverite = false,
                description = "Venture into the Gothic city of Yharnam and battle nightmarish creatures in this action-packed RPG."
            });

            allDummyData.Add(new PC_Game
            {
                itemID = 13,
                gameName = "Divinity: Original Sin 2",
                price = 75,
                orderStatus = true,
                condition = "New",
                created = DateTime.Now.AddDays(-50),
                updated = DateTime.Now.AddDays(-50),
                genre = "RPG",
                manufacture = "Larian Studios",
                addToFaverite = false,
                description = "Embark on a fantastical journey alone or with friends in this critically acclaimed RPG with deep tactical gameplay."
            });

            allDummyData.Add(new PS_Game
            {
                itemID = 14,
                gameName = "God of War (2018)",
                price = 70,
                orderStatus = true,
                condition = "New",
                created = DateTime.Now.AddDays(-55),
                updated = DateTime.Now.AddDays(-55),
                genre = "Action-Adventure",
                manufacture = "Santa Monica Studio",
                addToFaverite = false,
                description = "Join Kratos and his son Atreus on a breathtaking journey through the realms of Norse mythology."
            });

            allDummyData.Add(new PC_Game
            {
                itemID = 15,
                gameName = "Borderlands 3",
                price = 55,
                orderStatus = true,
                condition = "New",
                created = DateTime.Now.AddDays(-60),
                updated = DateTime.Now.AddDays(-60),
                genre = "Action RPG",
                manufacture = "Gearbox Software",
                addToFaverite = false,
                description = "Shoot and loot your way through the chaotic world of Pandora in this irreverent co-op shooter."
            });

            allDummyData.Add(new PS_Game
            {
                itemID = 16,
                gameName = "Persona 5",
                price = 60,
                orderStatus = true,
                condition = "New",
                created = DateTime.Now.AddDays(-65),
                updated = DateTime.Now.AddDays(-65),
                genre = "RPG",
                manufacture = "Atlus",
                addToFaverite = false,
                description = "Lead a group of high school students as they balance their daily lives with battling supernatural forces."
            });

            allDummyData.Add(new PC_Game
            {
                itemID = 17,
                gameName = "Doom Eternal",
                price = 65,
                orderStatus = true,
                condition = "New",
                created = DateTime.Now.AddDays(-70),
                updated = DateTime.Now.AddDays(-70),
                genre = "First-Person Shooter",
                manufacture = "id Software",
                addToFaverite = false,
                description = "Rip and tear through hordes of demons in this fast-paced and brutal FPS sequel."
            });

            allDummyData.Add(new PS_Game
            {
                itemID = 18,
                gameName = "The Last of Us Part II",
                price = 75,
                orderStatus = true,
                condition = "New",
                created = DateTime.Now.AddDays(-75),
                updated = DateTime.Now.AddDays(-75),
                genre = "Action-Adventure",
                manufacture = "Naughty Dog",
                addToFaverite = false,
                description = "Experience the emotional journey of Ellie in a post-apocalyptic world filled with danger and moral dilemmas."
            });

            allDummyData.Add(new PC_Game
            {
                itemID = 19,
                gameName = "Star Wars Jedi: Fallen Order",
                price = 70,
                orderStatus = true,
                condition = "New",
                created = DateTime.Now.AddDays(-80),
                updated = DateTime.Now.AddDays(-80),
                genre = "Action-Adventure",
                manufacture = "Respawn Entertainment",
                addToFaverite = false,
                description = "Become a Jedi on the run and uncover the mysteries of the Force in this thrilling Star Wars adventure."
            });

            allDummyData.Add(new PS_Game
            {
                itemID = 20,
                gameName = "Marvel's Spider-Man",
                price = 65,
                orderStatus = true,
                condition = "New",
                created = DateTime.Now.AddDays(-85),
                updated = DateTime.Now.AddDays(-85),
                genre = "Action-Adventure",
                manufacture = "Insomniac Games",
                addToFaverite = false,
                description = "Swing through the streets of New York City as Spider-Man and battle iconic villains in this open-world adventure."
            });





            return allDummyData;
        }
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

            // Add more users as needed

            return allDummyUsers;
        }
    }
}
