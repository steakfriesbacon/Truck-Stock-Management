using StockTruckManagementBraydenRoberts.TruckManagement;
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

namespace StockTruckManagementBraydenRoberts
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {/*
        public string username;
        public string password;

        public Login sender;

        public MainWindow(string username, string password, Login sender)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
            this.sender = sender;
        }

        public MainWindow()
        {
            InitializeComponent();
        }
        */
        private void AddNewTruckwithExistingModel_Click(object sender, RoutedEventArgs e)
        {
            CenterPanel.Children.Clear();
            CenterPanel.Children.Add(new NewTruckWithExistingModel());
        }

        private void AddNewTruckNewModel_Click(object sender, RoutedEventArgs e)
        {
            CenterPanel.Children.Clear();
            CenterPanel.Children.Add(new AddNewTruckNewModel());
            
        }

        private void SearchTruck_Click(object sender, RoutedEventArgs e)
        {
            CenterPanel.Children.Clear();
            CenterPanel.Children.Add(new SearchTruck());
        }

        private void SearchTruckAndUpdate_Click(object sender, RoutedEventArgs e)
        {
            CenterPanel.Children.Clear();
            CenterPanel.Children.Add(new SearchTruckAndUpdate());
        }

        private void SearchTruckby_Click(object sender, RoutedEventArgs e)
        {

            CenterPanel.Children.Clear();
            CenterPanel.Children.Add(new SearchCarModelByIDUC());
        }

        private void SearchTruckDetailsbyID_Click(object sender, RoutedEventArgs e)
        {
            CenterPanel.Children.Clear();
            CenterPanel.Children.Add(new SearchTruckDetailByIDUC());

        }
    }
}
