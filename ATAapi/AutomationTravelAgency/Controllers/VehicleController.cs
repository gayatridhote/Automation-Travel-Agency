using AutomationTravelAgency.Business.Interface;
using AutomationTravelAgency.Data.Entity;
using Microsoft.AspNetCore.Mvc;

namespace AutomationTravelAgency.Controllers
{
        public class VehicleController : HomeController
    {
        private readonly ILogger<VehicleController> _logger;
        private readonly IVehicleService _vehicleService;

        public VehicleController(ILogger<VehicleController> logger, IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vehicle>>> GetVehicles()
        {
            var vehicles = await _vehicleService.GetVehiclesAsync();
            return Ok(vehicles);
        }

        
        // public async Task<ActionResult<Vehicle>> GetVehicleById(int Id)
        // {

        //     return await  _vehicleService.GetVehicleByIdAsync(Id);

        // }

        public async Task<ActionResult<Vehicle>> AddVehicle()
        {          

            return NotFound();
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<Vehicle>> ViewVehicle(int Id)
        {          
            var vehicle =await  _vehicleService.ViewVehicleAsync(Id);

            if (vehicle == null) return NotFound();

            return Ok(vehicle);
        }

        public async Task<ActionResult<Vehicle>> ModifyVehicle()
        {          

            return Ok();
        }

        public async Task<ActionResult<Vehicle>> DeleteVehicle()
        {          

            return Ok();
        }

    }
}