using GhostSheriffsDatabaseAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Vehicles
{
    public abstract class Vehicle
    {

        public string? Regnumber { get; protected set; }
        public string VehicleType { get; protected set; } = null!;
        public int VehicleSize { get; protected set; }

        public VehiclesDB GetVehicleData(DateTime checkIn, int parkingSpot, string vehicleType)
        {
            VehiclesDB newVehicleData = new();
            newVehicleData.NumberPlate = this.Regnumber.ToUpper();
            newVehicleData.CheckInTimeStamp = checkIn;
            newVehicleData.ParkingSpot = parkingSpot;
            newVehicleData.VehicleType = vehicleType;
            newVehicleData.VehicleSize = this.VehicleSize;
            return newVehicleData;
            
        }
    }
}
