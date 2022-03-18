using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GhostSheriffsDatabaseAccess;

namespace Core.ParkingGarage
{
    public class HandleParkingGarage
    {
        //public DateTime TimeStamp { get; set; }

        VehicleContext context = new();

        #region ConditionAndData
        public bool CheckNumberSpot(int parkingSpotMax, int userInput)
        {
            var validNumber = false;

            if (userInput >= 1 && userInput <= parkingSpotMax)
            {
                validNumber = true;
            }
            return validNumber;
        }
        public bool CanVehiclePark(bool validParkingSpotNumber, int currentUsedPSize, int newVehiclePSize, int sizeOfSelectedPSpot)
        {
            bool allowIt = false;
            if (validParkingSpotNumber)
            {
                if ((currentUsedPSize + newVehiclePSize) <= sizeOfSelectedPSpot)
                {
                    allowIt = true;
                }
            }

            return allowIt;
        }
        public List<VehiclesDB> SelectVehicle(string searchWord)
        {
            var dbIndexNumber = context.Garage
                .Where(condition => condition.NumberPlate == searchWord.ToUpper())
                .Select(select => select).ToList();
            return dbIndexNumber;
        }
        public bool SearchVehicle(string searchWord)
        {
            var isFound = context.Garage
                .Where(condition => condition.NumberPlate == searchWord.ToUpper())
                .Select(select => select)
                .Any();
            return isFound;
        }
        public int GetVehicleSize(string numberPlate)
        {
            var vehicleSize = context.Garage
                .Where(condition => condition.NumberPlate == numberPlate)
                .Select(select => select.VehicleSize)
                .ToList();
            return vehicleSize[0];
        }

        public string GetVehicleType(string numberPlate)
        {
            var vehicleType = context.Garage
               .Where(condition => condition.NumberPlate == numberPlate)
               .Select(select => select.VehicleType)
               .ToList();
            return vehicleType[0];
        }
        #endregion

        #region ApplyAction
        public void AddVehicleToDb(bool GarageCapacity, bool canVehiclePark, VehiclesDB newVehicle)
        {
            if (GarageCapacity)
            {
                if (canVehiclePark)
                {
                    context.Add(newVehicle);
                    context.SaveChanges();
                }
            }
        }
        public void MoveVehicle(bool searchVehicle, bool canVehiclePark, List<VehiclesDB> selectVehicle, int newSpot)
        {
            if (searchVehicle)
            {
                if (canVehiclePark)
                {
                    selectVehicle[0].ParkingSpot = newSpot;
                    context.Update(selectVehicle[0]);
                    context.SaveChanges();
                }
            }
        }
        public void RemoveVehicle(bool searchVehicle, List<VehiclesDB> selectVehicle)
        {
            if (searchVehicle)
            {
                context.Remove(selectVehicle[0]);
                context.SaveChanges();
            }
        }
        #endregion

        // Json
        public TimeSpan AmountOfTime(string numberPlate)
        {
            var checkOut = DateTime.Now.AddMinutes(-10);

            var checkIn = context.Garage
                .Where(condition => condition.NumberPlate == numberPlate)
                .Select(select => select.CheckInTimeStamp)
                .FirstOrDefault();

            var result = checkOut - checkIn;
            return (TimeSpan)result;
        }
        public double HandlePrice(TimeSpan amountOfTime, string vehicleType) // hantera pris, första 10 min är gratis
        {
            ParkingGarageLimitations parkingGarageLimitations = new();
            int carRentalPrice = parkingGarageLimitations.GetOneIntValueFromJsonFile(1);
            int mcRentalPrice = parkingGarageLimitations.GetOneIntValueFromJsonFile(2);
            Console.WriteLine("test");
            double price = 0;
            if (vehicleType == "Car")
            {
                price = Math.Round(((double)amountOfTime.TotalHours * carRentalPrice), 2); // json
            }
            else if (vehicleType == "Motorcycle")
            {
                price = Math.Round(((double)amountOfTime.TotalHours * mcRentalPrice), 2);// json
            }
            return price;
        }
        
        //Tar ut både parkeringsplatsen och nummerplåten i en objektlista
        public List<object> PresentVehicle(string vehicleType)
        {
            List<object> vehicle = new();

            using var context = new VehicleContext();
            {
                foreach (var foundVehicle in context.Garage)



                {
                    var typeOfVehicle = foundVehicle.VehicleType;

                    if (typeOfVehicle == vehicleType)
                    {

                        var numberPlate = foundVehicle.NumberPlate;
                        var parkingSpot = foundVehicle.ParkingSpot;

                        if (numberPlate == null)
                        { }
                        else
                        {
                            vehicle.Add(numberPlate);
                            vehicle.Add(parkingSpot);
                        }
                    }
                }

                return vehicle;
            }
        }

        //Hämtar fordonstypen
        public string GetNumberPlateVehicleType(string numberPlate)
        {

            var getVehicleType = context.Garage
             .Where(condition => condition.NumberPlate == numberPlate)
             .Select(select => select.VehicleType)
             .FirstOrDefault();

            var result = getVehicleType?.ToString();
          
            if (result == null)
            { 
             result = ""; 
            }
            else
            {

            }

            return result;
        }
    }
}
