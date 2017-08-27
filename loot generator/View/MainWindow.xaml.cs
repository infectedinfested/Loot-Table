using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            FrameWithinGrid.Content = new home();
        }
        private void Cash_Click(object sender, RoutedEventArgs e)
        {
            FrameWithinGrid.Content = new CashGen();
        }
        private void Loot_Click(object sender, RoutedEventArgs e)
        {
            FrameWithinGrid.Content = new Lootgen();
        }
        private void Potion_Click(object sender, RoutedEventArgs e)
        {
            FrameWithinGrid.Content = new Potiongen();
        }

            private void Scroll_Click(object sender, RoutedEventArgs e)
        {
            FrameWithinGrid.Content = new Scrollgen();
        }
    }
}
