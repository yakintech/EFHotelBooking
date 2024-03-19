using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFHotelBooking.Models
{
    public class AcademyHotelContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-EET2RGT;Database=AcademyHotel;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        public DbSet<Room> Rooms { get; set; }
    }
}
