// See https://aka.ms/new-console-template for more information
using GhostSheriffsDatabaseAccess;
using Microsoft.Extensions.Configuration;



Console.WriteLine(VehicleContext.ReadCarParkSettings()); //prints selected value from JSON



//VehicleContext context = new();
//context.Database.EnsureCreated();
//Console.WriteLine("Database is created");

//TODO antingen txt eller json
/* Det skall finnas en prislista i form av en textfil. Filen läses in vid programstart och kan vid 
behov läsas in på nytt via ett menyval. Filen skall gå att ändra även för en med låg ITkunskap, så formatet behöver vara lätt att förstå.
o Bil: 20 CZK per påbörjad timme
o MC: 10 CZK per påbörjad timme
o De första tio minuterna är gratis*/


//TODO: Proper ID for vehicle class
//TODO: Fill DB with data from JSON TESTDATA-file (or other)
//TODO: PriceList txt-file
//TODO: Able to edit json-file (add class)