﻿
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace GhostSheriffsDatabaseAccess
{
    public class Vehicle
    {
        //Size skulle kanske kunna läggas in..
        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Column("CheckInTimeStamp")]
        public DateTime? CheckInTimeStamp { get; set; }

        [Column("ParkingSpot")]
        public int ParkingSpot { get; set; }

        //enum till klasserna
        [Column("VehicleType")]
        public string? VehicleType { get; set; }

    }
}
