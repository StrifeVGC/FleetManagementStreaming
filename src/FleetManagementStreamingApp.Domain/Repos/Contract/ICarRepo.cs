using FleetManagementStreamingApp.Domain.Models;

namespace FleetManagementStreamingApp.Domain.Repos.Contract
{
    public interface ICarRepo
    {
        Task<List<Car>> GetAllCars();
        Task<Car> GetCarById(string id);
    }
}