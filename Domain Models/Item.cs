using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain_Models
{
    public abstract class Item : User
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

        private User userID;

        public Item(User userID)
        {
            this.userID = userID;
        }


		void SetItem() { }
        void AddItem() { }
        void RemoveItem() { }
        void ItemStatus() { }
        void GetItem() { } 
    }
}