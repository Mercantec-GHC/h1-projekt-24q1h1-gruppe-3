using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain_Models
{
    public abstract class Item
    {
        private int itemID;
        public string gameName;
        public int price;
        public bool orderStatus;
        public string condition;
        public DateTime created;
        public DateTime updated;
        public string genre;
        public string manufacture;
        public bool addToFaverite;
        void SetItem() { }
        void AddItem() { }
        void RemoveItem() { }
        void ItemStatus() { }
        void GetItem() { } 
    }
}