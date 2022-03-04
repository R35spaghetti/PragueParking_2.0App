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



//Tuple to get all the json limitation values
(int, int, int, int, int) rentalPricesAndLimitations = (0,0,0,0,0);
rentalPricesAndLimitations = VehicleContext.GiveParkGarageValuesFromJsonFile(rentalPricesAndLimitations);
Console.WriteLine($"Rental price per hour for car is: {rentalPricesAndLimitations.Item1}\n" +
    $"Rental price per hour for mc is {rentalPricesAndLimitations.Item2} \n" +
    $"Parkingspot limit: {rentalPricesAndLimitations.Item3}\n" +
    $"Amount of cars in the same parking space: {rentalPricesAndLimitations.Item4}\n" +
    $"Amount of MCs in the same parking space: {rentalPricesAndLimitations.Item5}");



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


