using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace GhostSheriffsDatabaseAccess
{
    public class VehicleContext : DbContext
    {

        public DbSet<Vehicle> Vehicles { get; set; } = null!;

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

        public static string ReadCarParkSettings()
        {
            var builder = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            var ParkingSpot = builder.Build().GetSection("AmountOfParkingSpots").GetSection("ParkinSpotLimit").Value;

            return $"Parking spots allowed in the parking lot: {ParkingSpot}";
        }
 
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


