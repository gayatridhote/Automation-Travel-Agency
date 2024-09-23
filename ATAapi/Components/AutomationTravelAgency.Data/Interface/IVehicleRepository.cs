using AutomationTravelAgency.Data.Entity;

namespace AutomationTravelAgency.Data.Interface
{
    public interface IVehicleRepository
    {
        
        public  Task<IEnumerable<Vehicle>> GetVehiclesAsync();
        public  Task<Vehicle?> ViewVehicleAsync(int id);
        public  Task<IEnumerable<Vehicle>> AddVehicleAsync();
        public  Task<IEnumerable<Vehicle>> ModifyVehicleAsync();
        public  Task<IEnumerable<Vehicle>> DeleteVehicleAsync();

        
    }
}