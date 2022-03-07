using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using PragueParking_2._0;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace GhostSheriffsDatabaseAccess
{
    public class VehicleContext : DbContext
    {

        public DbSet<VehiclesDB> Vehicles { get; set; } = null!;

        public VehicleContext(DbContextOptions<VehicleContext> options) : base(options)
        { }


        public VehicleContext()
        { }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var builder = new ConfigurationBuilder()
                .AddJsonFile($"appsettings.json", true, true);
                string connectionString =
                builder.Build().GetConnectionString("DefaultConnection");
                optionsBuilder.UseSqlServer(connectionString);


            }
        }

  

        public static (int,int, int, int, int) GiveParkGarageValuesFromJsonFile((int,int, int, int, int) rentalPricesAndParkingLimitations)
        {
       

            var builder = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("ParkingLotLimitationValues.json", optional: true, reloadOnChange: true);
            var priceForCar = builder.Build().GetSection("Per hour for Car").Value;
            var priceForMC = builder.Build().GetSection("Per hour for MC").Value;
            var parkingSpotLimit = builder.Build().GetSection("Parking spots in the garage").Value;
            var parkedCarsLimit = builder.Build().GetSection("Cars in the same parking spot").Value;
            var parkedMCsLimit = builder.Build().GetSection("Motorcycles in the same parking spot").Value;

        
            rentalPricesAndParkingLimitations = ApplyTupleValues(priceForCar, priceForMC, parkingSpotLimit, parkedCarsLimit, parkedMCsLimit);


            return rentalPricesAndParkingLimitations;
        }

        private static (int carPrice, int mcPrice, int parkingSpace, int parkedCarsTogether, int parkedMCsTogether) ApplyTupleValues(string priceForCar, string priceForMC, string parkingSpotLimit, string parkedCarsLimit, string parkedMCsLimit)
        {
            int carPrice = int.Parse(priceForCar);
            int mcPrice = int.Parse(priceForMC);
            int parkingSpace = int.Parse(parkingSpotLimit);
            int parkedCarsTogether = int.Parse(parkedCarsLimit);
            int parkedMCsTogether = int.Parse(parkedMCsLimit);

            return (carPrice, mcPrice, parkingSpace, parkedCarsTogether, parkedMCsTogether);
        }

        //TODO lägg in alla nödvändiga värden
        //Måste (just nu) vara AppDomain.CurrentDomain.BaseDirectory så att den skapar en egen json-fil annars kraschar det vid connectionstring, denna mall har ingen connectionstring sträng
        public static void EditParkingLotLimitionValues(int parkingSpots, int rentalPriceCar, int rentalPriceMC, int carsPerSpace, int mcsPerSpace)
        {
           
            //Gets the json-file values
            var config = new ConfigurationBuilder() //Directory.GetCurrentDirectory()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("ParkingLotLimitationValues.json") 
                .Build()
                .Get<ParkingGarageLimitationValues>(); //Gets the class to read the json-file




            //sätter in värden
            config.PerHourForCar = rentalPriceCar;
              config.PerHourForMC= rentalPriceMC;
            config.CarsInTheSameParkingSpot = carsPerSpace;
            config.MotorcyclesInTheSameParkingSpot = mcsPerSpace;
            config.ParkingSpotsInTheGarage = parkingSpots;


            var jsonWriteOptions = new JsonSerializerOptions()
            {
                WriteIndented = true, //beskrivning beskriver sig själv
                
        };

            //tillåter int
           jsonWriteOptions.Converters.Add(new JsonStringEnumConverter());
          
            var addJson = JsonSerializer.Serialize(config, jsonWriteOptions); //skriv utifrån writeoptions och klassens värden

            var AppsettingsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ParkingLotLimitationValues.json"); //vart ska sakerna ligga
            File.WriteAllTextAsync(AppsettingsPath, addJson); //skriv in
                
        }
   



        //Connect to command line app, not needed with ASP
        public class VehicleContextFactory : IDesignTimeDbContextFactory<VehicleContext>
        {
            public VehicleContext CreateDbContext(string[] args)
            {
                var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

                var optionsBuilder = new DbContextOptionsBuilder<VehicleContext>();
                optionsBuilder.UseSqlServer(configuration["ConnectionStrings:DefaultConnection"]);

                return new VehicleContext(optionsBuilder.Options);
            }

        }
    }
}


