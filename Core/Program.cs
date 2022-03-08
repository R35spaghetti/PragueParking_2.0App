using GhostSheriffsDatabaseAccess;
using System.Globalization;
using System.Text;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;
CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

int configFileValue = 0;
int newConfigFileValue = 0;
//TODO: Lägg i en egen inmatningsmetods

int parkingSpots = 0;
int rentalPriceMC = 0;
int rentalPriceCar = 0;
int carsPerSpace = 11;
int mcsPerSpace = 22;

//Get the current values from the ParkingLotLimitationValues-jsonfile
(int, int, int, int, int) rentalPricesAndLimitations = (0, 0, 0, 0, 0);
rentalPricesAndLimitations = VehicleContext.GiveParkGarageValuesFromJsonFile(rentalPricesAndLimitations);

(int, int, int, int, int) EditOneValueInJsonValueFile = (0, 0, 0, 0, 0);
EditOneValueInJsonValueFile = ChangeOneValue(rentalPriceCar, rentalPriceMC, parkingSpots, carsPerSpace, mcsPerSpace);

(int, int, int, int, int) ChangeOneValue(int rentalPriceCar, int rentalPriceMC, int parkingSpots, int carsPerSpace, int mcsPerSpace)
{
    switch (configFileValue)
    {
        case 0:

            rentalPriceCar = newConfigFileValue;
            rentalPriceMC = rentalPricesAndLimitations.Item2;
            parkingSpots = rentalPricesAndLimitations.Item3;
            carsPerSpace = rentalPricesAndLimitations.Item4;
            mcsPerSpace = rentalPricesAndLimitations.Item5;

            break;

        case 1:

            rentalPriceCar = rentalPricesAndLimitations.Item1;
            rentalPriceMC = newConfigFileValue;
            parkingSpots = rentalPricesAndLimitations.Item3;
            carsPerSpace = rentalPricesAndLimitations.Item4;
            mcsPerSpace = rentalPricesAndLimitations.Item5;

            break;

        case 2:

            rentalPriceCar = rentalPricesAndLimitations.Item1;
            rentalPriceMC = rentalPricesAndLimitations.Item2;
            parkingSpots = newConfigFileValue;
            carsPerSpace = rentalPricesAndLimitations.Item4;
            mcsPerSpace = rentalPricesAndLimitations.Item5;

            break;

        case 3:

            rentalPriceCar = rentalPricesAndLimitations.Item1;
            rentalPriceMC = rentalPricesAndLimitations.Item2;
            parkingSpots = rentalPricesAndLimitations.Item3;
            carsPerSpace = newConfigFileValue;
            mcsPerSpace = rentalPricesAndLimitations.Item5;

            break;

        case 4:

            rentalPriceCar = rentalPricesAndLimitations.Item1;
            rentalPriceMC = rentalPricesAndLimitations.Item2;
            parkingSpots = rentalPricesAndLimitations.Item3;
            carsPerSpace = rentalPricesAndLimitations.Item4;
            mcsPerSpace = newConfigFileValue;

            break;

        default:

            Console.WriteLine("Enter a value");

            break;

    }

    return (rentalPriceCar, rentalPriceMC, parkingSpots, carsPerSpace, mcsPerSpace);

}



/* 1. Hämta nuvarande värden
2. bestäm vilket värde som ska ändras och hämta ut ett int värde för switchen
3. int värdet bestämmer vilket värde i json-filen som ska ändras
4. allt skrivs om på nytt men endast ett värde ändras*/

//Update 1 value
VehicleContext.EditParkingLotLimitionValues(parkingSpots,rentalPriceCar, rentalPriceMC, carsPerSpace, mcsPerSpace);
Console.WriteLine("Value was changed");


//UI
Console.WriteLine($"Rental price per hour for car is: {rentalPricesAndLimitations.Item1}\n" +
    $"Rental price per hour for mc is {rentalPricesAndLimitations.Item2} \n" +
    $"Parkingspot limit: {rentalPricesAndLimitations.Item3}\n" +
    $"Amount of cars in the same parking space: {rentalPricesAndLimitations.Item4}\n" +
    $"Amount of MCs in the same parking space: {rentalPricesAndLimitations.Item5}");
