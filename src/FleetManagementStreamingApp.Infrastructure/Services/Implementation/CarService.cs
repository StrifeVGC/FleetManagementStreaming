using AutoMapper;
using FleetManagementStreamingApp.Common.DTOs;
using FleetManagementStreamingApp.Domain.Repos.Contract;
using FleetManagementStreamingApp.Infrastructure.Services.Contract;

namespace FleetManagementStreamingApp.Infrastructure.Services.Implementation
{
    public class CarService : ICarService
    {
        private readonly ICarRepo _carRepo;
        private readonly IMapper _mapper;

        public CarService(ICarRepo carRepo, IMapper mapper)
        {
            _carRepo = carRepo;
            _mapper = mapper;
        }

        public async Task<List<CarDTO>> GetAllCars()
            => _mapper.Map<List<CarDTO>>(await _carRepo.GetAllCars());

        public async Task<CarDTO> GetCarById(string id)
            => _mapper.Map<CarDTO>(await _carRepo.GetCarById(id));
    }
}
