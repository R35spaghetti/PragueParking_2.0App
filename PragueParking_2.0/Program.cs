// See https://aka.ms/new-console-template for more information
using GhostSheriffsDatabaseAccess;
using Microsoft.Extensions.Configuration;
using PragueParking_2._0;
using System.Text.Json;
using System.Linq;
using System.IO;
using System.Text.Json.Serialization;
using System;
using System.Linq;

Console.WriteLine(VehicleContext.ReadParkGaragePrices()); //prints the price from appsettings.JSON
//await VehicleContext.ChangeParkGaragePricesAsync();
//Console.WriteLine(VehicleContext.ReadParkGaragePrices());

//Tuple to get two values
(int, int) rentalPrices = (0,0);
rentalPrices = VehicleContext.GiveParkGaragePrices(rentalPrices);
Console.WriteLine($"New rental price for car is: {rentalPrices.Item1}\n" +
    $"New rental price for mc is {rentalPrices.Item2}");


int getCarPrice = rentalPrices.Item1;
Console.WriteLine(getCarPrice);

//TODO: Fill DB with data from JSON TESTDATA-file (or other)
//TODO: Able to edit json-file (add class)





//Funkar ej
//string[] lines = await File.ReadAllLinesAsync("TESTDATA.json");
//foreach(var line in lines)
//{
//    Console.WriteLine(line);
//}

//await ReadJsonFile();

// async Task ReadJsonFile()
//{
//    string fileName = "TESTDATA.json";
//    using FileStream openStream = File.OpenRead(fileName);
//    Testdata? testdata = 
//        await JsonSerializer.DeserializeAsync<Testdata>(openStream);
//    Console.WriteLine($"Number plate: {testdata?.NumberPlate}");
//    Console.WriteLine($"Time stamp: {testdata?.TimeStamp}");
//    Console.WriteLine($"Parking Spot: {testdata?.ParkingSpot}");
//    Console.WriteLine($"Vehicle Type: {testdata?.VehicleType}");
//}

//Funkar
//VehicleContext context = new();
//context.Database.EnsureCreated();
//Console.WriteLine("Database is created"); 



//Funkar för tysken
//var fileContentTestData = await File.ReadAllTextAsync("TESTDATA.json");
//var vehicles = JsonSerializer.Deserialize<Testdata>(fileContentTestData);

//var vehicleswithdateAfter = vehicles.Where(car => car.TimeStamp == "2022");


