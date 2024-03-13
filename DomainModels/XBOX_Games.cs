using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain_Models
{
    public class XBOX_Game : Item
    {
        public int yearDeployed { get; set; }
        public List<string> pictures { get; set; }
        public string xboxModel { get; set; }
    }




}