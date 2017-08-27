using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loot_Table.Loot
{
    class Weapon:Treasure
    {
        //private int mod;
        //private string effect1;
        //private string recharge1;
        //private string effect2;
        //private string recharge2;
        //private string effect3;
        //private string recharge3;

        private void Weapon1(string naam, string rare, string type, string subtype, int mod)
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
            this.subtype = subtype;
            this.mod = mod;
            if (mod > 0 )
            {
                modview = "+" + mod;
            }
            
        }
        private void Weapon2(string naam, string rare, string type, string subtype, int mod, object effect1, object recharge1)
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
            this.subtype = subtype;
            this.mod = mod;
            if (mod > 0)
            {
                modview = "+" + mod;
            }
            this.effect1 = (String)effect1;
            this.recharge1 = (String)recharge1;
        }
        private void Weapon3(string naam, string rare, string type, string subtype, int mod, object effect1, object recharge1, object effect2, object recharge2)
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
            this.subtype = subtype;
            this.mod = mod;
            if (mod > 0)
            {
                modview = "+" + mod;
            }
            this.effect1 = (String)effect1;
            this.effect2 = (String)effect2;
            this.recharge1 = (String)recharge1;
            this.recharge2 = (String)recharge2;
        }
        private void Weapon4(string naam, string rare, string type, string subtype, int mod, object effect1, object recharge1, object effect2, object recharge2, object effect3, object recharge3)
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
            this.subtype = subtype;
            this.mod = mod;
            if (mod > 0)
            {
                modview = "+" + mod;
            }
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

        public override string MakeDiscription()
        {
            string text = "";
            switch (mod)
            {
                case 0: text = text+ "This is a weapon";
                    break;
                case 1:
                    text = text + "This is a fine weapon";
                    break;
                case 2:
                    text = text + "This is a quality weapon";
                    break;
                case 3:
                    text = text + "This masterwork weapon";
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

        public Weapon(IList<object> row)
        {
            try
            {
                Convert.ToInt32(row[4]);
            }
            catch (Exception)
            {
                try
                {
                    row[4] = 0;
                }
                catch (Exception)
                {
                    row.Add(0);
                }
            }
            
            switch (row.Count)
            {
                case 5: Weapon1((string)row[0],(string) row[1],(string) row[2],(string) row[3], Convert.ToInt32(row[4]));
                    break;
                case 7:
                    Weapon2((string)row[0], (string)row[1], (string)row[2], (string)row[3], Convert.ToInt32(row[4]), row[5],row[6]);
                    break;
                case 9:
                    Weapon3((string)row[0], (string)row[1], (string)row[2], (string)row[3], Convert.ToInt32(row[4]), row[5], row[6], row[7], row[8]);
                    break;
                case 11:
                    Weapon4((string)row[0], (string)row[1], (string)row[2], (string)row[3], Convert.ToInt32(row[4]), row[5], row[6], row[7], row[8], row[9], row[10]);
                    break;
                default:
                    break;
            }
            this.discription = MakeDiscription();
            
        }
    }
}
