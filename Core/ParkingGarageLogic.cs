using Core.HandlingParkingSpot;
using Core.ParkingGarage;
using Core.Vehicles;

namespace Core
{
    //TODO få in logiken
    public class ParkingGarageLogic
    {
        CreateDb createDb = new();
        HandleParkingGarage Garage = new();
        ParkingSpot parking = new();

        public void CreateTheDB()
        {
            createDb.EnsureCreatedDb();
            //createDb.InitializeDb();
        }

        //Console.Write
        //    (
        //    "1. Park car\n" +
        //    "2. Park mc\n" +
        //    "3. Move vehicle\n" +
        //    "4. Remove vehicle\n" +
        //    "Select: "
        //    );

        //var input = int.Parse(Console.ReadLine());

        //smidigare sätt att få placementForVehicle till int?
        public void ParkingGarageOptions(int choice, string NumberPlate, string placementForVehicle)
        {
            switch (choice)
            {
                //Add vehicle
                case 1:
                    var regNrCar = NumberPlate;
                    var platsCar = int.Parse(placementForVehicle);
                    Car newCar = new(regNrCar);
                    Garage.AddVehicleToDb
                        (
                        Garage.canVehiclePark(parking.CurrentOccupiedPSpace(platsCar), newCar.VehicleSize, parking.P_SpotSize),
                        parking.GarageCapacity(parking.AllOccupiedPSpace(), parking.GarageMaxCapacity()),
                        newCar.GetVehicleData(DateTime.Now, platsCar, newCar.VehicleType)
                        );
                    break;
                case 2:
                    var regNrMc = NumberPlate;
                    var platsMc = int.Parse(placementForVehicle);
                    Motorcycle newMc = new(regNrMc);
                    Garage.AddVehicleToDb
                        (
                        Garage.canVehiclePark(parking.CurrentOccupiedPSpace(platsMc), newMc.VehicleSize, parking.P_SpotSize),
                        parking.GarageCapacity(parking.AllOccupiedPSpace(), parking.GarageMaxCapacity()),
                        newMc.GetVehicleData(DateTime.Now, platsMc, newMc.VehicleType)
                        );
                    break;
                case 3:
                    var searchForVehicle = NumberPlate;
                    var newPSpace = int.Parse(placementForVehicle);
                    Garage.MoveVehicle
                        (
                        Garage.SearchVehicle(searchForVehicle),
                        Garage.canVehiclePark(parking.CurrentOccupiedPSpace(newPSpace), Garage.GetVehicleSize(searchForVehicle), parking.P_SpotSize),
                        Garage.SelectVehicle(searchForVehicle),
                        newPSpace
                        );
                    break;
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
    }
}
//// WinForms
//static string AngeReg()
//    {
//        Console.WriteLine("Ange regnr");
//        var reg = Console.ReadLine();
//        return reg;
//    }
//    static int VäljPlats()
//    {
//        Console.WriteLine("Välj plats");
//        var plats = int.Parse(Console.ReadLine());
//        return plats;
//    }
//}

