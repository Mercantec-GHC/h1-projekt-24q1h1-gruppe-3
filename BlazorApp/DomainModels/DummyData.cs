using DomainModels;

namespace DomainModels
{
    public class CreateGames
    {
        public List<PC_Game> GeneretePCDummyGames()
        {
            List<PC_Game> allPCDummyData = new List<PC_Game>();
            allPCDummyData.Add(new PC_Game(
                1,
                "The Elder Scrolls V: Skyrim",
                100,
                true,
                "New",
                DateTime.Now,
                DateTime.Now,
                "Action-RPG",
                "Bethesda Game Studios",
                false,
                "Explore the world of Skyrim, filled with dragons, magic, and epic adventures."
            ));

            allPCDummyData.Add(new PC_Game(
                2,
                "The Elder Scrolls V: Skyrim",
                102,
                true,
                "New",
                DateTime.Now.AddDays(-2),
                DateTime.Now.AddDays(-2),
                "Action-RPG",
                "Bethesda Game Studios",
                false,
                "Explore the world of Skyrim, filled with dragons, magic, and epic adventures."
            ));

            allPCDummyData.Add(new PC_Game(
                3,
                "The Witcher 3: Wild Hunt",
                125,
                true,
                "Used",
                new DateTime(2023, 5, 12),
                new DateTime(2023, 6, 2),
                "Action-RPG",
                "CD Projekt Red",
                false,
                "Embark on a journey through a dark fantasy world in this action-packed RPG."
            ));

            allPCDummyData.Add(new PC_Game(
                4,
                "Grand Theft Auto V",
                180,
                true,
                "New",
                new DateTime(2023, 7, 20),
                new DateTime(2023, 8, 10),
                "Action-Adventure",
                "Rockstar Games",
                false,
                "Explore a sprawling open world filled with crime, mayhem, and opportunity."
            ));

            allPCDummyData.Add(new PC_Game(
                5,
                "Red Dead Redemption 2",
                150,
                true,
                "New",
                new DateTime(2023, 9, 15),
                new DateTime(2023, 10, 5),
                "Action-Adventure",
                "Rockstar Games",
                false,
                "Experience the Wild West like never before in this epic tale of outlaws and redemption."
            ));

            allPCDummyData.Add(new PC_Game(
                6,
                "Dark Souls III",
                95,
                false,
                "Used",
                new DateTime(2023, 11, 8),
                new DateTime(2023, 11, 28),
                "Action-RPG",
                "FromSoftware",
                false,
                "Prepare to die in this challenging action RPG filled with menacing foes and unforgiving difficulty."
            ));

            allPCDummyData.Add(new PC_Game(
                7,
                "Mass Effect 2",
                70,
                true,
                "Refurbished",
                new DateTime(2023, 12, 3),
                new DateTime(2023, 12, 23),
                "Action-RPG",
                "BioWare",
                true,
                "Command your own starship and save the galaxy in this acclaimed sci-fi RPG."
            ));

            allPCDummyData.Add(new PC_Game(
                8,
                "Divinity: Original Sin 2",
                110,
                true,
                "New",
                new DateTime(2024, 1, 18),
                new DateTime(2024, 2, 7),
                "RPG",
                "Larian Studios",
                false,
                "Gather your party and embark on an epic quest in this critically acclaimed RPG adventure."
            ));

            allPCDummyData.Add(new PC_Game(
                9,
                "Persona 5",
                100,
                true,
                "Used",
                new DateTime(2024, 3, 4),
                new DateTime(2024, 3, 24),
                "RPG",
                "Atlus",
                false,
                "Unravel the mysteries of the heart in this captivating RPG about high school life and supernatural powers."
            ));

            allPCDummyData.Add(new PC_Game(
                10,
                "DOOM Eternal",
                80,
                false,
                "Refurbished",
                new DateTime(2024, 4, 9),
                new DateTime(2024, 4, 29),
                "Action",
                "id Software",
                true,
                "Rip and tear through hordes of demons in this adrenaline-fueled first-person shooter."
            ));

            allPCDummyData.Add(new PC_Game(
                11,
                "Metal Gear Solid V: The Phantom Pain",
                90,
                true,
                "New",
                new DateTime(2024, 5, 14),
                new DateTime(2024, 6, 3),
                "Action-Adventure",
                "Konami",
                false,
                "Infiltrate enemy territory and complete missions as a legendary soldier in this gripping stealth action game."
            ));

            allPCDummyData.Add(new PC_Game(
                12,
                "Bloodborne",
                85,
                true,
                "Used",
                new DateTime(2024, 6, 29),
                new DateTime(2024, 7, 19),
                "Action-RPG",
                "FromSoftware",
                false,
                "Face your fears and uncover the truth in this hauntingly beautiful horror masterpiece."
            ));

            allPCDummyData.Add(new PC_Game(
                13,
                "The Witcher 3: Wild Hunt",
                125,
                true,
                "Used",
                new DateTime(2023, 5, 12),
                new DateTime(2023, 6, 2),
                "Action-RPG",
                "CD Projekt Red",
                false,
                "Embark on a journey through a dark fantasy world in this action-packed RPG."
            ));

            allPCDummyData.Add(new PC_Game(
                14,
                "Grand Theft Auto V",
                180,
                true,
                "New",
                new DateTime(2023, 7, 20),
                new DateTime(2023, 8, 10),
                "Action-Adventure",
                "Rockstar Games",
                false,
                "Explore a sprawling open world filled with crime, mayhem, and opportunity."
            ));

            allPCDummyData.Add(new PC_Game(
                15,
                "Red Dead Redemption 2",
                150,
                true,
                "New",
                new DateTime(2023, 9, 15),
                new DateTime(2023, 10, 5),
                "Action-Adventure",
                "Rockstar Games",
                false,
                "Experience the Wild West like never before in this epic tale of outlaws and redemption."
            ));

            allPCDummyData.Add(new PC_Game(
                16,
                "Dark Souls III",
                95,
                false,
                "Used",
                new DateTime(2023, 11, 8),
                new DateTime(2023, 11, 28),
                "Action-RPG",
                "FromSoftware",
                false,
                "Prepare to die in this challenging action RPG filled with menacing foes and unforgiving difficulty."
            ));

            allPCDummyData.Add(new PC_Game(
                17,
                "Mass Effect 2",
                70,
                true,
                "Refurbished",
                new DateTime(2023, 12, 3),
                new DateTime(2023, 12, 23),
                "Action-RPG",
                "BioWare",
                true,
                "Command your own starship and save the galaxy in this acclaimed sci-fi RPG."
            ));

            allPCDummyData.Add(new PC_Game(
                18,
                "Divinity: Original Sin 2",
                110,
                true,
                "New",
                new DateTime(2024, 1, 18),
                new DateTime(2024, 2, 7),
                "RPG",
                "Larian Studios",
                false,
                "Gather your party and embark on an epic quest in this critically acclaimed RPG adventure."
            ));

            allPCDummyData.Add(new PC_Game(
                19,
                "Persona 5",
                100,
                true,
                "Used",
                new DateTime(2024, 3, 4),
                new DateTime(2024, 3, 24),
                "RPG",
                "Atlus",
                false,
                "Unravel the mysteries of the heart in this captivating RPG about high school life and supernatural powers."
            ));

            allPCDummyData.Add(new PC_Game(
                20,
                "DOOM Eternal",
                80,
                false,
                "Refurbished",
                new DateTime(2024, 4, 9),
                new DateTime(2024, 4, 29),
                "Action",
                "id Software",
                true,
                "Rip and tear through hordes of demons in this adrenaline-fueled first-person shooter."
            ));

            allPCDummyData.Add(new PC_Game(
                21,
                "Metal Gear Solid V: The Phantom Pain",
                90,
                true,
                "New",
                new DateTime(2024, 5, 14),
                new DateTime(2024, 6, 3),
                "Action-Adventure",
                "Konami",
                false,
                "Infiltrate enemy territory and complete missions as a legendary soldier in this gripping stealth action game."
            ));

            allPCDummyData.Add(new PC_Game(
                22,
                "Bloodborne",
                85,
                true,
                "Used",
                new DateTime(2024, 6, 29),
                new DateTime(2024, 7, 19),
                "Action-RPG",
                "FromSoftware",
                false,
                "Face your fears and uncover the truth in this hauntingly beautiful horror masterpiece."
            ));

            return allPCDummyData;
        }

