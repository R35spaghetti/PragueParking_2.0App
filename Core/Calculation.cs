using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Calculation
    {

        /// <summary>
        /// Method to calculate price per hour 
        /// </summary>
        /// <param name="vehicle"></param>
        /// <returns>Total price</returns>
        public int priceCalculation(IVehicle vehicle)
        {
            TimeSpan span = DateTime.UtcNow - vehicle.Arrival;

            int totPrice;

            if (span.TotalMinutes < 70)//De första tio minuterna är gratis + 60 minuter är en timme.
            {
                if (vehicle.Type == IVehicle.VehicleType.MC)
                    totPrice = 10;
                else totPrice = 20;
            }
            else
            {
                //uträkning av pris per timme beroende av fordons typ
                int hours;
                if (span.TotalMinutes - 10 % 60 == 0)
                { hours = (int)(span.TotalMinutes - 10) / 60; }
                else
                {
                    hours = (int)(span.TotalMinutes - 10) / 60;
                    hours++;
                }

                if (vehicle.Type == IVehicle.VehicleType.MC)
                    totPrice = hours * 10;
                else totPrice = 20;
            }

            return totPrice;
        }
        
    }
}
