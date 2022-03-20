using GhostSheriffsDatabaseAccess;

namespace Core.ParkingGarage
{
    public class HandleParkingGarage
    {
       readonly ParkingGarageLimitations parkingGarageLimitations = new(); //kanske flyttar ut dessa och dylika metoder till logic

        readonly VehicleContext context = new();

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

            if (result == null)
            {
                result = TimeSpan.MinValue;
            }
            else
            {

            }


            return (TimeSpan)result;
        }
        public double HandlePrice(TimeSpan amountOfTime, string vehicleType) // hantera pris, första 10 min är gratis
        {
            ParkingGarageLimitations parkingGarageLimitations = new();
            int carRentalPrice = parkingGarageLimitations.GetOneIntValueFromJsonFile(1);
            int mcRentalPrice = parkingGarageLimitations.GetOneIntValueFromJsonFile(2);

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

        //Plocka ut alla fordonstyper från den valda parkeringsplatsen
        public List<string> CountEachVehicleTypeInSelectedParkingSpot(int currentParkingSpot)
        {
            List<string> amountOfVehicleTypes = new();

            using var context = new VehicleContext();
            {
                foreach (var vehiclesParkingSpot in context.Garage)
                {
                    var selectedParkingSpot = vehiclesParkingSpot.ParkingSpot;

                    if (selectedParkingSpot == currentParkingSpot)
                    {

                        var vehicleType = vehiclesParkingSpot.VehicleType;

                        if (vehicleType == null)
                        { }
                        else
                        {
                            amountOfVehicleTypes.Add(vehicleType);
                        }
                    }
                }

                return amountOfVehicleTypes;
            }

        }

        //Beräknar utrymmet som finns kvar på vald parkeringsplats
       public int UsedSpaceInSelectedParkingSpot(List<string> collectedVehicleTypes)
        {
            int parkingSpaceLeft = 0;
            int sizeOfCar = parkingGarageLimitations.GetOneIntValueFromJsonFile(6);
            int sizeOfMotorcycle = parkingGarageLimitations.GetOneIntValueFromJsonFile(7);
            string car = parkingGarageLimitations.GetOneStringValueFromJsonFile(4);
            string motorcycle = parkingGarageLimitations.GetOneStringValueFromJsonFile(5);

            foreach (var items in collectedVehicleTypes)
            {
                if(items.Equals(car))
                {
                    parkingSpaceLeft += sizeOfCar;
                }
               else if(items.StartsWith(motorcycle))
                {
                    parkingSpaceLeft += sizeOfMotorcycle;
                }
            }

            return parkingSpaceLeft;
        }

        /* item1 - håller i typ av fordon (byts alltid ut om flera typer av fordon finns)
           item2 - håller i antalet unika fordonstyper på vald parkeringsplats
           item3 - håller i den genomsökta parkeringsplatsens plats */
        public (string, int, int) WhatKindOfVehiclesInSelectedParkingSpot((string, int, int) holdVehicleTypeAndAmountOfVehicles)
        {
            int countVehicleTypes = 0;
            var previousVehicleType = "";

            using var context = new VehicleContext();
            {
                foreach (var foundVehicle in context.Garage)



                {
                    var currentParkingSpot = foundVehicle.ParkingSpot;

                    if (currentParkingSpot == holdVehicleTypeAndAmountOfVehicles.Item3)
                    {
                        var vehicleType = foundVehicle.VehicleType;


                        if (vehicleType == null || vehicleType == null)
                        {
                            vehicleType = "";
                        
                        }

                        else if (vehicleType != previousVehicleType)
                        {
                            countVehicleTypes++;

                        }

                        holdVehicleTypeAndAmountOfVehicles.Item1 = vehicleType;


                        holdVehicleTypeAndAmountOfVehicles.Item2 = countVehicleTypes;



                        previousVehicleType = vehicleType;

                    }

                }
                return holdVehicleTypeAndAmountOfVehicles;


            }
        }
   
        }
    }

