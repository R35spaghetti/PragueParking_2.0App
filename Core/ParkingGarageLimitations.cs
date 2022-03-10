using GhostSheriffsDatabaseAccess;
using System;

namespace Core
{
    public class ParkingGarageLimitations
    {

        //TODO Snygga till koden
        int newConfigFileValue = 0;

        int parkingSpots = 0;
        int rentalPriceMC = 0;
        int rentalPriceCar = 0;
        int carsPerSpace = 0;
        int mcsPerSpace = 0;
        (int, int, int, int, int) rentalPricesAndLimitations = (0, 0, 0, 0, 0);

        //Gets current car and mc price into a string
        public string GetRentalPrices(string prices)
        {
            //Get the current values from the ParkingLotLimitationValues-jsonfile
            rentalPricesAndLimitations = VehicleContext.GiveParkGarageValuesFromJsonFile(rentalPricesAndLimitations);

            

            prices += "Car rental price:" + " " + rentalPricesAndLimitations.Item1.ToString()+" ";
            prices += "\nMC rental price:" + " " + rentalPricesAndLimitations.Item2.ToString();

            return prices;
        }


        public void SwitchMenuValues(string value, int switchValue)

        {
            
           newConfigFileValue = GetNewIntValue(value);

            //Get the current values from the ParkingLotLimitationValues-jsonfile
            rentalPricesAndLimitations = VehicleContext.GiveParkGarageValuesFromJsonFile(rentalPricesAndLimitations);
            rentalPricesAndLimitations = ChangeOneValue(rentalPriceCar, rentalPriceMC, parkingSpots, carsPerSpace, mcsPerSpace);
            VehicleContext.EditParkingLotLimitionValues(rentalPricesAndLimitations);

            (int, int, int, int, int) ChangeOneValue(int rentalPriceCar, int rentalPriceMC, int parkingSpots, int carsPerSpace, int mcsPerSpace)
            {
                switch (switchValue)
                {
                    case 1:

                        rentalPriceCar = newConfigFileValue;
                        rentalPriceMC = rentalPricesAndLimitations.Item2;
                        parkingSpots = rentalPricesAndLimitations.Item3;
                        carsPerSpace = rentalPricesAndLimitations.Item4;
                        mcsPerSpace = rentalPricesAndLimitations.Item5;

                        break;

                    case 2:

                        rentalPriceCar = rentalPricesAndLimitations.Item1;
                        rentalPriceMC = newConfigFileValue;
                        parkingSpots = rentalPricesAndLimitations.Item3;
                        carsPerSpace = rentalPricesAndLimitations.Item4;
                        mcsPerSpace = rentalPricesAndLimitations.Item5;

                        break;

                    case 3:

                        rentalPriceCar = rentalPricesAndLimitations.Item1;
                        rentalPriceMC = rentalPricesAndLimitations.Item2;
                        parkingSpots = newConfigFileValue;
                        carsPerSpace = rentalPricesAndLimitations.Item4;
                        mcsPerSpace = rentalPricesAndLimitations.Item5;

                        break;

                    case 4:

                        rentalPriceCar = rentalPricesAndLimitations.Item1;
                        rentalPriceMC = rentalPricesAndLimitations.Item2;
                        parkingSpots = rentalPricesAndLimitations.Item3;
                        carsPerSpace = newConfigFileValue;
                        mcsPerSpace = rentalPricesAndLimitations.Item5;

                        break;

                    case 5:

                        rentalPriceCar = rentalPricesAndLimitations.Item1;
                        rentalPriceMC = rentalPricesAndLimitations.Item2;
                        parkingSpots = rentalPricesAndLimitations.Item3;
                        carsPerSpace = rentalPricesAndLimitations.Item4;
                        mcsPerSpace = newConfigFileValue;

                        break;

                    default:


                        break;

                }

                return (rentalPriceCar, rentalPriceMC, parkingSpots, carsPerSpace, mcsPerSpace);

            }
        }

        int GetNewIntValue(string value)
        {

          int configFileValue = ParseIntValue(value);

            return configFileValue;

        }

        int ParseIntValue(string? input)
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
