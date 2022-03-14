using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Vehicles
{
    public class Motorcycle : Vehicle
    {
        ParkingGarageLimitations ParkingGarageLimitations = new();

        public Motorcycle(string regnr)
        {
            this.VehicleSize = ParkingGarageLimitations.GetOneIntValueFromJsonFile(9); // här ska det länkas mot json
            this.VehicleType = ParkingGarageLimitations.GetOneStringValueFromJsonFile(7); // samma här
            this.Regnumber = regnr;
        }
    }
}
