﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainModels
{
    public class User
    {
        public string name { get; set; }
        public int userID { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }
        public string Location { get; set; }
        public DateTime yearCreated { get; set; }
        public int itemsSold { get; set; }
        public List<string> favorites { get; set; }
        public int ItemsViewed { get; set; }

        bool LoginAction()
        { return true; }
        bool LogoutAction()
        { return false; }
        void CreateAccount() { }
    }
}