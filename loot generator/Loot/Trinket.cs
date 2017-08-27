using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loot_Table.Loot
{
    class Trinket:Treasure
    {
       
        //public int mod;
        //public string effect1;
        //public string recharge1;
        //public string effect2;
        //public string recharge2;
        //public string effect3;
        //public string recharge3;
        private void Trinket1(string naam, string rare, string type, string subtype, int mod)
        {
            if (mod > 0)
            {
                modview = "+" + mod;
            }
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
            this.subtype = subtype;
            this.mod = mod;
        }
        private void Trinket2(string naam, string rare, string type, string subtype, int mod, object effect1, object recharge1)
        {
            if (mod > 0)
            {
                modview = "+" + mod;
            }
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
            this.subtype = subtype;
            this.mod = mod;
            this.effect1 = (String)effect1;
            this.recharge1 = (String)recharge1;
        }
        private void Trinket3(string naam, string rare, string type, string subtype, int mod, object effect1, object recharge1, object effect2, object recharge2)
        {
            if (mod > 0)
            {
                modview = "+" + mod;
            }
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
            this.subtype = subtype;
            this.mod = mod;
            this.effect1 = (String)effect1;
            this.effect2 = (String)effect2;
            this.recharge1 = (String)recharge1;
            this.recharge2 = (String)recharge2;
        }
        private void Trinket4(string naam, string rare, string type, string subtype, int mod, object effect1, object recharge1, object effect2, object recharge2, object effect3, object recharge3)
        {
            if (mod > 0)
            {
                modview = "+" + mod;
            }
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
            this.subtype = subtype;
            this.mod = mod;
            this.effect1 = (String)effect1;
            this.effect2 = (String)effect2;
            this.effect3 = (String)effect3;
            this.recharge1 = (String)recharge1;
            this.recharge2 = (String)recharge2;
            this.recharge3 = (String)recharge3;
        }

        public override string ToString()
        {
            return name;
        }

        public Trinket(IList<object> row)
        {
            try
            {
                Convert.ToInt32(row[4]);

            }
            catch (Exception)
            {
                row.Add(0);
            }
            switch (row.Count)
            {
                case 5:
                    Trinket1((string)row[0], (string)row[1], (string)row[2], (string)row[3], Convert.ToInt32(row[4]));
                    break;
                case 7:
                    Trinket2((string)row[0], (string)row[1], (string)row[2], (string)row[3], Convert.ToInt32(row[4]), row[5], row[6]);
                    break;
                case 9:
                    Trinket3((string)row[0], (string)row[1], (string)row[2], (string)row[3], Convert.ToInt32(row[4]), row[5], row[6], row[7], row[8]);
                    break;
                case 11:
                    Trinket4((string)row[0], (string)row[1], (string)row[2], (string)row[3], Convert.ToInt32(row[4]), row[5], row[6], row[7], row[8], row[9], row[10]);
                    break;
                default:
                    break;
            }
            this.discription = MakeDiscription();
        }

        public override string MakeDiscription()
        {
            string text = "";
            switch (mod)
            {
                case 0:
                    text = text + "This is a trinket";
                    break;
                case 1:
                    text = text + "This is a fine trinket";
                    break;
                case 2:
                    text = text + "This is a quality trinket";
                    break;
                case 3:
                    text = text + "This masterwork trinket";
                    break;
                default:
                    break;
            }

            if (effect1 != null)
            {

                text = text + " and it appears to be magical in origin." + Environment.NewLine
                + "   -" + effect1 + Environment.NewLine;

                if (!(recharge1.Equals("P") || recharge1.Equals("N")))
                {
                    string[] aStrings = recharge1.Split('/');
                    if (aStrings.Length == 2)
                    {
                        text = text + "   -This effect can be used " + aStrings[0] + "times each ";
                        switch (aStrings[1])
                        {
                            case "SR":
                                text = text + "short rest";
                                break;
                            case "R":
                                text = text + "long rest";
                                break;
                            case "D":
                                text = text + "day";
                                break;
                            default:
                                break;
                        }

                    }
                    else
                    {
                        text = text + "   -This effect has " + aStrings[0];
                        Console.WriteLine(text);
                        text = text + " charges, and it recharges " + aStrings[1] + " each ";
                        Console.WriteLine(text);
                        switch (aStrings[2])
                        {
                            case "SR":
                                text = text + "short rest";
                                break;
                            case "R":
                                text = text + "long rest";
                                break;
                            case "D":
                                text = text + "day";
                                break;
                            default:
                                break;
                        }
                    }
                }

                if (effect2 != null)
                {
                    text = text + "   -" + effect2 + Environment.NewLine;
                    if (!(recharge2.Equals("P") || recharge2.Equals("N")))
                    {
                        string[] aStrings = recharge2.Split('/');
                        if (aStrings.Length == 2)
                        {
                            text = text + "   -This effect can be used " + aStrings[0] + "times each ";
                            switch (aStrings[1])
                            {
                                case "SR":
                                    text = text + "short rest";
                                    break;
                                case "R":
                                    text = text + "long rest";
                                    break;
                                case "D":
                                    text = text + "day";
                                    break;
                                default:
                                    break;
                            }

                        }
                        else
                        {
                            text = text + "   -This effect has " + aStrings[0];
                            Console.WriteLine(text);
                            text = text + " charges, and it recharges " + aStrings[1] + " each ";
                            Console.WriteLine(text);
                            switch (aStrings[2])
                            {
                                case "SR":
                                    text = text + "short rest";
                                    break;
                                case "R":
                                    text = text + "long rest";
                                    break;
                                case "D":
                                    text = text + "day";
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                }



                if (effect3 != null)
                {
                    text = text + "   -" + effect3 + Environment.NewLine;
                    if (!(recharge3.Equals("P") || recharge3.Equals("N")))
                    {
                        string[] aStrings = recharge3.Split('/');
                        if (aStrings.Length == 2)
                        {
                            text = text + "   -This effect can be used " + aStrings[0] + "times each ";
                            switch (aStrings[1])
                            {
                                case "SR":
                                    text = text + "short rest";
                                    break;
                                case "R":
                                    text = text + "long rest";
                                    break;
                                case "D":
                                    text = text + "day";
                                    break;
                                default:
                                    break;
                            }

                        }
                        else
                        {
                            text = text + "   -This effect has " + aStrings[0];
                            Console.WriteLine(text);
                            text = text + " charges, and it recharges " + aStrings[1] + " each ";
                            Console.WriteLine(text);
                            switch (aStrings[2])
                            {
                                case "SR":
                                    text = text + "short rest";
                                    break;
                                case "R":
                                    text = text + "long rest";
                                    break;
                                case "D":
                                    text = text + "day";
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                }


            }


            return text;
        }
    }
}
