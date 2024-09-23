using AutomationTravelAgency.Data.Data;
using AutomationTravelAgency.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace AutomationTravelAgency.Data.Interface
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly AppDbContext _dbcontext;
        public VehicleRepository(AppDbContext dbcontext)
        {
            _dbcontext = dbcontext;
            
        }
        
        public async Task<IEnumerable<Vehicle>> GetVehiclesAsync()
        {
            return await _dbcontext.Vehicles.ToListAsync();
        }
        public async Task<Vehicle?> ViewVehicleAsync(int id)
        {
            return await _dbcontext.Vehicles.FindAsync(id);
        }

        public Task<IEnumerable<Vehicle>> AddVehicleAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Vehicle>> ModifyVehicleAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Vehicle>> DeleteVehicleAsync()
        {
            throw new NotImplementedException();
        }
    }
}