using StockTruckManagementBraydenRoberts.Models.DB;
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

namespace StockTruckManagementBraydenRoberts
{
    /// <summary>
    /// Interaction logic for SearchCarModelByIDUC.xaml
    /// </summary>
    public partial class SearchCarModelByIDUC : UserControl
    {
        public SearchCarModelByIDUC()
        {
            InitializeComponent();
        }

        private void BtnSearch_Click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(tbModelidSearch.Text);
            DAO db = new DAO();
            //THis below is to link data with data grid control
            List<TruckModel> data = new List<TruckModel>();
            data.Add(db.searchTruckModelByID(id));
            DataGridTruckModelID.ItemsSource = data;


        }
    }
}
