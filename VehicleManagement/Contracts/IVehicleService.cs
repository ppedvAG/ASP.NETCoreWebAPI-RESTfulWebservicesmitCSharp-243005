using VehicleManagement.Models;

namespace VehicleManagement.Contracts
{
    public interface IVehicleService
    {
        Task AddVehicle(Auto vehicle);
        Task<bool> DeleteVehicle(long id);
        Task<Auto?> GetVehicleById(long id);
        Task<IEnumerable<Auto>> GetVehicles();
        Task UpdateVehicle(Auto vehicle);
    }
}