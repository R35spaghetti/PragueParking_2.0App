using GhostSheriffsDatabaseAccess;


namespace Core.Vehicles
{
    public class Car : Vehicle
    {
       ParkingGarageLimitations parkingGarageLimitations = new();
        
        public Car(string regnr)
        {

            this.VehicleSize = 4;// här ska det länkas mot json
            this.VehicleType = "Car";// "Car"; // samma här
            this.Regnumber = regnr;
        }
    }
}
