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
      readonly int carsPerSpace = 0;
      readonly int mcsPerSpace = 0;
      readonly string carType = string.Empty;
      readonly string motorcycleType = string.Empty;
      readonly int vehicleSize = 0;


        (int, int, int, int, int, string, string, int) rentalPricesAndLimitations = (0, 0, 0, 0, 0, "", "", 0);

        //Gets current car and mc price into a string
        public string GetRentalPrices(string prices)
        {
            //Get the current values from the ParkingLotLimitationValues-jsonfile
            rentalPricesAndLimitations = VehicleContext.GiveParkGarageValuesFromJsonFile(rentalPricesAndLimitations);

            

            prices += "Car rental price:" + " " + rentalPricesAndLimitations.Item1.ToString()+" ";
            prices += "\nMC rental price:" + " " + rentalPricesAndLimitations.Item2.ToString();

            return prices;
        }


        public  void SwitchMenuValues(string value, int switchValue)

        {
            
           newConfigFileValue = GetNewIntValue(value);

            //Get the current values from the ParkingLotLimitationValues-jsonfile
            rentalPricesAndLimitations = VehicleContext.GiveParkGarageValuesFromJsonFile(rentalPricesAndLimitations);
            rentalPricesAndLimitations = ChangeOneValue(rentalPriceCar, rentalPriceMC, parkingSpots, carsPerSpace, mcsPerSpace, carType, motorcycleType, vehicleSize);
            VehicleContext.EditParkingLotLimitionValues(rentalPricesAndLimitations);

            (int, int, int, int, int, string, string, int) ChangeOneValue(int rentalPriceCar, int rentalPriceMC, int parkingSpots, int carsPerSpace, int mcsPerSpace, string carType, string motorcycleType, int vehicleSize)
            {
                switch (switchValue)
                {
                    case 1:

                        rentalPriceCar = newConfigFileValue;
                        rentalPriceMC = rentalPricesAndLimitations.Item2;
                        parkingSpots = rentalPricesAndLimitations.Item3;
                        carsPerSpace = rentalPricesAndLimitations.Item4;
                        mcsPerSpace = rentalPricesAndLimitations.Item5;
                        carType = rentalPricesAndLimitations.Item6;
                        motorcycleType = rentalPricesAndLimitations.Item7;
                        vehicleSize = rentalPricesAndLimitations.Item8;


                        break;

                    case 2:

                        rentalPriceCar = rentalPricesAndLimitations.Item1;
                        rentalPriceMC = newConfigFileValue;
                        parkingSpots = rentalPricesAndLimitations.Item3;
                        carsPerSpace = rentalPricesAndLimitations.Item4;
                        mcsPerSpace = rentalPricesAndLimitations.Item5;
                        carType = rentalPricesAndLimitations.Item6;
                        motorcycleType = rentalPricesAndLimitations.Item7;
                        vehicleSize = rentalPricesAndLimitations.Item8;

                        break;

                    case 3:

                        rentalPriceCar = rentalPricesAndLimitations.Item1;
                        rentalPriceMC = rentalPricesAndLimitations.Item2;
                        parkingSpots = newConfigFileValue;
                        carsPerSpace = rentalPricesAndLimitations.Item4;
                        mcsPerSpace = rentalPricesAndLimitations.Item5;
                        carType = rentalPricesAndLimitations.Item6;
                        motorcycleType = rentalPricesAndLimitations.Item7;
                        vehicleSize = rentalPricesAndLimitations.Item8;

                        break;

                    case 4:

                        rentalPriceCar = rentalPricesAndLimitations.Item1;
                        rentalPriceMC = rentalPricesAndLimitations.Item2;
                        parkingSpots = rentalPricesAndLimitations.Item3;
                        carsPerSpace = newConfigFileValue;
                        mcsPerSpace = rentalPricesAndLimitations.Item5;
                        carType = rentalPricesAndLimitations.Item6;
                        motorcycleType = rentalPricesAndLimitations.Item7;
                        vehicleSize = rentalPricesAndLimitations.Item8;

                        break;

                    case 5:

                        rentalPriceCar = rentalPricesAndLimitations.Item1;
                        rentalPriceMC = rentalPricesAndLimitations.Item2;
                        parkingSpots = rentalPricesAndLimitations.Item3;
                        carsPerSpace = rentalPricesAndLimitations.Item4;
                        mcsPerSpace = newConfigFileValue;
                        carType = rentalPricesAndLimitations.Item6;
                        motorcycleType = rentalPricesAndLimitations.Item7;
                        vehicleSize = rentalPricesAndLimitations.Item8;

                        break;



                    case 6:
                       
                        rentalPriceCar = rentalPricesAndLimitations.Item1;
                        rentalPriceMC = rentalPricesAndLimitations.Item2;
                        parkingSpots = rentalPricesAndLimitations.Item3;
                        carsPerSpace = rentalPricesAndLimitations.Item4;
                        mcsPerSpace = rentalPricesAndLimitations.Item5;
                        carType = newConfigFileValue.ToString();
                        motorcycleType = rentalPricesAndLimitations.Item7;
                        vehicleSize = rentalPricesAndLimitations.Item8;

                        break;

                    case 7:

                        rentalPriceCar = rentalPricesAndLimitations.Item1;
                        rentalPriceMC = rentalPricesAndLimitations.Item2;
                        parkingSpots = rentalPricesAndLimitations.Item3;
                        carsPerSpace = rentalPricesAndLimitations.Item4;
                        mcsPerSpace = rentalPricesAndLimitations.Item5;
                        carType = rentalPricesAndLimitations.Item6;
                        motorcycleType = newConfigFileValue.ToString();
                        vehicleSize = rentalPricesAndLimitations.Item8;

                        break;

                    case 8:

                        rentalPriceCar = rentalPricesAndLimitations.Item1;
                        rentalPriceMC = rentalPricesAndLimitations.Item2;
                        parkingSpots = rentalPricesAndLimitations.Item3;
                        carsPerSpace = rentalPricesAndLimitations.Item4;
                        mcsPerSpace = rentalPricesAndLimitations.Item5;
                        carType = rentalPricesAndLimitations.Item6;
                        motorcycleType = rentalPricesAndLimitations.Item7;
                        vehicleSize = newConfigFileValue;

                        break;


                    default:

                        

                        break;

                }

                return (rentalPriceCar, rentalPriceMC, parkingSpots, carsPerSpace, mcsPerSpace, carType, motorcycleType, vehicleSize);

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
