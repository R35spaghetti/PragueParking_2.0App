using System.Text.Json.Serialization;
namespace PragueParking_2._0
{


    public class AppsettingsPriceListOptions
    {

        
        [JsonPropertyName("Per hour for Car")]
        public int PerHourForCar { get; set; }

        [JsonPropertyName("Per hour for MC")]
        public int PerHourForMC { get; set; }

       
    }
}

