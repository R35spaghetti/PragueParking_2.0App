
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace GhostSheriffsDatabaseAccess
{
    [Index(nameof(NumberPlate), IsUnique = true)]
    public class VehiclesDB
    {
      
        [Key]
        public int Id { get; set; }

        [Column("NumberPlate")]
        public string NumberPlate { get; set; }

        [Column("CheckInTimeStamp")]
        public DateTime? CheckInTimeStamp { get; set; }

        [Column("ParkingSpot")]
        public int ParkingSpot { get; set; }

        [Column("VehicleType")]
        public string VehicleType { get; set; }

    }
}
