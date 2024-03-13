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





}