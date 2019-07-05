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
    /// Interaction logic for SearchTruckDetailByIDUC.xaml
    /// </summary>
    public partial class SearchTruckDetailByIDUC : UserControl
    {
        public SearchTruckDetailByIDUC()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

            // Do not load your data at design time.
            // if (!System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
            // {
            // 	//Load your data here and assign the result to the CollectionViewSource.
            // 	System.Windows.Data.CollectionViewSource myCollectionViewSource = (System.Windows.Data.CollectionViewSource)this.Resources["Resource Key for CollectionViewSource"];
            // 	myCollectionViewSource.Source = your data
            // }
        }

        private void BtnSearch_Click(object sender, RoutedEventArgs e)
        {
            int modelID = int.Parse(tbSearch.Text);
            DAO db = new DAO();

            TruckData data = db.searchTruckDetailByID(modelID);
            //The below line is to link above data to the data grid
            List<TruckData> values = new List<TruckData>();
            values.Add(data);
            CollectionViewSource myCollectionViewSource = (CollectionViewSource)this.Resources["truckDataViewSource"];
            myCollectionViewSource.Source = values;


        }
    }
}
