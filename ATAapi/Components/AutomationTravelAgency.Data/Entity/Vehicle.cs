using System.ComponentModel.DataAnnotations;

namespace AutomationTravelAgency.Data.Entity
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string VehicleNo { get; set; }

        public string VehicleName { get; set; }

        public int SeatingCapacity { get; set; }

        public string DriverId { get; set; }

        public string VehicleType { get; set; }

        public string FarePerKm { get; set; }  
    }
}