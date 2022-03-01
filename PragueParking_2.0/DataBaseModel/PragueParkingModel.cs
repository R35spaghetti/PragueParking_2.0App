using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PragueParking_2._0.DataBaseModel
{
    public class PragueParkingModel
    {
        [Key]
        public int Id { get; set; }
        public int Place { get; set; }
        public DateTime dateTime { get; set; }
        public string Vehicletype { get; set; }
        
    }
}
