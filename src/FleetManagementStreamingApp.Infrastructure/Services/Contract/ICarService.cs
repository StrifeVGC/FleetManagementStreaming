using FleetManagementStreamingApp.Common.DTOs;

namespace FleetManagementStreamingApp.Infrastructure.Services.Contract
{
    public interface ICarService
    {
        Task<List<CarDTO>> GetAllCars();
        Task<CarDTO> GetCarById(string id);
    }
}