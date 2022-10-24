using AutoMapper;
using FleetManagementStreamingApp.Common.DTOs;
using FleetManagementStreamingApp.Domain.Models;

namespace FleetManagementStreamingApp.Infrastructure.Profiles
{
    public class CarProfile : Profile
    {
        public CarProfile()
        {
            CreateMap<Car, CarDTO>()
                .ForMember(dest => dest.BrandName, opts => opts.MapFrom(src => src.CarModel.Brand.Name))
                .ForMember(dest => dest.ModelName, opts => opts.MapFrom(src => src.CarModel.ModelName))
                .ReverseMap();
        }
    }
}
