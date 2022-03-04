using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using PragueParking_2._0;
using System.IO;
using System.Text.Json;

namespace GhostSheriffsDatabaseAccess
{
    public class VehicleContext : DbContext
    {

        public DbSet<Vehicles> Vehicles { get; set; } = null!;

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

  

        public static (int,int, int, int, int) GiveParkGarageValuesFromJsonFile((int,int, int, int, int) rentalPricesAndLimitations)
        {
       

            var builder = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            var priceForCar = builder.Build().GetSection("PriceList").GetSection("Per hour for Car").Value;
            var priceForMC = builder.Build().GetSection("PriceList").GetSection("Per hour for MC").Value;
            var parkingSpotLimit = builder.Build().GetSection("AmountOfParkingSpots").GetSection("ParkinSpotLimit").Value;
            var parkedCarsLimit = builder.Build().GetSection("CarsInParkingSpot").GetSection("AmountInSameParkingSpot").Value;
            var parkedMCsLimit = builder.Build().GetSection("MCsInParkingSpot").GetSection("AmountInSameParkingSpot").Value;

            rentalPricesAndLimitations = ApplyTupleValues(priceForCar, priceForMC, parkingSpotLimit, parkedCarsLimit, parkedMCsLimit);


            return rentalPricesAndLimitations;
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

        //Replace Price list?
        public static async Task ChangeParkGaragePricesAsync()
        {
            var newHourlyPrice = new AppsettingsPriceListOptions
            {
                PerHourForCar = 40,
                  PerHourForMC = 20,

              
            };

            string fileName = "appsettings.json";
            using FileStream createStream = File.Create(fileName);
            await JsonSerializer.SerializeAsync(createStream, newHourlyPrice);
            await createStream.DisposeAsync();

            Console.WriteLine(File.ReadAllText(fileName));
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


