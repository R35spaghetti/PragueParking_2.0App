
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace GhostSheriffsDatabaseAccess
{
    public class Vehicles
    {
        //int ID nyckel?
        //
        [Key]
        [Column("Id_NumberPlate")]
        public string? Id_NumberPlate { get; set; }

        [Column("CheckInTimeStamp")]
        public DateTime? CheckInTimeStamp { get; set; }

        [Column("ParkingSpot")]
        public int ParkingSpot { get; set; }

        //enum till klasserna
        [Column("VehicleType")]
        public string? VehicleType { get; set; }

    }
}
