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

namespace StockTruckManagementBraydenRoberts.TruckManagement
{
    /// <summary>
    /// Interaction logic for SearchTruckAndUpdate.xaml
    /// </summary>
    public partial class SearchTruckAndUpdate : UserControl
    {
        IndividualTruck it;

        public SearchTruckAndUpdate()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            truckgrid.Visibility = System.Windows.Visibility.Hidden;

            // Do not load your data at design time.
            // if (!System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
            // {
            // 	//Load your data here and assign the result to the CollectionViewSource.
            // 	System.Windows.Data.CollectionViewSource myCollectionViewSource = (System.Windows.Data.CollectionViewSource)this.Resources["Resource Key for CollectionViewSource"];
            // 	myCollectionViewSource.Source = your data
            // }
        }


        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            if (searchTruckTextBox.Text.Length == 0)
            {
                MessageBox.Show("Please enter Truck Id first");
            }
            else
            {
                int idt = int.Parse(searchTruckTextBox.Text);
                DAO db = new DAO();
                IndividualTruck it = db.searchTruckbyID(idt);
                if (it == null)
                {
                    MessageBox.Show("No Truck found with this Id");

                }
                else
                {
                    truckgrid.Visibility = System.Windows.Visibility.Visible;
                    advanceDepositRequiredTextBox.Text = it.AdvanceDepositRequired.ToString();
                    colourTextBox.Text = it.Colour;
                    dailyRentalPriceTextBox.Text = it.DailyRentalPrice.ToString();
                    dateImportedDatePicker.Text = it.DateImported.ToString();
                    fuelTypeTextBox.Text = it.FuelType;
                    manufactureYearTextBox.Text = it.ManufactureYear.ToString();
                    registrationExpiryDateDatePicker.Text = it.RegistrationExpiryDate.ToString();
                    registrationNumberTextBox.Text = it.RegistrationNumber.ToString();
                    statusTextBox.Text = it.Status.ToString();
                    transmissionTextBox.Text = it.Transmission;
                    wofexpiryDateDatePicker.Text = it.WofexpiryDate.ToString();






                }
            }

        }

        private void SearchAndUpdateButton_Click(object sender, RoutedEventArgs e)
        {
            
            it.AdvanceDepositRequired = int.Parse(advanceDepositRequiredTextBox.Text);
            it.Colour = colourTextBox.Text;
            it.DailyRentalPrice = int.Parse(dailyRentalPriceTextBox.Text);
            it.DateImported = dateImportedDatePicker.SelectedDate.Value;
            it.FuelType = fuelTypeTextBox.Text;
            it.ManufactureYear = int.Parse(manufactureYearTextBox.Text);
            it.RegistrationExpiryDate = registrationExpiryDateDatePicker.SelectedDate.Value;
            it.RegistrationNumber = registrationNumberTextBox.Text;
            it.Status = statusTextBox.Text;
            it.Transmission = transmissionTextBox.Text;
            it.WofexpiryDate = wofexpiryDateDatePicker.SelectedDate.Value;

            DAO db = new DAO();
            db.updateTruck(it);
            MessageBox.Show("Truck data has been updated");





        }
    }
}
