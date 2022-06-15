using AccumapDataProcessor.Models;
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
using System.Configuration;
using AccumapDataProcessor.Stores;
using AccumapDataProcessor.Utils;
using Microsoft.Win32;

namespace AccumapDataProcessor
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


        private async void GetWellListButton_Click(object sender, RoutedEventArgs e) {
            
            // Get the File Name
            var ofd = new OpenFileDialog();
            var filePath = ofd.ShowDialog();
            if (filePath == false) return;
            Display.Text = ofd.FileName;
            
            //Convert the locations to a string for sql list. 
            var locationList = CsvUtils.ConvertUwiFromCsvToSqlString(ofd.FileName);

            // Get the details from Accumap Synapse
            var wellList = await AccumapUtils.GetWells(locationList);
            
            // Determine the interaction status
            GeoUtils.DetermineParentChildStatus(wellList);
            
            wellListGrid.ItemsSource = wellList;

            Console.WriteLine(wellList);


          }
        }
    }
