using AutomationTravelAgency.Data.Entity;
using AutomationTravelAgency.Data.Interface;

namespace AutomationTravelAgency.Business.Interface
{
    public class VehicleService : IVehicleService
    {
        private readonly IVehicleRepository _vehicleRepository;
        public VehicleService(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
            
        }
        public async Task<Vehicle?> ViewVehicleAsync(int id)
        {
            
            return await _vehicleRepository.ViewVehicleAsync(id);
                  
        }

        public async Task<IEnumerable<Vehicle>> GetVehiclesAsync()
        {
            return await _vehicleRepository.GetVehiclesAsync();
        }
    }
}