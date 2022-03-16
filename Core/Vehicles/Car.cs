using GhostSheriffsDatabaseAccess;


namespace Core.Vehicles
{
    public class Car : Vehicle
    {
        ParkingGarageLimitations ParkingGarageLimitations = new();

        public Car(string regnr)
        {
            this.VehicleSize = ParkingGarageLimitations.GetOneIntValueFromJsonFile(6); 
            this.VehicleType = ParkingGarageLimitations.GetOneStringValueFromJsonFile(4); 
            this.Regnumber = regnr;
        }
    }
}
