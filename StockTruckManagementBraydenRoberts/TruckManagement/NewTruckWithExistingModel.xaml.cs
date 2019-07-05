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
using System.Windows.Shapes;

namespace StockTruckManagementBraydenRoberts
{
    /// <summary>
    /// Interaction logic for NewCarWithExistingModel.xaml
    /// </summary>
    public partial class NewTruckWithExistingModel : UserControl
    {
        public NewTruckWithExistingModel()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            DAO db = new DAO();
            descriptionComboBox.ItemsSource = db.getTruckFeature();
            descriptionComboBox.DisplayMemberPath = "Feature";
            descriptionComboBox.SelectedValuePath = "TruckFeatureId";
            modelComboBox.ItemsSource = db.getTruckModels();
            modelComboBox.DisplayMemberPath = "Model";
            modelComboBox.SelectedValuePath = "ModelId";

            // Do not load your data at design time.
            // if (!System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
            // {
            // 	//Load your data here and assign the result to the CollectionViewSource.
            // 	System.Windows.Data.CollectionViewSource myCollectionViewSource = (System.Windows.Data.CollectionViewSource)this.Resources["Resource Key for CollectionViewSource"];
            // 	myCollectionViewSource.Source = your data
            // }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DAO db = new DAO();
            IndividualTruck truck = new IndividualTruck();

            truck.AdvanceDepositRequired = int.Parse(advanceDepositRequiredTextBox.Text);
            truck.Colour = colourTextBox.Text;
            truck.DailyRentalPrice = int.Parse(dailyRentalPriceTextBox.Text);
            truck.DateImported = dateImportedDatePicker.SelectedDate.Value;
            truck.FuelType = fuelTypeTextBox.Text;
            truck.ManufactureYear = int.Parse(manufactureYearTextBox.Text);
            truck.RegistrationExpiryDate = registrationExpiryDateDatePicker.SelectedDate.Value;
            truck.RegistrationNumber = registrationNumberTextBox.Text;
            truck.Status = statusTextBox.Text;
            truck.Transmission = transmissionTextBox.Text;
            truck.WofexpiryDate = wofexpiryDateDatePicker.SelectedDate.Value;



        }
    }
}
