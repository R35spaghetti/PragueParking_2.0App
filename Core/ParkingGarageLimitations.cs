using GhostSheriffsDatabaseAccess;
using System;

namespace Core
{
    public class ParkingGarageLimitations
    {

        int newConfigFileValue = 0;

      readonly int parkingSpots = 0;
      readonly int rentalPriceMC = 0;
      readonly int rentalPriceCar = 0;
      readonly string carType = string.Empty;
      readonly string motorcycleType = string.Empty;
      readonly int vehicleSizeCar = 0;
      readonly int vehicleSizeMotorcycle = 0;
      readonly int parkingSpaceSize = 0;




        (int, int, int, string, string, int, int, int) rentalPricesAndLimitations = (0, 0, 0, "", "", 0, 0, 0);

        //Gets current car and mc price into a string //TODO:ändra?
        public string GetJsonValuesToPresent(string values)
        {
            //Get the current values from the ParkingLotLimitationValues-jsonfile
            rentalPricesAndLimitations = VehicleContext.GiveParkGarageValuesFromJsonFile(rentalPricesAndLimitations);


            int carPrice = rentalPricesAndLimitations.Item1;
            int mcPrice = rentalPricesAndLimitations.Item2;
            int currentParkingSpots = rentalPricesAndLimitations.Item3;
            string vehicleTypeCar = rentalPricesAndLimitations.Item4;
            string vehicleTypeMC = rentalPricesAndLimitations.Item5;
            int sizeCar = rentalPricesAndLimitations.Item6;
            int sizeMC = rentalPricesAndLimitations.Item7;
            int parkingSpotSpace = rentalPricesAndLimitations.Item8;


            values = $"Current rental price for car: {carPrice}\n" +
                    $"Current rental price for motorcycle: {mcPrice}.\n" +
                    $"Current amount of parking spots in the garage: {currentParkingSpots}.\n" +
                    $"Current vehicles allowed: {vehicleTypeCar} & {vehicleTypeMC}.\n" +
                    $"Current size of cars: {sizeCar}\n" +
                    $"Current size of motorcycles: {sizeMC}\n" +
                    $"Current size of parking lots: {parkingSpotSpace}";

            return values;
        }

        //Gets one value from the json-file based on row
        public int GetOneIntValueFromJsonFile(int placementOfJsonValue)
        {
            rentalPricesAndLimitations = VehicleContext.GiveParkGarageValuesFromJsonFile(rentalPricesAndLimitations);
            int value = 0;


            switch(placementOfJsonValue)
            {
                case 1:
                    //Price for car
                    value = rentalPricesAndLimitations.Item1;

                    break;


                    case 2:
                          //Price for mc
                        value = rentalPricesAndLimitations.Item2;
                    break;


                case 3: //Parking spots in the garage
                    value = rentalPricesAndLimitations.Item3;
                    break;
                case 6: //vehicle Size car
                    value = rentalPricesAndLimitations.Item6;
                    break;

                case 7: //vehicle size motorcycle
                    value = rentalPricesAndLimitations.Item7;

                    break;

                case 8: //Parking space size
                    value = rentalPricesAndLimitations.Item8;
                    break;
            
               
            }


            return value;


        }

        public string GetOneStringValueFromJsonFile(int placementOfJsonValue)
        {
            rentalPricesAndLimitations = VehicleContext.GiveParkGarageValuesFromJsonFile(rentalPricesAndLimitations);
            string value = "";


            switch (placementOfJsonValue)
            {
                //Get vehicle type: Car
                case 4:
                    value = rentalPricesAndLimitations.Item4;
                    break;

                //Get vehicle type: Motorcycle
                case 5:
                    value = rentalPricesAndLimitations.Item5;
                    break;

               
            }


            return value;


        }



        
        public void SwitchMenuValues(string value, int switchValue)

