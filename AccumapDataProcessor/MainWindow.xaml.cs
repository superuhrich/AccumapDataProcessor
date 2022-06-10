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

        public static int buttonCount = 0;

        private void testButton_Click(object sender, RoutedEventArgs e)
        {

            string synapse = ConfigurationManager.ConnectionStrings["Synapse"].ConnectionString;

            var context = new AZUPSQLP01Context();

            var well = (from c in context.TIhsWells
                        where c.Uwi.Contains("103132704204W400")
                        select c).First();

       

            if (null != well)
            {
                var businessAssociate =
                    (from ba in context.TIhsBusinessAssociates
                    where ba.BusinessAssociate == well.Operator
                    select ba).First();

                if(null != businessAssociate)
                {
                    buttonCount++;
                    Display.Text = businessAssociate.BaName?.ToString();
                    Display.Text = buttonCount.ToString();
                }
            }
        }
    }
}
