using FleetManagementStreamingApp.Domain.Models;

namespace FleetManagementStreamingApp.Domain.Repos.Contract
{
    public interface IBrandRepo
    {
        Task<List<Brand>> GetAllBrands();
        Task<Brand> GetBrandById(string id);
    }
}
