using Domain_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain_Models
{
    public class User
    {
        public string name { get; set; }
        public int userID { get; set; }
        private string phoneNumber { get; set; }
        private string email { get; set; }
        private string Location { get; set; }
        public DateTime yearCreated { get; set; }
        public int itemsSold { get; set; }
        private List<string> favorites { get; set; }
        private int ItemsViewed { get; set; }

        bool LoginAction()
        { return true; }
        bool LogoutAction()
        { return false; }
        void CreateAccount() { }
    }




<<<<<<< Updated upstream
=======
   /* User user1 = new User
    {
        name = "John Doe",
        userID = 1,
        yearCreated = new DateTime(2020, 1, 1),
        itemsSold = 5
    };*/
>>>>>>> Stashed changes


}





