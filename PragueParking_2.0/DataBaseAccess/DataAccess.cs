using Microsoft.EntityFrameworkCore;
using PragueParking_2._0.DataBaseModel;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PragueParking_2._0.DataBaseAccess
{
    public class DataAccess : DbContext
    {
        public DbSet<PragueParkingModel> PragueParking { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=GhostSheriffsDb;Integrated Security=True;");
            }

        }
    }
}
