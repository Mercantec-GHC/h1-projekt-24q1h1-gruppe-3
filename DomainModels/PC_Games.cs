using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain_Models
{
    public class PC_Game : Item
    {
        public int yearDeployed { get; set; }
        public List<string> pictures { get; set; }
        public string operatingSystem { get; set; }
    }


    PC_Game pcGame1 = new PC_Game
    {
        itemID = 101,
        gameName = "Game 1",
        price = 599,
        orderStatus = true,
        condition = "New",
        created = new DateTime(2021, 1, 1),
        updated = new DateTime(2021, 1, 1),
        genre = "Action",
        manufacture = "GameCo",
        addToFaverite = false,
        yearDeployed = 2020,
        pictures = new List<string> { "picture1.jpg", "picture2.jpg" },
        operatingSystem = "Windows 10"
    };


}