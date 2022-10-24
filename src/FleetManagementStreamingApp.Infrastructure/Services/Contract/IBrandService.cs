using FleetManagementStreamingApp.Common.DTOs;

namespace FleetManagementStreamingApp.Infrastructure.Services.Contract
{
    public interface IBrandService
    {
        Task<List<BrandDTO>> GetAllBrands();
        Task<BrandDTO> GetBrandById(string id);
    }
}