using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTruckManagementBraydenRoberts.Models.DB
{
    public class TruckData
    {
        public int ModelID {get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public string Colour { get; set; }
        public int RegistrationNumber { get; set; }
        public int DailyRentalPrice { get; set; }
    }
}
