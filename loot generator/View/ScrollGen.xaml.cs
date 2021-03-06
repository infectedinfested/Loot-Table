﻿using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Util.Store;
using Loot_Table.Loot;
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
    /// Interaction logic for Page2.xaml
    /// </summary>
    /// 
    public partial class Scrollgen : Page
    {
        List<Scroll> scrolls;
        HashSet<String> types;
        Scroll _selectedScroll;
        HashSet<Scroll> obtainableLoot;

        public Scrollgen()
        {
            InitializeComponent();

            GetTable();
            LviewTreasure.DataContext = scrolls;

            types = GetTypes();
            

            CboxType.ItemsSource = types;

            CboxType.SelectedIndex = 0;

            RBlow.IsChecked = true;
        }

        
        private HashSet<String> GetTypes()
        {
            HashSet<string> types = new HashSet<string>();
            types.Add("Random");
            foreach (var item in scrolls)
            {
                types.Add(item.type);
            }
            return types;
        }

        private void OnItemSelect(object sender, SelectionChangedEventArgs e)
        {

            _selectedScroll = (Scroll)ListOfItems.SelectedItem;
            ItemView.DataContext = _selectedScroll;
        }

        private void GetTable()
        {
            // If modifying these scopes, delete your previously saved credentials
            // at ~/.credentials/sheets.googleapis.com-dotnet-quickstart.json
            string[] Scopes = { SheetsService.Scope.SpreadsheetsReadonly };
            string ApplicationName = "Google Sheets API .NET Quickstart";

            UserCredential credential;

            using (var stream =
                new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = System.Environment.GetFolderPath(
                    System.Environment.SpecialFolder.Personal);
                credPath = System.IO.Path.Combine(credPath, ".credentials/sheets.googleapis.com-dotnet-quickstart.json");

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }

            // Create Google Sheets API service.
            var service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            // Define request parameters.
            String spreadsheetId = "1wkCt0YfEe7nPtCixij5zR66vZubmw7K21q7r07b1EBI";
            String range = "Scrolls!A2:F";
            SpreadsheetsResource.ValuesResource.GetRequest request =
                    service.Spreadsheets.Values.Get(spreadsheetId, range);

            // Prints the names and majors of students in a sample spreadsheet:
            // https://docs.google.com/spreadsheets/d/1wkCt0YfEe7nPtCixij5zR66vZubmw7K21q7r07b1EBI/edit


            ValueRange response = request.Execute();
            IList<IList<Object>> values = response.Values;
            scrolls = new List<Scroll>();
            if (values != null && values.Count > 0)
            {
                Console.WriteLine("Importing data");
                foreach (var row in values)
                {
                    scrolls.Add(new Scroll(row));
                }
            }
            else
            {
                Console.WriteLine("No data found.");
            }
        }

        private void Generate_Click(object sender, RoutedEventArgs e)
        {
            HashSet<Scroll> obtainableLootTemp = new HashSet<Scroll>();
            Random rnd = new Random();
            Changeobtainable();
            if (obtainableLoot.Count!=0)
            {
                rnd.Next(0, obtainableLoot.Count);
                obtainableLootTemp.Add(obtainableLoot.ToList()[rnd.Next(0, obtainableLoot.Count)]);
                LviewTreasure.DataContext = obtainableLootTemp;
            }
            else
            {
                LviewTreasure.DataContext = "No Treasure";
            }
            
            
        }

        

        private void Changeobtainable()
        {
            HashSet<Scroll> obtainableLootTemp = new HashSet<Scroll>();
            obtainableLoot = new HashSet<Scroll>();
            //1 common, uncommon
            //5 rare
            //11 very rare
            //17 legendary
            if (Convert.ToBoolean(RBlow.IsChecked))
            {
                foreach (var item in scrolls)
                {
                    if (item.rarity.Equals("Common") || item.rarity.Equals("Uncommon"))
                    {
                        obtainableLootTemp.Add(item);
                    }
                    
                }
            }
            if (Convert.ToBoolean(RBmid.IsChecked))
            {
                foreach (var item in scrolls)
                {
                    if (item.rarity.Equals("Common") || item.rarity.Equals("Uncommon") || item.rarity.Equals("Rare"))
                    {
                        obtainableLootTemp.Add(item);
                    }

                }
            }
            if (Convert.ToBoolean(RBhigh.IsChecked))
            {
                foreach (var item in scrolls)
                {
                    if (item.rarity.Equals("Common") || item.rarity.Equals("Uncommon") || item.rarity.Equals("Rare") || item.rarity.Equals("Very Rare"))
                    {
                        obtainableLootTemp.Add(item);
                    }

                }
            }
            if (Convert.ToBoolean(RBhighest.IsChecked))
            {
                foreach (var item in scrolls)
                {
                    obtainableLootTemp.Add(item);

                }
            }
            
            foreach (var item in obtainableLootTemp)
            {
                if (CboxType.SelectedItem.Equals("Random"))
                {
                    obtainableLoot.Add(item);
                }
                else
                {
                    if (CboxType.SelectedItem.Equals(item.type))
                    {
                        
                            obtainableLoot.Add(item);
                        
                        
                    }
                }
                
            }
        }

    }

}
