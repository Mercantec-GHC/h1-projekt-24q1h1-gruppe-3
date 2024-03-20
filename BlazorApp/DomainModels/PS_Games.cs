﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainModels
{
    public class PS_Game// : Item
    {
        public bool addToFaverite { get; set; }
        public string condition { get; set; }
        public DateTime created { get; set; }
        public string? gameName { get; set; }
        public string genre { get; set; }
        public int itemID { get; set; }
        public string manufacture { get; set; }
        public int price { get; set; }
        public DateTime updated { get; set; }
        public bool orderStatus { get; set; }
        public string description { get; set; }

        public PS_Game(int itemID, string gameName, int price, bool orderStatus, string condition, DateTime created, DateTime updated, string genre, string manufacture, bool addToFaverite, string description)
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
        }
    }
}