        public List<PS_Game> GeneretePSDummyGames()
        {
            List<PS_Game> allPSDummyData = new List<PS_Game>();
            allPSDummyData.Add(new PS_Game(
                1,
                "The Last of Us Part II",
                60,
                true,
                "New",
                new DateTime(2023, 8, 1),
                new DateTime(2023, 8, 21),
                "Action-Adventure",
                "Naughty Dog",
                false,
                "Experience a gripping story of survival and revenge in a post-apocalyptic world."
            ));

            allPSDummyData.Add(new PS_Game(
                2,
                "Ghost of Tsushima",
                50,
                true,
                "New",
                new DateTime(2023, 9, 5),
                new DateTime(2023, 9, 25),
                "Action-Adventure",
                "Sucker Punch Productions",
                false,
                "Embark on an epic journey as a samurai warrior fighting to save feudal Japan."
            ));

            allPSDummyData.Add(new PS_Game(
                3,
                "Spider-Man: Miles Morales",
                40,
                true,
                "New",
                new DateTime(2023, 10, 10),
                new DateTime(2023, 10, 30),
                "Action-Adventure",
                "Insomniac Games",
                false,
                "Swing through the streets of New York as Miles Morales and protect the city from evil."
            ));

            allPSDummyData.Add(new PS_Game(
                4,
                "God of War",
                45,
                true,
                "Used",
                new DateTime(2023, 11, 15),
                new DateTime(2023, 12, 5),
                "Action-Adventure",
                "Santa Monica Studio",
                false,
                "Join Kratos on a journey through Norse mythology to fulfill his destiny."
            ));

            allPSDummyData.Add(new PS_Game(
                5,
                "Horizon Zero Dawn",
                35,
                true,
                "New",
                new DateTime(2024, 1, 20),
                new DateTime(2024, 2, 9),
                "Action-RPG",
                "Guerrilla Games",
                false,
                "Explore a lush open world inhabited by robotic creatures in this action-packed RPG."
            ));

            allPSDummyData.Add(new PS_Game(
                6,
                "Bloodborne",
                55,
                false,
                "Used",
                new DateTime(2024, 2, 25),
                new DateTime(2024, 3, 16),
                "Action-RPG",
                "FromSoftware",
                false,
                "Face your fears and uncover the truth in this hauntingly beautiful horror masterpiece."
            ));

            allPSDummyData.Add(new PS_Game(
                7,
                "Demons Souls",
                65,
                true,
                "New",
                new DateTime(2024, 3, 30),
                new DateTime(2024, 4, 19),
                "Action-RPG",
                "Bluepoint Games",
                false,
                "Enter the kingdom of Boletaria and confront the demons that plague the land."
            ));

            allPSDummyData.Add(new PS_Game(
                8,
                "Uncharted 4: A Thiefs End",
                30,
                true,
                "Refurbished",
                new DateTime(2024, 5, 24),
                new DateTime(2024, 6, 13),
                "Action-Adventure",
                "Naughty Dog",
                true,
                "Join Nathan Drake on his final adventure to uncover hidden treasures and secrets."
            ));

            allPSDummyData.Add(new PS_Game(
                9,
                "Ratchet & Clank: Rift Apart",
                55,
                true,
                "New",
                new DateTime(2024, 7, 5),
                new DateTime(2024, 7, 25),
                "Action-Adventure",
                "Insomniac Games",
                false,
                "Embark on a dimension-hopping adventure with Ratchet and Clank to save the multiverse."
            ));

            allPSDummyData.Add(new PS_Game(
                10,
                "Final Fantasy VII Remake",
                50,
                true,
                "Used",
                new DateTime(2024, 8, 9),
                new DateTime(2024, 8, 29),
                "RPG",
                "Square Enix",
                false,
                "Relive the epic tale of Cloud Strife and his allies in this stunning remake of a classic RPG."
            ));

            allPSDummyData.Add(new PS_Game(
                11,
                "The Witcher 3: Wild Hunt",
                70,
                true,
                "New",
                new DateTime(2023, 6, 10),
                new DateTime(2023, 6, 30),
                "Action-RPG",
                "CD Projekt Red",
                false,
                "Embark on a journey through a dark fantasy world in this action-packed RPG."
            ));

            allPSDummyData.Add(new PS_Game(
                12,
                "Grand Theft Auto V",
                40,
                true,
                "Used",
                new DateTime(2023, 7, 15),
                new DateTime(2023, 8, 4),
                "Action-Adventure",
                "Rockstar Games",
                false,
                "Explore a sprawling open world filled with crime, mayhem, and opportunity."
            ));

            allPSDummyData.Add(new PS_Game(
                13,
                "Red Dead Redemption 2",
                50,
                true,
                "New",
                new DateTime(2023, 8, 20),
                new DateTime(2023, 9, 9),
                "Action-Adventure",
                "Rockstar Games",
                false,
                "Experience the Wild West like never before in this epic tale of outlaws and redemption."
            ));

            allPSDummyData.Add(new PS_Game(
                14,
                "Dark Souls III",
                30,
                false,
                "Used",
                new DateTime(2023, 9, 25),
                new DateTime(2023, 10, 15),
                "Action-RPG",
                "FromSoftware",
                false,
                "Prepare to die in this challenging action RPG filled with menacing foes and unforgiving difficulty."
            ));

            allPSDummyData.Add(new PS_Game(
                15,
                "Mass Effect 2",
                20,
                true,
                "Refurbished",
                new DateTime(2023, 10, 30),
                new DateTime(2023, 11, 19),
                "Action-RPG",
                "BioWare",
                true,
                "Command your own starship and save the galaxy in this acclaimed sci-fi RPG."
            ));

            allPSDummyData.Add(new PS_Game(
                16,
                "Divinity: Original Sin 2",
                60,
                true,
                "New",
                new DateTime(2023, 11, 25),
                new DateTime(2023, 12, 15),
                "RPG",
                "Larian Studios",
                false,
                "Gather your party and embark on an epic quest in this critically acclaimed RPG adventure."
            ));

            allPSDummyData.Add(new PS_Game(
                17,
                "Persona 5",
                35,
                true,
                "Used",
                new DateTime(2023, 12, 30),
                new DateTime(2024, 1, 19),
                "RPG",
                "Atlus",
                false,
                "Unravel the mysteries of the heart in this captivating RPG about high school life and supernatural powers."
            ));

            allPSDummyData.Add(new PS_Game(
                18,
                "DOOM Eternal",
                25,
                false,
                "Refurbished",
                new DateTime(2024, 1, 24),
                new DateTime(2024, 2, 13),
                "Action",
                "id Software",
                true,
                "Rip and tear through hordes of demons in this adrenaline-fueled first-person shooter."
            ));

            allPSDummyData.Add(new PS_Game(
                19,
                "Metal Gear Solid V: The Phantom Pain",
                45,
                true,
                "New",
                new DateTime(2024, 2, 28),
                new DateTime(2024, 3, 19),
                "Action-Adventure",
                "Konami",
                false,
                "Infiltrate enemy territory and complete missions as a legendary soldier in this gripping stealth action game."
            ));

            allPSDummyData.Add(new PS_Game(
                20,
                "Bloodborne",
                55,
                true,
                "Used",
                new DateTime(2024, 3, 25),
                new DateTime(2024, 4, 14),
                "Action-RPG",
                "FromSoftware",
                false,
                "Face your fears and uncover the truth in this hauntingly beautiful horror masterpiece."
            ));

            return allPSDummyData;


        }

