using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class ReadWrite
    {
        public List<IVehicle> ReadDataBase()
        {
            if (!File.Exists("TestData"))
            {
                throw new Exception("TestData file is not found");
            }

            StreamReader sr = new StreamReader("TestData");
            List<IVehicle> Vehicles = new List<IVehicle>();
            string temp = "";
            using (sr)
            {
                temp = sr.ReadLine();
                do
                {
                    Vehicles.Add(FormatOfVehicle(temp));
                    temp = sr.ReadLine();
                } while (temp != null);
            }
            return Vehicles;
        }

        public void WriteDataBase(List<IVehicle> plot)
        {
            if (!File.Exists("TestData"))
            {
                Console.WriteLine("TestData file is not found");
            }
            StreamWriter sw = new StreamWriter("TestData");
            using (sw)
            {
                foreach (IVehicle vehicle in plot)
                {
                    sw.WriteLine(vehicle.ToString());
                }
                sw.Flush();
            }
        }

        private IVehicle FormatOfVehicle(string input)
        {
            string[] regnum = input.Split(',');
            DateTime dateTime = DateTime.Parse(regnum[0]);
            IVehicle.VehicleType type;
            if (regnum[1] == "Car")
            {
                type = IVehicle.VehicleType.Car;
            }
            else if (regnum[1] == "MC")
            {
                type= IVehicle.VehicleType.MC;
            }
            else
            {
                type = IVehicle.VehicleType.Empty;
            }
            IVehicle tempVehicle = new IVehicle(type,regnum[2],dateTime); 
            return tempVehicle;

        }
    }
}
