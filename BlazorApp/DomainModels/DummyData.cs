using Domain_Models;

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
                addToFaverite = false
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
            });



            return allDummyData;
        }
    }
}
