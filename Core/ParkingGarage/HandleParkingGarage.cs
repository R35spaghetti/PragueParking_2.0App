using DataAccess.DataAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ParkingGarage
{
    public class HandleParkingGarage
    {
        //public DateTime TimeStamp { get; set; }

        PTableContext context = new();

        #region ConditionAndData
        public bool canVehiclePark(int currentUsedPSize, int newVehiclePSize, int sizeOfSelectedPSpot)
        {
            bool allowIt = false;
            if ((currentUsedPSize + newVehiclePSize) <= sizeOfSelectedPSpot)
            {
                allowIt = true;
            }
            return allowIt;
        }
        public List<PTable> SelectVehicle(string searchWord)
        {
            var dbIndexNumber = context.Garage
                .Where(condition => condition.NumberPlate == searchWord)
                .Select(select => select).ToList();
            return dbIndexNumber;
        }
        public bool SearchVehicle(string searchWord)
        {
            var isFound = context.Garage
                .Where(condition => condition.NumberPlate == searchWord)
                .Select(select => select)
                .Any();
            return isFound;
        }
        public int GetVehicleSize(string NumberPlate)
        {
            var vehicleSize = context.Garage
                .Where(condition => condition.NumberPlate == NumberPlate)
                .Select(select => select.VehicleSize)
                .ToList();
            return vehicleSize[0];
        }
        #endregion

        #region ApplyAction
        public void AddVehicleToDb(bool GarageCapacity, bool canVehiclePark, PTable newVehicle)
        {
            if (GarageCapacity)
            {
                if (canVehiclePark)
                {
                    context.Add(newVehicle);
                    context.SaveChanges();
                }
            }
        }
        public void MoveVehicle(bool searchVehicle, bool canVehiclePark, List<PTable> selectVehicle, int newSpot)
        {
            if (searchVehicle)
            {
                if (canVehiclePark)
                {
                    selectVehicle[0].ParkingSpot = newSpot;
                    context.Update(selectVehicle[0]);
                    context.SaveChanges();
                }
            }
        }
        public void RemoveVehicle(bool searchVehicle, List<PTable> selectVehicle)
        {
            if (searchVehicle)
            {
                context.Remove(selectVehicle[0]);
                context.SaveChanges();
            }
        }
        #endregion

        // Json
        public void HandlePrice()
        {
            
        }

    }
}