        public List<XBOX_Game> GenereteXBOXDummyGames()
        {
            List<XBOX_Game> allXBOXDummyData = new List<XBOX_Game>();
            allXBOXDummyData.Add(new XBOX_Game(
                1,
                "The Last of Us Part II",
                60,
                true,
                "New",
                new DateTime(2023, 8, 1),
                new DateTime(2023, 8, 21),
                "Action-Adventure",
                "Naughty Dog",
                false,
                "Experience a gripping story of survival and revenge in a post-apocalyptic world."
            ));


            allXBOXDummyData.Add(new XBOX_Game(
                1,
                "Halo Infinite",
                60,
                true,
                "New",
                new DateTime(2023, 5, 1),
                new DateTime(2023, 5, 21),
                "First-Person Shooter",
                "343 Industries",
                false,
                "Embark on a legendary adventure as Master Chief in the next chapter of the iconic Halo series."
            ));

            allXBOXDummyData.Add(new XBOX_Game(
                2,
                "Forza Horizon 5",
                50,
                true,
                "New",
                new DateTime(2023, 6, 5),
                new DateTime(2023, 6, 25),
                "Racing",
                "Playground Games",
                false,
                "Experience the thrill of the open road in the stunning landscapes of Mexico in this ultimate racing playground."
            ));

            allXBOXDummyData.Add(new XBOX_Game(
                3,
                "Fable IV",
                40,
                true,
                "New",
                new DateTime(2023, 7, 10),
                new DateTime(2023, 7, 30),
                "Action-RPG",
                "Playground Games",
                false,
                "Return to the magical world of Albion and shape your own destiny in this highly anticipated RPG adventure."
            ));

            allXBOXDummyData.Add(new XBOX_Game(
                4,
                "Gears of War 6",
                45,
                true,
                "Used",
                new DateTime(2023, 8, 15),
                new DateTime(2023, 9, 4),
                "Third-Person Shooter",
                "The Coalition",
                false,
                "Join the fight against the Swarm as JD Fenix and his allies in this intense and action-packed sequel."
            ));

            allXBOXDummyData.Add(new XBOX_Game(
                5,
                "Fable Anniversary",
                35,
                true,
                "New",
                new DateTime(2023, 10, 20),
                new DateTime(2023, 11, 9),
                "Action-RPG",
                "Lionhead Studios",
                false,
                "Relive the classic tale of heroes and villains in this remastered edition of the original Fable game."
            ));

            allXBOXDummyData.Add(new XBOX_Game(
                6,
                "Halo: The Master Chief Collection",
                55,
                false,
                "Used",
                new DateTime(2023, 12, 25),
                new DateTime(2024, 1, 14),
                "First-Person Shooter",
                "343 Industries",
                false,
                "Experience the entire Master Chief saga in one epic collection, remastered for Xbox Series X|S."
            ));

            allXBOXDummyData.Add(new XBOX_Game(
                7,
                "Forza Motorsport 8",
                65,
                true,
                "New",
                new DateTime(2024, 2, 28),
                new DateTime(2024, 3, 19),
                "Racing",
                "Turn 10 Studios",
                false,
                "Get behind the wheel of the most powerful cars on the planet and race to victory in this stunning simulation."
            ));

            allXBOXDummyData.Add(new XBOX_Game(
                8,
                "Fable II",
                30,
                true,
                "Refurbished",
                new DateTime(2024, 4, 24),
                new DateTime(2024, 5, 13),
                "Action-RPG",
                "Lionhead Studios",
                true,
                "Journey back to Albion and experience the magic of Fable in this classic RPG adventure."
            ));

            allXBOXDummyData.Add(new XBOX_Game(
                9,
                "Gears Tactics",
                55,
                true,
                "New",
                new DateTime(2024, 6, 5),
                new DateTime(2024, 6, 25),
                "Turn-Based Strategy",
                "Splash Damage",
                false,
                "Lead your squad to victory against the Locust Horde in this intense and strategic Gears of War spin-off."
            ));

            allXBOXDummyData.Add(new XBOX_Game(
                10,
                "Halo Wars 2",
                50,
                true,
                "Used",
                new DateTime(2024, 7, 9),
                new DateTime(2024, 7, 29),
                "Real-Time Strategy",
                "Creative Assembly",
                false,
                "Command armies of Spartans and warthogs in epic battles against the Banished in this thrilling RTS game."
            ));

            allXBOXDummyData.Add(new XBOX_Game(
                11,
                "Gears 5",
                40,
                true,
                "New",
                new DateTime(2024, 8, 20),
                new DateTime(2024, 9, 9),
                "Third-Person Shooter",
                "The Coalition",
                false,
                "Join Kait Diaz on her journey to uncover the truth about her familys past and save humanity from the Swarm threat."
            ));

            allXBOXDummyData.Add(new XBOX_Game(
                12,
                "Forza Horizon 4",
                50,
                true,
                "New",
                new DateTime(2024, 9, 15),
                new DateTime(2024, 10, 5),
                "Racing",
                "Playground Games",
                false,
                "Race, explore, and dominate the ever-changing landscapes of Britain in this ultimate open-world racing adventure."
            ));

            allXBOXDummyData.Add(new XBOX_Game(
                13,
                "Halo: Combat Evolved Anniversary",
                30,
                false,
                "Used",
                new DateTime(2024, 10, 10),
                new DateTime(2024, 10, 30),
                "First-Person Shooter",
                "343 Industries",
                false,
                "Relive the legendary adventure that started it all, now remastered for Xbox One with updated graphics and features."
            ));

            allXBOXDummyData.Add(new XBOX_Game(
                14,
                "Sea of Thieves",
                35,
                true,
                "New",
                new DateTime(2024, 11, 5),
                new DateTime(2024, 11, 25),
                "Action-Adventure",
                "Rare",
                false,
                "Set sail on the open seas and live the pirate life in this multiplayer adventure game filled with treasure and danger."
            ));

            allXBOXDummyData.Add(new XBOX_Game(
                15,
                "Fable III",
                25,
                false,
                "Refurbished",
                new DateTime(2024, 12, 1),
                new DateTime(2024, 12, 21),
                "Action-RPG",
                "Lionhead Studios",
                true,
                "Lead a revolution to overthrow the tyrannical ruler of Albion and shape the kingdoms destiny in this epic RPG."
            ));

            allXBOXDummyData.Add(new XBOX_Game(
                16,
                "Ori and the Will of the Wisps",
                60,
                true,
                "New",
                new DateTime(2025, 1, 1),
                new DateTime(2025, 1, 21),
                "Platformer",
                "Moon Studios",
                false,
                "Embark on a beautiful and emotional journey as Ori, a guardian spirit, in this stunning platform adventure."
            ));

            allXBOXDummyData.Add(new XBOX_Game(
                17,
                "Gears of War: Ultimate Edition",
                35,
                true,
                "New",
                new DateTime(2025, 2, 5),
                new DateTime(2025, 2, 25),
                "Third-Person Shooter",
                "The Coalition",
                false,
                "Experience the original Gears of War game remastered for Xbox One with improved graphics and gameplay."
            ));

            allXBOXDummyData.Add(new XBOX_Game(
                18,
                "State of Decay 2",
                20,
                true,
                "Used",
                new DateTime(2025, 3, 10),
                new DateTime(2025, 3, 30),
                "Action",
                "Undead Labs",
                false,
                "Build and manage your own community of survivors in a post-apocalyptic world overrun by zombies in this survival game."
            ));

            allXBOXDummyData.Add(new XBOX_Game(
                19,
                "Gears Tactics",
                55,
                true,
                "New",
                new DateTime(2025, 4, 5),
                new DateTime(2025, 4, 25),
                "Turn-Based Strategy",
                "Splash Damage",
                false,
                "Lead your squad to victory against the Locust Horde in this intense and strategic Gears of War spin-off."
            ));

            allXBOXDummyData.Add(new XBOX_Game(
                20,
                "Fable Heroes",
                15,
                true,
                "Refurbished",
                new DateTime(2025, 5, 1),
                new DateTime(2025, 5, 21),
                "Action",
                "Lionhead Studios",
                true,
                "Embark on a whimsical adventure with friends in this charming hack-and-slash game set in the Fable universe."
            ));

            return allXBOXDummyData;
        }
        



















































