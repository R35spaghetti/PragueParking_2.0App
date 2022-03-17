using Core.HandlingParkingSpot;
using Core.ParkingGarage;
using Core.Vehicles;
using GhostSheriffsDatabaseAccess;

namespace Core
{
    public class ParkingGarageLogic
    {
        readonly CreateDb createDb = new();
        readonly HandleParkingGarage Garage = new();
        readonly ParkingSpot parking = new();


        public void CreateTheDB()
        {
            VehicleContext vehicleContext = new();
            createDb.EnsureCreatedDb();
            var isDbEmpty = vehicleContext.Garage.Where(x => x.Id == 1);
            if (!isDbEmpty.Any())
            {
                createDb.InitializeDb();
            }
        }



        //var input = int.Parse(Console.ReadLine());

        //smidigare sätt att få placementForVehicle till int?
        public void ParkingGarageOptions(int choice, string NumberPlate, string placementForVehicle)
        {
            switch (choice)
            {
                //Add car 
                case 1:
                    var regNrCar = NumberPlate;
                    var platsCar = int.Parse(placementForVehicle);
                    Car newCar = new(regNrCar);
                    Garage.AddVehicleToDb
                        (
                        Garage.CanVehiclePark(Garage.CheckNumberSpot(100, platsCar), parking.CurrentOccupiedPSpace(platsCar), newCar.VehicleSize, parking.P_SpotSize),
                        parking.GarageCapacity(parking.AllOccupiedPSpace(), parking.GarageMaxCapacity()),
                        newCar.GetVehicleData(DateTime.Now, platsCar, newCar.VehicleType)
                        );
                    break;

                //Add MC
                case 2:
                    var regNrMc = NumberPlate;
                    var platsMc = int.Parse(placementForVehicle);
                    Motorcycle newMc = new(regNrMc);
                    Garage.AddVehicleToDb
                        (
                        Garage.CanVehiclePark(Garage.CheckNumberSpot(100, platsMc), parking.CurrentOccupiedPSpace(platsMc), newMc.VehicleSize, parking.P_SpotSize),
                        parking.GarageCapacity(parking.AllOccupiedPSpace(), parking.GarageMaxCapacity()),
                        newMc.GetVehicleData(DateTime.Now, platsMc, newMc.VehicleType)
                        );
                    break;

                //Move vehicle
                case 3:
                    var searchForVehicle = NumberPlate;
                    var newPSpace = int.Parse(placementForVehicle);
                    Garage.MoveVehicle
                        (
                        Garage.SearchVehicle(searchForVehicle),
                        Garage.CanVehiclePark(Garage.CheckNumberSpot(100, newPSpace), parking.CurrentOccupiedPSpace(newPSpace), Garage.GetVehicleSize(searchForVehicle), parking.P_SpotSize),
                        Garage.SelectVehicle(searchForVehicle),
                        newPSpace
                        );
                    break;

                //Remove vehicle
                case 4:
                    Garage.RemoveVehicle
                    (
                        Garage.SearchVehicle(NumberPlate),
                        Garage.SelectVehicle(NumberPlate)
                    );
                    break;


                default:
                    break;

            }
        }

        //Hämta regnummer och parkeringsplats, slå sedan ihop båda två till en sträng
        public string PresentVehicles(string numberPlateWithParkingSpot, int parkingSpot, string vehicle)
        {


            List<object> vehiclesWithParkingSpot = Garage.PresentVehicle(vehicle);

            //om outofbounds
            try
            {
                //Tar både nummerplåten och parkeringsnummret 
                numberPlateWithParkingSpot = (string)vehiclesWithParkingSpot[parkingSpot];
                parkingSpot++; //Parkeringsplatsen kommer alltid ligga bredvid nummerplåten i objektlistan
                parkingSpot = (int)vehiclesWithParkingSpot[parkingSpot];

                numberPlateWithParkingSpot += " | " + parkingSpot.ToString();
            }

            catch (ArgumentOutOfRangeException)
            { }

            return numberPlateWithParkingSpot;

        }
    }
}


