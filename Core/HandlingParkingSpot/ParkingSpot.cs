﻿using GhostSheriffsDatabaseAccess; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.HandlingParkingSpot
{
    public class ParkingSpot
    {
        ParkingGarageLimitations parkingGarageLimitations = new();
        public int numberOfP_spot { get; set; }
        public int P_SpotSize { get; set; }
        public ParkingSpot()// CTOR
        {
            this.numberOfP_spot = GarageSize();
            this.P_SpotSize = ParkingSpotSize(); 
        }

        VehicleContext context = new();

        #region Settings
        public int ParkingSpotSize()
        {

            //json
            var pSizeConfig = parkingGarageLimitations.GetOneIntValueFromJsonFile(10); // Json
            return pSizeConfig;
        }
        public int GarageSize()
        {
            var GarageSizeConfig = parkingGarageLimitations.GetOneIntValueFromJsonFile(3); // Json
            return GarageSizeConfig;
        }
        #endregion

        #region Calculate
        public int CurrentOccupiedPSpace(int parkspot)
        {
            var occupied = context.Garage
                .Where(condition => condition.ParkingSpot == parkspot)
                .Sum(totalSum => totalSum.VehicleSize);// <= ändra här till VehicleSize 
            return occupied;
        }
        public int AllOccupiedPSpace()
        {
            var totalUsedPSpot = context.Garage.Sum(sumOf => sumOf.VehicleSize);// <= ändra här till VehicleSize 
            return totalUsedPSpot;
        }
        public int GarageMaxCapacity()
        {
            int totalAvailable = this.numberOfP_spot * this.P_SpotSize;
            return totalAvailable;
        }
        public bool GarageCapacity(int allOccupiedPSpace, int garageMaxCapacity)
        {
            bool openForBusiness = false;
            if (allOccupiedPSpace <= garageMaxCapacity)
            {
                openForBusiness = true;
            }
            return openForBusiness;
        }
        #endregion
    }
}