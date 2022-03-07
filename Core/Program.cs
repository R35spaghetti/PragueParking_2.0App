using GhostSheriffsDatabaseAccess;
using System.Globalization;
using System.Text;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;
CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;


//TODO: Lägg i en egen inmatningsmetods
//Hårdkodat, ändras senare
int ParkingSpots = 55;
int rentalPriceMC = 145;
int rentalPriceCar = 53;
int carsPerSpace = 11;
int mcsPerSpace = 22;

/*Hårdkodat för studen, läggs senare in i en switchmeny
 1. Hämta nuvarande värden
2. bestäm vilket värde som ska ändras och hämta ut ett int värde för switchen
3. int värdet bestämmer vilket värde i json-filen som ska ändras
4. allt skrivs om på nytt men endast ett värde ändras*/
VehicleContext.EditParkingLotLimitionValues(ParkingSpots,rentalPriceCar, rentalPriceMC, carsPerSpace, mcsPerSpace);
Console.WriteLine("Value was changed");


//Presenterar värdena
//Tuple to get all the json limitation values
(int, int, int, int, int) rentalPricesAndLimitations = (0, 0, 0, 0, 0);
rentalPricesAndLimitations = VehicleContext.GiveParkGarageValuesFromJsonFile(rentalPricesAndLimitations);

//UI
Console.WriteLine($"Rental price per hour for car is: {rentalPricesAndLimitations.Item1}\n" +
    $"Rental price per hour for mc is {rentalPricesAndLimitations.Item2} \n" +
    $"Parkingspot limit: {rentalPricesAndLimitations.Item3}\n" +
    $"Amount of cars in the same parking space: {rentalPricesAndLimitations.Item4}\n" +
    $"Amount of MCs in the same parking space: {rentalPricesAndLimitations.Item5}");
