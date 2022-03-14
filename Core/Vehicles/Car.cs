using GhostSheriffsDatabaseAccess;


namespace Core.Vehicles
{
    public class Car : Vehicle
    {
        
        public Car(string regnr)
        {
            
            this.VehicleSize = 4;// här ska det länkas mot json
            this.VehicleType = "Car"; // samma här
            this.Regnumber = regnr;
        }
    }
}
