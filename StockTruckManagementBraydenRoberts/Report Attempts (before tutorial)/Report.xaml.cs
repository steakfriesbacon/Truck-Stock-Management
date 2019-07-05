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
using System.Windows.Shapes;
using StockTruckManagementBraydenRoberts.Models.DB;

namespace StockTruckManagementBraydenRoberts
{
    /// <summary>
    /// Interaction logic for Report.xaml
    /// </summary>
    public partial class Report : Window
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource individualTruckViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("individualTruckViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // individualTruckViewSource.Source = [generic data source]
        }

        private void IndividualTruckDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void IndividualTruckDataGrid_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            

            
        }

        private void DatalistBox_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
