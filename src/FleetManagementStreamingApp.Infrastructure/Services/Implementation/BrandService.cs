using AutoMapper;
using FleetManagementStreamingApp.Common.DTOs;
using FleetManagementStreamingApp.Domain.Repos.Contract;
using FleetManagementStreamingApp.Infrastructure.Services.Contract;

namespace FleetManagementStreamingApp.Infrastructure.Services.Implementation
{
    public class BrandService : IBrandService
    {
        private readonly IBrandRepo _brandRepo;
        private readonly IMapper _mapper;

        public BrandService(IBrandRepo brandRepo, IMapper mapper)
        {
            _brandRepo = brandRepo;
            _mapper = mapper;
        }

        public async Task<List<BrandDTO>> GetAllBrands()
            => _mapper.Map<List<BrandDTO>>(await _brandRepo.GetAllBrands());

        public async Task<BrandDTO> GetBrandById(string id)
            => _mapper.Map<BrandDTO>(await _brandRepo.GetBrandById(id));
    }
}
