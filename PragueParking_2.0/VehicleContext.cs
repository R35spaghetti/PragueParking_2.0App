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

        public DbSet<VehiclesDB> Garage { get; set; } = null!;

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

  

        public static (int,int, int, string ,string ,int, int, int) GiveParkGarageValuesFromJsonFile((int,int, int, string, string, int, int, int) rentalPricesAndParkingLimitations)
        {
       

            var builder = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("ParkingLotLimitationValues.json", optional: true, reloadOnChange: true);
            var priceForCar = builder.Build().GetSection("Per hour for Car").Value;
            var priceForMC = builder.Build().GetSection("Per hour for MC").Value;
            var parkingSpotLimit = builder.Build().GetSection("Parking spots in the garage").Value;
            var car = builder.Build().GetSection("Vehicle Car").Value;
            var motorcycle = builder.Build().GetSection("Vehicle Motorcycle").Value;
            var vehicleSizeCar = builder.Build().GetSection("Vehicle Size Car").Value;
            var vehicleSizeMotorcycle = builder.Build().GetSection("Vehicle Size Motorcycle").Value;
            var parkingSpaceSize = builder.Build().GetSection("Parking space size").Value;



            rentalPricesAndParkingLimitations = ApplyTupleValues(priceForCar, priceForMC, parkingSpotLimit, car, motorcycle, vehicleSizeCar, vehicleSizeMotorcycle, parkingSpaceSize);


            return rentalPricesAndParkingLimitations;
        }

        private static (int carPrice, int mcPrice, int parkingSpace, string car, string motorcycle, int vehicleSizeCar, int vehicleSizeMotorcycle, int parkingSpaceSize) ApplyTupleValues(string priceForCar, string priceForMC, string parkingSpotLimit, string car, string motorcycle, string vehicleSizeCar, string vehicleSizeMotorcycle, string parkingSpaceSize)
        {
            int carPrice = int.Parse(priceForCar);
            int mcPrice = int.Parse(priceForMC);
            int parkingSpace = int.Parse(parkingSpotLimit);
            string carType = car;
            string motorcycleType = motorcycle;
            int sizeOfCar = int.Parse(vehicleSizeCar);
            int sizeOfMotorcycle = int.Parse(vehicleSizeMotorcycle);
            int sizeOfParkingSpace = int.Parse(parkingSpaceSize);




            return (carPrice, mcPrice, parkingSpace, carType, motorcycleType, sizeOfCar, sizeOfMotorcycle, sizeOfParkingSpace);
        }

        public static void EditParkingLotLimitionValues((int, int, int, string, string, int, int, int) editOneValueInJsonValueFile)
        {

            //Gets the json-file values
            var config = new ConfigurationBuilder() //AppDomain.CurrentDomain.BaseDirectory
                .SetBasePath(Directory.GetCurrentDirectory()) //Directory.GetCurrentDirectory()
                .AddJsonFile("ParkingLotLimitationValues.json")
                .Build()
                .Get<ParkingGarageLimitationValues>(); //Gets the class to read the json-file




            //sätter in värden
            config.PerHourForCar = editOneValueInJsonValueFile.Item1;
            config.PerHourForMC = editOneValueInJsonValueFile.Item2;
            config.ParkingSpotsInTheGarage = editOneValueInJsonValueFile.Item3;
            config.VehicleTypeCar = editOneValueInJsonValueFile.Item4;
            config.VehicleTypeMotorcycle = editOneValueInJsonValueFile.Item5;
            config.VehicleSizeCar=editOneValueInJsonValueFile.Item6;
            config.VehicleSizeMotorcycle = editOneValueInJsonValueFile.Item7;
            config.ParkingSpaceSize = editOneValueInJsonValueFile.Item8;
            
            var jsonWriteOptions = new JsonSerializerOptions()
            {
                WriteIndented = true, //beskrivning beskriver sig själv

            };

            //tillåter int
            jsonWriteOptions.Converters.Add(new JsonStringEnumConverter());

            var addJson = JsonSerializer.Serialize(config, jsonWriteOptions); //skriv utifrån writeoptions och klassens värden

            var AppsettingsPath = Path.Combine(Directory.GetCurrentDirectory(), "ParkingLotLimitationValues.json"); //vart ska sakerna ligga
            File.WriteAllTextAsync(AppsettingsPath, addJson);
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


