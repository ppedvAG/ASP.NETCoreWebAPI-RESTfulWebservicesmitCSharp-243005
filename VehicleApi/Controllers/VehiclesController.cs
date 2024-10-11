using Microsoft.AspNetCore.Mvc;
using VehicleApi.Mappers;
using VehicleApi.Models;
using VehicleManagement.Contracts;

namespace VehicleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        private readonly IVehicleService _vehicleService;

        public VehiclesController(IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }

        // GET: api/Vehicles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AutoDto>>> GetVehicles([FromQuery] SearchParams? search)
        {
            if (!string.IsNullOrEmpty(search?.Manufacturer))
            {
                return Ok(await _vehicleService.GetVehiclesByManufacturer(search.Manufacturer));
            }

            if (!string.IsNullOrEmpty(search?.Type))
            {
                return Ok(await _vehicleService.GetVehiclesByType(search.Type));
            }

            if (!string.IsNullOrEmpty(search?.Fuel))
            {
                return Ok(await _vehicleService.GetVehiclesByFuelType(search.Fuel));
            }

            var result = await _vehicleService.GetVehicles();
            return Ok(result.Select(x => x.ToDto()));
        }

        // GET: api/Vehicles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AutoDto>> GetAuto(long id)
        {
            var auto = await _vehicleService.GetVehicleById(id);

            if (auto == null)
            {
                return NotFound();
            }

            return Ok(auto.ToDto());
        }

        // PUT: api/Vehicles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAuto(long id, AutoDto auto)
        {
            // Required Fields und Range validieren
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (await _vehicleService.GetVehicleById(id) == null)
            {
                return NotFound();
            }

            await _vehicleService.UpdateVehicle(auto.ToEntity());
            return NoContent();
        }

        // POST: api/Vehicles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AutoDto>> PostAuto(AutoDto auto)
        {
            // Required Fields und Range validieren
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var id = await _vehicleService.AddVehicle(auto.ToEntity());

            return CreatedAtAction("GetAuto", new { id }, auto);
        }

        // DELETE: api/Vehicles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAuto(long id)
        {
            var result = await _vehicleService.DeleteVehicle(id);
            if (!result)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
