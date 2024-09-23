using AutomationTravelAgency.Data.Entity;

namespace AutomationTravelAgency.Business.Interface
{
    public interface IVehicleService
    {
        public Task<IEnumerable<Vehicle>> GetVehiclesAsync();
        public Task<Vehicle?> ViewVehicleAsync(int id);
    }
}