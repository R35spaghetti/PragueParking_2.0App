using DataAccess.DataAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Vehicles
{
    public class Car : Vehicle
    {

        public Car(string regnr)
        {


            this.VehicleSize = 4; // här ska det länkas mot json
            this.VehicleType = "Car"; // samma här
            this.Regnumber = regnr;
        }
    }
}
