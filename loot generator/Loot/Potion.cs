using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loot_Table.Loot
{
    class Potion
    {
        public string name { get; set; }
        public string rarity { get; set; }
        public string type { get; set; }
        public string effect { get; set; }
        private void Potion1(string naam, string rare, string type, object effect)
        {
            this.name = naam;
            switch (rare)
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
            this.type = type;
            this.effect = (string)effect;
        }
        
        public Potion(IList<object> row)
        {
            switch (row.Count)
            {
                case 4:
                    Potion1((string)row[0], (string)row[1], (string)row[2], (string)row[3]);
                    break;
                default:
                    break;
            }
        }

        public override string ToString()
        {
            return name;
        }

    }
}
