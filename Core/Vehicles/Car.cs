using GhostSheriffsDatabaseAccess;


namespace Core.Vehicles
{
    public class Car : Vehicle
    {
        ParkingGarageLimitations ParkingGarageLimitations = new();

        public Car(string regnr)
        {
            this.VehicleSize = ParkingGarageLimitations.GetOneIntValueFromJsonFile(8);// här ska det länkas mot json
            this.VehicleType = ParkingGarageLimitations.GetOneStringValueFromJsonFile(6); // samma här
            this.Regnumber = regnr;
        }
    }
}
