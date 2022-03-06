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
using System.Xml;



//ANVÄND DENNA
//Tuple to get all the json limitation values
(int, int, int, int, int) rentalPricesAndLimitations = (0, 0, 0, 0, 0);
rentalPricesAndLimitations = VehicleContext.GiveParkGarageValuesFromJsonFile(rentalPricesAndLimitations);

Console.WriteLine($"Rental price per hour for car is: {rentalPricesAndLimitations.Item1}\n" +
    $"Rental price per hour for mc is {rentalPricesAndLimitations.Item2} \n" +
    $"Parkingspot limit: {rentalPricesAndLimitations.Item3}\n" +
    $"Amount of cars in the same parking space: {rentalPricesAndLimitations.Item4}\n" +
    $"Amount of MCs in the same parking space: {rentalPricesAndLimitations.Item5}");


//TEST
//VehicleContext.EditTheJson();
//Console.WriteLine("Price value was changed");




VehicleContext context = new();
context.Database.EnsureCreated();
Console.WriteLine("Database is created");


















