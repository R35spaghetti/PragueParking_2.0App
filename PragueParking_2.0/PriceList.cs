using System.Text.Json.Serialization;
namespace PragueParking_2._0
{

    //Funkar trots vad docs hävda
    public class PriceList
    {
       [JsonPropertyName("Per hour for Car")]
        public int PerHourForCar { get; set; }

        [JsonPropertyName("Per hour for MC")]
        public int PerHourForMC { get; set; }
    }
    //Funkar inte enligt docs
    public class ConfigPriceList
    {
        [JsonPropertyName("PriceList")]
        public PriceList? PriceList { get; set; }
      
    }

}

