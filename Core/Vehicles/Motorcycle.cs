using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Vehicles
{
    public class Motorcycle : Vehicle
    {
       readonly ParkingGarageLimitations ParkingGarageLimitations = new();

        public Motorcycle(string regnr)
        {
            this.VehicleSize = ParkingGarageLimitations.GetOneIntValueFromJsonFile(7); // här ska det länkas mot json
            this.VehicleType = ParkingGarageLimitations.GetOneStringValueFromJsonFile(5); // samma här
            this.Regnumber = regnr;
        }
    }
}
