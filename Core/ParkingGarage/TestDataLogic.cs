using GhostSheriffsDatabaseAccess;

namespace Core.ParkingGarage
{
    public class TestDataLogic
    {

        readonly VehicleContext InitializeTestDataDB = new();

        public void CreateTheDB()
        {

            EnsureCreatedDB();
            var isDbEmpty = InitializeTestDataDB.Garage.Where(x => x.Id == 1);
            if (!isDbEmpty.Any())
            {
                GetTestDataForDB();
            }
        }


        public void EnsureCreatedDB()
        {
            InitializeTestDataDB.Database.EnsureCreated();



        }
        public void GetTestDataForDB()
        {
            HandleParkingGarage handleParkingGarage = new();
            string path = @"Initialize.csv";
            string[] listOfVehicles = System.IO.File.ReadAllLines(path);
            var dbData = listOfVehicles.Skip(1).ToList();

            foreach (var item in dbData)
            {
                string[] columns = item.Split(',');

                InitializeTestDataDB.Garage.Add(new VehiclesDB()
                {
                    NumberPlate = columns[0],
                    CheckInTimeStamp = DateTime.Parse(columns[1]),
                    ParkingSpot = int.Parse(columns[2]),
                    VehicleType = columns[3],
                    VehicleSize = int.Parse(columns[4]) 
                });
                InitializeTestDataDB.SaveChanges();
            }
        }
    }
}
