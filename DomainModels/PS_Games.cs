using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain_Models
{
    public class PS_Game : Item
    {
        public int yearDeployed { get; set; }
        public List<string> pictures { get; set; }
        public string psModel { get; set; }
    }

    PS_Game psGame1 = new PS_Game
    {
        itemID = 102,
        gameName = "Game 2",
        price = 499,
        orderStatus = false,
        condition = "Used",
        created = new DateTime(2021, 2, 1),
        updated = new DateTime(2021, 2, 1),
        genre = "Adventure",
        manufacture = "GameCo",
        addToFaverite = true,
        yearDeployed = 2020,
        pictures = new List<string> { "picture3.jpg", "picture4.jpg" },
        psModel = "PS5"
    };




}