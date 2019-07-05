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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class AddNewTruckNewModel : UserControl
    {
        public AddNewTruckNewModel()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            DAO db = new DAO();
      
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DAO db = new DAO();
            TruckModel model = new TruckModel();

            model.Model = modelTextBox.Text;
            model.Doors = int.Parse(doorsTextBox.Text);
            model.Manufacturer = manufacturerTextBox.Text;
            model.Seats = int.Parse(seatsTextBox.Text);
            model.Size = sizeTextBox.Text;

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

            truck.TruckModel = model;

            int featureID = int.Parse(descriptionTextBox.SelectedText.ToString());

           TruckFeatureAssociation junction = new TruckFeatureAssociation();
           junction.FeatureId = featureID;
           junction.Truck = truck;
           truck.TruckFeatureAssociation.Add(junction);
           db.addNewTruckModel(truck);
           MessageBox.Show("New Truck and New Model Added Successfully");
            



           


            






            

        }
    }
}
