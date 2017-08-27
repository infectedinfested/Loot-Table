using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Loot_Table
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class CashGen : Page
    {
        public CashGen()
        {
            InitializeComponent();
            RBlow.IsChecked = true;
        }

        private void Generate_Click(object sender, RoutedEventArgs e)
        {

            List<string> loot = new List<string>();
             
            Roller roller = new Roller();
            int belong = Convert.ToInt32(Math.Floor(Convert.ToDouble(roller.roll(1, 100) % 4)))+1;
            Console.WriteLine(belong);
            if (Convert.ToBoolean(RBlow.IsChecked))
            {
                switch (belong)
                {
                    case 1: loot.Add(roller.roll(5, 6) + " cp");
                        break;
                    case 2:
                        loot.Add(roller.roll(4, 6) + " sp");
                        break;
                    case 3:
                        loot.Add(roller.roll(3, 6) + " gp");
                        break;
                    case 4:
                        loot.Add(roller.roll(1, 6) + " pp");
                        break;
                    default:
                        loot.Add("error");
                        break;
                }
                
            }
            if (Convert.ToBoolean(RBmid.IsChecked))
            {
                switch (belong)
                {
                    case 1:
                        loot.Add((roller.roll(1, 6)) + " gp");
                        loot.Add((roller.roll(4, 6)*100) + " cp");
                        break;
                    case 2:
                        loot.Add((roller.roll(2, 6)) + " gp");
                        loot.Add((roller.roll(6, 6) * 10) + " sp");
                        break;
                    case 3:
                        loot.Add((roller.roll(4, 6) * 10) + " gp");
                        break;
                    case 4:
                        loot.Add((roller.roll(3, 6)) + " pp");
                        loot.Add((roller.roll(2, 6)) + " gp");
                        break;
                    default:
                        loot.Add("error");
                        break;
                }
            }
            if (Convert.ToBoolean(RBhigh.IsChecked))
            {
                switch (belong)
                {
                    case 1:
                        loot.Add((roller.roll(1, 6) * 100) + " gp");
                        loot.Add((roller.roll(4, 6)) *100 + " sp");
                        break;
                    case 2:
                        loot.Add((roller.roll(1, 6) * 150) + " gp");
                        break;
                    case 3:
                        loot.Add((roller.roll(1, 6) * 10) + " pp");
                        loot.Add((roller.roll(2, 6) * 100) + " gp");
                        break;
                    case 4:
                        loot.Add((roller.roll(2, 6) * 10) + " pp");
                        loot.Add((roller.roll(2, 6) * 100) + " gp");
                        break;
                    default:
                        loot.Add("error");
                        break;
                }
            }
            if (Convert.ToBoolean(RBhighest.IsChecked))
            {
                switch (belong)
                {
                    case 1:
                        loot.Add((roller.roll(8, 6)) * 100 + " gp");
                        loot.Add((roller.roll(1, 6) * 1000) + " sp");
                        break;
                    case 2:
                        loot.Add((roller.roll(1, 6) * 100) + " pp");
                        loot.Add((roller.roll(1, 6) * 1000) + " gp");
                        break;
                    case 3:
                        loot.Add((roller.roll(2, 6) * 100) + " pp");
                        loot.Add((roller.roll(1, 6) * 1000) + " gp");
                        break;
                    default:
                        loot.Add((roller.roll(1, 6) * 100) + " pp");
                        loot.Add((roller.roll(1, 6) * 1000) + " gp");
                        break;
                }
            }
            Lboxloot.ItemsSource = loot;
        }
    }
}
