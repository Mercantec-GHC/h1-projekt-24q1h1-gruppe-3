using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainModels
{
    public abstract class Item //: User
    {
        public int itemID { get; set; }
        public string? gameName { get; set; }
        public int price { get; set; }
        public bool orderStatus { get; set; }
        public string condition { get; set; }
        public DateTime created { get; set; }
        public DateTime updated { get; set; }
        public string genre { get; set; }
        public string manufacture { get; set; }
        public bool addToFaverite { get; set; }
        public string description { get; set; }
        //private User userID;


		void SetItem() { }
        void AddItem() { }
        void RemoveItem() { }
        void ItemStatus() { }
        void GetItem() { } 
    }
}