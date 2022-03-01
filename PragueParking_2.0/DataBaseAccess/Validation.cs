using PragueParking_2._0.DataBaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PragueParking_2._0.DataBaseAccess
{
    public class Validation
    {
        public static bool IsDbEmpty()
        {
            var resault = DbInteraction.GetAllDbRecords();
            if (resault.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static PragueParkingModel DbInputData(PragueParkingModel model, List<string[]> values)
        {
            model.dateTime = Convert.ToDateTime(values[0]);
            model.Place = Convert.ToInt32(values[1]);
            model.Vehicletype = Convert.ToString(values[2]);
            return model;
        }
    }
}
