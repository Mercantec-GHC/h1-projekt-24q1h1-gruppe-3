using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainModels
{
    public class User
    {
        public string name;
        public int userID;
        private string phoneNumber;
        private string email;
        private string Location;
        public DateTime yearCreated;
        public int itemsSold;
        private List<string> favorites;
        private int ItemsViewed;

		bool LoginAction()
        { return true; }
        bool LogoutAction()
        { return false; }
        void CreateAccount() { }
    }
}