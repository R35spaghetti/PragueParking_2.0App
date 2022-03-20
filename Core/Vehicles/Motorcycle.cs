

namespace Core.Vehicles
{
    public class Motorcycle : Vehicle
    {
       readonly ParkingGarageLimitations ParkingGarageLimitations = new();

        public Motorcycle(string regnr)
        {
            this.VehicleSize = ParkingGarageLimitations.GetOneIntValueFromJsonFile(7); 
            this.VehicleType = ParkingGarageLimitations.GetOneStringValueFromJsonFile(5); 
            this.Regnumber = regnr;
        }
    }
}