        //    public List<User> GenerateDummyUsers()
        //{
        //    List<User> allDummyUsers = new List<User>();

        //    allDummyUsers.Add(new User
        //    {
        //        name = "John Doe",
        //        userID = 1,
        //        phoneNumber = "123-456-7890",
        //        email = "john.doe@example.com",
        //        Location = "New York, NY",
        //        yearCreated = new DateTime(2020, 1, 1),
        //        itemsSold = 10,
        //        favorites = new List<string> { "Books", "Movies" },
        //        ItemsViewed = 50
        //    });

        //    allDummyUsers.Add(new User
        //    {
        //        name = "Jane Smith",
        //        userID = 2,
        //        phoneNumber = "098-765-4321",
        //        email = "jane.smith@example.com",
        //        Location = "Los Angeles, CA",
        //        yearCreated = new DateTime(2019, 6, 15),
        //        itemsSold = 15,
        //        favorites = new List<string> { "Music", "Art" },
        //        ItemsViewed = 75
        //    });

        //    allDummyUsers.Add(new User
        //    {
        //        name = "Alice Johnson",
        //        userID = 3,
        //        phoneNumber = "111-222-3333",
        //        email = "alice.johnson@example.com",
        //        Location = "Chicago, IL",
        //        yearCreated = new DateTime(2021, 3, 10),
        //        itemsSold = 5,
        //        favorites = new List<string> { "Fashion", "Cooking" },
        //        ItemsViewed = 30
        //    });

