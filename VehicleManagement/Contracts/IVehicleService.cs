using VehicleManagement.Models;

namespace VehicleManagement.Contracts
{
    public interface IVehicleService
    {
        Task<long> AddVehicle(Auto vehicle);
        Task<bool> DeleteVehicle(long id);
        Task<Auto?> GetVehicleById(long id);
        Task<IEnumerable<Auto>> GetVehicles();
        Task<IEnumerable<Auto>> GetVehiclesByType(string value);
        Task<IEnumerable<Auto>> GetVehiclesByFuelType(string value);
        Task<IEnumerable<Auto>> GetVehiclesByManufacturer(string value);
        Task UpdateVehicle(Auto vehicle);
    }
}