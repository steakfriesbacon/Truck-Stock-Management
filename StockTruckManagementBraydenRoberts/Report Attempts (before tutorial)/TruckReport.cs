using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockTruckManagementBraydenRoberts.Models.DB;

namespace StockTruckManagementBraydenRoberts
{
    public partial class TruckReport: Form
    {
        List<IndividualTruck> sortedTrucks = new List<IndividualTruck>();

        public TruckReport()
        {
            InitializeComponent();
        }

        private void btnSortbyTop5_Click(object sender, EventArgs e)
        {
            sortedTrucks.Sort();
            sortedTrucks.Reverse();
            dataListBox.DataSource = sortedTrucks;

        }
    }
}
