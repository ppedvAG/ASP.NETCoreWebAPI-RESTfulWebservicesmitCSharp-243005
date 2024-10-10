using Microsoft.AspNetCore.Mvc;
using VehicleManagement.Contracts;
using VehicleManagement.Models;

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
        public async Task<ActionResult<IEnumerable<Auto>>> GetVehicles()
        {
            var result = await _vehicleService.GetVehicles();
            return Ok(result);
        }

        // GET: api/Vehicles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Auto>> GetAuto(long id)
        {
            var auto = await _vehicleService.GetVehicleById(id);

            if (auto == null)
            {
                return NotFound();
            }

            return Ok(auto);
        }

        // PUT: api/Vehicles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAuto(long id, Auto auto)
        {
            if (id != auto.Id)
            {
                return BadRequest();
            }

            if (await _vehicleService.GetVehicleById(id) == null)
            {
                return NotFound();
            }

            await _vehicleService.UpdateVehicle(auto);
            return NoContent();
        }

        // POST: api/Vehicles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Auto>> PostAuto(Auto auto)
        {
            await _vehicleService.AddVehicle(auto);

            return CreatedAtAction("GetAuto", new { id = auto.Id }, auto);
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
