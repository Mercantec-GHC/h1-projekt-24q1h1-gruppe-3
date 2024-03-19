using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainModels
{
    public class XBOX_Game : Item
    {
        public string xboxModel { get; set; }
        public DateTime yearDeployed { get; set; }

        public XBOX_Game(int itemID, string gameName, int price, bool orderStatus, string condition, DateTime created, DateTime updated, string genre, string manufacture, bool addToFaverite, string description, string xboxModel, DateTime yearDeployed)
        {
            // Initialiser felterne her
            this.itemID = itemID;
            this.gameName = gameName;
            this.price = price;
            this.orderStatus = orderStatus;
            this.condition = condition;
            this.created = created;
            this.updated = updated;
            this.genre = genre;
            this.manufacture = manufacture;
            this.addToFaverite = addToFaverite;
            this.description = description;
            this.xboxModel = xboxModel;
            this.yearDeployed = yearDeployed;
        }
    }
}