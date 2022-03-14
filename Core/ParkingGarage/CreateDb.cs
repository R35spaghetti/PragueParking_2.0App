using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GhostSheriffsDatabaseAccess;

namespace Core.ParkingGarage
{
    public class CreateDb
    {
        public void EnsureCreatedDb()
        {
            VehicleContext buildDb = new();
            buildDb.Database.EnsureCreated();
        }
        public void InitializeDb()
        {
            VehicleContext context = new();
            HandleParkingGarage handleParkingGarage = new();
            string path = @"Initialize.csv";
            string[] listOfVehicles = System.IO.File.ReadAllLines(path);
            var dbData = listOfVehicles.Skip(1).ToList();

            foreach (var item in dbData)
            {
                string[] columns = item.Split(',');

                context.Garage.Add(new VehiclesDB()
                {
                    NumberPlate = columns[0],
                    CheckInTimeStamp = DateTime.Parse(columns[1]),
                    ParkingSpot = int.Parse(columns[2]),
                    VehicleType = columns[3],
                    VehicleSize = int.Parse(columns[4]) 
                });
                context.SaveChanges();
            }
        }
    }
}
