using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loot_Table.Loot
{
    abstract class Treasure
    {
        public string name { get; set; }
        public string rarity { get; set; }
        public string type { get; set; }
        public string subtype { get; set; }
        public int mod { get; set; }
        public string modview { get; set; }
        public string effect1 { get; set; }
        public string recharge1 { get; set; }
        public string effect2 { get; set; }
        public string recharge2 { get; set; }
        public string effect3 { get; set; }
        public string recharge3 { get; set; }
        public string discription { get; set; }
        //abstract public string ToString();
        public abstract string MakeDiscription();
    }
}
