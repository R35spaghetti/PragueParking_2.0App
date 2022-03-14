using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Vehicles
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle(string regnr)
        {
            this.VehicleSize = 2; // här ska det länkas mot json
            this.VehicleType = "Motorcycle"; // samma här
            this.Regnumber = regnr;
        }
    }
}
