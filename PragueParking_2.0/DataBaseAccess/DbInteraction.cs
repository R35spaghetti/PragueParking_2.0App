using PragueParking_2._0.DataBaseModel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PragueParking_2._0.DataBaseAccess
{
    public class DbInteraction
    {
        public static void PopulateDb()
        {
            string[] parkingValues = GetParkingValues();

            HashSet<string> exceptions = new HashSet<string>();
            int validRowsCount = 0;
            int exceptionCount = 0;

            using (var context = new DataAccess())
            {
                foreach (var value in parkingValues)
                {
                    PragueParkingModel model = new PragueParkingModel();
                    bool exception = false;

                    try
                    {
                        model.dateTime = Convert.ToDateTime(value[0]);
                        model.Place = Convert.ToInt32(value[1]);
                        model.Vehicletype = Convert.ToString(value[2]);
                    }
                    catch (Exception ex)
                    {
                        exceptions.Add(ex.Message);
                        exception = true;
                        exceptionCount++;
                    }
                    if (exception == false)
                    {
                        try
                        {
                            context.Add(model);
                            validRowsCount++;
                        }
                        catch (Exception ex)
                        {
                            exceptions.Add(ex.Message);
                            exception = true;
                        }
                    }
                }
                context.SaveChanges();
            }

        }

        public static string[] GetParkingValues()
        {            
            return File.ReadAllLines("TestData.csv");
        }

        public static List<PragueParkingModel> GetAllDbRecords()
        {
            using (var context = new DataAccess())
            {
                List<PragueParkingModel> parkingModels = context.PragueParking.ToList();
                return parkingModels;
            }


        }

    }
}