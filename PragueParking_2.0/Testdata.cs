
using System.Text.Json;
using System.Text.Json.Serialization;

//Add data from TESTDATA.Json to Database
namespace PragueParking_2._0
{

    public class Testdata
    {


        [JsonPropertyName("Id_NumberPlate")]
        public string NumberPlate { get; set; }

        [JsonPropertyName("CheckInTimeStamp")]
        public DateTime TimeStamp { get; set; }

        [JsonPropertyName("ParkingSpot")]
        public int ParkingSpot { get; set; }

        [JsonPropertyName("VehicleType")]
        public string VehicleType { get; set; }


    }
}