        //    allDummyUsers.Add(new User
        //    {
        //        name = "Michael Brown",
        //        userID = 4,
        //        phoneNumber = "444-555-6666",
        //        email = "michael.brown@example.com",
        //        Location = "Houston, TX",
        //        yearCreated = new DateTime(2020, 9, 20),
        //        itemsSold = 20,
        //        favorites = new List<string> { "Electronics", "Sports" },
        //        ItemsViewed = 100
        //    });

        //    allDummyUsers.Add(new User
        //    {
        //        name = "Emily Davis",
        //        userID = 5,
        //        phoneNumber = "777-888-9999",
        //        email = "emily.davis@example.com",
        //        Location = "Miami, FL",
        //        yearCreated = new DateTime(2018, 5, 8),
        //        itemsSold = 25,
        //        favorites = new List<string> { "Home Decor", "Travel" },
        //        ItemsViewed = 120
        //    });

        //    allDummyUsers.Add(new User
        //    {
        //        name = "William Wilson",
        //        userID = 6,
        //        phoneNumber = "123-456-7890",
        //        email = "william.wilson@example.com",
        //        Location = "Seattle, WA",
        //        yearCreated = new DateTime(2017, 12, 25),
        //        itemsSold = 12,
        //        favorites = new List<string> { "Gardening", "Photography" },
        //        ItemsViewed = 60
        //    });

