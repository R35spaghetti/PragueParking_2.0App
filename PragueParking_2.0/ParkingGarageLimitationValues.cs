﻿using System.Text.Json.Serialization;
namespace PragueParking_2._0
{

    public class ParkingGarageLimitationValues
    {
       [JsonPropertyName("Per hour for Car")]
        public int PerHourForCar { get; set; }

        [JsonPropertyName("Per hour for MC")]
        public int PerHourForMC { get; set; }
      

        [JsonPropertyName("Parking spots in the garage")]
        public int ParkingSpotsInTheGarage { get; set; }

        [JsonPropertyName("Motorcycles in the same parking spot")]
        public int MotorcyclesInTheSameParkingSpot { get; set; }

        [JsonPropertyName("Cars in the same parking spot")]
        public int CarsInTheSameParkingSpot { get; set; }

        [JsonPropertyName("Vehicle Car")]
        public string? VehicleTypeCar { get; set; }

        [JsonPropertyName("Vehicle Motorcycle")]
        public string? VehicleTypeMotorcycle { get; set; }


        [JsonPropertyName("Vehicle Size Car")]
        public int VehicleSizeCar { get; set; }

        [JsonPropertyName("Vehicle Size Motorcycle")]
        public int VehicleSizeMotorcycle { get; set; }

        [JsonPropertyName("Parking space size")]
        public int ParkingSpaceSize { get; set; }
    }


}
