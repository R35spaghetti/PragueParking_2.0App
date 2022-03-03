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

   

        //Prints price list values 
        public static string ReadParkGaragePrices()
        {
            var builder = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            var PriceForCar = builder.Build().GetSection("PriceList").GetSection("Per hour for Car").Value;
            var PriceForMC = builder.Build().GetSection("PriceList").GetSection("Per hour for MC").Value;

            return $"Current price per hour for Car: {PriceForCar}\n" +
                $"Current price per hour for MC: {PriceForMC}";
        }


        public static (int,int) GiveParkGaragePrices((int,int) rentalPrices)
        {
         

            var builder = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            var PriceForCar = builder.Build().GetSection("PriceList").GetSection("Per hour for Car").Value;
            var PriceForMC = builder.Build().GetSection("PriceList").GetSection("Per hour for MC").Value;
         int carPrice = int.Parse(PriceForCar);
         int mcPrice = int.Parse(PriceForMC);
            return (carPrice,mcPrice);
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