        //    allDummyUsers.Add(new User
        //    {
        //        name = "Olivia Martinez",
        //        userID = 7,
        //        phoneNumber = "321-654-9876",
        //        email = "olivia.martinez@example.com",
        //        Location = "Dallas, TX",
        //        yearCreated = new DateTime(2019, 8, 14),
        //        itemsSold = 18,
        //        favorites = new List<string> { "Health & Fitness", "Beauty" },
        //        ItemsViewed = 90
        //    });

        //    allDummyUsers.Add(new User
        //    {
        //        name = "James Taylor",
        //        userID = 8,
        //        phoneNumber = "555-555-5555",
        //        email = "james.taylor@example.com",
        //        Location = "Atlanta, GA",
        //        yearCreated = new DateTime(2022, 2, 28),
        //        itemsSold = 8,
        //        favorites = new List<string> { "Tech Gadgets", "Gaming" },
        //        ItemsViewed = 40
        //    });

        //    allDummyUsers.Add(new User
        //    {
        //        name = "Sophia Brown",
        //        userID = 9,
        //        phoneNumber = "444-444-4444",
        //        email = "sophia.brown@example.com",
        //        Location = "San Francisco, CA",
        //        yearCreated = new DateTime(2021, 11, 11),
        //        itemsSold = 30,
        //        favorites = new List<string> { "Fashion", "Books" },
        //        ItemsViewed = 150
        //    });