        {
            
           newConfigFileValue = GetNewIntValue(value);

            //Get the current values from the ParkingLotLimitationValues-jsonfile
            rentalPricesAndLimitations = VehicleContext.GiveParkGarageValuesFromJsonFile(rentalPricesAndLimitations);
            rentalPricesAndLimitations = ChangeOneValue(rentalPriceCar, rentalPriceMC, parkingSpots, carType, motorcycleType, vehicleSizeCar, vehicleSizeMotorcycle, parkingSpaceSize);
            VehicleContext.EditParkingLotLimitionValues(rentalPricesAndLimitations);

            (int, int, int, string, string, int, int, int) ChangeOneValue(int rentalPriceCar, int rentalPriceMC, int parkingSpots, string carType, string motorcycleType, int vehicleSizeCar, int vehicleSizeMotorcycle, int parkingSpaceSize)
            {
                switch (switchValue)
                { //Alla får sitt gamla värde utom ett som byts ut
                    case 1:

                        rentalPriceCar = newConfigFileValue;

                        rentalPriceMC = rentalPricesAndLimitations.Item2;
                        parkingSpots = rentalPricesAndLimitations.Item3;
                        carType = rentalPricesAndLimitations.Item4;
                        motorcycleType = rentalPricesAndLimitations.Item5;
                        vehicleSizeCar = rentalPricesAndLimitations.Item6;
                        vehicleSizeMotorcycle = rentalPricesAndLimitations.Item7;
                        parkingSpaceSize = rentalPricesAndLimitations.Item8;

                        break;
                   
                    case 2:

                        rentalPriceCar = rentalPricesAndLimitations.Item1;

                        rentalPriceMC = newConfigFileValue;

                        parkingSpots = rentalPricesAndLimitations.Item3;
                        carType = rentalPricesAndLimitations.Item4;
                        motorcycleType = rentalPricesAndLimitations.Item5;
                        vehicleSizeCar = rentalPricesAndLimitations.Item6;
                        vehicleSizeMotorcycle = rentalPricesAndLimitations.Item7;
                        parkingSpaceSize = rentalPricesAndLimitations.Item8;

                        break;

                    case 3:
                        rentalPriceCar = rentalPricesAndLimitations.Item1;
                        rentalPriceMC = rentalPricesAndLimitations.Item2;

                        parkingSpots = newConfigFileValue;

                        carType = rentalPricesAndLimitations.Item4;
                        motorcycleType = rentalPricesAndLimitations.Item5;
                        vehicleSizeCar = rentalPricesAndLimitations.Item6;
                        vehicleSizeMotorcycle = rentalPricesAndLimitations.Item7;
                        parkingSpaceSize = rentalPricesAndLimitations.Item8;
                     
                        break;


                    case 6:

                        rentalPriceCar = rentalPricesAndLimitations.Item1;
                        rentalPriceMC = rentalPricesAndLimitations.Item2;
                        parkingSpots = rentalPricesAndLimitations.Item3;
                        carType = rentalPricesAndLimitations.Item4;
                        motorcycleType = rentalPricesAndLimitations.Item5;

                        vehicleSizeCar = newConfigFileValue;

                        vehicleSizeMotorcycle = rentalPricesAndLimitations.Item7;
                        parkingSpaceSize = rentalPricesAndLimitations.Item8;

                        break;

                    case 7:

                        rentalPriceCar = rentalPricesAndLimitations.Item1;
                        rentalPriceMC = rentalPricesAndLimitations.Item2;
                        parkingSpots = rentalPricesAndLimitations.Item3;
                        carType = rentalPricesAndLimitations.Item4;
                        motorcycleType = rentalPricesAndLimitations.Item5;
                        vehicleSizeCar = rentalPricesAndLimitations.Item6;

                        vehicleSizeMotorcycle = newConfigFileValue;

                        parkingSpaceSize = rentalPricesAndLimitations.Item8;

                        break;


                    case 8:

                        rentalPriceCar = rentalPricesAndLimitations.Item1;
                        rentalPriceMC = rentalPricesAndLimitations.Item2;
                        parkingSpots = rentalPricesAndLimitations.Item3;
                        carType = rentalPricesAndLimitations.Item4;
                        motorcycleType = rentalPricesAndLimitations.Item5;
                        vehicleSizeCar = rentalPricesAndLimitations.Item6;
                        vehicleSizeMotorcycle = rentalPricesAndLimitations.Item7;

                        parkingSpaceSize = newConfigFileValue;

                        break;

                    default:

                        

                        break;

                }

                return (rentalPriceCar, rentalPriceMC, parkingSpots, carType, motorcycleType, vehicleSizeCar, vehicleSizeMotorcycle, parkingSpaceSize);

            }
        }

       static int GetNewIntValue(string value)
        {

          int configFileValue = ParseIntValue(value);

            return configFileValue;

        }

        static int ParseIntValue(string? input)
        {
            int convertedValue = -1;


            if (input == null)
            {


            }
            else
            {

                convertedValue = int.Parse(input);

            }

            return convertedValue;

        }

    }
}
