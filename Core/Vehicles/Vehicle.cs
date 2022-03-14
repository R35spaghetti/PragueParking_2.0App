using DataAccess.DataAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Vehicles
{
    public abstract class Vehicle
    {
       
        public string Regnumber { get; protected set; }
        public string VehicleType { get; protected set; }
        public int VehicleSize { get; protected set; }

        public PTable GetVehicleData(DateTime checkIn, int parkingSpot, string vehicleType)
        {
            PTable newVehicleData = new PTable();
            newVehicleData.NumberPlate = this.Regnumber;
            newVehicleData.CheckInTimeStamp = checkIn;
            newVehicleData.ParkingSpot = parkingSpot;
            newVehicleData.VehicleType = vehicleType;
            newVehicleData.VehicleSize = this.VehicleSize;
            return newVehicleData;
            
        }
    }
}