        //    allDummyUsers.Add(new User
        //    {
        //        name = "Liam Miller",
        //        userID = 10,
        //        phoneNumber = "666-666-6666",
        //        email = "liam.miller@example.com",
        //        Location = "Boston, MA",
        //        yearCreated = new DateTime(2020, 4, 30),
        //        itemsSold = 22,
        //        favorites = new List<string> { "Music", "Art" },
        //        ItemsViewed = 110
        //    });

        //    allDummyUsers.Add(new User
        //    {
        //        name = "Ava Garcia",
        //        userID = 11,
        //        phoneNumber = "777-777-7777",
        //        email = "ava.garcia@example.com",
        //        Location = "Denver, CO",
        //        yearCreated = new DateTime(2019, 10, 5),
        //        itemsSold = 16,
        //        favorites = new List<string> { "Outdoor Gear", "Pets" },
        //        ItemsViewed = 80
        //    });

        //    allDummyUsers.Add(new User
        //    {
        //        name = "Noah Rodriguez",
        //        userID = 12,
        //        phoneNumber = "999-999-9999",
        //        email = "noah.rodriguez@example.com",
        //        Location = "Phoenix, AZ",
        //        yearCreated = new DateTime(2022, 6, 18),
        //        itemsSold = 14,
        //        favorites = new List<string> { "Cooking", "Travel" },
        //        ItemsViewed = 70
        //    });

