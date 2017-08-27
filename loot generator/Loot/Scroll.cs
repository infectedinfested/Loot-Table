using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loot_Table.Loot
{
    class Scroll
    {
        public string name { get; set; }
        public string rarity { get; set; }
        public string type { get; set; }
        public string effect { get; set; }
        public Scroll(IList<object> row)
        { 
            name = (string)row[0];
            switch ((string)row[1])
            {
                case "C":
                    this.rarity = "Common";
                    break;
                case "U":
                    this.rarity = "Uncommon";
                    break;
                case "R":
                    this.rarity = "Rare";
                    break;
                case "V":
                    this.rarity = "Very Rare";
                    break;
                case "L":
                    this.rarity = "Legendary";
                    break;
                default:
                    break;
            }
            this.type = (string)row[2];
            this.effect = (string)row[3];
        }

        public override string ToString()
        {
            return name;
        }

    }
}
