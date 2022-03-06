using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class IVehicle
    {
        private readonly string RegNumber;
        private DateTime arrival;
        private VehicleType type;


        public enum VehicleType
        { Car, MC, Empty }


        public IVehicle(VehicleType type, string RegNumber, DateTime arrival)
        {
            this.type = type;
            this.RegNumber = RegNumber;
            this.arrival = arrival;
        }


        public string regNumber { get { return regNumber; } }
        public DateTime Arrival { get { return arrival; } }
        public VehicleType Type { get { return type; } }


        public override string ToString()
        {
            return regNumber.ToString() + "," + arrival.ToString() + "," + Type.ToString();
        }
    }
}
