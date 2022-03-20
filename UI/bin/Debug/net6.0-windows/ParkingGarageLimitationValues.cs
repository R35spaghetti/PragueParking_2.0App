using System.Text.Json.Serialization;
namespace PragueParking_2._0
{

    public class ParkingGarageLimitationValues
    {
        //1
       [JsonPropertyName("Per hour for Car")]
        public int PerHourForCar { get; set; }

        //2
        [JsonPropertyName("Per hour for MC")]
        public int PerHourForMC { get; set; }
      
        //3
        [JsonPropertyName("Parking spots in the garage")]
        public int ParkingSpotsInTheGarage { get; set; }

        //4
        [JsonPropertyName("Vehicle Car")]
        public string? VehicleTypeCar { get; set; }

        //5
        [JsonPropertyName("Vehicle Motorcycle")]
        public string? VehicleTypeMotorcycle { get; set; }

        //6
        [JsonPropertyName("Vehicle Size Car")]
        public int VehicleSizeCar { get; set; }
        
        //7
        [JsonPropertyName("Vehicle Size Motorcycle")]
        public int VehicleSizeMotorcycle { get; set; }

        //8
        [JsonPropertyName("Parking space size")]
        public int ParkingSpaceSize { get; set; }
    }


}

