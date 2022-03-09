using Core;
using GhostSheriffsDatabaseAccess;
using System.Globalization;
using System.Text;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;
CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;


string prices = "";
prices = ParkingGarageLimitations.GetRentalPrices(prices);

////TODO Snygga till koden
//int configFileValue = 0;
//int newConfigFileValue = 0;

//int parkingSpots = 0;
//int rentalPriceMC = 0;
//int rentalPriceCar = 0;
//int carsPerSpace = 0;
//int mcsPerSpace = 0;

//    //Get the current values from the ParkingLotLimitationValues-jsonfile
//    (int, int, int, int, int) rentalPricesAndLimitations = (0, 0, 0, 0, 0);
//    rentalPricesAndLimitations = VehicleContext.GiveParkGarageValuesFromJsonFile(rentalPricesAndLimitations);

////UI
//Console.WriteLine($"Rental price per hour for car is: {rentalPricesAndLimitations.Item1}\n" +
//    $"Rental price per hour for mc is {rentalPricesAndLimitations.Item2} \n" +
//    $"Parkingspot limit: {rentalPricesAndLimitations.Item3}\n" +
//    $"Amount of cars in the same parking space: {rentalPricesAndLimitations.Item4}\n" +
//    $"Amount of MCs in the same parking space: {rentalPricesAndLimitations.Item5}");



//Console.WriteLine("1. Edit rental price for Car\n" +
//"2. Edit rental price for MC\n" +
//"3. Edit amount of parking spots\n" +
//"4. Edit amount of cars in the same space\n" +
//"5. Edit amount of mcs in the same space" +
//"");

//       configFileValue = getNewIntValue(configFileValue);

//       //Console.WriteLine("Enter new value");
//       newConfigFileValue = getNewIntValue(newConfigFileValue);


//       rentalPricesAndLimitations = ChangeOneValue(rentalPriceCar, rentalPriceMC, parkingSpots, carsPerSpace, mcsPerSpace);

//       (int, int, int, int, int) ChangeOneValue(int rentalPriceCar, int rentalPriceMC, int parkingSpots, int carsPerSpace, int mcsPerSpace)
//       {
//           switch (configFileValue)
//           {
//               case 1:

//                   rentalPriceCar = newConfigFileValue;
//                   rentalPriceMC = rentalPricesAndLimitations.Item2;
//                   parkingSpots = rentalPricesAndLimitations.Item3;
//                   carsPerSpace = rentalPricesAndLimitations.Item4;
//                   mcsPerSpace = rentalPricesAndLimitations.Item5;

//                   break;

//               case 2:

//                   rentalPriceCar = rentalPricesAndLimitations.Item1;
//                   rentalPriceMC = newConfigFileValue;
//                   parkingSpots = rentalPricesAndLimitations.Item3;
//                   carsPerSpace = rentalPricesAndLimitations.Item4;
//                   mcsPerSpace = rentalPricesAndLimitations.Item5;

//                   break;

//               case 3:

//                   rentalPriceCar = rentalPricesAndLimitations.Item1;
//                   rentalPriceMC = rentalPricesAndLimitations.Item2;
//                   parkingSpots = newConfigFileValue;
//                   carsPerSpace = rentalPricesAndLimitations.Item4;
//                   mcsPerSpace = rentalPricesAndLimitations.Item5;

//                   break;

//               case 4:

//                   rentalPriceCar = rentalPricesAndLimitations.Item1;
//                   rentalPriceMC = rentalPricesAndLimitations.Item2;
//                   parkingSpots = rentalPricesAndLimitations.Item3;
//                   carsPerSpace = newConfigFileValue;
//                   mcsPerSpace = rentalPricesAndLimitations.Item5;

//                   break;

//               case 5:

//                   rentalPriceCar = rentalPricesAndLimitations.Item1;
//                   rentalPriceMC = rentalPricesAndLimitations.Item2;
//                   parkingSpots = rentalPricesAndLimitations.Item3;
//                   carsPerSpace = rentalPricesAndLimitations.Item4;
//                   mcsPerSpace = newConfigFileValue;

//                   break;

//               default:

//                   Console.WriteLine("Enter a value");

//                   break;

//           }

//           return (rentalPriceCar, rentalPriceMC, parkingSpots, carsPerSpace, mcsPerSpace);

//       }
//   }
//   int getNewIntValue(int configFileValue)
//   {
//       string? input = Console.ReadLine();




//       configFileValue = parseIntValue(input);

//       return configFileValue;

//   }

//   int parseIntValue(string? input)
//   {
//       int convertedValue = -1;


//       if (input == null)
//       {

//           Console.WriteLine("value is null");

//       }
//       else
//       {

//           convertedValue = int.Parse(input);

//       }

//       return convertedValue;

//   }

//   /* 1. Hämta nuvarande värden
//   2. bestäm vilket värde som ska ändras och hämta ut ett int värde för switchen
//   3. int värdet bestämmer vilket värde i json-filen som ska ändras
//   4. allt skrivs om på nytt men endast ett värde ändras*/

//   //Update 1 value
//   VehicleContext.EditParkingLotLimitionValues(rentalPricesAndLimitations);
//   Console.WriteLine("Value was changed");


//   //UI
//   Console.WriteLine($"Rental price per hour for car is: {rentalPricesAndLimitations.Item1}\n" +
//$"Rental price per hour for mc is {rentalPricesAndLimitations.Item2} \n" +
//$"Parkingspot limit: {rentalPricesAndLimitations.Item3}\n" +
//$"Amount of cars in the same parking space: {rentalPricesAndLimitations.Item4}\n" +
//$"Amount of MCs in the same parking space: {rentalPricesAndLimitations.Item5}");