        //    allDummyUsers.Add(new User
        //    {
        //        name = "Isabella Hernandez",
        //        userID = 13,
        //        phoneNumber = "888-888-8888",
        //        email = "isabella.hernandez@example.com",
        //        Location = "Philadelphia, PA",
        //        yearCreated = new DateTime(2018, 8, 22),
        //        itemsSold = 19,
        //        favorites = new List<string> { "Home Decor", "Crafts" },
        //        ItemsViewed = 95
        //    });

        //    allDummyUsers.Add(new User
        //    {
        //        name = "Ethan Lopez",
        //        userID = 14,
        //        phoneNumber = "101-202-3030",
        //        email = "ethan.lopez@example.com",
        //        Location = "San Diego, CA",
        //        yearCreated = new DateTime(2020, 3, 15),
        //        itemsSold = 28,
        //        favorites = new List<string> { "Tech Gadgets", "Gaming" },
        //        ItemsViewed = 140
        //    });

        //    allDummyUsers.Add(new User
        //    {
        //        name = "Mia Gonzalez",
        //        userID = 15,
        //        phoneNumber = "505-606-7070",
        //        email = "mia.gonzalez@example.com",
        //        Location = "Portland, OR",
        //        yearCreated = new DateTime(2019, 5, 28),
        //        itemsSold = 11,
        //        favorites = new List<string> { "Fashion", "Beauty" },
        //        ItemsViewed = 55
        //    });

        //    allDummyUsers.Add(new User
        //    {
        //        name = "Lucas Perez",
        //        userID = 16,
        //        phoneNumber = "303-404-5050",
        //        email = "lucas.perez@example.com",
        //        Location = "Austin, TX",
        //        yearCreated = new DateTime(2021, 1, 8),
        //        itemsSold = 17,
        //        favorites = new List<string> { "Sports", "Outdoor Gear" },
        //        ItemsViewed = 85
        //    });

        //    allDummyUsers.Add(new User
        //    {
        //        name = "Amelia Flores",
        //        userID = 17,
        //        phoneNumber = "202-303-4040",
        //        email = "amelia.flores@example.com",
        //        Location = "Charlotte, NC",
        //        yearCreated = new DateTime(2020, 7, 17),
        //        itemsSold = 23,
        //        favorites = new List<string> { "Books", "Music" },
        //        ItemsViewed = 115
        //    });

        //    allDummyUsers.Add(new User
        //    {
        //        name = "Oliver Washington",
        //        userID = 18,
        //        phoneNumber = "707-808-9090",
        //        email = "oliver.washington@example.com",
        //        Location = "Detroit, MI",
        //        yearCreated = new DateTime(2019, 9, 3),
        //        itemsSold = 13,
        //        favorites = new List<string> { "Art", "Crafts" },
        //        ItemsViewed = 65
        //    });

        //    allDummyUsers.Add(new User
        //    {
        //        name = "Charlotte Nguyen",
        //        userID = 19,
        //        phoneNumber = "606-707-8080",
        //        email = "charlotte.nguyen@example.com",
        //        Location = "Nashville, TN",
        //        yearCreated = new DateTime(2022, 4, 22),
        //        itemsSold = 21,
        //        favorites = new List<string> { "Music", "Movies" },
        //        ItemsViewed = 105
        //    });

        //    allDummyUsers.Add(new User
        //    {
        //        name = "Benjamin Kim",
        //        userID = 20,
        //        phoneNumber = "404-505-6060",
        //        email = "benjamin.kim@example.com",
        //        Location = "Minneapolis, MN",
        //        yearCreated = new DateTime(2018, 10, 12),
        //        itemsSold = 26,
        //        favorites = new List<string> { "Electronics", "Tech Gadgets" },
        //        ItemsViewed = 130
        //    });

        //    // Add more users as needed

        //    return allDummyUsers;
        //}
    }
}
