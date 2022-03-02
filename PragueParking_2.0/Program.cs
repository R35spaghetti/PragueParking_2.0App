// See https://aka.ms/new-console-template for more information
using GhostSheriffsDatabaseAccess;

Console.WriteLine("Hello, World!");



//TODO skapa testa och se om testdatan åker in - fler metoder
//TODO JSON för parkeringsplatser, fordonsmodeller, antalet som får sitta i samma plats

VehicleContext context = new();
context.Database.EnsureCreated();