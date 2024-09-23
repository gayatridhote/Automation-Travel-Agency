using AutomationTravelAgency.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace AutomationTravelAgency.Data.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }

        public DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vehicle>().HasData(
                new Vehicle { Id = 1,VehicleNo = "AB 12 CD 3456",VehicleName = "Traveler's Van",
                              SeatingCapacity = 7,DriverId = "1023",VehicleType = "Van" ,FarePerKm = "$0.75" },
                new Vehicle { Id = 2,VehicleNo = "XY 45 EF 6789",VehicleName = "Explorer SUV",
                              SeatingCapacity = 5,DriverId = "2045",VehicleType = "SUV" ,FarePerKm = "$1.00" },
                new Vehicle { Id = 3,VehicleNo = "GH 78 IJ 1234",VehicleName = "Comfort Coach",
                              SeatingCapacity = 50,DriverId = "3456",VehicleType = "Bus" ,FarePerKm = "$0.50" },
                new Vehicle { Id = 4,VehicleNo = "KL 90 MN 5678",VehicleName = "Journey Shuttle",
                              SeatingCapacity = 15,DriverId = "4567",VehicleType = "Minibus" ,FarePerKm = "$0.60" },
                new Vehicle { Id = 5,VehicleNo = "OP 34 QR 9101",VehicleName = "Adventure Wagon",
                              SeatingCapacity = 8,DriverId = "5678",VehicleType = "SUV" ,FarePerKm = "$0.80" },
                new Vehicle { Id = 6,VehicleNo = "ST 56 UV 1213",VehicleName = "Nomad Ride",
                              SeatingCapacity = 4,DriverId = "6789",VehicleType = "Sedan" ,FarePerKm = "$0.90" },
                new Vehicle { Id = 7,VehicleNo = "WX 78 YZ 1415",VehicleName = "Expedition Bus",
                              SeatingCapacity = 40,DriverId = "7890",VehicleType = "Coach" ,FarePerKm = "$0.45" }
            );
        }
    }
}