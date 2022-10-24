using AutoMapper;
using FleetManagementStreamingApp.Common.DTOs;
using FleetManagementStreamingApp.Domain.Models;

namespace FleetManagementStreamingApp.Infrastructure.Profiles
{
    public class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<Brand, BrandDTO>()
                .ReverseMap();
        }
    }
}
