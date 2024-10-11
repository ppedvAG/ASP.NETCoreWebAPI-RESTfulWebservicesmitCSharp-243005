using Microsoft.EntityFrameworkCore;
using VehicleManagement.Contracts;
using VehicleManagement.Data;
using VehicleManagement.Models;

namespace VehicleManagement.Services
{
    public class VehicleService : IVehicleService
    {
        private readonly VehicleDbContext _context;

        public VehicleService(VehicleDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Auto>> GetVehicles()
        {
            return await _context.Vehicles.ToListAsync();
        }

        public async Task<IEnumerable<Auto>> GetVehiclesByType(string value)
        {
            return await _context.Vehicles.Where(v => v.Type == value).ToListAsync();
        }

        public async Task<IEnumerable<Auto>> GetVehiclesByFuelType(string value)
        {
            return await _context.Vehicles.Where(v => v.Fuel == value).ToListAsync();
        }

        public async Task<IEnumerable<Auto>> GetVehiclesByManufacturer(string value)
        {
            return await _context.Vehicles.Where(v => v.Manufacturer == value).ToListAsync();
        }

        public async Task<Auto?> GetVehicleById(long id)
        {
            return await _context.Vehicles.FindAsync(id);
        }

        public async Task<long> AddVehicle(Auto vehicle)
        {
            _context.Vehicles.Add(vehicle);
            await _context.SaveChangesAsync();
            return vehicle.Id;
        }

        public async Task UpdateVehicle(Auto vehicle)
        {
            _context.Entry(vehicle).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<bool> DeleteVehicle(long id)
        {
            var vehicle = await _context.Vehicles.FindAsync(id);
            if (vehicle != null)
            {
                _context.Vehicles.Remove(vehicle);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}
